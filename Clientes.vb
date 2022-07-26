


Imports System.IO
Imports System.Data.SqlClient




Public Class Clientes


    Dim ar As String
    Dim con As New SqlConnection("data source=" & CStr(leerarchivo(ar)) & "; initial catalog=Clientes; integrated security=true")
    Function leerarchivo(ByVal archivo As String) As String
        If File.Exists("c:\ABM\ip.txt") = True Then
            Dim SR As StreamReader = File.OpenText("c:\ABM\ip.txt")
            Dim Line As String = SR.ReadLine()
            SR.Close()
            Return Line
        Else
            MsgBox("Verifique Falta Archivo de Configuracion")
            Me.Close()
        End If
    End Function

    Private Sub Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        buscar(" apeynom like '" & tApellido.Text & "%' ")
    End Sub

    Sub buscar(ByVal condicion As String)

        Dim da As New SqlDataAdapter("SELECT TOP (100) PERCENT ncli,apeynom from Clientes_búsqueda where " & condicion & " order by apeynom", con)
        Dim ds As New DataSet
        da.Fill(ds, "Clientes")
        If ds.Tables("Clientes").Rows.Count = 0 Then

            DataGridView1.Visible = False

            pBotones.Visible = False
            pCampos.Visible = False
            lLegajo.Visible = False
        Else

            DataGridView1.DataSource = ds.Tables("Clientes")
            DataGridView1.Refresh()
            DataGridView1.Visible = True

            lLegajo.Visible = True
        End If

    End Sub

    Private Sub DataGridView1_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        FilaClick(e)
    End Sub

    Sub FilaClick(ByVal e As Object)
        Dim fila As Integer = e.RowIndex
        Dim tfila As String

        If IsNothing(DataGridView1.Rows(fila).Cells(0).Value) Then
            lLegajo.Text = "0"
            pBotones.Visible = False
            pCampos.Visible = False
            Exit Sub
        Else
            tfila = DataGridView1.Rows(fila).Cells(0).Value
            lLegajo.Text = tfila.ToString()
            CargarCamposClientes()
        End If

    End Sub



    Private Sub DataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        FilaClick(e)
    End Sub


    Sub CargarCamposClientes()
        If Val(lLegajo.Text) = 0 Then
            pBotones.Visible = False
            pCampos.Visible = False

            Exit Sub
        Else
            pBotones.Visible = True
            pCampos.Visible = True
            Dim da As New SqlDataAdapter("SELECT  upper(ltrim(rtrim(isnull(apellidoCli,'****')))) as apellido, upper(ltrim(rtrim(isnull(nombreCli,'****')))) as nombres,isnull([documento-Cli],0) as doc,isnull([CUIT-Cli],0) as CUIT,upper(ltrim(rtrim(isnull([Usuario],'****')))) as Usuario,upper(ltrim(rtrim(isnull([clave],'****')))) as Clave, ltrim(rtrim(isnull(DomicilioCli,''))) as dirección,ltrim(rtrim(isnull(localidadCli,''))) as Localidad,ltrim(rtrim(isnull(provinciaCli,''))) as provincia,ltrim(rtrim(isnull(teléfonosCli,''))) as teléfonos,FechanacimientoCli as fechanacimiento,ltrim(rtrim(isnull(comentariosCli,''))) as comentarios,ltrim(rtrim(isnull([E-Mail-Cli],''))) as email, isnull(estado,0) as Estado  from Clientes where nCli=" & Val(lLegajo.Text), con)
            Dim ds As New DataSet
            da.Fill(ds, "Clientes")
            TextBox1.Text = ds.Tables("Clientes").Rows(0)("apellido")
            TextBox2.Text = ds.Tables("Clientes").Rows(0)("nombres")
            TextBox3.Text = ds.Tables("Clientes").Rows(0)("doc")
            TCuit.Text = ds.Tables("Clientes").Rows(0)("CUIT")
            tUsuario.Text = ds.Tables("Clientes").Rows(0)("Usuario")
            tClave.Text = ds.Tables("Clientes").Rows(0)("Clave")
            TextBox4.Text = ds.Tables("Clientes").Rows(0)("Dirección")
            TextBox5.Text = ds.Tables("Clientes").Rows(0)("Localidad")
            TextBox8.Text = ds.Tables("Clientes").Rows(0)("provincia")
            TextBox6.Text = ds.Tables("Clientes").Rows(0)("teléfonos")
            TextBox7.Text = ds.Tables("Clientes").Rows(0)("email")
            CheckBox1.Checked = IIf(ds.Tables("Clientes").Rows(0)("estado") = 0, False, True)


            TextBox12.Text = ds.Tables("Clientes").Rows(0)("comentarios")

            DateTimePicker1.Value = ds.Tables("Clientes").Rows(0)("fechanacimiento")
        End If
    End Sub



    Private Sub PictureBox8_Click(sender As Object, e As EventArgs)
        tApellido.Text = ""
        buscar(" apeynom like '" & tApellido.Text & "%' ")
    End Sub




    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        If MessageBox.Show("Está por ELIMINAR definitivamente al CLIENTE: " & TextBox1.Text.Trim.ToUpper & ", " & TextBox12.Text.Trim.ToUpper & ". Es algo EXTREMO, porque todos los cursos que lo tienen desde el 2005 perderán las referencias. Está SEGURO?", "Eliminar Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub

        If SQL_Accion("delete from Clientes  where  NCli=" & Val(lLegajo.Text)) = False Then
            MsgBox("Hubo un error al intentar borrar al Cliente, reintente, y si el error persiste, anote todos los datos que quizo ingresar y comuníquese con el programador.")
        Else

            buscar(" NCli=" & Val(lLegajo.Text))
            MsgBox("El Cliente fue ELIMINADO de la base de datos.")

        End If
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Dim errores As String = "", en As String = vbCrLf
        If TextBox1.Text.Trim.Length < 3 Then
            errores &= "Debe completar el Apellido del cliente." & en
        End If
        If TextBox2.Text.Trim.Length < 3 Then
            errores &= "Debe completar el o los nombres del cliente." & en
        End If
        TextBox3.Text = Val(TextBox3.Text.Trim.Replace(".", "").Replace(" ", "").Replace(",", ""))
        If TextBox3.Text.Trim.Length < 4 Or TextBox3.Text.IndexOf("11111") > -1 Or TextBox3.Text.IndexOf("12345") > -1 Or TextBox3.Text.IndexOf("000000") > -1 Then
            errores &= "Debe completar CORRECTAMENTE el documento del cliente." & en
        End If
        TCuit.Text = Val(TCuit.Text.Trim.Replace(".", "").Replace(" ", "").Replace(",", ""))


        If TextBox7.Text.Trim.Length <> 0 And (TextBox7.Text.IndexOf("@") < 0 Or TextBox7.Text.IndexOf(".") < 0) Then
            errores &= "Verifique por favor el email del cliente. No es obligatorio, pero si lo escribe debe ser correcto." & en
        End If
        If errores.Length > 0 Then
            MsgBox("Hubo errores, por favor verifique y corrija antes de intentar de nuevo:" & en & en & errores)
            Exit Sub
        End If
        ' TextBox12.Text = "update Profesores set apellidos='" & TextBox1.Text.Trim.ToUpper.Replace("'", "´") & "', nombres='" & TextBox2.Text.Trim.ToUpper.Replace("'", "´") & "', sexo='" & Sexo.SelectedItem & "', doc=" & Val(TextBox3.Text.Trim.Replace(".", "").Replace(" ", "").Replace(",", "")) & ", nacionalidad='" & TextBox10.Text.Trim.ToUpper & "', dirección='" & TextBox4.Text.Trim.ToUpper.Replace("'", "´") & "', localidad='" & TextBox5.Text.Trim.ToUpper.Replace("'", "´") & "', teléfparticular='" & TextBox6.Text.Trim.ToUpper.Replace("'", "´") & "', emailalumno='" & TextBox7.Text.Trim.ToUpper.Replace("'", "´") & "', fechanacimiento=" & FechaSQL(DateTimePicker1.Value) & ", ocupación='" & TextBox8.Text.Trim.ToUpper.Replace("'", "´") & "', colegio='" & TextBox9.Text.Trim.ToUpper.Replace("'", "´") & "', turno='" & TextBox11.Text.Trim.ToUpper.Replace("'", "´") & "', comentarios='" & TextBox12.Text.Trim.ToUpper.Replace("'", "´") & "' where legajo=" & VNum(lLegajo.Text)
        If SQL_Accion("update Clientes set estado=" & IIf(CheckBox1.Checked, 1, 0) & ", apellidoCli='" & TextBox1.Text.Trim.ToUpper.Replace("'", "´") & "', nombreCli='" & TextBox2.Text.Trim.ToUpper.Replace("'", "´") & "', [documento-Cli]=" & Val(TextBox3.Text.Trim.Replace(".", "").Replace(" ", "").Replace(",", "")) & ", [CUIT-Cli]=" & Val(TCuit.Text.Trim.Replace(".", "")) & ",[Usuario]='" & tUsuario.Text.Trim.ToUpper.Replace("'", "´") & "',[Clave]='" & tClave.Text.Trim.ToUpper.Replace("'", "´") & "', domicilioCli='" & TextBox4.Text.Trim.ToUpper.Replace("'", "´") & "', localidadCli='" & TextBox5.Text.Trim.ToUpper.Replace("'", "´") & "', provinciaCli='" & TextBox8.Text.Trim.ToUpper.Replace("'", "´") & "', teléfonosCli='" & TextBox6.Text.Trim.ToUpper.Replace("'", "´") & "', [e-mail-Cli]='" & TextBox7.Text.Trim.ToUpper.Replace("'", "´") & "', fechanacimientoCli=" & FechaSQL(DateTimePicker1.Value) & ", comentariosCli='" & TextBox12.Text.Trim.ToUpper.Replace("'", "´") & "' where nCli=" & VNum(lLegajo.Text)) = True Then

            Dim unused = MsgBox("Cambios realizados correctamente.")

            buscar(" NCli=" & VNum(lLegajo.Text))
        Else
            MsgBox("Se produjo un error al querer guardar los datos del cliente, reintente, y si el error persiste, anote todos los datos que quizo ingresar y comuníquese con el programador.")
        End If
    End Sub
    Private Sub bNuevoAlumno_Click_1(sender As Object, e As EventArgs) Handles bNuevoAlumno.Click
        If SQL_Accion("insert into Clientes (apellidoCli, nombreCli, [documento-Cli],[CUIT-Cli],[Usuario],[clave],DomicilioCli, localidadCli, teléfonosCli, fechanacimientoCli, comentariosCli,[e-mail-Cli],estado) values ('*****','*****',          0,         0 ,        '',          '',     '',        '',             '',           getdate(),               ''       ,      ''    ,     1   )  ") Then


            buscar(" ApeYNom like '****%' ")
            MsgBox("Se ha creado un nuevo registro para el cliente que desea ingresar, seleccione la línea nueva, cargue los datos y luego confirme con el botón 'Aceptar Cambios'.")
        End If
    End Sub

    Private Sub bBuscar_Click_1(sender As Object, e As EventArgs) Handles bBuscar.Click
        buscar(" ApeYNom like '" & tApellido.Text & "%' ")
    End Sub


End Class