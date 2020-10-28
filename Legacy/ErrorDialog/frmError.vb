Option Explicit On 
Option Strict On

Imports System.Reflection

Namespace ErrorDialog

  Public Class ErrorForm
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    'Public Sub New()
    '  MyBase.New()

    '  'This call is required by the Windows Form Designer.
    '  InitializeComponent()

    '  'Add any initialization after the InitializeComponent() call

    'End Sub

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
    Friend WithEvents chdDescription As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtExceptionTypeValue As System.Windows.Forms.TextBox
    Friend WithEvents chdName As System.Windows.Forms.ColumnHeader
    Friend WithEvents chdMethod As System.Windows.Forms.ColumnHeader
    Friend WithEvents tabInfo As System.Windows.Forms.TabControl
    Friend WithEvents tabGeneral As System.Windows.Forms.TabPage
    Friend WithEvents txtHelpLinkValue As System.Windows.Forms.TextBox
    Friend WithEvents lblHelpLink As System.Windows.Forms.Label
    Friend WithEvents txtExceptionSourceValue As System.Windows.Forms.TextBox
    Friend WithEvents txtExceptionTargetMethodValue As System.Windows.Forms.TextBox
    Friend WithEvents txtExceptionMessageValue As System.Windows.Forms.TextBox
    Friend WithEvents lblExceptionTargetMethod As System.Windows.Forms.Label
    Friend WithEvents lblExceptionSource As System.Windows.Forms.Label
    Friend WithEvents lblExceptionMessage As System.Windows.Forms.Label
    Friend WithEvents tabInner As System.Windows.Forms.TabPage
    Friend WithEvents trvInnerExceptions As System.Windows.Forms.TreeView
    Friend WithEvents tabStack As System.Windows.Forms.TabPage
    Friend WithEvents lstStackTrace As System.Windows.Forms.ListView
    Friend WithEvents tabSpecific As System.Windows.Forms.TabPage
    Friend WithEvents lstOtherInfo As System.Windows.Forms.ListView
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents lblError As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
      Me.chdDescription = New System.Windows.Forms.ColumnHeader
      Me.txtExceptionTypeValue = New System.Windows.Forms.TextBox
      Me.chdName = New System.Windows.Forms.ColumnHeader
      Me.chdMethod = New System.Windows.Forms.ColumnHeader
      Me.tabInfo = New System.Windows.Forms.TabControl
      Me.tabGeneral = New System.Windows.Forms.TabPage
      Me.txtHelpLinkValue = New System.Windows.Forms.TextBox
      Me.lblHelpLink = New System.Windows.Forms.Label
      Me.txtExceptionSourceValue = New System.Windows.Forms.TextBox
      Me.txtExceptionTargetMethodValue = New System.Windows.Forms.TextBox
      Me.txtExceptionMessageValue = New System.Windows.Forms.TextBox
      Me.lblExceptionTargetMethod = New System.Windows.Forms.Label
      Me.lblExceptionSource = New System.Windows.Forms.Label
      Me.lblExceptionMessage = New System.Windows.Forms.Label
      Me.tabStack = New System.Windows.Forms.TabPage
      Me.lstStackTrace = New System.Windows.Forms.ListView
      Me.tabInner = New System.Windows.Forms.TabPage
      Me.trvInnerExceptions = New System.Windows.Forms.TreeView
      Me.tabSpecific = New System.Windows.Forms.TabPage
      Me.lstOtherInfo = New System.Windows.Forms.ListView
      Me.btnOK = New System.Windows.Forms.Button
      Me.lblError = New System.Windows.Forms.Label
      Me.tabInfo.SuspendLayout()
      Me.tabGeneral.SuspendLayout()
      Me.tabStack.SuspendLayout()
      Me.tabInner.SuspendLayout()
      Me.tabSpecific.SuspendLayout()
      Me.SuspendLayout()
      '
      'chdDescription
      '
      Me.chdDescription.Text = "Description"
      Me.chdDescription.Width = 220
      '
      'txtExceptionTypeValue
      '
      Me.txtExceptionTypeValue.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.txtExceptionTypeValue.Location = New System.Drawing.Point(192, 7)
      Me.txtExceptionTypeValue.Name = "txtExceptionTypeValue"
      Me.txtExceptionTypeValue.ReadOnly = True
      Me.txtExceptionTypeValue.Size = New System.Drawing.Size(256, 20)
      Me.txtExceptionTypeValue.TabIndex = 24
      Me.txtExceptionTypeValue.TabStop = False
      Me.txtExceptionTypeValue.Text = ""
      '
      'chdName
      '
      Me.chdName.Text = "Name"
      Me.chdName.Width = 120
      '
      'chdMethod
      '
      Me.chdMethod.Text = "Method"
      Me.chdMethod.Width = 400
      '
      'tabInfo
      '
      Me.tabInfo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                  Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.tabInfo.Controls.Add(Me.tabGeneral)
      Me.tabInfo.Controls.Add(Me.tabStack)
      Me.tabInfo.Controls.Add(Me.tabInner)
      Me.tabInfo.Controls.Add(Me.tabSpecific)
      Me.tabInfo.Location = New System.Drawing.Point(8, 33)
      Me.tabInfo.Name = "tabInfo"
      Me.tabInfo.SelectedIndex = 0
      Me.tabInfo.Size = New System.Drawing.Size(440, 176)
      Me.tabInfo.TabIndex = 23
      '
      'tabGeneral
      '
      Me.tabGeneral.Controls.Add(Me.txtHelpLinkValue)
      Me.tabGeneral.Controls.Add(Me.lblHelpLink)
      Me.tabGeneral.Controls.Add(Me.txtExceptionSourceValue)
      Me.tabGeneral.Controls.Add(Me.txtExceptionTargetMethodValue)
      Me.tabGeneral.Controls.Add(Me.txtExceptionMessageValue)
      Me.tabGeneral.Controls.Add(Me.lblExceptionTargetMethod)
      Me.tabGeneral.Controls.Add(Me.lblExceptionSource)
      Me.tabGeneral.Controls.Add(Me.lblExceptionMessage)
      Me.tabGeneral.Location = New System.Drawing.Point(4, 22)
      Me.tabGeneral.Name = "tabGeneral"
      Me.tabGeneral.Size = New System.Drawing.Size(432, 150)
      Me.tabGeneral.TabIndex = 0
      Me.tabGeneral.Text = "General Information"
      '
      'txtHelpLinkValue
      '
      Me.txtHelpLinkValue.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.txtHelpLinkValue.Location = New System.Drawing.Point(96, 120)
      Me.txtHelpLinkValue.Name = "txtHelpLinkValue"
      Me.txtHelpLinkValue.ReadOnly = True
      Me.txtHelpLinkValue.Size = New System.Drawing.Size(328, 20)
      Me.txtHelpLinkValue.TabIndex = 23
      Me.txtHelpLinkValue.TabStop = False
      Me.txtHelpLinkValue.Text = ""
      '
      'lblHelpLink
      '
      Me.lblHelpLink.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
      Me.lblHelpLink.FlatStyle = System.Windows.Forms.FlatStyle.System
      Me.lblHelpLink.Location = New System.Drawing.Point(8, 120)
      Me.lblHelpLink.Name = "lblHelpLink"
      Me.lblHelpLink.Size = New System.Drawing.Size(80, 16)
      Me.lblHelpLink.TabIndex = 22
      Me.lblHelpLink.Text = "Help Link:"
      Me.lblHelpLink.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      '
      'txtExceptionSourceValue
      '
      Me.txtExceptionSourceValue.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.txtExceptionSourceValue.Location = New System.Drawing.Point(96, 72)
      Me.txtExceptionSourceValue.Name = "txtExceptionSourceValue"
      Me.txtExceptionSourceValue.ReadOnly = True
      Me.txtExceptionSourceValue.Size = New System.Drawing.Size(328, 20)
      Me.txtExceptionSourceValue.TabIndex = 21
      Me.txtExceptionSourceValue.TabStop = False
      Me.txtExceptionSourceValue.Text = ""
      '
      'txtExceptionTargetMethodValue
      '
      Me.txtExceptionTargetMethodValue.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.txtExceptionTargetMethodValue.Location = New System.Drawing.Point(96, 96)
      Me.txtExceptionTargetMethodValue.Name = "txtExceptionTargetMethodValue"
      Me.txtExceptionTargetMethodValue.ReadOnly = True
      Me.txtExceptionTargetMethodValue.Size = New System.Drawing.Size(328, 20)
      Me.txtExceptionTargetMethodValue.TabIndex = 19
      Me.txtExceptionTargetMethodValue.TabStop = False
      Me.txtExceptionTargetMethodValue.Text = ""
      '
      'txtExceptionMessageValue
      '
      Me.txtExceptionMessageValue.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                  Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.txtExceptionMessageValue.Location = New System.Drawing.Point(96, 8)
      Me.txtExceptionMessageValue.Multiline = True
      Me.txtExceptionMessageValue.Name = "txtExceptionMessageValue"
      Me.txtExceptionMessageValue.ReadOnly = True
      Me.txtExceptionMessageValue.Size = New System.Drawing.Size(328, 56)
      Me.txtExceptionMessageValue.TabIndex = 18
      Me.txtExceptionMessageValue.TabStop = False
      Me.txtExceptionMessageValue.Text = ""
      '
      'lblExceptionTargetMethod
      '
      Me.lblExceptionTargetMethod.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
      Me.lblExceptionTargetMethod.FlatStyle = System.Windows.Forms.FlatStyle.System
      Me.lblExceptionTargetMethod.Location = New System.Drawing.Point(8, 96)
      Me.lblExceptionTargetMethod.Name = "lblExceptionTargetMethod"
      Me.lblExceptionTargetMethod.Size = New System.Drawing.Size(80, 16)
      Me.lblExceptionTargetMethod.TabIndex = 16
      Me.lblExceptionTargetMethod.Text = "Target Method:"
      Me.lblExceptionTargetMethod.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      '
      'lblExceptionSource
      '
      Me.lblExceptionSource.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
      Me.lblExceptionSource.FlatStyle = System.Windows.Forms.FlatStyle.System
      Me.lblExceptionSource.Location = New System.Drawing.Point(8, 72)
      Me.lblExceptionSource.Name = "lblExceptionSource"
      Me.lblExceptionSource.Size = New System.Drawing.Size(80, 16)
      Me.lblExceptionSource.TabIndex = 14
      Me.lblExceptionSource.Text = "Source:"
      Me.lblExceptionSource.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      '
      'lblExceptionMessage
      '
      Me.lblExceptionMessage.FlatStyle = System.Windows.Forms.FlatStyle.System
      Me.lblExceptionMessage.Location = New System.Drawing.Point(8, 8)
      Me.lblExceptionMessage.Name = "lblExceptionMessage"
      Me.lblExceptionMessage.Size = New System.Drawing.Size(80, 16)
      Me.lblExceptionMessage.TabIndex = 12
      Me.lblExceptionMessage.Text = "Message:"
      Me.lblExceptionMessage.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      '
      'tabStack
      '
      Me.tabStack.Controls.Add(Me.lstStackTrace)
      Me.tabStack.Location = New System.Drawing.Point(4, 22)
      Me.tabStack.Name = "tabStack"
      Me.tabStack.Size = New System.Drawing.Size(432, 150)
      Me.tabStack.TabIndex = 2
      Me.tabStack.Text = "Stack Trace"
      Me.tabStack.Visible = False
      '
      'lstStackTrace
      '
      Me.lstStackTrace.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                  Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.lstStackTrace.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chdMethod})
      Me.lstStackTrace.Location = New System.Drawing.Point(8, 7)
      Me.lstStackTrace.Name = "lstStackTrace"
      Me.lstStackTrace.Size = New System.Drawing.Size(416, 136)
      Me.lstStackTrace.TabIndex = 1
      Me.lstStackTrace.View = System.Windows.Forms.View.Details
      '
      'tabInner
      '
      Me.tabInner.Controls.Add(Me.trvInnerExceptions)
      Me.tabInner.Location = New System.Drawing.Point(4, 22)
      Me.tabInner.Name = "tabInner"
      Me.tabInner.Size = New System.Drawing.Size(432, 150)
      Me.tabInner.TabIndex = 1
      Me.tabInner.Text = "Inner Exception Trace"
      Me.tabInner.Visible = False
      '
      'trvInnerExceptions
      '
      Me.trvInnerExceptions.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                  Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.trvInnerExceptions.ImageIndex = -1
      Me.trvInnerExceptions.Location = New System.Drawing.Point(8, 8)
      Me.trvInnerExceptions.Name = "trvInnerExceptions"
      Me.trvInnerExceptions.SelectedImageIndex = -1
      Me.trvInnerExceptions.Size = New System.Drawing.Size(416, 136)
      Me.trvInnerExceptions.TabIndex = 0
      '
      'tabSpecific
      '
      Me.tabSpecific.Controls.Add(Me.lstOtherInfo)
      Me.tabSpecific.Location = New System.Drawing.Point(4, 22)
      Me.tabSpecific.Name = "tabSpecific"
      Me.tabSpecific.Size = New System.Drawing.Size(432, 150)
      Me.tabSpecific.TabIndex = 3
      Me.tabSpecific.Text = "Other Information"
      Me.tabSpecific.Visible = False
      '
      'lstOtherInfo
      '
      Me.lstOtherInfo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                  Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.lstOtherInfo.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chdName, Me.chdDescription})
      Me.lstOtherInfo.Location = New System.Drawing.Point(8, 8)
      Me.lstOtherInfo.Name = "lstOtherInfo"
      Me.lstOtherInfo.Size = New System.Drawing.Size(416, 136)
      Me.lstOtherInfo.TabIndex = 0
      Me.lstOtherInfo.View = System.Windows.Forms.View.Details
      '
      'btnOK
      '
      Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK
      Me.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.System
      Me.btnOK.Location = New System.Drawing.Point(368, 220)
      Me.btnOK.Name = "btnOK"
      Me.btnOK.Size = New System.Drawing.Size(80, 24)
      Me.btnOK.TabIndex = 21
      Me.btnOK.Text = "&OK"
      '
      'lblError
      '
      Me.lblError.FlatStyle = System.Windows.Forms.FlatStyle.System
      Me.lblError.Location = New System.Drawing.Point(8, 9)
      Me.lblError.Name = "lblError"
      Me.lblError.Size = New System.Drawing.Size(200, 16)
      Me.lblError.TabIndex = 22
      Me.lblError.Text = "The following exception has occurred:"
      '
      'ErrorForm
      '
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.ClientSize = New System.Drawing.Size(456, 254)
      Me.Controls.Add(Me.txtExceptionTypeValue)
      Me.Controls.Add(Me.tabInfo)
      Me.Controls.Add(Me.btnOK)
      Me.Controls.Add(Me.lblError)
      Me.MinimizeBox = False
      Me.Name = "ErrorForm"
      Me.Text = "Exception Information"
      Me.tabInfo.ResumeLayout(False)
      Me.tabGeneral.ResumeLayout(False)
      Me.tabStack.ResumeLayout(False)
      Me.tabInner.ResumeLayout(False)
      Me.tabSpecific.ResumeLayout(False)
      Me.ResumeLayout(False)

    End Sub

#End Region

    Private m_TargetEx As Exception
    Private m_hasGeneralBeenCalled As Boolean = False
    Private m_hasInnerExceptionBeenCalled As Boolean = False
    Private m_hasStackTraceBeenCalled As Boolean = False
    Private m_hasOtherInformationBeenCalled As Boolean = False
    Private m_enableVisualStyles As Boolean = False

    Public Sub New(ByVal targetException As Exception, ByVal enableVisualStyles As Boolean)
      InitializeComponent()
      m_enableVisualStyles = enableVisualStyles
      m_TargetEx = targetException
    End Sub

    Public Sub New(ByVal targetException As Exception)
      InitializeComponent()
      m_TargetEx = targetException
    End Sub

    Private Sub ErrorForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

      If m_enableVisualStyles AndAlso XPThemesEnabled() Then
        ' Just cheat and set to white, since most of the tab is covered anyway.
        tabGeneral.BackColor = Color.White
        tabInfo.BackColor = Color.White
        tabInner.BackColor = Color.White
        tabSpecific.BackColor = Color.White
        tabStack.BackColor = Color.White
      End If

      If Not m_TargetEx Is Nothing Then
        txtExceptionTypeValue.Text = m_TargetEx.GetType().FullName
        DisplayGeneralInformation()
      Else
        tabInfo.Enabled = False
        txtExceptionTypeValue.Text = "Unknown"
      End If

    End Sub

    Private Sub DisplayGeneralInformation()
      If Not m_TargetEx Is Nothing AndAlso m_hasGeneralBeenCalled = False Then
        txtExceptionMessageValue.Text = m_TargetEx.Message
        txtExceptionSourceValue.Text = m_TargetEx.Source
        txtExceptionTargetMethodValue.Text = GetTargetMethodFormat(m_TargetEx)
        txtHelpLinkValue.Text = m_TargetEx.HelpLink
        m_hasGeneralBeenCalled = True
      End If
    End Sub

    Private Function GetTargetMethodFormat(ByVal Ex As Exception) As String
      Return "[" & Ex.TargetSite.DeclaringType.Assembly.GetName().Name & "]" & Ex.TargetSite.DeclaringType.ToString & "::" & Ex.TargetSite.Name & "()"
    End Function

    Private Function GetCustomExceptionInfo(ByVal Ex As Exception) As Hashtable

      Dim customInfo As New Hashtable

      Dim pi As PropertyInfo
      For Each pi In Ex.GetType().GetProperties()
        Dim baseEx As Type = GetType(System.Exception)
        If baseEx.GetProperty(pi.Name) Is Nothing Then
          customInfo.Add(pi.Name, pi.GetValue(Ex, Nothing))
        End If
      Next

      Return customInfo

    End Function

    Private Sub DisplayInnerExceptionTrace()

      If False = m_hasInnerExceptionBeenCalled Then
        Dim innerEx As Exception = m_TargetEx
        Dim parentNode As TreeNode = Nothing
        Dim childNode As TreeNode = Nothing
        Dim childMessage As TreeNode = Nothing
        Dim childTarget As TreeNode = Nothing

        trvInnerExceptions.BeginUpdate()

        While Not innerEx Is Nothing
          childNode = New TreeNode(innerEx.GetType().FullName)
          '  For now, add just the message.
          childMessage = New TreeNode(innerEx.Message)
          childTarget = New TreeNode(GetTargetMethodFormat(innerEx))

          childNode.Nodes.Add(childMessage)
          childNode.Nodes.Add(childTarget)

          If Not parentNode Is Nothing Then
            parentNode.Nodes.Add(childNode)
          Else
            trvInnerExceptions.Nodes.Add(childNode)
          End If

          parentNode = childNode
          innerEx = innerEx.InnerException
        End While

        trvInnerExceptions.EndUpdate()
        m_hasInnerExceptionBeenCalled = True
      End If

    End Sub

    Private Sub DisplayStackTrace()
      If False = m_hasStackTraceBeenCalled Then

        Dim stackTrace As String() = m_TargetEx.StackTrace.Split(New Char() {Chr(10)})

        Dim st As String

        For Each st In stackTrace
          lstStackTrace.Items.Add(New ListViewItem(st))
        Next st

        m_hasStackTraceBeenCalled = True

      End If

    End Sub

    Private Sub DisplayOtherInformation()

      If False = m_hasOtherInformationBeenCalled Then

        Dim ht As Hashtable = GetCustomExceptionInfo(m_TargetEx)
        Dim ide As IDictionaryEnumerator = ht.GetEnumerator()

        lstOtherInfo.Items.Clear()
        lstOtherInfo.BeginUpdate()

        Dim lvi As ListViewItem

        While ide.MoveNext()
          lvi = New ListViewItem(ide.Key.ToString())
          If Not ide.Value Is Nothing Then
            lvi.SubItems.Add(ide.Value.ToString())
          End If
          lstOtherInfo.Items.Add(lvi)
        End While

        lstOtherInfo.EndUpdate()
        m_hasOtherInformationBeenCalled = True
      End If

    End Sub

    Private Sub DisplayTabInfo()
      Select Case tabInfo.SelectedIndex
        Case 0 ' General info
          DisplayGeneralInformation()
        Case 1 '  Stack trace info.
          DisplayStackTrace()
        Case 2 '  Inner exception info.
          DisplayInnerExceptionTrace()
        Case 3 '  Other information.
          DisplayOtherInformation()
        Case Else
      End Select
    End Sub

    Private Sub tabInfo_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tabInfo.SelectedIndexChanged
      DisplayTabInfo()
    End Sub

#Region "Win32 Interop - Determine if XP Themes are enabled."

    Private Declare Function LoadLibrary Lib "kernel32.dll" Alias "LoadLibraryA" (ByVal path As String) As IntPtr
    Private Declare Function GetProcAddress Lib "kernel32.dll" (ByVal library As IntPtr, ByVal procName As String) As IntPtr
    Private Declare Function FreeLibrary Lib "kernel32.dll" (ByVal library As IntPtr) As Boolean
    Private Declare Function IsThemeActive Lib "uxtheme.dll" () As Boolean
    Private Declare Function IsAppThemed Lib "uxtheme.dll" () As Boolean

    Private Function XPThemesEnabled() As Boolean

      Dim os As OperatingSystem = System.Environment.OSVersion

      If os.Platform = PlatformID.Win32NT AndAlso (((os.Version.Major = 5) And (os.Version.Minor >= 1)) Or (os.Version.Major > 5)) Then
        Dim uxTheme As IntPtr = LoadLibrary("uxtheme.dll")
        If Not uxTheme.Equals(IntPtr.Zero) Then
          Dim handle As IntPtr = GetProcAddress(uxTheme, "IsThemeActive")
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

  End Class

End Namespace