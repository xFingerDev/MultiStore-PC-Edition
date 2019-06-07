<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inicio
	Inherits System.Windows.Forms.Form

	'Form reemplaza a Dispose para limpiar la lista de componentes.
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

	'Requerido por el Diseñador de Windows Forms
	Private components As System.ComponentModel.IContainer

	'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
	'Se puede modificar usando el Diseñador de Windows Forms.  
	'No lo modifique con el editor de código.
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.Slider = New System.Windows.Forms.TabControl()
		Me.Download = New System.Windows.Forms.TabPage()
		Me.PictureBox2 = New System.Windows.Forms.PictureBox()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
		Me.List1 = New System.Windows.Forms.ListView()
		Me.Searcher = New System.Windows.Forms.TextBox()
		Me.Game_Selector = New System.Windows.Forms.ComboBox()
		Me.Uplaoder = New System.Windows.Forms.TabPage()
		Me.Configuration = New System.Windows.Forms.TabPage()
		Me.KBS = New System.Windows.Forms.Label()
		Me.NameGame = New System.Windows.Forms.Label()
		Me.Type = New System.Windows.Forms.Label()
		Me.Format = New System.Windows.Forms.Label()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Slider.SuspendLayout()
		Me.Download.SuspendLayout()
		CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'PictureBox1
		'
		Me.PictureBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark
		Me.PictureBox1.Location = New System.Drawing.Point(-1, -24)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(808, 464)
		Me.PictureBox1.TabIndex = 0
		Me.PictureBox1.TabStop = False
		'
		'Slider
		'
		Me.Slider.Controls.Add(Me.Download)
		Me.Slider.Controls.Add(Me.Uplaoder)
		Me.Slider.Controls.Add(Me.Configuration)
		Me.Slider.Location = New System.Drawing.Point(-1, 0)
		Me.Slider.Name = "Slider"
		Me.Slider.SelectedIndex = 0
		Me.Slider.Size = New System.Drawing.Size(755, 417)
		Me.Slider.TabIndex = 2
		'
		'Download
		'
		Me.Download.BackColor = System.Drawing.Color.DimGray
		Me.Download.Controls.Add(Me.Format)
		Me.Download.Controls.Add(Me.Type)
		Me.Download.Controls.Add(Me.NameGame)
		Me.Download.Controls.Add(Me.KBS)
		Me.Download.Controls.Add(Me.PictureBox2)
		Me.Download.Controls.Add(Me.Button1)
		Me.Download.Controls.Add(Me.ProgressBar1)
		Me.Download.Controls.Add(Me.List1)
		Me.Download.Controls.Add(Me.Searcher)
		Me.Download.Controls.Add(Me.Game_Selector)
		Me.Download.Location = New System.Drawing.Point(4, 22)
		Me.Download.Name = "Download"
		Me.Download.Padding = New System.Windows.Forms.Padding(3)
		Me.Download.Size = New System.Drawing.Size(747, 391)
		Me.Download.TabIndex = 0
		Me.Download.Text = "Downloader"
		'
		'PictureBox2
		'
		Me.PictureBox2.Location = New System.Drawing.Point(554, 29)
		Me.PictureBox2.Name = "PictureBox2"
		Me.PictureBox2.Size = New System.Drawing.Size(186, 100)
		Me.PictureBox2.TabIndex = 6
		Me.PictureBox2.TabStop = False
		'
		'Button1
		'
		Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button1.Location = New System.Drawing.Point(554, 305)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(186, 44)
		Me.Button1.TabIndex = 5
		Me.Button1.Text = "Button1"
		Me.Button1.UseVisualStyleBackColor = True
		'
		'ProgressBar1
		'
		Me.ProgressBar1.BackColor = System.Drawing.Color.DimGray
		Me.ProgressBar1.Cursor = System.Windows.Forms.Cursors.Default
		Me.ProgressBar1.ForeColor = System.Drawing.Color.Fuchsia
		Me.ProgressBar1.Location = New System.Drawing.Point(8, 354)
		Me.ProgressBar1.Name = "ProgressBar1"
		Me.ProgressBar1.Size = New System.Drawing.Size(538, 31)
		Me.ProgressBar1.TabIndex = 4
		'
		'List1
		'
		Me.List1.BackColor = System.Drawing.Color.DimGray
		Me.List1.ForeColor = System.Drawing.SystemColors.WindowText
		Me.List1.Location = New System.Drawing.Point(9, 29)
		Me.List1.Name = "List1"
		Me.List1.Size = New System.Drawing.Size(538, 321)
		Me.List1.TabIndex = 3
		Me.List1.UseCompatibleStateImageBehavior = False
		'
		'Searcher
		'
		Me.Searcher.BackColor = System.Drawing.Color.DimGray
		Me.Searcher.Location = New System.Drawing.Point(6, 3)
		Me.Searcher.Name = "Searcher"
		Me.Searcher.Size = New System.Drawing.Size(541, 20)
		Me.Searcher.TabIndex = 1
		Me.Searcher.Text = "Search"
		'
		'Game_Selector
		'
		Me.Game_Selector.BackColor = System.Drawing.Color.DimGray
		Me.Game_Selector.FormattingEnabled = True
		Me.Game_Selector.Location = New System.Drawing.Point(553, 2)
		Me.Game_Selector.Name = "Game_Selector"
		Me.Game_Selector.Size = New System.Drawing.Size(188, 21)
		Me.Game_Selector.TabIndex = 0
		Me.Game_Selector.Text = "All"
		'
		'Uplaoder
		'
		Me.Uplaoder.BackColor = System.Drawing.Color.DimGray
		Me.Uplaoder.Location = New System.Drawing.Point(4, 22)
		Me.Uplaoder.Name = "Uplaoder"
		Me.Uplaoder.Padding = New System.Windows.Forms.Padding(3)
		Me.Uplaoder.Size = New System.Drawing.Size(747, 391)
		Me.Uplaoder.TabIndex = 1
		Me.Uplaoder.Text = "Uploader Games"
		'
		'Configuration
		'
		Me.Configuration.BackColor = System.Drawing.Color.DimGray
		Me.Configuration.Location = New System.Drawing.Point(4, 22)
		Me.Configuration.Name = "Configuration"
		Me.Configuration.Padding = New System.Windows.Forms.Padding(3)
		Me.Configuration.Size = New System.Drawing.Size(747, 391)
		Me.Configuration.TabIndex = 2
		Me.Configuration.Text = "Configuration"
		'
		'KBS
		'
		Me.KBS.AutoSize = True
		Me.KBS.Location = New System.Drawing.Point(551, 364)
		Me.KBS.Name = "KBS"
		Me.KBS.Size = New System.Drawing.Size(41, 13)
		Me.KBS.TabIndex = 7
		Me.KBS.Text = "0/0 KB"
		'
		'NameGame
		'
		Me.NameGame.AutoSize = True
		Me.NameGame.Location = New System.Drawing.Point(550, 137)
		Me.NameGame.Name = "NameGame"
		Me.NameGame.Size = New System.Drawing.Size(69, 13)
		Me.NameGame.TabIndex = 8
		Me.NameGame.Text = "Name Game:"
		'
		'Type
		'
		Me.Type.AutoSize = True
		Me.Type.Location = New System.Drawing.Point(550, 159)
		Me.Type.Name = "Type"
		Me.Type.Size = New System.Drawing.Size(37, 13)
		Me.Type.TabIndex = 9
		Me.Type.Text = "Type: "
		'
		'Format
		'
		Me.Format.AutoSize = True
		Me.Format.Location = New System.Drawing.Point(548, 183)
		Me.Format.Name = "Format"
		Me.Format.Size = New System.Drawing.Size(42, 13)
		Me.Format.TabIndex = 10
		Me.Format.Text = "Format:"
		'
		'Inicio
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(751, 412)
		Me.Controls.Add(Me.Slider)
		Me.Controls.Add(Me.PictureBox1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Name = "Inicio"
		Me.Text = "Inicio"
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Slider.ResumeLayout(False)
		Me.Download.ResumeLayout(False)
		Me.Download.PerformLayout()
		CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents PictureBox1 As PictureBox
	Friend WithEvents Slider As TabControl
	Friend WithEvents Download As TabPage
	Friend WithEvents ProgressBar1 As ProgressBar
	Friend WithEvents List1 As ListView
	Friend WithEvents Searcher As TextBox
	Friend WithEvents Game_Selector As ComboBox
	Friend WithEvents Uplaoder As TabPage
	Friend WithEvents Configuration As TabPage
	Friend WithEvents PictureBox2 As PictureBox
	Friend WithEvents Button1 As Button
	Friend WithEvents KBS As Label
	Friend WithEvents Format As Label
	Friend WithEvents Type As Label
	Friend WithEvents NameGame As Label
End Class
