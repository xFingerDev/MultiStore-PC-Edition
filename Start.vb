Imports System
Imports System.IO
Imports System.Net
Imports Newtonsoft.Json
Imports System.Threading

Public Class Start

	Public Property Version As String = "1"


	Public Property Platform As String

	Public Languaje_Program As String

	Private Link_Game As String
	Private Link_License As String
	Private Platform_Game As String
	Private Version_Game As String
	Private format_Game As String
	Private format_License As String
	Private Name_Game As String
	Private Region_Game As String
	Private Game_Part As String
	Private Game_Num As String
	Private myFile As String
	Private DirGamesDownload As String()
	Private Dir_Save_Games As String
	Dim StartBol As Boolean = True
#Disable Warning IDE1006 ' Estilos de nombres
	Private WithEvents myWebClient As New Net.WebClient()
#Enable Warning IDE1006 ' Estilos de nombres
	Dim client As WebClient = New WebClient
	Private color_combo As Color
	Public counter2 As Integer
	Public counter3 As Integer
	Dim counter4 As Integer
	Public platfom2 As String
	Public Name_Send As String
	Public Parts As Boolean
	Public License_Bol As Boolean
	Dim ini As New IniFile
	Dim saved As String
	Private load_images_games As Boolean
	Public BackGround_Image As Boolean
	Public Color_ini As String

	Public start_tab As Boolean
	Public Search_On As Boolean = True

	Dim blnAscending As Boolean = False

	Private Sub Companya_Combo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Companya_Combo.SelectedIndexChanged
		ComboBox1.Items.Clear()
		Select Case Companya_Combo.Text
			Case "All"
#Region "All"
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
				ComboBox1.Items.Add("Game & Watch")
				ComboBox1.Items.Add("PlayStation")
				ComboBox1.Items.Add("PlayStation 2")
				ComboBox1.Items.Add("PlayStation 3")
				ComboBox1.Items.Add("PlayStation 4")
				ComboBox1.Items.Add("PSP")
				ComboBox1.Items.Add("PS Vita")
				ComboBox1.Items.Add("PocketStation")
				ComboBox1.Items.Add("Xbox")
				ComboBox1.Items.Add("Xbox 360")
				ComboBox1.Items.Add("Xbox One")
				ComboBox1.Items.Add("SG-1000")
				ComboBox1.Items.Add("SC-3000")
				ComboBox1.Items.Add("Sega Master System")
				ComboBox1.Items.Add("Sega Genesis")
				ComboBox1.Items.Add("Sega Mega CD")
				ComboBox1.Items.Add("Game Gear")
				ComboBox1.Items.Add("Sega Saturn")
				ComboBox1.Items.Add("Mega Drive 32x")
				ComboBox1.Items.Add("Sega Nomad")
				ComboBox1.Items.Add("Sega Model 2")
				ComboBox1.Items.Add("Sega Dreamcast")
				ComboBox1.Items.Add("Neo-Geo")
				ComboBox1.Items.Add("Neo-Geo CD")
				ComboBox1.Items.Add("Pippin")
				ComboBox1.Items.Add("Atari 2600")
				ComboBox1.Items.Add("Atari 5200")
				ComboBox1.Items.Add("Atari 7800")
				ComboBox1.Items.Add("Atari Jaguar")
				ComboBox1.Items.Add("Playdia")
				ComboBox1.Items.Add("Wonderswan")
				ComboBox1.Items.Add("Wonderswan Color")
				ComboBox1.Items.Add("Play System 1")
				ComboBox1.Items.Add("Play System 2")
				ComboBox1.Items.Add("Play System 3")
				ComboBox1.Items.Add("Casio Loopy")
				ComboBox1.Items.Add("ColecoVision")
				ComboBox1.Items.Add("Commodore 64GS")
				ComboBox1.Items.Add("AmigaCD32")
				ComboBox1.Items.Add("AmigaCD")
				ComboBox1.Items.Add("Fairchild Channel F")
				ComboBox1.Items.Add("GP32")
				ComboBox1.Items.Add("Vectrex")
				ComboBox1.Items.Add("Magnavox Oddyssey")
				ComboBox1.Items.Add("Magnavox Oddyssey 2")
				ComboBox1.Items.Add("Intellivision")
				ComboBox1.Items.Add("PC Engine")
				ComboBox1.Items.Add("PC-FX")
				ComboBox1.Items.Add("N-Gage")
				ComboBox1.Items.Add("3DO")
				ComboBox1.Items.Add("Videopac")
				ComboBox1.Items.Add("Philips CDi")
				ComboBox1.Items.Add("RCA Studio II")
				ComboBox1.Items.Add("V.Smile")
				ComboBox1.Items.Add("Amstrad GX4000")

				ComboBox1.Text = "All"
#End Region
			Case "Nintendo"
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
				ComboBox1.Items.Add("Game & Watch")
				ComboBox1.Text = "All"
			Case "Sony"
				ComboBox1.Items.Add("All")
				ComboBox1.Items.Add("PlayStation")
				ComboBox1.Items.Add("PlayStation 2")
				ComboBox1.Items.Add("PlayStation 3")
				ComboBox1.Items.Add("PlayStation 4")
				ComboBox1.Items.Add("PSP")
				ComboBox1.Items.Add("PS Vita")
				ComboBox1.Items.Add("PocketStation")
				ComboBox1.Text = "All"
			Case "Microsoft"
				ComboBox1.Items.Add("All")
				ComboBox1.Items.Add("Xbox")
				ComboBox1.Items.Add("Xbox 360")
				ComboBox1.Items.Add("Xbox One")
				ComboBox1.Text = "All"
			Case "Sega"
				ComboBox1.Items.Add("All")
				ComboBox1.Items.Add("SG-1000")
				ComboBox1.Items.Add("SC-3000")
				ComboBox1.Items.Add("Sega Master System")
				ComboBox1.Items.Add("Sega Genesis")
				ComboBox1.Items.Add("Sega Mega CD")
				ComboBox1.Items.Add("Game Gear")
				ComboBox1.Items.Add("Sega Saturn")
				ComboBox1.Items.Add("Mega Drive 32x")
				ComboBox1.Items.Add("Sega Nomad")
				ComboBox1.Items.Add("Sega Model 2")
				ComboBox1.Items.Add("Sega Dreamcast")
				ComboBox1.Text = "All"
			Case "SNK"
				ComboBox1.Items.Add("All")
				ComboBox1.Items.Add("Neo-Geo")
				ComboBox1.Items.Add("Neo-Geo CD")
				ComboBox1.Text = "All"
			Case "Apple"
				ComboBox1.Items.Add("All")
				ComboBox1.Items.Add("Pippin")
				ComboBox1.Text = "All"
			Case "Atari"
				ComboBox1.Items.Add("All")
				ComboBox1.Items.Add("Atari 2600")
				ComboBox1.Items.Add("Atari 5200")
				ComboBox1.Items.Add("Atari 7800")
				ComboBox1.Items.Add("Atari Jaguar")
				ComboBox1.Text = "All"
			Case "Bandai"
				ComboBox1.Items.Add("All")
				ComboBox1.Items.Add("Playdia")
				ComboBox1.Items.Add("Wonderswan")
				ComboBox1.Items.Add("Wonderswan Color")
				ComboBox1.Text = "All"
			Case "Capcom"
				ComboBox1.Items.Add("All")
				ComboBox1.Items.Add("Play System 1")
				ComboBox1.Items.Add("Play System 2")
				ComboBox1.Items.Add("Play System 3")
				ComboBox1.Text = "All"
			Case "Casio"
				ComboBox1.Items.Add("All")
				ComboBox1.Items.Add("Casio Loopy")
				ComboBox1.Text = "All"
			Case "Coleco"
				ComboBox1.Items.Add("All")
				ComboBox1.Items.Add("ColecoVision")
				ComboBox1.Text = "All"
			Case "Commodore International"
				ComboBox1.Items.Add("All")
				ComboBox1.Items.Add("Commodore 64GS")
				ComboBox1.Items.Add("AmigaCD32")
				ComboBox1.Items.Add("AmigaCD")
				ComboBox1.Text = "All"
			Case "Fairchild Semiconductor"
				ComboBox1.Items.Add("All")
				ComboBox1.Items.Add("Fairchild Channel F")
				ComboBox1.Text = "All"
			Case "Game Park"
				ComboBox1.Items.Add("All")
				ComboBox1.Items.Add("GP32")
				ComboBox1.Text = "All"
			Case "Milton Bradley Company"
				ComboBox1.Items.Add("All")
				ComboBox1.Items.Add("Vectrex")
				ComboBox1.Text = "All"
			Case "Magnavox"
				ComboBox1.Items.Add("All")
				ComboBox1.Items.Add("Magnavox Oddyssey")
				ComboBox1.Items.Add("Magnavox Oddyssey 2")
				ComboBox1.Text = "All"
			Case "Mattel"
				ComboBox1.Items.Add("All")
				ComboBox1.Items.Add("Intellivision")
				ComboBox1.Text = "All"
			Case "NEC"
				ComboBox1.Items.Add("All")
				ComboBox1.Items.Add("PC Engine")
				ComboBox1.Items.Add("PC-FX")
				ComboBox1.Text = "All"
			Case "Nokia"
				ComboBox1.Items.Add("All")
				ComboBox1.Items.Add("N-Gage")
				ComboBox1.Text = "All"
			Case "Panoramic"
				ComboBox1.Items.Add("All")
				ComboBox1.Items.Add("3DO")
				ComboBox1.Text = "All"
			Case "Philips"
				ComboBox1.Items.Add("All")
				ComboBox1.Items.Add("Videopac")
				ComboBox1.Items.Add("Philips CDi")
				ComboBox1.Text = "All"
			Case "RCA"
				ComboBox1.Items.Add("All")
				ComboBox1.Items.Add("RCA Studio II")
				ComboBox1.Text = "All"
			Case "V.Tech"
				ComboBox1.Items.Add("All")
				ComboBox1.Items.Add("V.Smile")
				ComboBox1.Text = "All"
			Case "Amstrad"
				ComboBox1.Items.Add("All")
				ComboBox1.Items.Add("Amstrad GX4000")
				ComboBox1.Text = "All"
		End Select
	End Sub
	Public Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
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
			Case "Game & Watch"
				Platform = "G&W"
			Case "PlayStation"
				Platform = "PS1"
			Case "PlayStation 2"
				Platform = "PS2"
			Case "PlayStation 3"
				Platform = "PS3"
			Case "PlayStation 4"
				Platform = "PS4"
			Case "PSP"
				Platform = "PSP"
			Case "PS Vita"
				Platform = "PSVita"
			Case "PocketStation"
				Platform = "PocketStation"
			Case "Xbox"
				Platform = "Xbox"
			Case "Xbox 360"
				Platform = "Xbox360"
			Case "Xbox One"
				Platform = "XboxOne"
			Case "SG-1000"
				Platform = "SG-1000"
			Case "SC-3000"
				Platform = "SC-3000"
			Case "Sega Master System"
				Platform = "Sega-Master-System"
			Case "Sega Genesis"
				Platform = "Sega-Genesis"
			Case "Sega Mega CD"
				Platform = "Sega-Mega-CD"
			Case "Game Gear"
				Platform = "Game-Gear"
			Case "Sega Saturn"
				Platform = "Sega-Saturn"
			Case "Mega Drive 32x"
				Platform = "Mega-Drive-32x"
			Case "Sega Nomad"
				Platform = "Sega-Nomad"
			Case "Sega Model 2"
				Platform = "Sega-Model-2"
			Case "Sega Dreamcast"
				Platform = "Dreamcast"
			Case "Neo-Geo"
				Platform = "Neo-Geo"
			Case "Neo-Geo CD"
				Platform = "Neo-Geo-CD"
			Case "Pippin"
				Platform = "Pippin"
			Case "Atari 2600"
				Platform = "Atari2600"
			Case "Atari 5200"
				Platform = "Atari5200"
			Case "Atari 7800"
				Platform = "Atari7800"
			Case "Atari Jaguar"
				Platform = "Atari-Jaguar"
			Case "Playdia"
				Platform = "Playdia"
			Case "Wonderswan"
				Platform = "Wonderswan"
			Case "Wonderswan Color"
				Platform = "Wonderswan-Color"
			Case "Play System 1"
				Platform = "Play-System-1"
			Case "Play System 2"
				Platform = "Play-System-2"
			Case "Play System 3"
				Platform = "Play-System-3"
			Case "Casio Loopy"
				Platform = "Casio-Loopy"
			Case "ColecoVision"
				Platform = "ColecoVision"
			Case "Commodore 64GS"
				Platform = "Commodore64GS"
			Case "AmigaCD32"
				Platform = "AmigaCD32"
			Case "AmigaCD"
				Platform = "AmigaCD"
			Case "Fairchild Channel F"
				Platform = "Fairchild-Channel-F"
			Case "GP32"
				Platform = "GP32"
			Case "Vectrex"
				Platform = "Vectrex"
			Case "Magnavox Oddyssey"
				Platform = "Magnavox-Oddyssey"
			Case "Magnavox Oddyssey 2"
				Platform = "Magnavox-Oddyssey2"
			Case "Intellivision"
				Platform = "Intellivision"
			Case "PC Engine"
				Platform = "PC-Engine"
			Case "PC-FX"
				Platform = "PC-FX"
			Case "N-Gage"
				Platform = "N-Gage"
			Case "3DO"
				Platform = "3DO"
			Case "Videopac"
				Platform = "Videopac"
			Case "Philips CDi"
				Platform = "Philips-CDi"
			Case "RCA Studio II"
				Platform = "RCA-Studio-II"
			Case "V.Smile"
				Platform = "V-Smile"
			Case "Amstrad GX4000"
				Platform = "AmstradGX4000"
		End Select
		List1.Items.Clear()
		AddList()
	End Sub
	Private Sub Start_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Me.Cursor = Cursors.WaitCursor
		Createfolders()

		'myListView.ListViewItemSorter = New myListViewComparer
		Net.ServicePointManager.DefaultConnectionLimit = 5
		Me.Text = "Σύνταξη for games v" & Version
		If Dir(Application.StartupPath & "\Picture_Remplace.png", vbDirectory) = "" Then
		Else
			Kill(Application.StartupPath & "\Picture.png")
			Rename(Application.StartupPath & "\Picture_Remplace.png", Application.StartupPath & "\Picture.png")
		End If
		DownParts.Visible = False
		DownParts.Enabled = False
		LinkLicense_Text.Visible = False
		ID_Game.Visible = False
		Button2.Visible = False
		ListView99.Visible = False
		TextBox8.Visible = False
		Select_Image.Visible = False
		Label2.Visible = False

		Dim Languaje_StringAll As String() = Directory.GetFiles(Application.StartupPath & "\Lang\", "*.ini")
		For Each LangSenseArray As String In Languaje_StringAll
			' Do work, example
			Dim fileName As String = LangSenseArray.Substring(LangSenseArray.LastIndexOf("\") + 1)

			Languaje_Combobox.Items.Add(Path.GetDirectoryName(fileName) + Path.GetFileNameWithoutExtension(fileName))
		Next


		Dir_Save_Games = "Default"


#Region "Consoles"
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
		ComboBox1.Items.Add("Game & Watch")
		ComboBox1.Items.Add("PlayStation")
		ComboBox1.Items.Add("PlayStation 2")
		ComboBox1.Items.Add("PlayStation 3")
		ComboBox1.Items.Add("PlayStation 4")
		ComboBox1.Items.Add("PSP")
		ComboBox1.Items.Add("PS Vita")
		ComboBox1.Items.Add("PocketStation")
		ComboBox1.Items.Add("Xbox")
		ComboBox1.Items.Add("Xbox 360")
		ComboBox1.Items.Add("Xbox One")
		ComboBox1.Items.Add("SG-1000")
		ComboBox1.Items.Add("SC-3000")
		ComboBox1.Items.Add("Sega Master System")
		ComboBox1.Items.Add("Sega Genesis")
		ComboBox1.Items.Add("Sega Mega CD")
		ComboBox1.Items.Add("Game Gear")
		ComboBox1.Items.Add("Sega Saturn")
		ComboBox1.Items.Add("Mega Drive 32x")
		ComboBox1.Items.Add("Sega Nomad")
		ComboBox1.Items.Add("Sega Model 2")
		ComboBox1.Items.Add("Sega Dreamcast")
		ComboBox1.Items.Add("Neo-Geo")
		ComboBox1.Items.Add("Neo-Geo CD")
		ComboBox1.Items.Add("Pippin")
		ComboBox1.Items.Add("Atari 2600")
		ComboBox1.Items.Add("Atari 5200")
		ComboBox1.Items.Add("Atari 7800")
		ComboBox1.Items.Add("Atari Jaguar")
		ComboBox1.Items.Add("Playdia")
		ComboBox1.Items.Add("Wonderswan")
		ComboBox1.Items.Add("Wonderswan Color")
		ComboBox1.Items.Add("Play System 1")
		ComboBox1.Items.Add("Play System 2")
		ComboBox1.Items.Add("Play System 3")
		ComboBox1.Items.Add("Casio Loopy")
		ComboBox1.Items.Add("ColecoVision")
		ComboBox1.Items.Add("Commodore 64GS")
		ComboBox1.Items.Add("AmigaCD32")
		ComboBox1.Items.Add("AmigaCD")
		ComboBox1.Items.Add("Fairchild Channel F")
		ComboBox1.Items.Add("GP32")
		ComboBox1.Items.Add("Vectrex")
		ComboBox1.Items.Add("Magnavox Oddyssey")
		ComboBox1.Items.Add("Magnavox Oddyssey 2")
		ComboBox1.Items.Add("Intellivision")
		ComboBox1.Items.Add("PC Engine")
		ComboBox1.Items.Add("PC-FX")
		ComboBox1.Items.Add("N-Gage")
		ComboBox1.Items.Add("3DO")
		ComboBox1.Items.Add("Videopac")
		ComboBox1.Items.Add("Philips CDi")
		ComboBox1.Items.Add("RCA Studio II")
		ComboBox1.Items.Add("V.Smile")
		ComboBox1.Items.Add("Amstrad GX4000")
		ComboBox4.Items.Add("Wii")
		ComboBox4.Items.Add("Wii U")
		ComboBox4.Items.Add("Nintendo Swich")
		ComboBox4.Items.Add("Nintendo 64")
		ComboBox4.Items.Add("GameCube")
		ComboBox4.Items.Add("Snes")
		ComboBox4.Items.Add("Nes")
		ComboBox4.Items.Add("NDS")
		ComboBox4.Items.Add("3DS")
		ComboBox4.Items.Add("Game Boy")
		ComboBox4.Items.Add("Game Boy Advance")
		ComboBox4.Items.Add("Virtual Boy")
		ComboBox4.Items.Add("Game & Watch")
		ComboBox4.Items.Add("PlayStation")
		ComboBox4.Items.Add("PlayStation 2")
		ComboBox4.Items.Add("PlayStation 3")
		ComboBox4.Items.Add("PlayStation 4")
		ComboBox4.Items.Add("PSP")
		ComboBox4.Items.Add("PS Vita")
		ComboBox4.Items.Add("PocketStation")
		ComboBox4.Items.Add("Xbox")
		ComboBox4.Items.Add("Xbox 360")
		ComboBox4.Items.Add("Xbox One")
		ComboBox4.Items.Add("SG-1000")
		ComboBox4.Items.Add("SC-3000")
		ComboBox4.Items.Add("Sega Master System")
		ComboBox4.Items.Add("Sega Genesis")
		ComboBox4.Items.Add("Sega Mega CD")
		ComboBox4.Items.Add("Game Gear")
		ComboBox4.Items.Add("Sega Saturn")
		ComboBox4.Items.Add("Mega Drive 32x")
		ComboBox4.Items.Add("Sega Nomad")
		ComboBox4.Items.Add("Sega Model 2")
		ComboBox4.Items.Add("Sega Dreamcast")
		ComboBox4.Items.Add("Neo-Geo")
		ComboBox4.Items.Add("Neo-Geo CD")
		ComboBox4.Items.Add("Pippin")
		ComboBox4.Items.Add("Atari 2600")
		ComboBox4.Items.Add("Atari 5200")
		ComboBox4.Items.Add("Atari 7800")
		ComboBox4.Items.Add("Atari Jaguar")
		ComboBox4.Items.Add("Playdia")
		ComboBox4.Items.Add("Wonderswan")
		ComboBox4.Items.Add("Wonderswan Color")
		ComboBox4.Items.Add("Play System 1")
		ComboBox4.Items.Add("Play System 2")
		ComboBox4.Items.Add("Play System 3")
		ComboBox4.Items.Add("Casio Loopy")
		ComboBox4.Items.Add("ColecoVision")
		ComboBox4.Items.Add("Commodore 64GS")
		ComboBox4.Items.Add("AmigaCD32")
		ComboBox4.Items.Add("AmigaCD")
		ComboBox4.Items.Add("Fairchild Channel F")
		ComboBox4.Items.Add("GP32")
		ComboBox4.Items.Add("Vectrex")
		ComboBox4.Items.Add("Magnavox Oddyssey")
		ComboBox4.Items.Add("Magnavox Oddyssey 2")
		ComboBox4.Items.Add("Intellivision")
		ComboBox4.Items.Add("PC Engine")
		ComboBox4.Items.Add("PC-FX")
		ComboBox4.Items.Add("N-Gage")
		ComboBox4.Items.Add("3DO")
		ComboBox4.Items.Add("Videopac")
		ComboBox4.Items.Add("Philips CDi")
		ComboBox4.Items.Add("RCA Studio II")
		ComboBox4.Items.Add("V.Smile")
		ComboBox4.Items.Add("Amstrad GX4000")
		ComboBox4.Text = "WII"
		ComboBox1.Text = "Nintendo"
#End Region
		DownParts.Items.Add("ALL")
		DownParts.Text = "ALL"
#Region "Company"
		Companya_Combo.Items.Add("All")
		Companya_Combo.Items.Add("Nintendo") '
		Companya_Combo.Items.Add("Sony") '
		Companya_Combo.Items.Add("Microsoft") '
		Companya_Combo.Items.Add("Sega") '
		Companya_Combo.Items.Add("SNK") '
		Companya_Combo.Items.Add("Apple") '
		Companya_Combo.Items.Add("Atari") '
		Companya_Combo.Items.Add("Bandai") '
		'Companya_Combo.Items.Add("Bentley")
		Companya_Combo.Items.Add("Capcom") '
		Companya_Combo.Items.Add("Casio") '
		Companya_Combo.Items.Add("Coleco") '
		Companya_Combo.Items.Add("Commodore International") '
		'Companya_Combo.Items.Add("Conic")
		'Companya_Combo.Items.Add("Cybiko")
		Companya_Combo.Items.Add("Fairchild Semiconductor") '
		'Companya_Combo.Items.Add("Fujitsu")
		Companya_Combo.Items.Add("Game Park") '
		'Companya_Combo.Items.Add("Game Park Holdings")
		Companya_Combo.Items.Add("Milton Bradley Company") '
		'Companya_Combo.Items.Add("Giochi Preziosi")
		'Companya_Combo.Items.Add("Impel")
		Companya_Combo.Items.Add("Magnavox") '
		Companya_Combo.Items.Add("Mattel") '
		Companya_Combo.Items.Add("NEC") '
		Companya_Combo.Items.Add("Nokia") '
		Companya_Combo.Items.Add("Panoramic") '
		Companya_Combo.Items.Add("Philips") '
		'Companya_Combo.Items.Add("Qualcomm")
		Companya_Combo.Items.Add("RCA") '
		'Companya_Combo.Items.Add("TRQ S.L")
		'Companya_Combo.Items.Add("Turbo Technologies Inc.")
		Companya_Combo.Items.Add("V.Tech") '
		Companya_Combo.Items.Add("Amstrad") '
		'Companya_Combo.Items.Add("Other")

		Companya_Combo.Text = "ALL"
#End Region
#Region "LANG"
		Try
			ini.Load(Application.StartupPath & "\Lang\" & Languaje_Program & ".ini")
			Button2.Text = ini.GetKeyValue("LANGUAGE", "Download_License")
			Button_Download.Text = ini.GetKeyValue("LANGUAGE", "Download_Game")
			Search_Label.Text = ini.GetKeyValue("LANGUAGE", "Search")
			CheckBox1.Text = ini.GetKeyValue("LANGUAGE", "UnLoad_Images_games_Less_lag_if_your_internet_is_not_good")
			background_image_checkbox.Text = ini.GetKeyValue("LANGUAGE", "Background_Image")
			Uploader_tab.Text = ini.GetKeyValue("LANGUAGE", "Show_Uploader")
			Select_Image.Text = ini.GetKeyValue("LANGUAGE", "Browse")
			Button3.Text = ini.GetKeyValue("LANGUAGE", "Browse")
			CheckBox2.Text = ini.GetKeyValue("LANGUAGE", "Custom_Path_Save")
			Label2.Text = ini.GetKeyValue("LANGUAGE", "If_you_already_have_a_defined_image_and_change_it_again_the_application_will_restart_be_careful_that_the_downloads_will_stop")
			Uploader.Text = ini.GetKeyValue("LANGUAGE", "Upload_List_Games")
			btnResumeAll1.Text = ini.GetKeyValue("LANGUAGE", "Resume_All")
			btnResume1.Text = ini.GetKeyValue("LANGUAGE", "Resume")
			btnPause1.Text = ini.GetKeyValue("LANGUAGE", "Pause")
			btnPauseAll1.Text = ini.GetKeyValue("LANGUAGE", "Pause_All")
			btnRemove1.Text = ini.GetKeyValue("LANGUAGE", "Remove")
			btnRemoveAll.Text = ini.GetKeyValue("LANGUAGE", "Remove_All")
			Button1.Text = ini.GetKeyValue("LANGUAGE", "Check_image")
			Upload_Add_item.Text = ini.GetKeyValue("LANGUAGE", "Up_Game")
			Button4.Text = ini.GetKeyValue("LANGUAGE", "Edit_Url_List")
			Accept.Label1.Text = ini.GetKeyValue("LANGUAGE", "Are_you_sure_you_want_to_remove_this_file_from_the_download_list")
			Accept.Label1.Text = ""
			Languaje_Combobox.Text = Languaje_Program
		Catch
		End Try
#End Region
		ini.Load(Application.StartupPath & "\Lang\" & Languaje_Program & ".ini")
		List1.Columns.Add(ini.GetKeyValue("LANGUAGE", "ID"), 100)
		List1.Columns.Add(ini.GetKeyValue("LANGUAGE", "NAME"), 300)
		List1.Columns.Add(ini.GetKeyValue("LANGUAGE", "REGION"), 70)
		List1.Columns.Add(ini.GetKeyValue("LANGUAGE", "TYPE"), 70)
		List1.Columns.Add(ini.GetKeyValue("LANGUAGE", "USER"), 90)
		List1.Columns.Add(ini.GetKeyValue("LANGUAGE", "VERSION"), 100)
		List1.Columns.Add(ini.GetKeyValue("LANGUAGE", "FORMAT"), 100)
		List1.Columns.Add("ENCRYPT", 0)
		List1.Columns.Add("Platform", 0)
		List1.Columns.Add("Part Exist?", 0)
		List1.Columns.Add("NPart", 0)
		List1.Columns.Add("id_json", 0)
		List1.Columns.Add("image", 0)
		List1.Columns.Add("ExistLicense", 0)
		List1.Columns.Add("LinkLicence encrypt", 0)
		List1.Columns.Add("FORMATLicence", 0)

		ListView99.Columns.Add(ini.GetKeyValue("LANGUAGE", "ID"), 100)
		ListView99.Columns.Add(ini.GetKeyValue("LANGUAGE", "NAME"), 300)
		ListView99.Columns.Add(ini.GetKeyValue("LANGUAGE", "REGION"), 70)
		ListView99.Columns.Add(ini.GetKeyValue("LANGUAGE", "TYPE"), 70)
		ListView99.Columns.Add(ini.GetKeyValue("LANGUAGE", "USER"), 90)
		ListView99.Columns.Add(ini.GetKeyValue("LANGUAGE", "VERSION"), 100)
		ListView99.Columns.Add(ini.GetKeyValue("LANGUAGE", "FORMAT"), 100)
		ListView99.Columns.Add("ENCRYPT", 0)
		ListView99.Columns.Add("Platform", 0)
		ListView99.Columns.Add("Part Exist?", 0)
		ListView99.Columns.Add("NPart", 0)
		ListView99.Columns.Add("id_json", 0)
		ListView99.Columns.Add("image", 0)
		ListView99.Columns.Add("ExistLicense", 0)
		ListView99.Columns.Add("LinkLicence encrypt", 0)
		ListView99.Columns.Add("FORMATLicence", 0)

		'ListView1.Columns.Add("ID", 0)
		'ListView1.Columns.Add("NAME", 120)
		'ListView1.Columns.Add("TYPE", 60)
		'ListView1.Columns.Add("REGION", 100)
		'ListView1.Columns.Add("USER", 100)
		'ListView1.Columns.Add("VERSION", 70)
		'ListView1.Columns.Add("FORMAT", 60)
		'ListView1.Columns.Add("ENCRYPT", 0)
		'ListView1.Columns.Add("Platform", 0)
		'ListView1.Columns.Add("Part", 60)
		'ListView1.Columns.Add("NPart", 0)
		'ListView1.Columns.Add("Image", 100)

		ComboBox2.Items.Add("GAME")
		ComboBox2.Items.Add("DEMO")
		ComboBox2.Items.Add("HACKROM")
		ComboBox2.Items.Add("APPLICATION")
		ComboBox2.Items.Add("MOVIE")
		ComboBox2.Items.Add("TRAILER")
		ComboBox2.Items.Add("MINI")
		ComboBox2.Items.Add("EDAT")
		ComboBox2.Items.Add("DLC")
		ComboBox2.Items.Add("PORT")
		ComboBox2.Items.Add("THEME")
		ComboBox2.Items.Add("UPDATE")
		ComboBox2.Items.Add("PATCH")
		ComboBox2.Items.Add("HOMEBREW")



		ComboBox2.Sorted = True

		ComboBox2.Text = "GAME"
#Region "Colors"
		Color_Combobox.Items.Add("White")
		Color_Combobox.Items.Add("BlanchedAlmond")
		Color_Combobox.Items.Add("Gray")
		Color_Combobox.Items.Add("Red")
		Color_Combobox.Items.Add("Blue")
		Color_Combobox.Items.Add("Yellow")
		Color_Combobox.Items.Add("Green")
		Color_Combobox.Items.Add("Orange")
		Color_Combobox.Items.Add("Brown")
		Color_Combobox.Items.Add("Pink")
		Color_Combobox.Items.Add("Violet")
		Color_Combobox.Items.Add("Purple")
		Color_Combobox.Items.Add("Golden")
		Color_Combobox.Items.Add("Silver")
		Color_Combobox.Items.Add("WhiteSmoke")
		Color_Combobox.Items.Add("DimGray")
		Color_Combobox.Items.Add("Aqua")
		Color_Combobox.Items.Add("AntiqueWhite")
		Color_Combobox.Items.Add("Aquamarine")
		Color_Combobox.Items.Add("Azure")
		Color_Combobox.Items.Add("Beige")
		Color_Combobox.Items.Add("Bisque")
		Color_Combobox.Items.Add("BlanchedAlmond")
		Color_Combobox.Items.Add("BlueViolet")
		Color_Combobox.Items.Add("BurlyWood")
		Color_Combobox.Items.Add("CadetBlue")
		Color_Combobox.Items.Add("Chartreuse")
		Color_Combobox.Items.Add("Chocolate")
		Color_Combobox.Items.Add("Coral")
		Color_Combobox.Items.Add("CornflowerBlue")
		Color_Combobox.Items.Add("Cornsilk")
		Color_Combobox.Items.Add("Crimson")
		Color_Combobox.Items.Add("Cyan")
		Color_Combobox.Items.Add("DarkBlue")
		Color_Combobox.Items.Add("DarkCyan")
		Color_Combobox.Items.Add("DarkGoldenrod")
		Color_Combobox.Items.Add("DarkGray")
		Color_Combobox.Items.Add("DarkGreen")
		Color_Combobox.Items.Add("DarkKhaki")
		Color_Combobox.Items.Add("DarkMagenta")
		Color_Combobox.Items.Add("DarkOliveGreen")
		Color_Combobox.Items.Add("DarkOrange")
		Color_Combobox.Items.Add("DarkOrchid")
		Color_Combobox.Items.Add("DarkRed")
		Color_Combobox.Items.Add("DarkSalmon")
		Color_Combobox.Items.Add("DarkSeaGreen")
		Color_Combobox.Items.Add("DarkSlateBlue")
		Color_Combobox.Items.Add("DarkSlateGray")
		Color_Combobox.Items.Add("DarkTurquoise")
		Color_Combobox.Items.Add("DarkViolet")
		Color_Combobox.Items.Add("DeepPink")
		Color_Combobox.Items.Add("DodgerBlue")
		Color_Combobox.Items.Add("Firebrick")
		Color_Combobox.Items.Add("FloralWhite")
		Color_Combobox.Items.Add("ForestGreen")
		Color_Combobox.Items.Add("Fuchsia")
		Color_Combobox.Items.Add("Gainsboro")
		Color_Combobox.Items.Add("GhostWhite")
		Color_Combobox.Items.Add("Goldenrod")
		Color_Combobox.Items.Add("GreenYellow")
		Color_Combobox.Items.Add("Honeydew")
		Color_Combobox.Items.Add("HotPink")
		Color_Combobox.Items.Add("IndianRed")
		Color_Combobox.Items.Add("Indigo")
		Color_Combobox.Items.Add("Ivory")
		Color_Combobox.Items.Add("Khaki")
		Color_Combobox.Items.Add("Lavender")
		Color_Combobox.Items.Add("LavenderBlush")
		Color_Combobox.Items.Add("LawnGreen")
		Color_Combobox.Items.Add("LemonChiffon")
		Color_Combobox.Items.Add("LightBlue")
		Color_Combobox.Items.Add("LightCoral")
		Color_Combobox.Items.Add("LightCyan")
		Color_Combobox.Items.Add("LightGoldenrodYellow")
		Color_Combobox.Items.Add("LightGray")
		Color_Combobox.Items.Add("LightGreen")
		Color_Combobox.Items.Add("LightPink")
		Color_Combobox.Items.Add("LightSalmon")
		Color_Combobox.Items.Add("LightSeaGreen")
		Color_Combobox.Items.Add("LightSkyBlue")
		Color_Combobox.Items.Add("LightSlateGray")
		Color_Combobox.Items.Add("LightSteelBlue")
		Color_Combobox.Items.Add("LightYellow")
		Color_Combobox.Items.Add("Lime")
		Color_Combobox.Items.Add("LimeGreen")
		Color_Combobox.Items.Add("Linen")
		Color_Combobox.Items.Add("Magenta")
		Color_Combobox.Items.Add("Maroon")
		Color_Combobox.Items.Add("MediumAquamarine")
		Color_Combobox.Items.Add("MediumBlue")
		Color_Combobox.Items.Add("MediumOrchid")
		Color_Combobox.Items.Add("MediumPurple")
		Color_Combobox.Items.Add("MediumSeaGreen")
		Color_Combobox.Items.Add("MediumSlateBlue")
		Color_Combobox.Items.Add("MediumSpringGreen")
		Color_Combobox.Items.Add("MediumTurquoise")
		Color_Combobox.Items.Add("MediumVioletRed")
		Color_Combobox.Items.Add("MidnightBlue")
		Color_Combobox.Items.Add("MintCream")
		Color_Combobox.Items.Add("MistyRose")
		Color_Combobox.Items.Add("Moccasin")
		Color_Combobox.Items.Add("NavajoWhite")
		Color_Combobox.Items.Add("Navy")
		Color_Combobox.Items.Add("OldLace")
		Color_Combobox.Items.Add("Olive")
		Color_Combobox.Items.Add("OliveDrab")
		Color_Combobox.Items.Add("OrangeRed")
		Color_Combobox.Items.Add("Orchid")
		Color_Combobox.Items.Add("PaleGoldenrod")
		Color_Combobox.Items.Add("PaleGreen")
		Color_Combobox.Items.Add("PaleTurquoise")
		Color_Combobox.Items.Add("PaleVioletRed")
		Color_Combobox.Items.Add("PapayaWhip")
		Color_Combobox.Items.Add("PeachPuff")
		Color_Combobox.Items.Add("Peru")
		Color_Combobox.Items.Add("Plum")
		Color_Combobox.Items.Add("PowderBlue")
		Color_Combobox.Items.Add("RosyBrown")
		Color_Combobox.Items.Add("RoyalBlue")
		Color_Combobox.Items.Add("SaddleBrown")
		Color_Combobox.Items.Add("Salmon")
		Color_Combobox.Items.Add("SandyBrown")
		Color_Combobox.Items.Add("SeaGreen")
		Color_Combobox.Items.Add("SeaShell")
		Color_Combobox.Items.Add("Sienna")
		Color_Combobox.Items.Add("SkyBlue")
		Color_Combobox.Items.Add("SlateBlue")
		Color_Combobox.Items.Add("SlateGray")
		Color_Combobox.Items.Add("Snow")
		Color_Combobox.Items.Add("SpringGreen")
		Color_Combobox.Items.Add("SteelBlue")
		Color_Combobox.Items.Add("Tan")
		Color_Combobox.Items.Add("Teal")
		Color_Combobox.Items.Add("Thistle")
		Color_Combobox.Items.Add("Tomato")
		Color_Combobox.Items.Add("Turquoise")
		Color_Combobox.Items.Add("Wheat")
		Color_Combobox.Items.Add("WhiteSmoke")
		Color_Combobox.Items.Add("YellowGreen")

#End Region
		Color_Combobox.Sorted = True

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
		ComboBox3.Items.Add("NTSC")
		ComboBox3.Items.Add("PAL")
		ComboBox3.Items.Add("NTSC-PAL")

		'Select_Server.Items.Add("")
		ComboBox3.Text = "USA"



		PictureBox2.WaitOnLoad = False
		PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
		Try
			'	PictureBox2.Load("https://upload.wikimedia.org/wikipedia/en/thumb/5/56/Megaman10.jpg/220px-Megaman10.jpg")
		Catch
		End Try
		PictureBox3.WaitOnLoad = False
		PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
		Try
			'PictureBox3.Load("https://upload.wikimedia.org/wikipedia/en/thumb/5/56/Megaman10.jpg/220px-Megaman10.jpg")
		Catch
		End Try
		'AddList()

		ListViewEx.Columns.Add(ini.GetKeyValue("LANGUAGE", "Filename"), 225, HorizontalAlignment.Left)
		ListViewEx.Columns.Add(ini.GetKeyValue("LANGUAGE", "Size"), 80, HorizontalAlignment.Right)
		ListViewEx.Columns.Add(ini.GetKeyValue("LANGUAGE", "Status"), 125, HorizontalAlignment.Left)
		ListViewEx.Columns.Add(ini.GetKeyValue("LANGUAGE", "Completed"), 100, HorizontalAlignment.Right)
		ListViewEx.Columns.Add(ini.GetKeyValue("LANGUAGE", "Progress"), 125, HorizontalAlignment.Center)
		ListViewEx.Columns.Add(ini.GetKeyValue("LANGUAGE", "Speed"), 75, HorizontalAlignment.Right)
		ListViewEx.Columns.Add(ini.GetKeyValue("LANGUAGE", "Time"), 80, HorizontalAlignment.Left)
		ListViewEx.Columns.Add(ini.GetKeyValue("LANGUAGE", "Time_Left"), 80, HorizontalAlignment.Left)


#Region "Load Color"

		Color_Combobox.Text = Color_ini
		Select Case Color_ini
			Case "White"
				color_combo = Color.White
			Case "WhiteSmoke"
				color_combo = Color.WhiteSmoke
			Case "BlanchedAlmond"
				color_combo = Color.BlanchedAlmond
			Case "Gray"
				color_combo = Color.Gray
			Case "DimGray"
				color_combo = Color.DimGray
			Case "Red"
				color_combo = Color.Red
			Case "Blue"
				color_combo = Color.Blue
			Case "Yellow"
				color_combo = Color.Yellow
			Case "Green"
				color_combo = Color.Green
			Case "Orange"
				color_combo = Color.Orange
			Case "Brown"
				color_combo = Color.Brown
			Case "Pink"
				color_combo = Color.Pink
			Case "Violet"
				color_combo = Color.Violet
			Case "Purple"
				color_combo = Color.Purple
			Case "Golden"
				color_combo = Color.Gold
			Case "Silver"
				color_combo = Color.Silver
			Case "Aqua"
				color_combo = Color.Aqua
			Case "AntiqueWhite"
				color_combo = Color.AntiqueWhite
			Case "AntiqueWhite"
				color_combo = Color.AntiqueWhite
			Case "Aquamarine"
				color_combo = Color.Aquamarine
			Case "Azure"
				color_combo = Color.Azure
			Case "Beige"
				color_combo = Color.Beige
			Case "Bisque"
				color_combo = Color.Bisque
			Case "BlanchedAlmond"
				color_combo = Color.BlanchedAlmond
			Case "BlueViolet"
				color_combo = Color.BlueViolet
			Case "BurlyWood"
				color_combo = Color.BurlyWood
			Case "CadetBlue"
				color_combo = Color.CadetBlue
			Case "Chartreuse"
				color_combo = Color.Chartreuse
			Case "Chartreuse"
				color_combo = Color.Chartreuse
			Case "Chocolate"
				color_combo = Color.Chocolate
			Case "Coral"
				color_combo = Color.Coral
			Case "CornflowerBlue"
				color_combo = Color.CornflowerBlue
			Case "Cornsilk"
				color_combo = Color.Cornsilk
			Case "Crimson"
				color_combo = Color.Crimson
			Case "Cyan"
				color_combo = Color.Cyan
			Case "DarkBlue"
				color_combo = Color.DarkBlue
			Case "DarkCyan"
				color_combo = Color.DarkCyan
			Case "DarkGoldenrod"
				color_combo = Color.DarkGoldenrod
			Case "DarkGray"
				color_combo = Color.DarkGray
			Case "DarkGreen"
				color_combo = Color.DarkGreen
			Case "DarkKhaki"
				color_combo = Color.DarkKhaki
			Case "DarkMagenta"
				color_combo = Color.DarkMagenta
			Case "DarkOliveGreen"
				color_combo = Color.DarkOliveGreen
			Case "DarkOrange"
				color_combo = Color.DarkOrange
			Case "DarkOrchid"
				color_combo = Color.DarkOrchid
			Case "DarkRed"
				color_combo = Color.DarkRed
			Case "DarkSalmon"
				color_combo = Color.DarkSalmon
			Case "DarkSeaGreen"
				color_combo = Color.DarkSeaGreen
			Case "DarkSlateBlue"
				color_combo = Color.DarkSlateBlue
			Case "DarkSlateGray"
				color_combo = Color.DarkSlateGray
			Case "DarkTurquoise"
				color_combo = Color.DarkTurquoise
			Case "DarkViolet"
				color_combo = Color.DarkViolet
			Case "DeepPink"
				color_combo = Color.DeepPink
			Case "DeepSkyBlue"
				color_combo = Color.DeepSkyBlue
			Case "DodgerBlue"
				color_combo = Color.DodgerBlue
			Case "Firebrick"
				color_combo = Color.Firebrick
			Case "FloralWhite"
				color_combo = Color.FloralWhite
			Case "ForestGreen"
				color_combo = Color.ForestGreen
			Case "Fuchsia"
				color_combo = Color.Fuchsia
			Case "Gainsboro"
				color_combo = Color.Gainsboro
			Case "GhostWhite"
				color_combo = Color.GhostWhite
			Case "Goldenrod"
				color_combo = Color.Goldenrod
			Case "GreenYellow"
				color_combo = Color.GreenYellow
			Case "Honeydew"
				color_combo = Color.Honeydew
			Case "HotPink"
				color_combo = Color.HotPink
			Case "IndianRed"
				color_combo = Color.IndianRed
			Case "Indigo"
				color_combo = Color.Indigo
			Case "Ivory"
				color_combo = Color.Ivory
			Case "Khaki"
				color_combo = Color.Khaki
			Case "Lavender"
				color_combo = Color.Lavender
			Case "LavenderBlush"
				color_combo = Color.LavenderBlush
			Case "LawnGreen"
				color_combo = Color.LawnGreen
			Case "LemonChiffon"
				color_combo = Color.LemonChiffon
			Case "LightBlue"
				color_combo = Color.LightBlue
			Case "Color.LightCoral"
				color_combo = Color.LightCoral
			Case "LightCyan"
				color_combo = Color.LightCyan
			Case "LightGoldenrodYellow"
				color_combo = Color.LightGoldenrodYellow
			Case "LightGray"
				color_combo = Color.LightGray
			Case "LightGreen"
				color_combo = Color.LightGreen
			Case "LightPink"
				color_combo = Color.LightPink
			Case "LightSalmon"
				color_combo = Color.LightSalmon
			Case "LightSeaGreen"
				color_combo = Color.LightSeaGreen
			Case "LightSkyBlue"
				color_combo = Color.LightSkyBlue
			Case "LightSlateGray"
				color_combo = Color.LightSlateGray
			Case "LightSteelBlue"
				color_combo = Color.LightSteelBlue
			Case "LightYellow"
				color_combo = Color.LightYellow
			Case "Lime"
				color_combo = Color.Lime
			Case "LimeGreen"
				color_combo = Color.LimeGreen
			Case "Linen"
				color_combo = Color.Linen
			Case "Magenta"
				color_combo = Color.Magenta
			Case "Maroon"
				color_combo = Color.Maroon
			Case "MediumAquamarine"
				color_combo = Color.MediumAquamarine
			Case "MediumBlue"
				color_combo = Color.MediumBlue
			Case "MediumOrchid"
				color_combo = Color.MediumOrchid
			Case "MediumPurple"
				color_combo = Color.MediumPurple
			Case "MediumSeaGreen"
				color_combo = Color.MediumSeaGreen
			Case "MediumSlateBlue"
				color_combo = Color.MediumSlateBlue
			Case "MediumSpringGreen"
				color_combo = Color.MediumSpringGreen
			Case "MediumTurquoise"
				color_combo = Color.MediumTurquoise
			Case "MediumVioletRed"
				color_combo = Color.MediumVioletRed
			Case "MidnightBlue"
				color_combo = Color.MidnightBlue
			Case "MintCream"
				color_combo = Color.MintCream
			Case "MistyRose"
				color_combo = Color.MistyRose
			Case "Moccasin"
				color_combo = Color.Moccasin
			Case "NavajoWhite"
				color_combo = Color.NavajoWhite
			Case "Navy"
				color_combo = Color.Navy
			Case "OldLace"
				color_combo = Color.OldLace
			Case "Olive"
				color_combo = Color.Olive
			Case "OliveDrab"
				color_combo = Color.OliveDrab
			Case "OrangeRed"
				color_combo = Color.OrangeRed
			Case "Orchid"
				color_combo = Color.Orchid
			Case "PaleGoldenrod"
				color_combo = Color.PaleGoldenrod
			Case "PaleGreen"
				color_combo = Color.PaleGreen
			Case "PaleTurquoise"
				color_combo = Color.PaleTurquoise
			Case "PaleVioletRed"
				color_combo = Color.PaleVioletRed
			Case "PapayaWhip"
				color_combo = Color.PapayaWhip
			Case "PeachPuff"
				color_combo = Color.PeachPuff
			Case "Peru"
				color_combo = Color.Peru
			Case "Plum"
				color_combo = Color.Plum
			Case "PowderBlue"
				color_combo = Color.PowderBlue
			Case "RosyBrown"
				color_combo = Color.RosyBrown
			Case "RoyalBlue"
				color_combo = Color.RoyalBlue
			Case "SaddleBrown"
				color_combo = Color.SaddleBrown
			Case "Salmon"
				color_combo = Color.Salmon
			Case "SandyBrown"
				color_combo = Color.SandyBrown
			Case "SeaGreen"
				color_combo = Color.SeaGreen
			Case "SeaShell"
				color_combo = Color.SeaShell
			Case "Sienna"
				color_combo = Color.Sienna
			Case "SkyBlue"
				color_combo = Color.SkyBlue
			Case "SlateBlue"
				color_combo = Color.SlateBlue
			Case "SlateGray"
				color_combo = Color.SlateGray
			Case "Snow"
				color_combo = Color.Snow
			Case "SpringGreen"
				color_combo = Color.SpringGreen
			Case "SteelBlue"
				color_combo = Color.SteelBlue
			Case "Tan"
				color_combo = Color.Tan
			Case "Teal"
				color_combo = Color.Teal
			Case "Thistle"
				color_combo = Color.Thistle
			Case "Tomato"
				color_combo = Color.Tomato
			Case "Turquoise"
				color_combo = Color.Turquoise
			Case "Wheat"
				color_combo = Color.Wheat
			Case "WhiteSmoke"
				color_combo = Color.WhiteSmoke
			Case "YellowGreen"
				color_combo = Color.YellowGreen
		End Select
		TabPage3.BackColor = color_combo
		Uploader.BackColor = color_combo
		Color_Combobox.BackColor = color_combo
		Languaje_Combobox.BackColor = color_combo
		TabPage1.BackColor = color_combo
		TabPage2.BackColor = color_combo
		ListViewEx.BackColor = color_combo
		List_Download.BackColor = color_combo
		ComboBox4.BackColor = color_combo
		ComboBox3.BackColor = color_combo
		Button1.BackColor = color_combo
		PictureBox2.BackColor = color_combo
		PictureBox3.BackColor = color_combo
		TextBox2.BackColor = color_combo
		TextBox3.BackColor = color_combo
		TextBox4.BackColor = color_combo
		TextBox6.BackColor = color_combo
		TextBox5.BackColor = color_combo
		ID_Game.BackColor = color_combo
		TextBox8.BackColor = color_combo
		LinkLicense_Text.BackColor = color_combo
		Upload_Add_item.BackColor = color_combo
		TextBox7.BackColor = color_combo
		Search_Label.BackColor = color_combo
		TextBox1.BackColor = color_combo
		Companya_Combo.BackColor = color_combo
		ComboBox1.BackColor = color_combo
		Name_Game_Label.BackColor = color_combo
		Type_label.BackColor = color_combo
		Format_label.BackColor = color_combo
		User_label.BackColor = color_combo
		Version_label.BackColor = color_combo
		Region_label.BackColor = color_combo
		DownParts.BackColor = color_combo
		Button2.BackColor = color_combo
		Button_Download.BackColor = color_combo
		ListView99.BackColor = color_combo
		List1.BackColor = color_combo
		ComboBox2.BackColor = color_combo
		MyToolStrip.BackColor = color_combo
		TextBox9.BackColor = color_combo

		If BackGround_Image = True Then
			If Dir(Application.StartupPath & "\Picture.png", vbDirectory) = "" Then
			Else
				Dim Dir_Image As String = Application.StartupPath & "\Picture.png"
				TabPage3.BackgroundImage = System.Drawing.Image.FromFile(Dir_Image)
				TabPage1.BackgroundImage = System.Drawing.Image.FromFile(Dir_Image)
				TabPage2.BackgroundImage = System.Drawing.Image.FromFile(Dir_Image)
				List_Download.BackgroundImage = System.Drawing.Image.FromFile(Dir_Image)
				PictureBox2.BackColor = Color.Transparent
				PictureBox3.BackColor = Color.Transparent
			End If
		End If
#End Region
		ini.Load(Application.StartupPath & "\Config.ini")
		Color_Combobox.Text = ini.GetKeyValue("Config", "Color")
		Me.Cursor = Cursors.Default

		List1.ListViewItemSorter = New ListViewItemComparer(1, True)
	End Sub
	Private Sub CreatedBy_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles CreatedBy.LinkClicked
		'Process.Start("https://github.com/TiTiYum/Project-Koppai/releases")
	End Sub
	Private Sub Uploader_Click(sender As Object, e As EventArgs) Handles Uploader.Click
		UploadList()
	End Sub
	Private Sub Createfolders()

		If Dir(Application.StartupPath & "\Roms", vbDirectory) = "" Then
			MkDir(Application.StartupPath & "\Roms")
		End If


		If Dir(Application.StartupPath & "\Lang", vbDirectory) = "" Then
			MkDir(Application.StartupPath & "\Lang")
		End If

		If Dir(Application.StartupPath & "\License", vbDirectory) = "" Then
			MkDir(Application.StartupPath & "\License")
		End If

		If Dir(Application.StartupPath & "\List", vbDirectory) = "" Then
			MkDir(Application.StartupPath & "\List")
			UploadList()
		End If

		If Dir(Application.StartupPath & "\List\Version", vbArchive) = "" Then
		Else
			Kill(Application.StartupPath & "\List\Version")
		End If

		'My.Computer.Network.DownloadFile(AES_Decrypt("U0VzLh27ENMYgkA8Zp67mlH4bFoD7Zh8otEcaclCBr2gPo7zkZJSvY7egf4Sfq1XYNg7AN0lO34nSAnLwKk8ow=="), Application.StartupPath & "\List\Version")
		'If File.ReadAllText(Application.StartupPath & "\List\Version").ToString = Version Then
		'Else
		'Process.Start("https://github.com/TiTiYum/Project-Koppai/releases/latest")
		'End If
		If System.IO.File.Exists((Application.StartupPath & "\Lang\English.ini")) = False Then
			System.IO.File.WriteAllText(Application.StartupPath & "\Lang\English.ini", "[LANGUAGE]
ID=ID
NAME=NAME
TYPE=TYPE
REGION=REGION
USER=USER
VERSION=VERSION
FORMAT=FORMAT
ENCRYPT=ENCRYPT
Error_Load_Image=Error Load Image
The_selected_dirrectory_does_not_exist_please_select_another_dirrectory=The selected dirrectory does not exist please select another dirrectory
Download_Start=Download Start
Name_Game=Name Game
Type=Type
Format=Format
User=User
Version=Version
Region=Region
Game_data_copied_in_Clipboard=Game data copied in Clipboard
Finished=Finished
Paused=Paused
Download_Complete=Download Complete
Downloading=Downloading
Initializing=Initializing
Filename=Filename
Size=Size
Status=Status
Completed=Completed
Progress=Progress
Speed=Speed
Check_image=Check image
Up_Game=Up Game
Time=Time
Time_Left=Time Left
Browse=Browse
Upload_List_Games=Upload List Games
Custom_Path_Save=Custom Path Save
Show_Uploader=Show Uploader
Background_Image=Background Image
UnLoad_Images_games_Less_lag_if_your_internet_is_not_good=UnLoad Images games (Less lag if your internet is not good)
If_you_already_have_a_defined_image_and_change_it_again_the_application_will_restart_be_careful_that_the_downloads_will_stop=If you already have a defined image and change it again, the application will restart, be careful that the downloads will stop
Resume=Resume
Resume_All=Resume All
Pause=Pause
Pause_All=Pause All
Remove=Remove
Remove_All=Remove All
Search=Search:
Download_License=Download License
Download_Game=Download Game
Edit_Url_List=Edit Url List
Are_you_sure_you_want_to_remove_this_file_from_the_download_list=Are you sure you want to remove this file from the download list?
Also_delete_files_from_disk=Also delete files from disk
Confirm_Delete=Confirm Delete")
		End If
		If System.IO.File.Exists((Application.StartupPath & "\Lang\Español.ini")) = False Then
			System.IO.File.WriteAllText(Application.StartupPath & "\Lang\Español.ini", "[LANGUAGE]
ID=ID
NAME=NOMBRE
TYPE=TIPO
REGION=REGIÓN
USER=USUARIO
VERSION=VERSIÓN
FORMAT=FORMATO
ENCRYPT=ENCRYPT
Error_Load_Image=Error al Cargar Imagen
The_selected_dirrectory_does_not_exist_please_select_another_dirrectory=La direcion del escritoro selecionada no existe
Download_Start=Comenzando Descarga
Name_Game=Nombre Juego
Type=Tipo
Format=Formato
User=Usuario
Version=Versión
Region=Región
Game_data_copied_in_Clipboard=Datos del juego copiado al portapapeles
Finished=Acabado
Paused=Pausado
Download_Complete=Descarga Completada
Downloading=Descargando
Initializing=Iniciando
Filename=Nombre del archivo
Size=Tamaño
Status=Estado
Completed=Completado
Progress=Progreso
Speed=Velocidad
Check_image=Verificar Imagen
Up_Game=Subir Juego
Time=Tiempo
Time_Left=Tiempo Restante
Browse=Buscar
Upload_List_Games=Actualizar lista de los juegos
Custom_Path_Save=Directorio Customizado de guardado
Show_Uploader=Mostrar Subidor
Background_Image=Imagen de fondo
UnLoad_Images_games_Less_lag_if_your_internet_is_not_good=No Cargar imagenes de los juegos(Es perfecto si tu internet es lento)
If_you_already_have_a_defined_image_and_change_it_again_the_application_will_restart_be_careful_that_the_downloads_will_stop=Si ya tiene una imagen definida y la vuelve a cambiar, la aplicación se reiniciará, tenga cuidado de que las descargas no se detengan
Resume=Resume
Resume_All=Resume Todo
Pause=Pausar
Pause_All=Pausar Todo
Remove=Eliminar
Remove_All=Eliminar Todo
Search=Buscar:
Download_License=Descargar Licencia
Download_Game=Descargar Juego
Edit_Url_List=Editar Url de la lista
Are_you_sure_you_want_to_remove_this_file_from_the_download_list=¿Seguro que quieres eliminar este archivo de la lista de descargas?
Also_delete_files_from_disk=Eliminar también archivos del disco
Confirm_Delete=Confirmar Eliminación")
		End If
		If System.IO.File.Exists((Application.StartupPath & "\Config.ini")) = True Then
			ini.Load(Application.StartupPath & "\Config.ini")
			If ini.GetKeyValue("Config", "Unload_Images") = "True" Then

				load_images_games = True
				CheckBox1.Checked = 1
			Else
				load_images_games = False
				CheckBox1.Checked = 0
			End If
			If ini.GetKeyValue("Config", "BackGroundImage") = "True" Then
				BackGround_Image = True
				background_image_checkbox.Checked = 1
			Else
				BackGround_Image = False
				background_image_checkbox.Checked = 0
			End If
			Color_ini = ini.GetKeyValue("Config", "Show_Uploader")
			If ini.GetKeyValue("Config", "Show_Uploader") = "False" Then
				Uploader_tab.Checked = 0
				Upload.TabPages.Remove(TabPage2)
				start_tab = False
				start_tab = True
				TextBox9.Visible = False
				Encrypt_Burron.Visible = False
			Else
				Uploader_tab.Checked = 1
				start_tab = True
			End If
			If ini.GetKeyValue("Config", "Path_Save") = "Default" Then
				CheckBox2.Checked = 0
				Button3.Visible = False
			Else
				CheckBox2.Checked = 1
				Dir_Save_Games = ini.GetKeyValue("Config", "Path_Save")
				'MsgBox(Dir_Save_Games)
			End If
			Color_Combobox.Text = ini.GetKeyValue("Config", "Color")
			Languaje_Combobox.Text = ini.GetKeyValue("Config", "Language")
			Languaje_Program = ini.GetKeyValue("Config", "Language")
		End If
		If System.IO.File.Exists((Application.StartupPath & "\Config.ini")) = False Then
			System.IO.File.Create((Application.StartupPath & "\Config.ini")).Dispose()
			'ini.Load(Application.StartupPath & "\Config.ini")
			'ini.AddSection("Config").AddKey("Unload_Images").Value = "True"
			'ini.AddSection("Config").AddKey("BackGroundImage").Value = "False"
			'ini.AddSection("Config").AddKey("Color").Value = "White"
			load_images_games = False
			CheckBox1.Checked = 0
			BackGround_Image = False
			Upload.TabPages.Remove(TabPage2)
			'Color_ini = ini.GetKeyValue("Config", "Color")
			'ini.Save(Application.StartupPath & "\Config.ini")
			Languaje_Program = "English"
			System.IO.File.WriteAllText(Application.StartupPath & "\Config.ini", "[Config]
BackGroundImage=False
Color=White
Unload_Images=True
Show_Uploader=False
Path_Save=Default
Language=English")

		End If
#Region "List"
		If System.IO.File.Exists((Application.StartupPath & "\List.ini")) = False Then
			System.IO.File.Create((Application.StartupPath & "\List.ini")).Dispose()
			ini.Load(Application.StartupPath & "\List.ini")
			ini.AddSection("DirList").AddKey("Wii").Value = "NONE"
			ini.AddSection("DirList").AddKey("WiiU").Value = "NONE"
			ini.AddSection("DirList").AddKey("NSwich").Value = "NONE"
			ini.AddSection("DirList").AddKey("N64").Value = "NONE"
			ini.AddSection("DirList").AddKey("GameCube").Value = "NONE"
			ini.AddSection("DirList").AddKey("VirtualBoy").Value = "NONE"
			ini.AddSection("DirList").AddKey("GameBoyAdvance").Value = "NONE"
			ini.AddSection("DirList").AddKey("SNES").Value = "NONE"
			ini.AddSection("DirList").AddKey("NES").Value = "NONE"
			ini.AddSection("DirList").AddKey("NDS").Value = "NONE"
			ini.AddSection("DirList").AddKey("3DS").Value = "NONE"
			ini.AddSection("DirList").AddKey("GameBoy").Value = "NONE"
			ini.AddSection("DirList").AddKey("G&W").Value = "NONE"
			ini.AddSection("DirList").AddKey("PS1").Value = "NONE"
			ini.AddSection("DirList").AddKey("PS2").Value = "NONE"
			ini.AddSection("DirList").AddKey("PS3").Value = "NONE"
			ini.AddSection("DirList").AddKey("PS4").Value = "NONE"
			ini.AddSection("DirList").AddKey("PSP").Value = "NONE"
			ini.AddSection("DirList").AddKey("PSVita").Value = "NONE"
			ini.AddSection("DirList").AddKey("PocketStation").Value = "NONE"
			ini.AddSection("DirList").AddKey("Xbox").Value = "NONE"
			ini.AddSection("DirList").AddKey("Xbox360").Value = "NONE"
			ini.AddSection("DirList").AddKey("XboxOne").Value = "NONE"
			ini.AddSection("DirList").AddKey("SG-1000").Value = "NONE"
			ini.AddSection("DirList").AddKey("SC-3000").Value = "NONE"
			ini.AddSection("DirList").AddKey("Sega-Master-System").Value = "NONE"
			ini.AddSection("DirList").AddKey("Sega-Genesis").Value = "NONE"
			ini.AddSection("DirList").AddKey("Sega-Mega-CD").Value = "NONE"
			ini.AddSection("DirList").AddKey("Game-Gear").Value = "NONE"
			ini.AddSection("DirList").AddKey("Sega-Saturn").Value = "NONE"
			ini.AddSection("DirList").AddKey("Mega-Drive-32x").Value = "NONE"
			ini.AddSection("DirList").AddKey("Sega-Nomad").Value = "NONE"
			ini.AddSection("DirList").AddKey("Sega-Model-2").Value = "NONE"
			ini.AddSection("DirList").AddKey("Dreamcast").Value = "NONE"
			ini.AddSection("DirList").AddKey("Neo-Geo").Value = "NONE"
			ini.AddSection("DirList").AddKey("Neo-Geo-CD").Value = "NONE"
			ini.AddSection("DirList").AddKey("Pippin").Value = "NONE"
			ini.AddSection("DirList").AddKey("Atari2600").Value = "NONE"
			ini.AddSection("DirList").AddKey("Atari5200").Value = "NONE"
			ini.AddSection("DirList").AddKey("Atari7800").Value = "NONE"
			ini.AddSection("DirList").AddKey("Atari-Jaguar").Value = "NONE"
			ini.AddSection("DirList").AddKey("Playdia").Value = "NONE"
			ini.AddSection("DirList").AddKey("Wonderswan").Value = "NONE"
			ini.AddSection("DirList").AddKey("Wonderswan-Color").Value = "NONE"
			ini.AddSection("DirList").AddKey("Play-System-1").Value = "NONE"
			ini.AddSection("DirList").AddKey("Play-System-2").Value = "NONE"
			ini.AddSection("DirList").AddKey("Play-System-3").Value = "NONE"
			ini.AddSection("DirList").AddKey("Casio-Loopy").Value = "NONE"
			ini.AddSection("DirList").AddKey("ColecoVision").Value = "NONE"
			ini.AddSection("DirList").AddKey("Commodore64GSU").Value = "NONE"
			ini.AddSection("DirList").AddKey("AmigaCD32").Value = "NONE"
			ini.AddSection("DirList").AddKey("AmigaCD").Value = "NONE"
			ini.AddSection("DirList").AddKey("Fairchild-Channel-F").Value = "NONE"
			ini.AddSection("DirList").AddKey("GP32").Value = "NONE"
			ini.AddSection("DirList").AddKey("Vectrex").Value = "NONE"
			ini.AddSection("DirList").AddKey("Magnavox-Oddyssey").Value = "NONE"
			ini.AddSection("DirList").AddKey("Magnavox-Oddyssey2").Value = "NONE"
			ini.AddSection("DirList").AddKey("Intellivision").Value = "NONE"
			ini.AddSection("DirList").AddKey("PC-Engine").Value = "NONE"
			ini.AddSection("DirList").AddKey("PC-FX").Value = "NONE"
			ini.AddSection("DirList").AddKey("N-Gage").Value = "NONE"
			ini.AddSection("DirList").AddKey("3DO").Value = "NONE"
			ini.AddSection("DirList").AddKey("Videopac").Value = "NONE"
			ini.AddSection("DirList").AddKey("Philips-CDi").Value = "NONE"
			ini.AddSection("DirList").AddKey("RCA-Studio-II").Value = "NONE"
			ini.AddSection("DirList").AddKey("V-Smile").Value = "NONE"
			ini.AddSection("DirList").AddKey("AmstradGX4000").Value = "NONE"
			load_images_games = False
			CheckBox1.Checked = 0
			BackGround_Image = False
			ini.Save(Application.StartupPath & "\List.ini")
		End If
		If System.IO.File.Exists((Application.StartupPath & "\List.ini")) = True Then
			ini.Load(Application.StartupPath & "\List.ini")
			If ini.GetKeyValue("DirList", "Wii") = "NONE" Then
			Else
				DirGamesDownload(0) = ini.GetKeyValue("DirList", "Wii")
			End If
			If ini.GetKeyValue("DirList", "WiiU") = "NONE" Then
			Else
				DirGamesDownload(1) = ini.GetKeyValue("DirList", "WiiU")
			End If
			If ini.GetKeyValue("DirList", "NSwich") = "NONE" Then
			Else
				DirGamesDownload(2) = ini.GetKeyValue("DirList", "NSwich")
			End If
			If ini.GetKeyValue("DirList", "N64") = "NONE" Then
			Else
				DirGamesDownload(3) = ini.GetKeyValue("DirList", "N64")
			End If
			If ini.GetKeyValue("DirList", "GameCube") = "NONE" Then
			Else
				DirGamesDownload(4) = ini.GetKeyValue("DirList", "GameCube")
			End If
			If ini.GetKeyValue("DirList", "VirtualBoy") = "NONE" Then
			Else
				DirGamesDownload(5) = ini.GetKeyValue("DirList", "VirtualBoy")
			End If
			If ini.GetKeyValue("DirList", "GameBoyAdvance") = "NONE" Then
			Else
				DirGamesDownload(6) = ini.GetKeyValue("DirList", "GameBoyAdvance")
			End If
			If ini.GetKeyValue("DirList", "SNES") = "NONE" Then
			Else
				DirGamesDownload(7) = ini.GetKeyValue("DirList", "SNES")
			End If
			If ini.GetKeyValue("DirList", "NES") = "NONE" Then
			Else
				DirGamesDownload(8) = ini.GetKeyValue("DirList", "NES")
			End If
			If ini.GetKeyValue("DirList", "NDS") = "NONE" Then
			Else
				DirGamesDownload(9) = ini.GetKeyValue("DirList", "NDS")
			End If
			If ini.GetKeyValue("DirList", "3DS") = "NONE" Then
			Else
				DirGamesDownload(10) = ini.GetKeyValue("DirList", "3DS")
			End If
			If ini.GetKeyValue("DirList", "GameBoy") = "NONE" Then
			Else
				DirGamesDownload(11) = ini.GetKeyValue("DirList", "GameBoy")
			End If
			If ini.GetKeyValue("DirList", "G&W") = "NONE" Then
			Else
				DirGamesDownload(12) = ini.GetKeyValue("DirList", "G&W")
			End If
			If ini.GetKeyValue("DirList", "PS1") = "NONE" Then
			Else
				DirGamesDownload(13) = ini.GetKeyValue("DirList", "PS1")
			End If
			If ini.GetKeyValue("DirList", "PS2") = "NONE" Then
			Else
				DirGamesDownload(14) = ini.GetKeyValue("DirList", "PS2")
			End If
			If ini.GetKeyValue("DirList", "PS3") = "NONE" Then
			Else
				DirGamesDownload(15) = ini.GetKeyValue("DirList", "PS3")
			End If
			If ini.GetKeyValue("DirList", "PS4") = "NONE" Then
			Else
				DirGamesDownload(16) = ini.GetKeyValue("DirList", "PS4")
			End If
			If ini.GetKeyValue("DirList", "PSP") = "NONE" Then
			Else
				DirGamesDownload(17) = ini.GetKeyValue("DirList", "PSP")
			End If
			If ini.GetKeyValue("DirList", "PSVita") = "NONE" Then
			Else
				DirGamesDownload(18) = ini.GetKeyValue("DirList", "PSVita")
			End If
			If ini.GetKeyValue("DirList", "PocketStation") = "NONE" Then
			Else
				DirGamesDownload(19) = ini.GetKeyValue("DirList", "PocketStation")
			End If
			If ini.GetKeyValue("DirList", "Xbox") = "NONE" Then
			Else
				DirGamesDownload(20) = ini.GetKeyValue("DirList", "Xbox")
			End If
			If ini.GetKeyValue("DirList", "Xbox360") = "NONE" Then
			Else
				DirGamesDownload(21) = ini.GetKeyValue("DirList", "Xbox360")
			End If
			If ini.GetKeyValue("DirList", "XboxOne") = "NONE" Then
			Else
				DirGamesDownload(22) = ini.GetKeyValue("DirList", "XboxOne")
			End If
			If ini.GetKeyValue("DirList", "SG-1000") = "NONE" Then
			Else
				DirGamesDownload(23) = ini.GetKeyValue("DirList", "SG-1000")
			End If
			If ini.GetKeyValue("DirList", "SC-3000") = "NONE" Then
			Else
				DirGamesDownload(24) = ini.GetKeyValue("DirList", "SC-3000")
			End If
			If ini.GetKeyValue("DirList", "Sega-Master-System") = "NONE" Then
			Else
				DirGamesDownload(25) = ini.GetKeyValue("DirList", "Sega-Master-System")
			End If
			If ini.GetKeyValue("DirList", "Sega-Genesis") = "NONE" Then
			Else
				DirGamesDownload(26) = ini.GetKeyValue("DirList", "Sega-Genesis")
			End If
			If ini.GetKeyValue("DirList", "Sega-Mega-CD") = "NONE" Then
			Else
				DirGamesDownload(27) = ini.GetKeyValue("DirList", "Sega-Mega-CD")
			End If
			If ini.GetKeyValue("DirList", "Game-Gear") = "NONE" Then
			Else
				DirGamesDownload(28) = ini.GetKeyValue("DirList", "Game-Gear")
			End If
			If ini.GetKeyValue("DirList", "Sega-Saturn") = "NONE" Then
			Else
				DirGamesDownload(29) = ini.GetKeyValue("DirList", "Sega-Saturn")
			End If
			If ini.GetKeyValue("DirList", "Mega-Drive-32x") = "NONE" Then
			Else
				DirGamesDownload(30) = ini.GetKeyValue("DirList", "Mega-Drive-32x")
			End If
			If ini.GetKeyValue("DirList", "Sega-Nomad") = "NONE" Then
			Else
				DirGamesDownload(31) = ini.GetKeyValue("DirList", "Sega-Nomad")
			End If
			If ini.GetKeyValue("DirList", "Sega-Model-2") = "NONE" Then
			Else
				DirGamesDownload(32) = ini.GetKeyValue("DirList", "Sega-Model-2")
			End If
			If ini.GetKeyValue("DirList", "Dreamcast") = "NONE" Then
			Else
				DirGamesDownload(33) = ini.GetKeyValue("DirList", "Dreamcast")
			End If
			If ini.GetKeyValue("DirList", "Neo-Geo") = "NONE" Then
			Else
				DirGamesDownload(34) = ini.GetKeyValue("DirList", "Neo-Geo")
			End If
			If ini.GetKeyValue("DirList", "Neo-Geo-CD") = "NONE" Then
			Else
				DirGamesDownload(35) = ini.GetKeyValue("DirList", "Neo-Geo-CD")
			End If
			If ini.GetKeyValue("DirList", "Pippin") = "NONE" Then
			Else
				DirGamesDownload(36) = ini.GetKeyValue("DirList", "Pippin")
			End If
			If ini.GetKeyValue("DirList", "Atari2600") = "NONE" Then
			Else
				DirGamesDownload(37) = ini.GetKeyValue("DirList", "Atari2600")
			End If
			If ini.GetKeyValue("DirList", "Atari5200") = "NONE" Then
			Else
				DirGamesDownload(38) = ini.GetKeyValue("DirList", "Atari5200")
			End If
			If ini.GetKeyValue("DirList", "Atari7800") = "NONE" Then
			Else
				DirGamesDownload(39) = ini.GetKeyValue("DirList", "Atari7800")
			End If
			If ini.GetKeyValue("DirList", "Atari-Jaguar") = "NONE" Then
			Else
				DirGamesDownload(40) = ini.GetKeyValue("DirList", "Atari-Jaguar")
			End If
			If ini.GetKeyValue("DirList", "Playdia") = "NONE" Then
			Else
				DirGamesDownload(41) = ini.GetKeyValue("DirList", "Playdia")
			End If
			If ini.GetKeyValue("DirList", "Wonderswan") = "NONE" Then
			Else
				DirGamesDownload(42) = ini.GetKeyValue("DirList", "Wonderswan")
			End If
			If ini.GetKeyValue("DirList", "Wonderswan-Color") = "NONE" Then
			Else
				DirGamesDownload(43) = ini.GetKeyValue("DirList", "Wonderswan-Color")
			End If
			If ini.GetKeyValue("DirList", "Play-System-1") = "NONE" Then
			Else
				DirGamesDownload(44) = ini.GetKeyValue("DirList", "Play-System-1")
			End If
			If ini.GetKeyValue("DirList", "Play-System-2") = "NONE" Then
			Else
				DirGamesDownload(45) = ini.GetKeyValue("DirList", "Play-System-2")
			End If
			If ini.GetKeyValue("DirList", "Play-System-3") = "NONE" Then
			Else
				DirGamesDownload(46) = ini.GetKeyValue("DirList", "Play-System-3")
			End If
			If ini.GetKeyValue("DirList", "Casio-Loopy") = "NONE" Then
			Else
				DirGamesDownload(47) = ini.GetKeyValue("DirList", "Casio-Loopy")
			End If
			If ini.GetKeyValue("DirList", "ColecoVision") = "NONE" Then
			Else
				DirGamesDownload(48) = ini.GetKeyValue("DirList", "ColecoVision")
			End If
			If ini.GetKeyValue("DirList", "Commodore64GSU") = "NONE" Then
			Else
				DirGamesDownload(49) = ini.GetKeyValue("DirList", "Commodore64GSU")
			End If
			If ini.GetKeyValue("DirList", "AmigaCD32") = "NONE" Then
			Else
				DirGamesDownload(50) = ini.GetKeyValue("DirList", "AmigaCD32")
			End If
			If ini.GetKeyValue("DirList", "AmigaCD") = "NONE" Then
			Else
				DirGamesDownload(51) = ini.GetKeyValue("DirList", "AmigaCD")
			End If
			If ini.GetKeyValue("DirList", "Fairchild-Channel-F") = "NONE" Then
			Else
				DirGamesDownload(52) = ini.GetKeyValue("DirList", "Fairchild-Channel-F")
			End If
			If ini.GetKeyValue("DirList", "GP32") = "NONE" Then
			Else
				DirGamesDownload(53) = ini.GetKeyValue("DirList", "GP32")
			End If
			If ini.GetKeyValue("DirList", "Vectrex") = "NONE" Then
			Else
				DirGamesDownload(54) = ini.GetKeyValue("DirList", "Vectrex")
			End If
			If ini.GetKeyValue("DirList", "Magnavox-Oddyssey") = "NONE" Then
			Else
				DirGamesDownload(55) = ini.GetKeyValue("DirList", "Magnavox-Oddyssey")
			End If
			If ini.GetKeyValue("DirList", "Magnavox-Oddyssey2") = "NONE" Then
			Else
				DirGamesDownload(56) = ini.GetKeyValue("DirList", "Magnavox-Oddyssey2")
			End If
			If ini.GetKeyValue("DirList", "Intellivision") = "NONE" Then
			Else
				DirGamesDownload(57) = ini.GetKeyValue("DirList", "Intellivision")
			End If
			If ini.GetKeyValue("DirList", "PC-Engine") = "NONE" Then
			Else
				DirGamesDownload(58) = ini.GetKeyValue("DirList", "PC-Engine")
			End If
			If ini.GetKeyValue("DirList", "PC-FX") = "NONE" Then
			Else
				DirGamesDownload(59) = ini.GetKeyValue("DirList", "PC-FX")
			End If
			If ini.GetKeyValue("DirList", "N-Gage") = "NONE" Then
			Else
				DirGamesDownload(60) = ini.GetKeyValue("DirList", "N-Gage")
			End If
			If ini.GetKeyValue("DirList", "3DO") = "NONE" Then
			Else
				DirGamesDownload(61) = ini.GetKeyValue("DirList", "3DO")
			End If
			If ini.GetKeyValue("DirList", "Videopac") = "NONE" Then
			Else
				DirGamesDownload(62) = ini.GetKeyValue("DirList", "Videopac")
			End If
			If ini.GetKeyValue("DirList", "Philips-CDi") = "NONE" Then
			Else
				DirGamesDownload(63) = ini.GetKeyValue("DirList", "Philips-CDi")
			End If
			If ini.GetKeyValue("DirList", "RCA-Studio-II") = "NONE" Then
			Else
				DirGamesDownload(64) = ini.GetKeyValue("DirList", "RCA-Studio-II")
			End If
			If ini.GetKeyValue("DirList", "V-Smile") = "NONE" Then
			Else
				DirGamesDownload(65) = ini.GetKeyValue("DirList", "V-Smile")
			End If
			If ini.GetKeyValue("DirList", "AmstradGX4000") = "NONE" Then
			Else
				DirGamesDownload(66) = ini.GetKeyValue("DirList", "AmstradGX4000")
			End If
		End If
		'Color_ini = ini.GetKeyValue("Config", "Color")

#End Region
	End Sub
	Private Sub UploadList()
		'Delete List
		Me.Cursor = Cursors.WaitCursor
#Region "Delete"
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
		If Dir(Application.StartupPath & "\List\Games-List-3DO", vbArchive) = "" Then
		Else
			Kill(Application.StartupPath & "\List\Games-List-3DO")
		End If
		If Dir(Application.StartupPath & "\List\Games-List-AmigaCD", vbArchive) = "" Then
		Else
			Kill(Application.StartupPath & "\List\Games-List-AmigaCD")
		End If
		If Dir(Application.StartupPath & "\List\Games-List-AmigaCD32", vbArchive) = "" Then
		Else
			Kill(Application.StartupPath & "\List\Games-List-AmigaCD32")
		End If
		If Dir(Application.StartupPath & "\List\Games-List-AmstradGX4000", vbArchive) = "" Then
		Else
			Kill(Application.StartupPath & "\List\Games-List-AmstradGX4000")
		End If
		If Dir(Application.StartupPath & "\List\Games-List-Atari2600", vbArchive) = "" Then
		Else
			Kill(Application.StartupPath & "\List\Games-List-Atari2600")
		End If
		If Dir(Application.StartupPath & "\List\Games-List-Atari5200", vbArchive) = "" Then
		Else
			Kill(Application.StartupPath & "\List\Games-List-Atari5200")
		End If
		If Dir(Application.StartupPath & "\List\Games-List-Atari7800", vbArchive) = "" Then
		Else
			Kill(Application.StartupPath & "\List\Games-List-Atari7800")
		End If
		If Dir(Application.StartupPath & "\List\Games-List-Atari-Jaguar", vbArchive) = "" Then
		Else
			Kill(Application.StartupPath & "\List\Games-List-Atari-Jaguar")
		End If
		If Dir(Application.StartupPath & "\List\Games-List-Casio-Loopy", vbArchive) = "" Then
		Else
			Kill(Application.StartupPath & "\List\Games-List-Casio-Loopy")
		End If
		If Dir(Application.StartupPath & "\List\Games-List-ColecoVision", vbArchive) = "" Then
		Else
			Kill(Application.StartupPath & "\List\Games-List-ColecoVision")
		End If
		If Dir(Application.StartupPath & "\List\Games-List-Commodore64GS", vbArchive) = "" Then
		Else
			Kill(Application.StartupPath & "\List\Games-List-Commodore64GS")
		End If
		If Dir(Application.StartupPath & "\List\Games-List-Dreamcast", vbArchive) = "" Then
		Else
			Kill(Application.StartupPath & "\List\Games-List-Dreamcast")
		End If
		If Dir(Application.StartupPath & "\List\Games-List-Fairchild-Channel-F", vbArchive) = "" Then
		Else
			Kill(Application.StartupPath & "\List\Games-List-Fairchild-Channel-F")
		End If
		If Dir(Application.StartupPath & "\List\Games-List-G&W", vbArchive) = "" Then
		Else
			Kill(Application.StartupPath & "\List\Games-List-G&W")
		End If
		If Dir(Application.StartupPath & "\List\Games-List-Game-Gear", vbArchive) = "" Then
		Else
			Kill(Application.StartupPath & "\List\Games-List-Game-Gear")
		End If
		If Dir(Application.StartupPath & "\List\Games-List-GP32", vbArchive) = "" Then
		Else
			Kill(Application.StartupPath & "\List\Games-List-GP32")
		End If
		If Dir(Application.StartupPath & "\List\Games-List-Intellivision", vbArchive) = "" Then
		Else
			Kill(Application.StartupPath & "\List\Games-List-Intellivision")
		End If
		If Dir(Application.StartupPath & "\List\Games-List-Magnavox-Oddyssey", vbArchive) = "" Then
		Else
			Kill(Application.StartupPath & "\List\Games-List-Magnavox-Oddyssey")
		End If
		If Dir(Application.StartupPath & "\List\Games-List-Magnavox-Oddyssey2", vbArchive) = "" Then
		Else
			Kill(Application.StartupPath & "\List\Games-List-Magnavox-Oddyssey2")
		End If
		If Dir(Application.StartupPath & "\List\Games-List-Mega-Drive-32x", vbArchive) = "" Then
		Else
			Kill(Application.StartupPath & "\List\Games-List-Mega-Drive-32x")
		End If
		If Dir(Application.StartupPath & "\List\Games-List-Neo-Geo", vbArchive) = "" Then
		Else
			Kill(Application.StartupPath & "\List\Games-List-Neo-Geo")
		End If
		If Dir(Application.StartupPath & "\List\Games-List-Neo-Geo-CD", vbArchive) = "" Then
		Else
			Kill(Application.StartupPath & "\List\Games-List-Neo-Geo-CD")
		End If
		If Dir(Application.StartupPath & "\List\Games-List-N-Gage", vbArchive) = "" Then
		Else
			Kill(Application.StartupPath & "\List\Games-List-N-Gage")
		End If
		If Dir(Application.StartupPath & "\List\Games-List-PC-Engine", vbArchive) = "" Then
		Else
			Kill(Application.StartupPath & "\List\Games-List-PC-Engine")
		End If
		If Dir(Application.StartupPath & "\List\Games-List-PC-FX", vbArchive) = "" Then
		Else
			Kill(Application.StartupPath & "\List\Games-List-PC-FX")
		End If
		If Dir(Application.StartupPath & "\List\Games-List-Philips-CDi", vbArchive) = "" Then
		Else
			Kill(Application.StartupPath & "\List\Games-List-Philips-CDi")
		End If
		If Dir(Application.StartupPath & "\List\Games-List-Pippin", vbArchive) = "" Then
		Else
			Kill(Application.StartupPath & "\List\Games-List-Pippin")
		End If
		If Dir(Application.StartupPath & "\List\Games-List-Playdia", vbArchive) = "" Then
		Else
			Kill(Application.StartupPath & "\List\Games-List-Playdia")
		End If
		If Dir(Application.StartupPath & "\List\Games-List-Play-System-1", vbArchive) = "" Then
		Else
			Kill(Application.StartupPath & "\List\Games-List-Play-System-1")
		End If
		If Dir(Application.StartupPath & "\List\Games-List-Play-System-2", vbArchive) = "" Then
		Else
			Kill(Application.StartupPath & "\List\Games-List-Play-System-2")
		End If
		If Dir(Application.StartupPath & "\List\Games-List-Play-System-3", vbArchive) = "" Then
		Else
			Kill(Application.StartupPath & "\List\Games-List-Play-System-3")
		End If
		If Dir(Application.StartupPath & "\List\Games-List-PocketStation", vbArchive) = "" Then
		Else
			Kill(Application.StartupPath & "\List\Games-List-PocketStation")
		End If
		If Dir(Application.StartupPath & "\List\Games-List-PS1", vbArchive) = "" Then
		Else
			Kill(Application.StartupPath & "\List\Games-List-PS1")
		End If
		If Dir(Application.StartupPath & "\List\Games-List-PS2", vbArchive) = "" Then
		Else
			Kill(Application.StartupPath & "\List\Games-List-PS2")
		End If
		If Dir(Application.StartupPath & "\List\Games-List-PS3", vbArchive) = "" Then
		Else
			Kill(Application.StartupPath & "\List\Games-List-PS3")
		End If
		If Dir(Application.StartupPath & "\List\Games-List-PS4", vbArchive) = "" Then
		Else
			Kill(Application.StartupPath & "\List\Games-List-PS4")
		End If
		If Dir(Application.StartupPath & "\List\Games-List-PSP", vbArchive) = "" Then
		Else
			Kill(Application.StartupPath & "\List\Games-List-PSP")
		End If
		If Dir(Application.StartupPath & "\List\Games-List-PSVita", vbArchive) = "" Then
		Else
			Kill(Application.StartupPath & "\List\Games-List-PSVita")
		End If
		If Dir(Application.StartupPath & "\List\Games-List-RCA-Studio-II", vbArchive) = "" Then
		Else
			Kill(Application.StartupPath & "\List\Games-List-RCA-Studio-II")
		End If
		If Dir(Application.StartupPath & "\List\Games-List-SC-3000", vbArchive) = "" Then
		Else
			Kill(Application.StartupPath & "\List\Games-List-SC-3000")
		End If
		If Dir(Application.StartupPath & "\List\Games-List-Sega-Genesis", vbArchive) = "" Then
		Else
			Kill(Application.StartupPath & "\List\Games-List-Sega-Genesis")
		End If
		If Dir(Application.StartupPath & "\List\Games-List-Sega-Master-System", vbArchive) = "" Then
		Else
			Kill(Application.StartupPath & "\List\Games-List-Sega-Master-System")
		End If
		If Dir(Application.StartupPath & "\List\Games-List-Sega-Mega-CD", vbArchive) = "" Then
		Else
			Kill(Application.StartupPath & "\List\Games-List-Sega-Mega-CD")
		End If
		If Dir(Application.StartupPath & "\List\Games-List-Sega-Model-2", vbArchive) = "" Then
		Else
			Kill(Application.StartupPath & "\List\Games-List-Sega-Model-2")
		End If
		If Dir(Application.StartupPath & "\List\Games-List-Sega-Nomad", vbArchive) = "" Then
		Else
			Kill(Application.StartupPath & "\List\Games-List-Sega-Nomad")
		End If
		If Dir(Application.StartupPath & "\List\Games-List-Sega-Saturn", vbArchive) = "" Then
		Else
			Kill(Application.StartupPath & "\List\Games-List-Sega-Saturn")
		End If
		If Dir(Application.StartupPath & "\List\Games-List-SG-1000", vbArchive) = "" Then
		Else
			Kill(Application.StartupPath & "\List\Games-List-SG-1000")
		End If
		If Dir(Application.StartupPath & "\List\Games-List-Vectrex", vbArchive) = "" Then
		Else
			Kill(Application.StartupPath & "\List\Games-List-Vectrex")
		End If
		If Dir(Application.StartupPath & "\List\Games-List-Videopac", vbArchive) = "" Then
		Else
			Kill(Application.StartupPath & "\List\Games-List-Videopac")
		End If
		If Dir(Application.StartupPath & "\List\Games-List-V-Smile", vbArchive) = "" Then
		Else
			Kill(Application.StartupPath & "\List\Games-List-V-Smile")
		End If
		If Dir(Application.StartupPath & "\List\Games-List-Wonderswan", vbArchive) = "" Then
		Else
			Kill(Application.StartupPath & "\List\Games-List-Wonderswan")
		End If
		If Dir(Application.StartupPath & "\List\Games-List-Wonderswan-Color", vbArchive) = "" Then
		Else
			Kill(Application.StartupPath & "\List\Games-List-Wonderswan-Color")
		End If
		If Dir(Application.StartupPath & "\List\Games-List-Xbox", vbArchive) = "" Then
		Else
			Kill(Application.StartupPath & "\List\Games-List-Xbox")
		End If
		If Dir(Application.StartupPath & "\List\Games-List-Xbox360", vbArchive) = "" Then
		Else
			Kill(Application.StartupPath & "\List\Games-List-Xbox360")
		End If
		If Dir(Application.StartupPath & "\List\Games-List-XboxOne", vbArchive) = "" Then
		Else
			Kill(Application.StartupPath & "\List\Games-List-XboxOne")
		End If
#End Region
		'Download List
#Region "Download"
		Try
			If UrlExist(AES_Decrypt(DirGamesDownload(0))) = True Then
				My.Computer.Network.DownloadFile(AES_Decrypt(DirGamesDownload(0)), Application.StartupPath & "\List\Games-List-Wii")
			End If
			If UrlExist(AES_Decrypt(DirGamesDownload(1))) = True Then
				My.Computer.Network.DownloadFile(AES_Decrypt(DirGamesDownload(1)), Application.StartupPath & "\List\Games-List-WiiU")
			End If
			If UrlExist(AES_Decrypt(DirGamesDownload(2))) = True Then
				My.Computer.Network.DownloadFile(AES_Decrypt(DirGamesDownload(2)), Application.StartupPath & "\List\Games-List-NSwich")
			End If
			If UrlExist(AES_Decrypt(DirGamesDownload(3))) = True Then
				My.Computer.Network.DownloadFile(AES_Decrypt(DirGamesDownload(3)), Application.StartupPath & "\List\Games-List-N64")
			End If
			If UrlExist(AES_Decrypt(DirGamesDownload(4))) = True Then
				My.Computer.Network.DownloadFile(AES_Decrypt(DirGamesDownload(4)), Application.StartupPath & "\List\Games-List-GameCube")
			End If
			If UrlExist(AES_Decrypt(DirGamesDownload(5))) = True Then
				My.Computer.Network.DownloadFile(AES_Decrypt(DirGamesDownload(5)), Application.StartupPath & "\List\Games-List-VirtualBoy")
			End If
			If UrlExist(AES_Decrypt(DirGamesDownload(6))) = True Then
				My.Computer.Network.DownloadFile(AES_Decrypt(DirGamesDownload(6)), Application.StartupPath & "\List\Games-List-GameBoyAdvance")
			End If
			If UrlExist(AES_Decrypt(DirGamesDownload(7))) = True Then
				My.Computer.Network.DownloadFile(AES_Decrypt(DirGamesDownload(7)), Application.StartupPath & "\List\Games-List-SNES")
			End If
			If UrlExist(AES_Decrypt(DirGamesDownload(8))) = True Then
				My.Computer.Network.DownloadFile(AES_Decrypt(DirGamesDownload(8)), Application.StartupPath & "\List\Games-List-NES")
			End If
			If UrlExist(AES_Decrypt(DirGamesDownload(9))) = True Then
				My.Computer.Network.DownloadFile(AES_Decrypt(DirGamesDownload(9)), Application.StartupPath & "\List\Games-List-NDS")
			End If
			If UrlExist(AES_Decrypt(DirGamesDownload(10))) = True Then
				My.Computer.Network.DownloadFile(AES_Decrypt(DirGamesDownload(10)), Application.StartupPath & "\List\Games-List-3DS")
			End If
			If UrlExist(AES_Decrypt(DirGamesDownload(11))) = True Then
				My.Computer.Network.DownloadFile(AES_Decrypt(DirGamesDownload(11)), Application.StartupPath & "\List\Games-List-GameBoy")
			End If
			If UrlExist(AES_Decrypt(DirGamesDownload(12))) = True Then
				My.Computer.Network.DownloadFile(AES_Decrypt(DirGamesDownload(12)), Application.StartupPath & "\List\Games-List-G&W")
			End If
			If UrlExist(AES_Decrypt(DirGamesDownload(13))) = True Then
				My.Computer.Network.DownloadFile(AES_Decrypt(DirGamesDownload(13)), Application.StartupPath & "\List\Games-List-PS1")
			End If
			If UrlExist(AES_Decrypt(DirGamesDownload(14))) = True Then
				My.Computer.Network.DownloadFile(AES_Decrypt(DirGamesDownload(14)), Application.StartupPath & "\List\Games-List-PS2")
			End If
			If UrlExist(AES_Decrypt(DirGamesDownload(15))) = True Then
				My.Computer.Network.DownloadFile(AES_Decrypt(DirGamesDownload(15)), Application.StartupPath & "\List\Games-List-PS3")
			End If
			If UrlExist(AES_Decrypt(DirGamesDownload(16))) = True Then
				My.Computer.Network.DownloadFile(AES_Decrypt(DirGamesDownload(16)), Application.StartupPath & "\List\Games-List-PS4")
			End If
			If UrlExist(AES_Decrypt(DirGamesDownload(17))) = True Then
				My.Computer.Network.DownloadFile(AES_Decrypt(DirGamesDownload(17)), Application.StartupPath & "\List\Games-List-PSP")
			End If
			If UrlExist(AES_Decrypt(DirGamesDownload(18))) = True Then
				My.Computer.Network.DownloadFile(AES_Decrypt(DirGamesDownload(18)), Application.StartupPath & "\List\Games-List-PSVita")
			End If
			If UrlExist(AES_Decrypt(DirGamesDownload(19))) = True Then
				My.Computer.Network.DownloadFile(AES_Decrypt(DirGamesDownload(19)), Application.StartupPath & "\List\Games-List-PocketStation")
			End If
			If UrlExist(AES_Decrypt(DirGamesDownload(20))) = True Then
				My.Computer.Network.DownloadFile(AES_Decrypt(DirGamesDownload(20)), Application.StartupPath & "\List\Games-List-Xbox")
			End If
			If UrlExist(AES_Decrypt(DirGamesDownload(21))) = True Then
				My.Computer.Network.DownloadFile(AES_Decrypt(DirGamesDownload(21)), Application.StartupPath & "\List\Games-List-Xbox360")
			End If
			If UrlExist(AES_Decrypt(DirGamesDownload(22))) = True Then
				My.Computer.Network.DownloadFile(AES_Decrypt(DirGamesDownload(22)), Application.StartupPath & "\List\Games-List-XboxOne")
			End If
			If UrlExist(AES_Decrypt(DirGamesDownload(23))) = True Then
				My.Computer.Network.DownloadFile(AES_Decrypt(DirGamesDownload(23)), Application.StartupPath & "\List\Games-List-SG-1000")
			End If
			If UrlExist(AES_Decrypt(DirGamesDownload(24))) = True Then
				My.Computer.Network.DownloadFile(AES_Decrypt(DirGamesDownload(24)), Application.StartupPath & "\List\Games-List-SC-3000")
			End If
			If UrlExist(AES_Decrypt(DirGamesDownload(25))) = True Then
				My.Computer.Network.DownloadFile(AES_Decrypt(DirGamesDownload(25)), Application.StartupPath & "\List\Games-List-Sega-Master-System")
			End If
			If UrlExist(AES_Decrypt(DirGamesDownload(26))) = True Then
				My.Computer.Network.DownloadFile(AES_Decrypt(DirGamesDownload(26)), Application.StartupPath & "\List\Games-List-Sega-Genesis")
			End If
			If UrlExist(AES_Decrypt(DirGamesDownload(27))) = True Then
				My.Computer.Network.DownloadFile(AES_Decrypt(DirGamesDownload(27)), Application.StartupPath & "\List\Games-List-Sega-Mega-CD")
			End If
			If UrlExist(AES_Decrypt(DirGamesDownload(28))) = True Then
				My.Computer.Network.DownloadFile(AES_Decrypt(DirGamesDownload(28)), Application.StartupPath & "\List\Games-List-Game-Gear")
			End If
			If UrlExist(AES_Decrypt(DirGamesDownload(29))) = True Then
				My.Computer.Network.DownloadFile(AES_Decrypt(DirGamesDownload(29)), Application.StartupPath & "\List\Games-List-Sega-Saturn")
			End If
			If UrlExist(AES_Decrypt(DirGamesDownload(30))) = True Then
				My.Computer.Network.DownloadFile(AES_Decrypt(DirGamesDownload(30)), Application.StartupPath & "\List\Games-List-Mega-Drive-32x")
			End If
			If UrlExist(AES_Decrypt(DirGamesDownload(31))) = True Then
				My.Computer.Network.DownloadFile(AES_Decrypt(DirGamesDownload(31)), Application.StartupPath & "\List\Games-List-Sega-Nomad")
			End If
			If UrlExist(AES_Decrypt(DirGamesDownload(32))) = True Then
				My.Computer.Network.DownloadFile(AES_Decrypt(DirGamesDownload(32)), Application.StartupPath & "\List\Games-List-Sega-Model-2")
			End If
			If UrlExist(AES_Decrypt(DirGamesDownload(33))) = True Then
				My.Computer.Network.DownloadFile(AES_Decrypt(DirGamesDownload(33)), Application.StartupPath & "\List\Games-List-Dreamcast")
			End If
			If UrlExist(AES_Decrypt(DirGamesDownload(34))) = True Then
				My.Computer.Network.DownloadFile(AES_Decrypt(DirGamesDownload(34)), Application.StartupPath & "\List\Games-List-Neo-Geo")
			End If
			If UrlExist(AES_Decrypt(DirGamesDownload(35))) = True Then
				My.Computer.Network.DownloadFile(AES_Decrypt(DirGamesDownload(35)), Application.StartupPath & "\List\Games-List-Neo-Geo-CD")
			End If
			If UrlExist(AES_Decrypt(DirGamesDownload(36))) = True Then
				My.Computer.Network.DownloadFile(AES_Decrypt(DirGamesDownload(36)), Application.StartupPath & "\List\Games-List-Pippin")
			End If
			If UrlExist(AES_Decrypt(DirGamesDownload(37))) = True Then
				My.Computer.Network.DownloadFile(AES_Decrypt(DirGamesDownload(37)), Application.StartupPath & "\List\Games-List-Atari2600")
			End If
			If UrlExist(AES_Decrypt(DirGamesDownload(38))) = True Then
				My.Computer.Network.DownloadFile(AES_Decrypt(DirGamesDownload(38)), Application.StartupPath & "\List\Games-List-Atari5200")
			End If
			If UrlExist(AES_Decrypt(DirGamesDownload(39))) = True Then
				My.Computer.Network.DownloadFile(AES_Decrypt(DirGamesDownload(39)), Application.StartupPath & "\List\Games-List-Atari7800")
			End If
			If UrlExist(AES_Decrypt(DirGamesDownload(40))) = True Then
				My.Computer.Network.DownloadFile(AES_Decrypt(DirGamesDownload(40)), Application.StartupPath & "\List\Games-List-Atari-Jaguar")
			End If
			If UrlExist(AES_Decrypt(DirGamesDownload(41))) = True Then
				My.Computer.Network.DownloadFile(AES_Decrypt(DirGamesDownload(41)), Application.StartupPath & "\List\Games-List-Playdia")
			End If
			If UrlExist(AES_Decrypt(DirGamesDownload(42))) = True Then
				My.Computer.Network.DownloadFile(AES_Decrypt(DirGamesDownload(42)), Application.StartupPath & "\List\Games-List-Wonderswan")
			End If
			If UrlExist(AES_Decrypt(DirGamesDownload(43))) = True Then
				My.Computer.Network.DownloadFile(AES_Decrypt(DirGamesDownload(43)), Application.StartupPath & "\List\Games-List-Wonderswan-Color")
			End If
			If UrlExist(AES_Decrypt(DirGamesDownload(44))) = True Then
				My.Computer.Network.DownloadFile(AES_Decrypt(DirGamesDownload(44)), Application.StartupPath & "\List\Games-List-Play-System-1")
			End If
			If UrlExist(AES_Decrypt(DirGamesDownload(45))) = True Then
				My.Computer.Network.DownloadFile(AES_Decrypt(DirGamesDownload(45)), Application.StartupPath & "\List\Games-List-Play-System-2")
			End If
			If UrlExist(AES_Decrypt(DirGamesDownload(46))) = True Then
				My.Computer.Network.DownloadFile(AES_Decrypt(DirGamesDownload(46)), Application.StartupPath & "\List\Games-List-Play-System-3")
			End If
			If UrlExist(AES_Decrypt(DirGamesDownload(47))) = True Then
				My.Computer.Network.DownloadFile(AES_Decrypt(DirGamesDownload(47)), Application.StartupPath & "\List\Games-List-Casio-Loopy")
			End If
			If UrlExist(AES_Decrypt(DirGamesDownload(48))) = True Then
				My.Computer.Network.DownloadFile(AES_Decrypt(DirGamesDownload(48)), Application.StartupPath & "\List\Games-List-ColecoVision")
			End If
			If UrlExist(AES_Decrypt(DirGamesDownload(49))) = True Then
				My.Computer.Network.DownloadFile(AES_Decrypt(DirGamesDownload(49)), Application.StartupPath & "\List\Games-List-Commodore64GS")
			End If
			If UrlExist(AES_Decrypt(DirGamesDownload(50))) = True Then
				My.Computer.Network.DownloadFile(AES_Decrypt(DirGamesDownload(50)), Application.StartupPath & "\List\Games-List-AmigaCD32")
			End If
			If UrlExist(AES_Decrypt(DirGamesDownload(51))) = True Then
				My.Computer.Network.DownloadFile(AES_Decrypt(DirGamesDownload(51)), Application.StartupPath & "\List\Games-List-AmigaCD")
			End If
			If UrlExist(AES_Decrypt(DirGamesDownload(52))) = True Then
				My.Computer.Network.DownloadFile(AES_Decrypt(DirGamesDownload(52)), Application.StartupPath & "\List\Games-List-Fairchild-Channel-F")
			End If
			If UrlExist(AES_Decrypt(DirGamesDownload(53))) = True Then
				My.Computer.Network.DownloadFile(AES_Decrypt(DirGamesDownload(53)), Application.StartupPath & "\List\Games-List-GP32")
			End If
			If UrlExist(AES_Decrypt(DirGamesDownload(54))) = True Then
				My.Computer.Network.DownloadFile(AES_Decrypt(DirGamesDownload(54)), Application.StartupPath & "\List\Games-List-Vectrex")
			End If
			If UrlExist(AES_Decrypt(DirGamesDownload(55))) = True Then
				My.Computer.Network.DownloadFile(AES_Decrypt(DirGamesDownload(55)), Application.StartupPath & "\List\Games-List-Magnavox-Oddyssey")
			End If
			If UrlExist(AES_Decrypt(DirGamesDownload(56))) = True Then
				My.Computer.Network.DownloadFile(AES_Decrypt(DirGamesDownload(56)), Application.StartupPath & "\List\Games-List-Magnavox-Oddyssey2")
			End If
			If UrlExist(AES_Decrypt(DirGamesDownload(57))) = True Then
				My.Computer.Network.DownloadFile(AES_Decrypt(DirGamesDownload(57)), Application.StartupPath & "\List\Games-List-Intellivision")
			End If
			If UrlExist(AES_Decrypt(DirGamesDownload(58))) = True Then
				My.Computer.Network.DownloadFile(AES_Decrypt(DirGamesDownload(58)), Application.StartupPath & "\List\Games-List-PC-Engine")
			End If
			If UrlExist(AES_Decrypt(DirGamesDownload(59))) = True Then
				My.Computer.Network.DownloadFile(AES_Decrypt(DirGamesDownload(59)), Application.StartupPath & "\List\Games-List-PC-FX")
			End If
			If UrlExist(AES_Decrypt(DirGamesDownload(60))) = True Then
				My.Computer.Network.DownloadFile(AES_Decrypt(DirGamesDownload(60)), Application.StartupPath & "\List\Games-List-N-Gage")
			End If
			If UrlExist(AES_Decrypt(DirGamesDownload(61))) = True Then
				My.Computer.Network.DownloadFile(AES_Decrypt(DirGamesDownload(61)), Application.StartupPath & "\List\Games-List-3DO")
			End If
			If UrlExist(AES_Decrypt(DirGamesDownload(62))) = True Then
				My.Computer.Network.DownloadFile(AES_Decrypt(DirGamesDownload(62)), Application.StartupPath & "\List\Games-List-Videopac")
			End If
			If UrlExist(AES_Decrypt(DirGamesDownload(63))) = True Then
				My.Computer.Network.DownloadFile(AES_Decrypt(DirGamesDownload(63)), Application.StartupPath & "\List\Games-List-Philips-CDi")
			End If
			If UrlExist(AES_Decrypt(DirGamesDownload(64))) = True Then
				My.Computer.Network.DownloadFile(AES_Decrypt(DirGamesDownload(64)), Application.StartupPath & "\List\Games-List-RCA-Studio-II")
			End If
			If UrlExist(AES_Decrypt(DirGamesDownload(65))) = True Then
				My.Computer.Network.DownloadFile(AES_Decrypt(DirGamesDownload(65)), Application.StartupPath & "\List\Games-List-V-Smile")
			End If
			If UrlExist(AES_Decrypt(DirGamesDownload(66))) = True Then
				My.Computer.Network.DownloadFile(AES_Decrypt(DirGamesDownload(66)), Application.StartupPath & "\List\Games-List-AmstradGX4000")
			End If
			NotifyIcon1.ShowBalloonTip(1000, "Σύνταξη for games    ", "Correctly updated list", ToolTipIcon.None)
		Catch
			NotifyIcon1.ShowBalloonTip(1000, "Σύνταξη for games    ", "Error Download List, please completes the list.ini file", ToolTipIcon.None)
		End Try

#End Region

		Me.Cursor = Cursors.Default
	End Sub
	Private Sub AddList()
		Dim localpath
		Dim Game As List(Of ListTwo)
		Me.Cursor = Cursors.WaitCursor
		Dim pos As Long
		Dim pos2 As Long = 1
		Dim FilaIni As Long
		Dim UFila As Long
		Dim index1 As Long
		Dim counter As Integer
		'MsgBox(pos)
		If Platform = "All" Then
			'MsgBox(ComboBox1.Items.Item(1).ToString)
			Do
#Region "platform"
				Select Case ComboBox1.Items.Item(pos2).ToString
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
					Case "Game & Watch"
						Platform = "G&W"
					Case "PlayStation"
						Platform = "PS1"
					Case "PlayStation 2"
						Platform = "PS2"
					Case "PlayStation 3"
						Platform = "PS3"
					Case "PlayStation 4"
						Platform = "PS4"
					Case "PSP"
						Platform = "PSP"
					Case "PS Vita"
						Platform = "PSVita"
					Case "PocketStation"
						Platform = "PocketStation"
					Case "Xbox"
						Platform = "Xbox"
					Case "Xbox 360"
						Platform = "Xbox360"
					Case "Xbox One"
						Platform = "XboxOne"
					Case "SG-1000"
						Platform = "SG-1000"
					Case "SC-3000"
						Platform = "SC-3000"
					Case "Sega Master System"
						Platform = "Sega-Master-System"
					Case "Sega Genesis"
						Platform = "Sega-Genesis"
					Case "Sega Mega CD"
						Platform = "Sega-Mega-CD"
					Case "Game Gear"
						Platform = "Game-Gear"
					Case "Sega Saturn"
						Platform = "Sega-Saturn"
					Case "Mega Drive 32x"
						Platform = "Mega-Drive-32x"
					Case "Sega Nomad"
						Platform = "Sega-Nomad"
					Case "Sega Model 2"
						Platform = "Sega-Model-2"
					Case "Sega Dreamcast"
						Platform = "Dreamcast"
					Case "Neo-Geo"
						Platform = "Neo-Geo"
					Case "Neo-Geo CD"
						Platform = "Neo-Geo-CD"
					Case "Pippin"
						Platform = "Pippin"
					Case "Atari 2600"
						Platform = "Atari2600"
					Case "Atari 5200"
						Platform = "Atari5200"
					Case "Atari 7800"
						Platform = "Atari7800"
					Case "Atari Jaguar"
						Platform = "Atari-Jaguar"
					Case "Playdia"
						Platform = "Playdia"
					Case "Wonderswan"
						Platform = "Wonderswan"
					Case "Wonderswan Color"
						Platform = "Wonderswan-Color"
					Case "Play System 1"
						Platform = "Play-System-1"
					Case "Play System 2"
						Platform = "Play-System-2"
					Case "Play System 3"
						Platform = "Play-System-3"
					Case "Casio Loopy"
						Platform = "Casio-Loopy"
					Case "ColecoVision"
						Platform = "ColecoVision"
					Case "Commodore 64GS"
						Platform = "Commodore64GS"
					Case "AmigaCD32"
						Platform = "AmigaCD32"
					Case "AmigaCD"
						Platform = "AmigaCD"
					Case "Fairchild Channel F"
						Platform = "Fairchild-Channel-F"
					Case "GP32"
						Platform = "GP32"
					Case "Vectrex"
						Platform = "Vectrex"
					Case "Magnavox Oddyssey"
						Platform = "Magnavox-Oddyssey"
					Case "Magnavox Oddyssey 2"
						Platform = "Magnavox-Oddyssey2"
					Case "Intellivision"
						Platform = "Intellivision"
					Case "PC Engine"
						Platform = "PC-Engine"
					Case "PC-FX"
						Platform = "PC-FX"
					Case "N-Gage"
						Platform = "N-Gage"
					Case "3DO"
						Platform = "3DO"
					Case "Videopac"
						Platform = "Videopac"
					Case "Philips CDi"
						Platform = "Philips-CDi"
					Case "RCA Studio II"
						Platform = "RCA-Studio-II"
					Case "V.Smile"
						Platform = "V-Smile"
					Case "Amstrad GX4000"
						Platform = "AmstradGX4000"
				End Select
#End Region
				Try
					localpath = File.ReadAllText(Application.StartupPath & "\List\Games-List-" & Platform)
					Game = JsonConvert.DeserializeObject(Of List(Of ListTwo))(localpath)
					FilaIni = 2 : UFila = 999999
					'MsgBox(Platform)
					'pos = 0
					'counter = 0

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
							List1.Items(counter).SubItems.Add(ComboBox1.Items.Item(pos2).ToString)
							List1.Items(counter).SubItems.Add(Game(pos).Parts)
							List1.Items(counter).SubItems.Add(Game(pos).N_Part)
							List1.Items(counter).SubItems.Add(pos)
							List1.Items(counter).SubItems.Add(Game(pos).Image)
							List1.Items(counter).SubItems.Add(Game(pos).LicenseExist)
							List1.Items(counter).SubItems.Add(Game(pos).LinkLisense)
							List1.Items(counter).SubItems.Add(Game(pos).FormatLisense)
							pos = pos + 1
							counter = counter + 1
						End If
					Next index1
				Catch
				End Try
				pos = 0
				'counter = 0
				pos2 = pos2 + 1
			Loop Until pos2 = ComboBox1.Items.Count

		Else
			Try
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
						List1.Items(counter).SubItems.Add(ComboBox1.Text)
						List1.Items(counter).SubItems.Add(Game(pos).Parts)
						List1.Items(counter).SubItems.Add(Game(pos).N_Part)
						List1.Items(counter).SubItems.Add(pos)
						List1.Items(counter).SubItems.Add(Game(pos).Image)
						List1.Items(counter).SubItems.Add(Game(pos).LicenseExist)
						List1.Items(counter).SubItems.Add(Game(pos).LinkLisense)
						List1.Items(counter).SubItems.Add(Game(pos).FormatLisense)
						pos = pos + 1
						counter = counter + 1
					End If
				Next index1
			Catch
			End Try
		End If
		'Catch
		'MsgBox("error")
		'End Try

		If List1.Items.Count = 0 Then
		Else
			Try
				List1.ListViewItemSorter = New ListViewItemComparer(1, True)
				Name_Game_Label.Text = "Name Game: " & List1.Items.Item(0).SubItems(1).Text
				Type_label.Text = "Type: " & List1.Items.Item(0).SubItems(2).Text
				Format_label.Text = "Format: " & List1.Items.Item(0).SubItems(6).Text
				User_label.Text = "User: " & List1.Items.Item(0).SubItems(4).Text
				Version_label.Text = "Version: " & List1.Items.Item(0).SubItems(5).Text
				Region_label.Text = "Region: " & List1.Items.Item(0).SubItems(3).Text
			Catch
			End Try
		End If

		Me.Cursor = Cursors.Default
		Try
			List1.Items.Item(0).Selected = True
		Catch
		End Try
	End Sub
	Private Sub List1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles List1.SelectedIndexChanged

		Dim Lisense As Boolean = False
		If StartBol = False Then
			Try
				ini.Load(Application.StartupPath & "\Lang\" & Languaje_Program & ".ini")
				Name_Game_Label.Text = ini.GetKeyValue("LANGUAGE", "Name_Game") & ": " & List1.Items.Item(List1.FocusedItem.Index).SubItems(1).Text
				Type_label.Text = ini.GetKeyValue("LANGUAGE", "Type") & ": " & List1.Items.Item(List1.FocusedItem.Index).SubItems(3).Text
				Format_label.Text = ini.GetKeyValue("LANGUAGE", "Format") & ": " & List1.Items.Item(List1.FocusedItem.Index).SubItems(6).Text
				User_label.Text = ini.GetKeyValue("LANGUAGE", "User") & ": " & List1.Items.Item(List1.FocusedItem.Index).SubItems(4).Text
				Version_label.Text = ini.GetKeyValue("LANGUAGE", "Version") & ": " & List1.Items.Item(List1.FocusedItem.Index).SubItems(5).Text
				Region_label.Text = ini.GetKeyValue("LANGUAGE", "Region") & ": " & List1.Items.Item(List1.FocusedItem.Index).SubItems(2).Text
				Link_Game = AES_Decrypt(List1.Items.Item(List1.FocusedItem.Index).SubItems(7).Text)
				Platform_Game = List1.Items.Item(List1.FocusedItem.Index).SubItems(8).Text
				Version_Game = List1.Items.Item(List1.FocusedItem.Index).SubItems(5).Text
				format_Game = List1.Items.Item(List1.FocusedItem.Index).SubItems(6).Text
				Name_Game = List1.Items.Item(List1.FocusedItem.Index).SubItems(1).Text
				Region_Game = List1.Items.Item(List1.FocusedItem.Index).SubItems(2).Text
				Game_Part = List1.Items.Item(List1.FocusedItem.Index).SubItems(9).Text
				Game_Num = List1.Items.Item(List1.FocusedItem.Index).SubItems(10).Text
				Lisense = List1.Items.Item(List1.FocusedItem.Index).SubItems(13).Text
				Link_License = AES_Decrypt(List1.Items.Item(List1.FocusedItem.Index).SubItems(14).Text)
				format_License = List1.Items.Item(List1.FocusedItem.Index).SubItems(15).Text
				If Lisense = False Then
					Button2.Visible = False
				Else
					Button2.Visible = True
				End If
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
						Try
							PictureBox3.Load(List1.Items.Item(List1.FocusedItem.Index).SubItems(12).Text)
						Catch
						End Try
						'	MsgBox("1")
					End If
				End If
			Catch ex As Exception
				'MsgBox("Error: " & ex.Message, MsgBoxStyle.OkOnly)
			End Try
		Else
			StartBol = False
			Try
				ini.Load(Application.StartupPath & "\Lang\" & Languaje_Program & ".ini")
				Name_Game_Label.Text = ini.GetKeyValue("LANGUAGE", "Name_Game") & ": " & List1.Items.Item(0).SubItems(1).Text
				Type_label.Text = ini.GetKeyValue("LANGUAGE", "Type") & ": " & List1.Items.Item(0).SubItems(3).Text
				Format_label.Text = ini.GetKeyValue("LANGUAGE", "Format") & ": " & List1.Items.Item(0).SubItems(6).Text
				User_label.Text = ini.GetKeyValue("LANGUAGE", "User") & ": " & List1.Items.Item(0).SubItems(4).Text
				Version_label.Text = ini.GetKeyValue("LANGUAGE", "Version") & ": " & List1.Items.Item(0).SubItems(5).Text
				Region_label.Text = ini.GetKeyValue("LANGUAGE", "Region") & ": " & List1.Items.Item(0).SubItems(2).Text
				Link_Game = AES_Decrypt(List1.Items.Item(0).SubItems(7).Text)
				Platform_Game = List1.Items.Item(0).SubItems(8).Text
				Version_Game = List1.Items.Item(0).SubItems(5).Text
				format_Game = List1.Items.Item(0).SubItems(6).Text
				Name_Game = List1.Items.Item(0).SubItems(1).Text
				Region_Game = List1.Items.Item(0).SubItems(2).Text
				Game_Part = List1.Items.Item(0).SubItems(9).Text
				Game_Num = List1.Items.Item(0).SubItems(10).Text
				Lisense = List1.Items.Item(0).SubItems(13).Text
				Link_License = AES_Decrypt(List1.Items.Item(0).SubItems(14).Text)
				format_License = List1.Items.Item(0).SubItems(15).Text
				If Lisense = False Then
					Button2.Visible = False
				Else
					Button2.Visible = True
				End If
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
					If List1.Items.Item(0).SubItems(12).Text = "" Then
					Else
						Try
							PictureBox3.Load(List1.Items.Item(0).SubItems(12).Text)
						Catch
						End Try
						'	MsgBox("1")
					End If
				End If
			Catch ex As Exception
				'MsgBox("Error: " & ex.Message, MsgBoxStyle.OkOnly)
			End Try
		End If
	End Sub
	Private Sub ListView99_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView99.SelectedIndexChanged

		Dim Lisense As Boolean = False
		If StartBol = False Then
			Try
				ini.Load(Application.StartupPath & "\Lang\" & Languaje_Program & ".ini")
				Name_Game_Label.Text = ini.GetKeyValue("LANGUAGE", "Name_Game") & ": " & ListView99.Items.Item(ListView99.FocusedItem.Index).SubItems(1).Text
				Type_label.Text = ini.GetKeyValue("LANGUAGE", "Type") & ": " & ListView99.Items.Item(ListView99.FocusedItem.Index).SubItems(3).Text
				Format_label.Text = ini.GetKeyValue("LANGUAGE", "Format") & ": " & ListView99.Items.Item(ListView99.FocusedItem.Index).SubItems(6).Text
				User_label.Text = ini.GetKeyValue("LANGUAGE", "User") & ": " & ListView99.Items.Item(ListView99.FocusedItem.Index).SubItems(4).Text
				Version_label.Text = ini.GetKeyValue("LANGUAGE", "Version") & ": " & ListView99.Items.Item(ListView99.FocusedItem.Index).SubItems(5).Text
				Region_label.Text = ini.GetKeyValue("LANGUAGE", "Region") & ": " & ListView99.Items.Item(ListView99.FocusedItem.Index).SubItems(2).Text
				Link_Game = AES_Decrypt(ListView99.Items.Item(ListView99.FocusedItem.Index).SubItems(7).Text)
				Platform_Game = ListView99.Items.Item(ListView99.FocusedItem.Index).SubItems(8).Text
				Version_Game = ListView99.Items.Item(ListView99.FocusedItem.Index).SubItems(5).Text
				format_Game = ListView99.Items.Item(ListView99.FocusedItem.Index).SubItems(6).Text
				Name_Game = ListView99.Items.Item(ListView99.FocusedItem.Index).SubItems(1).Text
				Region_Game = ListView99.Items.Item(ListView99.FocusedItem.Index).SubItems(2).Text
				Game_Part = ListView99.Items.Item(ListView99.FocusedItem.Index).SubItems(9).Text
				Game_Num = ListView99.Items.Item(ListView99.FocusedItem.Index).SubItems(10).Text
				Lisense = ListView99.Items.Item(ListView99.FocusedItem.Index).SubItems(13).Text
				Link_License = AES_Decrypt(ListView99.Items.Item(ListView99.FocusedItem.Index).SubItems(14).Text)
				format_License = ListView99.Items.Item(ListView99.FocusedItem.Index).SubItems(15).Text
				If Lisense = False Then
					Button2.Visible = False
				Else
					Button2.Visible = True
				End If
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
					If ListView99.Items.Item(ListView99.FocusedItem.Index).SubItems(12).Text = "" Then
					Else
						Try
							PictureBox3.Load(ListView99.Items.Item(ListView99.FocusedItem.Index).SubItems(12).Text)
						Catch
						End Try
						'	MsgBox("1")
					End If
				End If
			Catch ex As Exception
				'MsgBox("Error: " & ex.Message, MsgBoxStyle.OkOnly)
			End Try
		Else
			StartBol = False
			Try
				ini.Load(Application.StartupPath & "\Lang\" & Languaje_Program & ".ini")
				Name_Game_Label.Text = ini.GetKeyValue("LANGUAGE", "Name_Game") & ": " & ListView99.Items.Item(0).SubItems(1).Text
				Type_label.Text = ini.GetKeyValue("LANGUAGE", "Type") & ": " & ListView99.Items.Item(0).SubItems(3).Text
				Format_label.Text = ini.GetKeyValue("LANGUAGE", "Format") & ": " & ListView99.Items.Item(0).SubItems(6).Text
				User_label.Text = ini.GetKeyValue("LANGUAGE", "User") & ": " & ListView99.Items.Item(0).SubItems(4).Text
				Version_label.Text = ini.GetKeyValue("LANGUAGE", "Version") & ": " & ListView99.Items.Item(0).SubItems(5).Text
				Region_label.Text = ini.GetKeyValue("LANGUAGE", "Region") & ": " & ListView99.Items.Item(0).SubItems(2).Text
				Link_Game = AES_Decrypt(ListView99.Items.Item(0).SubItems(7).Text)
				Platform_Game = ListView99.Items.Item(0).SubItems(8).Text
				Version_Game = ListView99.Items.Item(0).SubItems(5).Text
				format_Game = ListView99.Items.Item(0).SubItems(6).Text
				Name_Game = ListView99.Items.Item(0).SubItems(1).Text
				Region_Game = ListView99.Items.Item(0).SubItems(2).Text
				Game_Part = ListView99.Items.Item(0).SubItems(9).Text
				Game_Num = ListView99.Items.Item(0).SubItems(10).Text
				Lisense = ListView99.Items.Item(0).SubItems(13).Text
				Link_License = AES_Decrypt(ListView99.Items.Item(0).SubItems(14).Text)
				format_License = ListView99.Items.Item(0).SubItems(15).Text
				If Lisense = False Then
					Button2.Visible = False
				Else
					Button2.Visible = True
				End If
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
					If ListView99.Items.Item(0).SubItems(12).Text = "" Then
					Else
						Try
							PictureBox3.Load(ListView99.Items.Item(0).SubItems(12).Text)
						Catch
						End Try
						'	MsgBox("1")
					End If
				End If
			Catch ex As Exception
				'MsgBox("Error: " & ex.Message, MsgBoxStyle.OkOnly)
			End Try
		End If
	End Sub
	Private Sub Button_Download_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Download.Click

		ini.Load(Application.StartupPath & "\Lang\" & Languaje_Program & ".ini")
		If Dir_Save_Games = "Default" Then
			saved = Application.StartupPath
		Else
			saved = Dir_Save_Games

			If (Directory.Exists(Dir_Save_Games)) = False Then
				MsgBox(ini.GetKeyValue("LANGUAGE", "The_selected_dirrectory_does_not_exist_please_select_another_dirrectory"))
				Exit Sub
			End If
		End If


		myWebClient = New Net.WebClient
		Dim i As Integer = 0
		Dim Listita As List(Of ListTwo)
		Dim Plataforma As String
		Select Case ComboBox1.Text
			Case "All"
				Plataforma = "All"
			Case "Wii"
				Plataforma = "Wii"
			Case "Wii U"
				Plataforma = "WiiU"
			Case "Nintendo Swich"
				Plataforma = "NSwich"
			Case "Nintendo 64"
				Plataforma = "N64"
			Case "GameCube"
				Plataforma = "GameCube"
			Case "Virtual Boy"
				Plataforma = "VirtualBoy"
			Case "Game Boy Advance"
				Plataforma = "GameBoyAdvance"
			Case "Snes"
				Plataforma = "SNES"
			Case "Nes"
				Plataforma = "NES"
			Case "NDS"
				Plataforma = "NDS"
			Case "3DS"
				Plataforma = "3DS"
			Case "Game Boy"
				Plataforma = "GameBoy"
			Case "Game & Watch"
				Plataforma = "G&W"
			Case "PlayStation"
				Plataforma = "PS1"
			Case "PlayStation 2"
				Plataforma = "PS2"
			Case "PlayStation 3"
				Plataforma = "PS3"
			Case "PlayStation 4"
				Plataforma = "PS4"
			Case "PSP"
				Plataforma = "PSP"
			Case "PS Vita"
				Plataforma = "PSVita"
			Case "PocketStation"
				Plataforma = "PocketStation"
			Case "Xbox"
				Plataforma = "Xbox"
			Case "Xbox 360"
				Plataforma = "Xbox360"
			Case "Xbox One"
				Plataforma = "XboxOne"
			Case "SG-1000"
				Plataforma = "SG-1000"
			Case "SC-3000"
				Plataforma = "SC-3000"
			Case "Sega Master System"
				Plataforma = "Sega-Master-System"
			Case "Sega Genesis"
				Plataforma = "Sega-Genesis"
			Case "Sega Mega CD"
				Plataforma = "Sega-Mega-CD"
			Case "Game Gear"
				Plataforma = "Game-Gear"
			Case "Sega Saturn"
				Plataforma = "Sega-Saturn"
			Case "Mega Drive 32x"
				Plataforma = "Mega-Drive-32x"
			Case "Sega Nomad"
				Plataforma = "Sega-Nomad"
			Case "Sega Model 2"
				Plataforma = "Sega-Model-2"
			Case "Sega Dreamcast"
				Plataforma = "Dreamcast"
			Case "Neo-Geo"
				Plataforma = "Neo-Geo"
			Case "Neo-Geo CD"
				Plataforma = "Neo-Geo-CD"
			Case "Pippin"
				Plataforma = "Pippin"
			Case "Atari 2600"
				Plataforma = "Atari2600"
			Case "Atari 5200"
				Plataforma = "Atari5200"
			Case "Atari 7800"
				Plataforma = "Atari7800"
			Case "Atari Jaguar"
				Plataforma = "Atari-Jaguar"
			Case "Playdia"
				Plataforma = "Playdia"
			Case "Wonderswan"
				Plataforma = "Wonderswan"
			Case "Wonderswan Color"
				Plataforma = "Wonderswan-Color"
			Case "Play System 1"
				Plataforma = "Play-System-1"
			Case "Play System 2"
				Plataforma = "Play-System-2"
			Case "Play System 3"
				Plataforma = "Play-System-3"
			Case "Casio Loopy"
				Plataforma = "Casio-Loopy"
			Case "ColecoVision"
				Plataforma = "ColecoVision"
			Case "Commodore 64GS"
				Plataforma = "Commodore64GS"
			Case "AmigaCD32"
				Plataforma = "AmigaCD32"
			Case "AmigaCD"
				Plataforma = "AmigaCD"
			Case "Fairchild Channel F"
				Plataforma = "Fairchild-Channel-F"
			Case "GP32"
				Plataforma = "GP32"
			Case "Vectrex"
				Plataforma = "Vectrex"
			Case "Magnavox Oddyssey"
				Plataforma = "Magnavox-Oddyssey"
			Case "Magnavox Oddyssey 2"
				Plataforma = "Magnavox-Oddyssey2"
			Case "Intellivision"
				Plataforma = "Intellivision"
			Case "PC Engine"
				Plataforma = "PC-Engine"
			Case "PC-FX"
				Plataforma = "PC-FX"
			Case "N-Gage"
				Plataforma = "N-Gage"
			Case "3DO"
				Plataforma = "3DO"
			Case "Videopac"
				Plataforma = "Videopac"
			Case "Philips CDi"
				Plataforma = "Philips-CDi"
			Case "RCA Studio II"
				Plataforma = "RCA-Studio-II"
			Case "V.Smile"
				Plataforma = "V-Smile"
			Case "Amstrad GX4000"
				Plataforma = "AmstradGX4000"
		End Select
#Disable Warning BC42104 ' Se usa la variable antes de que se le haya asignado un valor
		'MsgBox()
		Dim localpath As String
		If Plataforma = "All" Then
			Try
				Select Case List1.Items.Item(0).SubItems(8).Text
					Case "All"
						Plataforma = "All"
					Case "Wii"
						Plataforma = "Wii"
					Case "Wii U"
						Plataforma = "WiiU"
					Case "Nintendo Swich"
						Plataforma = "NSwich"
					Case "Nintendo 64"
						Plataforma = "N64"
					Case "GameCube"
						Plataforma = "GameCube"
					Case "Virtual Boy"
						Plataforma = "VirtualBoy"
					Case "Game Boy Advance"
						Plataforma = "GameBoyAdvance"
					Case "Snes"
						Plataforma = "SNES"
					Case "Nes"
						Plataforma = "NES"
					Case "NDS"
						Plataforma = "NDS"
					Case "3DS"
						Plataforma = "3DS"
					Case "Game Boy"
						Plataforma = "GameBoy"
					Case "Game & Watch"
						Plataforma = "G&W"
					Case "PlayStation"
						Plataforma = "PS1"
					Case "PlayStation 2"
						Plataforma = "PS2"
					Case "PlayStation 3"
						Plataforma = "PS3"
					Case "PlayStation 4"
						Plataforma = "PS4"
					Case "PSP"
						Plataforma = "PSP"
					Case "PS Vita"
						Plataforma = "PSVita"
					Case "PocketStation"
						Plataforma = "PocketStation"
					Case "Xbox"
						Plataforma = "Xbox"
					Case "Xbox 360"
						Plataforma = "Xbox360"
					Case "Xbox One"
						Plataforma = "XboxOne"
					Case "SG-1000"
						Plataforma = "SG-1000"
					Case "SC-3000"
						Plataforma = "SC-3000"
					Case "Sega Master System"
						Plataforma = "Sega-Master-System"
					Case "Sega Genesis"
						Plataforma = "Sega-Genesis"
					Case "Sega Mega CD"
						Plataforma = "Sega-Mega-CD"
					Case "Game Gear"
						Plataforma = "Game-Gear"
					Case "Sega Saturn"
						Plataforma = "Sega-Saturn"
					Case "Mega Drive 32x"
						Plataforma = "Mega-Drive-32x"
					Case "Sega Nomad"
						Plataforma = "Sega-Nomad"
					Case "Sega Model 2"
						Plataforma = "Sega-Model-2"
					Case "Sega Dreamcast"
						Plataforma = "Dreamcast"
					Case "Neo-Geo"
						Plataforma = "Neo-Geo"
					Case "Neo-Geo CD"
						Plataforma = "Neo-Geo-CD"
					Case "Pippin"
						Plataforma = "Pippin"
					Case "Atari 2600"
						Plataforma = "Atari2600"
					Case "Atari 5200"
						Plataforma = "Atari5200"
					Case "Atari 7800"
						Plataforma = "Atari7800"
					Case "Atari Jaguar"
						Plataforma = "Atari-Jaguar"
					Case "Playdia"
						Plataforma = "Playdia"
					Case "Wonderswan"
						Plataforma = "Wonderswan"
					Case "Wonderswan Color"
						Plataforma = "Wonderswan-Color"
					Case "Play System 1"
						Plataforma = "Play-System-1"
					Case "Play System 2"
						Plataforma = "Play-System-2"
					Case "Play System 3"
						Plataforma = "Play-System-3"
					Case "Casio Loopy"
						Plataforma = "Casio-Loopy"
					Case "ColecoVision"
						Plataforma = "ColecoVision"
					Case "Commodore 64GS"
						Plataforma = "Commodore64GS"
					Case "AmigaCD32"
						Plataforma = "AmigaCD32"
					Case "AmigaCD"
						Plataforma = "AmigaCD"
					Case "Fairchild Channel F"
						Plataforma = "Fairchild-Channel-F"
					Case "GP32"
						Plataforma = "GP32"
					Case "Vectrex"
						Plataforma = "Vectrex"
					Case "Magnavox Oddyssey"
						Plataforma = "Magnavox-Oddyssey"
					Case "Magnavox Oddyssey 2"
						Plataforma = "Magnavox-Oddyssey2"
					Case "Intellivision"
						Plataforma = "Intellivision"
					Case "PC Engine"
						Plataforma = "PC-Engine"
					Case "PC-FX"
						Plataforma = "PC-FX"
					Case "N-Gage"
						Plataforma = "N-Gage"
					Case "3DO"
						Plataforma = "3DO"
					Case "Videopac"
						Plataforma = "Videopac"
					Case "Philips CDi"
						Plataforma = "Philips-CDi"
					Case "RCA Studio II"
						Plataforma = "RCA-Studio-II"
					Case "V.Smile"
						Plataforma = "V-Smile"
					Case "Amstrad GX4000"
						Plataforma = "AmstradGX4000"
				End Select
			Catch
			End Try
		Else

		End If
		Try
			localpath = File.ReadAllText(Application.StartupPath & "\List\Games-List-" & Plataforma)

			Listita = JsonConvert.DeserializeObject(Of List(Of ListTwo))(localpath)

			myFile = saved & "\Roms\[" & Platform_Game & "][" & Version_Game & "][" & Region_Game & "]" & Name_Game & "." & format_Game

#Enable Warning BC42104 ' Se usa la variable antes de que se le haya asignado un valor
			If Game_Part = False Then
				'Link_Game = ""
				'myWebClient.DownloadFileAsync(New Uri(Link_Game), myFile)
				ListViewEx.StartDownload(Link_Game, myFile)
				NotifyIcon1.ContextMenuStrip = ContextMenuStrip2
				NotifyIcon1.ShowBalloonTip(1000, ini.GetKeyValue("LANGUAGE", "Download_Start") & ":    ", myFile, ToolTipIcon.None)
			Else
				If DownParts.Text = "ALL" Then
					For i = 1 To Game_Num
						'myWebClient.DownloadFileAsync(New Uri(Listita(Game_Num).Encrypt(i)), "[Part:" & i & "]" & myFile)
						ListViewEx.StartDownload(Listita(Game_Num).Encrypt(i), "[Part:" & i & "]" & myFile)
						NotifyIcon1.ContextMenuStrip = ContextMenuStrip2
						NotifyIcon1.ShowBalloonTip(1000, ini.GetKeyValue("LANGUAGE", "Download_Start") & ":    ", myFile, ToolTipIcon.None)
					Next
					ListViewEx.StartDownload(Listita(Game_Num).Encrypt(DownParts.Text), "[Part:" & DownParts.Text & "]" & myFile)
					NotifyIcon1.ContextMenuStrip = ContextMenuStrip2
					NotifyIcon1.ShowBalloonTip(1000, ini.GetKeyValue("LANGUAGE", "Download_Start") & ":    ", myFile, ToolTipIcon.None)
				Else

				End If
			End If
		Catch
		End Try
	End Sub
	Private Sub Form1_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
		Dim wClient As DownloadFileAsyncExtended
		NotifyIcon1.Visible = False
		For i As Integer = 0 To ListViewEx.Items.Count - 1
			'// Check if the Tag isn't Nothing, because else the download has already
			'// finished or an error occurred, so it can't be cancelled.
			If ListViewEx.Items(i).Tag IsNot Nothing Then
				'// Get the DownloadFileAsyncExtended class instance from the ListViewItem Tag.
				wClient = DirectCast(ListViewEx.Items(i).Tag, DownloadFileAsyncExtended)
				'// Cancel the download if it's still busy.
				wClient.CancelAsync()
			End If
		Next
	End Sub
	Private Sub Upload_Add_item_Click(sender As Object, e As EventArgs) Handles Upload_Add_item.Click


		Select Case ComboBox4.Text
			Case "Wii"
				platfom2 = "Wii"
			Case "Wii U"
				platfom2 = "WiiU"
			Case "Nintendo Swich"
				platfom2 = "NSwich"
			Case "Nintendo 64"
				platfom2 = "N64"
			Case "GameCube"
				platfom2 = "GameCube"
			Case "Virtual Boy"
				platfom2 = "VirtualBoy"
			Case "Game Boy Advance"
				platfom2 = "GameBoyAdvance"
			Case "Snes"
				platfom2 = "SNES"
			Case "Nes"
				platfom2 = "NES"
			Case "NDS"
				platfom2 = "NDS"
			Case "3DS"
				platfom2 = "3DS"
			Case "Game Boy"
				platfom2 = "GameBoy"
			Case "Game & Watch"
				platfom2 = "G&W"
			Case "PlayStation"
				platfom2 = "PS1"
			Case "PlayStation 2"
				platfom2 = "PS2"
			Case "PlayStation 3"
				platfom2 = "PS3"
			Case "PlayStation 4"
				platfom2 = "PS4"
			Case "PSP"
				platfom2 = "PSP"
			Case "PS Vita"
				platfom2 = "PSVita"
			Case "PocketStation"
				platfom2 = "PocketStation"
			Case "Xbox"
				platfom2 = "Xbox"
			Case "Xbox 360"
				platfom2 = "Xbox360"
			Case "Xbox One"
				platfom2 = "XboxOne"
			Case "SG-1000"
				platfom2 = "SG-1000"
			Case "SC-3000"
				platfom2 = "SC-3000"
			Case "Sega Master System"
				platfom2 = "Sega-Master-System"
			Case "Sega Genesis"
				platfom2 = "Sega-Genesis"
			Case "Sega Mega CD"
				platfom2 = "Sega-Mega-CD"
			Case "Game Gear"
				platfom2 = "Game-Gear"
			Case "Sega Saturn"
				platfom2 = "Sega-Saturn"
			Case "Mega Drive 32x"
				platfom2 = "Mega-Drive-32x"
			Case "Sega Nomad"
				platfom2 = "Sega-Nomad"
			Case "Sega Model 2"
				platfom2 = "Sega-Model-2"
			Case "Sega Dreamcast"
				platfom2 = "Dreamcast"
			Case "Neo-Geo"
				platfom2 = "Neo-Geo"
			Case "Neo-Geo CD"
				platfom2 = "Neo-Geo-CD"
			Case "Pippin"
				platfom2 = "Pippin"
			Case "Atari 2600"
				platfom2 = "Atari2600"
			Case "Atari 5200"
				platfom2 = "Atari5200"
			Case "Atari 7800"
				platfom2 = "Atari7800"
			Case "Atari Jaguar"
				platfom2 = "Atari-Jaguar"
			Case "Playdia"
				platfom2 = "Playdia"
			Case "Wonderswan"
				platfom2 = "Wonderswan"
			Case "Wonderswan Color"
				platfom2 = "Wonderswan-Color"
			Case "Play System 1"
				platfom2 = "Play-System-1"
			Case "Play System 2"
				platfom2 = "Play-System-2"
			Case "Play System 3"
				platfom2 = "Play-System-3"
			Case "Casio Loopy"
				platfom2 = "Casio-Loopy"
			Case "ColecoVision"
				platfom2 = "ColecoVision"
			Case "Commodore 64GS"
				platfom2 = "Commodore64GS"
			Case "AmigaCD32"
				platfom2 = "AmigaCD32"
			Case "AmigaCD"
				platfom2 = "AmigaCD"
			Case "Fairchild Channel F"
				platfom2 = "Fairchild-Channel-F"
			Case "GP32"
				platfom2 = "GP32"
			Case "Vectrex"
				platfom2 = "Vectrex"
			Case "Magnavox Oddyssey"
				platfom2 = "Magnavox-Oddyssey"
			Case "Magnavox Oddyssey 2"
				platfom2 = "Magnavox-Oddyssey2"
			Case "Intellivision"
				platfom2 = "Intellivision"
			Case "PC Engine"
				platfom2 = "PC-Engine"
			Case "PC-FX"
				platfom2 = "PC-FX"
			Case "N-Gage"
				platfom2 = "N-Gage"
			Case "3DO"
				platfom2 = "3DO"
			Case "Videopac"
				platfom2 = "Videopac"
			Case "Philips CDi"
				platfom2 = "Philips-CDi"
			Case "RCA Studio II"
				platfom2 = "RCA-Studio-II"
			Case "V.Smile"
				platfom2 = "V-Smile"
			Case "Amstrad GX4000"
				platfom2 = "AmstradGX4000"
		End Select
		If TextBox3.Text = "Name Game" Then
		Else
			If TextBox7.Text = "Url Image" Then
			Else
				If TextBox7.Text = "" Then
				Else
					If UrlExist(TextBox7.Text) = True Then
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
													If TextBox2.Text = "Link Game(Direct Download)" Then
													Else
														If TextBox2.Text = "" Then
														Else
															If GameID_Checkbox.CheckState = False Then
																If CheckBox3.CheckState = False Then
																	CopyClipBoard(ComboBox4.Text, "0", ComboBox2.Text,
																					 TextBox3.Text, ComboBox3.Text,
																					 TextBox4.Text, TextBox5.Text, TextBox6.Text, TextBox7.Text, Parts,
																					 TextBox2.Text, "1", License_Bol, "", "")
																Else
																	If LinkLicense_Text.Text = "" Then
																	Else
																		If LinkLicense_Text.Text = "Link License" Then
																		Else
																			If TextBox8.Text = "" Then
																			Else
																				If TextBox8.Text = "Format License" Then
																				Else
																					CopyClipBoard(ComboBox4.Text, "0", ComboBox2.Text,
																						 TextBox3.Text, ComboBox3.Text,
																						 TextBox4.Text, TextBox5.Text, TextBox6.Text, TextBox7.Text, Parts,
																						 TextBox2.Text, "1", License_Bol, LinkLicense_Text.Text, TextBox8.Text)
																				End If
																			End If
																		End If
																	End If
																End If
															Else
																If ID_Game.Text = "ID Game" Then
																Else
																	If ID_Game.Text = "" Then
																	Else
																		If CheckBox3.CheckState = False Then
																			CopyClipBoard(ComboBox4.Text, ID_Game.Text, ComboBox2.Text,
																			 TextBox3.Text, ComboBox3.Text,
																			 TextBox4.Text, TextBox5.Text, TextBox6.Text, TextBox7.Text, Parts,
																			 TextBox2.Text, "1", License_Bol, "", "")
																		Else
																			If LinkLicense_Text.Text = "" Then
																			Else
																				If LinkLicense_Text.Text = "Link License" Then
																				Else
																					If TextBox8.Text = "" Then
																					Else
																						If TextBox8.Text = "Format License" Then
																						Else
																							CopyClipBoard(ComboBox4.Text, ID_Game.Text, ComboBox2.Text,
																								 TextBox3.Text, ComboBox3.Text,
																								 TextBox4.Text, TextBox5.Text, TextBox6.Text, TextBox7.Text, Parts,
																								 TextBox2.Text, "1", License_Bol, LinkLicense_Text.Text, TextBox8.Text)
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
					End If
				End If
			End If
		End If
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
		Public LicenseExist As Boolean
		Public LinkLisense As String
		Public FormatLisense As String
	End Class
	Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
		'If TextBox1.Text.Length = 2 Then
		If Search_On = True Then
			Dim check As Integer = FindItem(List1, TextBox1.Text)

			If TextBox1.Text.Length <= 2 Then
				ListView99.Visible = False
				counter4 = 0
				ListView99.Items.Clear()
			Else
				ListView99.Visible = True
				ListView99.Items.Clear()
				counter4 = 0

				For i As Integer = 0 To List1.Items.Count - 1
					If Trim(List1.Items(i).Text).Contains(Trim(TextBox1.Text)) Then
						'MsgBox(i)
						ListView99.Items.Add(List1.Items.Item(i).SubItems(0).Text)
						ListView99.Items(counter4).SubItems.Add(List1.Items.Item(i).SubItems(1).Text)
						ListView99.Items(counter4).SubItems.Add(List1.Items.Item(i).SubItems(2).Text)
						ListView99.Items(counter4).SubItems.Add(List1.Items.Item(i).SubItems(3).Text)
						ListView99.Items(counter4).SubItems.Add(List1.Items.Item(i).SubItems(4).Text)
						ListView99.Items(counter4).SubItems.Add(List1.Items.Item(i).SubItems(5).Text)
						ListView99.Items(counter4).SubItems.Add(List1.Items.Item(i).SubItems(6).Text)
						ListView99.Items(counter4).SubItems.Add(List1.Items.Item(i).SubItems(7).Text)
						ListView99.Items(counter4).SubItems.Add(List1.Items.Item(i).SubItems(8).Text)
						ListView99.Items(counter4).SubItems.Add(List1.Items.Item(i).SubItems(9).Text)
						ListView99.Items(counter4).SubItems.Add(List1.Items.Item(i).SubItems(10).Text)
						ListView99.Items(counter4).SubItems.Add(List1.Items.Item(i).SubItems(11).Text)
						ListView99.Items(counter4).SubItems.Add(List1.Items.Item(i).SubItems(12).Text)
						ListView99.Items(counter4).SubItems.Add(List1.Items.Item(i).SubItems(13).Text)
						ListView99.Items(counter4).SubItems.Add(List1.Items.Item(i).SubItems(14).Text)
						ListView99.Items(counter4).SubItems.Add(List1.Items.Item(i).SubItems(15).Text)
						counter4 = counter4 + 1
					End If
					For subitem As Integer = 0 To List1.Items(i).SubItems.Count - 1
						If Trim(List1.Items(i).SubItems(subitem).Text).Contains(Trim(TextBox1.Text)) Then
							ListView99.Items.Add(List1.Items.Item(i).SubItems(0).Text)
							ListView99.Items(counter4).SubItems.Add(List1.Items.Item(i).SubItems(1).Text)
							ListView99.Items(counter4).SubItems.Add(List1.Items.Item(i).SubItems(2).Text)
							ListView99.Items(counter4).SubItems.Add(List1.Items.Item(i).SubItems(3).Text)
							ListView99.Items(counter4).SubItems.Add(List1.Items.Item(i).SubItems(4).Text)
							ListView99.Items(counter4).SubItems.Add(List1.Items.Item(i).SubItems(5).Text)
							ListView99.Items(counter4).SubItems.Add(List1.Items.Item(i).SubItems(6).Text)
							ListView99.Items(counter4).SubItems.Add(List1.Items.Item(i).SubItems(7).Text)
							ListView99.Items(counter4).SubItems.Add(List1.Items.Item(i).SubItems(8).Text)
							ListView99.Items(counter4).SubItems.Add(List1.Items.Item(i).SubItems(9).Text)
							ListView99.Items(counter4).SubItems.Add(List1.Items.Item(i).SubItems(10).Text)
							ListView99.Items(counter4).SubItems.Add(List1.Items.Item(i).SubItems(11).Text)
							ListView99.Items(counter4).SubItems.Add(List1.Items.Item(i).SubItems(12).Text)
							ListView99.Items(counter4).SubItems.Add(List1.Items.Item(i).SubItems(13).Text)
							ListView99.Items(counter4).SubItems.Add(List1.Items.Item(i).SubItems(14).Text)
							ListView99.Items(counter4).SubItems.Add(List1.Items.Item(i).SubItems(15).Text)
							counter4 = counter4 + 1
							Exit For
						End If
					Next

				Next

			End If
			Try
				ListView99.ListViewItemSorter = New ListViewItemComparer2(1, True)
				ListView99.Items.Item(0).Selected = True
				StartBol = True
			Catch
			End Try
		End If
		'Else
		'ListView99.Visible = False
		'counter4 = 0
		'End If
	End Sub
	Private Sub TextBox1_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyUp
		If e.KeyCode = 8 Then
			Search_On = True
			If TextBox1.Text = "" Then
			Else
				Dim check As Integer = FindItem(List1, TextBox1.Text)

				If TextBox1.Text.Length <= 2 Then
					ListView99.Visible = False
					counter4 = 0
					ListView99.Items.Clear()
				Else
					ListView99.Visible = True
					ListView99.Items.Clear()
					counter4 = 0

					For i As Integer = 0 To List1.Items.Count - 1
						If Trim(List1.Items(i).Text).Contains(Trim(TextBox1.Text)) Then
							'MsgBox(i)
							ListView99.Items.Add(List1.Items.Item(i).SubItems(0).Text)
							ListView99.Items(counter4).SubItems.Add(List1.Items.Item(i).SubItems(1).Text)
							ListView99.Items(counter4).SubItems.Add(List1.Items.Item(i).SubItems(2).Text)
							ListView99.Items(counter4).SubItems.Add(List1.Items.Item(i).SubItems(3).Text)
							ListView99.Items(counter4).SubItems.Add(List1.Items.Item(i).SubItems(4).Text)
							ListView99.Items(counter4).SubItems.Add(List1.Items.Item(i).SubItems(5).Text)
							ListView99.Items(counter4).SubItems.Add(List1.Items.Item(i).SubItems(6).Text)
							ListView99.Items(counter4).SubItems.Add(List1.Items.Item(i).SubItems(7).Text)
							ListView99.Items(counter4).SubItems.Add(List1.Items.Item(i).SubItems(8).Text)
							ListView99.Items(counter4).SubItems.Add(List1.Items.Item(i).SubItems(9).Text)
							ListView99.Items(counter4).SubItems.Add(List1.Items.Item(i).SubItems(10).Text)
							ListView99.Items(counter4).SubItems.Add(List1.Items.Item(i).SubItems(11).Text)
							ListView99.Items(counter4).SubItems.Add(List1.Items.Item(i).SubItems(12).Text)
							ListView99.Items(counter4).SubItems.Add(List1.Items.Item(i).SubItems(13).Text)
							ListView99.Items(counter4).SubItems.Add(List1.Items.Item(i).SubItems(14).Text)
							ListView99.Items(counter4).SubItems.Add(List1.Items.Item(i).SubItems(15).Text)
							counter4 = counter4 + 1
						End If
						For subitem As Integer = 0 To List1.Items(i).SubItems.Count - 1
							If Trim(List1.Items(i).SubItems(subitem).Text).Contains(Trim(TextBox1.Text)) Then
								ListView99.Items.Add(List1.Items.Item(i).SubItems(0).Text)
								ListView99.Items(counter4).SubItems.Add(List1.Items.Item(i).SubItems(1).Text)
								ListView99.Items(counter4).SubItems.Add(List1.Items.Item(i).SubItems(2).Text)
								ListView99.Items(counter4).SubItems.Add(List1.Items.Item(i).SubItems(3).Text)
								ListView99.Items(counter4).SubItems.Add(List1.Items.Item(i).SubItems(4).Text)
								ListView99.Items(counter4).SubItems.Add(List1.Items.Item(i).SubItems(5).Text)
								ListView99.Items(counter4).SubItems.Add(List1.Items.Item(i).SubItems(6).Text)
								ListView99.Items(counter4).SubItems.Add(List1.Items.Item(i).SubItems(7).Text)
								ListView99.Items(counter4).SubItems.Add(List1.Items.Item(i).SubItems(8).Text)
								ListView99.Items(counter4).SubItems.Add(List1.Items.Item(i).SubItems(9).Text)
								ListView99.Items(counter4).SubItems.Add(List1.Items.Item(i).SubItems(10).Text)
								ListView99.Items(counter4).SubItems.Add(List1.Items.Item(i).SubItems(11).Text)
								ListView99.Items(counter4).SubItems.Add(List1.Items.Item(i).SubItems(12).Text)
								ListView99.Items(counter4).SubItems.Add(List1.Items.Item(i).SubItems(13).Text)
								ListView99.Items(counter4).SubItems.Add(List1.Items.Item(i).SubItems(14).Text)
								ListView99.Items(counter4).SubItems.Add(List1.Items.Item(i).SubItems(15).Text)
								counter4 = counter4 + 1
								Exit For
							End If
						Next

					Next

				End If
				Try
					ListView99.ListViewItemSorter = New ListViewItemComparer2(1, True)
					ListView99.Items.Item(0).Selected = True
					StartBol = True
				Catch
				End Try
			End If
		End If
	End Sub
	Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
		If e.KeyChar = "" Then
			Search_On = False
			If TextBox1.Text = "" Then
				ListView99.Visible = False
				counter4 = 0
			End If
		Else
			Search_On = True
		End If
	End Sub
	Private Sub CopyClipBoard(Platform_Send As String, ID_Send As String, Type_Send As String, Name_Send As String, Region_Send As String,
					 User_Send As String, Version_Send As String, Format_Send As String, Image_Send As String, Parts_Send As Boolean,
					 Encrypt_Send As String, NumberParts_Send As String, LicenseExist_Send As Boolean, LinkLisense_Send As String,
					 FormatLisense_Send As String)
		Upload_Add_item.Enabled = False
		Dim Encrypt_Split As String()
		Dim Encrypt_Array As New List(Of String)
		Encrypt_Split = Encrypt_Send.Split(New String() {Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries)
		'MsgBox(Encrypt_Split(0))
		'MsgBox(Encrypt_Split.Length)
		For Other As Integer = 1 To Encrypt_Split.Length
			'Encrypt_Array.Add
			Encrypt_Array.Add(AES_Encrypt(Encrypt_Split(Other - 1)))
			'Encrypt_Array.Add("asd2")
			'	Encrypt_Array.Add(1)
		Next
		Try
			'MsgBox(Encrypt_Array.ToArray)
			Dim Lista As New ListTwo()

			Lista.Name = Name_Send
			Lista.ID = ID_Send
			Lista.Type = Type_Send
			Lista.Format = Format_Send
			Lista.Image = Image_Send
			Lista.User = User_Send
			Lista.Version = Version_Send
			Lista.Encrypt = Encrypt_Array.ToArray
			Lista.Region = Region_Send
			Lista.N_Part = Encrypt_Split.Length
			Lista.Parts = Parts_Send
			Lista.FormatLisense = FormatLisense_Send
			Lista.LicenseExist = LicenseExist_Send
			Lista.LinkLisense = AES_Encrypt(LinkLisense_Send)

			Dim output As String = JsonConvert.SerializeObject(Lista)

			Clipboard.SetText(output & ",")
			ini.Load(Application.StartupPath & "\Lang\" & Languaje_Program & ".ini")
			NotifyIcon1.ShowBalloonTip(1000, "Σύνταξη for games    ", ini.GetKeyValue("LANGUAGE", "Game_data_copied_in_Clipboard"), ToolTipIcon.None)

		Catch ex As Exception
			NotifyIcon1.ShowBalloonTip(1000, "Σύνταξη for games    ", ex.Message, ToolTipIcon.Error)
		End Try

		Upload_Add_item.Enabled = True
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
	Private Sub ListView1_DoubleClick(sender As Object, e As EventArgs)
		'ListView1.Items.RemoveAt(ListView1.FocusedItem.Index)
		counter2 = counter2 - 1
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
	Function UrlExist(ByVal strURL As String) As String
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
		NotifyIcon1.Visible = False
	End Sub
	Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
		ini.Load(Application.StartupPath & "\Config.ini")
		If CheckBox1.CheckState = 1 Then
			load_images_games = True
			ini.SetKeyValue("Config", "Unload_Images", "True")
			ini.Save(Application.StartupPath & "\Config.ini")
		End If
		If CheckBox1.CheckState = 0 Then
			load_images_games = False
			ini.SetKeyValue("Config", "Unload_Images", "False")
			ini.Save(Application.StartupPath & "\Config.ini")
		End If
	End Sub
	Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
		Try
			If UrlExist(TextBox7.Text) = True Then
				PictureBox2.Load(TextBox7.Text)
			End If
		Catch
			MsgBox("Error Load Image")
		End Try
	End Sub
	Private Sub Button2_Click(sender As Object, e As EventArgs)
		Clipboard.SetText(AES_Encrypt("https://drive.google.com/uc?export=download&id=1kknhAg39K47SGWooqflDCXcbghmYs90Z"))
	End Sub
	Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
		If CheckBox3.CheckState = 1 Then
			CheckBox3.Text = "The Game is licensed? True"
			LinkLicense_Text.Visible = True
			License_Bol = True
			TextBox8.Visible = True
		End If
		If CheckBox3.CheckState = False Then
			CheckBox3.Text = "The Game is licensed? False"
			LinkLicense_Text.Visible = False
			License_Bol = False
			TextBox8.Visible = False
		End If
	End Sub
	Private Sub Color_Combobox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Color_Combobox.SelectedIndexChanged
		Dim color_combo As Color
		Color_ini = Color_Combobox.Text
		Select Case Color_Combobox.Text
			Case "White"
				color_combo = Color.White
			Case "WhiteSmoke"
				color_combo = Color.WhiteSmoke
			Case "BlanchedAlmond"
				color_combo = Color.BlanchedAlmond
			Case "Gray"
				color_combo = Color.Gray
			Case "DimGray"
				color_combo = Color.DimGray
			Case "Red"
				color_combo = Color.Red
			Case "Blue"
				color_combo = Color.Blue
			Case "Yellow"
				color_combo = Color.Yellow
			Case "Green"
				color_combo = Color.Green
			Case "Orange"
				color_combo = Color.Orange
			Case "Brown"
				color_combo = Color.Brown
			Case "Pink"
				color_combo = Color.Pink
			Case "Violet"
				color_combo = Color.Violet
			Case "Purple"
				color_combo = Color.Purple
			Case "Golden"
				color_combo = Color.Gold
			Case "Silver"
				color_combo = Color.Silver
			Case "Aqua"
				color_combo = Color.Aqua
			Case "AntiqueWhite"
				color_combo = Color.AntiqueWhite
			Case "AntiqueWhite"
				color_combo = Color.AntiqueWhite
			Case "Aquamarine"
				color_combo = Color.Aquamarine
			Case "Azure"
				color_combo = Color.Azure
			Case "Beige"
				color_combo = Color.Beige
			Case "Bisque"
				color_combo = Color.Bisque
			Case "BlanchedAlmond"
				color_combo = Color.BlanchedAlmond
			Case "BlueViolet"
				color_combo = Color.BlueViolet
			Case "BurlyWood"
				color_combo = Color.BurlyWood
			Case "CadetBlue"
				color_combo = Color.CadetBlue
			Case "Chartreuse"
				color_combo = Color.Chartreuse
			Case "Chartreuse"
				color_combo = Color.Chartreuse
			Case "Chocolate"
				color_combo = Color.Chocolate
			Case "Coral"
				color_combo = Color.Coral
			Case "CornflowerBlue"
				color_combo = Color.CornflowerBlue
			Case "Cornsilk"
				color_combo = Color.Cornsilk
			Case "Crimson"
				color_combo = Color.Crimson
			Case "Cyan"
				color_combo = Color.Cyan
			Case "DarkBlue"
				color_combo = Color.DarkBlue
			Case "DarkCyan"
				color_combo = Color.DarkCyan
			Case "DarkGoldenrod"
				color_combo = Color.DarkGoldenrod
			Case "DarkGray"
				color_combo = Color.DarkGray
			Case "DarkGreen"
				color_combo = Color.DarkGreen
			Case "DarkKhaki"
				color_combo = Color.DarkKhaki
			Case "DarkMagenta"
				color_combo = Color.DarkMagenta
			Case "DarkOliveGreen"
				color_combo = Color.DarkOliveGreen
			Case "DarkOrange"
				color_combo = Color.DarkOrange
			Case "DarkOrchid"
				color_combo = Color.DarkOrchid
			Case "DarkRed"
				color_combo = Color.DarkRed
			Case "DarkSalmon"
				color_combo = Color.DarkSalmon
			Case "DarkSeaGreen"
				color_combo = Color.DarkSeaGreen
			Case "DarkSlateBlue"
				color_combo = Color.DarkSlateBlue
			Case "DarkSlateGray"
				color_combo = Color.DarkSlateGray
			Case "DarkTurquoise"
				color_combo = Color.DarkTurquoise
			Case "DarkViolet"
				color_combo = Color.DarkViolet
			Case "DeepPink"
				color_combo = Color.DeepPink
			Case "DeepSkyBlue"
				color_combo = Color.DeepSkyBlue
			Case "DodgerBlue"
				color_combo = Color.DodgerBlue
			Case "Firebrick"
				color_combo = Color.Firebrick
			Case "FloralWhite"
				color_combo = Color.FloralWhite
			Case "ForestGreen"
				color_combo = Color.ForestGreen
			Case "Fuchsia"
				color_combo = Color.Fuchsia
			Case "Gainsboro"
				color_combo = Color.Gainsboro
			Case "GhostWhite"
				color_combo = Color.GhostWhite
			Case "Goldenrod"
				color_combo = Color.Goldenrod
			Case "GreenYellow"
				color_combo = Color.GreenYellow
			Case "Honeydew"
				color_combo = Color.Honeydew
			Case "HotPink"
				color_combo = Color.HotPink
			Case "IndianRed"
				color_combo = Color.IndianRed
			Case "Indigo"
				color_combo = Color.Indigo
			Case "Ivory"
				color_combo = Color.Ivory
			Case "Khaki"
				color_combo = Color.Khaki
			Case "Lavender"
				color_combo = Color.Lavender
			Case "LavenderBlush"
				color_combo = Color.LavenderBlush
			Case "LawnGreen"
				color_combo = Color.LawnGreen
			Case "LemonChiffon"
				color_combo = Color.LemonChiffon
			Case "LightBlue"
				color_combo = Color.LightBlue
			Case "Color.LightCoral"
				color_combo = Color.LightCoral
			Case "LightCyan"
				color_combo = Color.LightCyan
			Case "LightGoldenrodYellow"
				color_combo = Color.LightGoldenrodYellow
			Case "LightGray"
				color_combo = Color.LightGray
			Case "LightGreen"
				color_combo = Color.LightGreen
			Case "LightPink"
				color_combo = Color.LightPink
			Case "LightSalmon"
				color_combo = Color.LightSalmon
			Case "LightSeaGreen"
				color_combo = Color.LightSeaGreen
			Case "LightSkyBlue"
				color_combo = Color.LightSkyBlue
			Case "LightSlateGray"
				color_combo = Color.LightSlateGray
			Case "LightSteelBlue"
				color_combo = Color.LightSteelBlue
			Case "LightYellow"
				color_combo = Color.LightYellow
			Case "Lime"
				color_combo = Color.Lime
			Case "LimeGreen"
				color_combo = Color.LimeGreen
			Case "Linen"
				color_combo = Color.Linen
			Case "Magenta"
				color_combo = Color.Magenta
			Case "Maroon"
				color_combo = Color.Maroon
			Case "MediumAquamarine"
				color_combo = Color.MediumAquamarine
			Case "MediumBlue"
				color_combo = Color.MediumBlue
			Case "MediumOrchid"
				color_combo = Color.MediumOrchid
			Case "MediumPurple"
				color_combo = Color.MediumPurple
			Case "MediumSeaGreen"
				color_combo = Color.MediumSeaGreen
			Case "MediumSlateBlue"
				color_combo = Color.MediumSlateBlue
			Case "MediumSpringGreen"
				color_combo = Color.MediumSpringGreen
			Case "MediumTurquoise"
				color_combo = Color.MediumTurquoise
			Case "MediumVioletRed"
				color_combo = Color.MediumVioletRed
			Case "MidnightBlue"
				color_combo = Color.MidnightBlue
			Case "MintCream"
				color_combo = Color.MintCream
			Case "MistyRose"
				color_combo = Color.MistyRose
			Case "Moccasin"
				color_combo = Color.Moccasin
			Case "NavajoWhite"
				color_combo = Color.NavajoWhite
			Case "Navy"
				color_combo = Color.Navy
			Case "OldLace"
				color_combo = Color.OldLace
			Case "Olive"
				color_combo = Color.Olive
			Case "OliveDrab"
				color_combo = Color.OliveDrab
			Case "OrangeRed"
				color_combo = Color.OrangeRed
			Case "Orchid"
				color_combo = Color.Orchid
			Case "PaleGoldenrod"
				color_combo = Color.PaleGoldenrod
			Case "PaleGreen"
				color_combo = Color.PaleGreen
			Case "PaleTurquoise"
				color_combo = Color.PaleTurquoise
			Case "PaleVioletRed"
				color_combo = Color.PaleVioletRed
			Case "PapayaWhip"
				color_combo = Color.PapayaWhip
			Case "PeachPuff"
				color_combo = Color.PeachPuff
			Case "Peru"
				color_combo = Color.Peru
			Case "Plum"
				color_combo = Color.Plum
			Case "PowderBlue"
				color_combo = Color.PowderBlue
			Case "RosyBrown"
				color_combo = Color.RosyBrown
			Case "RoyalBlue"
				color_combo = Color.RoyalBlue
			Case "SaddleBrown"
				color_combo = Color.SaddleBrown
			Case "Salmon"
				color_combo = Color.Salmon
			Case "SandyBrown"
				color_combo = Color.SandyBrown
			Case "SeaGreen"
				color_combo = Color.SeaGreen
			Case "SeaShell"
				color_combo = Color.SeaShell
			Case "Sienna"
				color_combo = Color.Sienna
			Case "SkyBlue"
				color_combo = Color.SkyBlue
			Case "SlateBlue"
				color_combo = Color.SlateBlue
			Case "SlateGray"
				color_combo = Color.SlateGray
			Case "Snow"
				color_combo = Color.Snow
			Case "SpringGreen"
				color_combo = Color.SpringGreen
			Case "SteelBlue"
				color_combo = Color.SteelBlue
			Case "Tan"
				color_combo = Color.Tan
			Case "Teal"
				color_combo = Color.Teal
			Case "Thistle"
				color_combo = Color.Thistle
			Case "Tomato"
				color_combo = Color.Tomato
			Case "Turquoise"
				color_combo = Color.Turquoise
			Case "Wheat"
				color_combo = Color.Wheat
			Case "WhiteSmoke"
				color_combo = Color.WhiteSmoke
			Case "YellowGreen"
				color_combo = Color.YellowGreen
		End Select
		TabPage3.BackColor = color_combo
		Uploader.BackColor = color_combo
		Color_Combobox.BackColor = color_combo
		Languaje_Combobox.BackColor = color_combo
		TabPage1.BackColor = color_combo
		TabPage2.BackColor = color_combo
		ListViewEx.BackColor = color_combo
		List_Download.BackColor = color_combo
		ComboBox4.BackColor = color_combo
		ComboBox3.BackColor = color_combo
		Button1.BackColor = color_combo
		TextBox2.BackColor = color_combo
		TextBox3.BackColor = color_combo
		TextBox4.BackColor = color_combo
		TextBox6.BackColor = color_combo
		TextBox5.BackColor = color_combo
		ID_Game.BackColor = color_combo
		TextBox8.BackColor = color_combo
		LinkLicense_Text.BackColor = color_combo
		Upload_Add_item.BackColor = color_combo
		TextBox7.BackColor = color_combo
		PictureBox2.BackColor = color_combo
		PictureBox3.BackColor = color_combo
		Search_Label.BackColor = color_combo
		TextBox1.BackColor = color_combo
		Companya_Combo.BackColor = color_combo
		ComboBox1.BackColor = color_combo
		Name_Game_Label.BackColor = color_combo
		Type_label.BackColor = color_combo
		Format_label.BackColor = color_combo
		User_label.BackColor = color_combo
		Version_label.BackColor = color_combo
		Region_label.BackColor = color_combo
		DownParts.BackColor = color_combo
		Button2.BackColor = color_combo
		Button_Download.BackColor = color_combo
		ListView99.BackColor = color_combo
		List1.BackColor = color_combo
		ComboBox2.BackColor = color_combo
		MyToolStrip.BackColor = color_combo
		TextBox9.BackColor = color_combo

		ini.SetKeyValue("Config", "Color", Color_Combobox.Text)
		ini.Save(Application.StartupPath & "\Config.ini")

		If BackGround_Image = True Then
			If Dir(Application.StartupPath & "\Picture.png", vbDirectory) = "" Then
			Else
				Dim Dir_Image As String = Application.StartupPath & "\Picture.png"
				PictureBox2.BackColor = Color.Transparent
				PictureBox3.BackColor = Color.Transparent
			End If
		End If
	End Sub
	Private Sub Background_image_checkbox_CheckedChanged(sender As Object, e As EventArgs) Handles background_image_checkbox.CheckedChanged
		ini.Load(Application.StartupPath & "\Config.ini")
		If background_image_checkbox.CheckState = 1 Then
			'load_images_games = True
			Select_Image.Visible = True
			Label2.Visible = True
			ini.SetKeyValue("Config", "BackGroundImage", "True")
			ini.Save(Application.StartupPath & "\Config.ini")
			BackGround_Image = True
			If BackGround_Image = True Then
				If Dir(Application.StartupPath & "\Picture.png", vbDirectory) = "" Then
				Else
					Dim Dir_Image As String = Application.StartupPath & "\Picture.png"
					TabPage3.BackgroundImage = System.Drawing.Image.FromFile(Dir_Image)
					TabPage1.BackgroundImage = System.Drawing.Image.FromFile(Dir_Image)
					TabPage2.BackgroundImage = System.Drawing.Image.FromFile(Dir_Image)
					List_Download.BackgroundImage = System.Drawing.Image.FromFile(Dir_Image)
					PictureBox2.BackColor = Color.Transparent
					PictureBox3.BackColor = Color.Transparent
				End If
			End If
		End If
		If background_image_checkbox.CheckState = 0 Then
			'load_images_games = False
			Select_Image.Visible = False
			ini.SetKeyValue("Config", "BackGroundImage", "False")
			ini.Save(Application.StartupPath & "\Config.ini")
			BackGround_Image = False
			Label2.Visible = False
			TabPage3.BackgroundImage = Nothing
			TabPage1.BackgroundImage = Nothing
			TabPage2.BackgroundImage = Nothing
			List_Download.BackgroundImage = Nothing

			Dim color_combo As Color
			Select Case Color_ini
				Case "White"
					color_combo = Color.White
				Case "WhiteSmoke"
					color_combo = Color.WhiteSmoke
				Case "BlanchedAlmond"
					color_combo = Color.BlanchedAlmond
				Case "Gray"
					color_combo = Color.Gray
				Case "DimGray"
					color_combo = Color.DimGray
				Case "Red"
					color_combo = Color.Red
				Case "Blue"
					color_combo = Color.Blue
				Case "Yellow"
					color_combo = Color.Yellow
				Case "Green"
					color_combo = Color.Green
				Case "Orange"
					color_combo = Color.Orange
				Case "Brown"
					color_combo = Color.Brown
				Case "Pink"
					color_combo = Color.Pink
				Case "Violet"
					color_combo = Color.Violet
				Case "Purple"
					color_combo = Color.Purple
				Case "Golden"
					color_combo = Color.Gold
				Case "Silver"
					color_combo = Color.Silver
				Case "Aqua"
					color_combo = Color.Aqua
				Case "AntiqueWhite"
					color_combo = Color.AntiqueWhite
				Case "AntiqueWhite"
					color_combo = Color.AntiqueWhite
				Case "Aquamarine"
					color_combo = Color.Aquamarine
				Case "Azure"
					color_combo = Color.Azure
				Case "Beige"
					color_combo = Color.Beige
				Case "Bisque"
					color_combo = Color.Bisque
				Case "BlanchedAlmond"
					color_combo = Color.BlanchedAlmond
				Case "BlueViolet"
					color_combo = Color.BlueViolet
				Case "BurlyWood"
					color_combo = Color.BurlyWood
				Case "CadetBlue"
					color_combo = Color.CadetBlue
				Case "Chartreuse"
					color_combo = Color.Chartreuse
				Case "Chartreuse"
					color_combo = Color.Chartreuse
				Case "Chocolate"
					color_combo = Color.Chocolate
				Case "Coral"
					color_combo = Color.Coral
				Case "CornflowerBlue"
					color_combo = Color.CornflowerBlue
				Case "Cornsilk"
					color_combo = Color.Cornsilk
				Case "Crimson"
					color_combo = Color.Crimson
				Case "Cyan"
					color_combo = Color.Cyan
				Case "DarkBlue"
					color_combo = Color.DarkBlue
				Case "DarkCyan"
					color_combo = Color.DarkCyan
				Case "DarkGoldenrod"
					color_combo = Color.DarkGoldenrod
				Case "DarkGray"
					color_combo = Color.DarkGray
				Case "DarkGreen"
					color_combo = Color.DarkGreen
				Case "DarkKhaki"
					color_combo = Color.DarkKhaki
				Case "DarkMagenta"
					color_combo = Color.DarkMagenta
				Case "DarkOliveGreen"
					color_combo = Color.DarkOliveGreen
				Case "DarkOrange"
					color_combo = Color.DarkOrange
				Case "DarkOrchid"
					color_combo = Color.DarkOrchid
				Case "DarkRed"
					color_combo = Color.DarkRed
				Case "DarkSalmon"
					color_combo = Color.DarkSalmon
				Case "DarkSeaGreen"
					color_combo = Color.DarkSeaGreen
				Case "DarkSlateBlue"
					color_combo = Color.DarkSlateBlue
				Case "DarkSlateGray"
					color_combo = Color.DarkSlateGray
				Case "DarkTurquoise"
					color_combo = Color.DarkTurquoise
				Case "DarkViolet"
					color_combo = Color.DarkViolet
				Case "DeepPink"
					color_combo = Color.DeepPink
				Case "DeepSkyBlue"
					color_combo = Color.DeepSkyBlue
				Case "DodgerBlue"
					color_combo = Color.DodgerBlue
				Case "Firebrick"
					color_combo = Color.Firebrick
				Case "FloralWhite"
					color_combo = Color.FloralWhite
				Case "ForestGreen"
					color_combo = Color.ForestGreen
				Case "Fuchsia"
					color_combo = Color.Fuchsia
				Case "Gainsboro"
					color_combo = Color.Gainsboro
				Case "GhostWhite"
					color_combo = Color.GhostWhite
				Case "Goldenrod"
					color_combo = Color.Goldenrod
				Case "GreenYellow"
					color_combo = Color.GreenYellow
				Case "Honeydew"
					color_combo = Color.Honeydew
				Case "HotPink"
					color_combo = Color.HotPink
				Case "IndianRed"
					color_combo = Color.IndianRed
				Case "Indigo"
					color_combo = Color.Indigo
				Case "Ivory"
					color_combo = Color.Ivory
				Case "Khaki"
					color_combo = Color.Khaki
				Case "Lavender"
					color_combo = Color.Lavender
				Case "LavenderBlush"
					color_combo = Color.LavenderBlush
				Case "LawnGreen"
					color_combo = Color.LawnGreen
				Case "LemonChiffon"
					color_combo = Color.LemonChiffon
				Case "LightBlue"
					color_combo = Color.LightBlue
				Case "Color.LightCoral"
					color_combo = Color.LightCoral
				Case "LightCyan"
					color_combo = Color.LightCyan
				Case "LightGoldenrodYellow"
					color_combo = Color.LightGoldenrodYellow
				Case "LightGray"
					color_combo = Color.LightGray
				Case "LightGreen"
					color_combo = Color.LightGreen
				Case "LightPink"
					color_combo = Color.LightPink
				Case "LightSalmon"
					color_combo = Color.LightSalmon
				Case "LightSeaGreen"
					color_combo = Color.LightSeaGreen
				Case "LightSkyBlue"
					color_combo = Color.LightSkyBlue
				Case "LightSlateGray"
					color_combo = Color.LightSlateGray
				Case "LightSteelBlue"
					color_combo = Color.LightSteelBlue
				Case "LightYellow"
					color_combo = Color.LightYellow
				Case "Lime"
					color_combo = Color.Lime
				Case "LimeGreen"
					color_combo = Color.LimeGreen
				Case "Linen"
					color_combo = Color.Linen
				Case "Magenta"
					color_combo = Color.Magenta
				Case "Maroon"
					color_combo = Color.Maroon
				Case "MediumAquamarine"
					color_combo = Color.MediumAquamarine
				Case "MediumBlue"
					color_combo = Color.MediumBlue
				Case "MediumOrchid"
					color_combo = Color.MediumOrchid
				Case "MediumPurple"
					color_combo = Color.MediumPurple
				Case "MediumSeaGreen"
					color_combo = Color.MediumSeaGreen
				Case "MediumSlateBlue"
					color_combo = Color.MediumSlateBlue
				Case "MediumSpringGreen"
					color_combo = Color.MediumSpringGreen
				Case "MediumTurquoise"
					color_combo = Color.MediumTurquoise
				Case "MediumVioletRed"
					color_combo = Color.MediumVioletRed
				Case "MidnightBlue"
					color_combo = Color.MidnightBlue
				Case "MintCream"
					color_combo = Color.MintCream
				Case "MistyRose"
					color_combo = Color.MistyRose
				Case "Moccasin"
					color_combo = Color.Moccasin
				Case "NavajoWhite"
					color_combo = Color.NavajoWhite
				Case "Navy"
					color_combo = Color.Navy
				Case "OldLace"
					color_combo = Color.OldLace
				Case "Olive"
					color_combo = Color.Olive
				Case "OliveDrab"
					color_combo = Color.OliveDrab
				Case "OrangeRed"
					color_combo = Color.OrangeRed
				Case "Orchid"
					color_combo = Color.Orchid
				Case "PaleGoldenrod"
					color_combo = Color.PaleGoldenrod
				Case "PaleGreen"
					color_combo = Color.PaleGreen
				Case "PaleTurquoise"
					color_combo = Color.PaleTurquoise
				Case "PaleVioletRed"
					color_combo = Color.PaleVioletRed
				Case "PapayaWhip"
					color_combo = Color.PapayaWhip
				Case "PeachPuff"
					color_combo = Color.PeachPuff
				Case "Peru"
					color_combo = Color.Peru
				Case "Plum"
					color_combo = Color.Plum
				Case "PowderBlue"
					color_combo = Color.PowderBlue
				Case "RosyBrown"
					color_combo = Color.RosyBrown
				Case "RoyalBlue"
					color_combo = Color.RoyalBlue
				Case "SaddleBrown"
					color_combo = Color.SaddleBrown
				Case "Salmon"
					color_combo = Color.Salmon
				Case "SandyBrown"
					color_combo = Color.SandyBrown
				Case "SeaGreen"
					color_combo = Color.SeaGreen
				Case "SeaShell"
					color_combo = Color.SeaShell
				Case "Sienna"
					color_combo = Color.Sienna
				Case "SkyBlue"
					color_combo = Color.SkyBlue
				Case "SlateBlue"
					color_combo = Color.SlateBlue
				Case "SlateGray"
					color_combo = Color.SlateGray
				Case "Snow"
					color_combo = Color.Snow
				Case "SpringGreen"
					color_combo = Color.SpringGreen
				Case "SteelBlue"
					color_combo = Color.SteelBlue
				Case "Tan"
					color_combo = Color.Tan
				Case "Teal"
					color_combo = Color.Teal
				Case "Thistle"
					color_combo = Color.Thistle
				Case "Tomato"
					color_combo = Color.Tomato
				Case "Turquoise"
					color_combo = Color.Turquoise
				Case "Wheat"
					color_combo = Color.Wheat
				Case "WhiteSmoke"
					color_combo = Color.WhiteSmoke
				Case "YellowGreen"
					color_combo = Color.YellowGreen
			End Select
			PictureBox2.BackColor = color_combo
			PictureBox3.BackColor = color_combo
		End If

	End Sub
	Private Sub Select_Image_Click(sender As Object, e As EventArgs) Handles Select_Image.Click
		Dim rutaDefault = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
		Dim fileDefault = "Picture.png"

		Dim abrir As New OpenFileDialog
		abrir.InitialDirectory = rutaDefault
		abrir.Filter = "Png|*.png"

		If File.Exists(Path.Combine(rutaDefault, fileDefault)) Then
			'Nombre de archivo que se cargará por defecto, si existe en la ruta
			abrir.FileName = fileDefault
		End If

		If abrir.ShowDialog = DialogResult.OK Then
			'TextBox1.Text = abrir.FileName
			'MsgBox(abrir.)
			TabPage3.BackgroundImage = Nothing
			TabPage1.BackgroundImage = Nothing
			TabPage2.BackgroundImage = Nothing
			Dim Dir_Image As String = Application.StartupPath & "\Picture.png"


			If Dir(Application.StartupPath & "\Picture.png", vbDirectory) = "" Then
				File.Copy(abrir.FileName, Dir_Image)
			Else
				File.Copy(abrir.FileName, Application.StartupPath & "\Picture_Remplace.png")
				Application.Restart()
			End If


			TabPage3.BackgroundImage = System.Drawing.Image.FromFile(Dir_Image)
			TabPage1.BackgroundImage = System.Drawing.Image.FromFile(Dir_Image)
			TabPage2.BackgroundImage = System.Drawing.Image.FromFile(Dir_Image)
			List_Download.BackgroundImage = System.Drawing.Image.FromFile(Dir_Image)
		End If
		'MsgBox(fileDefault)
	End Sub
	Private Sub BtnResume_Click(sender As Object, e As EventArgs) Handles btnResume1.Click
		Dim wClient As DownloadFileAsyncExtended

		For i As Integer = 0 To ListViewEx.SelectedItems.Count - 1
			If ListViewEx.SelectedItems(i).Tag IsNot Nothing Then
				wClient = DirectCast(ListViewEx.SelectedItems(i).Tag, DownloadFileAsyncExtended)
				'// Make sure you check if the download is not
				'// already busy or an exception will be thrown.
				If wClient.IsBusy = False Then
					wClient.ResumeAsync()
				End If
			End If
		Next
	End Sub
	Private Sub BtnResumeAll_Click(sender As Object, e As EventArgs) Handles btnResumeAll1.Click
		Dim wClient As DownloadFileAsyncExtended

		For i As Integer = 0 To ListViewEx.Items.Count - 1
			If ListViewEx.Items(i).Tag IsNot Nothing Then
				wClient = DirectCast(ListViewEx.Items(i).Tag, DownloadFileAsyncExtended)
				'// Make sure you check if the download is not
				'// already busy or an exception will be thrown.
				If wClient.IsBusy = False Then
					wClient.ResumeAsync()
				End If
			End If
		Next
	End Sub
	Private Sub BtnPause_Click(sender As Object, e As EventArgs) Handles btnPause1.Click
		Dim wClient As DownloadFileAsyncExtended

		For i As Integer = 0 To ListViewEx.SelectedItems.Count - 1
			If ListViewEx.SelectedItems(i).Tag IsNot Nothing Then
				wClient = DirectCast(ListViewEx.SelectedItems(i).Tag, DownloadFileAsyncExtended)
				'// Pause the download.
				wClient.CancelAsync()
			End If
		Next
	End Sub
	Private Sub BtnPauseAll_Click(sender As Object, e As EventArgs) Handles btnPauseAll1.Click
		Dim wClient As DownloadFileAsyncExtended

		For i As Integer = 0 To ListViewEx.Items.Count - 1
			If ListViewEx.Items(i).Tag IsNot Nothing Then
				wClient = DirectCast(ListViewEx.Items(i).Tag, DownloadFileAsyncExtended)
				'// Pause the download.
				wClient.CancelAsync()
			End If
		Next
	End Sub
	Private Sub BtnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove1.Click
		Dim wClient As DownloadFileAsyncExtended
		Dim Accept_Form As New Accept
		'// Always loop backwards when removing items from the list,
		'// because the index gets updated when an item is removed.
		'// This can result in certain items not getting removed.

		If Accept_Form.ShowDialog = DialogResult.OK Then


			For i As Integer = ListViewEx.SelectedItems.Count - 1 To 0 Step -1
				If ListViewEx.SelectedItems(i).Tag IsNot Nothing Then
					'// Get the DownloadFileAsyncExtended class instance from the ListViewItem Tag.
					wClient = DirectCast(ListViewEx.SelectedItems(i).Tag, DownloadFileAsyncExtended)
					'// Pause (cancel) the download and remove it from the list.
					wClient.CancelAsync()
					ListViewEx.SelectedItems(i).Tag = Nothing

					If Accept_Form.CheckBox1.Checked = True Then
						'Kill(ListViewEx.SelectedItems(i).)
						If System.IO.File.Exists(saved & "\Roms\" & ListViewEx.Items.Item(i).SubItems(0).Text) = True Then
							'	MsgBox("exist")
							Kill(saved & "\Roms\" & ListViewEx.Items.Item(i).SubItems(0).Text)
						Else
							'MsgBox("exist2")
						End If
					End If
					ListViewEx.SelectedItems(i).Remove()
				Else
					If Accept_Form.CheckBox1.Checked = True Then
						MsgBox(saved & ListViewEx.Items.Item(i).SubItems(0).Text)
						If System.IO.File.Exists(saved & ListViewEx.Items.Item(i).SubItems(0).Text) = True Then
							'	MsgBox("exist")
							Kill(saved & "\Roms\" & ListViewEx.Items.Item(i).SubItems(0).Text)
						Else
							'MsgBox("exist2")
						End If
					End If
					'// There's nothing to cancel, because the
					'// download has finished or caused an error.
					'// Just remove the item from the list.
					ListViewEx.SelectedItems(i).Remove()
				End If
			Next
		End If
		'MsgBox(Accept_Form.CheckBox1.CheckState)
	End Sub
	Private Sub BtnRemoveAll_Click(sender As Object, e As EventArgs) Handles btnRemoveAll.Click
		Dim wClient As DownloadFileAsyncExtended

		'// Always loop backwards when removing items from the list,
		'// because the index gets updated when an item is removed.
		'// This can result in certain items not getting removed.
		For i As Integer = ListViewEx.Items.Count - 1 To 0 Step -1
			If ListViewEx.Items(i).Tag IsNot Nothing Then
				'// Get the DownloadFileAsyncExtended class instance from the ListViewItem Tag.
				wClient = DirectCast(ListViewEx.Items(i).Tag, DownloadFileAsyncExtended)
				'// Pause (cancel) the download and remove it from the list.
				wClient.CancelAsync()
				ListViewEx.Items(i).Tag = Nothing
				ListViewEx.Items(i).Remove()
			Else
				'// There's nothing to cancel, because the
				'// download has finished or caused an error.
				'// Just remove the item from the list.
				ListViewEx.Items(i).Remove()
			End If
		Next
	End Sub
	Private Sub ListViewEx_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListViewEx.MouseUp
		Dim objDrawingPoint As Point
		Dim objListViewItem As ListViewItem

		objDrawingPoint = ListViewEx.PointToClient(Cursor.Position)

		'// Check to see if an item has been selected.
		If Not IsNothing(objDrawingPoint) Then
			With objDrawingPoint
				objListViewItem = ListViewEx.GetItemAt(.X, .Y)
			End With

			'// If an item has been selected, then enable toolstrip buttons.
			If Not IsNothing(objListViewItem) Then
				btnResume1.Enabled = True
				btnPause1.Enabled = True
				btnRemove1.Enabled = True
			Else '// Else disable them.
				btnResume1.Enabled = False
				btnPause1.Enabled = False
				btnRemove1.Enabled = False
			End If
		End If
	End Sub
	Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
		Try
			PictureBox3.Load(List1.Items.Item(List1.FocusedItem.Index).SubItems(12).Text)
		Catch
			MsgBox("Error Load Image")
		End Try
	End Sub
	Private Sub OpenToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem1.Click
		Show()
	End Sub
	Private Sub ResumeAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResumeAllToolStripMenuItem.Click
		Dim wClient As DownloadFileAsyncExtended

		For i As Integer = 0 To ListViewEx.Items.Count - 1
			If ListViewEx.Items(i).Tag IsNot Nothing Then
				wClient = DirectCast(ListViewEx.Items(i).Tag, DownloadFileAsyncExtended)
				'// Make sure you check if the download is not
				'// already busy or an exception will be thrown.
				If wClient.IsBusy = False Then
					wClient.ResumeAsync()
				End If
			End If
		Next
	End Sub
	Private Sub PauseAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PauseAllToolStripMenuItem.Click
		Dim wClient As DownloadFileAsyncExtended

		For i As Integer = 0 To ListViewEx.Items.Count - 1
			If ListViewEx.Items(i).Tag IsNot Nothing Then
				wClient = DirectCast(ListViewEx.Items(i).Tag, DownloadFileAsyncExtended)
				'// Pause the download.
				wClient.CancelAsync()
			End If
		Next
	End Sub
	Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem1.Click
		Dim wClient As DownloadFileAsyncExtended

		For i As Integer = 0 To ListViewEx.Items.Count - 1
			'// Check if the Tag isn't Nothing, because else the download has already
			'// finished or an error occurred, so it can't be cancelled.
			If ListViewEx.Items(i).Tag IsNot Nothing Then
				'// Get the DownloadFileAsyncExtended class instance from the ListViewItem Tag.
				wClient = DirectCast(ListViewEx.Items(i).Tag, DownloadFileAsyncExtended)
				'// Cancel the download if it's still busy.
				wClient.CancelAsync()
			End If
		Next
		Close()
	End Sub
	Private Sub MinimizeToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MinimizeToolStripMenuItem1.Click
		Hide()
	End Sub
	Private Sub MinimizeToolStripMenuItem_Click(sender As Object, e As EventArgs)
		Hide()
	End Sub
	Private Sub RemoveAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveAllToolStripMenuItem.Click
		Dim wClient As DownloadFileAsyncExtended

		'// Always loop backwards when removing items from the list,
		'// because the index gets updated when an item is removed.
		'// This can result in certain items not getting removed.
		For i As Integer = ListViewEx.Items.Count - 1 To 0 Step -1
			If ListViewEx.Items(i).Tag IsNot Nothing Then
				'// Get the DownloadFileAsyncExtended class instance from the ListViewItem Tag.
				wClient = DirectCast(ListViewEx.Items(i).Tag, DownloadFileAsyncExtended)
				'// Pause (cancel) the download and remove it from the list.
				wClient.CancelAsync()
				ListViewEx.Items(i).Tag = Nothing
				ListViewEx.Items(i).Remove()
			Else
				'// There's nothing to cancel, because the
				'// download has finished or caused an error.
				'// Just remove the item from the list.
				ListViewEx.Items(i).Remove()
			End If
		Next
	End Sub
	Private Sub Uploader_tab_CheckedChanged(sender As Object, e As EventArgs) Handles Uploader_tab.CheckedChanged
		ini.Load(Application.StartupPath & "\Config.ini")
		If Uploader_tab.CheckState = 1 Then
			If start_tab = False Then
			Else
				Upload.TabPages.Add(TabPage2)
				start_tab = True
			End If

			TextBox9.Visible = True
			Encrypt_Burron.Visible = True
			ini.SetKeyValue("Config", "Show_Uploader", "True")
			ini.Save(Application.StartupPath & "\Config.ini")
			'MsgBox("add")
		End If
		If Uploader_tab.CheckState = 0 Then
			'MsgBox("remove")
			Upload.TabPages.Remove(TabPage2)
			ini.SetKeyValue("Config", "Show_Uploader", "False")
			ini.Save(Application.StartupPath & "\Config.ini")
			TextBox9.Visible = False
			Encrypt_Burron.Visible = False
			start_tab = True
		End If
	End Sub
	Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
		If (FolderBrowserDialog1.ShowDialog() = DialogResult.OK) Then
			'MsgBox(FolderBrowserDialog1.SelectedPath)
			Dir_Save_Games = FolderBrowserDialog1.SelectedPath
			ini.Load(Application.StartupPath & "\Config.ini")
			ini.SetKeyValue("Config", "Path_Save", FolderBrowserDialog1.SelectedPath)
			ini.Save(Application.StartupPath & "\Config.ini")
		End If
	End Sub
	Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
		Dim saved As String

		If Dir_Save_Games = "Default" Then
			saved = Application.StartupPath
		Else
			saved = Dir_Save_Games

			If (Directory.Exists(Dir_Save_Games)) = False Then
				MsgBox("The selected dirrectory does not exist please select another dirrectory")
				Exit Sub
			End If
		End If


		myWebClient = New Net.WebClient
		Dim Plataforma As String
		Select Case ComboBox1.Text
			Case "All"
				Plataforma = "All"
			Case "Wii"
				Plataforma = "Wii"
			Case "Wii U"
				Plataforma = "WiiU"
			Case "Nintendo Swich"
				Plataforma = "NSwich"
			Case "Nintendo 64"
				Plataforma = "N64"
			Case "GameCube"
				Plataforma = "GameCube"
			Case "Virtual Boy"
				Plataforma = "VirtualBoy"
			Case "Game Boy Advance"
				Plataforma = "GameBoyAdvance"
			Case "Snes"
				Plataforma = "SNES"
			Case "Nes"
				Plataforma = "NES"
			Case "NDS"
				Plataforma = "NDS"
			Case "3DS"
				Plataforma = "3DS"
			Case "Game Boy"
				Plataforma = "GameBoy"
			Case "Game & Watch"
				Plataforma = "G&W"
			Case "PlayStation"
				Plataforma = "PS1"
			Case "PlayStation 2"
				Plataforma = "PS2"
			Case "PlayStation 3"
				Plataforma = "PS3"
			Case "PlayStation 4"
				Plataforma = "PS4"
			Case "PSP"
				Plataforma = "PSP"
			Case "PS Vita"
				Plataforma = "PSVita"
			Case "PocketStation"
				Plataforma = "PocketStation"
			Case "Xbox"
				Plataforma = "Xbox"
			Case "Xbox 360"
				Plataforma = "Xbox360"
			Case "Xbox One"
				Plataforma = "XboxOne"
			Case "SG-1000"
				Plataforma = "SG-1000"
			Case "SC-3000"
				Plataforma = "SC-3000"
			Case "Sega Master System"
				Plataforma = "Sega-Master-System"
			Case "Sega Genesis"
				Plataforma = "Sega-Genesis"
			Case "Sega Mega CD"
				Plataforma = "Sega-Mega-CD"
			Case "Game Gear"
				Plataforma = "Game-Gear"
			Case "Sega Saturn"
				Plataforma = "Sega-Saturn"
			Case "Mega Drive 32x"
				Plataforma = "Mega-Drive-32x"
			Case "Sega Nomad"
				Plataforma = "Sega-Nomad"
			Case "Sega Model 2"
				Plataforma = "Sega-Model-2"
			Case "Sega Dreamcast"
				Plataforma = "Dreamcast"
			Case "Neo-Geo"
				Plataforma = "Neo-Geo"
			Case "Neo-Geo CD"
				Plataforma = "Neo-Geo-CD"
			Case "Pippin"
				Plataforma = "Pippin"
			Case "Atari 2600"
				Plataforma = "Atari2600"
			Case "Atari 5200"
				Plataforma = "Atari5200"
			Case "Atari 7800"
				Plataforma = "Atari7800"
			Case "Atari Jaguar"
				Plataforma = "Atari-Jaguar"
			Case "Playdia"
				Plataforma = "Playdia"
			Case "Wonderswan"
				Plataforma = "Wonderswan"
			Case "Wonderswan Color"
				Plataforma = "Wonderswan-Color"
			Case "Play System 1"
				Plataforma = "Play-System-1"
			Case "Play System 2"
				Plataforma = "Play-System-2"
			Case "Play System 3"
				Plataforma = "Play-System-3"
			Case "Casio Loopy"
				Plataforma = "Casio-Loopy"
			Case "ColecoVision"
				Plataforma = "ColecoVision"
			Case "Commodore 64GS"
				Plataforma = "Commodore64GS"
			Case "AmigaCD32"
				Plataforma = "AmigaCD32"
			Case "AmigaCD"
				Plataforma = "AmigaCD"
			Case "Fairchild Channel F"
				Plataforma = "Fairchild-Channel-F"
			Case "GP32"
				Plataforma = "GP32"
			Case "Vectrex"
				Plataforma = "Vectrex"
			Case "Magnavox Oddyssey"
				Plataforma = "Magnavox-Oddyssey"
			Case "Magnavox Oddyssey 2"
				Plataforma = "Magnavox-Oddyssey2"
			Case "Intellivision"
				Plataforma = "Intellivision"
			Case "PC Engine"
				Plataforma = "PC-Engine"
			Case "PC-FX"
				Plataforma = "PC-FX"
			Case "N-Gage"
				Plataforma = "N-Gage"
			Case "3DO"
				Plataforma = "3DO"
			Case "Videopac"
				Plataforma = "Videopac"
			Case "Philips CDi"
				Plataforma = "Philips-CDi"
			Case "RCA Studio II"
				Plataforma = "RCA-Studio-II"
			Case "V.Smile"
				Plataforma = "V-Smile"
			Case "Amstrad GX4000"
				Plataforma = "AmstradGX4000"
		End Select
#Disable Warning BC42104 ' Se usa la variable antes de que se le haya asignado un valor
		'MsgBox()
		If Plataforma = "All" Then
			Select Case List1.Items.Item(0).SubItems(8).Text
				Case "All"
					Plataforma = "All"
				Case "Wii"
					Plataforma = "Wii"
				Case "Wii U"
					Plataforma = "WiiU"
				Case "Nintendo Swich"
					Plataforma = "NSwich"
				Case "Nintendo 64"
					Plataforma = "N64"
				Case "GameCube"
					Plataforma = "GameCube"
				Case "Virtual Boy"
					Plataforma = "VirtualBoy"
				Case "Game Boy Advance"
					Plataforma = "GameBoyAdvance"
				Case "Snes"
					Plataforma = "SNES"
				Case "Nes"
					Plataforma = "NES"
				Case "NDS"
					Plataforma = "NDS"
				Case "3DS"
					Plataforma = "3DS"
				Case "Game Boy"
					Plataforma = "GameBoy"
				Case "Game & Watch"
					Plataforma = "G&W"
				Case "PlayStation"
					Plataforma = "PS1"
				Case "PlayStation 2"
					Plataforma = "PS2"
				Case "PlayStation 3"
					Plataforma = "PS3"
				Case "PlayStation 4"
					Plataforma = "PS4"
				Case "PSP"
					Plataforma = "PSP"
				Case "PS Vita"
					Plataforma = "PSVita"
				Case "PocketStation"
					Plataforma = "PocketStation"
				Case "Xbox"
					Plataforma = "Xbox"
				Case "Xbox 360"
					Plataforma = "Xbox360"
				Case "Xbox One"
					Plataforma = "XboxOne"
				Case "SG-1000"
					Plataforma = "SG-1000"
				Case "SC-3000"
					Plataforma = "SC-3000"
				Case "Sega Master System"
					Plataforma = "Sega-Master-System"
				Case "Sega Genesis"
					Plataforma = "Sega-Genesis"
				Case "Sega Mega CD"
					Plataforma = "Sega-Mega-CD"
				Case "Game Gear"
					Plataforma = "Game-Gear"
				Case "Sega Saturn"
					Plataforma = "Sega-Saturn"
				Case "Mega Drive 32x"
					Plataforma = "Mega-Drive-32x"
				Case "Sega Nomad"
					Plataforma = "Sega-Nomad"
				Case "Sega Model 2"
					Plataforma = "Sega-Model-2"
				Case "Sega Dreamcast"
					Plataforma = "Dreamcast"
				Case "Neo-Geo"
					Plataforma = "Neo-Geo"
				Case "Neo-Geo CD"
					Plataforma = "Neo-Geo-CD"
				Case "Pippin"
					Plataforma = "Pippin"
				Case "Atari 2600"
					Plataforma = "Atari2600"
				Case "Atari 5200"
					Plataforma = "Atari5200"
				Case "Atari 7800"
					Plataforma = "Atari7800"
				Case "Atari Jaguar"
					Plataforma = "Atari-Jaguar"
				Case "Playdia"
					Plataforma = "Playdia"
				Case "Wonderswan"
					Plataforma = "Wonderswan"
				Case "Wonderswan Color"
					Plataforma = "Wonderswan-Color"
				Case "Play System 1"
					Plataforma = "Play-System-1"
				Case "Play System 2"
					Plataforma = "Play-System-2"
				Case "Play System 3"
					Plataforma = "Play-System-3"
				Case "Casio Loopy"
					Plataforma = "Casio-Loopy"
				Case "ColecoVision"
					Plataforma = "ColecoVision"
				Case "Commodore 64GS"
					Plataforma = "Commodore64GS"
				Case "AmigaCD32"
					Plataforma = "AmigaCD32"
				Case "AmigaCD"
					Plataforma = "AmigaCD"
				Case "Fairchild Channel F"
					Plataforma = "Fairchild-Channel-F"
				Case "GP32"
					Plataforma = "GP32"
				Case "Vectrex"
					Plataforma = "Vectrex"
				Case "Magnavox Oddyssey"
					Plataforma = "Magnavox-Oddyssey"
				Case "Magnavox Oddyssey 2"
					Plataforma = "Magnavox-Oddyssey2"
				Case "Intellivision"
					Plataforma = "Intellivision"
				Case "PC Engine"
					Plataforma = "PC-Engine"
				Case "PC-FX"
					Plataforma = "PC-FX"
				Case "N-Gage"
					Plataforma = "N-Gage"
				Case "3DO"
					Plataforma = "3DO"
				Case "Videopac"
					Plataforma = "Videopac"
				Case "Philips CDi"
					Plataforma = "Philips-CDi"
				Case "RCA Studio II"
					Plataforma = "RCA-Studio-II"
				Case "V.Smile"
					Plataforma = "V-Smile"
				Case "Amstrad GX4000"
					Plataforma = "AmstradGX4000"
			End Select
		Else

		End If
#Enable Warning BC42104 ' Se usa la variable antes de que se le haya asignado un valor
		'Link_Game = ""
		myFile = saved & "\License\[" & Platform_Game & "][" & Version_Game & "][" & Region_Game & "]" & Name_Game & "." & format_License
		'myWebClient.DownloadFileAsync(New Uri(Link_Game), myFile)
		ListViewEx.StartDownload(Link_License, myFile)
		NotifyIcon1.ContextMenuStrip = ContextMenuStrip2
		NotifyIcon1.ShowBalloonTip(1000, "Download Start:    ", myFile, ToolTipIcon.None)
	End Sub
	Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
		ini.Load(Application.StartupPath & "\Config.ini")
		If CheckBox2.CheckState = 1 Then
			Button3.Visible = True
		End If
		If CheckBox2.CheckState = 0 Then
			'MsgBox("remove")
			ini.SetKeyValue("Config", "Path_Save", "Default")
			ini.Save(Application.StartupPath & "\Config.ini")
			Dir_Save_Games = "Default"
			Button3.Visible = False
		End If
	End Sub
	Private Sub Languaje_Combobox_SelectedIndexChanged(sender As Object, e As EventArgs)

	End Sub
	Private Sub Languaje_Combobox_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles Languaje_Combobox.SelectedIndexChanged

		ini.Load(Application.StartupPath & "\Config.ini")
		If Languaje_Combobox.Text = ini.GetKeyValue("Config", "Language") Then
		Else
			MsgBox("Please Reset Program")
		End If
		ini.SetKeyValue("Config", "Language", Languaje_Combobox.Text)
		ini.Save(Application.StartupPath & "\Config.ini")
		Languaje_Program = Languaje_Combobox.Text

	End Sub
	Private Sub List1_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles List1.ColumnClick
		List1.ListViewItemSorter = New ListViewItemComparer(e.Column, blnAscending)

		If blnAscending = True Then
			blnAscending = False
		Else
			blnAscending = True
		End If
	End Sub
	Private Sub ListView99_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles List1.ColumnClick
		ListView99.ListViewItemSorter = New ListViewItemComparer2(e.Column, blnAscending)
		If blnAscending = True Then
			blnAscending = False
		Else
			blnAscending = True
		End If
	End Sub
	Private Sub ListViewEx_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles List1.ColumnClick
		ListViewEx.ListViewItemSorter = New ListViewItemComparer(e.Column, blnAscending)

		If blnAscending = True Then
			blnAscending = False
		Else
			blnAscending = True
		End If
	End Sub
	Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
		Process.Start(Application.StartupPath & "\List.ini")
	End Sub
	Private Sub Encrypt_Burron_Click(sender As Object, e As EventArgs) Handles Encrypt_Burron.Click

		Clipboard.SetText(AES_Encrypt(TextBox9.Text))
		NotifyIcon1.ShowBalloonTip(1000, "Σύνταξη for games    ", "Encrypted Link", ToolTipIcon.None)
	End Sub
End Class

'
' Hola buena Persona, mi nombre es Yum, encantado de conozerte, soy un programador algo novato llevare mas o menos 1 año programando
' y me encanta, asi que encontre mi aficion favorita, si les esto, es que as descrifrazo el programa, o lo has cogido de mi git privado
' hehhe, solo queria decir que puedes modificarlo de tal manera para que sea incluso mejor..., ya que mis conozimientos son gracias
' a aprender por la red, si puede re-editar el programa y hacerlo mejor, no tendre ningun problem, pero almenos quiero que me mencionen,
' no eh estado mas de 4 meses trabajando en este proyecto para que una persona random me robe todo el proyecto, porfabor si es tan hamable
' de hacerlo.., este programa no influye en ninguna ilegaliadad (Pirateria, etc) ya que como el creador que soy, no doy ningun enlaze de 
' descarga de  ningun juego/ram/programa etc, y hacer un sofware tampoco es illegal, como los emuladores que no son ilegales, cada uno le
' da el uso que quiere..., yo doy la herramienta de hazelo mas sencillo, la feana es de los usuarios, ya que si yo subiese las roms, estaria
' inflingiendo las reglas sociales tales puesta en este 2019 por ahora, si, no sera el mejor programa del mundo si, pero es algo que nadie
' lo ah echo, porque?, porque en simple vista pareze una tonteria, pensaras que a hay webs para esto, y mi pregunta es y cunto tiempo tardas 
' en descargar aquella rom que deseas?, no es tan simple de buscar y descargar en el 90% de las vezes, incluye un wuebo de publicidad, y esta
' appno incluye publicidad, 0% de lucro puedes ver en el codigo, si, normalmente la gente que hace esas paginas lo hacen para ganar dinero,
' pero no piensan en el usuario, el pobre esta 20-100s esperando a descargar 1 rom, en la cual la empresa o empresas que suben las roms,
' no les importa, ami si que me importa, no quiero perder tiempo unitil haciendo cosas inutiles, quiero hacer la cosas en el momento,
' y aqui biene mi app, 0% publicidad, instantea, y sin limite de descarga, que todo pinta bien ahora no?, el problema es que los usuarios
' se organizen y suban juegos, como en cemu los graphicspaks, los shaders etc..., si no logran hacer eso, esta app sera inutil,
' si, puede ser ua buena app, pero sera buena si os usuarios les interesa..., are un pequeño resumen delo que es mi app:
' esta applicacion es un recopilatorio de roms, puede ser privada o publica, eso ya el consumidor, puede un usuario subir sus propias roms
' a un servidor y gracias a esta app descargarlas, sin ir al servidor y descargarlas, ese es el mayor punto fuerte, si podia tomarse como una
' app para descargar roms ilegalmente, si se puede usar para eso, pero enteria ese no es mi plan, yo me eh echo un pequeño repositorio de
' las roms que jugare y descargare de mi servidor, claro, yo la utilizare porqu no?, si, para el 99% de los usuaios lo utilizaran para descargar
' roms piratas pero ese ya no esmi probema. 
'
' Bueno muchas gracias por leer.
' 
'ATENTAMENTE: YUM :D
'
'
' APPICACION SIN COPIRIGTH HEHHE
'
'
'
' Por cierto Gracias al Control + Z , me ha salvado demasiadas vezes por gilipollezes xD
'
'
'
'
