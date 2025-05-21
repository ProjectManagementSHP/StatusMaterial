<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class materialStatus
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(materialStatus))
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
        Me.pictureSHP = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.labelCWO = New System.Windows.Forms.Label()
        Me.textboxCWO = New System.Windows.Forms.TextBox()
        Me.labelArea = New System.Windows.Forms.Label()
        Me.comboboxArea = New System.Windows.Forms.ComboBox()
        Me.panelTOP.SuspendLayout()
        CType(Me.pictureSHP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'textboxTag
        '
        Me.textboxTag.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textboxTag.Location = New System.Drawing.Point(186, 71)
        Me.textboxTag.Name = "textboxTag"
        Me.textboxTag.Size = New System.Drawing.Size(283, 36)
        Me.textboxTag.TabIndex = 0
        '
        'labelTAG
        '
        Me.labelTAG.AutoSize = True
        Me.labelTAG.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20.0!, System.Drawing.FontStyle.Bold)
        Me.labelTAG.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.labelTAG.Location = New System.Drawing.Point(119, 71)
        Me.labelTAG.Name = "labelTAG"
        Me.labelTAG.Size = New System.Drawing.Size(65, 33)
        Me.labelTAG.TabIndex = 1
        Me.labelTAG.Text = "TAG :"
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
        Me.btnasignar.Location = New System.Drawing.Point(55, 451)
        Me.btnasignar.Name = "btnasignar"
        Me.btnasignar.Size = New System.Drawing.Size(111, 39)
        Me.btnasignar.TabIndex = 2
        Me.btnasignar.Text = "ASIGNAR"
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
        Me.btnentrada.Location = New System.Drawing.Point(281, 451)
        Me.btnentrada.Name = "btnentrada"
        Me.btnentrada.Size = New System.Drawing.Size(111, 39)
        Me.btnentrada.TabIndex = 3
        Me.btnentrada.Text = "RECIBIR"
        Me.btnentrada.UseVisualStyleBackColor = False
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.lblStatus.Location = New System.Drawing.Point(120, 263)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(0, 33)
        Me.lblStatus.TabIndex = 4
        '
        'lblPN
        '
        Me.lblPN.AutoSize = True
        Me.lblPN.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblPN.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.lblPN.Location = New System.Drawing.Point(73, 301)
        Me.lblPN.Name = "lblPN"
        Me.lblPN.Size = New System.Drawing.Size(55, 33)
        Me.lblPN.TabIndex = 5
        Me.lblPN.Text = "PN :"
        '
        'lblBalance
        '
        Me.lblBalance.AutoSize = True
        Me.lblBalance.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblBalance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.lblBalance.Location = New System.Drawing.Point(3, 339)
        Me.lblBalance.Name = "lblBalance"
        Me.lblBalance.Size = New System.Drawing.Size(125, 33)
        Me.lblBalance.TabIndex = 6
        Me.lblBalance.Text = "BALANCE :"
        '
        'lblTAG
        '
        Me.lblTAG.AutoSize = True
        Me.lblTAG.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblTAG.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.lblTAG.Location = New System.Drawing.Point(131, 376)
        Me.lblTAG.Name = "lblTAG"
        Me.lblTAG.Size = New System.Drawing.Size(93, 33)
        Me.lblTAG.TabIndex = 7
        Me.lblTAG.Text = "LBLTAG"
        '
        'textboxUserInputMaterials
        '
        Me.textboxUserInputMaterials.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textboxUserInputMaterials.Location = New System.Drawing.Point(186, 113)
        Me.textboxUserInputMaterials.Name = "textboxUserInputMaterials"
        Me.textboxUserInputMaterials.Size = New System.Drawing.Size(283, 36)
        Me.textboxUserInputMaterials.TabIndex = 10
        '
        'labelUser
        '
        Me.labelUser.AutoSize = True
        Me.labelUser.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20.0!, System.Drawing.FontStyle.Bold)
        Me.labelUser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.labelUser.Location = New System.Drawing.Point(68, 113)
        Me.labelUser.Name = "labelUser"
        Me.labelUser.Size = New System.Drawing.Size(116, 33)
        Me.labelUser.TabIndex = 11
        Me.labelUser.Text = "USUARIO :"
        '
        'panelTOP
        '
        Me.panelTOP.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.panelTOP.Controls.Add(Me.pictureSHP)
        Me.panelTOP.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelTOP.Location = New System.Drawing.Point(0, 0)
        Me.panelTOP.Margin = New System.Windows.Forms.Padding(0)
        Me.panelTOP.Name = "panelTOP"
        Me.panelTOP.Size = New System.Drawing.Size(478, 44)
        Me.panelTOP.TabIndex = 12
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(26, 263)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 33)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "STATUS :"
        '
        'labelCWO
        '
        Me.labelCWO.AutoSize = True
        Me.labelCWO.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20.0!, System.Drawing.FontStyle.Bold)
        Me.labelCWO.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.labelCWO.Location = New System.Drawing.Point(2, 201)
        Me.labelCWO.Name = "labelCWO"
        Me.labelCWO.Size = New System.Drawing.Size(182, 33)
        Me.labelCWO.TabIndex = 14
        Me.labelCWO.Text = "PWO/CWO/WIP :"
        '
        'textboxCWO
        '
        Me.textboxCWO.Enabled = False
        Me.textboxCWO.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textboxCWO.Location = New System.Drawing.Point(186, 201)
        Me.textboxCWO.Name = "textboxCWO"
        Me.textboxCWO.Size = New System.Drawing.Size(283, 36)
        Me.textboxCWO.TabIndex = 15
        '
        'labelArea
        '
        Me.labelArea.AutoSize = True
        Me.labelArea.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20.0!, System.Drawing.FontStyle.Bold)
        Me.labelArea.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.labelArea.Location = New System.Drawing.Point(100, 156)
        Me.labelArea.Name = "labelArea"
        Me.labelArea.Size = New System.Drawing.Size(84, 33)
        Me.labelArea.TabIndex = 16
        Me.labelArea.Text = "AREA :"
        '
        'comboboxArea
        '
        Me.comboboxArea.BackColor = System.Drawing.Color.White
        Me.comboboxArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxArea.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 18.0!, System.Drawing.FontStyle.Bold)
        Me.comboboxArea.FormattingEnabled = True
        Me.comboboxArea.Items.AddRange(New Object() {"CORTE", "MP", "Z0", "INVPISO"})
        Me.comboboxArea.Location = New System.Drawing.Point(186, 155)
        Me.comboboxArea.Name = "comboboxArea"
        Me.comboboxArea.Size = New System.Drawing.Size(283, 37)
        Me.comboboxArea.TabIndex = 17
        '
        'materialStatus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(478, 506)
        Me.Controls.Add(Me.comboboxArea)
        Me.Controls.Add(Me.labelArea)
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
        Me.Name = "materialStatus"
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
    Friend WithEvents labelCWO As Label
    Friend WithEvents textboxCWO As TextBox
    Friend WithEvents pictureSHP As PictureBox
    Friend WithEvents labelArea As Label
    Friend WithEvents comboboxArea As ComboBox
    Private WithEvents Label3 As Label
End Class
