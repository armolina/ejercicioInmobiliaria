Class MainWindow
    Sub inicializar()
        Dim cliente As New Cliente
        cliente.obtenerClientes()
    End Sub

    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)

        Dim miOperaciones As New Operaciones
        'Dim empleados As New List(Of Empleado)

        'armm: pintado de datos en pantalla (vista)
        miOperaciones.getEmpleados()
        'empleados = miOperaciones.empleadosLeidos
        txtbEmpleado.Text = miOperaciones.empleadosLeidos(0).nombre + " : " + miOperaciones.empleadosLeidos(0).apellidos

    End Sub

    Private Sub calcularSueldoNeto(sender As Object, e As RoutedEventArgs)
        Dim empleado As New Empleado
        empleado.sueldoBrutoAnual = 25000
        empleado.calcularSueldoNeto()
    End Sub

    Private Sub calcularPvp(sender As Object, e As RoutedEventArgs)
        Dim casa As New Casa
        casa.calcularPVP(txtbPrecioBase.Text.ToString)
    End Sub

    Private Sub txtbPrecioBase_TextChanged(sender As Object, e As TextChangedEventArgs) Handles txtbPrecioBase.TextChanged
        Console.WriteLine(e.ToString)
    End Sub

    Private Sub chekIntegerOnly(sender As Object, keyVal As KeyEventArgs) Handles txtbPrecioBase.KeyDown
        Console.WriteLine(keyVal.Key.ToString)
        Console.WriteLine(keyVal.Key)
        Console.WriteLine(keyVal.SystemKey)
        'If (keyVal.Key = 'A')
        'Console.Write
    End Sub

    Private Sub calcularDni(sender As Object, e As RoutedEventArgs)
        Dim persona As New Persona
        Dim operacion As New Operaciones
        Dim ramon As New Empleado With {
            .nombre = "ramon",
            .apellidos = "Molina",
            .telefono = "876999000"
        }

        persona.calcularDni("65874547", AddressOf operacion.calcularLetraDni)
    End Sub
End Class
