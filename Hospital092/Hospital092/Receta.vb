'------------------------------------------------------------------------------
' <auto-generated>
'     Este código se generó a partir de una plantilla.
'
'     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
'     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class Receta
    Public Property idReceta As Integer
    Public Property idConsulta As Nullable(Of Integer)
    Public Property idMedicamento As Nullable(Of Integer)
    Public Property dosis As String

    Public Overridable Property Consulta As Consulta
    Public Overridable Property Medicamento As Medicamento

End Class