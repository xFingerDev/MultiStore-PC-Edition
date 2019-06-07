<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Start
	Inherits System.Windows.Forms.Form

	'Form reemplaza a Dispose para limpiar la lista de componentes.
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

	'Requerido por el Diseñador de Windows Forms
	Private components As System.ComponentModel.IContainer

	'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
	'Se puede modificar usando el Diseñador de Windows Forms.  
	'No lo modifique con el editor de código.
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Start))
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.Upload = New System.Windows.Forms.TabControl()
		Me.TabPage1 = New System.Windows.Forms.TabPage()
		Me.Load_Image_button = New System.Windows.Forms.Button()
		Me.PictureBox3 = New System.Windows.Forms.PictureBox()
		Me.Report = New System.Windows.Forms.Button()
		Me.i3 = New System.Windows.Forms.Button()
		Me.DownParts = New System.Windows.Forms.ComboBox()
		Me.Region_label = New System.Windows.Forms.Label()
		Me.Version_label = New System.Windows.Forms.Label()
		Me.User_label = New System.Windows.Forms.Label()
		Me.Format_label = New System.Windows.Forms.Label()
		Me.Type_label = New System.Windows.Forms.Label()
		Me.Name_Game_Label = New System.Windows.Forms.Label()
		Me.Button_Download = New System.Windows.Forms.Button()
		Me.Progres_KB = New System.Windows.Forms.Label()
		Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
		Me.List1 = New System.Windows.Forms.ListView()
		Me.ComboBox1 = New System.Windows.Forms.ComboBox()
		Me.TextBox1 = New System.Windows.Forms.TextBox()
		Me.TabPage2 = New System.Windows.Forms.TabPage()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.TextBox7 = New System.Windows.Forms.TextBox()
		Me.PictureBox2 = New System.Windows.Forms.PictureBox()
		Me.ID_Game = New System.Windows.Forms.TextBox()
		Me.GameID_Checkbox = New System.Windows.Forms.CheckBox()
		Me.i = New System.Windows.Forms.Button()
		Me.ComboBox2 = New System.Windows.Forms.ComboBox()
		Me.GamePath = New System.Windows.Forms.CheckBox()
		Me.ListView1 = New System.Windows.Forms.ListView()
		Me.TextBox6 = New System.Windows.Forms.TextBox()
		Me.TextBox5 = New System.Windows.Forms.TextBox()
		Me.TextBox4 = New System.Windows.Forms.TextBox()
		Me.TextBox3 = New System.Windows.Forms.TextBox()
		Me.ComboBox3 = New System.Windows.Forms.ComboBox()
		Me.wii_BOTONCITOS = New System.Windows.Forms.RadioButton()
		Me.wiiu_BOTONCITOS = New System.Windows.Forms.RadioButton()
		Me.VB_BOTONCITOS = New System.Windows.Forms.RadioButton()
		Me.NS_BOTONCITOS = New System.Windows.Forms.RadioButton()
		Me.GameBoyAdvance_BOTONCITOS = New System.Windows.Forms.RadioButton()
		Me.GameCube_BOTONCITOS = New System.Windows.Forms.RadioButton()
		Me.NES_BOTONCITOS = New System.Windows.Forms.RadioButton()
		Me.Snes_BOTONCITOS = New System.Windows.Forms.RadioButton()
		Me.N64_BOTONCITOS = New System.Windows.Forms.RadioButton()
		Me.NDS_BOTONCITOS = New System.Windows.Forms.RadioButton()
		Me.GameBoy_BOTONCITOS = New System.Windows.Forms.RadioButton()
		Me.Upload_Add_item = New System.Windows.Forms.Button()
		Me.Upload_To_ftp = New System.Windows.Forms.Button()
		Me.TextBox2 = New System.Windows.Forms.TextBox()
		Me.TresDS_BOTONCITOS = New System.Windows.Forms.RadioButton()
		Me.TabPage3 = New System.Windows.Forms.TabPage()
		Me.CheckBox2 = New System.Windows.Forms.CheckBox()
		Me.CheckBox1 = New System.Windows.Forms.CheckBox()
		Me.i2 = New System.Windows.Forms.Button()
		Me.CreatedBy = New System.Windows.Forms.LinkLabel()
		Me.Uploader = New System.Windows.Forms.Button()
		Me.Languaje_Custom = New System.Windows.Forms.TextBox()
		Me.Custom_Color = New System.Windows.Forms.TextBox()
		Me.Languaje = New System.Windows.Forms.ComboBox()
		Me.Color = New System.Windows.Forms.ComboBox()
		Me.List_Download = New System.Windows.Forms.TabPage()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.MyToolStrip = New System.Windows.Forms.ToolStrip()
		Me.btnResume = New System.Windows.Forms.ToolStripButton()
		Me.btnResumeAll = New System.Windows.Forms.ToolStripButton()
		Me.btnPause = New System.Windows.Forms.ToolStripButton()
		Me.btnPauseAll = New System.Windows.Forms.ToolStripButton()
		Me.btnRemove = New System.Windows.Forms.ToolStripButton()
		Me.btnRemoveAll = New System.Windows.Forms.ToolStripButton()
		Me.ListView2 = New System.Windows.Forms.ListView()
		Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Upload.SuspendLayout()
		Me.TabPage1.SuspendLayout()
		CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.TabPage2.SuspendLayout()
		CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.TabPage3.SuspendLayout()
		Me.List_Download.SuspendLayout()
		Me.MyToolStrip.SuspendLayout()
		Me.SuspendLayout()
		'
		'PictureBox1
		'
		Me.PictureBox1.BackColor = System.Drawing.Color.DimGray
		Me.PictureBox1.Location = New System.Drawing.Point(-1, -5)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(976, 546)
		Me.PictureBox1.TabIndex = 0
		Me.PictureBox1.TabStop = False
		'
		'Upload
		'
		Me.Upload.Controls.Add(Me.TabPage1)
		Me.Upload.Controls.Add(Me.TabPage2)
		Me.Upload.Controls.Add(Me.TabPage3)
		Me.Upload.Controls.Add(Me.List_Download)
		Me.Upload.Location = New System.Drawing.Point(-1, 0)
		Me.Upload.Name = "Upload"
		Me.Upload.SelectedIndex = 0
		Me.Upload.Size = New System.Drawing.Size(976, 541)
		Me.Upload.TabIndex = 1
		'
		'TabPage1
		'
		Me.TabPage1.BackColor = System.Drawing.Color.DimGray
		Me.TabPage1.Controls.Add(Me.Load_Image_button)
		Me.TabPage1.Controls.Add(Me.PictureBox3)
		Me.TabPage1.Controls.Add(Me.Report)
		Me.TabPage1.Controls.Add(Me.i3)
		Me.TabPage1.Controls.Add(Me.DownParts)
		Me.TabPage1.Controls.Add(Me.Region_label)
		Me.TabPage1.Controls.Add(Me.Version_label)
		Me.TabPage1.Controls.Add(Me.User_label)
		Me.TabPage1.Controls.Add(Me.Format_label)
		Me.TabPage1.Controls.Add(Me.Type_label)
		Me.TabPage1.Controls.Add(Me.Name_Game_Label)
		Me.TabPage1.Controls.Add(Me.Button_Download)
		Me.TabPage1.Controls.Add(Me.Progres_KB)
		Me.TabPage1.Controls.Add(Me.ProgressBar1)
		Me.TabPage1.Controls.Add(Me.List1)
		Me.TabPage1.Controls.Add(Me.ComboBox1)
		Me.TabPage1.Controls.Add(Me.TextBox1)
		Me.TabPage1.Location = New System.Drawing.Point(4, 22)
		Me.TabPage1.Name = "TabPage1"
		Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
		Me.TabPage1.Size = New System.Drawing.Size(968, 515)
		Me.TabPage1.TabIndex = 0
		Me.TabPage1.Text = "Download"
		'
		'Load_Image_button
		'
		Me.Load_Image_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Load_Image_button.Location = New System.Drawing.Point(768, 5)
		Me.Load_Image_button.Name = "Load_Image_button"
		Me.Load_Image_button.Size = New System.Drawing.Size(163, 21)
		Me.Load_Image_button.TabIndex = 17
		Me.Load_Image_button.Text = "Load Image"
		Me.Load_Image_button.UseVisualStyleBackColor = True
		'
		'PictureBox3
		'
		Me.PictureBox3.Location = New System.Drawing.Point(766, 32)
		Me.PictureBox3.Name = "PictureBox3"
		Me.PictureBox3.Size = New System.Drawing.Size(196, 199)
		Me.PictureBox3.TabIndex = 16
		Me.PictureBox3.TabStop = False
		'
		'Report
		'
		Me.Report.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Report.Location = New System.Drawing.Point(897, 446)
		Me.Report.Name = "Report"
		Me.Report.Size = New System.Drawing.Size(65, 27)
		Me.Report.TabIndex = 15
		Me.Report.Text = "Report"
		Me.Report.UseVisualStyleBackColor = True
		'
		'i3
		'
		Me.i3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.i3.Location = New System.Drawing.Point(942, 6)
		Me.i3.Name = "i3"
		Me.i3.Size = New System.Drawing.Size(20, 20)
		Me.i3.TabIndex = 14
		Me.i3.Text = "i"
		Me.i3.UseVisualStyleBackColor = True
		'
		'DownParts
		'
		Me.DownParts.BackColor = System.Drawing.Color.DimGray
		Me.DownParts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.DownParts.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.DownParts.FormattingEnabled = True
		Me.DownParts.Location = New System.Drawing.Point(762, 415)
		Me.DownParts.Name = "DownParts"
		Me.DownParts.Size = New System.Drawing.Size(200, 21)
		Me.DownParts.TabIndex = 13
		'
		'Region_label
		'
		Me.Region_label.AutoSize = True
		Me.Region_label.Location = New System.Drawing.Point(765, 389)
		Me.Region_label.Name = "Region_label"
		Me.Region_label.Size = New System.Drawing.Size(44, 13)
		Me.Region_label.TabIndex = 12
		Me.Region_label.Text = "Region:"
		'
		'Version_label
		'
		Me.Version_label.AutoSize = True
		Me.Version_label.Location = New System.Drawing.Point(765, 359)
		Me.Version_label.Name = "Version_label"
		Me.Version_label.Size = New System.Drawing.Size(45, 13)
		Me.Version_label.TabIndex = 10
		Me.Version_label.Text = "Version:"
		'
		'User_label
		'
		Me.User_label.AutoSize = True
		Me.User_label.Location = New System.Drawing.Point(765, 329)
		Me.User_label.Name = "User_label"
		Me.User_label.Size = New System.Drawing.Size(32, 13)
		Me.User_label.TabIndex = 9
		Me.User_label.Text = "User:"
		'
		'Format_label
		'
		Me.Format_label.AutoSize = True
		Me.Format_label.Location = New System.Drawing.Point(765, 299)
		Me.Format_label.Name = "Format_label"
		Me.Format_label.Size = New System.Drawing.Size(42, 13)
		Me.Format_label.TabIndex = 8
		Me.Format_label.Text = "Format:"
		'
		'Type_label
		'
		Me.Type_label.AutoSize = True
		Me.Type_label.Location = New System.Drawing.Point(765, 269)
		Me.Type_label.Name = "Type_label"
		Me.Type_label.Size = New System.Drawing.Size(34, 13)
		Me.Type_label.TabIndex = 7
		Me.Type_label.Text = "Type:"
		'
		'Name_Game_Label
		'
		Me.Name_Game_Label.AutoSize = True
		Me.Name_Game_Label.Location = New System.Drawing.Point(765, 237)
		Me.Name_Game_Label.Name = "Name_Game_Label"
		Me.Name_Game_Label.Size = New System.Drawing.Size(72, 13)
		Me.Name_Game_Label.TabIndex = 6
		Me.Name_Game_Label.Text = "Name Game: "
		'
		'Button_Download
		'
		Me.Button_Download.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button_Download.Location = New System.Drawing.Point(762, 446)
		Me.Button_Download.Name = "Button_Download"
		Me.Button_Download.Size = New System.Drawing.Size(129, 27)
		Me.Button_Download.TabIndex = 5
		Me.Button_Download.Text = "Download"
		Me.Button_Download.UseVisualStyleBackColor = True
		'
		'Progres_KB
		'
		Me.Progres_KB.AutoSize = True
		Me.Progres_KB.Location = New System.Drawing.Point(765, 485)
		Me.Progres_KB.Name = "Progres_KB"
		Me.Progres_KB.Size = New System.Drawing.Size(41, 13)
		Me.Progres_KB.TabIndex = 4
		Me.Progres_KB.Text = "0/0 KB"
		'
		'ProgressBar1
		'
		Me.ProgressBar1.ForeColor = System.Drawing.Color.Fuchsia
		Me.ProgressBar1.Location = New System.Drawing.Point(10, 481)
		Me.ProgressBar1.Name = "ProgressBar1"
		Me.ProgressBar1.Size = New System.Drawing.Size(749, 23)
		Me.ProgressBar1.TabIndex = 3
		'
		'List1
		'
		Me.List1.BackColor = System.Drawing.Color.DimGray
		Me.List1.FullRowSelect = True
		Me.List1.Location = New System.Drawing.Point(6, 32)
		Me.List1.Name = "List1"
		Me.List1.Size = New System.Drawing.Size(752, 441)
		Me.List1.TabIndex = 2
		Me.List1.UseCompatibleStateImageBehavior = False
		Me.List1.View = System.Windows.Forms.View.Details
		'
		'ComboBox1
		'
		Me.ComboBox1.BackColor = System.Drawing.Color.DimGray
		Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.ComboBox1.FormattingEnabled = True
		Me.ComboBox1.Location = New System.Drawing.Point(571, 5)
		Me.ComboBox1.Name = "ComboBox1"
		Me.ComboBox1.Size = New System.Drawing.Size(188, 21)
		Me.ComboBox1.TabIndex = 1
		'
		'TextBox1
		'
		Me.TextBox1.BackColor = System.Drawing.Color.DimGray
		Me.TextBox1.Location = New System.Drawing.Point(6, 6)
		Me.TextBox1.Name = "TextBox1"
		Me.TextBox1.Size = New System.Drawing.Size(559, 20)
		Me.TextBox1.TabIndex = 0
		Me.TextBox1.Text = "Search"
		'
		'TabPage2
		'
		Me.TabPage2.BackColor = System.Drawing.Color.DimGray
		Me.TabPage2.Controls.Add(Me.Button1)
		Me.TabPage2.Controls.Add(Me.TextBox7)
		Me.TabPage2.Controls.Add(Me.PictureBox2)
		Me.TabPage2.Controls.Add(Me.ID_Game)
		Me.TabPage2.Controls.Add(Me.GameID_Checkbox)
		Me.TabPage2.Controls.Add(Me.i)
		Me.TabPage2.Controls.Add(Me.ComboBox2)
		Me.TabPage2.Controls.Add(Me.GamePath)
		Me.TabPage2.Controls.Add(Me.ListView1)
		Me.TabPage2.Controls.Add(Me.TextBox6)
		Me.TabPage2.Controls.Add(Me.TextBox5)
		Me.TabPage2.Controls.Add(Me.TextBox4)
		Me.TabPage2.Controls.Add(Me.TextBox3)
		Me.TabPage2.Controls.Add(Me.ComboBox3)
		Me.TabPage2.Controls.Add(Me.wii_BOTONCITOS)
		Me.TabPage2.Controls.Add(Me.wiiu_BOTONCITOS)
		Me.TabPage2.Controls.Add(Me.VB_BOTONCITOS)
		Me.TabPage2.Controls.Add(Me.NS_BOTONCITOS)
		Me.TabPage2.Controls.Add(Me.GameBoyAdvance_BOTONCITOS)
		Me.TabPage2.Controls.Add(Me.GameCube_BOTONCITOS)
		Me.TabPage2.Controls.Add(Me.NES_BOTONCITOS)
		Me.TabPage2.Controls.Add(Me.Snes_BOTONCITOS)
		Me.TabPage2.Controls.Add(Me.N64_BOTONCITOS)
		Me.TabPage2.Controls.Add(Me.NDS_BOTONCITOS)
		Me.TabPage2.Controls.Add(Me.GameBoy_BOTONCITOS)
		Me.TabPage2.Controls.Add(Me.Upload_Add_item)
		Me.TabPage2.Controls.Add(Me.Upload_To_ftp)
		Me.TabPage2.Controls.Add(Me.TextBox2)
		Me.TabPage2.Controls.Add(Me.TresDS_BOTONCITOS)
		Me.TabPage2.Location = New System.Drawing.Point(4, 22)
		Me.TabPage2.Name = "TabPage2"
		Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
		Me.TabPage2.Size = New System.Drawing.Size(968, 515)
		Me.TabPage2.TabIndex = 1
		Me.TabPage2.Text = "Upload"
		'
		'Button1
		'
		Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button1.Location = New System.Drawing.Point(11, 289)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(251, 26)
		Me.Button1.TabIndex = 36
		Me.Button1.Text = "Check image"
		Me.Button1.UseVisualStyleBackColor = True
		'
		'TextBox7
		'
		Me.TextBox7.BackColor = System.Drawing.Color.DimGray
		Me.TextBox7.Location = New System.Drawing.Point(9, 263)
		Me.TextBox7.Name = "TextBox7"
		Me.TextBox7.Size = New System.Drawing.Size(254, 20)
		Me.TextBox7.TabIndex = 35
		Me.TextBox7.Text = "Url Image"
		'
		'PictureBox2
		'
		Me.PictureBox2.Location = New System.Drawing.Point(10, 100)
		Me.PictureBox2.Name = "PictureBox2"
		Me.PictureBox2.Size = New System.Drawing.Size(252, 157)
		Me.PictureBox2.TabIndex = 34
		Me.PictureBox2.TabStop = False
		'
		'ID_Game
		'
		Me.ID_Game.BackColor = System.Drawing.Color.DimGray
		Me.ID_Game.Location = New System.Drawing.Point(268, 311)
		Me.ID_Game.Name = "ID_Game"
		Me.ID_Game.Size = New System.Drawing.Size(167, 20)
		Me.ID_Game.TabIndex = 33
		Me.ID_Game.Text = "ID Game"
		'
		'GameID_Checkbox
		'
		Me.GameID_Checkbox.AutoSize = True
		Me.GameID_Checkbox.Location = New System.Drawing.Point(268, 288)
		Me.GameID_Checkbox.Name = "GameID_Checkbox"
		Me.GameID_Checkbox.Size = New System.Drawing.Size(122, 17)
		Me.GameID_Checkbox.TabIndex = 32
		Me.GameID_Checkbox.Text = "Game has ID? False"
		Me.GameID_Checkbox.UseVisualStyleBackColor = True
		'
		'i
		'
		Me.i.BackColor = System.Drawing.Color.DimGray
		Me.i.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.i.Location = New System.Drawing.Point(408, 261)
		Me.i.Name = "i"
		Me.i.Size = New System.Drawing.Size(23, 21)
		Me.i.TabIndex = 31
		Me.i.Text = "i"
		Me.i.UseVisualStyleBackColor = False
		'
		'ComboBox2
		'
		Me.ComboBox2.BackColor = System.Drawing.Color.DimGray
		Me.ComboBox2.Cursor = System.Windows.Forms.Cursors.Default
		Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.ComboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.ComboBox2.FormattingEnabled = True
		Me.ComboBox2.Location = New System.Drawing.Point(268, 157)
		Me.ComboBox2.Name = "ComboBox2"
		Me.ComboBox2.Size = New System.Drawing.Size(168, 21)
		Me.ComboBox2.TabIndex = 30
		'
		'GamePath
		'
		Me.GamePath.AutoSize = True
		Me.GamePath.Location = New System.Drawing.Point(269, 265)
		Me.GamePath.Name = "GamePath"
		Me.GamePath.Size = New System.Drawing.Size(110, 17)
		Me.GamePath.TabIndex = 26
		Me.GamePath.Text = "Game Part? False"
		Me.GamePath.UseVisualStyleBackColor = True
		'
		'ListView1
		'
		Me.ListView1.BackColor = System.Drawing.Color.DimGray
		Me.ListView1.FullRowSelect = True
		Me.ListView1.Location = New System.Drawing.Point(447, 100)
		Me.ListView1.Name = "ListView1"
		Me.ListView1.Size = New System.Drawing.Size(507, 399)
		Me.ListView1.TabIndex = 25
		Me.ListView1.UseCompatibleStateImageBehavior = False
		Me.ListView1.View = System.Windows.Forms.View.Details
		'
		'TextBox6
		'
		Me.TextBox6.BackColor = System.Drawing.Color.DimGray
		Me.TextBox6.Location = New System.Drawing.Point(268, 210)
		Me.TextBox6.Name = "TextBox6"
		Me.TextBox6.Size = New System.Drawing.Size(167, 20)
		Me.TextBox6.TabIndex = 24
		Me.TextBox6.Text = "Format"
		'
		'TextBox5
		'
		Me.TextBox5.BackColor = System.Drawing.Color.DimGray
		Me.TextBox5.Location = New System.Drawing.Point(268, 239)
		Me.TextBox5.Name = "TextBox5"
		Me.TextBox5.Size = New System.Drawing.Size(167, 20)
		Me.TextBox5.TabIndex = 23
		Me.TextBox5.Text = "Version"
		'
		'TextBox4
		'
		Me.TextBox4.BackColor = System.Drawing.Color.DimGray
		Me.TextBox4.Location = New System.Drawing.Point(268, 184)
		Me.TextBox4.Name = "TextBox4"
		Me.TextBox4.Size = New System.Drawing.Size(167, 20)
		Me.TextBox4.TabIndex = 21
		Me.TextBox4.Text = "Your Name"
		'
		'TextBox3
		'
		Me.TextBox3.BackColor = System.Drawing.Color.DimGray
		Me.TextBox3.Location = New System.Drawing.Point(268, 104)
		Me.TextBox3.Name = "TextBox3"
		Me.TextBox3.Size = New System.Drawing.Size(167, 20)
		Me.TextBox3.TabIndex = 20
		Me.TextBox3.Text = "Name Game"
		'
		'ComboBox3
		'
		Me.ComboBox3.BackColor = System.Drawing.Color.DimGray
		Me.ComboBox3.Cursor = System.Windows.Forms.Cursors.Default
		Me.ComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.ComboBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.ComboBox3.FormattingEnabled = True
		Me.ComboBox3.Location = New System.Drawing.Point(268, 130)
		Me.ComboBox3.Name = "ComboBox3"
		Me.ComboBox3.Size = New System.Drawing.Size(168, 21)
		Me.ComboBox3.TabIndex = 19
		'
		'wii_BOTONCITOS
		'
		Me.wii_BOTONCITOS.AutoSize = True
		Me.wii_BOTONCITOS.Checked = True
		Me.wii_BOTONCITOS.Location = New System.Drawing.Point(148, 380)
		Me.wii_BOTONCITOS.Name = "wii_BOTONCITOS"
		Me.wii_BOTONCITOS.Size = New System.Drawing.Size(42, 17)
		Me.wii_BOTONCITOS.TabIndex = 17
		Me.wii_BOTONCITOS.TabStop = True
		Me.wii_BOTONCITOS.Text = "WII"
		Me.wii_BOTONCITOS.UseVisualStyleBackColor = True
		'
		'wiiu_BOTONCITOS
		'
		Me.wiiu_BOTONCITOS.AutoSize = True
		Me.wiiu_BOTONCITOS.Checked = True
		Me.wiiu_BOTONCITOS.Location = New System.Drawing.Point(148, 403)
		Me.wiiu_BOTONCITOS.Name = "wiiu_BOTONCITOS"
		Me.wiiu_BOTONCITOS.Size = New System.Drawing.Size(53, 17)
		Me.wiiu_BOTONCITOS.TabIndex = 16
		Me.wiiu_BOTONCITOS.TabStop = True
		Me.wiiu_BOTONCITOS.Text = "WII U"
		Me.wiiu_BOTONCITOS.UseVisualStyleBackColor = True
		'
		'VB_BOTONCITOS
		'
		Me.VB_BOTONCITOS.AutoSize = True
		Me.VB_BOTONCITOS.Checked = True
		Me.VB_BOTONCITOS.Location = New System.Drawing.Point(11, 426)
		Me.VB_BOTONCITOS.Name = "VB_BOTONCITOS"
		Me.VB_BOTONCITOS.Size = New System.Drawing.Size(96, 17)
		Me.VB_BOTONCITOS.TabIndex = 15
		Me.VB_BOTONCITOS.TabStop = True
		Me.VB_BOTONCITOS.Text = "VIRTUAL BOY"
		Me.VB_BOTONCITOS.UseVisualStyleBackColor = True
		'
		'NS_BOTONCITOS
		'
		Me.NS_BOTONCITOS.AutoSize = True
		Me.NS_BOTONCITOS.Checked = True
		Me.NS_BOTONCITOS.Location = New System.Drawing.Point(148, 426)
		Me.NS_BOTONCITOS.Name = "NS_BOTONCITOS"
		Me.NS_BOTONCITOS.Size = New System.Drawing.Size(121, 17)
		Me.NS_BOTONCITOS.TabIndex = 14
		Me.NS_BOTONCITOS.TabStop = True
		Me.NS_BOTONCITOS.Text = "NINTENDO SWICH"
		Me.NS_BOTONCITOS.UseVisualStyleBackColor = True
		'
		'GameBoyAdvance_BOTONCITOS
		'
		Me.GameBoyAdvance_BOTONCITOS.AutoSize = True
		Me.GameBoyAdvance_BOTONCITOS.Checked = True
		Me.GameBoyAdvance_BOTONCITOS.Location = New System.Drawing.Point(11, 380)
		Me.GameBoyAdvance_BOTONCITOS.Name = "GameBoyAdvance_BOTONCITOS"
		Me.GameBoyAdvance_BOTONCITOS.Size = New System.Drawing.Size(135, 17)
		Me.GameBoyAdvance_BOTONCITOS.TabIndex = 13
		Me.GameBoyAdvance_BOTONCITOS.TabStop = True
		Me.GameBoyAdvance_BOTONCITOS.Text = "GAME BOY ADVANCE"
		Me.GameBoyAdvance_BOTONCITOS.UseVisualStyleBackColor = True
		'
		'GameCube_BOTONCITOS
		'
		Me.GameCube_BOTONCITOS.AutoSize = True
		Me.GameCube_BOTONCITOS.Checked = True
		Me.GameCube_BOTONCITOS.Location = New System.Drawing.Point(11, 403)
		Me.GameCube_BOTONCITOS.Name = "GameCube_BOTONCITOS"
		Me.GameCube_BOTONCITOS.Size = New System.Drawing.Size(85, 17)
		Me.GameCube_BOTONCITOS.TabIndex = 12
		Me.GameCube_BOTONCITOS.TabStop = True
		Me.GameCube_BOTONCITOS.Text = "GAMECUBE"
		Me.GameCube_BOTONCITOS.UseVisualStyleBackColor = True
		'
		'NES_BOTONCITOS
		'
		Me.NES_BOTONCITOS.AutoSize = True
		Me.NES_BOTONCITOS.Checked = True
		Me.NES_BOTONCITOS.Location = New System.Drawing.Point(361, 357)
		Me.NES_BOTONCITOS.Name = "NES_BOTONCITOS"
		Me.NES_BOTONCITOS.Size = New System.Drawing.Size(47, 17)
		Me.NES_BOTONCITOS.TabIndex = 11
		Me.NES_BOTONCITOS.TabStop = True
		Me.NES_BOTONCITOS.Text = "NES"
		Me.NES_BOTONCITOS.UseVisualStyleBackColor = True
		'
		'Snes_BOTONCITOS
		'
		Me.Snes_BOTONCITOS.AutoSize = True
		Me.Snes_BOTONCITOS.Checked = True
		Me.Snes_BOTONCITOS.Location = New System.Drawing.Point(361, 380)
		Me.Snes_BOTONCITOS.Name = "Snes_BOTONCITOS"
		Me.Snes_BOTONCITOS.Size = New System.Drawing.Size(54, 17)
		Me.Snes_BOTONCITOS.TabIndex = 10
		Me.Snes_BOTONCITOS.TabStop = True
		Me.Snes_BOTONCITOS.Text = "SNES"
		Me.Snes_BOTONCITOS.UseVisualStyleBackColor = True
		'
		'N64_BOTONCITOS
		'
		Me.N64_BOTONCITOS.AutoSize = True
		Me.N64_BOTONCITOS.Checked = True
		Me.N64_BOTONCITOS.Location = New System.Drawing.Point(148, 357)
		Me.N64_BOTONCITOS.Name = "N64_BOTONCITOS"
		Me.N64_BOTONCITOS.Size = New System.Drawing.Size(97, 17)
		Me.N64_BOTONCITOS.TabIndex = 9
		Me.N64_BOTONCITOS.TabStop = True
		Me.N64_BOTONCITOS.Text = "NINTENDO 64"
		Me.N64_BOTONCITOS.UseVisualStyleBackColor = True
		'
		'NDS_BOTONCITOS
		'
		Me.NDS_BOTONCITOS.AutoSize = True
		Me.NDS_BOTONCITOS.Checked = True
		Me.NDS_BOTONCITOS.Location = New System.Drawing.Point(269, 380)
		Me.NDS_BOTONCITOS.Name = "NDS_BOTONCITOS"
		Me.NDS_BOTONCITOS.Size = New System.Drawing.Size(48, 17)
		Me.NDS_BOTONCITOS.TabIndex = 8
		Me.NDS_BOTONCITOS.TabStop = True
		Me.NDS_BOTONCITOS.Text = "NDS"
		Me.NDS_BOTONCITOS.UseVisualStyleBackColor = True
		'
		'GameBoy_BOTONCITOS
		'
		Me.GameBoy_BOTONCITOS.AutoSize = True
		Me.GameBoy_BOTONCITOS.Checked = True
		Me.GameBoy_BOTONCITOS.Location = New System.Drawing.Point(11, 357)
		Me.GameBoy_BOTONCITOS.Name = "GameBoy_BOTONCITOS"
		Me.GameBoy_BOTONCITOS.Size = New System.Drawing.Size(81, 17)
		Me.GameBoy_BOTONCITOS.TabIndex = 7
		Me.GameBoy_BOTONCITOS.TabStop = True
		Me.GameBoy_BOTONCITOS.Text = "GAME BOY"
		Me.GameBoy_BOTONCITOS.UseVisualStyleBackColor = True
		'
		'Upload_Add_item
		'
		Me.Upload_Add_item.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Upload_Add_item.Location = New System.Drawing.Point(10, 450)
		Me.Upload_Add_item.Name = "Upload_Add_item"
		Me.Upload_Add_item.Size = New System.Drawing.Size(180, 49)
		Me.Upload_Add_item.TabIndex = 5
		Me.Upload_Add_item.Text = "Upload List"
		Me.Upload_Add_item.UseVisualStyleBackColor = True
		'
		'Upload_To_ftp
		'
		Me.Upload_To_ftp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Upload_To_ftp.Location = New System.Drawing.Point(196, 450)
		Me.Upload_To_ftp.Name = "Upload_To_ftp"
		Me.Upload_To_ftp.Size = New System.Drawing.Size(240, 50)
		Me.Upload_To_ftp.TabIndex = 4
		Me.Upload_To_ftp.Text = "List To  Host"
		Me.Upload_To_ftp.UseVisualStyleBackColor = True
		'
		'TextBox2
		'
		Me.TextBox2.BackColor = System.Drawing.Color.DimGray
		Me.TextBox2.Location = New System.Drawing.Point(10, 10)
		Me.TextBox2.Multiline = True
		Me.TextBox2.Name = "TextBox2"
		Me.TextBox2.ScrollBars = System.Windows.Forms.ScrollBars.Both
		Me.TextBox2.Size = New System.Drawing.Size(943, 84)
		Me.TextBox2.TabIndex = 1
		Me.TextBox2.Text = "Link Game(Please Read Wiki)"
		'
		'TresDS_BOTONCITOS
		'
		Me.TresDS_BOTONCITOS.AutoSize = True
		Me.TresDS_BOTONCITOS.Checked = True
		Me.TresDS_BOTONCITOS.Location = New System.Drawing.Point(268, 357)
		Me.TresDS_BOTONCITOS.Name = "TresDS_BOTONCITOS"
		Me.TresDS_BOTONCITOS.Size = New System.Drawing.Size(46, 17)
		Me.TresDS_BOTONCITOS.TabIndex = 0
		Me.TresDS_BOTONCITOS.TabStop = True
		Me.TresDS_BOTONCITOS.Text = "3DS"
		Me.TresDS_BOTONCITOS.UseVisualStyleBackColor = True
		'
		'TabPage3
		'
		Me.TabPage3.BackColor = System.Drawing.Color.DimGray
		Me.TabPage3.Controls.Add(Me.CheckBox2)
		Me.TabPage3.Controls.Add(Me.CheckBox1)
		Me.TabPage3.Controls.Add(Me.i2)
		Me.TabPage3.Controls.Add(Me.CreatedBy)
		Me.TabPage3.Controls.Add(Me.Uploader)
		Me.TabPage3.Controls.Add(Me.Languaje_Custom)
		Me.TabPage3.Controls.Add(Me.Custom_Color)
		Me.TabPage3.Controls.Add(Me.Languaje)
		Me.TabPage3.Controls.Add(Me.Color)
		Me.TabPage3.Location = New System.Drawing.Point(4, 22)
		Me.TabPage3.Name = "TabPage3"
		Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
		Me.TabPage3.Size = New System.Drawing.Size(968, 515)
		Me.TabPage3.TabIndex = 2
		Me.TabPage3.Text = "Configuration"
		'
		'CheckBox2
		'
		Me.CheckBox2.AutoSize = True
		Me.CheckBox2.Location = New System.Drawing.Point(185, 143)
		Me.CheckBox2.Name = "CheckBox2"
		Me.CheckBox2.Size = New System.Drawing.Size(194, 17)
		Me.CheckBox2.TabIndex = 8
		Me.CheckBox2.Text = "Custom Path Save(No found Temp)"
		Me.CheckBox2.UseVisualStyleBackColor = True
		Me.CheckBox2.Visible = False
		'
		'CheckBox1
		'
		Me.CheckBox1.AutoSize = True
		Me.CheckBox1.Location = New System.Drawing.Point(9, 10)
		Me.CheckBox1.Name = "CheckBox1"
		Me.CheckBox1.Size = New System.Drawing.Size(307, 17)
		Me.CheckBox1.TabIndex = 7
		Me.CheckBox1.Text = "UnLoad Images games (Less lag if your internet is not good)"
		Me.CheckBox1.UseVisualStyleBackColor = True
		'
		'i2
		'
		Me.i2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.i2.Location = New System.Drawing.Point(940, 6)
		Me.i2.Name = "i2"
		Me.i2.Size = New System.Drawing.Size(22, 21)
		Me.i2.TabIndex = 6
		Me.i2.Text = "i"
		Me.i2.UseVisualStyleBackColor = True
		'
		'CreatedBy
		'
		Me.CreatedBy.AutoSize = True
		Me.CreatedBy.LinkColor = System.Drawing.Color.Fuchsia
		Me.CreatedBy.Location = New System.Drawing.Point(864, 499)
		Me.CreatedBy.Name = "CreatedBy"
		Me.CreatedBy.Size = New System.Drawing.Size(104, 13)
		Me.CreatedBy.TabIndex = 5
		Me.CreatedBy.TabStop = True
		Me.CreatedBy.Text = "Created By: TiTiYum"
		'
		'Uploader
		'
		Me.Uploader.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Uploader.Location = New System.Drawing.Point(384, 308)
		Me.Uploader.Name = "Uploader"
		Me.Uploader.Size = New System.Drawing.Size(265, 60)
		Me.Uploader.TabIndex = 4
		Me.Uploader.Text = "Upload List Games"
		Me.Uploader.UseVisualStyleBackColor = True
		'
		'Languaje_Custom
		'
		Me.Languaje_Custom.BackColor = System.Drawing.Color.DimGray
		Me.Languaje_Custom.Location = New System.Drawing.Point(520, 94)
		Me.Languaje_Custom.Name = "Languaje_Custom"
		Me.Languaje_Custom.Size = New System.Drawing.Size(284, 20)
		Me.Languaje_Custom.TabIndex = 3
		Me.Languaje_Custom.Text = "Exemple Name"
		Me.Languaje_Custom.Visible = False
		'
		'Custom_Color
		'
		Me.Custom_Color.BackColor = System.Drawing.Color.DimGray
		Me.Custom_Color.Location = New System.Drawing.Point(520, 67)
		Me.Custom_Color.Name = "Custom_Color"
		Me.Custom_Color.Size = New System.Drawing.Size(284, 20)
		Me.Custom_Color.TabIndex = 2
		Me.Custom_Color.Text = "Exemple Name"
		Me.Custom_Color.Visible = False
		'
		'Languaje
		'
		Me.Languaje.BackColor = System.Drawing.Color.DimGray
		Me.Languaje.FormattingEnabled = True
		Me.Languaje.Location = New System.Drawing.Point(186, 93)
		Me.Languaje.Name = "Languaje"
		Me.Languaje.Size = New System.Drawing.Size(316, 21)
		Me.Languaje.TabIndex = 1
		Me.Languaje.Text = "Languaje"
		Me.Languaje.Visible = False
		'
		'Color
		'
		Me.Color.BackColor = System.Drawing.Color.DimGray
		Me.Color.FormattingEnabled = True
		Me.Color.Location = New System.Drawing.Point(185, 66)
		Me.Color.Name = "Color"
		Me.Color.Size = New System.Drawing.Size(317, 21)
		Me.Color.TabIndex = 0
		Me.Color.Text = "Color"
		Me.Color.Visible = False
		'
		'List_Download
		'
		Me.List_Download.BackColor = System.Drawing.Color.DimGray
		Me.List_Download.Controls.Add(Me.Label1)
		Me.List_Download.Controls.Add(Me.MyToolStrip)
		Me.List_Download.Controls.Add(Me.ListView2)
		Me.List_Download.Location = New System.Drawing.Point(4, 22)
		Me.List_Download.Name = "List_Download"
		Me.List_Download.Padding = New System.Windows.Forms.Padding(3)
		Me.List_Download.Size = New System.Drawing.Size(968, 515)
		Me.List_Download.TabIndex = 3
		Me.List_Download.Text = "List Download"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(287, 138)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(312, 46)
		Me.Label1.TabIndex = 1
		Me.Label1.Text = "COMING SOON"
		'
		'MyToolStrip
		'
		Me.MyToolStrip.BackColor = System.Drawing.Color.DimGray
		Me.MyToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnResume, Me.btnResumeAll, Me.btnPause, Me.btnPauseAll, Me.btnRemove, Me.btnRemoveAll})
		Me.MyToolStrip.Location = New System.Drawing.Point(3, 3)
		Me.MyToolStrip.Name = "MyToolStrip"
		Me.MyToolStrip.Size = New System.Drawing.Size(962, 25)
		Me.MyToolStrip.TabIndex = 0
		Me.MyToolStrip.Text = "ToolStrip1"
		'
		'btnResume
		'
		Me.btnResume.Image = CType(resources.GetObject("btnResume.Image"), System.Drawing.Image)
		Me.btnResume.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.btnResume.Name = "btnResume"
		Me.btnResume.Size = New System.Drawing.Size(69, 22)
		Me.btnResume.Text = "Resume"
		Me.btnResume.ToolTipText = "Resume"
		'
		'btnResumeAll
		'
		Me.btnResumeAll.Image = CType(resources.GetObject("btnResumeAll.Image"), System.Drawing.Image)
		Me.btnResumeAll.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.btnResumeAll.Name = "btnResumeAll"
		Me.btnResumeAll.Size = New System.Drawing.Size(86, 22)
		Me.btnResumeAll.Text = "Resume All"
		'
		'btnPause
		'
		Me.btnPause.Image = CType(resources.GetObject("btnPause.Image"), System.Drawing.Image)
		Me.btnPause.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.btnPause.Name = "btnPause"
		Me.btnPause.Size = New System.Drawing.Size(58, 22)
		Me.btnPause.Text = "Pause"
		Me.btnPause.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
		'
		'btnPauseAll
		'
		Me.btnPauseAll.Image = CType(resources.GetObject("btnPauseAll.Image"), System.Drawing.Image)
		Me.btnPauseAll.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.btnPauseAll.Name = "btnPauseAll"
		Me.btnPauseAll.Size = New System.Drawing.Size(75, 22)
		Me.btnPauseAll.Text = "Pause All"
		'
		'btnRemove
		'
		Me.btnRemove.Image = CType(resources.GetObject("btnRemove.Image"), System.Drawing.Image)
		Me.btnRemove.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.btnRemove.Name = "btnRemove"
		Me.btnRemove.Size = New System.Drawing.Size(70, 22)
		Me.btnRemove.Text = "Remove"
		'
		'btnRemoveAll
		'
		Me.btnRemoveAll.Image = CType(resources.GetObject("btnRemoveAll.Image"), System.Drawing.Image)
		Me.btnRemoveAll.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.btnRemoveAll.Name = "btnRemoveAll"
		Me.btnRemoveAll.Size = New System.Drawing.Size(87, 22)
		Me.btnRemoveAll.Text = "Remove All"
		'
		'ListView2
		'
		Me.ListView2.BackColor = System.Drawing.Color.DimGray
		Me.ListView2.FullRowSelect = True
		Me.ListView2.Location = New System.Drawing.Point(0, 31)
		Me.ListView2.Name = "ListView2"
		Me.ListView2.Size = New System.Drawing.Size(965, 469)
		Me.ListView2.TabIndex = 26
		Me.ListView2.UseCompatibleStateImageBehavior = False
		Me.ListView2.View = System.Windows.Forms.View.Details
		'
		'Start
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.ClientSize = New System.Drawing.Size(969, 534)
		Me.Controls.Add(Me.Upload)
		Me.Controls.Add(Me.PictureBox1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
		Me.HelpButton = True
		Me.MaximumSize = New System.Drawing.Size(985, 573)
		Me.Name = "Start"
		Me.Text = "Project Koppai v2.3"
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Upload.ResumeLayout(False)
		Me.TabPage1.ResumeLayout(False)
		Me.TabPage1.PerformLayout()
		CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
		Me.TabPage2.ResumeLayout(False)
		Me.TabPage2.PerformLayout()
		CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
		Me.TabPage3.ResumeLayout(False)
		Me.TabPage3.PerformLayout()
		Me.List_Download.ResumeLayout(False)
		Me.List_Download.PerformLayout()
		Me.MyToolStrip.ResumeLayout(False)
		Me.MyToolStrip.PerformLayout()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents PictureBox1 As PictureBox
	Friend WithEvents Upload As TabControl
	Friend WithEvents TabPage1 As TabPage
	Friend WithEvents ComboBox1 As ComboBox
	Friend WithEvents TextBox1 As TextBox
	Friend WithEvents TabPage3 As TabPage
	Friend WithEvents Button_Download As Button
	Friend WithEvents Progres_KB As Label
	Friend WithEvents ProgressBar1 As ProgressBar
	Friend WithEvents List1 As ListView
	Friend WithEvents Uploader As Button
	Friend WithEvents Languaje_Custom As TextBox
	Friend WithEvents Custom_Color As TextBox
	Friend WithEvents Languaje As ComboBox
	Friend WithEvents Color As ComboBox
	Friend WithEvents CreatedBy As LinkLabel
	Friend WithEvents TabPage2 As TabPage
	Friend WithEvents TextBox6 As TextBox
	Friend WithEvents TextBox5 As TextBox
	Friend WithEvents TextBox4 As TextBox
	Friend WithEvents TextBox3 As TextBox
	Friend WithEvents ComboBox3 As ComboBox
	Friend WithEvents wii_BOTONCITOS As RadioButton
	Friend WithEvents wiiu_BOTONCITOS As RadioButton
	Friend WithEvents VB_BOTONCITOS As RadioButton
	Friend WithEvents NS_BOTONCITOS As RadioButton
	Friend WithEvents GameBoyAdvance_BOTONCITOS As RadioButton
	Friend WithEvents GameCube_BOTONCITOS As RadioButton
	Friend WithEvents NES_BOTONCITOS As RadioButton
	Friend WithEvents Snes_BOTONCITOS As RadioButton
	Friend WithEvents N64_BOTONCITOS As RadioButton
	Friend WithEvents NDS_BOTONCITOS As RadioButton
	Friend WithEvents GameBoy_BOTONCITOS As RadioButton
	Friend WithEvents Upload_Add_item As Button
	Friend WithEvents Upload_To_ftp As Button
	Friend WithEvents TextBox2 As TextBox
	Friend WithEvents TresDS_BOTONCITOS As RadioButton
	Friend WithEvents Region_label As Label
	Friend WithEvents Version_label As Label
	Friend WithEvents User_label As Label
	Friend WithEvents Format_label As Label
	Friend WithEvents Type_label As Label
	Friend WithEvents Name_Game_Label As Label
	Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
	Friend WithEvents ListView1 As ListView
	Friend WithEvents List_Download As TabPage
	Friend WithEvents MyToolStrip As ToolStrip
	Friend WithEvents btnResume As ToolStripButton
	Friend WithEvents btnResumeAll As ToolStripButton
	Friend WithEvents btnPause As ToolStripButton
	Friend WithEvents btnPauseAll As ToolStripButton
	Friend WithEvents btnRemove As ToolStripButton
	Friend WithEvents btnRemoveAll As ToolStripButton
	Friend WithEvents Label1 As Label
	Friend WithEvents GamePath As CheckBox
	Friend WithEvents Parte As TextBox
	Friend WithEvents ComboBox2 As ComboBox
	Friend WithEvents DownParts As ComboBox
	Friend WithEvents i As Button
	Friend WithEvents i2 As Button
	Friend WithEvents i3 As Button
	Friend WithEvents Report As Button
	Friend WithEvents GameID_Checkbox As CheckBox
	Friend WithEvents ID_Game As TextBox
	Friend WithEvents TextBox7 As TextBox
	Friend WithEvents PictureBox2 As PictureBox
	Friend WithEvents PictureBox3 As PictureBox
	Friend WithEvents CheckBox1 As CheckBox
	Friend WithEvents Load_Image_button As Button
	Friend WithEvents CheckBox2 As CheckBox
	Friend WithEvents ListView2 As ListView
	Friend WithEvents Button1 As Button
End Class
