<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
        Me.bProveedores = New System.Windows.Forms.Button()
        Me.bAceptar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tClavelog = New System.Windows.Forms.TextBox()
        Me.tUsuariolog = New System.Windows.Forms.TextBox()
        Me.pLogin = New System.Windows.Forms.Panel()
        Me.bAdministradores = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SistemaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CLIENTESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PROVEEDORESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ADMINISTRADORESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SALIRToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.bFormularioCli = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.bSalir = New System.Windows.Forms.Button()
        Me.bFormularioAdministradores = New System.Windows.Forms.Button()
        Me.bFormularioPro = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.pLogin.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'bProveedores
        '
        Me.bProveedores.BackColor = System.Drawing.Color.DodgerBlue
        Me.bProveedores.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bProveedores.ForeColor = System.Drawing.Color.White
        Me.bProveedores.Location = New System.Drawing.Point(386, 326)
        Me.bProveedores.Name = "bProveedores"
        Me.bProveedores.Size = New System.Drawing.Size(121, 29)
        Me.bProveedores.TabIndex = 1
        Me.bProveedores.Text = " PROVEEDORES"
        Me.bProveedores.UseVisualStyleBackColor = False
        '
        'bAceptar
        '
        Me.bAceptar.BackColor = System.Drawing.Color.Red
        Me.bAceptar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bAceptar.Location = New System.Drawing.Point(212, 342)
        Me.bAceptar.Name = "bAceptar"
        Me.bAceptar.Size = New System.Drawing.Size(143, 48)
        Me.bAceptar.TabIndex = 2
        Me.bAceptar.Text = "CLIENTES"
        Me.bAceptar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.OrangeRed
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(148, 264)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 23)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Usuario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.OrangeRed
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(158, 311)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 25)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Clave"
        '
        'tClavelog
        '
        Me.tClavelog.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.tClavelog.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tClavelog.Location = New System.Drawing.Point(229, 310)
        Me.tClavelog.Name = "tClavelog"
        Me.tClavelog.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tClavelog.Size = New System.Drawing.Size(126, 26)
        Me.tClavelog.TabIndex = 5
        '
        'tUsuariolog
        '
        Me.tUsuariolog.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.tUsuariolog.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tUsuariolog.Location = New System.Drawing.Point(229, 264)
        Me.tUsuariolog.Name = "tUsuariolog"
        Me.tUsuariolog.Size = New System.Drawing.Size(123, 26)
        Me.tUsuariolog.TabIndex = 6
        '
        'pLogin
        '
        Me.pLogin.BackColor = System.Drawing.Color.Transparent
        Me.pLogin.Controls.Add(Me.bAdministradores)
        Me.pLogin.Controls.Add(Me.bProveedores)
        Me.pLogin.Controls.Add(Me.tUsuariolog)
        Me.pLogin.Controls.Add(Me.Label2)
        Me.pLogin.Controls.Add(Me.tClavelog)
        Me.pLogin.Controls.Add(Me.bAceptar)
        Me.pLogin.Controls.Add(Me.Label1)
        Me.pLogin.Location = New System.Drawing.Point(111, 12)
        Me.pLogin.Name = "pLogin"
        Me.pLogin.Size = New System.Drawing.Size(581, 395)
        Me.pLogin.TabIndex = 7
        '
        'bAdministradores
        '
        Me.bAdministradores.BackColor = System.Drawing.Color.Lime
        Me.bAdministradores.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bAdministradores.ForeColor = System.Drawing.Color.White
        Me.bAdministradores.Location = New System.Drawing.Point(386, 361)
        Me.bAdministradores.Name = "bAdministradores"
        Me.bAdministradores.Size = New System.Drawing.Size(129, 29)
        Me.bAdministradores.TabIndex = 9
        Me.bAdministradores.Text = "ADMINISTRADORES"
        Me.bAdministradores.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SistemaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(718, 24)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SistemaToolStripMenuItem
        '
        Me.SistemaToolStripMenuItem.BackColor = System.Drawing.Color.Tomato
        Me.SistemaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CLIENTESToolStripMenuItem, Me.PROVEEDORESToolStripMenuItem, Me.ADMINISTRADORESToolStripMenuItem, Me.SALIRToolStripMenuItem1})
        Me.SistemaToolStripMenuItem.Name = "SistemaToolStripMenuItem"
        Me.SistemaToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.SistemaToolStripMenuItem.Text = "SISTEMA"
        '
        'CLIENTESToolStripMenuItem
        '
        Me.CLIENTESToolStripMenuItem.Name = "CLIENTESToolStripMenuItem"
        Me.CLIENTESToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.CLIENTESToolStripMenuItem.Text = "CLIENTES"
        '
        'PROVEEDORESToolStripMenuItem
        '
        Me.PROVEEDORESToolStripMenuItem.Name = "PROVEEDORESToolStripMenuItem"
        Me.PROVEEDORESToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.PROVEEDORESToolStripMenuItem.Text = "PROVEEDORES"
        '
        'ADMINISTRADORESToolStripMenuItem
        '
        Me.ADMINISTRADORESToolStripMenuItem.Name = "ADMINISTRADORESToolStripMenuItem"
        Me.ADMINISTRADORESToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.ADMINISTRADORESToolStripMenuItem.Text = "ADMINISTRADORES"
        '
        'SALIRToolStripMenuItem1
        '
        Me.SALIRToolStripMenuItem1.Name = "SALIRToolStripMenuItem1"
        Me.SALIRToolStripMenuItem1.Size = New System.Drawing.Size(179, 22)
        Me.SALIRToolStripMenuItem1.Text = "SALIR"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Yellow
        Me.Label3.Font = New System.Drawing.Font("Elephant", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(36, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 31)
        Me.Label3.TabIndex = 9
        '
        'bFormularioCli
        '
        Me.bFormularioCli.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.bFormularioCli.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bFormularioCli.ForeColor = System.Drawing.Color.Black
        Me.bFormularioCli.Location = New System.Drawing.Point(251, 206)
        Me.bFormularioCli.Name = "bFormularioCli"
        Me.bFormularioCli.Size = New System.Drawing.Size(242, 38)
        Me.bFormularioCli.TabIndex = 10
        Me.bFormularioCli.Text = "Formulario Cliente"
        Me.bFormularioCli.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.bSalir)
        Me.Panel3.Controls.Add(Me.bFormularioAdministradores)
        Me.Panel3.Controls.Add(Me.bFormularioPro)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.bFormularioCli)
        Me.Panel3.Location = New System.Drawing.Point(42, 85)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(680, 358)
        Me.Panel3.TabIndex = 11
        '
        'bSalir
        '
        Me.bSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.bSalir.Font = New System.Drawing.Font("Algerian", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bSalir.ForeColor = System.Drawing.Color.Black
        Me.bSalir.Location = New System.Drawing.Point(47, 278)
        Me.bSalir.Name = "bSalir"
        Me.bSalir.Size = New System.Drawing.Size(85, 40)
        Me.bSalir.TabIndex = 13
        Me.bSalir.Text = "SALIR"
        Me.bSalir.UseVisualStyleBackColor = False
        '
        'bFormularioAdministradores
        '
        Me.bFormularioAdministradores.BackColor = System.Drawing.Color.Lime
        Me.bFormularioAdministradores.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bFormularioAdministradores.ForeColor = System.Drawing.Color.White
        Me.bFormularioAdministradores.Location = New System.Drawing.Point(261, 311)
        Me.bFormularioAdministradores.Name = "bFormularioAdministradores"
        Me.bFormularioAdministradores.Size = New System.Drawing.Size(226, 29)
        Me.bFormularioAdministradores.TabIndex = 14
        Me.bFormularioAdministradores.Text = "FORMULARIO ADMINISTRADORES"
        Me.bFormularioAdministradores.UseVisualStyleBackColor = False
        '
        'bFormularioPro
        '
        Me.bFormularioPro.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bFormularioPro.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bFormularioPro.ForeColor = System.Drawing.Color.White
        Me.bFormularioPro.Location = New System.Drawing.Point(262, 268)
        Me.bFormularioPro.Name = "bFormularioPro"
        Me.bFormularioPro.Size = New System.Drawing.Size(225, 37)
        Me.bFormularioPro.TabIndex = 13
        Me.bFormularioPro.Text = "FORMULARIO PROVEEDORES"
        Me.bFormularioPro.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(260, 247)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(227, 18)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "**Haz Click en  Formulario**"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScrollMargin = New System.Drawing.Size(5, 5)
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.BackColor = System.Drawing.Color.SaddleBrown
        Me.BackgroundImage = Global.Proyectofinal.My.Resources.Resources.imagenPapelera
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(718, 437)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.pLogin)
        Me.Controls.Add(Me.MenuStrip1)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Sistema"
        Me.pLogin.ResumeLayout(False)
        Me.pLogin.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bProveedores As Button
    Friend WithEvents bAceptar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tClavelog As TextBox
    Friend WithEvents tUsuariolog As TextBox
    Friend WithEvents pLogin As Panel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SistemaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents bAdministradores As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents bFormularioCli As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents bFormularioPro As Button
    Friend WithEvents bFormularioAdministradores As Button
    Friend WithEvents CLIENTESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PROVEEDORESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ADMINISTRADORESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SALIRToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents bSalir As Button
End Class
