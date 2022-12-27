Imports ClassLibrary1

Public Class Form1

    Dim obj As New Class1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGVPersonas.DataSource = obj.ListarPersonas


    End Sub

    Private Sub BtnGrabar_Click(sender As Object, e As EventArgs) Handles BtnGrabar.Click
        Try
            obj.Insertar(TxtNombre.Text, TxtApellido.Text, TxtDNI.Text, (CDate(TxtFNacimiento.Text)))
            DGVPersonas.DataSource = obj.ListarPersonas
            MsgBox("Se registro a la persona correctamente")

            TxtNombre.Text = ""
            TxtApellido.Text = ""
            TxtDNI.Text = ""
            TxtFNacimiento.Value = DateTime.Now

        Catch ex As Exception

        End Try
    End Sub
End Class
