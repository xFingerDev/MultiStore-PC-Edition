Imports System
Imports System.IO
Imports System.Web
Imports System.Net
Imports Newtonsoft.Json
Imports System.Net.Mail
Imports System.Threading

Public Class Start

	Public Property Version As String = "2.4"


	Public Property Platform As String

	Dim userMsg As String


	Private Link_Game As String
	Private Platform_Game As String
	Private Version_Game As String
	Private format_Game As String
	Private Name_Game As String
	Private Region_Game As String
	Private Game_Part As String
	Private Game_Num As String
	Private myFile As String
#Disable Warning IDE1006 ' Estilos de nombres
	Private WithEvents myWebClient As New Net.WebClient()
#Enable Warning IDE1006 ' Estilos de nombres
	Dim client As WebClient = New WebClient

	Public counter2 As Integer
	Public counter3 As Integer

	Public platfom2 As String
	Public Name_Send As String
	Public Parts As Boolean
	Dim ini As New IniFile
	Private load_images_games As Boolean



	Public Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
		'Platform = ComboBox1.Text
		'MsgBox(Platform)
		Select Case ComboBox1.Text
			Case "All"
				Platform = "All"
			Case "Wii"
				Platform = "Wii"
			Case "Wii U"
				Platform = "WiiU"
			Case "Nintendo Swich"
				Platform = "NSwich"
			Case "Nintendo 64"
				Platform = "N64"
			Case "GameCube"
				Platform = "GameCube"
			Case "Virtual Boy"
				Platform = "VirtualBoy"
			Case "Game Boy Advance"
				Platform = "GameBoyAdvance"
			Case "Snes"
				Platform = "SNES"
			Case "Nes"
				Platform = "NES"
			Case "NDS"
				Platform = "NDS"
			Case "3DS"
				Platform = "3DS"
			Case "Game Boy"
				Platform = "GameBoy"
		End Select
		List1.Items.Clear()
		AddList()
	End Sub

	Private Sub Start_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Me.Cursor = Cursors.WaitCursor


		Createfolders()

		Platform = "All"
		ComboBox1.Items.Add("All")
		ComboBox1.Items.Add("Wii")
		ComboBox1.Items.Add("Wii U")
		ComboBox1.Items.Add("Nintendo Swich")
		ComboBox1.Items.Add("Nintendo 64")
		ComboBox1.Items.Add("GameCube")
		ComboBox1.Items.Add("Snes")
		ComboBox1.Items.Add("Nes")
		ComboBox1.Items.Add("NDS")
		ComboBox1.Items.Add("3DS")
		ComboBox1.Items.Add("Game Boy")
		ComboBox1.Items.Add("Game Boy Advance")
		ComboBox1.Items.Add("Virtual Boy")

		ComboBox1.Text = "All"

		DownParts.Items.Add("ALL")
		DownParts.Text = "ALL"

		List1.Columns.Add("ID", 100)
		List1.Columns.Add("NAME", 300)
		List1.Columns.Add("TYPE", 70)
		List1.Columns.Add("REGION", 70)
		List1.Columns.Add("USER", 90)
		List1.Columns.Add("VERSION", 100)
		List1.Columns.Add("FORMAT", 100)
		List1.Columns.Add("ENCRYPT", 0)
		List1.Columns.Add("Platform", 0)
		List1.Columns.Add("Part Exist?", 0)
		List1.Columns.Add("NPart", 0)
		List1.Columns.Add("id_json", 0)
		List1.Columns.Add("image", 0)

		ListView1.Columns.Add("ID", 0)
		ListView1.Columns.Add("NAME", 120)
		ListView1.Columns.Add("TYPE", 60)
		ListView1.Columns.Add("REGION", 100)
		ListView1.Columns.Add("USER", 100)
		ListView1.Columns.Add("VERSION", 70)
		ListView1.Columns.Add("FORMAT", 60)
		ListView1.Columns.Add("ENCRYPT", 0)
		ListView1.Columns.Add("Platform", 0)
		ListView1.Columns.Add("Part", 60)
		ListView1.Columns.Add("NPart", 0)
		ListView1.Columns.Add("Image", 100)


		ComboBox2.Items.Add("GAME")
		ComboBox2.Items.Add("HACKROM")
		ComboBox2.Items.Add("DLC")
		ComboBox2.Items.Add("PORT")
		ComboBox2.Items.Add("THEME")
		ComboBox2.Items.Add("UPDATE")
		ComboBox2.Items.Add("PATCH")
		ComboBox2.Items.Add("HOMEBREW")

		ComboBox2.Text = "GAME"

		ComboBox3.Items.Add("USA")
		ComboBox3.Items.Add("EUR")
		ComboBox3.Items.Add("HK")
		ComboBox3.Items.Add("JAPAN")
		ComboBox3.Items.Add("KR")
		ComboBox3.Items.Add("AS")
		ComboBox3.Items.Add("UNKNOWN")
		ComboBox3.Items.Add("USA,JAPAN")
		ComboBox3.Items.Add("USA,HK")
		ComboBox3.Items.Add("USA,KR")
		ComboBox3.Items.Add("USA,AS")
		ComboBox3.Items.Add("USA,EUR")
		ComboBox3.Items.Add("EUR,HK")
		ComboBox3.Items.Add("EUR,JAPAN")
		ComboBox3.Items.Add("EUR,KR")
		ComboBox3.Items.Add("EUR,AS")
		ComboBox3.Items.Add("HK,JAPAN")
		ComboBox3.Items.Add("HK,KR")
		ComboBox3.Items.Add("HK,AS")
		ComboBox3.Items.Add("JAPAN,KR")
		ComboBox3.Items.Add("JAPAN,AS")

		'Select_Server.Items.Add("")
		ComboBox3.Text = "USA"

		DownParts.Visible = False
		DownParts.Enabled = False

		ID_Game.Visible = False



		PictureBox2.WaitOnLoad = False
		PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
		PictureBox2.Load("https://upload.wikimedia.org/wikipedia/en/thumb/5/56/Megaman10.jpg/220px-Megaman10.jpg")
		PictureBox3.WaitOnLoad = False
		PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
		PictureBox3.Load("https://upload.wikimedia.org/wikipedia/en/thumb/5/56/Megaman10.jpg/220px-Megaman10.jpg")

		AddList()

		ListView2.Columns.Add("Filename", 225, HorizontalAlignment.Left)
		ListView2.Columns.Add("Size", 80, HorizontalAlignment.Right)
		ListView2.Columns.Add("Status", 125, HorizontalAlignment.Left)
		ListView2.Columns.Add("Completed", 100, HorizontalAlignment.Right)
		ListView2.Columns.Add("Progress", 125, HorizontalAlignment.Center)
		ListView2.Columns.Add("Speed", 75, HorizontalAlignment.Right)
		ListView2.Columns.Add("Time", 80, HorizontalAlignment.Left)
		ListView2.Columns.Add("Time Left", 80, HorizontalAlignment.Left)


		Me.Cursor = Cursors.Default
	End Sub

	Private Sub CreatedBy_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles CreatedBy.LinkClicked
		Process.Start("https://github.com/TiTiYum/Project-Koppai/releases")
	End Sub

	Private Sub Uploader_Click(sender As Object, e As EventArgs) Handles Uploader.Click
		UploadList()
	End Sub

	Private Sub Createfolders()

		If Dir(Application.StartupPath & "\Roms", vbDirectory) = "" Then
			MkDir(Application.StartupPath & "\Roms")
		End If

		If Dir(Application.StartupPath & "\Uploader", vbDirectory) = "" Then
			MkDir(Application.StartupPath & "\Uploader")
		End If

		If Dir(Application.StartupPath & "\Uploader\List", vbDirectory) = "" Then
			MkDir(Application.StartupPath & "\Uploader\List")
		End If

		If Dir(Application.StartupPath & "\Roms\NDS", vbDirectory) = "" Then
			MkDir(Application.StartupPath & "\Roms\NDS")
		End If

		If Dir(Application.StartupPath & "\Roms\3DS", vbDirectory) = "" Then
			MkDir(Application.StartupPath & "\Roms\3DS")
		End If

		If Dir(Application.StartupPath & "\Roms\WII", vbDirectory) = "" Then
			MkDir(Application.StartupPath & "\Roms\WII")
		End If

		If Dir(Application.StartupPath & "\Roms\WII U", vbDirectory) = "" Then
			MkDir(Application.StartupPath & "\Roms\WII U")
		End If

		If Dir(Application.StartupPath & "\Roms\NINTENDO 64", vbDirectory) = "" Then
			MkDir(Application.StartupPath & "\Roms\NINTENDO 64")
		End If

		If Dir(Application.StartupPath & "\Roms\GAMECUBE", vbDirectory) = "" Then
			MkDir(Application.StartupPath & "\Roms\GAMECUBE")
		End If

		If Dir(Application.StartupPath & "\Roms\NES", vbDirectory) = "" Then
			MkDir(Application.StartupPath & "\Roms\NES")
		End If

		If Dir(Application.StartupPath & "\Roms\SNES", vbDirectory) = "" Then
			MkDir(Application.StartupPath & "\Roms\SNES")
		End If

		If Dir(Application.StartupPath & "\Roms\GAME BOY", vbDirectory) = "" Then
			MkDir(Application.StartupPath & "\Roms\GAME BOY")
		End If

		If Dir(Application.StartupPath & "\Roms\GAME BOY ADVANCE", vbDirectory) = "" Then
			MkDir(Application.StartupPath & "\Roms\GAME BOY ADVANCE")
		End If

		If Dir(Application.StartupPath & "\Roms\NINTENDO SWICH", vbDirectory) = "" Then
			MkDir(Application.StartupPath & "\Roms\NINTENDO SWICH")
		End If

		If Dir(Application.StartupPath & "\Roms\VIRTUAL BOY", vbDirectory) = "" Then
			MkDir(Application.StartupPath & "\Roms\VIRTUAL BOY")
		End If


		If Dir(Application.StartupPath & "\Lang", vbDirectory) = "" Then
			MkDir(Application.StartupPath & "\Lang")
		End If

		If Dir(Application.StartupPath & "\List", vbDirectory) = "" Then
			MkDir(Application.StartupPath & "\List")
			UploadList()
		End If

		If Dir(Application.StartupPath & "\List\Version", vbArchive) = "" Then
		Else
			Kill(Application.StartupPath & "\List\Version")
		End If

		My.Computer.Network.DownloadFile("http://www.openpstore.xyz/PK-List-Games/Version.txt", Application.StartupPath & "\List\Version")
		If File.ReadAllText(Application.StartupPath & "\List\Version").ToString = Version Then
		Else
			Process.Start("https://github.com/TiTiYum/Project-Koppai/releases/latest")
		End If

		If System.IO.File.Exists((Application.StartupPath & "\List\Config.ini")) = True Then
			ini.Load(Application.StartupPath & "\List\Config.ini")
			If ini.GetKeyValue("Config", "Unload_Images") = "True" Then

				load_images_games = True
				CheckBox1.Checked = 1
				Load_Image_button.Visible = True
			Else
				load_images_games = False
				CheckBox1.Checked = 0
				Load_Image_button.Visible = False
			End If
		End If
		If System.IO.File.Exists((Application.StartupPath & "\List\Config.ini")) = False Then
			System.IO.File.Create((Application.StartupPath & "\List\Config.ini")).Dispose()
			ini.Load(Application.StartupPath & "\List\Config.ini")
			ini.AddSection("Config").AddKey("Unload_Images").Value = "True"
			load_images_games = False
			CheckBox1.Checked = 0
			Load_Image_button.Visible = False
			ini.Save(Application.StartupPath & "\List\Config.ini")
		End If
	End Sub

	Private Sub UploadList()
		'Delete List
		Me.Cursor = Cursors.WaitCursor
		If Dir(Application.StartupPath & "\List\Games-List-Wii", vbArchive) = "" Then
		Else
			Kill(Application.StartupPath & "\List\Games-List-Wii")
		End If
		If Dir(Application.StartupPath & "\List\Games-List-WiiU", vbArchive) = "" Then
		Else
			Kill(Application.StartupPath & "\List\Games-List-WiiU")
		End If
		If Dir(Application.StartupPath & "\List\Games-List-GameBoy", vbArchive) = "" Then
		Else
			Kill(Application.StartupPath & "\List\Games-List-GameBoy")
		End If
		If Dir(Application.StartupPath & "\List\Games-List-GameBoyAdvance", vbArchive) = "" Then
		Else
			Kill(Application.StartupPath & "\List\Games-List-GameBoyAdvance")
		End If
		If Dir(Application.StartupPath & "\List\Games-List-GameCube", vbArchive) = "" Then
		Else
			Kill(Application.StartupPath & "\List\Games-List-GameCube")
		End If
		If Dir(Application.StartupPath & "\List\Games-List-N64", vbArchive) = "" Then
		Else
			Kill(Application.StartupPath & "\List\Games-List-N64")
		End If
		If Dir(Application.StartupPath & "\List\Games-List-NDS", vbArchive) = "" Then
		Else
			Kill(Application.StartupPath & "\List\Games-List-NDS")
		End If
		If Dir(Application.StartupPath & "\List\Games-List-NES", vbArchive) = "" Then
		Else
			Kill(Application.StartupPath & "\List\Games-List-NES")
		End If
		If Dir(Application.StartupPath & "\List\Games-List-NSwich", vbArchive) = "" Then
		Else
			Kill(Application.StartupPath & "\List\Games-List-NSwich")
		End If
		If Dir(Application.StartupPath & "\List\Games-List-SNES", vbArchive) = "" Then
		Else
			Kill(Application.StartupPath & "\List\Games-List-SNES")
		End If
		If Dir(Application.StartupPath & "\List\Games-List-VirtualBoy", vbArchive) = "" Then
		Else
			Kill(Application.StartupPath & "\List\Games-List-VirtualBoy")
		End If
		If Dir(Application.StartupPath & "\List\Games-List-3DS", vbArchive) = "" Then
		Else
			Kill(Application.StartupPath & "\List\Games-List-3DS")
		End If
		'Download List
		My.Computer.Network.DownloadFile("http://www.openpstore.xyz/PK-List-Games/Games-List-Wii.json", Application.StartupPath & "\List\Games-List-Wii")
		My.Computer.Network.DownloadFile("http://www.openpstore.xyz/PK-List-Games/Games-List-WiiU.json", Application.StartupPath & "\List\Games-List-WiiU")
		My.Computer.Network.DownloadFile("http://www.openpstore.xyz/PK-List-Games/Games-List-VirtualBoy.json", Application.StartupPath & "\List\Games-List-VirtualBoy")
		My.Computer.Network.DownloadFile("http://www.openpstore.xyz/PK-List-Games/Games-List-SNES.json", Application.StartupPath & "\List\Games-List-SNES")
		My.Computer.Network.DownloadFile("http://www.openpstore.xyz/PK-List-Games/Games-List-NSwich.json", Application.StartupPath & "\List\Games-List-NSwich")
		My.Computer.Network.DownloadFile("http://www.openpstore.xyz/PK-List-Games/Games-List-NDS.json", Application.StartupPath & "\List\Games-List-NDS")
		My.Computer.Network.DownloadFile("http://www.openpstore.xyz/PK-List-Games/Games-List-N64.json", Application.StartupPath & "\List\Games-List-N64")
		My.Computer.Network.DownloadFile("http://www.openpstore.xyz/PK-List-Games/Games-List-GameCube.json", Application.StartupPath & "\List\Games-List-GameCube")
		My.Computer.Network.DownloadFile("http://www.openpstore.xyz/PK-List-Games/Games-List-GameBoyAdvance.json", Application.StartupPath & "\List\Games-List-GameBoyAdvance")
		My.Computer.Network.DownloadFile("http://www.openpstore.xyz/PK-List-Games/Games-List-GameBoy.json", Application.StartupPath & "\List\Games-List-GameBoy")
		My.Computer.Network.DownloadFile("http://www.openpstore.xyz/PK-List-Games/Games-List-NES.json", Application.StartupPath & "\List\Games-List-NES")
		My.Computer.Network.DownloadFile("http://www.openpstore.xyz/PK-List-Games/Games-List-3DS.json", Application.StartupPath & "\List\Games-List-3DS")
		Me.Cursor = Cursors.Default
	End Sub

	Private Sub AddList()
		Dim localpath
		Dim Game As List(Of ListTwo)
		If "\List\Games-List-Wii" = "" Then
		Else
			If "\List\Games-List-3DS" = "" Then
			Else
				If "\List\Games-List-GameBoy" = "" Then
				Else
					If "\List\Games-List-GameBoyAdvance" = "" Then
					Else
						If "\List\Games-List-GameCube" = "" Then
						Else
							If "\sourceListGames-List-N64" = "" Then
							Else
								If "\List\Games-List-NDS" = "" Then
								Else
									If "\List\Games-List-NES" = "" Then
									Else
										If "\List\Games-List-SNES" = "" Then
										Else
											If "\List\Games-List-NSwich" = "" Then
											Else
												If "\List\Games-List-VirtualBoy" = "" Then
												Else
													If "\List\Games-List-WiiU" = "" Then
													Else
														Me.Cursor = Cursors.WaitCursor
														Dim pos As Long
														Dim FilaIni As Long
														Dim UFila As Long
														Dim index1 As Long
														Dim counter As Integer
														If Platform = "All" Then
															localpath = File.ReadAllText(Application.StartupPath & "\List\Games-List-Wii")
															Game = JsonConvert.DeserializeObject(Of List(Of ListTwo))(localpath)
															FilaIni = 2 : UFila = 999999
															For index1 = FilaIni To UFila
																If (Game(pos).Name = "") Then
																	Exit For
																Else
																	List1.Items.Add(Game(pos).ID)
																	List1.Items(counter).SubItems.Add(Game(pos).Name)
																	List1.Items(counter).SubItems.Add(Game(pos).Region)
																	List1.Items(counter).SubItems.Add(Game(pos).Type)
																	List1.Items(counter).SubItems.Add(Game(pos).User)
																	List1.Items(counter).SubItems.Add(Game(pos).Version)
																	List1.Items(counter).SubItems.Add(Game(pos).Format)
																	List1.Items(counter).SubItems.Add(Game(pos).Encrypt(0))
																	List1.Items(counter).SubItems.Add("WII")
																	List1.Items(counter).SubItems.Add(Game(pos).Parts)
																	List1.Items(counter).SubItems.Add(Game(pos).N_Part)
																	List1.Items(counter).SubItems.Add(pos)
																	List1.Items(counter).SubItems.Add(Game(pos).Image)
																	pos = pos + 1
																	counter = counter + 1
																End If
															Next index1
															pos = 0

															localpath = File.ReadAllText(Application.StartupPath & "\List\Games-List-NSwich")
															Game = JsonConvert.DeserializeObject(Of List(Of ListTwo))(localpath)

															FilaIni = 2 : UFila = 999999
															For index1 = FilaIni To UFila
																If (Game(pos).Name = "") Then
																	Exit For
																Else
																	List1.Items.Add(Game(pos).ID)
																	List1.Items(counter).SubItems.Add(Game(pos).Name)
																	List1.Items(counter).SubItems.Add(Game(pos).Region)
																	List1.Items(counter).SubItems.Add(Game(pos).Type)
																	List1.Items(counter).SubItems.Add(Game(pos).User)
																	List1.Items(counter).SubItems.Add(Game(pos).Version)
																	List1.Items(counter).SubItems.Add(Game(pos).Format)
																	List1.Items(counter).SubItems.Add(Game(pos).Encrypt(0))
																	List1.Items(counter).SubItems.Add("NINTENDO SWICH")
																	List1.Items(counter).SubItems.Add(Game(pos).Parts)
																	List1.Items(counter).SubItems.Add(Game(pos).N_Part)
																	List1.Items(counter).SubItems.Add(pos)
																	List1.Items(counter).SubItems.Add(Game(pos).Image)
																	pos = pos + 1
																	counter = counter + 1
																End If
															Next index1
															localpath = File.ReadAllText(Application.StartupPath & "\List\Games-List-WiiU")
															Game = JsonConvert.DeserializeObject(Of List(Of ListTwo))(localpath)
															pos = 0
															FilaIni = 2 : UFila = 999999
															For index1 = FilaIni To UFila
																If (Game(pos).Name = "") Then
																	Exit For
																Else
																	List1.Items.Add(Game(pos).ID)
																	List1.Items(counter).SubItems.Add(Game(pos).Name)
																	List1.Items(counter).SubItems.Add(Game(pos).Region)
																	List1.Items(counter).SubItems.Add(Game(pos).Type)
																	List1.Items(counter).SubItems.Add(Game(pos).User)
																	List1.Items(counter).SubItems.Add(Game(pos).Version)
																	List1.Items(counter).SubItems.Add(Game(pos).Format)
																	List1.Items(counter).SubItems.Add(Game(pos).Encrypt(0))
																	List1.Items(counter).SubItems.Add("WII U")
																	List1.Items(counter).SubItems.Add(Game(pos).Parts)
																	List1.Items(counter).SubItems.Add(Game(pos).N_Part)
																	List1.Items(counter).SubItems.Add(pos)
																	List1.Items(counter).SubItems.Add(Game(pos).Image)
																	pos = pos + 1
																	counter = counter + 1
																End If
															Next index1

															localpath = File.ReadAllText(Application.StartupPath & "\List\Games-List-N64")
															Game = JsonConvert.DeserializeObject(Of List(Of ListTwo))(localpath)
															pos = 0
															FilaIni = 2 : UFila = 999999
															For index1 = FilaIni To UFila
																If (Game(pos).Name = "") Then
																	Exit For
																Else
																	List1.Items.Add(Game(pos).ID)
																	List1.Items(counter).SubItems.Add(Game(pos).Name)
																	List1.Items(counter).SubItems.Add(Game(pos).Region)
																	List1.Items(counter).SubItems.Add(Game(pos).Type)
																	List1.Items(counter).SubItems.Add(Game(pos).User)
																	List1.Items(counter).SubItems.Add(Game(pos).Version)
																	List1.Items(counter).SubItems.Add(Game(pos).Format)
																	List1.Items(counter).SubItems.Add(Game(pos).Encrypt(0))
																	List1.Items(counter).SubItems.Add("NINTENDO 64")
																	List1.Items(counter).SubItems.Add(Game(pos).Parts)
																	List1.Items(counter).SubItems.Add(Game(pos).N_Part)
																	List1.Items(counter).SubItems.Add(pos)
																	List1.Items(counter).SubItems.Add(Game(pos).Image)
																	pos = pos + 1
																	counter = counter + 1
																End If
															Next index1
															localpath = File.ReadAllText(Application.StartupPath & "\List\Games-List-GameCube")
															Game = JsonConvert.DeserializeObject(Of List(Of ListTwo))(localpath)
															pos = 0
															FilaIni = 2 : UFila = 999999
															For index1 = FilaIni To UFila
																If (Game(pos).Name = "") Then
																	Exit For
																Else
																	List1.Items.Add(Game(pos).ID)
																	List1.Items(counter).SubItems.Add(Game(pos).Name)
																	List1.Items(counter).SubItems.Add(Game(pos).Region)
																	List1.Items(counter).SubItems.Add(Game(pos).Type)
																	List1.Items(counter).SubItems.Add(Game(pos).User)
																	List1.Items(counter).SubItems.Add(Game(pos).Version)
																	List1.Items(counter).SubItems.Add(Game(pos).Format)
																	List1.Items(counter).SubItems.Add(Game(pos).Encrypt(0))
																	List1.Items(counter).SubItems.Add("GAMECUBE")
																	List1.Items(counter).SubItems.Add(Game(pos).Parts)
																	List1.Items(counter).SubItems.Add(Game(pos).N_Part)
																	List1.Items(counter).SubItems.Add(pos)
																	List1.Items(counter).SubItems.Add(Game(pos).Image)
																	pos = pos + 1
																	counter = counter + 1
																End If
															Next index1
															localpath = File.ReadAllText(Application.StartupPath & "\List\Games-List-SNES")
															Game = JsonConvert.DeserializeObject(Of List(Of ListTwo))(localpath)
															pos = 0
															FilaIni = 2 : UFila = 999999
															For index1 = FilaIni To UFila
																If (Game(pos).Name = "") Then
																	Exit For
																Else
																	List1.Items.Add(Game(pos).ID)
																	List1.Items(counter).SubItems.Add(Game(pos).Name)
																	List1.Items(counter).SubItems.Add(Game(pos).Region)
																	List1.Items(counter).SubItems.Add(Game(pos).Type)
																	List1.Items(counter).SubItems.Add(Game(pos).User)
																	List1.Items(counter).SubItems.Add(Game(pos).Version)
																	List1.Items(counter).SubItems.Add(Game(pos).Format)
																	List1.Items(counter).SubItems.Add(Game(pos).Encrypt(0))
																	List1.Items(counter).SubItems.Add("SNES")
																	List1.Items(counter).SubItems.Add(Game(pos).Parts)
																	List1.Items(counter).SubItems.Add(Game(pos).N_Part)
																	List1.Items(counter).SubItems.Add(pos)
																	List1.Items(counter).SubItems.Add(Game(pos).Image)
																	pos = pos + 1
																	counter = counter + 1
																End If
															Next index1
															localpath = File.ReadAllText(Application.StartupPath & "\List\Games-List-NDS")
															Game = JsonConvert.DeserializeObject(Of List(Of ListTwo))(localpath)
															pos = 0
															FilaIni = 2 : UFila = 999999
															For index1 = FilaIni To UFila
																If (Game(pos).Name = "") Then
																	Exit For
																Else
																	List1.Items.Add(Game(pos).ID)
																	List1.Items(counter).SubItems.Add(Game(pos).Name)
																	List1.Items(counter).SubItems.Add(Game(pos).Region)
																	List1.Items(counter).SubItems.Add(Game(pos).Type)
																	List1.Items(counter).SubItems.Add(Game(pos).User)
																	List1.Items(counter).SubItems.Add(Game(pos).Version)
																	List1.Items(counter).SubItems.Add(Game(pos).Format)
																	List1.Items(counter).SubItems.Add(Game(pos).Encrypt(0))
																	List1.Items(counter).SubItems.Add("NDS")
																	List1.Items(counter).SubItems.Add(Game(pos).Parts)
																	List1.Items(counter).SubItems.Add(Game(pos).N_Part)
																	List1.Items(counter).SubItems.Add(pos)
																	List1.Items(counter).SubItems.Add(Game(pos).Image)
																	pos = pos + 1
																	counter = counter + 1
																End If
															Next index1
															localpath = File.ReadAllText(Application.StartupPath & "\List\Games-List-3DS")
															Game = JsonConvert.DeserializeObject(Of List(Of ListTwo))(localpath)
															pos = 0
															FilaIni = 2 : UFila = 999999
															For index1 = FilaIni To UFila
																If (Game(pos).Name = "") Then
																	Exit For
																Else
																	List1.Items.Add(Game(pos).ID)
																	List1.Items(counter).SubItems.Add(Game(pos).Name)
																	List1.Items(counter).SubItems.Add(Game(pos).Region)
																	List1.Items(counter).SubItems.Add(Game(pos).Type)
																	List1.Items(counter).SubItems.Add(Game(pos).User)
																	List1.Items(counter).SubItems.Add(Game(pos).Version)
																	List1.Items(counter).SubItems.Add(Game(pos).Format)
																	List1.Items(counter).SubItems.Add(Game(pos).Encrypt(0))
																	List1.Items(counter).SubItems.Add("3DS")
																	List1.Items(counter).SubItems.Add(Game(pos).Parts)
																	List1.Items(counter).SubItems.Add(Game(pos).N_Part)
																	List1.Items(counter).SubItems.Add(pos)
																	List1.Items(counter).SubItems.Add(Game(pos).Image)
																	pos = pos + 1
																	counter = counter + 1
																End If
															Next index1
															localpath = File.ReadAllText(Application.StartupPath & "\List\Games-List-GameBoy")
															Game = JsonConvert.DeserializeObject(Of List(Of ListTwo))(localpath)
															pos = 0
															FilaIni = 2 : UFila = 999999
															For index1 = FilaIni To UFila
																If (Game(pos).Name = "") Then
																	Exit For
																Else
																	List1.Items.Add(Game(pos).ID)
																	List1.Items(counter).SubItems.Add(Game(pos).Name)
																	List1.Items(counter).SubItems.Add(Game(pos).Region)
																	List1.Items(counter).SubItems.Add(Game(pos).Type)
																	List1.Items(counter).SubItems.Add(Game(pos).User)
																	List1.Items(counter).SubItems.Add(Game(pos).Version)
																	List1.Items(counter).SubItems.Add(Game(pos).Format)
																	List1.Items(counter).SubItems.Add(Game(pos).Encrypt(0))
																	List1.Items(counter).SubItems.Add("GAME BOY")
																	List1.Items(counter).SubItems.Add(Game(pos).Parts)
																	List1.Items(counter).SubItems.Add(Game(pos).N_Part)
																	List1.Items(counter).SubItems.Add(pos)
																	List1.Items(counter).SubItems.Add(Game(pos).Image)
																	pos = pos + 1
																	counter = counter + 1
																End If
															Next index1
															localpath = File.ReadAllText(Application.StartupPath & "\List\Games-List-GameBoyAdvance")
															Game = JsonConvert.DeserializeObject(Of List(Of ListTwo))(localpath)
															pos = 0
															FilaIni = 2 : UFila = 999999
															For index1 = FilaIni To UFila
																If (Game(pos).Name = "") Then
																	Exit For
																Else
																	List1.Items.Add(Game(pos).ID)
																	List1.Items(counter).SubItems.Add(Game(pos).Name)
																	List1.Items(counter).SubItems.Add(Game(pos).Region)
																	List1.Items(counter).SubItems.Add(Game(pos).Type)
																	List1.Items(counter).SubItems.Add(Game(pos).User)
																	List1.Items(counter).SubItems.Add(Game(pos).Version)
																	List1.Items(counter).SubItems.Add(Game(pos).Format)
																	List1.Items(counter).SubItems.Add(Game(pos).Encrypt(0))
																	List1.Items(counter).SubItems.Add("GAME BOY ADVANCE")
																	List1.Items(counter).SubItems.Add(Game(pos).Parts)
																	List1.Items(counter).SubItems.Add(Game(pos).N_Part)
																	List1.Items(counter).SubItems.Add(pos)
																	List1.Items(counter).SubItems.Add(Game(pos).Image)
																	pos = pos + 1
																	counter = counter + 1
																End If
															Next index1
															localpath = File.ReadAllText(Application.StartupPath & "\List\Games-List-NES")
															Game = JsonConvert.DeserializeObject(Of List(Of ListTwo))(localpath)
															pos = 0
															FilaIni = 2 : UFila = 999999
															For index1 = FilaIni To UFila
																If (Game(pos).Name = "") Then
																	Exit For
																Else
																	List1.Items.Add(Game(pos).ID)
																	List1.Items(counter).SubItems.Add(Game(pos).Name)
																	List1.Items(counter).SubItems.Add(Game(pos).Region)
																	List1.Items(counter).SubItems.Add(Game(pos).Type)
																	List1.Items(counter).SubItems.Add(Game(pos).User)
																	List1.Items(counter).SubItems.Add(Game(pos).Version)
																	List1.Items(counter).SubItems.Add(Game(pos).Format)
																	List1.Items(counter).SubItems.Add(Game(pos).Encrypt(0))
																	List1.Items(counter).SubItems.Add("NES")
																	List1.Items(counter).SubItems.Add(Game(pos).Parts)
																	List1.Items(counter).SubItems.Add(Game(pos).N_Part)
																	List1.Items(counter).SubItems.Add(pos)
																	List1.Items(counter).SubItems.Add(Game(pos).Image)
																	pos = pos + 1
																	counter = counter + 1
																End If
															Next index1
															localpath = File.ReadAllText(Application.StartupPath & "\List\Games-List-VirtualBoy")
															Game = JsonConvert.DeserializeObject(Of List(Of ListTwo))(localpath)
															pos = 0
															FilaIni = 2 : UFila = 999999
															For index1 = FilaIni To UFila
																If (Game(pos).Name = "") Then
																	Exit For
																Else
																	List1.Items.Add(Game(pos).ID)
																	List1.Items(counter).SubItems.Add(Game(pos).Name)
																	List1.Items(counter).SubItems.Add(Game(pos).Region)
																	List1.Items(counter).SubItems.Add(Game(pos).Type)
																	List1.Items(counter).SubItems.Add(Game(pos).User)
																	List1.Items(counter).SubItems.Add(Game(pos).Version)
																	List1.Items(counter).SubItems.Add(Game(pos).Format)
																	List1.Items(counter).SubItems.Add(Game(pos).Encrypt(0))
																	List1.Items(counter).SubItems.Add("VIRTUAL BOY")
																	List1.Items(counter).SubItems.Add(Game(pos).Parts)
																	List1.Items(counter).SubItems.Add(Game(pos).N_Part)
																	List1.Items(counter).SubItems.Add(pos)
																	List1.Items(counter).SubItems.Add(Game(pos).Image)
																	pos = pos + 1
																	counter = counter + 1
																End If
															Next index1
														Else
															localpath = File.ReadAllText(Application.StartupPath & "\List\Games-List-" & Platform)
															Game = JsonConvert.DeserializeObject(Of List(Of ListTwo))(localpath)
															FilaIni = 2 : UFila = 999999
															For index1 = FilaIni To UFila
																If (Game(pos).Name = "") Then
																	Exit For
																Else
																	List1.Items.Add(Game(pos).ID)
																	List1.Items(counter).SubItems.Add(Game(pos).Name)
																	List1.Items(counter).SubItems.Add(Game(pos).Region)
																	List1.Items(counter).SubItems.Add(Game(pos).Type)
																	List1.Items(counter).SubItems.Add(Game(pos).User)
																	List1.Items(counter).SubItems.Add(Game(pos).Version)
																	List1.Items(counter).SubItems.Add(Game(pos).Format)
																	List1.Items(counter).SubItems.Add(Game(pos).Encrypt(0))

																	Select Case Platform
																		Case "Wii"
																			List1.Items(counter).SubItems.Add("WII")
																		Case "WiiU"
																			List1.Items(counter).SubItems.Add("WII U")
																		Case "NSwich"
																			List1.Items(counter).SubItems.Add("NINTENDO SWICH")
																		Case "N64"
																			List1.Items(counter).SubItems.Add("NINTENDO 64")
																		Case "GameCube"
																			List1.Items(counter).SubItems.Add("GAMECUBE")
																		Case "VirtualBoy"
																			List1.Items(counter).SubItems.Add("VIRTUAL BOY")
																		Case "GameBoyAdvance"
																			List1.Items(counter).SubItems.Add("GAME BOY ADVANCE")
																		Case "SNES"
																			List1.Items(counter).SubItems.Add("SNES")
																		Case "NES"
																			List1.Items(counter).SubItems.Add("NES")
																		Case "NDS"
																			List1.Items(counter).SubItems.Add("NDS")
																		Case "3DS"
																			List1.Items(counter).SubItems.Add("3DS")
																		Case "GameBoy"
																			List1.Items(counter).SubItems.Add("GAME BOY")
																	End Select
																	List1.Items(counter).SubItems.Add(Game(pos).Parts)
																	List1.Items(counter).SubItems.Add(Game(pos).N_Part)
																	List1.Items(counter).SubItems.Add(pos)
																	List1.Items(counter).SubItems.Add(Game(pos).Image)
																	pos = pos + 1
																	counter = counter + 1
																End If
															Next index1
														End If

														If List1.Items.Count = 0 Then
														Else
															Name_Game_Label.Text = "Name Game: " & List1.Items.Item(0).SubItems(1).Text
															Type_label.Text = "Type: " & List1.Items.Item(0).SubItems(2).Text
															Format_label.Text = "Format: " & List1.Items.Item(0).SubItems(6).Text
															User_label.Text = "User: " & List1.Items.Item(0).SubItems(4).Text
															Version_label.Text = "Version: " & List1.Items.Item(0).SubItems(5).Text
															Region_label.Text = "Region: " & List1.Items.Item(0).SubItems(3).Text
														End If

														Me.Cursor = Cursors.Default
													End If
												End If
											End If
										End If
									End If
								End If
							End If
						End If
					End If
				End If
			End If
		End If

	End Sub

	Private Sub List1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles List1.SelectedIndexChanged
		'MsgBox(sender & " ee " & e)
		Name_Game_Label.Text = "Name Game: " & List1.Items.Item(List1.FocusedItem.Index).SubItems(1).Text
		Type_label.Text = "Type: " & List1.Items.Item(List1.FocusedItem.Index).SubItems(3).Text
		Format_label.Text = "Format: " & List1.Items.Item(List1.FocusedItem.Index).SubItems(6).Text
		User_label.Text = "User: " & List1.Items.Item(List1.FocusedItem.Index).SubItems(4).Text
		Version_label.Text = "Version: " & List1.Items.Item(List1.FocusedItem.Index).SubItems(5).Text
		Region_label.Text = "Region: " & List1.Items.Item(List1.FocusedItem.Index).SubItems(2).Text
		Link_Game = AES_Decrypt(List1.Items.Item(List1.FocusedItem.Index).SubItems(7).Text)
		Platform_Game = List1.Items.Item(List1.FocusedItem.Index).SubItems(8).Text
		Version_Game = List1.Items.Item(List1.FocusedItem.Index).SubItems(5).Text
		format_Game = List1.Items.Item(List1.FocusedItem.Index).SubItems(6).Text
		Name_Game = List1.Items.Item(List1.FocusedItem.Index).SubItems(1).Text
		Region_Game = List1.Items.Item(List1.FocusedItem.Index).SubItems(3).Text
		Game_Part = List1.Items.Item(List1.FocusedItem.Index).SubItems(9).Text
		Game_Num = List1.Items.Item(List1.FocusedItem.Index).SubItems(10).Text

		'MsgBox(Game_Part)
		'MsgBox(Game_Num)
		If Game_Part = True Then
			DownParts.Visible = True
			DownParts.Enabled = True
			DownParts.Items.Clear()
			DownParts.Items.Add("ALL")
			DownParts.Text = "ALL"
			Dim i As Integer = 0
			For i = 1 To Game_Num
				DownParts.Items.Add(i)
			Next
		Else
			DownParts.Visible = False
			DownParts.Enabled = False
		End If

		If load_images_games = False Then
			If List1.Items.Item(List1.FocusedItem.Index).SubItems(12).Text = "" Then
			Else
				PictureBox3.Load(List1.Items.Item(List1.FocusedItem.Index).SubItems(12).Text)
				'	MsgBox("1")
			End If
		End If
	End Sub

	Private Sub Button_Download_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Download.Click

		myFile = Application.StartupPath & "\Roms\" & Platform_Game & "\[" & Platform_Game & "][" & Region_Game & "]" & Name_Game & "." & format_Game
		myWebClient = New Net.WebClient
		ProgressBar1.Value = 0
		Me.Text = "Project Koppai v2.3   Downloading..."
		Dim i As Integer = 0

		Dim Listita As List(Of ListTwo)
		Dim Plataforma As String
		Select Case Platform_Game
			Case "WII"
				Plataforma = "Wii"
			Case "WII U"
				Plataforma = "WiiU"
			Case "NINTENDO SWICH"
				Plataforma = "NSwich"
			Case "NINTENDO 64"
				Plataforma = "N64"
			Case "GAMECUBE"
				Plataforma = "GameCube"
			Case "VIRTUAL BOY"
				Plataforma = "VirtualBoy"
			Case "GAME BOY ADVANCE"
				Plataforma = "GameBoyAdvance"
			Case "SNES"
				Plataforma = "SNES"
			Case "NES"
				Plataforma = "NES"
			Case "NDS"
				Plataforma = "NDS"
			Case "3DS"
				Plataforma = "3DS"
			Case "GAME BOY"
				Plataforma = "GameBoy"
			Case Else

		End Select
#Disable Warning BC42104 ' Se usa la variable antes de que se le haya asignado un valor
		'MsgBox()
		Dim localpath As String
		localpath = File.ReadAllText(Application.StartupPath & "\List\Games-List-" & Plataforma)
		Listita = JsonConvert.DeserializeObject(Of List(Of ListTwo))(localpath)
#Enable Warning BC42104 ' Se usa la variable antes de que se le haya asignado un valor
		If Game_Part = False Then
			'Link_Game = ""
			myWebClient.DownloadFileAsync(New Uri(Link_Game), myFile)
		Else
			If DownParts.Text = "ALL" Then
				For i = 1 To Game_Num
					myWebClient.DownloadFileAsync(New Uri(Listita(Game_Num).Encrypt(i)), "[Part:" & i & "]" & myFile)
				Next
			End If
		End If
	End Sub

#Disable Warning IDE1006 ' Estilos de nombres
	Private Sub myWebClient_DownloadFileCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs) Handles myWebClient.DownloadFileCompleted
#Enable Warning IDE1006 ' Estilos de nombres
		If ProgressBar1.Value = ProgressBar1.Maximum Then
			MsgBox("Download Completed", MsgBoxStyle.Information)
			Me.Text = "Project Koppai v2.4"
			'Button1.Enabled = True
		Else
			IO.File.Delete(myFile) '// Delete File if Download is NOT Complete.
		End If
	End Sub

#Disable Warning IDE1006 ' Estilos de nombres
	Public Sub myWebClient_DownloadProgressChanged(ByVal sender As Object, ByVal e As System.Net.DownloadProgressChangedEventArgs) Handles myWebClient.DownloadProgressChanged
#Enable Warning IDE1006 ' Estilos de nombres
		Try
			Dim dDownloadProgress As Decimal = CStr(e.BytesReceived / e.TotalBytesToReceive * 100)
			ProgressBar1.Value = CInt(dDownloadProgress)
			'// Display Download Status.
			Dim dDownloadedMB As Decimal = Format((e.BytesReceived / 1024) / 1024, "###,###,##0.00")
			Dim dTotalToDownloadMB As Decimal = Format((e.TotalBytesToReceive / 1024) / 1024, "###,###,##0.00")
			Progres_KB.Text = dDownloadedMB & "/" & dTotalToDownloadMB & "MB"
			Me.Text = "Project Koppai v2.4    Downloaded: " & dDownloadedMB & "MB out of " & dTotalToDownloadMB & "MB - Progress: " _
				& Format(dDownloadProgress, "###.00") & "%"
		Catch ex As Exception
		End Try
	End Sub

	Private Sub Form1_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing


	End Sub

	Private Sub Upload_Add_item_Click(sender As Object, e As EventArgs) Handles Upload_Add_item.Click


		Dim founditem As ListViewItem = ListView1.FindItemWithText(TextBox3.Text)
		If Not (founditem Is Nothing) Then
			Exit Sub
		Else
			If TextBox3.Text = "Name Game" Then
			Else
				If TextBox7.Text = "Url Image" Then
				Else
					If TextBox7.Text = "" Then
					Else
						If PicExist(TextBox7.Text) = True Then
							If TextBox3.Text = "" Then
							Else
								If TextBox4.Text = "Your Name" Then
								Else
									If TextBox4.Text = "" Then
									Else
										If TextBox5.Text = "Version" Then
										Else
											If TextBox5.Text = "" Then
											Else
												If TextBox6.Text = "Format" Then
												Else
													If TextBox6.Text = "" Then
													Else
														If TextBox2.Text = "Link Game(Please Read Wiki)" Then
														Else
															If TextBox2.Text = "" Then
															Else
																If GameID_Checkbox.CheckState = False Then
																	ListView1.Items.Add(counter2)
																	ListView1.Items(counter2).SubItems.Add(TextBox3.Text)
																	ListView1.Items(counter2).SubItems.Add(ComboBox2.Text)
																	ListView1.Items(counter2).SubItems.Add(ComboBox3.Text)
																	ListView1.Items(counter2).SubItems.Add(TextBox4.Text)
																	ListView1.Items(counter2).SubItems.Add(TextBox5.Text)
																	ListView1.Items(counter2).SubItems.Add(TextBox6.Text)
																	ListView1.Items(counter2).SubItems.Add(TextBox2.Text)
																	ListView1.Items(counter2).SubItems.Add(platfom2)
																	ListView1.Items(counter2).SubItems.Add(Parts)
																	ListView1.Items(counter2).SubItems.Add("")
																	ListView1.Items(counter2).SubItems.Add(TextBox7.Text)
																	counter2 += 1
																Else
																	If ID_Game.Text = "ID Game" Then
																	Else
																		If ID_Game.Text = "" Then
																		Else
																			ListView1.Items.Add(ID_Game.Text)
																			ListView1.Items(counter2).SubItems.Add(TextBox3.Text)
																			ListView1.Items(counter2).SubItems.Add(ComboBox2.Text)
																			ListView1.Items(counter2).SubItems.Add(ComboBox3.Text)
																			ListView1.Items(counter2).SubItems.Add(TextBox4.Text)
																			ListView1.Items(counter2).SubItems.Add(TextBox5.Text)
																			ListView1.Items(counter2).SubItems.Add(TextBox6.Text)
																			ListView1.Items(counter2).SubItems.Add(TextBox2.Text)
																			ListView1.Items(counter2).SubItems.Add(platfom2)
																			ListView1.Items(counter2).SubItems.Add(Parts)
																			ListView1.Items(counter2).SubItems.Add("")
																			ListView1.Items(counter2).SubItems.Add(TextBox7.Text)
																			counter2 += 1
																		End If
																	End If
																End If
															End If
														End If
													End If
												End If
											End If
										End If
									End If
								End If
							End If
						End If
					End If
				End If
			End If
			End If
	End Sub

	Private Sub TresDS_BOTONCITOS_CheckedChanged(sender As Object, e As EventArgs) Handles TresDS_BOTONCITOS.CheckedChanged
		platfom2 = "3DS"
	End Sub
	Private Sub NDS_BOTONCITOS_CheckedChanged(sender As Object, e As EventArgs) Handles NDS_BOTONCITOS.CheckedChanged
		platfom2 = "NDS"
	End Sub
	Private Sub GameBoy_BOTONCITOS_CheckedChanged(sender As Object, e As EventArgs) Handles GameBoy_BOTONCITOS.CheckedChanged
		platfom2 = "GameBoy"
	End Sub
	Private Sub GameBoyAdvance_BOTONCITOS_CheckedChanged(sender As Object, e As EventArgs) Handles GameBoyAdvance_BOTONCITOS.CheckedChanged
		platfom2 = "GameBoyAdvance"
	End Sub
	Private Sub GameCube_BOTONCITOS_CheckedChanged(sender As Object, e As EventArgs) Handles GameCube_BOTONCITOS.CheckedChanged
		platfom2 = "GameCube"
	End Sub
	Private Sub NES_BOTONCITOS_CheckedChanged(sender As Object, e As EventArgs) Handles NES_BOTONCITOS.CheckedChanged
		platfom2 = "NES"
	End Sub
	Private Sub Snes_BOTONCITOS_CheckedChanged(sender As Object, e As EventArgs) Handles Snes_BOTONCITOS.CheckedChanged
		platfom2 = "SNES"
	End Sub
	Private Sub N64_BOTONCITOS_CheckedChanged(sender As Object, e As EventArgs) Handles N64_BOTONCITOS.CheckedChanged
		platfom2 = "N64"
	End Sub
	Private Sub NS_BOTONCITOS_CheckedChanged(sender As Object, e As EventArgs) Handles NS_BOTONCITOS.CheckedChanged
		platfom2 = "NSwich"
	End Sub
	Private Sub VB_BOTONCITOS_CheckedChanged(sender As Object, e As EventArgs) Handles VB_BOTONCITOS.CheckedChanged
		platfom2 = "VirtualBoy"
	End Sub
#Disable Warning IDE1006 ' Estilos de nombres
	Private Sub wii_BOTONCITOS_CheckedChanged(sender As Object, e As EventArgs) Handles wii_BOTONCITOS.CheckedChanged
#Enable Warning IDE1006 ' Estilos de nombres
		platfom2 = "Wii"
	End Sub
#Disable Warning IDE1006 ' Estilos de nombres
	Private Sub wiiu_BOTONCITOS_CheckedChanged(sender As Object, e As EventArgs) Handles wiiu_BOTONCITOS.CheckedChanged
#Enable Warning IDE1006 ' Estilos de nombres
		platfom2 = "WiiU"
	End Sub

	Private Sub Upload_To_ftp_Click(sender As Object, e As EventArgs) Handles Upload_To_ftp.Click
		Dim NPath As Integer

		Dim words As String()

		Me.Cursor = Cursors.WaitCursor
		Dim path As String
		Do While ListView1.Items.Count >= "0"

			If ListView1.Items(0).SubItems.Item(8).Text = "NDS" Then

				path = Application.StartupPath & "\Uploader\List\" & "[" & ListView1.Items(0).SubItems.Item(8).Text & "]" & counter3 & ".txt"
				Name_Send = ListView1.Items(0).SubItems.Item(4).Text
				Dim w1 As New System.IO.StreamWriter(path)
				w1.WriteLine("        {")
				w1.WriteLine("            ""ID"": """ & ListView1.Items.Count & """,")
				w1.WriteLine("            ""Type"": """ & ListView1.Items(0).SubItems.Item(2).Text & """,")
				w1.WriteLine("            ""Name"": """ & ListView1.Items(0).SubItems.Item(1).Text & """,")
				w1.WriteLine("            ""Region"": """ & ListView1.Items(0).SubItems.Item(3).Text & """,")
				w1.WriteLine("            ""User"": """ & ListView1.Items(0).SubItems.Item(4).Text & """,")
				w1.WriteLine("            ""Version"": """ & ListView1.Items(0).SubItems.Item(5).Text & """,")
				w1.WriteLine("            ""Format"": """ & ListView1.Items(0).SubItems.Item(6).Text & """,")
				w1.WriteLine("            ""Image"": """ & ListView1.Items(0).SubItems.Item(11).Text & """,")
				w1.WriteLine("            ""Parts"": """ & ListView1.Items(0).SubItems.Item(9).Text & """,")
				w1.WriteLine("            ""Encrypt"":  [")
				words = ListView1.Items(0).SubItems.Item(7).Text.Split(New String() {Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries)
				Dim word As String
				For Each word In words
					'MsgBox(word.Length())
					NPath = NPath + 1
					w1.WriteLine("             """ & AES_Encrypt(word) & """,")
				Next

				w1.WriteLine("        ],")
				w1.WriteLine("            ""N_Part"": """ & NPath & """")
				w1.WriteLine("        },")
				w1.Close()

				ListView1.Items.RemoveAt(0)
				counter3 = counter3 + 1
				If ListView1.Items.Count = "0" Then
					Exit Do

				End If
			End If

			If ListView1.Items(0).SubItems.Item(8).Text = "NSwich" Then
				Name_Send = ListView1.Items(0).SubItems.Item(4).Text
				path = Application.StartupPath & "\Uploader\List\" & "[" & ListView1.Items(0).SubItems.Item(8).Text & "]" & counter3 & ".txt"
				NPath = 0
				Dim w2 As New System.IO.StreamWriter(path)
				w2.WriteLine("        {")
				w2.WriteLine("            ""ID"": """ & ListView1.Items.Count & """,")
				w2.WriteLine("            ""Type"": """ & ListView1.Items(0).SubItems.Item(2).Text & """,")
				w2.WriteLine("            ""Name"": """ & ListView1.Items(0).SubItems.Item(1).Text & """,")
				w2.WriteLine("            ""Region"": """ & ListView1.Items(0).SubItems.Item(3).Text & """,")
				w2.WriteLine("            ""User"": """ & ListView1.Items(0).SubItems.Item(4).Text & """,")
				w2.WriteLine("            ""Version"": """ & ListView1.Items(0).SubItems.Item(5).Text & """,")
				w2.WriteLine("            ""Format"": """ & ListView1.Items(0).SubItems.Item(6).Text & """,")
				w2.WriteLine("            ""Image"": """ & ListView1.Items(0).SubItems.Item(11).Text & """,")
				w2.WriteLine("            ""Parts"": """ & ListView1.Items(0).SubItems.Item(9).Text & """,")
				w2.WriteLine("            ""Encrypt"":  [")
				words = ListView1.Items(0).SubItems.Item(7).Text.Split(New String() {Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries)
				Dim word As String
				For Each word In words
					NPath = NPath + 1
					w2.WriteLine("             """ & AES_Encrypt(word) & """,")
				Next

				w2.WriteLine("        ],")
				w2.WriteLine("            ""N_Part"": """ & NPath & """")
				w2.WriteLine("        },")
				w2.Close()
				ListView1.Items.RemoveAt(0)
				counter3 = counter3 + 1
				If ListView1.Items.Count = "0" Then
					Exit Do
				End If
			End If

			If ListView1.Items(0).SubItems.Item(8).Text = "Wii" Then
				Name_Send = ListView1.Items(0).SubItems.Item(4).Text
				path = Application.StartupPath & "\Uploader\List\" & "[" & ListView1.Items(0).SubItems.Item(8).Text & "]" & counter3 & ".txt"
				NPath = 0
				Dim w3 As New System.IO.StreamWriter(path)
				w3.WriteLine("        {")
				w3.WriteLine("            ""ID"": """ & ListView1.Items.Count & """,")
				w3.WriteLine("            ""Type"": """ & ListView1.Items(0).SubItems.Item(2).Text & """,")
				w3.WriteLine("            ""Name"": """ & ListView1.Items(0).SubItems.Item(1).Text & """,")
				w3.WriteLine("            ""Region"": """ & ListView1.Items(0).SubItems.Item(3).Text & """,")
				w3.WriteLine("            ""User"": """ & ListView1.Items(0).SubItems.Item(4).Text & """,")
				w3.WriteLine("            ""Version"": """ & ListView1.Items(0).SubItems.Item(5).Text & """,")
				w3.WriteLine("            ""Format"": """ & ListView1.Items(0).SubItems.Item(6).Text & """,")
				w3.WriteLine("            ""Image"": """ & ListView1.Items(0).SubItems.Item(11).Text & """,")
				w3.WriteLine("            ""Parts"": """ & ListView1.Items(0).SubItems.Item(9).Text & """,")
				w3.WriteLine("            ""Encrypt"":  [")
				words = ListView1.Items(0).SubItems.Item(7).Text.Split(New String() {Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries)
				Dim word As String
				For Each word In words
					NPath = NPath + 1
					w3.WriteLine("             """ & AES_Encrypt(word) & """,")
				Next

				w3.WriteLine("        ],")
				w3.WriteLine("            ""N_Part"": """ & NPath & """")
				w3.WriteLine("        },")
				w3.Close()
				ListView1.Items.RemoveAt(0)
				counter3 = counter3 + 1
				If ListView1.Items.Count = "0" Then
					Exit Do
				End If
			End If

			If ListView1.Items(0).SubItems.Item(8).Text = "WiiU" Then
				Name_Send = ListView1.Items(0).SubItems.Item(4).Text
				path = Application.StartupPath & "\Uploader\List\" & "[" & ListView1.Items(0).SubItems.Item(8).Text & "]" & counter3 & ".txt"
				NPath = 0
				Dim w4 As New System.IO.StreamWriter(path)
				w4.WriteLine("        {")
				w4.WriteLine("            ""ID"": """ & ListView1.Items.Count & """,")
				w4.WriteLine("            ""Type"": """ & ListView1.Items(0).SubItems.Item(2).Text & """,")
				w4.WriteLine("            ""Name"": """ & ListView1.Items(0).SubItems.Item(1).Text & """,")
				w4.WriteLine("            ""Region"": """ & ListView1.Items(0).SubItems.Item(3).Text & """,")
				w4.WriteLine("            ""User"": """ & ListView1.Items(0).SubItems.Item(4).Text & """,")
				w4.WriteLine("            ""Version"": """ & ListView1.Items(0).SubItems.Item(5).Text & """,")
				w4.WriteLine("            ""Format"": """ & ListView1.Items(0).SubItems.Item(6).Text & """,")
				w4.WriteLine("            ""Image"": """ & ListView1.Items(0).SubItems.Item(11).Text & """,")
				w4.WriteLine("            ""Parts"": """ & ListView1.Items(0).SubItems.Item(9).Text & """,")
				w4.WriteLine("            ""Encrypt"":  [")
				words = ListView1.Items(0).SubItems.Item(7).Text.Split(New String() {Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries)
				Dim word As String
				For Each word In words
					NPath = NPath + 1
					w4.WriteLine("             """ & AES_Encrypt(word) & """,")
				Next

				w4.WriteLine("        ],")
				w4.WriteLine("            ""N_Part"": """ & NPath & """")
				w4.WriteLine("        },")
				w4.Close()
				ListView1.Items.RemoveAt(0)
				counter3 = counter3 + 1
				If ListView1.Items.Count = "0" Then
					Exit Do
				End If
			End If

			If ListView1.Items(0).SubItems.Item(8).Text = "N64" Then
				Name_Send = ListView1.Items(0).SubItems.Item(4).Text
				path = Application.StartupPath & "\Uploader\List\" & "[" & ListView1.Items(0).SubItems.Item(8).Text & "]" & counter3 & ".txt"
				NPath = 0
				Dim w5 As New System.IO.StreamWriter(path)
				w5.WriteLine("        {")
				w5.WriteLine("            ""ID"": """ & ListView1.Items.Count & """,")
				w5.WriteLine("            ""Type"": """ & ListView1.Items(0).SubItems.Item(2).Text & """,")
				w5.WriteLine("            ""Name"": """ & ListView1.Items(0).SubItems.Item(1).Text & """,")
				w5.WriteLine("            ""Region"": """ & ListView1.Items(0).SubItems.Item(3).Text & """,")
				w5.WriteLine("            ""User"": """ & ListView1.Items(0).SubItems.Item(4).Text & """,")
				w5.WriteLine("            ""Version"": """ & ListView1.Items(0).SubItems.Item(5).Text & """,")
				w5.WriteLine("            ""Format"": """ & ListView1.Items(0).SubItems.Item(6).Text & """,")
				w5.WriteLine("            ""Image"": """ & ListView1.Items(0).SubItems.Item(11).Text & """,")
				w5.WriteLine("            ""Parts"": """ & ListView1.Items(0).SubItems.Item(9).Text & """,")
				w5.WriteLine("            ""Encrypt"":  [")
				words = ListView1.Items(0).SubItems.Item(7).Text.Split(New String() {Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries)
				Dim word As String
				For Each word In words
					NPath = NPath + 1
					w5.WriteLine("             """ & AES_Encrypt(word) & """,")
				Next

				w5.WriteLine("        ],")
				w5.WriteLine("            ""N_Part"": """ & NPath & """")
				w5.WriteLine("        },")
				w5.Close()
				ListView1.Items.RemoveAt(0)
				counter3 = counter3 + 1
				If ListView1.Items.Count = "0" Then
					Exit Do
				End If
			End If

			If ListView1.Items(0).SubItems.Item(8).Text = "GameCube" Then
				Name_Send = ListView1.Items(0).SubItems.Item(4).Text
				path = Application.StartupPath & "\Uploader\List\" & "[" & ListView1.Items(0).SubItems.Item(8).Text & "]" & counter3 & ".txt"
				NPath = 0
				Dim w6 As New System.IO.StreamWriter(path)
				w6.WriteLine("        {")
				w6.WriteLine("            ""ID"": """ & ListView1.Items.Count & """,")
				w6.WriteLine("            ""Type"": """ & ListView1.Items(0).SubItems.Item(2).Text & """,")
				w6.WriteLine("            ""Name"": """ & ListView1.Items(0).SubItems.Item(1).Text & """,")
				w6.WriteLine("            ""Region"": """ & ListView1.Items(0).SubItems.Item(3).Text & """,")
				w6.WriteLine("            ""User"": """ & ListView1.Items(0).SubItems.Item(4).Text & """,")
				w6.WriteLine("            ""Version"": """ & ListView1.Items(0).SubItems.Item(5).Text & """,")
				w6.WriteLine("            ""Format"": """ & ListView1.Items(0).SubItems.Item(6).Text & """,")
				w6.WriteLine("            ""Image"": """ & ListView1.Items(0).SubItems.Item(11).Text & """,")
				w6.WriteLine("            ""Parts"": """ & ListView1.Items(0).SubItems.Item(9).Text & """,")
				w6.WriteLine("            ""Encrypt"":  [")
				words = ListView1.Items(0).SubItems.Item(7).Text.Split(New String() {Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries)
				Dim word As String
				For Each word In words
					NPath = NPath + 1
					w6.WriteLine("             """ & AES_Encrypt(word) & """,")
				Next

				w6.WriteLine("        ],")
				w6.WriteLine("            ""N_Part"": """ & NPath & """")
				w6.WriteLine("        },")
				w6.Close()
				ListView1.Items.RemoveAt(0)
				counter3 = counter3 + 1
				If ListView1.Items.Count = "0" Then
					Exit Do
				End If
			End If

			If ListView1.Items(0).SubItems.Item(8).Text = "VirtualBoy" Then
				Name_Send = ListView1.Items(0).SubItems.Item(4).Text
				path = Application.StartupPath & "\Uploader\List\" & "[" & ListView1.Items(0).SubItems.Item(8).Text & "]" & counter3 & ".txt"
				NPath = 0
				Dim w7 As New System.IO.StreamWriter(path)
				w7.WriteLine("        {")
				w7.WriteLine("            ""ID"": """ & ListView1.Items.Count & """,")
				w7.WriteLine("            ""Type"": """ & ListView1.Items(0).SubItems.Item(2).Text & """,")
				w7.WriteLine("            ""Name"": """ & ListView1.Items(0).SubItems.Item(1).Text & """,")
				w7.WriteLine("            ""Region"": """ & ListView1.Items(0).SubItems.Item(3).Text & """,")
				w7.WriteLine("            ""User"": """ & ListView1.Items(0).SubItems.Item(4).Text & """,")
				w7.WriteLine("            ""Version"": """ & ListView1.Items(0).SubItems.Item(5).Text & """,")
				w7.WriteLine("            ""Format"": """ & ListView1.Items(0).SubItems.Item(6).Text & """,")
				w7.WriteLine("            ""Image"": """ & ListView1.Items(0).SubItems.Item(11).Text & """,")
				w7.WriteLine("            ""Parts"": """ & ListView1.Items(0).SubItems.Item(9).Text & """,")
				w7.WriteLine("            ""Encrypt"":  [")
				words = ListView1.Items(0).SubItems.Item(7).Text.Split(New String() {Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries)
				Dim word As String
				For Each word In words
					NPath = NPath + 1
					w7.WriteLine("             """ & AES_Encrypt(word) & """,")
				Next

				w7.WriteLine("        ],")
				w7.WriteLine("            ""N_Part"": """ & NPath & """")
				w7.WriteLine("        },")
				w7.Close()
				ListView1.Items.RemoveAt(0)
				counter3 = counter3 + 1
				If ListView1.Items.Count = "0" Then
					Exit Do
				End If
			End If

			If ListView1.Items(0).SubItems.Item(8).Text = "GameBoyAdvance" Then
				Name_Send = ListView1.Items(0).SubItems.Item(4).Text
				path = Application.StartupPath & "\Uploader\List\" & "[" & ListView1.Items(0).SubItems.Item(8).Text & "]" & counter3 & ".txt"
				NPath = 0
				Dim w8 As New System.IO.StreamWriter(path)
				w8.WriteLine("        {")
				w8.WriteLine("            ""ID"": """ & ListView1.Items.Count & """,")
				w8.WriteLine("            ""Type"": """ & ListView1.Items(0).SubItems.Item(2).Text & """,")
				w8.WriteLine("            ""Name"": """ & ListView1.Items(0).SubItems.Item(1).Text & """,")
				w8.WriteLine("            ""Region"": """ & ListView1.Items(0).SubItems.Item(3).Text & """,")
				w8.WriteLine("            ""User"": """ & ListView1.Items(0).SubItems.Item(4).Text & """,")
				w8.WriteLine("            ""Version"": """ & ListView1.Items(0).SubItems.Item(5).Text & """,")
				w8.WriteLine("            ""Format"": """ & ListView1.Items(0).SubItems.Item(6).Text & """,")
				w8.WriteLine("            ""Image"": """ & ListView1.Items(0).SubItems.Item(11).Text & """,")
				w8.WriteLine("            ""Parts"": """ & ListView1.Items(0).SubItems.Item(9).Text & """,")
				w8.WriteLine("            ""Encrypt"":  [")
				words = ListView1.Items(0).SubItems.Item(7).Text.Split(New String() {Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries)
				Dim word As String
				For Each word In words
					NPath = NPath + 1
					w8.WriteLine("             """ & AES_Encrypt(word) & """,")
				Next

				w8.WriteLine("        ],")
				w8.WriteLine("            ""N_Part"": """ & NPath & """")
				w8.WriteLine("        },")
				w8.Close()
				ListView1.Items.RemoveAt(0)
				counter3 = counter3 + 1
				If ListView1.Items.Count = "0" Then
					Exit Do
				End If
			End If

			If ListView1.Items(0).SubItems.Item(8).Text = "SNES" Then
				Name_Send = ListView1.Items(0).SubItems.Item(4).Text
				path = Application.StartupPath & "\Uploader\List\" & "[" & ListView1.Items(0).SubItems.Item(8).Text & "]" & counter3 & ".txt"
				NPath = 0
				Dim w9 As New System.IO.StreamWriter(path)
				w9.WriteLine("        {")
				w9.WriteLine("            ""ID"": """ & ListView1.Items.Count & """,")
				w9.WriteLine("            ""Type"": """ & ListView1.Items(0).SubItems.Item(2).Text & """,")
				w9.WriteLine("            ""Name"": """ & ListView1.Items(0).SubItems.Item(1).Text & """,")
				w9.WriteLine("            ""Region"": """ & ListView1.Items(0).SubItems.Item(3).Text & """,")
				w9.WriteLine("            ""User"": """ & ListView1.Items(0).SubItems.Item(4).Text & """,")
				w9.WriteLine("            ""Version"": """ & ListView1.Items(0).SubItems.Item(5).Text & """,")
				w9.WriteLine("            ""Format"": """ & ListView1.Items(0).SubItems.Item(6).Text & """,")
				w9.WriteLine("            ""Image"": """ & ListView1.Items(0).SubItems.Item(11).Text & """,")
				w9.WriteLine("            ""Parts"": """ & ListView1.Items(0).SubItems.Item(9).Text & """,")
				w9.WriteLine("            ""Encrypt"":  [")
				words = ListView1.Items(0).SubItems.Item(7).Text.Split(New String() {Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries)
				Dim word As String
				For Each word In words
					NPath = NPath + 1
					w9.WriteLine("             """ & AES_Encrypt(word) & """,")
				Next

				w9.WriteLine("        ],")
				w9.WriteLine("            ""N_Part"": """ & NPath & """")
				w9.WriteLine("        },")
				w9.Close()
				ListView1.Items.RemoveAt(0)
				counter3 = counter3 + 1
				If ListView1.Items.Count = "0" Then
					Exit Do
				End If
			End If

			If ListView1.Items(0).SubItems.Item(8).Text = "NES" Then
				Name_Send = ListView1.Items(0).SubItems.Item(4).Text
				path = Application.StartupPath & "\Uploader\List\" & "[" & ListView1.Items(0).SubItems.Item(8).Text & "]" & counter3 & ".txt"
				NPath = 0
				Dim w10 As New System.IO.StreamWriter(path)
				w10.WriteLine("        {")
				w10.WriteLine("            ""ID"": """ & ListView1.Items.Count & """,")
				w10.WriteLine("            ""Type"": """ & ListView1.Items(0).SubItems.Item(2).Text & """,")
				w10.WriteLine("            ""Name"": """ & ListView1.Items(0).SubItems.Item(1).Text & """,")
				w10.WriteLine("            ""Region"": """ & ListView1.Items(0).SubItems.Item(3).Text & """,")
				w10.WriteLine("            ""User"": """ & ListView1.Items(0).SubItems.Item(4).Text & """,")
				w10.WriteLine("            ""Version"": """ & ListView1.Items(0).SubItems.Item(5).Text & """,")
				w10.WriteLine("            ""Format"": """ & ListView1.Items(0).SubItems.Item(6).Text & """,")
				w10.WriteLine("            ""Image"": """ & ListView1.Items(0).SubItems.Item(11).Text & """,")
				w10.WriteLine("            ""Parts"": """ & ListView1.Items(0).SubItems.Item(9).Text & """,")
				w10.WriteLine("            ""Encrypt"":  [")
				words = ListView1.Items(0).SubItems.Item(7).Text.Split(New String() {Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries)
				Dim word As String
				For Each word In words
					NPath = NPath + 1
					w10.WriteLine("             """ & AES_Encrypt(word) & """,")
				Next

				w10.WriteLine("        ],")
				w10.WriteLine("            ""N_Part"": """ & NPath & """")
				w10.WriteLine("        },")
				w10.Close()
				ListView1.Items.RemoveAt(0)
				counter3 = counter3 + 1
				If ListView1.Items.Count = "0" Then
					Exit Do
				End If
			End If

			If ListView1.Items(0).SubItems.Item(8).Text = "3DS" Then
				Name_Send = ListView1.Items(0).SubItems.Item(4).Text
				path = Application.StartupPath & "\Uploader\List\" & "[" & ListView1.Items(0).SubItems.Item(8).Text & "]" & counter3 & ".txt"
				NPath = 0
				Dim w11 As New System.IO.StreamWriter(path)
				w11.WriteLine("        {")
				w11.WriteLine("            ""ID"": """ & ListView1.Items.Count & """,")
				w11.WriteLine("            ""Type"": """ & ListView1.Items(0).SubItems.Item(2).Text & """,")
				w11.WriteLine("            ""Name"": """ & ListView1.Items(0).SubItems.Item(1).Text & """,")
				w11.WriteLine("            ""Region"": """ & ListView1.Items(0).SubItems.Item(3).Text & """,")
				w11.WriteLine("            ""User"": """ & ListView1.Items(0).SubItems.Item(4).Text & """,")
				w11.WriteLine("            ""Version"": """ & ListView1.Items(0).SubItems.Item(5).Text & """,")
				w11.WriteLine("            ""Format"": """ & ListView1.Items(0).SubItems.Item(6).Text & """,")
				w11.WriteLine("            ""Image"": """ & ListView1.Items(0).SubItems.Item(11).Text & """,")
				w11.WriteLine("            ""Parts"": """ & ListView1.Items(0).SubItems.Item(9).Text & """,")
				w11.WriteLine("            ""Encrypt"":  [")
				words = ListView1.Items(0).SubItems.Item(7).Text.Split(New String() {Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries)
				Dim word As String
				For Each word In words
					NPath = NPath + 1
					w11.WriteLine("             """ & AES_Encrypt(word) & """,")
				Next

				w11.WriteLine("        ],")
				w11.WriteLine("            ""N_Part"": """ & NPath & """")
				w11.WriteLine("        },")
				w11.Close()
				ListView1.Items.RemoveAt(0)
				counter3 = counter3 + 1
				If ListView1.Items.Count = "0" Then
					Exit Do
				End If
			End If

			If ListView1.Items(0).SubItems.Item(8).Text = "GameBoy" Then
				Name_Send = ListView1.Items(0).SubItems.Item(4).Text
				path = Application.StartupPath & "\Uploader\List\" & "[" & ListView1.Items(0).SubItems.Item(8).Text & "]" & counter3 & ".txt"
				NPath = 0
				Dim w12 As New System.IO.StreamWriter(path)
				w12.WriteLine("        {")
				w12.WriteLine("            ""ID"": """ & ListView1.Items.Count & """,")
				w12.WriteLine("            ""Type"": """ & ListView1.Items(0).SubItems.Item(2).Text & """,")
				w12.WriteLine("            ""Name"": """ & ListView1.Items(0).SubItems.Item(1).Text & """,")
				w12.WriteLine("            ""Region"": """ & ListView1.Items(0).SubItems.Item(3).Text & """,")
				w12.WriteLine("            ""User"": """ & ListView1.Items(0).SubItems.Item(4).Text & """,")
				w12.WriteLine("            ""Version"": """ & ListView1.Items(0).SubItems.Item(5).Text & """,")
				w12.WriteLine("            ""Format"": """ & ListView1.Items(0).SubItems.Item(6).Text & """,")
				w12.WriteLine("            ""Image"": """ & ListView1.Items(0).SubItems.Item(11).Text & """,")
				w12.WriteLine("            ""Parts"": """ & ListView1.Items(0).SubItems.Item(9).Text & """,")
				w12.WriteLine("            ""Encrypt"":  [")
				words = ListView1.Items(0).SubItems.Item(7).Text.Split(New String() {Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries)
				Dim word As String
				For Each word In words
					NPath = NPath + 1
					w12.WriteLine("             """ & AES_Encrypt(word) & """,")
				Next
				w12.WriteLine("        ],")
				w12.WriteLine("            ""N_Part"": """ & NPath & """")
				w12.WriteLine("        },")
				w12.Close()
				ListView1.Items.RemoveAt(0)
				counter3 = counter3 + 1
				If ListView1.Items.Count = "0" Then
					Exit Do
				End If
			End If

		Loop
		Send()
		counter2 = 0
		Me.Cursor = Cursors.Default
	End Sub

	Public Class ListTwo
		Public Name As String
		Public ID As String
		Public Type As String
		Public Format As String
		Public Image As String
		Public User As String
		Public Version As String
		Public Encrypt() As String
		Public Region As String
		Public N_Part As Integer
		Public Parts As Boolean
	End Class

	Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
		'search
	End Sub

	Private Sub Send()

		Try


			Dim Smtp_Server As New SmtpClient
			Dim e_mail As New MailMessage()
			Dim attachment As System.Net.Mail.Attachment

			Smtp_Server.UseDefaultCredentials = False
			Smtp_Server.Credentials = New Net.NetworkCredential(("projectkoppaisender@gmail.com"), ("Sender1234"))


			'sending failure
			Smtp_Server.Port = "587" 'cannot be read
			Smtp_Server.EnableSsl = True 'cannot be read
			Smtp_Server.Host = "smtp.gmail.com" 'cannot be read

#Disable Warning IDE0017 ' Simplificar la inicialización de objetos
			e_mail = New MailMessage()
#Enable Warning IDE0017 ' Simplificar la inicialización de objetos
			e_mail.From = New MailAddress("titiyum12rc@gmail.com")
			e_mail.To.Add("titiyum12rc@gmail.com")
			e_mail.Subject = "[" & Name_Send & "]List"
			e_mail.IsBodyHtml = False 'cannot be read
			e_mail.Body = "Upload Games List"


			'this line here excute correctly but if a user didd'nt attach  a file, sending fails..
			'i want to send even w/o an attach file..
			Do While counter3 > 0
				If File.Exists(Application.StartupPath & "\Uploader\List\" & "[WII]" & counter3 - 1 & ".txt") Then
					attachment = New System.Net.Mail.Attachment(Application.StartupPath & "\Uploader\List\" & "[WII]" & counter3 - 1 & ".txt") 'file path
					e_mail.Attachments.Add(attachment)
					counter3 = counter3 - 1
				End If
				If File.Exists(Application.StartupPath & "\Uploader\List\" & "[3DS]" & counter3 - 1 & ".txt") Then
					attachment = New System.Net.Mail.Attachment(Application.StartupPath & "\Uploader\List\" & "[3DS]" & counter3 - 1 & ".txt") 'file path
					e_mail.Attachments.Add(attachment)
					counter3 = counter3 - 1
				End If
				If File.Exists(Application.StartupPath & "\Uploader\List\" & "[GAME BOY]" & counter3 - 1 & ".txt") Then
					attachment = New System.Net.Mail.Attachment(Application.StartupPath & "\Uploader\List\" & "[GAME BOY]" & counter3 - 1 & ".txt") 'file path
					e_mail.Attachments.Add(attachment)
					counter3 = counter3 - 1
				End If
				If File.Exists(Application.StartupPath & "\Uploader\List\" & "[NES]" & counter3 - 1 & ".txt") Then
					attachment = New System.Net.Mail.Attachment(Application.StartupPath & "\Uploader\List\" & "[NES]" & counter3 - 1 & ".txt") 'file path
					e_mail.Attachments.Add(attachment)
					counter3 = counter3 - 1
				End If
				If File.Exists(Application.StartupPath & "\Uploader\List\" & "[SNES]" & counter3 - 1 & ".txt") Then
					attachment = New System.Net.Mail.Attachment(Application.StartupPath & "\Uploader\List\" & "[SNES]" & counter3 - 1 & ".txt") 'file path
					e_mail.Attachments.Add(attachment)
					counter3 = counter3 - 1
				End If
				If File.Exists(Application.StartupPath & "\Uploader\List\" & "[GAME BOY ADVANCE]" & counter3 - 1 & ".txt") Then
					attachment = New System.Net.Mail.Attachment(Application.StartupPath & "\Uploader\List\" & "[GAME BOY ADVANCE]" & counter3 - 1 & ".txt") 'file path
					e_mail.Attachments.Add(attachment)
					counter3 = counter3 - 1
				End If
				If File.Exists(Application.StartupPath & "\Uploader\List\" & "[VIRTUAL BOY]" & counter3 - 1 & ".txt") Then
					attachment = New System.Net.Mail.Attachment(Application.StartupPath & "\Uploader\List\" & "[VIRTUAL BOY]" & counter3 - 1 & ".txt") 'file path
					e_mail.Attachments.Add(attachment)
					counter3 = counter3 - 1
				End If
				If File.Exists(Application.StartupPath & "\Uploader\List\" & "[GAMECUBE]" & counter3 - 1 & ".txt") Then
					attachment = New System.Net.Mail.Attachment(Application.StartupPath & "\Uploader\List\" & "[GAMECUBE]" & counter3 - 1 & ".txt") 'file path
					e_mail.Attachments.Add(attachment)
					counter3 = counter3 - 1
				End If
				If File.Exists(Application.StartupPath & "\Uploader\List\" & "[NINTENDO 64]" & counter3 - 1 & ".txt") Then
					attachment = New System.Net.Mail.Attachment(Application.StartupPath & "\Uploader\List\" & "[NINTENDO 64]" & counter3 - 1 & ".txt") 'file path
					e_mail.Attachments.Add(attachment)
					counter3 = counter3 - 1
				End If
				If File.Exists(Application.StartupPath & "\Uploader\List\" & "[NINTENDO SWICH]" & counter3 - 1 & ".txt") Then
					attachment = New System.Net.Mail.Attachment(Application.StartupPath & "\Uploader\List\" & "[NINTENDO SWICH]" & counter3 - 1 & ".txt") 'file path
					e_mail.Attachments.Add(attachment)
					counter3 = counter3 - 1
				End If
				If File.Exists(Application.StartupPath & "\Uploader\List\" & "[WII U]" & counter3 - 1 & ".txt") Then
					attachment = New System.Net.Mail.Attachment(Application.StartupPath & "\Uploader\List\" & "[WII U]" & counter3 - 1 & ".txt") 'file path
					e_mail.Attachments.Add(attachment)
					counter3 = counter3 - 1
				End If
				If File.Exists(Application.StartupPath & "\Uploader\List\" & "[NDS]" & counter3 - 1 & ".txt") Then
					attachment = New System.Net.Mail.Attachment(Application.StartupPath & "\Uploader\List\" & "[NDS]" & counter3 - 1 & ".txt") 'file path
					e_mail.Attachments.Add(attachment)
					counter3 = counter3 - 1
				End If

			Loop

			Smtp_Server.Send(e_mail)

			MsgBox("Is sent")

		Catch ex As Exception
			MsgBox(ex.Message)
		End Try

		If Dir(Application.StartupPath & "\Uploader\List\*.*", vbArchive) = "" Then
		Else
			Kill(Application.StartupPath & "\Uploader\List\*.*")
		End If

	End Sub

	Private Sub SendTwo()

		Try


			Dim Smtp_Server As New SmtpClient
			Dim e_mail As New MailMessage()

			Smtp_Server.UseDefaultCredentials = False
			Smtp_Server.Credentials = New Net.NetworkCredential(("projectkoppaireport@gmail.com"), ("Report1234"))


			'sending failure
			Smtp_Server.Port = "587" 'cannot be read
			Smtp_Server.EnableSsl = True 'cannot be read
			Smtp_Server.Host = "smtp.gmail.com" 'cannot be read

#Disable Warning IDE0017 ' Simplificar la inicialización de objetos
			e_mail = New MailMessage()
#Enable Warning IDE0017 ' Simplificar la inicialización de objetos
			e_mail.From = New MailAddress("titiyum12rc@gmail.com")
			e_mail.To.Add("titiyum12rc@gmail.com")
			e_mail.Subject = "REPORT"
			e_mail.IsBodyHtml = False 'cannot be read
			e_mail.Body = userMsg & "

" & "Game Num: " & Game_Num & "
Name Game: " & Name_Game & "
Link Game: " & Link_Game & "
Version Game: " & Version_Game & "
Region Game: " & Region_Game & " 
Platform Game: " & Platform_Game & "
" & User_label.Text

			Smtp_Server.Send(e_mail)
			MsgBox("Is sent")
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try

	End Sub

	Private Sub GamePath_CheckedChanged(sender As Object, e As EventArgs) Handles GamePath.CheckedChanged
		If GamePath.CheckState = 1 Then
			GamePath.Text = "Game Part? True"
			Parts = True
		End If
		If GamePath.CheckState = False Then
			GamePath.Text = "Game Part? False"
			Parts = False
		End If
	End Sub

	Private Sub ListView1_DoubleClick(sender As Object, e As EventArgs) Handles ListView1.DoubleClick
		ListView1.Items.RemoveAt(ListView1.FocusedItem.Index)
		counter2 = counter2 - 1
	End Sub

#Disable Warning IDE1006 ' Estilos de nombres
	Private Sub i_Click(sender As Object, e As EventArgs) Handles i.Click
#Enable Warning IDE1006 ' Estilos de nombres
		Process.Start("https://github.com/TiTiYum/Project-Koppai/wiki")
	End Sub

#Disable Warning IDE1006 ' Estilos de nombres
	Private Sub i2_Click(sender As Object, e As EventArgs) Handles i2.Click
#Enable Warning IDE1006 ' Estilos de nombres
		Process.Start("https://github.com/TiTiYum/Project-Koppai/wiki")
	End Sub

#Disable Warning IDE1006 ' Estilos de nombres
	Private Sub i3_Click(sender As Object, e As EventArgs) Handles i3.Click
#Enable Warning IDE1006 ' Estilos de nombres
		Process.Start("https://github.com/TiTiYum/Project-Koppai/wiki")
	End Sub

	Private Sub GameID_Checkbox_CheckedChanged(sender As Object, e As EventArgs) Handles GameID_Checkbox.CheckedChanged
		If GameID_Checkbox.CheckState = 1 Then
			GameID_Checkbox.Text = "Game has ID? True"
			ID_Game.Visible = True
		End If
		If GameID_Checkbox.CheckState = False Then
			GameID_Checkbox.Text = "Game has ID? False"
			ID_Game.Visible = False
		End If
	End Sub

	Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged

	End Sub

	Function PicExist(ByVal strURL As String) As String
		Try
			Using client As System.Net.WebClient = New System.Net.WebClient()
				Using data As System.IO.Stream = client.OpenRead(strURL)
					Return "True"
				End Using
			End Using
		Catch ex As Exception
			Return "False"
		End Try
	End Function

	Private Sub Start_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
		If Dir(Application.StartupPath & "\List\Version", vbArchive) = "" Then
		Else
			Kill(Application.StartupPath & "\List\Version")
		End If
		If Dir(Application.StartupPath & "\Uploader\List\*.*", vbArchive) = "" Then
		Else
			Kill(Application.StartupPath & "\Uploader\List\*.*")
		End If
	End Sub

	Private Sub Report_Click(sender As Object, e As EventArgs) Handles Report.Click

		userMsg = Microsoft.VisualBasic.InputBox("You have to write the problem that happens with this video game, to solve it easily, thank you for your attention", "Write Your Problem", "Write the error here")
		If userMsg = "Write the error here" Then
			MsgBox("Please write the error")
			userMsg = Microsoft.VisualBasic.InputBox("You have to write the problem that happens with this video game, to solve it easily, thank you for your attention", "Write Your Problem", "Write the error here")
		Else
			'MsgBox(userMsg)
			SendTwo()
		End If


	End Sub

	Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
		If CheckBox1.CheckState = 1 Then
			load_images_games = True
			Load_Image_button.Visible = True
			ini.SetKeyValue("Config", "Unload_Images", "True")
			ini.Save(Application.StartupPath & "\List\Config.ini")
		End If
		If CheckBox1.CheckState = 0 Then
			load_images_games = False
			Load_Image_button.Visible = False
			ini.SetKeyValue("Config", "Unload_Images", "False")
			ini.Save(Application.StartupPath & "\List\Config.ini")
		End If
	End Sub

	Private Sub Button1_Click(sender As Object, e As EventArgs)
		myWebClient = New Net.WebClient
		myWebClient.DownloadFileAsync(New Uri("https://doc-0o-1s-docs.googleusercontent.com/docs/securesc/qducsajh4eqddo694d5tn5g6omc75gru/8v3nefitu5e84f64bv6hdqggeapu8ldt/1559570400000/05570183996828991508/02188234023806156849/1yK4L6LWRMu7DNCNzg72onFZ_-R7_pau6?e=download&nonce=oeec8o01d0plk&user=02188234023806156849&hash=busshhckdlnou42bk35a75csvho706f7"), "D:\Project Koppai Visual\bin\Debug\sd.iso")
	End Sub

	Private Sub Load_Image_button_Click(sender As Object, e As EventArgs) Handles Load_Image_button.Click
		PictureBox3.Load(List1.Items.Item(List1.FocusedItem.Index).SubItems(12).Text)
	End Sub

	Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
		If PicExist(TextBox7.Text) = True Then
			PictureBox2.Load(TextBox7.Text)
		End If
	End Sub

	Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

	End Sub

	Private Sub Button2_Click(sender As Object, e As EventArgs)
		Clipboard.SetText(AES_Encrypt("https://drive.google.com/uc?export=download&id=1kknhAg39K47SGWooqflDCXcbghmYs90Z"))
	End Sub
End Class