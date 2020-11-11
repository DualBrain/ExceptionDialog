Option Explicit On
Option Strict On
Option Infer On

Imports ErrorDialog

Public Class Form1



  Private Sub CreateExceptionButton_Click(sender As Object, e As EventArgs) Handles CreateExceptionButton.Click
    Throw New Exception("A mild exception has occurred.")
  End Sub

  Private Sub CreateExceptionWithStackFrameButton_Click(sender As Object, e As EventArgs) Handles CreateExceptionWithStackFrameButton.Click
    MethodOne()
  End Sub

  Private Shared Sub MethodOne()
    MethodTwo()
  End Sub

  Private Shared Sub MethodTwo()
    MethodThree()
  End Sub

  Private Shared Sub MethodThree()
    Throw New Exception("A stackable error has occurred.")
  End Sub

  Private Sub CreateInnerExceptionButton_Click(sender As Object, e As EventArgs) Handles CreateInnerExceptionButton.Click
    InnerExOne()
  End Sub

  Private Shared Sub InnerExOne()
    Try
      InnerExTwo()
    Catch e As Exception
      Throw New Exception("InnerExOne() caused an exception.", e)
    End Try
  End Sub

  Private Shared Sub InnerExTwo()
    Try
      InnerExThree()
    Catch ioe As InvalidOperationException
      Throw New Exception("An invalid operation occurred.", ioe)
    Catch e As Exception
      Throw ' e
    End Try
  End Sub

  Private Shared Sub InnerExThree()
    Try
      Dim z = 0
      Dim x = 3 \ z
    Catch dbze As DivideByZeroException
      Throw New InvalidOperationException("Can't divide by zero.", dbze)
    Catch e As Exception
      Throw ' e
    End Try
  End Sub

  Private Sub CustomExceptionButton_Click(sender As Object, e As EventArgs) Handles CustomExceptionButton.Click
    CreateCustomException()
  End Sub

  Private Shared Sub CreateCustomException()
    Throw New OurCustomException
  End Sub

  Private Sub CreateAnotherCustomExceptionButton_Click(sender As Object, e As EventArgs) Handles CreateAnotherCustomExceptionButton.Click
    CallMethodWithNull(Nothing)
  End Sub

  Private Shared Sub CallMethodWithNull(anArg As String)
    If anArg Is Nothing Then
      Throw New ArgumentNullException(NameOf(anArg), $"{NameOf(anArg)} was null.")
    End If
  End Sub

  Private Sub OpaqueExceptionDialogButton_Click(sender As Object, e As EventArgs) Handles OpaqueExceptionDialogButton.Click
    Using ef = New ErrorForm(New Exception("I don't like opaque dialogs!")) With {
      .Text = "Too bad - it's opaque!",
      .Opacity = 0.78,
      .AllowTransparency = True}
      ef.ShowDialog(Me)
    End Using
  End Sub

End Class

Public Class OurCustomException
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
    ProcessId = Environment.ProcessId
    AppDomainName = AppDomain.CurrentDomain.FriendlyName
  End Sub

  Public ReadOnly Property ThreadId() As Integer
  Public ReadOnly Property ProcessId() As Integer
  Public ReadOnly Property AppDomainName() As String

End Class