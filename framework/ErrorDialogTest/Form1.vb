Option Explicit On
Option Strict On
Option Infer On

Imports ErrorDialog

Public Class Form1
  Inherits Form

#Region " Windows Form Designer generated code "

  Public Sub New()
    MyBase.New()

    'This call is required by the Windows Form Designer.
    InitializeComponent()

    'Add any initialization after the InitializeComponent() call

  End Sub

  'Form overrides dispose to clean up the component list.
  Protected Overloads Overrides Sub Dispose(disposing As Boolean)
    If disposing Then
      If components IsNot Nothing Then
        components.Dispose()
      End If
    End If
    MyBase.Dispose(disposing)
  End Sub

  'Required by the Windows Form Designer
  Private ReadOnly components As System.ComponentModel.IContainer

  'NOTE: The following procedure is required by the Windows Form Designer
  'It can be modified using the Windows Form Designer.  
  'Do not modify it using the code editor.
  Friend WithEvents OpaqueExceptionDialogButton As Button
  Friend WithEvents CreateAnotherCustomExceptionButton As Button
  Friend WithEvents CreateExceptionWithStackFrameButton As Button
  Friend WithEvents CustomExceptionButton As Button
  Friend WithEvents CreateInnerExceptionButton As Button
  Friend WithEvents CreateExceptionButton As Button
  <DebuggerStepThrough()> Private Sub InitializeComponent()
    OpaqueExceptionDialogButton = New Button
    CreateAnotherCustomExceptionButton = New Button
    CreateExceptionWithStackFrameButton = New Button
    CustomExceptionButton = New Button
    CreateInnerExceptionButton = New Button
    CreateExceptionButton = New Button
    SuspendLayout()
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
    ResumeLayout(False)

  End Sub

#End Region

  <STAThread()>
  Shared Sub Main()
    Application.EnableVisualStyles()
    Application.Run(New Form1)
  End Sub

  Private Sub CreateExceptionButton_Click(sender As Object, e As EventArgs) Handles CreateExceptionButton.Click
    Throw New Exception("A mild exception has occurred.")
  End Sub

  Private Sub CreateExceptionWithStackFrameButton_Click(sender As Object, e As EventArgs) Handles CreateExceptionWithStackFrameButton.Click
    MethodOne()
  End Sub

  Private Sub MethodOne()
    MethodTwo()
  End Sub

  Private Sub MethodTwo()
    MethodThree()
  End Sub

  Private Sub MethodThree()
    Throw New Exception("A stackable error has occurred.")
  End Sub

  Private Sub CreateInnerExceptionButton_Click(sender As Object, e As EventArgs) Handles CreateInnerExceptionButton.Click
    InnerExOne()
  End Sub

  Private Sub InnerExOne()
    Try
      InnerExTwo()
    Catch e As Exception
      Throw New Exception("InnerExOne() caused an exception.", e)
    End Try
  End Sub

  Private Sub InnerExTwo()
    Try
      InnerExThree()
    Catch ioe As InvalidOperationException
      Throw New Exception("An invalid operation occurred.", ioe)
    Catch e As Exception
      Throw e
    End Try
  End Sub

  Private Sub InnerExThree()
    Try
      Dim z = 0
      Dim x = 3 \ z
    Catch dbze As DivideByZeroException
      Throw New InvalidOperationException("Can't divide by zero.", dbze)
    Catch e As Exception
      Throw e
    End Try
  End Sub

  Private Sub CustomExceptionButton_Click(sender As Object, e As EventArgs) Handles CustomExceptionButton.Click
    CreateCustomException()
  End Sub

  Private Sub CreateCustomException()
    Throw New ACustomException
  End Sub

  Private Sub CreateAnotherCustomExceptionButton_Click(sender As Object, e As EventArgs) Handles CreateAnotherCustomExceptionButton.Click
    CallMethodWithNull(Nothing)
  End Sub

  Private Sub CallMethodWithNull(anArg As String)
    If anArg Is Nothing Then
      Throw New ArgumentNullException("anArg was null.")
    End If
  End Sub

  Private Sub OpaqueExceptionDialogButton_Click(sender As Object, e As EventArgs) Handles OpaqueExceptionDialogButton.Click
    Try
      Throw New Exception("I don't like opaque dialogs!")
    Catch ex As Exception
      Using ef = New ErrorForm(ex) With {.Text = "Too bad - it's opaque!",
                                         .Opacity = 0.78,
                                         .AllowTransparency = True}
        ef.ShowDialog(Me)
      End Using
    End Try
  End Sub

End Class

Public Class ACustomException
  Inherits Exception

  Public Sub New()
    MyClass.New(Nothing, Nothing)
  End Sub

  Public Sub New(message As String)
    MyClass.New(message, Nothing)
  End Sub

  Public Sub New(message As String, innerEx As Exception)
    MyBase.New(message, innerEx)
    ThreadId = Threading.Thread.CurrentThread.ManagedThreadId
    ProcessId = Process.GetCurrentProcess.Id
    AppDomainName = AppDomain.CurrentDomain.FriendlyName
  End Sub

  Public ReadOnly Property ThreadId() As Integer
  Public ReadOnly Property ProcessId() As Integer
  Public ReadOnly Property AppDomainName() As String

End Class