imports System.Windows

''' <summary>
''' Interaction logic for App.xaml
''' </summary>
Partial Public Class App
    'Inherits Application
    Public Shared Sub Main()
        Dim app As Application = New Application()
        app.Run(New MainWindow())
    End Sub
End Class
