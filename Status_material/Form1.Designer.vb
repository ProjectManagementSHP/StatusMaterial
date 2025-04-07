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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.txttag = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnasignar = New System.Windows.Forms.Button()
        Me.btnentrada = New System.Windows.Forms.Button()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblPN = New System.Windows.Forms.Label()
        Me.lblBalance = New System.Windows.Forms.Label()
        Me.lblTAG = New System.Windows.Forms.Label()
        Me.textboxUserInputMaterials = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txttag
        '
        Me.txttag.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttag.Location = New System.Drawing.Point(118, 47)
        Me.txttag.Name = "txttag"
        Me.txttag.Size = New System.Drawing.Size(279, 36)
        Me.txttag.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(56, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 33)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "TAG:"
        '
        'btnasignar
        '
        Me.btnasignar.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btnasignar.Enabled = False
        Me.btnasignar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue
        Me.btnasignar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.btnasignar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnasignar.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 16.0!, System.Drawing.FontStyle.Bold)
        Me.btnasignar.ForeColor = System.Drawing.Color.White
        Me.btnasignar.Location = New System.Drawing.Point(55, 320)
        Me.btnasignar.Name = "btnasignar"
        Me.btnasignar.Size = New System.Drawing.Size(100, 39)
        Me.btnasignar.TabIndex = 2
        Me.btnasignar.Text = "Asignar"
        Me.btnasignar.UseVisualStyleBackColor = False
        '
        'btnentrada
        '
        Me.btnentrada.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btnentrada.Enabled = False
        Me.btnentrada.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue
        Me.btnentrada.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.btnentrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnentrada.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 16.0!, System.Drawing.FontStyle.Bold)
        Me.btnentrada.ForeColor = System.Drawing.Color.White
        Me.btnentrada.Location = New System.Drawing.Point(292, 320)
        Me.btnentrada.Name = "btnentrada"
        Me.btnentrada.Size = New System.Drawing.Size(105, 39)
        Me.btnentrada.TabIndex = 3
        Me.btnentrada.Text = "Entrada"
        Me.btnentrada.UseVisualStyleBackColor = False
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.lblStatus.Location = New System.Drawing.Point(120, 130)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(0, 33)
        Me.lblStatus.TabIndex = 4
        '
        'lblPN
        '
        Me.lblPN.AutoSize = True
        Me.lblPN.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblPN.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.lblPN.Location = New System.Drawing.Point(65, 170)
        Me.lblPN.Name = "lblPN"
        Me.lblPN.Size = New System.Drawing.Size(49, 33)
        Me.lblPN.TabIndex = 5
        Me.lblPN.Text = "PN:"
        '
        'lblBalance
        '
        Me.lblBalance.AutoSize = True
        Me.lblBalance.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblBalance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.lblBalance.Location = New System.Drawing.Point(10, 205)
        Me.lblBalance.Name = "lblBalance"
        Me.lblBalance.Size = New System.Drawing.Size(104, 33)
        Me.lblBalance.TabIndex = 6
        Me.lblBalance.Text = "Balance:"
        '
        'lblTAG
        '
        Me.lblTAG.AutoSize = True
        Me.lblTAG.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblTAG.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.lblTAG.Location = New System.Drawing.Point(131, 241)
        Me.lblTAG.Name = "lblTAG"
        Me.lblTAG.Size = New System.Drawing.Size(81, 33)
        Me.lblTAG.TabIndex = 7
        Me.lblTAG.Text = "lblTAG"
        '
        'textboxUserInputMaterials
        '
        Me.textboxUserInputMaterials.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textboxUserInputMaterials.Location = New System.Drawing.Point(118, 88)
        Me.textboxUserInputMaterials.Name = "textboxUserInputMaterials"
        Me.textboxUserInputMaterials.Size = New System.Drawing.Size(279, 36)
        Me.textboxUserInputMaterials.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(15, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 33)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Usuario:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(469, 29)
        Me.Panel1.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(26, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 33)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Status:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(469, 376)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.textboxUserInputMaterials)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblTAG)
        Me.Controls.Add(Me.lblBalance)
        Me.Controls.Add(Me.lblPN)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.btnentrada)
        Me.Controls.Add(Me.btnasignar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txttag)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(485, 415)
        Me.MinimumSize = New System.Drawing.Size(485, 415)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Material Status"
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
    Friend WithEvents textboxUserInputMaterials As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
End Class
