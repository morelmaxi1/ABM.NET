


Imports System.IO
Imports System.Data.SqlClient


Public Class Form1

    Dim tipo As String
    Dim data As Object
    Dim ar As String
    Dim con As New SqlConnection("data source=" & CStr(leerarchivo(ar)) & "; initial catalog=Clientes; integrated security=true")

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MainMenuStrip.Visible = False

        Panel3.Visible = False

    End Sub


    Private Sub bAceptar_Click(sender As Object, e As EventArgs) Handles bAceptar.Click

        tipo = "Clientes"
        data = Loguin(tipo, tUsuariolog.Text, tClavelog.Text)
        If data Then
            pLogin.Visible = False
            MainMenuStrip.Visible = False
            Panel3.Visible = True
            bFormularioPro.Visible = False
            bFormularioAdministradores.Visible = False
            Dim da As New SqlDataAdapter("select apellidoCli from Clientes where Usuario = '" & tUsuariolog.Text & "' and Clave='" & tClavelog.Text & "'", con)
            Dim ds As New DataSet
            da.Fill(ds, "Clientes")

            Label3.Text = ("¡¡¡BIENVENIDO CLIENTE:  ") & ds.Tables("Clientes").Rows(0)("ApellidoCli") & ("!!!")
        Else
            MainMenuStrip.Visible = False
            pLogin.Visible = True
            MessageBox.Show("LOGUIN INCORRECTO")
            tUsuariolog.Text = ""
            tClavelog.Text = ""
        End If

    End Sub



    Private Sub bAdministradores_Click(sender As Object, e As EventArgs) Handles bAdministradores.Click

        tipo = "Administradores"
        data = Loguin(tipo, tUsuariolog.Text, tClavelog.Text)
        If data Then
            pLogin.Visible = False
            Panel3.Visible = True
            bFormularioPro.Visible = True
            bFormularioCli.Visible = True
            bFormularioAdministradores.Visible = True
            Dim da As New SqlDataAdapter("select apellidoAdm from Administradores where Usuario = '" & tUsuariolog.Text & "' and Clave='" & tClavelog.Text & "'", con)
            Dim ds As New DataSet
            da.Fill(ds, "Administradores")

            Label3.Text = ("¡¡¡BIENVENIDO ADMINISTRADOR: ") & ds.Tables("Administradores").Rows(0)("ApellidoAdm") & ("!!!")

            MainMenuStrip.Visible = True
            Label4.Visible = False
        Else
            MainMenuStrip.Visible = False
            pLogin.Visible = True
            MessageBox.Show("LOGUIN INCORRECTO")
            tUsuariolog.Text = ""
            tClavelog.Text = ""
        End If

    End Sub



    Private Sub bProveedores_Click(sender As Object, e As EventArgs) Handles bProveedores.Click
        tipo = "Proveedores"
        data = Loguin(tipo, tUsuariolog.Text, tClavelog.Text)
        If data Then
            pLogin.Visible = False
            Panel3.Visible = True
            bFormularioCli.Visible = False
            bFormularioAdministradores.Visible = False
            Dim da As New SqlDataAdapter("select apellidoProv from Proveedores where Usuario = '" & tUsuariolog.Text & "' and Clave='" & tClavelog.Text & "'", con)
            Dim ds As New DataSet
            da.Fill(ds, "Proveedores")

            Label3.Text = ("¡¡¡BIENVENIDO PROVEEDOR : ") & ds.Tables("Proveedores").Rows(0)("ApellidoProv") & ("!!!")


            MainMenuStrip.Visible = False

        Else
            MainMenuStrip.Visible = False
            pLogin.Visible = True
            MessageBox.Show("LOGUIN INCORRECTO")
            tUsuariolog.Text = ""
            tClavelog.Text = ""
        End If
    End Sub

    Private Sub BFormularioCli_Click(sender As Object, e As EventArgs) Handles bFormularioCli.Click
        Dim cli As New Clientes
        MainMenuStrip.Visible = False
        cli.ShowDialog()
    End Sub

    Private Sub bFormularioPro_Click(sender As Object, e As EventArgs) Handles bFormularioPro.Click
        Dim prov As New Proveedores
        MainMenuStrip.Visible = False
        prov.ShowDialog()
    End Sub

    Private Sub bFormularioAdministradores_Click(sender As Object, e As EventArgs) Handles bFormularioAdministradores.Click
        Dim adm As New Administradores
        adm.ShowDialog()
    End Sub

    Private Sub SALIRToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SALIRToolStripMenuItem1.Click
        If MessageBox.Show("Esta seguro que desea salir del sistema", "Salir del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
            Me.Close()
        Else

            Exit Sub


        End If

    End Sub

    Private Sub CLIENTESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CLIENTESToolStripMenuItem.Click
        Dim cli As New Clientes
        cli.ShowDialog()

    End Sub

    Private Sub PROVEEDORESToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles PROVEEDORESToolStripMenuItem.Click
        Dim prov As New Proveedores
        prov.ShowDialog()
    End Sub

    Private Sub ADMINISTRADORESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ADMINISTRADORESToolStripMenuItem.Click
        Dim adm As New Administradores
        adm.ShowDialog()
    End Sub


    Private Sub bSalir_Click(sender As Object, e As EventArgs) Handles bSalir.Click
        If MessageBox.Show("Esta seguro que desea salir del sistema", "Salir del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
            Me.Close()
        Else

            Exit Sub
        End If

    End Sub

End Class
