Imports System.Data.Odbc
Imports System.Data

Public Class Cliente : Inherits Persona
    Public idCliente As Integer

    Public Function obtenerClientes() As DataSet
        Dim conexion As New conexionBBDD
        Dim sql As String
        Dim da As New OdbcDataAdapter

        'armm: apertura de la conexion
        conexion.abirConexion()

        sql = "SELECT * FROM persona"

        Dim cmd As New OdbcCommand
        With cmd
            .CommandText = sql
            .CommandType = CommandType.Text
            .Connection = conexion.conn
            .CommandTimeout = 10000
        End With


        da.SelectCommand = cmd
        Dim ds As New DataSet
        da.Fill(ds)

        Dim dt As DataTable = ds.Tables.Item(0)
        Dim row As DataRow
        Dim count As Integer = dt.Columns.Count()

        Dim personas As New List(Of Persona)

        For Each row In dt.Rows
            Dim persona As New Persona
            Dim i As Integer = 0
            'While i <= count - 1
            ' Console.Write(row(i))
            persona.id = row(0)
            persona.nombre = row(1)
            persona.apellidos = row(2)
            persona.dni = row(3)
            personas.Add(persona)
            'i += 1
            'End While
            Console.WriteLine(Environment.NewLine())
        Next

        'Return ds

        'armm: fuerzo la reconexion
        conexion.abirConexion()

        'armm: cierre de la conexion
        conexion.cerrarConexion()
    End Function
End Class
