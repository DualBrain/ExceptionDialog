Option Explicit On
Option Strict On
Option Infer On

Namespace ErrorDialog

  Public Class ErrorForm
    Inherits Form

#Region " Windows Form Designer generated code "

    'Public Sub New()
    '  MyBase.New()

    '  'This call is required by the Windows Form Designer.
    '  InitializeComponent()

    '  'Add any initialization after the InitializeComponent() call

    'End Sub

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
    Friend WithEvents DescriptionColumnHeader As ColumnHeader
    Friend WithEvents ExceptionTypeValueTextBox As TextBox
    Friend WithEvents NameColumnHeader As ColumnHeader
    Friend WithEvents MethodColumnHeader As ColumnHeader
    Friend WithEvents InfoTabControl As TabControl
    Friend WithEvents GeneralTabPage As TabPage
    Friend WithEvents HelpLinkValueTextBox As TextBox
    Friend WithEvents HelpLinkLabel As Label
    Friend WithEvents ExceptionSourceValueTextBox As TextBox
    Friend WithEvents ExceptionTargetMethodValueTextBox As TextBox
    Friend WithEvents ExceptionMessageValueTextBox As TextBox
    Friend WithEvents ExceptionTargetMethodLabel As Label
    Friend WithEvents ExceptionSourceLabel As Label
    Friend WithEvents ExceptionMessageLabel As Label
    Friend WithEvents InnerTabPage As TabPage
    Friend WithEvents InnerExceptionsTreeView As TreeView
    Friend WithEvents StackTabPage As TabPage
    Friend WithEvents StackTraceListView As ListView
    Friend WithEvents SpecificTabPage As TabPage
    Friend WithEvents OtherInfoListView As ListView
    Private WithEvents OkButton As Button
    Friend WithEvents ErrorLabel As Label
    <DebuggerStepThrough()> Private Sub InitializeComponent()
      DescriptionColumnHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
      ExceptionTypeValueTextBox = New System.Windows.Forms.TextBox()
      NameColumnHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
      MethodColumnHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
      InfoTabControl = New System.Windows.Forms.TabControl()
      GeneralTabPage = New System.Windows.Forms.TabPage()
      HelpLinkValueTextBox = New System.Windows.Forms.TextBox()
      HelpLinkLabel = New System.Windows.Forms.Label()
      ExceptionSourceValueTextBox = New System.Windows.Forms.TextBox()
      ExceptionTargetMethodValueTextBox = New System.Windows.Forms.TextBox()
      ExceptionMessageValueTextBox = New System.Windows.Forms.TextBox()
      ExceptionTargetMethodLabel = New System.Windows.Forms.Label()
      ExceptionSourceLabel = New System.Windows.Forms.Label()
      ExceptionMessageLabel = New System.Windows.Forms.Label()
      StackTabPage = New System.Windows.Forms.TabPage()
      StackTraceListView = New System.Windows.Forms.ListView()
      InnerTabPage = New System.Windows.Forms.TabPage()
      InnerExceptionsTreeView = New System.Windows.Forms.TreeView()
      SpecificTabPage = New System.Windows.Forms.TabPage()
      OtherInfoListView = New System.Windows.Forms.ListView()
      OkButton = New System.Windows.Forms.Button()
      ErrorLabel = New System.Windows.Forms.Label()
      InfoTabControl.SuspendLayout()
      GeneralTabPage.SuspendLayout()
      StackTabPage.SuspendLayout()
      InnerTabPage.SuspendLayout()
      SpecificTabPage.SuspendLayout()
      SuspendLayout()
      '
      'DescriptionColumnHeader
      '
      DescriptionColumnHeader.Text = "Description"
      DescriptionColumnHeader.Width = 220
      '
      'ExceptionTypeValueTextBox
      '
      ExceptionTypeValueTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      ExceptionTypeValueTextBox.Location = New System.Drawing.Point(192, 7)
      ExceptionTypeValueTextBox.Name = "ExceptionTypeValueTextBox"
      ExceptionTypeValueTextBox.ReadOnly = True
      ExceptionTypeValueTextBox.Size = New System.Drawing.Size(256, 20)
      ExceptionTypeValueTextBox.TabIndex = 24
      ExceptionTypeValueTextBox.TabStop = False
      '
      'NameColumnHeader
      '
      NameColumnHeader.Text = "Name"
      NameColumnHeader.Width = 120
      '
      'MethodColumnHeader
      '
      MethodColumnHeader.Text = "Method"
      MethodColumnHeader.Width = 400
      '
      'InfoTabControl
      '
      InfoTabControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      InfoTabControl.Controls.Add(GeneralTabPage)
      InfoTabControl.Controls.Add(StackTabPage)
      InfoTabControl.Controls.Add(InnerTabPage)
      InfoTabControl.Controls.Add(SpecificTabPage)
      InfoTabControl.Location = New System.Drawing.Point(8, 33)
      InfoTabControl.Name = "InfoTabControl"
      InfoTabControl.SelectedIndex = 0
      InfoTabControl.Size = New System.Drawing.Size(440, 176)
      InfoTabControl.TabIndex = 23
      '
      'GeneralTabPage
      '
      GeneralTabPage.Controls.Add(HelpLinkValueTextBox)
      GeneralTabPage.Controls.Add(HelpLinkLabel)
      GeneralTabPage.Controls.Add(ExceptionSourceValueTextBox)
      GeneralTabPage.Controls.Add(ExceptionTargetMethodValueTextBox)
      GeneralTabPage.Controls.Add(ExceptionMessageValueTextBox)
      GeneralTabPage.Controls.Add(ExceptionTargetMethodLabel)
      GeneralTabPage.Controls.Add(ExceptionSourceLabel)
      GeneralTabPage.Controls.Add(ExceptionMessageLabel)
      GeneralTabPage.Location = New System.Drawing.Point(4, 22)
      GeneralTabPage.Name = "GeneralTabPage"
      GeneralTabPage.Size = New System.Drawing.Size(432, 150)
      GeneralTabPage.TabIndex = 0
      GeneralTabPage.Text = "General Information"
      '
      'HelpLinkValueTextBox
      '
      HelpLinkValueTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      HelpLinkValueTextBox.Location = New System.Drawing.Point(96, 120)
      HelpLinkValueTextBox.Name = "HelpLinkValueTextBox"
      HelpLinkValueTextBox.ReadOnly = True
      HelpLinkValueTextBox.Size = New System.Drawing.Size(328, 20)
      HelpLinkValueTextBox.TabIndex = 23
      HelpLinkValueTextBox.TabStop = False
      '
      'HelpLinkLabel
      '
      HelpLinkLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
      HelpLinkLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
      HelpLinkLabel.Location = New System.Drawing.Point(8, 120)
      HelpLinkLabel.Name = "HelpLinkLabel"
      HelpLinkLabel.Size = New System.Drawing.Size(80, 16)
      HelpLinkLabel.TabIndex = 22
      HelpLinkLabel.Text = "Help Link:"
      HelpLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      '
      'ExceptionSourceValueTextBox
      '
      ExceptionSourceValueTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      ExceptionSourceValueTextBox.Location = New System.Drawing.Point(96, 72)
      ExceptionSourceValueTextBox.Name = "ExceptionSourceValueTextBox"
      ExceptionSourceValueTextBox.ReadOnly = True
      ExceptionSourceValueTextBox.Size = New System.Drawing.Size(328, 20)
      ExceptionSourceValueTextBox.TabIndex = 21
      ExceptionSourceValueTextBox.TabStop = False
      '
      'ExceptionTargetMethodValueTextBox
      '
      ExceptionTargetMethodValueTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      ExceptionTargetMethodValueTextBox.Location = New System.Drawing.Point(96, 96)
      ExceptionTargetMethodValueTextBox.Name = "ExceptionTargetMethodValueTextBox"
      ExceptionTargetMethodValueTextBox.ReadOnly = True
      ExceptionTargetMethodValueTextBox.Size = New System.Drawing.Size(328, 20)
      ExceptionTargetMethodValueTextBox.TabIndex = 19
      ExceptionTargetMethodValueTextBox.TabStop = False
      '
      'ExceptionMessageValueTextBox
      '
      ExceptionMessageValueTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      ExceptionMessageValueTextBox.Location = New System.Drawing.Point(96, 8)
      ExceptionMessageValueTextBox.Multiline = True
      ExceptionMessageValueTextBox.Name = "ExceptionMessageValueTextBox"
      ExceptionMessageValueTextBox.ReadOnly = True
      ExceptionMessageValueTextBox.Size = New System.Drawing.Size(328, 56)
      ExceptionMessageValueTextBox.TabIndex = 18
      ExceptionMessageValueTextBox.TabStop = False
      '
      'ExceptionTargetMethodLabel
      '
      ExceptionTargetMethodLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
      ExceptionTargetMethodLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
      ExceptionTargetMethodLabel.Location = New System.Drawing.Point(8, 96)
      ExceptionTargetMethodLabel.Name = "ExceptionTargetMethodLabel"
      ExceptionTargetMethodLabel.Size = New System.Drawing.Size(80, 16)
      ExceptionTargetMethodLabel.TabIndex = 16
      ExceptionTargetMethodLabel.Text = "Target Method:"
      ExceptionTargetMethodLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      '
      'ExceptionSourceLabel
      '
      ExceptionSourceLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
      ExceptionSourceLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
      ExceptionSourceLabel.Location = New System.Drawing.Point(8, 72)
      ExceptionSourceLabel.Name = "ExceptionSourceLabel"
      ExceptionSourceLabel.Size = New System.Drawing.Size(80, 16)
      ExceptionSourceLabel.TabIndex = 14
      ExceptionSourceLabel.Text = "Source:"
      ExceptionSourceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      '
      'ExceptionMessageLabel
      '
      ExceptionMessageLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
      ExceptionMessageLabel.Location = New System.Drawing.Point(8, 8)
      ExceptionMessageLabel.Name = "ExceptionMessageLabel"
      ExceptionMessageLabel.Size = New System.Drawing.Size(80, 16)
      ExceptionMessageLabel.TabIndex = 12
      ExceptionMessageLabel.Text = "Message:"
      ExceptionMessageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      '
      'StackTabPage
      '
      StackTabPage.Controls.Add(StackTraceListView)
      StackTabPage.Location = New System.Drawing.Point(4, 22)
      StackTabPage.Name = "StackTabPage"
      StackTabPage.Size = New System.Drawing.Size(432, 150)
      StackTabPage.TabIndex = 2
      StackTabPage.Text = "Stack Trace"
      StackTabPage.Visible = False
      '
      'StackTraceListView
      '
      StackTraceListView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      StackTraceListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {MethodColumnHeader})
      StackTraceListView.HideSelection = False
      StackTraceListView.Location = New System.Drawing.Point(8, 7)
      StackTraceListView.Name = "StackTraceListView"
      StackTraceListView.Size = New System.Drawing.Size(416, 136)
      StackTraceListView.TabIndex = 1
      StackTraceListView.UseCompatibleStateImageBehavior = False
      StackTraceListView.View = System.Windows.Forms.View.Details
      '
      'InnerTabPage
      '
      InnerTabPage.Controls.Add(InnerExceptionsTreeView)
      InnerTabPage.Location = New System.Drawing.Point(4, 22)
      InnerTabPage.Name = "InnerTabPage"
      InnerTabPage.Size = New System.Drawing.Size(432, 150)
      InnerTabPage.TabIndex = 1
      InnerTabPage.Text = "Inner Exception Trace"
      InnerTabPage.Visible = False
      '
      'InnerExceptionsTreeView
      '
      InnerExceptionsTreeView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      InnerExceptionsTreeView.Location = New System.Drawing.Point(8, 8)
      InnerExceptionsTreeView.Name = "InnerExceptionsTreeView"
      InnerExceptionsTreeView.Size = New System.Drawing.Size(416, 136)
      InnerExceptionsTreeView.TabIndex = 0
      '
      'SpecificTabPage
      '
      SpecificTabPage.Controls.Add(OtherInfoListView)
      SpecificTabPage.Location = New System.Drawing.Point(4, 22)
      SpecificTabPage.Name = "SpecificTabPage"
      SpecificTabPage.Size = New System.Drawing.Size(432, 150)
      SpecificTabPage.TabIndex = 3
      SpecificTabPage.Text = "Other Information"
      SpecificTabPage.Visible = False
      '
      'OtherInfoListView
      '
      OtherInfoListView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      OtherInfoListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {NameColumnHeader, DescriptionColumnHeader})
      OtherInfoListView.HideSelection = False
      OtherInfoListView.Location = New System.Drawing.Point(8, 8)
      OtherInfoListView.Name = "OtherInfoListView"
      OtherInfoListView.Size = New System.Drawing.Size(416, 136)
      OtherInfoListView.TabIndex = 0
      OtherInfoListView.UseCompatibleStateImageBehavior = False
      OtherInfoListView.View = System.Windows.Forms.View.Details
      '
      'OkButton
      '
      OkButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      OkButton.DialogResult = System.Windows.Forms.DialogResult.OK
      OkButton.FlatStyle = System.Windows.Forms.FlatStyle.System
      OkButton.Location = New System.Drawing.Point(368, 220)
      OkButton.Name = "OkButton"
      OkButton.Size = New System.Drawing.Size(80, 24)
      OkButton.TabIndex = 21
      OkButton.Text = "&OK"
      '
      'ErrorLabel
      '
      ErrorLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
      ErrorLabel.Location = New System.Drawing.Point(8, 9)
      ErrorLabel.Name = "ErrorLabel"
      ErrorLabel.Size = New System.Drawing.Size(200, 16)
      ErrorLabel.TabIndex = 22
      ErrorLabel.Text = "The following exception has occurred:"
      '
      'ErrorForm
      '
      AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      ClientSize = New System.Drawing.Size(456, 254)
      Controls.Add(ExceptionTypeValueTextBox)
      Controls.Add(InfoTabControl)
      Controls.Add(OkButton)
      Controls.Add(ErrorLabel)
      MinimizeBox = False
      Name = "ErrorForm"
      Text = "Exception Information"
      InfoTabControl.ResumeLayout(False)
      GeneralTabPage.ResumeLayout(False)
      GeneralTabPage.PerformLayout()
      StackTabPage.ResumeLayout(False)
      InnerTabPage.ResumeLayout(False)
      SpecificTabPage.ResumeLayout(False)
      ResumeLayout(False)
      PerformLayout()

    End Sub

#End Region

    Private ReadOnly m_targetEx As Exception
    Private m_hasGeneralBeenCalled As Boolean = False
    Private m_hasInnerExceptionBeenCalled As Boolean = False
    Private m_hasStackTraceBeenCalled As Boolean = False
    Private m_hasOtherInformationBeenCalled As Boolean = False

#If XP Then
    Private ReadOnly m_enableVisualStyles As Boolean = False
#End If

    Public Sub New(targetException As Exception)
#If XP Then
      MyClass.New(targetException, False)
#Else
      InitializeComponent()
      m_targetEx = targetException
#End If

    End Sub

#If XP Then
    Public Sub New(targetException As Exception, enableVisualStyles As Boolean)
      InitializeComponent()
      m_enableVisualStyles = enableVisualStyles
      m_targetEx = targetException
    End Sub
#End If

    Private Sub Me_Load(sender As Object, e As EventArgs) Handles MyBase.Load

#If XP Then
      If m_enableVisualStyles AndAlso XPThemesEnabled() Then
        ' Just cheat and set to white, since most of the tab is covered anyway.
        GeneralTabPage.BackColor = Color.White
        InfoTabControl.BackColor = Color.White
        InnerTabPage.BackColor = Color.White
        SpecificTabPage.BackColor = Color.White
        StackTabPage.BackColor = Color.White
      End If
#End If

      If m_targetEx IsNot Nothing Then
        ExceptionTypeValueTextBox.Text = m_targetEx.GetType().FullName
        DisplayGeneralInformation()
      Else
        InfoTabControl.Enabled = False
        ExceptionTypeValueTextBox.Text = "Unknown"
      End If

    End Sub

    Private Sub DisplayGeneralInformation()
      If m_targetEx IsNot Nothing AndAlso Not m_hasGeneralBeenCalled Then
        ExceptionMessageValueTextBox.Text = m_targetEx.Message
        ExceptionSourceValueTextBox.Text = m_targetEx.Source
        ExceptionTargetMethodValueTextBox.Text = GetTargetMethodFormat(m_targetEx)
        HelpLinkValueTextBox.Text = m_targetEx.HelpLink
        m_hasGeneralBeenCalled = True
      End If
    End Sub

    Private Function GetTargetMethodFormat(ex As Exception) As String
      Return $"[{ex.TargetSite.DeclaringType.Assembly.GetName().Name}]{ex.TargetSite.DeclaringType}::{ex.TargetSite.Name}()"
    End Function

    Private Function GetCustomExceptionInfo(ex As Exception) As Hashtable

      Dim customInfo As New Hashtable

      For Each pi In ex.GetType().GetProperties()
        Dim baseEx = GetType(Exception)
        If baseEx.GetProperty(pi.Name) Is Nothing Then
          customInfo.Add(pi.Name, pi.GetValue(ex, Nothing))
        End If
      Next

      Return customInfo

    End Function

    Private Sub DisplayInnerExceptionTrace()

      If Not m_hasInnerExceptionBeenCalled Then

        Dim innerEx As Exception = m_targetEx
        Dim parentNode As TreeNode = Nothing

        InnerExceptionsTreeView.BeginUpdate()

        While innerEx IsNot Nothing

          Dim childNode = New TreeNode(innerEx.GetType().FullName)
          '  For now, add just the message.
          Dim childMessage = New TreeNode(innerEx.Message)
          Dim childTarget = New TreeNode(GetTargetMethodFormat(innerEx))

          childNode.Nodes.Add(childMessage)
          childNode.Nodes.Add(childTarget)

          If parentNode IsNot Nothing Then
            parentNode.Nodes.Add(childNode)
          Else
            InnerExceptionsTreeView.Nodes.Add(childNode)
          End If

          parentNode = childNode
          innerEx = innerEx.InnerException

        End While

        InnerExceptionsTreeView.EndUpdate()
        m_hasInnerExceptionBeenCalled = True

      End If

    End Sub

    Private Sub DisplayStackTrace()

      If Not m_hasStackTraceBeenCalled Then

        Dim stackTrace = m_targetEx.StackTrace.Split(New Char() {Chr(10)})

        For Each st In stackTrace
          StackTraceListView.Items.Add(New ListViewItem(st))
        Next

        m_hasStackTraceBeenCalled = True

      End If

    End Sub

    Private Sub DisplayOtherInformation()

      If Not m_hasOtherInformationBeenCalled Then

        Dim ht = GetCustomExceptionInfo(m_targetEx)
        Dim ide = ht.GetEnumerator()

        OtherInfoListView.Items.Clear()
        OtherInfoListView.BeginUpdate()

        While ide.MoveNext()
          Dim lvi = New ListViewItem(ide.Key.ToString())
          If Not ide.Value Is Nothing Then
            lvi.SubItems.Add(ide.Value.ToString())
          End If
          OtherInfoListView.Items.Add(lvi)
        End While

        OtherInfoListView.EndUpdate()
        m_hasOtherInformationBeenCalled = True

      End If

    End Sub

    Private Sub DisplayTabInfo()
      Select Case InfoTabControl.SelectedIndex
        Case 0 : DisplayGeneralInformation()  ' General info
        Case 1 : DisplayStackTrace()          '  Stack trace info.
        Case 2 : DisplayInnerExceptionTrace() '  Inner exception info.
        Case 3 : DisplayOtherInformation()    '  Other information.
        Case Else
      End Select
    End Sub

    Private Sub InfoTabControl_SelectedIndexChanged(sender As Object, e As EventArgs) Handles InfoTabControl.SelectedIndexChanged
      DisplayTabInfo()
    End Sub

#If XP Then

#Region "Win32 Interop - Determine if XP Themes are enabled."

    Private Declare Function LoadLibrary Lib "kernel32.dll" Alias "LoadLibraryA" (path As String) As IntPtr
    Private Declare Function GetProcAddress Lib "kernel32.dll" (library As IntPtr, procName As String) As IntPtr
    Private Declare Function FreeLibrary Lib "kernel32.dll" (library As IntPtr) As Boolean
    Private Declare Function IsThemeActive Lib "uxtheme.dll" () As Boolean
    Private Declare Function IsAppThemed Lib "uxtheme.dll" () As Boolean

    Private Function XPThemesEnabled() As Boolean

      Dim os = Environment.OSVersion

      If os.Platform = PlatformID.Win32NT AndAlso (((os.Version.Major = 5) AndAlso (os.Version.Minor >= 1)) OrElse (os.Version.Major > 5)) Then
        Dim uxTheme = LoadLibrary("uxtheme.dll")
        If Not uxTheme.Equals(IntPtr.Zero) Then
          Dim handle = GetProcAddress(uxTheme, "IsThemeActive")
          If handle.Equals(IntPtr.Zero) Then
            ' an error occured, use GetLastError
          Else
            If IsThemeActive() Then
              Return IsAppThemed
            End If
          End If
        Else
          ' an error occured, use GetLastError
        End If
        FreeLibrary(uxTheme)
      End If

      Return False

    End Function

#End Region

#End If

  End Class

End Namespace