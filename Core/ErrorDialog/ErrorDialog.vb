Option Explicit On
Option Strict On
Option Infer On

Public Class ErrorForm

  Private ReadOnly m_targetEx As Exception
  Private m_hasGeneralBeenCalled As Boolean = False
  Private m_hasInnerExceptionBeenCalled As Boolean = False
  Private m_hasStackTraceBeenCalled As Boolean = False
  Private m_hasOtherInformationBeenCalled As Boolean = False

  Public Sub New(targetException As Exception)
    InitializeComponent()
    m_targetEx = targetException
  End Sub

  Private Sub Me_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

End Class