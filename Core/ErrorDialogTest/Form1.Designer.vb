<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
  Inherits System.Windows.Forms.Form

  'Form overrides dispose to clean up the component list.
  <System.Diagnostics.DebuggerNonUserCode()> _
  Protected Overrides Sub Dispose(ByVal disposing As Boolean)
    Try
      If disposing AndAlso components IsNot Nothing Then
        components.Dispose()
      End If
    Finally
      MyBase.Dispose(disposing)
    End Try
  End Sub

  'Required by the Windows Form Designer
  Private components As System.ComponentModel.IContainer

  'NOTE: The following procedure is required by the Windows Form Designer
  'It can be modified using the Windows Form Designer.  
  'Do not modify it using the code editor.
  Private WithEvents OpaqueExceptionDialogButton As Button
  Private WithEvents CreateAnotherCustomExceptionButton As Button
  Private WithEvents CreateExceptionWithStackFrameButton As Button
  Private WithEvents CustomExceptionButton As Button
  Private WithEvents CreateInnerExceptionButton As Button
  Private WithEvents CreateExceptionButton As Button
  <System.Diagnostics.DebuggerStepThrough()>
  Private Sub InitializeComponent()
    OpaqueExceptionDialogButton = New Button
    CreateAnotherCustomExceptionButton = New Button
    CreateExceptionWithStackFrameButton = New Button
    CustomExceptionButton = New Button
    CreateInnerExceptionButton = New Button
    CreateExceptionButton = New Button
    Me.SuspendLayout()
    '
    'OpaqueExceptionDialogButton
    '
    OpaqueExceptionDialogButton.FlatStyle = FlatStyle.System
    OpaqueExceptionDialogButton.Location = New Point(8, 166)
    OpaqueExceptionDialogButton.Name = "OpaqueExceptionDialogButton"
    OpaqueExceptionDialogButton.Size = New Size(272, 24)
    OpaqueExceptionDialogButton.TabIndex = 12
    OpaqueExceptionDialogButton.Text = "Display Opaque Error Dialog"
    '
    'CreateAnotherCustomExceptionButton
    '
    CreateAnotherCustomExceptionButton.FlatStyle = FlatStyle.System
    CreateAnotherCustomExceptionButton.Location = New Point(8, 134)
    CreateAnotherCustomExceptionButton.Name = "CreateAnotherCustomExceptionButton"
    CreateAnotherCustomExceptionButton.Size = New Size(272, 24)
    CreateAnotherCustomExceptionButton.TabIndex = 11
    CreateAnotherCustomExceptionButton.Text = "Create Another Custom Exception"
    '
    'CreateExceptionWithStackFrameButton
    '
    CreateExceptionWithStackFrameButton.FlatStyle = FlatStyle.System
    CreateExceptionWithStackFrameButton.Location = New Point(8, 38)
    CreateExceptionWithStackFrameButton.Name = "CreateExceptionWithStackFrameButton"
    CreateExceptionWithStackFrameButton.Size = New Size(272, 24)
    CreateExceptionWithStackFrameButton.TabIndex = 8
    CreateExceptionWithStackFrameButton.Text = "Create Exception W/ Stack Frame"
    '
    'CustomExceptionButton
    '
    CustomExceptionButton.FlatStyle = FlatStyle.System
    CustomExceptionButton.Location = New Point(8, 102)
    CustomExceptionButton.Name = "CustomExceptionButton"
    CustomExceptionButton.Size = New Size(272, 24)
    CustomExceptionButton.TabIndex = 10
    CustomExceptionButton.Text = "Create Custom Exception"
    '
    'CreateInnerExceptionButton
    '
    CreateInnerExceptionButton.FlatStyle = FlatStyle.System
    CreateInnerExceptionButton.Location = New Point(8, 70)
    CreateInnerExceptionButton.Name = "CreateInnerExceptionButton"
    CreateInnerExceptionButton.Size = New Size(272, 24)
    CreateInnerExceptionButton.TabIndex = 9
    CreateInnerExceptionButton.Text = "Create Exception With Inner Exceptions"
    '
    'CreateExceptionButton
    '
    CreateExceptionButton.FlatStyle = FlatStyle.System
    CreateExceptionButton.Location = New Point(8, 6)
    CreateExceptionButton.Name = "CreateExceptionButton"
    CreateExceptionButton.Size = New Size(272, 24)
    CreateExceptionButton.TabIndex = 7
    CreateExceptionButton.Text = "Create Exception"
    '
    'Form1
    '
    AutoScaleBaseSize = New Size(5, 13)
    ClientSize = New Size(288, 197)
    Controls.Add(OpaqueExceptionDialogButton)
    Controls.Add(CreateAnotherCustomExceptionButton)
    Controls.Add(CreateExceptionWithStackFrameButton)
    Controls.Add(CustomExceptionButton)
    Controls.Add(CreateInnerExceptionButton)
    Controls.Add(CreateExceptionButton)
    MaximizeBox = False
    MinimizeBox = False
    Name = "Form1"
    StartPosition = FormStartPosition.CenterScreen
    Text = "Exception Handling Tests"
    Me.ResumeLayout(False)

  End Sub
End Class
