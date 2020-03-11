'
' Created by SharpDevelop.
' User: Christopher
' Date: 22/02/2019
' Time: 07:19 a. m.
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class AcercaDe
	Inherits System.Windows.Forms.Form
	
	''' <summary>
	''' Designer variable used to keep track of non-visual components.
	''' </summary>
	Private components As System.ComponentModel.IContainer
	
	''' <summary>
	''' Disposes resources used by the form.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		If disposing Then
			If components IsNot Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(disposing)
	End Sub
	
	''' <summary>
	''' This method is required for Windows Forms designer support.
	''' Do not change the method contents inside the source code editor. The Forms designer might
	''' not be able to load this method if it was changed manually.
	''' </summary>
	Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AcercaDe))
		Me.Aceptar = New System.Windows.Forms.Button()
		Me.SuspendLayout
		'
		'Aceptar
		'
		Me.Aceptar.Location = New System.Drawing.Point(370, 303)
		Me.Aceptar.Name = "Aceptar"
		Me.Aceptar.Size = New System.Drawing.Size(75, 23)
		Me.Aceptar.TabIndex = 0
		Me.Aceptar.Text = "Aceptar"
		Me.Aceptar.UseVisualStyleBackColor = true
		AddHandler Me.Aceptar.Click, AddressOf Me.AceptarClick
		'
		'AcercaDe
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"),System.Drawing.Image)
		Me.ClientSize = New System.Drawing.Size(448, 328)
		Me.ControlBox = false
		Me.Controls.Add(Me.Aceptar)
		Me.MaximizeBox = false
		Me.MinimizeBox = false
		Me.Name = "AcercaDe"
		Me.ShowIcon = false
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "AcercaDe"
		Me.ResumeLayout(false)
	End Sub
	Private Aceptar As System.Windows.Forms.Button
End Class
