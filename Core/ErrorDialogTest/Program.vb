Imports System

Module Program

  <STAThread>
  Sub Main() 'args As String())

    Try
      Application.SetHighDpiMode(HighDpiMode.SystemAware)
      Application.EnableVisualStyles()
      Application.SetCompatibleTextRenderingDefault(False)
      Application.Run(New Form1())
    Catch ex As Exception
      Using ef = New ErrorDialog.ErrorForm(ex)
        ef.StartPosition = FormStartPosition.CenterScreen
        ef.ShowDialog()
      End Using
    End Try

  End Sub

End Module
