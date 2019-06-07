Imports System.Windows.Forms

Public Class Accept
	Dim ini As New IniFile
	Private color_combo As Color
	Public Sub New()
		' Esta llamada es exigida por el diseñador.
		InitializeComponent()
		Select Case Start.Color_ini
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
		' Agregue cualquier inicialización después de la llamada a InitializeComponent().

		PictureBox1.BackColor = color_combo
		OK_Button.BackColor = color_combo
		Cancel_Button.BackColor = color_combo
		CheckBox1.BackColor = color_combo
		Label1.BackColor = color_combo
		ini.Load(Application.StartupPath & "\Lang\" & Start.Languaje_Program & ".ini")
		Label1.Text = ini.GetKeyValue("LANGUAGE", "Are_you_sure_you_want_to_remove_this_file_from_the_download_list")
		Me.Text = ini.GetKeyValue("LANGUAGE", "Confirm_Delete")
		CheckBox1.Text = ini.GetKeyValue("LANGUAGE", "Also_delete_files_from_disk")
	End Sub

	Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
		Me.DialogResult = System.Windows.Forms.DialogResult.OK
		Me.Close()
	End Sub

	Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
		Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.Close()
	End Sub
End Class
