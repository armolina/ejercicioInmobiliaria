Imports LibreriaInmobiliaria

Public Class Casa
    Public precio As Double
    Public direccion As String
    Public precioVentaNeto As Decimal
    Public pvp As Decimal
    Public comision As Decimal

    Public Sub calcularPVP(ByRef _precioVentaNeto As String)
        Dim libVenta As New Venta
        precioVentaNeto = _precioVentaNeto
        If precioVentaNeto > 0 Then
            pvp = libVenta.calcularPrecioVenta(precioVentaNeto)
            comision = libVenta.calcularComision(pvp)

            Console.WriteLine("El precio de venta es: " & pvp & "€")
            Console.WriteLine("La comisión para el vendedor es de: " & comision & "€")
        Else
            Console.WriteLine("No se ha seteado un precioVentaNeto")
        End If


    End Sub
End Class
