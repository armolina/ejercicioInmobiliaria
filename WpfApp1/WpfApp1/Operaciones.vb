Imports System
Imports System.IO

Public Class Operaciones

    Public empleadosLeidos As New List(Of Empleado)

    Public Sub getEmpleados()
        Dim empleados() As String = File.ReadAllLines("C:\datosCurso\inmobiliaria\empleados.txt")

        For Each empleado As String In empleados

            Dim empleadoCsv() = Split(empleados(0), ",")

            'armm: Creo el empleado con los datos del split.
            Dim empl As New Empleado
            empl.nombre = empleadoCsv(0)
            empl.apellidos = empleadoCsv(1)
            empl.telefono = empleadoCsv(2)
            empl.idEmpleado = empleadoCsv(3)

            empleadosLeidos.Add(empl)
        Next

        Console.Write(empleadosLeidos)
    End Sub

    Public Function calcularLetraDni(ByVal dni As String)
        Const cCADENA As String = "TRWAGMYFPDXBNJZSQVHLCKE"

        Dim a As Integer = 0
        Dim b As Integer
        Dim c As Integer

        Dim NIF = CInt(Val(dni))

        Do
            b = CInt(Int(NIF / 24))
            c = NIF - (24 * b)
            a = a + c
            NIF = b
        Loop While b <> 0

        b = CInt(Int(a / 23))
        c = a - (23 * b)

        Console.WriteLine(dni & Mid(cCADENA, CInt(c + 1), 1))
        Return dni & Mid(cCADENA, CInt(c + 1), 1)
    End Function

    Public Function pruebas()

    End Function

End Class
