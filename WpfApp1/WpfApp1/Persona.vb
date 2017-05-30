Public Class Persona

    Public nombre As String
    Public apellidos As String
    Public telefono As String

    'armm: declaro mi funcion Delegate 
    Public Delegate Sub OperacionesDelegate(ByVal x As String)

    'armm: calcularDni tiene una diferencia con los metodos normales y es que espera que le pasemos como parámetro
    'el metodo con el que va a trabajar.
    Public Sub calcularDni(_dni As String, operacion As OperacionesDelegate)
        'armm: al ser un delegate no podemos obtener valor, ya que no devolverá nada.
        operacion.Invoke(_dni)
    End Sub

    Public Function nombreApellidos()
        nombreApellidos = nombre + " " + apellidos
    End Function

End Class
