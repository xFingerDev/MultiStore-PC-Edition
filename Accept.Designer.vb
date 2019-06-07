<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Accept
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
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Me.OK_Button = New System.Windows.Forms.Button()
		Me.Cancel_Button = New System.Windows.Forms.Button()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.CheckBox1 = New System.Windows.Forms.CheckBox()
		Me.Label1 = New System.Windows.Forms.Label()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'OK_Button
		'
		Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
		Me.OK_Button.BackColor = System.Drawing.Color.DimGray
		Me.OK_Button.DialogResult = System.Windows.Forms.DialogResult.OK
		Me.OK_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.OK_Button.Location = New System.Drawing.Point(12, 77)
		Me.OK_Button.Name = "OK_Button"
		Me.OK_Button.Size = New System.Drawing.Size(166, 35)
		Me.OK_Button.TabIndex = 0
		Me.OK_Button.Text = "Aceptar"
		Me.OK_Button.UseVisualStyleBackColor = False
		'
		'Cancel_Button
		'
		Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
		Me.Cancel_Button.BackColor = System.Drawing.Color.DimGray
		Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.Cancel_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Cancel_Button.Location = New System.Drawing.Point(184, 77)
		Me.Cancel_Button.Name = "Cancel_Button"
		Me.Cancel_Button.Size = New System.Drawing.Size(166, 35)
		Me.Cancel_Button.TabIndex = 1
		Me.Cancel_Button.Text = "Cancelar"
		Me.Cancel_Button.UseVisualStyleBackColor = False
		'
		'PictureBox1
		'
		Me.PictureBox1.BackColor = System.Drawing.Color.DimGray
		Me.PictureBox1.Location = New System.Drawing.Point(-5, -1)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(454, 201)
		Me.PictureBox1.TabIndex = 2
		Me.PictureBox1.TabStop = False
		'
		'CheckBox1
		'
		Me.CheckBox1.AutoSize = True
		Me.CheckBox1.BackColor = System.Drawing.Color.DimGray
		Me.CheckBox1.Location = New System.Drawing.Point(37, 41)
		Me.CheckBox1.Name = "CheckBox1"
		Me.CheckBox1.Size = New System.Drawing.Size(144, 17)
		Me.CheckBox1.TabIndex = 3
		Me.CheckBox1.Text = "Also delete files from disk"
		Me.CheckBox1.UseVisualStyleBackColor = False
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.BackColor = System.Drawing.Color.DimGray
		Me.Label1.Location = New System.Drawing.Point(9, 9)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(308, 13)
		Me.Label1.TabIndex = 4
		Me.Label1.Text = "Are you sure you want to remove this file from the download list?"
		'
		'Accept
		'
		Me.AcceptButton = Me.OK_Button
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.CancelButton = Me.Cancel_Button
		Me.ClientSize = New System.Drawing.Size(361, 116)
		Me.ControlBox = False
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.CheckBox1)
		Me.Controls.Add(Me.Cancel_Button)
		Me.Controls.Add(Me.OK_Button)
		Me.Controls.Add(Me.PictureBox1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "Accept"
		Me.ShowInTaskbar = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
		Me.Text = "Accept"
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents Cancel_Button As System.Windows.Forms.Button
	Friend WithEvents PictureBox1 As PictureBox
	Friend WithEvents CheckBox1 As CheckBox
	Friend WithEvents Label1 As Label
	Friend WithEvents OK_Button As Button
End Class
