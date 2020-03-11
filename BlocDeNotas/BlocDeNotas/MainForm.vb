'
' Created by SharpDevelop.
' User: Christopher
' Date: 21/02/2019
' Time: 09:18 a. m.
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Public Partial Class MainForm
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'
	End Sub
	


	
	Sub AjusteDeToolStripMenuItemClick(sender As Object, e As EventArgs)
'		hace el ajuste de linea y desaparece la barra horizontal si esta seleccionado 
		textBoxEditor.WordWrap = ajustedelinea.Checked	
	
	End Sub
	
	
	Sub BarraDeEstadoToolStripMenuItemClick(sender As Object, e As EventArgs)
'		si esta seleccionada la bara de estado
If barraDeEstadoToolStripMenuItem.Checked =  True Then
'	es vsisible el status strip "pagina 1"
statusStrip1.Visible = True 
'reducimos el tamano del texboxteditor
textBoxEditor.Height -= 22
'si no esta seleccionada la barra de estado
ElseIf barraDeEstadoToolStripMenuItem.Checked =  False
	'hacemos invisible el status strip 1 'pagina 1'
	statusStrip1.visible = False
	'aumentamos el tamano  del texboxteditor
			textBoxEditor.Height += 22
		End If
			
	End Sub
	
	Sub AcercaDeBlocDeNotasToolStripMenuItemClick(sender As Object, e As EventArgs)
		
		Dim ventana As Form1
		ventana = New form1()
		
	    ventana.ShowDialog
	End Sub
'	
'	Sub FontDialog1Apply(sender As Object, e As EventArgs)
'		
'	End Sub
	
	Sub FuenteToolStripMenuItemClick(sender As Object, e As EventArgs)
		fontDialog1.ShowDialog
		textBoxEditor.Font = fontDialog1.Font
	End Sub
	
	Sub ColorToolStripMenuItemClick(sender As Object, e As EventArgs)
		colorDialog1.ShowDialog
		textBoxEditor.Forecolor = colorDialog1.Color
	End Sub
	
	Sub NuevoToolStripMenuItemClick(sender As Object, e As EventArgs)
textBoxEditor.Text = ""		
	End Sub
	
	Sub AbrirToolStripMenuItemClick(sender As Object, e As EventArgs)
		Dim Resultado As DialogResult
		
		Resultado = openFileDialog1.ShowDialog
		
		If Resultado = DialogResult.OK Then
		Dim ruta As String
		ruta = openFileDialog1.FileName
		textBoxEditor.Text = System.IO.File.ReadAllText(ruta)
			End If
	End Sub
	
	Sub GuardarComoToolStripMenuItemClick(sender As Object, e As EventArgs)
		Dim resultado As DialogResult
		resultado = saveFileDialog1.ShowDialog
		If resultado =DialogResult.OK Then
			Dim ruta As String
			ruta = saveFileDialog1.FileName
			System.IO.File.WriteAllText(ruta,textBoxEditor.text)
		End If
	End Sub
	
	Sub ArchivoToolStripMenuItemClick(sender As Object, e As EventArgs)
		
	End Sub
End Class
