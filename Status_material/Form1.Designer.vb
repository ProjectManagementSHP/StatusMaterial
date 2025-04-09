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
        Me.textboxTag = New System.Windows.Forms.TextBox()
        Me.labelTAG = New System.Windows.Forms.Label()
        Me.btnasignar = New System.Windows.Forms.Button()
        Me.btnentrada = New System.Windows.Forms.Button()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblPN = New System.Windows.Forms.Label()
        Me.lblBalance = New System.Windows.Forms.Label()
        Me.lblTAG = New System.Windows.Forms.Label()
        Me.textboxUserInputMaterials = New System.Windows.Forms.TextBox()
        Me.labelUser = New System.Windows.Forms.Label()
        Me.panelTOP = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.labelCWO = New System.Windows.Forms.Label()
        Me.textboxCWO = New System.Windows.Forms.TextBox()
        Me.pictureSHP = New System.Windows.Forms.PictureBox()
        Me.panelTOP.SuspendLayout()
        CType(Me.pictureSHP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'textboxTag
        '
        Me.textboxTag.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textboxTag.Location = New System.Drawing.Point(118, 69)
        Me.textboxTag.Name = "textboxTag"
        Me.textboxTag.Size = New System.Drawing.Size(279, 36)
        Me.textboxTag.TabIndex = 0
        '
        'labelTAG
        '
        Me.labelTAG.AutoSize = True
        Me.labelTAG.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20.0!, System.Drawing.FontStyle.Bold)
        Me.labelTAG.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.labelTAG.Location = New System.Drawing.Point(56, 69)
        Me.labelTAG.Name = "labelTAG"
        Me.labelTAG.Size = New System.Drawing.Size(58, 33)
        Me.labelTAG.TabIndex = 1
        Me.labelTAG.Text = "TAG:"
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
        Me.btnasignar.Location = New System.Drawing.Point(55, 402)
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
        Me.btnentrada.Location = New System.Drawing.Point(292, 402)
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
        Me.lblStatus.Location = New System.Drawing.Point(120, 212)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(0, 33)
        Me.lblStatus.TabIndex = 4
        '
        'lblPN
        '
        Me.lblPN.AutoSize = True
        Me.lblPN.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblPN.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.lblPN.Location = New System.Drawing.Point(65, 252)
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
        Me.lblBalance.Location = New System.Drawing.Point(10, 287)
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
        Me.lblTAG.Location = New System.Drawing.Point(131, 323)
        Me.lblTAG.Name = "lblTAG"
        Me.lblTAG.Size = New System.Drawing.Size(81, 33)
        Me.lblTAG.TabIndex = 7
        Me.lblTAG.Text = "lblTAG"
        '
        'textboxUserInputMaterials
        '
        Me.textboxUserInputMaterials.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textboxUserInputMaterials.Location = New System.Drawing.Point(118, 110)
        Me.textboxUserInputMaterials.Name = "textboxUserInputMaterials"
        Me.textboxUserInputMaterials.Size = New System.Drawing.Size(279, 36)
        Me.textboxUserInputMaterials.TabIndex = 10
        '
        'labelUser
        '
        Me.labelUser.AutoSize = True
        Me.labelUser.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20.0!, System.Drawing.FontStyle.Bold)
        Me.labelUser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.labelUser.Location = New System.Drawing.Point(15, 110)
        Me.labelUser.Name = "labelUser"
        Me.labelUser.Size = New System.Drawing.Size(99, 33)
        Me.labelUser.TabIndex = 11
        Me.labelUser.Text = "Usuario:"
        '
        'panelTOP
        '
        Me.panelTOP.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.panelTOP.Controls.Add(Me.pictureSHP)
        Me.panelTOP.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelTOP.Location = New System.Drawing.Point(0, 0)
        Me.panelTOP.Margin = New System.Windows.Forms.Padding(0)
        Me.panelTOP.Name = "panelTOP"
        Me.panelTOP.Size = New System.Drawing.Size(469, 44)
        Me.panelTOP.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(26, 212)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 33)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Status:"
        '
        'labelCWO
        '
        Me.labelCWO.AutoSize = True
        Me.labelCWO.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20.0!, System.Drawing.FontStyle.Bold)
        Me.labelCWO.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.labelCWO.Location = New System.Drawing.Point(47, 152)
        Me.labelCWO.Name = "labelCWO"
        Me.labelCWO.Size = New System.Drawing.Size(67, 33)
        Me.labelCWO.TabIndex = 14
        Me.labelCWO.Text = "CWO:"
        '
        'textboxCWO
        '
        Me.textboxCWO.Enabled = False
        Me.textboxCWO.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textboxCWO.Location = New System.Drawing.Point(118, 152)
        Me.textboxCWO.Name = "textboxCWO"
        Me.textboxCWO.Size = New System.Drawing.Size(279, 36)
        Me.textboxCWO.TabIndex = 15
        '
        'pictureSHP
        '
        Me.pictureSHP.Dock = System.Windows.Forms.DockStyle.Left
        Me.pictureSHP.Image = CType(resources.GetObject("pictureSHP.Image"), System.Drawing.Image)
        Me.pictureSHP.InitialImage = CType(resources.GetObject("pictureSHP.InitialImage"), System.Drawing.Image)
        Me.pictureSHP.Location = New System.Drawing.Point(0, 0)
        Me.pictureSHP.Name = "pictureSHP"
        Me.pictureSHP.Size = New System.Drawing.Size(100, 44)
        Me.pictureSHP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureSHP.TabIndex = 0
        Me.pictureSHP.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(469, 506)
        Me.Controls.Add(Me.textboxCWO)
        Me.Controls.Add(Me.labelCWO)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.panelTOP)
        Me.Controls.Add(Me.textboxUserInputMaterials)
        Me.Controls.Add(Me.labelUser)
        Me.Controls.Add(Me.lblTAG)
        Me.Controls.Add(Me.lblBalance)
        Me.Controls.Add(Me.lblPN)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.btnentrada)
        Me.Controls.Add(Me.btnasignar)
        Me.Controls.Add(Me.labelTAG)
        Me.Controls.Add(Me.textboxTag)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(485, 415)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Material Status"
        Me.panelTOP.ResumeLayout(False)
        CType(Me.pictureSHP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents textboxTag As TextBox
    Friend WithEvents labelTAG As Label
    Friend WithEvents btnasignar As Button
    Friend WithEvents btnentrada As Button
    Friend WithEvents lblStatus As Label
    Friend WithEvents lblPN As Label
    Friend WithEvents lblBalance As Label
    Friend WithEvents lblTAG As Label
    Friend WithEvents labelUser As Label
    Friend WithEvents textboxUserInputMaterials As TextBox
    Friend WithEvents panelTOP As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents labelCWO As Label
    Friend WithEvents textboxCWO As TextBox
    Friend WithEvents pictureSHP As PictureBox
End Class
