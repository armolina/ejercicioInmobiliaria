Imports Microsoft.Data.Odbc

Public Class conexionBBDD
    'armm: inicializo la conexion para ser reutilizada
    Public conn As New System.Data.Odbc.OdbcConnection

    'armm: abro la conexion
    Public Sub abirConexion()
        Try
            If conn.State = 0 Then
                conn.ConnectionString = "FIL=MySql;DSN=sacyrfluorodbc"
                conn.Open()
                Console.WriteLine("Abro la conexion")
            Else
                Console.WriteLine("Reutilizo una conexion abierta")
            End If

            'Pedro, pa ti
            'Dim estado As String = conn.State

        Catch ex As Exception
            MessageBox.Show("Error al conectarse a la BBDD")
        End Try
    End Sub

    'armm: cierro la conexion
    Public Sub cerrarConexion()
        Try
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Error al desconectarse a la BBDD")
        Finally
            conn.Close()
        End Try
    End Sub
End Class
