Imports System
Imports System.IO
Imports System.Net
Imports Newtonsoft.Json
Imports System.Net.Mail

Public Class Start

	Public Property Version As String = "2.4"


	Public Property Platform As String

	Dim userMsg As String


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
#Disable Warning IDE1006 ' Estilos de nombres
	Private WithEvents myWebClient As New Net.WebClient()
#Enable Warning IDE1006 ' Estilos de nombres
	Dim client As WebClient = New WebClient

	Public counter2 As Integer
	Public counter3 As Integer
	Dim counter4 As Integer
	Public platfom2 As String
	Public Name_Send As String
	Public Parts As Boolean
	Public License_Bol As Boolean
	Dim ini As New IniFile
	Private load_images_games As Boolean

	Private Sub Companya_Combo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Companya_Combo.SelectedIndexChanged
		ComboBox1.Items.Clear()
		Select Case Companya_Combo.Text
			Case "All"
#Region "All"

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

				ComboBox1.Text = "SNES"
#End Region
			Case "Nintendo"
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
				ComboBox1.Text = "Wii"
			Case "Sony"
				ComboBox1.Items.Add("PlayStation")
				ComboBox1.Items.Add("PlayStation 2")
				ComboBox1.Items.Add("PlayStation 3")
				ComboBox1.Items.Add("PlayStation 4")
				ComboBox1.Items.Add("PSP")
				ComboBox1.Items.Add("PS Vita")
				ComboBox1.Items.Add("PocketStation")
				ComboBox1.Text = "PlayStation"
			Case "Microsoft"
				ComboBox1.Items.Add("Xbox")
				ComboBox1.Items.Add("Xbox 360")
				ComboBox1.Items.Add("Xbox One")
				ComboBox1.Text = "Xbox"
			Case "Sega"
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
				ComboBox1.Text = "SG-1000"
			Case "SNK"
				ComboBox1.Items.Add("Neo-Geo")
				ComboBox1.Items.Add("Neo-Geo CD")
				ComboBox1.Text = "Neo-Geo"
			Case "Apple"
				ComboBox1.Items.Add("Pippin")
				ComboBox1.Text = "Pippin"
			Case "Atari"
				ComboBox1.Items.Add("Atari 2600")
				ComboBox1.Items.Add("Atari 5200")
				ComboBox1.Items.Add("Atari 7800")
				ComboBox1.Items.Add("Atari Jaguar")
				ComboBox1.Text = "Atari 2600"
			Case "Bandai"
				ComboBox1.Items.Add("Playdia")
				ComboBox1.Items.Add("Wonderswan")
				ComboBox1.Items.Add("Wonderswan Color")
				ComboBox1.Text = "Playdia"
			Case "Capcom"
				ComboBox1.Items.Add("Play System 1")
				ComboBox1.Items.Add("Play System 2")
				ComboBox1.Items.Add("Play System 3")
				ComboBox1.Text = "Play System 1"
			Case "Casio"
				ComboBox1.Items.Add("Casio Loopy")
				ComboBox1.Text = "Casio Loopy"
			Case "Coleco"
				ComboBox1.Items.Add("ColecoVision")
				ComboBox1.Text = "ColecoVision"
			Case "Commodore International"
				ComboBox1.Items.Add("Commodore 64GS")
				ComboBox1.Items.Add("AmigaCD32")
				ComboBox1.Items.Add("AmigaCD")
				ComboBox1.Text = "Commodore 64GS"
			Case "Fairchild Semiconductor"
				ComboBox1.Items.Add("Fairchild Channel F")
				ComboBox1.Text = "Fairchild Channel F"
			Case "Game Park"
				ComboBox1.Items.Add("GP32")
				ComboBox1.Text = "GP32"
			Case "Milton Bradley Company"
				ComboBox1.Items.Add("Vectrex")
				ComboBox1.Text = "Vectrex"
			Case "Magnavox"
				ComboBox1.Items.Add("Magnavox Oddyssey")
				ComboBox1.Items.Add("Magnavox Oddyssey 2")
				ComboBox1.Text = "Magnavox Oddyssey"
			Case "Mattel"
				ComboBox1.Items.Add("Intellivision")
				ComboBox1.Text = "Intellivision"
			Case "NEC"
				ComboBox1.Items.Add("PC Engine")
				ComboBox1.Items.Add("PC-FX")
				ComboBox1.Text = "PC Engine"
			Case "Nokia"
				ComboBox1.Items.Add("N-Gage")
				ComboBox1.Text = "N-Gage"
			Case "Panoramic"
				ComboBox1.Items.Add("3DO")
				ComboBox1.Text = "3DO"
			Case "Philips"
				ComboBox1.Items.Add("Videopac")
				ComboBox1.Items.Add("Philips CDi")
				ComboBox1.Text = "Videopac"
			Case "RCA"
				ComboBox1.Items.Add("RCA Studio II")
				ComboBox1.Text = "RCA Studio II"
			Case "V.Tech"
				ComboBox1.Items.Add("V.Smile")
				ComboBox1.Text = "V.Smile"
			Case "Amstrad"
				ComboBox1.Items.Add("Amstrad GX4000")
				ComboBox1.Text = "Amstrad GX4000"
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
#Region "Consoles"
		Platform = "SNES"
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
		List1.Columns.Add("ExistLicense", 0)
		List1.Columns.Add("LinkLicence encrypt", 0)
		List1.Columns.Add("FORMATLicence", 0)

		ListView99.Columns.Add("ID", 100)
		ListView99.Columns.Add("NAME", 300)
		ListView99.Columns.Add("TYPE", 70)
		ListView99.Columns.Add("REGION", 70)
		ListView99.Columns.Add("USER", 90)
		ListView99.Columns.Add("VERSION", 100)
		ListView99.Columns.Add("FORMAT", 100)
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
		LinkLicense_Text.Visible = False
		ID_Game.Visible = False
		Button2.Visible = False
		ListView99.Visible = False

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
		My.Computer.Network.DownloadFile("http://www.openpstore.xyz/PK-List-Games/Games-List-3DO.json", Application.StartupPath & "\List\Games-List-3DO")
		My.Computer.Network.DownloadFile("http://www.openpstore.xyz/PK-List-Games/Games-List-AmigaCD.json", Application.StartupPath & "\List\Games-List-AmigaCD")
		My.Computer.Network.DownloadFile("http://www.openpstore.xyz/PK-List-Games/Games-List-AmigaCD32.json", Application.StartupPath & "\List\Games-List-AmigaCD32")
		My.Computer.Network.DownloadFile("http://www.openpstore.xyz/PK-List-Games/Games-List-AmstradGX4000.json", Application.StartupPath & "\List\Games-List-AmstradGX4000")
		My.Computer.Network.DownloadFile("http://www.openpstore.xyz/PK-List-Games/Games-List-Atari2600.json", Application.StartupPath & "\List\Games-List-Atari2600")
		My.Computer.Network.DownloadFile("http://www.openpstore.xyz/PK-List-Games/Games-List-Atari5200.json", Application.StartupPath & "\List\Games-List-Atari5200")
		My.Computer.Network.DownloadFile("http://www.openpstore.xyz/PK-List-Games/Games-List-Atari7800.json", Application.StartupPath & "\List\Games-List-Atari7800")
		My.Computer.Network.DownloadFile("http://www.openpstore.xyz/PK-List-Games/Games-List-Atari-Jaguar.json", Application.StartupPath & "\List\Games-List-Atari-Jaguar")
		My.Computer.Network.DownloadFile("http://www.openpstore.xyz/PK-List-Games/Games-List-Casio-Loopy.json", Application.StartupPath & "\List\Games-List-Casio-Loopy")
		My.Computer.Network.DownloadFile("http://www.openpstore.xyz/PK-List-Games/Games-List-ColecoVision.json", Application.StartupPath & "\List\Games-List-ColecoVision")
		My.Computer.Network.DownloadFile("http://www.openpstore.xyz/PK-List-Games/Games-List-Commodore64GS.json", Application.StartupPath & "\List\Games-List-Commodore64GS")
		My.Computer.Network.DownloadFile("http://www.openpstore.xyz/PK-List-Games/Games-List-Dreamcast.json", Application.StartupPath & "\List\Games-List-Dreamcast")
		My.Computer.Network.DownloadFile("http://www.openpstore.xyz/PK-List-Games/Games-List-Fairchild-Channel-F.json", Application.StartupPath & "\List\Games-List-Fairchild-Channel-F")
		My.Computer.Network.DownloadFile("http://www.openpstore.xyz/PK-List-Games/Games-List-G&W.json", Application.StartupPath & "\List\Games-List-G&W")
		My.Computer.Network.DownloadFile("http://www.openpstore.xyz/PK-List-Games/Games-List-Game-Gear.json", Application.StartupPath & "\List\Games-List-Game-Gear")
		My.Computer.Network.DownloadFile("http://www.openpstore.xyz/PK-List-Games/Games-List-GP32.json", Application.StartupPath & "\List\Games-List-GP32")
		My.Computer.Network.DownloadFile("http://www.openpstore.xyz/PK-List-Games/Games-List-Intellivision.json", Application.StartupPath & "\List\Games-List-Intellivision")
		My.Computer.Network.DownloadFile("http://www.openpstore.xyz/PK-List-Games/Games-List-Magnavox-Oddyssey.json", Application.StartupPath & "\List\Games-List-Magnavox-Oddyssey")
		My.Computer.Network.DownloadFile("http://www.openpstore.xyz/PK-List-Games/Games-List-Magnavox-Oddyssey2.json", Application.StartupPath & "\List\Games-List-Magnavox-Oddyssey2")
		My.Computer.Network.DownloadFile("http://www.openpstore.xyz/PK-List-Games/Games-List-Mega-Drive-32x.json", Application.StartupPath & "\List\Games-List-Mega-Drive-32x")
		My.Computer.Network.DownloadFile("http://www.openpstore.xyz/PK-List-Games/Games-List-Neo-Geo.json", Application.StartupPath & "\List\Games-List-Neo-Geo")
		My.Computer.Network.DownloadFile("http://www.openpstore.xyz/PK-List-Games/Games-List-Neo-Geo-CD.json", Application.StartupPath & "\List\Games-List-Neo-Geo-CD")
		My.Computer.Network.DownloadFile("http://www.openpstore.xyz/PK-List-Games/Games-List-N-Gage.json", Application.StartupPath & "\List\Games-List-N-Gage")
		My.Computer.Network.DownloadFile("http://www.openpstore.xyz/PK-List-Games/Games-List-PC-Engine.json", Application.StartupPath & "\List\Games-List-PC-Engine")
		My.Computer.Network.DownloadFile("http://www.openpstore.xyz/PK-List-Games/Games-List-PC-FX.json", Application.StartupPath & "\List\Games-List-PC-FX")
		My.Computer.Network.DownloadFile("http://www.openpstore.xyz/PK-List-Games/Games-List-Philips-CDi.json", Application.StartupPath & "\List\Games-List-Philips-CDi")
		My.Computer.Network.DownloadFile("http://www.openpstore.xyz/PK-List-Games/Games-List-Pippin.json", Application.StartupPath & "\List\Games-List-Pippin")
		My.Computer.Network.DownloadFile("http://www.openpstore.xyz/PK-List-Games/Games-List-Playdia.json", Application.StartupPath & "\List\Games-List-Playdia")
		My.Computer.Network.DownloadFile("http://www.openpstore.xyz/PK-List-Games/Games-List-Play-System-1.json", Application.StartupPath & "\List\Games-List-Play-System-1")
		My.Computer.Network.DownloadFile("http://www.openpstore.xyz/PK-List-Games/Games-List-Play-System-2.json", Application.StartupPath & "\List\Games-List-Play-System-2")
		My.Computer.Network.DownloadFile("http://www.openpstore.xyz/PK-List-Games/Games-List-Play-System-3.json", Application.StartupPath & "\List\Games-List-Play-System-3")
		My.Computer.Network.DownloadFile("http://www.openpstore.xyz/PK-List-Games/Games-List-PocketStation.json", Application.StartupPath & "\List\Games-List-PocketStation")
		My.Computer.Network.DownloadFile("http://www.openpstore.xyz/PK-List-Games/Games-List-PS1.json", Application.StartupPath & "\List\Games-List-PS1")
		My.Computer.Network.DownloadFile("http://www.openpstore.xyz/PK-List-Games/Games-List-PS2.json", Application.StartupPath & "\List\Games-List-PS2")
		My.Computer.Network.DownloadFile("http://www.openpstore.xyz/PK-List-Games/Games-List-PS3.json", Application.StartupPath & "\List\Games-List-PS3")
		My.Computer.Network.DownloadFile("http://www.openpstore.xyz/PK-List-Games/Games-List-PS4.json", Application.StartupPath & "\List\Games-List-PS4")
		My.Computer.Network.DownloadFile("http://www.openpstore.xyz/PK-List-Games/Games-List-PSP.json", Application.StartupPath & "\List\Games-List-PSP")
		My.Computer.Network.DownloadFile("http://www.openpstore.xyz/PK-List-Games/Games-List-PSVita.json", Application.StartupPath & "\List\Games-List-PSVita")
		My.Computer.Network.DownloadFile("http://www.openpstore.xyz/PK-List-Games/Games-List-RCA-Studio-II.json", Application.StartupPath & "\List\Games-List-RCA-Studio-II")
		My.Computer.Network.DownloadFile("http://www.openpstore.xyz/PK-List-Games/Games-List-SC-3000.json", Application.StartupPath & "\List\Games-List-SC-3000")
		My.Computer.Network.DownloadFile("http://www.openpstore.xyz/PK-List-Games/Games-List-Sega-Genesis.json", Application.StartupPath & "\List\Games-List-Sega-Genesis")
		My.Computer.Network.DownloadFile("http://www.openpstore.xyz/PK-List-Games/Games-List-Sega-Master-System.json", Application.StartupPath & "\List\Games-List-Sega-Master-System")
		My.Computer.Network.DownloadFile("http://www.openpstore.xyz/PK-List-Games/Games-List-Sega-Mega-CD.json", Application.StartupPath & "\List\Games-List-Sega-Mega-CD")
		My.Computer.Network.DownloadFile("http://www.openpstore.xyz/PK-List-Games/Games-List-Sega-Model-2.json", Application.StartupPath & "\List\Games-List-Sega-Model-2")
		My.Computer.Network.DownloadFile("http://www.openpstore.xyz/PK-List-Games/Games-List-Sega-Nomad.json", Application.StartupPath & "\List\Games-List-Sega-Nomad")
		My.Computer.Network.DownloadFile("http://www.openpstore.xyz/PK-List-Games/Games-List-Sega-Saturn.json", Application.StartupPath & "\List\Games-List-Sega-Saturn")
		My.Computer.Network.DownloadFile("http://www.openpstore.xyz/PK-List-Games/Games-List-SG-1000.json", Application.StartupPath & "\List\Games-List-SG-1000")
		My.Computer.Network.DownloadFile("http://www.openpstore.xyz/PK-List-Games/Games-List-Vectrex.json", Application.StartupPath & "\List\Games-List-Vectrex")
		My.Computer.Network.DownloadFile("http://www.openpstore.xyz/PK-List-Games/Games-List-Videopac.json", Application.StartupPath & "\List\Games-List-Videopac")
		My.Computer.Network.DownloadFile("http://www.openpstore.xyz/PK-List-Games/Games-List-V-Smile.json", Application.StartupPath & "\List\Games-List-V-Smile")
		My.Computer.Network.DownloadFile("http://www.openpstore.xyz/PK-List-Games/Games-List-Wonderswan.json", Application.StartupPath & "\List\Games-List-Wonderswan")
		My.Computer.Network.DownloadFile("http://www.openpstore.xyz/PK-List-Games/Games-List-Wonderswan-Color.json", Application.StartupPath & "\List\Games-List-Wonderswan-Color")
		My.Computer.Network.DownloadFile("http://www.openpstore.xyz/PK-List-Games/Games-List-Xbox.json", Application.StartupPath & "\List\Games-List-Xbox")
		My.Computer.Network.DownloadFile("http://www.openpstore.xyz/PK-List-Games/Games-List-Xbox360.json", Application.StartupPath & "\List\Games-List-Xbox360")
		My.Computer.Network.DownloadFile("http://www.openpstore.xyz/PK-List-Games/Games-List-XboxOne.json", Application.StartupPath & "\List\Games-List-XboxOne")
#End Region

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
																List1.Items(counter).SubItems.Add(Game(pos).LicenseExist)
																List1.Items(counter).SubItems.Add(Game(pos).LinkLisense)
																List1.Items(counter).SubItems.Add(Game(pos).FormatLisense)
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

	End Sub

	Private Sub List1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles List1.SelectedIndexChanged

		Dim Lisense As Boolean = False

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
		Lisense = List1.Items.Item(List1.FocusedItem.Index).SubItems(13).Text
		Link_License = List1.Items.Item(List1.FocusedItem.Index).SubItems(14).Text
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
																If CheckBox3.CheckState = False Then
																	Send(ComboBox4.Text, "0", ComboBox2.Text,
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
																					Send(ComboBox4.Text, "0", ComboBox2.Text,
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
																			Send(ComboBox4.Text, ID_Game.Text, ComboBox2.Text,
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
																							Send(ComboBox4.Text, ID_Game.Text, ComboBox2.Text,
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
		Dim check As Integer = FindItem(List1, TextBox1.Text)

		If TextBox1.Text = "" Then
			ListView99.Visible = False
			counter4 = 0
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
	End Sub
	Private Sub Send(Platform_Send As String, ID_Send As String, Type_Send As String, Name_Send As String, Region_Send As String,
					 User_Send As String, Version_Send As String, Format_Send As String, Image_Send As String, Parts_Send As Boolean,
					 Encrypt_Send As String, NumberParts_Send As String, LicenseExist_Send As Boolean, LinkLisense_Send As String,
					 FormatLisense_Send As String)

		Dim Encrypt_Split As String()
		Dim Encrypt_Array As New List(Of String)
		Encrypt_Split = Encrypt_Send.Split(New String() {Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries)
		'MsgBox(Encrypt_Split(0))
		'MsgBox(Encrypt_Split.Length)
		For Other As Integer = 1 To Encrypt_Split.Length
			MsgBox(Other)
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

			Dim Smtp_Server As New SmtpClient
			Dim e_mail As New MailMessage()
			'Dim attachment As System.Net.Mail.Attachment

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
			e_mail.Subject = "[" & Platform_Send & "]" & Name_Send
			e_mail.IsBodyHtml = False 'cannot be read
			e_mail.Body = output


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

	Private Sub ListView1_DoubleClick(sender As Object, e As EventArgs)
		'ListView1.Items.RemoveAt(ListView1.FocusedItem.Index)
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

	Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) 

	End Sub

	Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
		If CheckBox3.CheckState = 1 Then
			CheckBox3.Text = "The Game is licensed? True"
			LinkLicense_Text.Visible = True
			License_Bol = True
		End If
		If CheckBox3.CheckState = False Then
			CheckBox3.Text = "The Game is licensed? False"
			LinkLicense_Text.Visible = False
			License_Bol = False
		End If
	End Sub

	Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
		My.Computer.Network.DownloadFile(AES_Encrypt(Link_License), Application.StartupPath & "\License\[" & List1.Items.Item(List1.FocusedItem.Index).SubItems(2).Text & "][" & List1.Items.Item(List1.FocusedItem.Index).SubItems(3).Text & "]" & List1.Items.Item(List1.FocusedItem.Index).SubItems(1).Text & "." & format_License)
	End Sub

	Private Sub Name_Game_Label_Click(sender As Object, e As EventArgs) Handles Name_Game_Label.Click

	End Sub

	Private Sub Region_label_Click(sender As Object, e As EventArgs) Handles Region_label.Click

	End Sub

	Private Sub Upload_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Upload.SelectedIndexChanged

	End Sub
End Class