Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class materialStatus
    Private strCnn As String = "Server=10.17.182.12\SQLEXPRESS2012;Database=SEA;User ID=sa;Password=SHPadmin14%"
    'Private strCnn As String = "Server=10.17.182.36\SQLEXPRESS2012;Database=SEA;User ID=sa;Password=SHPadmin14%"
    'Private strCnn As String = "Server=SHPLAPSIS01\SQLEXPRESS2012; Database=SEA; User ID=sa;Password=SHPadmin14%"
    Private cnn As New SqlConnection(strCnn)
    Private PN As String
    Private balance As Double


    Private Sub btnasignar_Click(sender As Object, e As EventArgs) Handles btnasignar.Click

        balance = 0

        If String.IsNullOrWhiteSpace(textboxUserInputMaterials.Text) Or String.IsNullOrWhiteSpace(textboxTag.Text) Or String.IsNullOrWhiteSpace(textboxCWO.Text) Or comboboxArea.SelectedIndex = -1 Then

            MessageBox.Show("Llena todos los campos para continuar.", "Material Status", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            textboxUserInputMaterials.Focus()
            Exit Sub

        ElseIf Not validaEmpleado(textboxUserInputMaterials.Text()) Then

            MessageBox.Show("El número de empleado no es válido.", "Material Status", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            textboxUserInputMaterials.Focus()
            Exit Sub

        ElseIf Not textboxCWO.Text.StartsWith("CWO", StringComparison.OrdinalIgnoreCase) And Not textboxCWO.Text.StartsWith("PWO", StringComparison.OrdinalIgnoreCase) And Not textboxCWO.Text.StartsWith("WAA", StringComparison.OrdinalIgnoreCase) Then

            MessageBox.Show("El CWO, PWO o WIP ingresado no es válido.", "Material Status", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            comboboxArea.Focus()
            Exit Sub

        ElseIf Not validateExistencePwoCwoWip(textboxCWO.Text) Then

            MessageBox.Show("El CWO, PWO o WIP ingresado no es existe.", "Material Status", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            comboboxArea.Focus()
            Exit Sub

        ElseIf Not WOContainsPN(textboxCWO.text, lblPN.text.Replace("PN : ", "")) Then

            MessageBox.Show("No es posible asignar al tag debido a que el número de parte [" & lblPN.Text.Replace("PN : ", "") & "] no pertenece al BOM de material de la WO [" & textboxCWO.Text & "]", "Material Status", MessageBoxButtons.OK, MessageBoxIcon.Error)
            comboboxArea.Focus()
            Exit Sub

        Else

            UpdateTag(lblTAG.Text, "NoAvailable")
            RecordMovement("Salida")
            UpdateUsuarioSalida(lblTAG.Text)

        End If


        textboxCWO.Enabled = False

    End Sub


    Private Function WOContainsPN(WO As String, PN As String) As Boolean

        Dim query As String = "SELECT COALESCE(STRING_AGG(AU, ', '), '') AS AU FROM (
                               SELECT DISTINCT AU FROM TBLBOMCWO WHERE CWO = @WO AND PN = @PN AND CWO <> '' AND PN <> '' UNION
                               SELECT DISTINCT AU FROM TBLBOMWIP WHERE WIP = @WO AND PN = @PN AND WIP <> '' AND PN <> '' UNION
                               SELECT DISTINCT AU FROM TBLBOMPWO WHERE PWO = @WO AND PN = @PN AND PWO <> '' AND PN <> '') AS AUS"

        Try
            cnn.Open()
            Dim command As New SqlCommand(query, cnn)
            command.Parameters.AddWithValue("@WO", WO)
            command.Parameters.AddWithValue("@PN", PN)

            Dim reader = command.ExecuteReader()

            If reader.Read() Then

                If Not String.IsNullOrWhiteSpace(reader("AU").ToString()) Then
                    Console.WriteLine("AU: " & reader("AU").ToString())
                    cnn.Close()
                    Return True
                Else
                    cnn.Close()
                    Return False
                End If

            End If
        Catch ex As Exception

            MessageBox.Show("Error al validar el número de parte en la WO: " & ex.Message, "Almacen", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False

        End Try

    End Function

    Private Function validateExistencePwoCwoWip(VALUE As String) As Boolean

        Dim query = "SELECT TOP(1)WIP AS VALUE FROM TBLWIPDET WHERE WIP = @VALUE OR CWO = @VALUE
                     UNION
                     SELECT TOP(1)PWO AS VALUE FROM TBLPWO WHERE PWO = @VALUE"

        Try
            cnn.Open()
            Dim command As New SqlCommand(query, cnn)
            command.Parameters.AddWithValue("@VALUE", VALUE)
            Dim result = command.ExecuteScalar()
            cnn.Close()
            Return result IsNot Nothing
        Catch ex As Exception
            cnn.Close()
            Return False
        End Try


    End Function


    Private Sub RecordMovement(Movement As String)

        Dim query = ""

        If Movement.Equals("Entrada", StringComparison.OrdinalIgnoreCase) Then

            query = "
                    DECLARE @USER NVARCHAR(255);
                    DECLARE @QTYSCANNED DECIMAL(18,2);
                    DECLARE @BALANCE DECIMAL(18,2);
                    SET @USER = (CASE 
                                        WHEN (SELECT COUNT(*) FROM tblEmpleados WHERE EmployeeNumber = @EMPLOYEE) > 0 
                                        THEN (SELECT ISNULL(FirstName, '') + ' ' + ISNULL(MiddleName, '') + ' ' + ISNULL(LastName, '') + ' ' + ISNULL(MaternalLastName, '')
                                            FROM tblEmpleados WHERE EmployeeNumber = @EMPLOYEE) 
                                        ELSE CONCAT('-', @EMPLOYEE)
                                 END);

                    SET @QTYSCANNED = (select COALESCE(SUM(QtyAsigned), 0) AS QtyAsigned from tblBOMWIPRelationsTagsDet WHERE TAG = @TAG AND PN = @PN AND CreatedDate >= (Select TOP(1) DATE from tblWarehouseInOut WHERE TAG = @TAG AND PN = @PN AND TypeOfMovement = 'Salida' ORDER BY DATE DESC))
                    SET @BALANCE = (select COALESCE(balance, 0) as balance from tblItemsTags where tag = @TAG and pn = @PN)
                    INSERT INTO TBLWAREHOUSEINOUT VALUES (@TAG, @PN, @CWO, 0, @QTYSCANNED, @BALANCE, @USER, @TYPEOFMOVEMENT, GETDATE(), @APP, '', '');"

        Else Movement.Equals("Salida", StringComparison.OrdinalIgnoreCase)

            query = "
                    DECLARE @USER NVARCHAR(255);
                    DECLARE @AU NVARCHAR(255);
                    DECLARE @BALANCE DECIMAL(18,2);

                    SET @USER = (CASE 
                                        WHEN (SELECT COUNT(*) FROM tblEmpleados WHERE EmployeeNumber = @EMPLOYEE) > 0 
                                        THEN (SELECT ISNULL(FirstName, '') + ' ' + ISNULL(MiddleName, '') + ' ' + ISNULL(LastName, '') + ' ' + ISNULL(MaternalLastName, '')
                                            FROM tblEmpleados WHERE EmployeeNumber = @EMPLOYEE) 
                                        ELSE CONCAT('-', @EMPLOYEE)
                                 END);
                    SET @BALANCE = (select COALESCE(balance, 0) as balance from tblItemsTags where tag = @TAG and pn = @PN)

                    SELECT @AU = COALESCE(STRING_AGG(AU, ', '), '') FROM (
                               SELECT DISTINCT AU FROM TBLBOMCWO WHERE CWO = @WO AND PN = @PN AND CWO <> '' AND PN <> '' UNION
                               SELECT DISTINCT AU FROM TBLBOMWIP WHERE WIP = @WO AND PN = @PN AND WIP <> '' AND PN <> '' UNION
                               SELECT DISTINCT AU FROM TBLBOMPWO WHERE PWO = @WO AND PN = @PN AND PWO <> '' AND PN <> '') AS AUS

                    INSERT INTO TBLWAREHOUSEINOUT VALUES (@TAG, @PN, @CWO, @QTYASIGNED, 0, @BALANCE, @USER, @TYPEOFMOVEMENT, GETDATE(), @APP, @AREA, @AU);
"

        End If



        Try
            cnn.Open()

            Dim command As New SqlCommand(query, cnn)
            command.Parameters.AddWithValue("@TAG", lblTAG.Text.ToUpper())
            command.Parameters.AddWithValue("@PN", PN.ToUpper())

            If Movement.Equals("Entrada", StringComparison.OrdinalIgnoreCase) Then

                command.Parameters.AddWithValue("@CWO", "")

            ElseIf Movement.Equals("Salida", StringComparison.OrdinalIgnoreCase) Then

                command.Parameters.AddWithValue("@WO", textboxCWO.Text)
                command.Parameters.AddWithValue("@CWO", clearString(textboxCWO.Text))
                command.Parameters.AddWithValue("@QTYASIGNED", balance)
                command.Parameters.AddWithValue("@AREA", comboboxArea.SelectedItem.ToString())

            End If

            command.Parameters.AddWithValue("@TYPEOFMOVEMENT", Movement.ToUpper())
            command.Parameters.AddWithValue("@EMPLOYEE", textboxUserInputMaterials.Text)
            command.Parameters.AddWithValue("@APP", "Status material".ToUpper())

            command.ExecuteNonQuery()




        Catch ex As Exception

            MessageBox.Show("Error al guardar el registro en la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Console.WriteLine(ex.ToString)

        End Try

        cnn.Close()

    End Sub


    Private Function clearString(value As String) As String
        value = Regex.Replace(value, "[^a-zA-Z0-9\-]", "").ToUpper()
        Return value
    End Function





    Private Function validaEmpleado(EmployeeNumber As String) As Boolean
        Dim query = "SELECT COUNT(*) AS EXISTE from tblEmpleados where EmployeeNumber = @EmployeeNumber"
        Dim exists = False

        Try
            cnn.Open()
            Dim command As New SqlCommand(query, cnn)
            command.Parameters.AddWithValue("@EmployeeNumber", EmployeeNumber)
            Dim result As Object = command.ExecuteScalar()

            If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                If Convert.ToInt32(result) > 0 Then
                    exists = True
                End If
            End If


        Catch ex As Exception

        End Try

        cnn.Close()
        Return exists
    End Function



    Private Sub TxtNumEmpleado_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textboxUserInputMaterials.KeyPress

        If Asc(e.KeyChar) = 13 Then
            BuscarTag(textboxTag.Text)
            comboboxArea.Focus()
        End If

        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True

        End If


    End Sub



    Private Sub btnentrada_Click(sender As Object, e As EventArgs) Handles btnentrada.Click

        balance = 0

        If String.IsNullOrWhiteSpace(textboxUserInputMaterials.Text) Or String.IsNullOrWhiteSpace(textboxTag.Text) Then

            MessageBox.Show("Llena todos los campos para continuar.", "Material Status", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            textboxUserInputMaterials.Focus()
            Exit Sub

        ElseIf Not validaEmpleado(textboxUserInputMaterials.Text()) Then

            MessageBox.Show("El número de empleado no es válido.", "Material Status", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            textboxUserInputMaterials.Focus()
            Exit Sub

        Else


            UpdateTag(lblTAG.Text, "Available")
            RecordMovement("Entrada")
            UpdateUsuarioEntrada(lblTAG.Text)

        End If

        textboxCWO.Enabled = False

    End Sub

    Private Sub txttag_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textboxTag.KeyPress
        If Asc(e.KeyChar) = 13 Then
            BuscarTag(textboxTag.Text)
            textboxUserInputMaterials.Focus()
        End If

        If Not Char.IsLetterOrDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txttag_TextChanged(sender As Object, e As EventArgs) Handles textboxTag.TextChanged
        textboxTag.Text = textboxTag.Text.ToUpper()
        textboxTag.SelectionStart = textboxTag.Text.Length
    End Sub

    Private Sub BuscarTag(ByVal TAG As String)
        Using TN As New DataTable
            Dim Edo As String = ""
            Try 'Query para encontrar los BOM que no se han usado
                Dim cmd As SqlCommand
                Dim dr As SqlDataReader
                Dim Query As String = "SELECT * FROM tblItemsTags WHERE TAG=@TAG "
                cmd = New SqlCommand(Query, cnn)
                cmd.CommandType = CommandType.Text
                cmd.Parameters.Add("@TAG", SqlDbType.NVarChar).Value = TAG
                'cmd.Parameters.Add("@Hasta", SqlDbType.NVarChar).Value = Hasta
                cnn.Open()
                dr = cmd.ExecuteReader
                TN.Load(dr)
                cnn.Close()
                If TN.Rows.Count > 0 Then
                    lblTAG.Text = textboxTag.Text
                    lblStatus.Text = TN.Rows(0).Item("Status").ToString
                    lblPN.Text = "PN : " + TN.Rows(0).Item("PN").ToString
                    PN = TN.Rows(0).Item("PN").ToString
                    lblBalance.Text = "BALANCE : " + CStr(Math.Round(CDec(Val(TN.Rows(0).Item("Balance").ToString)), 1)) + "   " + TN.Rows(0).Item("Unit").ToString
                    balance = CStr(Math.Round(CDec(Val(TN.Rows(0).Item("Balance").ToString)), 1))
                    If TN.Rows(0).Item("Status").ToString = "Available" And textboxUserInputMaterials.Text <> "" Then
                        btnasignar.Enabled = True
                        btnentrada.Enabled = False
                        textboxCWO.Enabled = True
                    ElseIf TN.Rows(0).Item("Status").ToString = "NoAvailable" And textboxUserInputMaterials.Text <> "" Then
                        btnasignar.Enabled = False
                        btnentrada.Enabled = True
                        textboxCWO.Enabled = False
                    End If
                End If
            Catch ex As Exception
                Edo = cnn.State.ToString
                If Edo = "Open" Then cnn.Close()
                MessageBox.Show(ex.Message + vbNewLine + "Error Loading SearchingTags", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub UpdateTag(ByVal TAG As String, ByVal Estatus As String)
        Try
            Dim query As String = "UPDATE tblItemsTags SET Status=@Status, InDate = GETDATE() WHERE TAG = @TAG "
            If Estatus = "Available" Then
                query = "UPDATE tblItemsTags SET Status=@Status, InDate=GETDATE(), OutDate=NULL WHERE TAG=@TAG "
            ElseIf Estatus = "NoAvailable" Then
                query = "UPDATE tblItemsTags SET Status=@Status, OutDate=GETDATE() WHERE TAG=@TAG "
            End If
            Dim cmd = New SqlCommand(query, cnn)
            cmd.CommandType = CommandType.Text
            cmd.Parameters.Add("@Status", SqlDbType.NVarChar).Value = Estatus
            cmd.Parameters.Add("@TAG", SqlDbType.NVarChar).Value = TAG
            cnn.Open()
            cmd.ExecuteNonQuery()
            cnn.Close()
            BuscarTag(textboxTag.Text)
            textboxTag.Text = ""
            btnasignar.Enabled = False
            btnentrada.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Private Sub UpdateUsuarioSalida(ByVal TAG As String)
        Try





            Dim query As String = "UPDATE tblitemstags " &
                      "SET SalidaUsuario = (CASE " &
                      "                         WHEN (SELECT COUNT(*) FROM tblEmpleados WHERE EmployeeNumber = @EmployeeNumber) > 0 " &
                      "                         THEN (SELECT FirstName + ' ' + MiddleName + ' ' + LastName + ' ' + MaternalLastName " &
                      "                               FROM tblEmpleados WHERE EmployeeNumber = @EmployeeNumber) " &
                      "                         ELSE @EmployeeNumber " &
                      "                     END) " &
                      "WHERE tag = @tag"



            Dim cmd = New SqlCommand(query, cnn)
            cmd.CommandType = CommandType.Text
            cmd.Parameters.Add("@EmployeeNumber", SqlDbType.NVarChar).Value = textboxUserInputMaterials.Text()
            cmd.Parameters.Add("@TAG", SqlDbType.NVarChar).Value = TAG
            cnn.Open()
            cmd.ExecuteNonQuery()
            cnn.Close()
            BuscarTag(textboxTag.Text)
            textboxTag.Text = ""
            textboxUserInputMaterials.Text = ""
            textboxCWO.Text = ""
            comboboxArea.SelectedIndex = -1
            btnasignar.Enabled = False
            btnentrada.Enabled = False

            textboxTag.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub UpdateUsuarioEntrada(ByVal TAG As String)
        Try





            Dim query As String = "UPDATE tblitemstags " &
                      "SET EntradaUsuario = (CASE " &
                      "                         WHEN (SELECT COUNT(*) FROM tblEmpleados WHERE EmployeeNumber = @EmployeeNumber) > 0 " &
                      "                         THEN (SELECT FirstName + ' ' + MiddleName + ' ' + LastName + ' ' + MaternalLastName " &
                      "                               FROM tblEmpleados WHERE EmployeeNumber = @EmployeeNumber) " &
                      "                         ELSE @EmployeeNumber " &
                      "                     END) " &
                      "WHERE tag = @tag"



            Dim cmd = New SqlCommand(query, cnn)
            cmd.CommandType = CommandType.Text
            cmd.Parameters.Add("@EmployeeNumber", SqlDbType.NVarChar).Value = textboxUserInputMaterials.Text()
            cmd.Parameters.Add("@TAG", SqlDbType.NVarChar).Value = TAG
            cnn.Open()
            cmd.ExecuteNonQuery()
            cnn.Close()
            BuscarTag(textboxTag.Text)
            textboxTag.Text = ""
            textboxUserInputMaterials.Text = ""
            textboxCWO.Text = ""
            btnasignar.Enabled = False
            btnentrada.Enabled = False

            textboxTag.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTAG.Text = ""
    End Sub

    Private Sub lblStatus_TextChanged(sender As Object, e As EventArgs) Handles lblStatus.TextChanged

        If lblStatus.Text.Contains("NoAvailable") Then
            lblStatus.BackColor = Color.Firebrick
            lblStatus.ForeColor = Color.White
        ElseIf lblStatus.Text.Contains("Available") Then
            lblStatus.BackColor = Color.DarkGreen
            lblStatus.ForeColor = Color.White
        End If
    End Sub

    Private Sub textboxCWO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textboxCWO.KeyPress

        If Asc(e.KeyChar) = 13 Then
            BuscarTag(textboxTag.Text)
        End If

        If e.KeyChar = "'"c Then
            textboxCWO.Text = textboxCWO.Text + "-"
        End If

        If Not Char.IsLetterOrDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso e.KeyChar <> "-"c Then
            e.Handled = True
        End If

    End Sub

    Private Sub textboxCWO_TextChanged(sender As Object, e As EventArgs) Handles textboxCWO.TextChanged
        textboxCWO.Text = textboxCWO.Text.ToUpper()
        textboxCWO.SelectionStart = textboxCWO.Text.Length
    End Sub
End Class
