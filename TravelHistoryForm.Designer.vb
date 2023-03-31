<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TravelHistoryForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TravelHistoryForm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.radioClose1 = New System.Windows.Forms.RadioButton()
        Me.radioClose2 = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radioCountry1 = New System.Windows.Forms.RadioButton()
        Me.radioCountry2 = New System.Windows.Forms.RadioButton()
        Me.btnBackTravel = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.btnNextTravel = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OPENToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SAVEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EXITToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(782, 82)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Impact", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(194, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(359, 53)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Travel History Form"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.GroupBox2)
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Controls.Add(Me.btnBackTravel)
        Me.Panel2.Controls.Add(Me.ComboBox1)
        Me.Panel2.Controls.Add(Me.btnNextTravel)
        Me.Panel2.Controls.Add(Me.TextBox2)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.CheckBox4)
        Me.Panel2.Controls.Add(Me.CheckBox3)
        Me.Panel2.Controls.Add(Me.CheckBox2)
        Me.Panel2.Controls.Add(Me.CheckBox1)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Location = New System.Drawing.Point(0, 112)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(782, 423)
        Me.Panel2.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.radioClose1)
        Me.GroupBox2.Controls.Add(Me.radioClose2)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 174)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(120, 43)
        Me.GroupBox2.TabIndex = 40
        Me.GroupBox2.TabStop = False
        '
        'radioClose1
        '
        Me.radioClose1.AutoSize = True
        Me.radioClose1.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.radioClose1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.radioClose1.Location = New System.Drawing.Point(6, 15)
        Me.radioClose1.Name = "radioClose1"
        Me.radioClose1.Size = New System.Drawing.Size(53, 22)
        Me.radioClose1.TabIndex = 27
        Me.radioClose1.TabStop = True
        Me.radioClose1.Text = "Yes"
        Me.radioClose1.UseVisualStyleBackColor = True
        '
        'radioClose2
        '
        Me.radioClose2.AutoSize = True
        Me.radioClose2.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.radioClose2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.radioClose2.Location = New System.Drawing.Point(65, 15)
        Me.radioClose2.Name = "radioClose2"
        Me.radioClose2.Size = New System.Drawing.Size(45, 22)
        Me.radioClose2.TabIndex = 28
        Me.radioClose2.TabStop = True
        Me.radioClose2.Text = "No"
        Me.radioClose2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radioCountry1)
        Me.GroupBox1.Controls.Add(Me.radioCountry2)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 36)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(121, 45)
        Me.GroupBox1.TabIndex = 39
        Me.GroupBox1.TabStop = False
        '
        'radioCountry1
        '
        Me.radioCountry1.AutoSize = True
        Me.radioCountry1.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.radioCountry1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.radioCountry1.Location = New System.Drawing.Point(6, 16)
        Me.radioCountry1.Name = "radioCountry1"
        Me.radioCountry1.Size = New System.Drawing.Size(53, 22)
        Me.radioCountry1.TabIndex = 12
        Me.radioCountry1.TabStop = True
        Me.radioCountry1.Text = "Yes"
        Me.radioCountry1.UseVisualStyleBackColor = True
        '
        'radioCountry2
        '
        Me.radioCountry2.AutoSize = True
        Me.radioCountry2.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.radioCountry2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.radioCountry2.Location = New System.Drawing.Point(65, 16)
        Me.radioCountry2.Name = "radioCountry2"
        Me.radioCountry2.Size = New System.Drawing.Size(45, 22)
        Me.radioCountry2.TabIndex = 13
        Me.radioCountry2.TabStop = True
        Me.radioCountry2.Text = "No"
        Me.radioCountry2.UseVisualStyleBackColor = True
        '
        'btnBackTravel
        '
        Me.btnBackTravel.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnBackTravel.Location = New System.Drawing.Point(11, 356)
        Me.btnBackTravel.Name = "btnBackTravel"
        Me.btnBackTravel.Size = New System.Drawing.Size(94, 29)
        Me.btnBackTravel.TabIndex = 38
        Me.btnBackTravel.Text = "&Back"
        Me.btnBackTravel.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Afghansitan", "Albania", "Algeria", "American Samoa", "Andorra", "Agola", "Anguilla", "Antarctica", "Antigua and Barbuda", "Argentina", "Armenia", "Aruba", "Australia", "Austria", "Azerbaijan", "Bahamas", "Bahrain", "Bangladesh", "Barbados", "Belarus", "Belgium", "Belize", "Benin", "Bermuda", "Bhutan", "Bolivia", "Bosnia and Herzegovina", "Botswana", "Brazil", "Brunei Darussalam", "Bulgaria", "Burkina Faso", "Burundi", "Cambodia", "Cameroon", "Canada", "Cae Verde", "Cayman Islands", "Central African Republic", "Chad", "Chile", "China", "Christmas Island", "Cocos( Keeling) Island", "Colombia", "Comoros", "Democratic Republic of the Congo", "Congo", "Cook Islands", "Costa Rica", "Cote D'ivoire", "Croatia", "Cuba", "Cyprus", "Czech Republic", "Denmark", "Djibouti", "Dominica", "Dominican Republic", "East Timor", "Ecuador", "Egypt", "El Salvador", "Equatorial Guinea", "Eritrea", "Estonia", "Ethiopia", "Falkland Island", "Faroe Islands", "Fiji", "Finland", "France", "French Guian", "Frenh Polynesia", "French Southern Territories", "Gabon", "The Gambia", "Georgia", "Germany", "Ghana", "Gibraltar", "GReece", "Greenland", "Grenada", "Guatemala", "Guinea", "Guinea-Bissau", "Guyana", "Haiti", "Holy See", "Honduras", "Hong Kong", "Hungary", "Iceland ", "India", "Indonesia", "Iran", "Iraq", "Ireland", "Israel", "Italy", "Ivory Coast", "Jamaica", "Japan", "Jordan", "Kazakhstan", "Kenya", "Kribati", "Korea,Democratic People's Rep.", "South Korea", "Kosovo", "Kuwait", "Kyrgzstan", "Lao", "Latvia", "Lebanon", "Lesotho", "Liberia", "Libya", "Liechtenstein", "Lithuania", "Luxembourg", "Macau", "Maadagasar", "Malawai", "Malaysia", "Madivies", "Mali", "Malta", "Marshall Islands ", "artinique", "Mauritania", "Mauritius", "Mayotte", "Mexico", "Micronesia,Federal States", "Moldova", "Monaco", "Mongolia", "Montenegro", "Montserrat", "Morocco", "Mozambique", "Myanmar", "Namiblia", "Nauru", "Nepal", "Netherlands", "Netherlands Antilles", "New Caledonia", "New Zealand", "Ncaragua", "Niger", "Nigeria", "Niue", "North Macedonia", "Northern MArana slands", "Norway", "Oman", "Pakistan", "Palau", "Palestinian Territories", "Panama", "Papau New Guinea", "Paraguay", "Peru", "Philippines", "Pitcairn Islans", "Poland", "Portugal", "Puerto Rico", "Qatar", "Reunion Island", "Romania", "RussiaFederation", "Rwanda", "Saint Kitts and Nevis", "Saint Lucia", "Saint Vincent and the Grenadines", "Samoa", "San Marino", "Sao Tome and Principe", "Saudi Arabia ", "Senega", "Serbia", "Seychelle", "Sierra Leone", "Singapore", "Slovakia", "Slovenia", "Solomon Island", "Soalia", "South Africa", "South Sudan", "Spain", "Sri Lanka", "Sudan", "Suriname", "Swaziland", "Sweden", "Switzerland", "Syria", "Taiwan", "Tajikistan", "Tanzania ", "Thailand", "Tibet", "Timor-Leste", "Togo", "Tokelau", "Tonga", "Trinidad nd Tobag", "Tunisia ", "Turkey", "Turkmenistan", "Turks ad Caicos Islands", "Tuvalu", "Uganda", "Ukraine", "United Arab Emirates", "United Kingdom", "United States", "Uruguay", "Uzbekistan", "Vanuatu", "Vatican City State", "Venezuela", "Vietnam", "Virgin Islands British", "Virgin Island US", "Wallis and Futua Islands", "Wester Sahara", "Yemen", "Zambia", "Zimbabwe"})
        Me.ComboBox1.Location = New System.Drawing.Point(11, 105)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(187, 28)
        Me.ComboBox1.TabIndex = 37
        '
        'btnNextTravel
        '
        Me.btnNextTravel.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnNextTravel.Location = New System.Drawing.Point(667, 356)
        Me.btnNextTravel.Name = "btnNextTravel"
        Me.btnNextTravel.Size = New System.Drawing.Size(94, 29)
        Me.btnNextTravel.TabIndex = 36
        Me.btnNextTravel.Text = "&Next"
        Me.btnNextTravel.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.AllowDrop = True
        Me.TextBox2.Location = New System.Drawing.Point(11, 305)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.PlaceholderText = "Enter"
        Me.TextBox2.Size = New System.Drawing.Size(552, 27)
        Me.TextBox2.TabIndex = 35
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(11, 284)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(552, 18)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "If Unknown,please list the places you went before getting a symptom:"
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.CheckBox4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CheckBox4.Location = New System.Drawing.Point(364, 241)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(86, 22)
        Me.CheckBox4.TabIndex = 33
        Me.CheckBox4.Text = "Unknown"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.CheckBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CheckBox3.Location = New System.Drawing.Point(229, 241)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(110, 22)
        Me.CheckBox3.TabIndex = 32
        Me.CheckBox3.Text = "Co-workers"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.CheckBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CheckBox2.Location = New System.Drawing.Point(112, 241)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(86, 22)
        Me.CheckBox2.TabIndex = 31
        Me.CheckBox2.Text = "Friends"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.CheckBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CheckBox1.Location = New System.Drawing.Point(11, 241)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(78, 22)
        Me.CheckBox1.TabIndex = 30
        Me.CheckBox1.Text = "Family"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(11, 220)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(328, 18)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "If Yes,please tick on the options below:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(10, 153)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(456, 18)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Did you have any close contact with a Covid-19 patient?:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label10.Location = New System.Drawing.Point(10, 84)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(264, 18)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "If Yes,please enter the country:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Consolas", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(456, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(296, 18)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "(If No,please click the Next button)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(10, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(440, 18)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Did you travel to another country in the last 14 days?"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OPENToolStripMenuItem, Me.SAVEToolStripMenuItem, Me.EXITToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(775, 28)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OPENToolStripMenuItem
        '
        Me.OPENToolStripMenuItem.Name = "OPENToolStripMenuItem"
        Me.OPENToolStripMenuItem.Size = New System.Drawing.Size(59, 24)
        Me.OPENToolStripMenuItem.Text = "&Open"
        '
        'SAVEToolStripMenuItem
        '
        Me.SAVEToolStripMenuItem.Name = "SAVEToolStripMenuItem"
        Me.SAVEToolStripMenuItem.Size = New System.Drawing.Size(54, 24)
        Me.SAVEToolStripMenuItem.Text = "&Save"
        '
        'EXITToolStripMenuItem
        '
        Me.EXITToolStripMenuItem.Name = "EXITToolStripMenuItem"
        Me.EXITToolStripMenuItem.Size = New System.Drawing.Size(47, 24)
        Me.EXITToolStripMenuItem.Text = "&Exit"
        '
        'TravelHistoryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(775, 507)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "TravelHistoryForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Travel History Form"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents radioCountry2 As RadioButton
    Friend WithEvents radioCountry1 As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents radioClose2 As RadioButton
    Friend WithEvents radioClose1 As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents btnNextTravel As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents btnBackTravel As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents OPENToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SAVEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EXITToolStripMenuItem As ToolStripMenuItem
End Class
