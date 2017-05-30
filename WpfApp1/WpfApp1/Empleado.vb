Imports System
Imports System.IO


Public Class Empleado : Inherits Persona
    Public idEmpleado As Integer
    Public sueldoBrutoAnual As Integer
    Public sueldoNetoAnual As Decimal

    Sub calcularSueldoNeto()
        'Dim ba As operecionesBasicas
        'ba = New operecionesBasicas()

        'Console.WriteLine(ba.suma(1, 4))

        If sueldoBrutoAnual > 0 Then
            'sueldoNetoAnual = ba.calcularSueldoNeto(sueldoBrutoAnual)
        Else
            MsgBox("No se ha informado del sueldo", , "Error")
        End If
    End Sub

    'armm: sobreescribor la función nombre apellidos para que devuelva apellidos, nombre
    Overloads Function nombreApellidos()
        nombreApellidos = apellidos + ", " + nombre
    End Function

End Class
