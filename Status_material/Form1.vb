Imports System.Data.SqlClient

Public Class Form1
    Private strCnn As String = "Server=10.17.182.12\SQLEXPRESS2012;Database=SEA;User ID=sa;Password=SHPadmin14%"
    'Private strCnn As String = "Server=10.17.182.36\SQLEXPRESS2012;Database=SEA;User ID=sa;Password=SHPadmin14%"
    'Private strCnn As String = "Server=SHPLAPSIS01\SQLEXPRESS2012; Database=SEA; User ID=sa;Password=SHPadmin14%"
    Private cnn As New SqlConnection(strCnn)

    Private Sub btnasignar_Click(sender As Object, e As EventArgs) Handles btnasignar.Click




        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        UpdateTag(lblTAG.Text, "NoAvailable")
        UpdateUsuarioSalida(lblTAG.Text)
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
    End Sub


    Private Sub TxtNumEmpleado_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNumEmpleado.KeyPress

        If Asc(e.KeyChar) = 13 Then
            BuscarTag(txttag.Text)
        End If

    End Sub



    Private Sub btnentrada_Click(sender As Object, e As EventArgs) Handles btnentrada.Click
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        UpdateTag(lblTAG.Text, "Available")
        UpdateUsuarioEntrada(lblTAG.Text)
        'MessageBox.Show("El Tag solo se puede regresar por la aplicacion", "", MessageBoxButtons.OK)
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub txttag_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txttag.KeyPress
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        If Asc(e.KeyChar) = 13 Then
            BuscarTag(txttag.Text)
            TxtNumEmpleado.Focus()
        End If
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default



    End Sub

    Private Sub txttag_TextChanged(sender As Object, e As EventArgs) Handles txttag.TextChanged
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
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
                    lblTAG.Text = txttag.Text
                    lblStatus.Text = "Status: " + TN.Rows(0).Item("Status").ToString
                    lblPN.Text = "PN: " + TN.Rows(0).Item("PN").ToString
                    lblBalance.Text = "Balance: " + CStr(Math.Round(CDec(Val(TN.Rows(0).Item("Balance").ToString)), 1)) + "   " + TN.Rows(0).Item("Unit").ToString
                    If TN.Rows(0).Item("Status").ToString = "Available" And TxtNumEmpleado.Text <> "" Then
                        btnasignar.Enabled = True
                        btnentrada.Enabled = False
                    ElseIf TN.Rows(0).Item("Status").ToString = "NoAvailable" And TxtNumEmpleado.Text <> "" Then
                        btnasignar.Enabled = False
                        btnentrada.Enabled = True
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
            BuscarTag(txttag.Text)
            txttag.Text = ""
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
            cmd.Parameters.Add("@EmployeeNumber", SqlDbType.NVarChar).Value = TxtNumEmpleado.Text()
            cmd.Parameters.Add("@TAG", SqlDbType.NVarChar).Value = TAG
            cnn.Open()
            cmd.ExecuteNonQuery()
            cnn.Close()
            BuscarTag(txttag.Text)
            txttag.Text = ""
            TxtNumEmpleado.Text = ""
            btnasignar.Enabled = False
            btnentrada.Enabled = False

            txttag.Focus()
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
            cmd.Parameters.Add("@EmployeeNumber", SqlDbType.NVarChar).Value = TxtNumEmpleado.Text()
            cmd.Parameters.Add("@TAG", SqlDbType.NVarChar).Value = TAG
            cnn.Open()
            cmd.ExecuteNonQuery()
            cnn.Close()
            BuscarTag(txttag.Text)
            txttag.Text = ""
            TxtNumEmpleado.Text = ""
            btnasignar.Enabled = False
            btnentrada.Enabled = False

            txttag.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTAG.Text = ""
    End Sub
End Class
