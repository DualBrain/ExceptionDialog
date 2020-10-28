Option Explicit On 
Option Strict On

Imports ErrorDialog

Public Class Form1
  Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

  Public Sub New()
    MyBase.New()

    'This call is required by the Windows Form Designer.
    InitializeComponent()

    'Add any initialization after the InitializeComponent() call

  End Sub

  'Form overrides dispose to clean up the component list.
  Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
    If disposing Then
      If Not (components Is Nothing) Then
        components.Dispose()
      End If
    End If
    MyBase.Dispose(disposing)
  End Sub

  'Required by the Windows Form Designer
  Private components As System.ComponentModel.IContainer

  'NOTE: The following procedure is required by the Windows Form Designer
  'It can be modified using the Windows Form Designer.  
  'Do not modify it using the code editor.
  Friend WithEvents btnOpaqueExceptionDialog As System.Windows.Forms.Button
  Friend WithEvents btnCreateAnotherCustomException As System.Windows.Forms.Button
  Friend WithEvents btnCreateExceptionWithStackFrame As System.Windows.Forms.Button
  Friend WithEvents btnCustomException As System.Windows.Forms.Button
  Friend WithEvents CreateInnerException As System.Windows.Forms.Button
  Friend WithEvents btnCreateException As System.Windows.Forms.Button
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    Me.btnOpaqueExceptionDialog = New System.Windows.Forms.Button
    Me.btnCreateAnotherCustomException = New System.Windows.Forms.Button
    Me.btnCreateExceptionWithStackFrame = New System.Windows.Forms.Button
    Me.btnCustomException = New System.Windows.Forms.Button
    Me.CreateInnerException = New System.Windows.Forms.Button
    Me.btnCreateException = New System.Windows.Forms.Button
    Me.SuspendLayout()
    '
    'btnOpaqueExceptionDialog
    '
    Me.btnOpaqueExceptionDialog.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.btnOpaqueExceptionDialog.Location = New System.Drawing.Point(8, 166)
    Me.btnOpaqueExceptionDialog.Name = "btnOpaqueExceptionDialog"
    Me.btnOpaqueExceptionDialog.Size = New System.Drawing.Size(272, 24)
    Me.btnOpaqueExceptionDialog.TabIndex = 12
    Me.btnOpaqueExceptionDialog.Text = "Display Opaque Error Dialog"
    '
    'btnCreateAnotherCustomException
    '
    Me.btnCreateAnotherCustomException.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.btnCreateAnotherCustomException.Location = New System.Drawing.Point(8, 134)
    Me.btnCreateAnotherCustomException.Name = "btnCreateAnotherCustomException"
    Me.btnCreateAnotherCustomException.Size = New System.Drawing.Size(272, 24)
    Me.btnCreateAnotherCustomException.TabIndex = 11
    Me.btnCreateAnotherCustomException.Text = "Create Another Custom Exception"
    '
    'btnCreateExceptionWithStackFrame
    '
    Me.btnCreateExceptionWithStackFrame.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.btnCreateExceptionWithStackFrame.Location = New System.Drawing.Point(8, 38)
    Me.btnCreateExceptionWithStackFrame.Name = "btnCreateExceptionWithStackFrame"
    Me.btnCreateExceptionWithStackFrame.Size = New System.Drawing.Size(272, 24)
    Me.btnCreateExceptionWithStackFrame.TabIndex = 8
    Me.btnCreateExceptionWithStackFrame.Text = "Create Exception W/ Stack Frame"
    '
    'btnCustomException
    '
    Me.btnCustomException.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.btnCustomException.Location = New System.Drawing.Point(8, 102)
    Me.btnCustomException.Name = "btnCustomException"
    Me.btnCustomException.Size = New System.Drawing.Size(272, 24)
    Me.btnCustomException.TabIndex = 10
    Me.btnCustomException.Text = "Create Custom Exception"
    '
    'CreateInnerException
    '
    Me.CreateInnerException.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.CreateInnerException.Location = New System.Drawing.Point(8, 70)
    Me.CreateInnerException.Name = "CreateInnerException"
    Me.CreateInnerException.Size = New System.Drawing.Size(272, 24)
    Me.CreateInnerException.TabIndex = 9
    Me.CreateInnerException.Text = "Create Exception With Inner Exceptions"
    '
    'btnCreateException
    '
    Me.btnCreateException.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.btnCreateException.Location = New System.Drawing.Point(8, 6)
    Me.btnCreateException.Name = "btnCreateException"
    Me.btnCreateException.Size = New System.Drawing.Size(272, 24)
    Me.btnCreateException.TabIndex = 7
    Me.btnCreateException.Text = "Create Exception"
    '
    'Form1
    '
    Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
    Me.ClientSize = New System.Drawing.Size(288, 197)
    Me.Controls.Add(Me.btnOpaqueExceptionDialog)
    Me.Controls.Add(Me.btnCreateAnotherCustomException)
    Me.Controls.Add(Me.btnCreateExceptionWithStackFrame)
    Me.Controls.Add(Me.btnCustomException)
    Me.Controls.Add(Me.CreateInnerException)
    Me.Controls.Add(Me.btnCreateException)
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "Form1"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Exception Handling Tests"
    Me.ResumeLayout(False)

  End Sub

#End Region

  <STAThread()> _
  Shared Sub Main()
    Application.EnableVisualStyles()
    Application.DoEvents()
    Application.Run(New Form1)
  End Sub

  Private Sub DisplayException(ByVal TargetException As Exception)
    Dim ef As New ErrorForm(TargetException, True)
    ef.ShowDialog(Me)
  End Sub

  Private Sub btnCreateException_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCreateException.Click
    Try
      Throw New Exception("A mild exception has occurred.")
    Catch ex As Exception
      DisplayException(ex)
    End Try
  End Sub

  Private Sub btnCreateExceptionWithStackFrame_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCreateExceptionWithStackFrame.Click
    Try
      Me.MethodOne()
    Catch ex As Exception
      DisplayException(ex)
    End Try
  End Sub

  Private Sub MethodOne()
    Me.MethodTwo()
  End Sub

  Private Sub MethodTwo()
    Me.MethodThree()
  End Sub

  Private Sub MethodThree()
    Throw New Exception("A stackable error has occurred.")
  End Sub

  Private Sub CreateInnerException_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CreateInnerException.Click
    Try
      Me.InnerExOne()
    Catch ex As Exception
      DisplayException(ex)
    End Try
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
      Dim z As Integer = 0
      Dim x As Integer = 3 \ z
    Catch dbze As DivideByZeroException
      Throw New InvalidOperationException("Can't divide by zero.", dbze)
    Catch e As Exception
      Throw e
    End Try
  End Sub

  Private Sub btnCustomException_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCustomException.Click
    Try
      CreateCustomException()
    Catch ex As Exception
      DisplayException(ex)
    End Try
  End Sub

  Private Sub CreateCustomException()
    Throw New ACustomException
  End Sub

  Private Sub btnCreateAnotherCustomException_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCreateAnotherCustomException.Click
    Try
      CallMethodWithNull(Nothing)
    Catch ex As Exception
      DisplayException(ex)
    End Try
  End Sub

  Private Sub CallMethodWithNull(ByVal anArg As String)
    If Nothing = anArg Then
      Throw New ArgumentNullException("anArg was null.")
    End If
  End Sub

  Private Sub btnOpaqueExceptionDialog_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnOpaqueExceptionDialog.Click
    Try
      Throw New Exception("I don't like opaque dialogs!")
    Catch ex As Exception
      Dim ef As New ErrorForm(ex)
      ef.Text = "Too bad - it's opaque!"
      ef.Opacity = 0.78
      ef.AllowTransparency = True
      ef.ShowDialog(Me)
    End Try
  End Sub

  Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

  End Sub
End Class

Public Class ACustomException
  Inherits Exception

  Private m_ThreadID As Integer
  Private m_ProcessID As Integer
  Private m_ADName As String

  Private Sub Init()
    m_ThreadID = AppDomain.GetCurrentThreadId()
    m_ProcessID = Process.GetCurrentProcess().Id
    m_ADName = AppDomain.CurrentDomain.FriendlyName
  End Sub

  Public Sub New()
    Init()
  End Sub

  Public Sub New(ByVal message As String)
    MyBase.New(message)
    Init()
  End Sub

  Public Sub New(ByVal message As String, ByVal innerEx As Exception)
    MyBase.New(message, innerEx)
    Init()
  End Sub

  Public ReadOnly Property ThreadID() As Integer
    Get
      Return Me.m_ThreadID
    End Get
  End Property

  Public ReadOnly Property ProcessID() As Integer
    Get
      Return Me.m_ProcessID
    End Get
  End Property

  Public ReadOnly Property AppDomainName() As String
    Get
      Return Me.m_ADName
    End Get
  End Property

End Class
