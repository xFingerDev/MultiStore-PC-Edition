Public Class Inicio
	Private Sub ToolTip1_Popup(sender As Object, e As PopupEventArgs)

	End Sub

	Private Sub Label1_Click(sender As Object, e As EventArgs) Handles KBS.Click

	End Sub

	Private Sub Inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Game_Selector.Items.Add("All")
		Game_Selector.Items.Add("Wii")
		Game_Selector.Items.Add("Wii U")
		Game_Selector.Items.Add("Nintendo Swich")
		Game_Selector.Items.Add("Nintendo 64")
		Game_Selector.Items.Add("GameCube")
		Game_Selector.Items.Add("Snes")
		Game_Selector.Items.Add("Nes")
		Game_Selector.Items.Add("NDS")
		Game_Selector.Items.Add("3DS")
		Game_Selector.Items.Add("Game Boy")
		Game_Selector.Items.Add("Game Boy Advance")
		Game_Selector.Items.Add("Virtual Boy")
	End Sub

	Private Sub CreateFiles()
		MsgBox("The application path is :" & Application.StartupPath)
		'Screen.MousePointer = vbHourglass
	End Sub
End Class