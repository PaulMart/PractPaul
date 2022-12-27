Imports System.Data.SqlClient

Public Class Class1
    Dim cnx As New SqlConnection("data source=DESKTOP-632VE4M;initial catalog=clinica;user id=sa;password=654321;")

    Public Function ListarPersonas() As DataTable
        Dim da As New SqlDataAdapter("sp_listar_personas", cnx)
        Dim tbl As New DataTable
        da.Fill(tbl)
        Return tbl
    End Function

    Public Function Insertar(nombre As String, apellido As String, dni As String, fechaNacimiento As Date)
        Dim da As New SqlCommand("sp_registrar_persona", cnx)
        da.CommandType = CommandType.StoredProcedure
        da.Parameters.AddWithValue("@Nombre", nombre)
        da.Parameters.AddWithValue("@Apellido", apellido)
        da.Parameters.AddWithValue("@Dni", dni)
        da.Parameters.AddWithValue("@FechaNacimiento", fechaNacimiento)
        da.Parameters.AddWithValue("@FechaRegistro", Date.Now)
        cnx.Open()
        Dim resp As Integer
        Try
            resp = da.ExecuteNonQuery
            cnx.Close()
        Catch ex As Exception
            MsgBox("Error al registrar persona")
        End Try
        Return resp
    End Function
End Class
