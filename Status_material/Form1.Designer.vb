<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txttag = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnasignar = New System.Windows.Forms.Button()
        Me.btnentrada = New System.Windows.Forms.Button()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblPN = New System.Windows.Forms.Label()
        Me.lblBalance = New System.Windows.Forms.Label()
        Me.lblTAG = New System.Windows.Forms.Label()
        Me.TxtNumEmpleado = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txttag
        '
        Me.txttag.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttag.Location = New System.Drawing.Point(157, 18)
        Me.txttag.Margin = New System.Windows.Forms.Padding(4)
        Me.txttag.Name = "txttag"
        Me.txttag.Size = New System.Drawing.Size(295, 34)
        Me.txttag.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(67, 21)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 31)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "TAG:"
        '
        'btnasignar
        '
        Me.btnasignar.Enabled = False
        Me.btnasignar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnasignar.Location = New System.Drawing.Point(73, 369)
        Me.btnasignar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnasignar.Name = "btnasignar"
        Me.btnasignar.Size = New System.Drawing.Size(133, 48)
        Me.btnasignar.TabIndex = 2
        Me.btnasignar.Text = "Asignar"
        Me.btnasignar.UseVisualStyleBackColor = True
        '
        'btnentrada
        '
        Me.btnentrada.Enabled = False
        Me.btnentrada.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnentrada.Location = New System.Drawing.Point(389, 369)
        Me.btnentrada.Margin = New System.Windows.Forms.Padding(4)
        Me.btnentrada.Name = "btnentrada"
        Me.btnentrada.Size = New System.Drawing.Size(140, 48)
        Me.btnentrada.TabIndex = 3
        Me.btnentrada.Text = "Entrada"
        Me.btnentrada.UseVisualStyleBackColor = True
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(76, 119)
        Me.lblStatus.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(100, 31)
        Me.lblStatus.TabIndex = 4
        Me.lblStatus.Text = "Status:"
        '
        'lblPN
        '
        Me.lblPN.AutoSize = True
        Me.lblPN.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPN.Location = New System.Drawing.Point(117, 161)
        Me.lblPN.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPN.Name = "lblPN"
        Me.lblPN.Size = New System.Drawing.Size(60, 31)
        Me.lblPN.TabIndex = 5
        Me.lblPN.Text = "PN:"
        '
        'lblBalance
        '
        Me.lblBalance.AutoSize = True
        Me.lblBalance.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBalance.Location = New System.Drawing.Point(53, 203)
        Me.lblBalance.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBalance.Name = "lblBalance"
        Me.lblBalance.Size = New System.Drawing.Size(120, 31)
        Me.lblBalance.TabIndex = 6
        Me.lblBalance.Text = "Balance:"
        '
        'lblTAG
        '
        Me.lblTAG.AutoSize = True
        Me.lblTAG.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTAG.Location = New System.Drawing.Point(175, 245)
        Me.lblTAG.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTAG.Name = "lblTAG"
        Me.lblTAG.Size = New System.Drawing.Size(97, 31)
        Me.lblTAG.TabIndex = 7
        Me.lblTAG.Text = "lblTAG"
        '
        'TxtNumEmpleado
        '
        Me.TxtNumEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNumEmpleado.Location = New System.Drawing.Point(157, 66)
        Me.TxtNumEmpleado.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtNumEmpleado.Name = "TxtNumEmpleado"
        Me.TxtNumEmpleado.Size = New System.Drawing.Size(295, 34)
        Me.TxtNumEmpleado.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(28, 66)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 31)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Usuario:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(621, 459)
        Me.Controls.Add(Me.TxtNumEmpleado)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblTAG)
        Me.Controls.Add(Me.lblBalance)
        Me.Controls.Add(Me.lblPN)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.btnentrada)
        Me.Controls.Add(Me.btnasignar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txttag)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Cambia Estatus del Material"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txttag As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnasignar As Button
    Friend WithEvents btnentrada As Button
    Friend WithEvents lblStatus As Label
    Friend WithEvents lblPN As Label
    Friend WithEvents lblBalance As Label
    Friend WithEvents lblTAG As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtNumEmpleado As TextBox
End Class
