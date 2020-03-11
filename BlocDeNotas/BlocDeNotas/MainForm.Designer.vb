'
' Created by SharpDevelop.
' User: Christopher
' Date: 21/02/2019
' Time: 09:18 a. m.
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class MainForm
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
		Me.menuStrip1 = New System.Windows.Forms.MenuStrip()
		Me.archivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.nuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.abrirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.guardarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.guardarComoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.toolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
		Me.configurarPaginaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.imprimirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.salirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.edicionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.deshacerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.toolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
		Me.cortarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.copiarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.pegarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.eliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.toolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
		Me.buscarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.buscarSiguienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.reemplazarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.irAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.toolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator()
		Me.seleccionarTodoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.horaYFechaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.formatoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ajustedelinea = New System.Windows.Forms.ToolStripMenuItem()
		Me.fuenteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.colorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.verToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.barraDeEstadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ayudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.verAyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.toolStripMenuItem5 = New System.Windows.Forms.ToolStripSeparator()
		Me.acercaDeBlocDeNotasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.statusStrip1 = New System.Windows.Forms.StatusStrip()
		Me.toolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
		Me.textBoxEditor = New System.Windows.Forms.TextBox()
		Me.fontDialog1 = New System.Windows.Forms.FontDialog()
		Me.colorDialog1 = New System.Windows.Forms.ColorDialog()
		Me.openFileDialog1 = New System.Windows.Forms.OpenFileDialog()
		Me.saveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
		Me.menuStrip1.SuspendLayout
		Me.statusStrip1.SuspendLayout
		Me.SuspendLayout
		'
		'menuStrip1
		'
		Me.menuStrip1.BackColor = System.Drawing.Color.White
		Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.archivoToolStripMenuItem, Me.edicionToolStripMenuItem, Me.formatoToolStripMenuItem, Me.verToolStripMenuItem, Me.ayudaToolStripMenuItem})
		Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
		Me.menuStrip1.Name = "menuStrip1"
		Me.menuStrip1.Size = New System.Drawing.Size(755, 24)
		Me.menuStrip1.TabIndex = 0
		Me.menuStrip1.Text = "menuStrip1"
		'
		'archivoToolStripMenuItem
		'
		Me.archivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.nuevoToolStripMenuItem, Me.abrirToolStripMenuItem, Me.guardarToolStripMenuItem, Me.guardarComoToolStripMenuItem, Me.toolStripMenuItem1, Me.configurarPaginaToolStripMenuItem, Me.imprimirToolStripMenuItem, Me.salirToolStripMenuItem})
		Me.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem"
		Me.archivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
		Me.archivoToolStripMenuItem.Text = "&Archivo"
		AddHandler Me.archivoToolStripMenuItem.Click, AddressOf Me.ArchivoToolStripMenuItemClick
		'
		'nuevoToolStripMenuItem
		'
		Me.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem"
		Me.nuevoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N),System.Windows.Forms.Keys)
		Me.nuevoToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
		Me.nuevoToolStripMenuItem.Text = "Nuevo"
		AddHandler Me.nuevoToolStripMenuItem.Click, AddressOf Me.NuevoToolStripMenuItemClick
		'
		'abrirToolStripMenuItem
		'
		Me.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem"
		Me.abrirToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A),System.Windows.Forms.Keys)
		Me.abrirToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
		Me.abrirToolStripMenuItem.Text = "Abrir..."
		AddHandler Me.abrirToolStripMenuItem.Click, AddressOf Me.AbrirToolStripMenuItemClick
		'
		'guardarToolStripMenuItem
		'
		Me.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem"
		Me.guardarToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G),System.Windows.Forms.Keys)
		Me.guardarToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
		Me.guardarToolStripMenuItem.Text = "Guardar"
		'
		'guardarComoToolStripMenuItem
		'
		Me.guardarComoToolStripMenuItem.Name = "guardarComoToolStripMenuItem"
		Me.guardarComoToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
		Me.guardarComoToolStripMenuItem.Text = "Guardar como..."
		AddHandler Me.guardarComoToolStripMenuItem.Click, AddressOf Me.GuardarComoToolStripMenuItemClick
		'
		'toolStripMenuItem1
		'
		Me.toolStripMenuItem1.Name = "toolStripMenuItem1"
		Me.toolStripMenuItem1.Size = New System.Drawing.Size(176, 6)
		'
		'configurarPaginaToolStripMenuItem
		'
		Me.configurarPaginaToolStripMenuItem.Name = "configurarPaginaToolStripMenuItem"
		Me.configurarPaginaToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
		Me.configurarPaginaToolStripMenuItem.Text = "Configurar pagina..."
		'
		'imprimirToolStripMenuItem
		'
		Me.imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem"
		Me.imprimirToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P),System.Windows.Forms.Keys)
		Me.imprimirToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
		Me.imprimirToolStripMenuItem.Text = "Imprimir..."
		'
		'salirToolStripMenuItem
		'
		Me.salirToolStripMenuItem.Name = "salirToolStripMenuItem"
		Me.salirToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
		Me.salirToolStripMenuItem.Text = "Salir"
		'
		'edicionToolStripMenuItem
		'
		Me.edicionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.deshacerToolStripMenuItem, Me.toolStripMenuItem2, Me.cortarToolStripMenuItem, Me.copiarToolStripMenuItem, Me.pegarToolStripMenuItem, Me.eliminarToolStripMenuItem, Me.toolStripMenuItem3, Me.buscarToolStripMenuItem, Me.buscarSiguienteToolStripMenuItem, Me.reemplazarToolStripMenuItem, Me.irAToolStripMenuItem, Me.toolStripMenuItem4, Me.seleccionarTodoToolStripMenuItem, Me.horaYFechaToolStripMenuItem})
		Me.edicionToolStripMenuItem.Name = "edicionToolStripMenuItem"
		Me.edicionToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
		Me.edicionToolStripMenuItem.Text = "&Edicion"
		'
		'deshacerToolStripMenuItem
		'
		Me.deshacerToolStripMenuItem.Name = "deshacerToolStripMenuItem"
		Me.deshacerToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z),System.Windows.Forms.Keys)
		Me.deshacerToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
		Me.deshacerToolStripMenuItem.Text = "Deshacer"
		'
		'toolStripMenuItem2
		'
		Me.toolStripMenuItem2.Name = "toolStripMenuItem2"
		Me.toolStripMenuItem2.Size = New System.Drawing.Size(199, 6)
		'
		'cortarToolStripMenuItem
		'
		Me.cortarToolStripMenuItem.Name = "cortarToolStripMenuItem"
		Me.cortarToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X),System.Windows.Forms.Keys)
		Me.cortarToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
		Me.cortarToolStripMenuItem.Text = "Cortar"
		'
		'copiarToolStripMenuItem
		'
		Me.copiarToolStripMenuItem.Name = "copiarToolStripMenuItem"
		Me.copiarToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C),System.Windows.Forms.Keys)
		Me.copiarToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
		Me.copiarToolStripMenuItem.Text = "Copiar"
		'
		'pegarToolStripMenuItem
		'
		Me.pegarToolStripMenuItem.Name = "pegarToolStripMenuItem"
		Me.pegarToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V),System.Windows.Forms.Keys)
		Me.pegarToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
		Me.pegarToolStripMenuItem.Text = "Pegar"
		'
		'eliminarToolStripMenuItem
		'
		Me.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem"
		Me.eliminarToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete
		Me.eliminarToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
		Me.eliminarToolStripMenuItem.Text = "Eliminar"
		'
		'toolStripMenuItem3
		'
		Me.toolStripMenuItem3.Name = "toolStripMenuItem3"
		Me.toolStripMenuItem3.Size = New System.Drawing.Size(199, 6)
		'
		'buscarToolStripMenuItem
		'
		Me.buscarToolStripMenuItem.Name = "buscarToolStripMenuItem"
		Me.buscarToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.B),System.Windows.Forms.Keys)
		Me.buscarToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
		Me.buscarToolStripMenuItem.Text = "Buscar..."
		'
		'buscarSiguienteToolStripMenuItem
		'
		Me.buscarSiguienteToolStripMenuItem.Name = "buscarSiguienteToolStripMenuItem"
		Me.buscarSiguienteToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3
		Me.buscarSiguienteToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
		Me.buscarSiguienteToolStripMenuItem.Text = "Buscar siguiente"
		'
		'reemplazarToolStripMenuItem
		'
		Me.reemplazarToolStripMenuItem.Name = "reemplazarToolStripMenuItem"
		Me.reemplazarToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R),System.Windows.Forms.Keys)
		Me.reemplazarToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
		Me.reemplazarToolStripMenuItem.Text = "Reemplazar..."
		'
		'irAToolStripMenuItem
		'
		Me.irAToolStripMenuItem.Name = "irAToolStripMenuItem"
		Me.irAToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.T),System.Windows.Forms.Keys)
		Me.irAToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
		Me.irAToolStripMenuItem.Text = "Ir a..."
		'
		'toolStripMenuItem4
		'
		Me.toolStripMenuItem4.Name = "toolStripMenuItem4"
		Me.toolStripMenuItem4.Size = New System.Drawing.Size(199, 6)
		'
		'seleccionarTodoToolStripMenuItem
		'
		Me.seleccionarTodoToolStripMenuItem.Name = "seleccionarTodoToolStripMenuItem"
		Me.seleccionarTodoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E),System.Windows.Forms.Keys)
		Me.seleccionarTodoToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
		Me.seleccionarTodoToolStripMenuItem.Text = "Seleccionar todo"
		'
		'horaYFechaToolStripMenuItem
		'
		Me.horaYFechaToolStripMenuItem.Name = "horaYFechaToolStripMenuItem"
		Me.horaYFechaToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5
		Me.horaYFechaToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
		Me.horaYFechaToolStripMenuItem.Text = "Hora y fecha"
		'
		'formatoToolStripMenuItem
		'
		Me.formatoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ajustedelinea, Me.fuenteToolStripMenuItem, Me.colorToolStripMenuItem})
		Me.formatoToolStripMenuItem.Name = "formatoToolStripMenuItem"
		Me.formatoToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
		Me.formatoToolStripMenuItem.Text = "F&ormato"
		'
		'ajustedelinea
		'
		Me.ajustedelinea.CheckOnClick = true
		Me.ajustedelinea.Name = "ajustedelinea"
		Me.ajustedelinea.Size = New System.Drawing.Size(151, 22)
		Me.ajustedelinea.Text = "Ajuste de linea"
		AddHandler Me.ajustedelinea.Click, AddressOf Me.AjusteDeToolStripMenuItemClick
		'
		'fuenteToolStripMenuItem
		'
		Me.fuenteToolStripMenuItem.Name = "fuenteToolStripMenuItem"
		Me.fuenteToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
		Me.fuenteToolStripMenuItem.Text = "Fuente..."
		AddHandler Me.fuenteToolStripMenuItem.Click, AddressOf Me.FuenteToolStripMenuItemClick
		'
		'colorToolStripMenuItem
		'
		Me.colorToolStripMenuItem.Name = "colorToolStripMenuItem"
		Me.colorToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
		Me.colorToolStripMenuItem.Text = "Color..."
		AddHandler Me.colorToolStripMenuItem.Click, AddressOf Me.ColorToolStripMenuItemClick
		'
		'verToolStripMenuItem
		'
		Me.verToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.barraDeEstadoToolStripMenuItem})
		Me.verToolStripMenuItem.Name = "verToolStripMenuItem"
		Me.verToolStripMenuItem.Size = New System.Drawing.Size(35, 20)
		Me.verToolStripMenuItem.Text = "&Ver"
		'
		'barraDeEstadoToolStripMenuItem
		'
		Me.barraDeEstadoToolStripMenuItem.Checked = true
		Me.barraDeEstadoToolStripMenuItem.CheckOnClick = true
		Me.barraDeEstadoToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
		Me.barraDeEstadoToolStripMenuItem.Name = "barraDeEstadoToolStripMenuItem"
		Me.barraDeEstadoToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
		Me.barraDeEstadoToolStripMenuItem.Text = "Barra de estado"
		AddHandler Me.barraDeEstadoToolStripMenuItem.Click, AddressOf Me.BarraDeEstadoToolStripMenuItemClick
		'
		'ayudaToolStripMenuItem
		'
		Me.ayudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.verAyudaToolStripMenuItem, Me.toolStripMenuItem5, Me.acercaDeBlocDeNotasToolStripMenuItem})
		Me.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem"
		Me.ayudaToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
		Me.ayudaToolStripMenuItem.Text = "Ay&uda"
		'
		'verAyudaToolStripMenuItem
		'
		Me.verAyudaToolStripMenuItem.Name = "verAyudaToolStripMenuItem"
		Me.verAyudaToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
		Me.verAyudaToolStripMenuItem.Text = "Ver la ayuda"
		'
		'toolStripMenuItem5
		'
		Me.toolStripMenuItem5.Name = "toolStripMenuItem5"
		Me.toolStripMenuItem5.Size = New System.Drawing.Size(197, 6)
		'
		'acercaDeBlocDeNotasToolStripMenuItem
		'
		Me.acercaDeBlocDeNotasToolStripMenuItem.Name = "acercaDeBlocDeNotasToolStripMenuItem"
		Me.acercaDeBlocDeNotasToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
		Me.acercaDeBlocDeNotasToolStripMenuItem.Text = "Acerca de Bloc de notas"
		AddHandler Me.acercaDeBlocDeNotasToolStripMenuItem.Click, AddressOf Me.AcercaDeBlocDeNotasToolStripMenuItemClick
		'
		'statusStrip1
		'
		Me.statusStrip1.BackColor = System.Drawing.Color.White
		Me.statusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripStatusLabel1})
		Me.statusStrip1.Location = New System.Drawing.Point(0, 351)
		Me.statusStrip1.Name = "statusStrip1"
		Me.statusStrip1.Size = New System.Drawing.Size(755, 22)
		Me.statusStrip1.TabIndex = 1
		Me.statusStrip1.Text = "statusStrip1"
		'
		'toolStripStatusLabel1
		'
		Me.toolStripStatusLabel1.Name = "toolStripStatusLabel1"
		Me.toolStripStatusLabel1.Size = New System.Drawing.Size(52, 17)
		Me.toolStripStatusLabel1.Text = "Pagina 1"
		'
		'textBoxEditor
		'
		Me.textBoxEditor.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
						Or System.Windows.Forms.AnchorStyles.Left)  _
						Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
		Me.textBoxEditor.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.textBoxEditor.ForeColor = System.Drawing.SystemColors.MenuText
		Me.textBoxEditor.Location = New System.Drawing.Point(0, 27)
		Me.textBoxEditor.Multiline = true
		Me.textBoxEditor.Name = "textBoxEditor"
		Me.textBoxEditor.ScrollBars = System.Windows.Forms.ScrollBars.Both
		Me.textBoxEditor.Size = New System.Drawing.Size(755, 321)
		Me.textBoxEditor.TabIndex = 2
		Me.textBoxEditor.WordWrap = false
		'
		'openFileDialog1
		'
		Me.openFileDialog1.DefaultExt = "txt"
		Me.openFileDialog1.Filter = "Archivos de texto|*.txt|Todos los archivos|*.*"
		'
		'saveFileDialog1
		'
		Me.saveFileDialog1.DefaultExt = "txt"
		Me.saveFileDialog1.Filter = "Archivo txt|*.txt"
		'
		'MainForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
		Me.ClientSize = New System.Drawing.Size(755, 373)
		Me.Controls.Add(Me.textBoxEditor)
		Me.Controls.Add(Me.statusStrip1)
		Me.Controls.Add(Me.menuStrip1)
		Me.MainMenuStrip = Me.menuStrip1
		Me.Name = "MainForm"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "BlocDeNotas"
		Me.menuStrip1.ResumeLayout(false)
		Me.menuStrip1.PerformLayout
		Me.statusStrip1.ResumeLayout(false)
		Me.statusStrip1.PerformLayout
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private saveFileDialog1 As System.Windows.Forms.SaveFileDialog
	Private openFileDialog1 As System.Windows.Forms.OpenFileDialog
	Private colorDialog1 As System.Windows.Forms.ColorDialog
	Private fontDialog1 As System.Windows.Forms.FontDialog
	Private textBoxEditor As System.Windows.Forms.TextBox
	Private toolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
	Private statusStrip1 As System.Windows.Forms.StatusStrip
	Private colorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private acercaDeBlocDeNotasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private toolStripMenuItem5 As System.Windows.Forms.ToolStripSeparator
	Private verAyudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private ayudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private barraDeEstadoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private verToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private fuenteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private ajustedelinea As System.Windows.Forms.ToolStripMenuItem
	Private formatoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private horaYFechaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private seleccionarTodoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private toolStripMenuItem4 As System.Windows.Forms.ToolStripSeparator
	Private irAToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private reemplazarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private buscarSiguienteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private buscarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private toolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
	Private eliminarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private pegarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private copiarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private cortarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private toolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
	Private deshacerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private edicionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private salirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private imprimirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private configurarPaginaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private toolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
	Private guardarComoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private guardarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private abrirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private nuevoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private archivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private menuStrip1 As System.Windows.Forms.MenuStrip
End Class
