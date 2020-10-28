Option Explicit On
Option Strict On
Option Infer On

Imports System

Module Program

  <STAThread>
  Sub Main() 'args As String())

    'Application.SetUnhandledExceptionMode(UnhandledExceptionMode.Automatic)
    'Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException)
    Application.SetUnhandledExceptionMode(UnhandledExceptionMode.ThrowException)

    AddHandler AppDomain.CurrentDomain.UnhandledException, AddressOf UnhandledExceptionHandler

    Application.SetHighDpiMode(HighDpiMode.SystemAware)
    Application.EnableVisualStyles()
    Application.SetCompatibleTextRenderingDefault(False)
    Application.Run(New Form1())

  End Sub

  Private Sub UnhandledExceptionHandler(sender As Object, e As UnhandledExceptionEventArgs)
    Using ef = New ErrorDialog.ErrorForm(DirectCast(e.ExceptionObject, Exception))
      ef.StartPosition = FormStartPosition.CenterScreen
      ef.ShowDialog()
    End Using
  End Sub

End Module
