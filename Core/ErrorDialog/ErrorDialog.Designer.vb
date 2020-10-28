<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ErrorForm
  Inherits System.Windows.Forms.Form

  'Form overrides dispose to clean up the component list.
  <System.Diagnostics.DebuggerNonUserCode()>
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
  Private WithEvents DescriptionColumnHeader As ColumnHeader
  Private WithEvents ExceptionTypeValueTextBox As TextBox
  Private WithEvents NameColumnHeader As ColumnHeader
  Private WithEvents MethodColumnHeader As ColumnHeader
  Private WithEvents InfoTabControl As TabControl
  Private WithEvents GeneralTabPage As TabPage
  Private WithEvents HelpLinkValueTextBox As TextBox
  Private WithEvents HelpLinkLabel As Label
  Private WithEvents ExceptionSourceValueTextBox As TextBox
  Private WithEvents ExceptionTargetMethodValueTextBox As TextBox
  Private WithEvents ExceptionMessageValueTextBox As TextBox
  Private WithEvents ExceptionTargetMethodLabel As Label
  Private WithEvents ExceptionSourceLabel As Label
  Private WithEvents ExceptionMessageLabel As Label
  Private WithEvents InnerTabPage As TabPage
  Private WithEvents InnerExceptionsTreeView As TreeView
  Private WithEvents StackTabPage As TabPage
  Private WithEvents StackTraceListView As ListView
  Private WithEvents SpecificTabPage As TabPage
  Private WithEvents OtherInfoListView As ListView
  Private WithEvents OkButton As Button
  Private WithEvents ErrorLabel As Label
  <System.Diagnostics.DebuggerStepThrough()>
  Private Sub InitializeComponent()
    Me.DescriptionColumnHeader = New System.Windows.Forms.ColumnHeader()
    Me.ExceptionTypeValueTextBox = New System.Windows.Forms.TextBox()
    Me.NameColumnHeader = New System.Windows.Forms.ColumnHeader()
    Me.MethodColumnHeader = New System.Windows.Forms.ColumnHeader()
    Me.InfoTabControl = New System.Windows.Forms.TabControl()
    Me.GeneralTabPage = New System.Windows.Forms.TabPage()
    Me.HelpLinkValueTextBox = New System.Windows.Forms.TextBox()
    Me.HelpLinkLabel = New System.Windows.Forms.Label()
    Me.ExceptionSourceValueTextBox = New System.Windows.Forms.TextBox()
    Me.ExceptionTargetMethodValueTextBox = New System.Windows.Forms.TextBox()
    Me.ExceptionMessageValueTextBox = New System.Windows.Forms.TextBox()
    Me.ExceptionTargetMethodLabel = New System.Windows.Forms.Label()
    Me.ExceptionSourceLabel = New System.Windows.Forms.Label()
    Me.ExceptionMessageLabel = New System.Windows.Forms.Label()
    Me.StackTabPage = New System.Windows.Forms.TabPage()
    Me.StackTraceListView = New System.Windows.Forms.ListView()
    Me.InnerTabPage = New System.Windows.Forms.TabPage()
    Me.InnerExceptionsTreeView = New System.Windows.Forms.TreeView()
    Me.SpecificTabPage = New System.Windows.Forms.TabPage()
    Me.OtherInfoListView = New System.Windows.Forms.ListView()
    Me.OkButton = New System.Windows.Forms.Button()
    Me.ErrorLabel = New System.Windows.Forms.Label()
    Me.InfoTabControl.SuspendLayout()
    Me.GeneralTabPage.SuspendLayout()
    Me.StackTabPage.SuspendLayout()
    Me.InnerTabPage.SuspendLayout()
    Me.SpecificTabPage.SuspendLayout()
    Me.SuspendLayout()
    '
    'DescriptionColumnHeader
    '
    Me.DescriptionColumnHeader.Name = "DescriptionColumnHeader"
    Me.DescriptionColumnHeader.Text = "Description"
    Me.DescriptionColumnHeader.Width = 220
    '
    'ExceptionTypeValueTextBox
    '
    Me.ExceptionTypeValueTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.ExceptionTypeValueTextBox.Location = New System.Drawing.Point(230, 9)
    Me.ExceptionTypeValueTextBox.Name = "ExceptionTypeValueTextBox"
    Me.ExceptionTypeValueTextBox.ReadOnly = True
    Me.ExceptionTypeValueTextBox.Size = New System.Drawing.Size(217, 23)
    Me.ExceptionTypeValueTextBox.TabIndex = 24
    Me.ExceptionTypeValueTextBox.TabStop = False
    '
    'NameColumnHeader
    '
    Me.NameColumnHeader.Name = "NameColumnHeader"
    Me.NameColumnHeader.Text = "Name"
    Me.NameColumnHeader.Width = 120
    '
    'MethodColumnHeader
    '
    Me.MethodColumnHeader.Name = "MethodColumnHeader"
    Me.MethodColumnHeader.Text = "Method"
    Me.MethodColumnHeader.Width = 400
    '
    'InfoTabControl
    '
    Me.InfoTabControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.InfoTabControl.Controls.Add(Me.GeneralTabPage)
    Me.InfoTabControl.Controls.Add(Me.StackTabPage)
    Me.InfoTabControl.Controls.Add(Me.InnerTabPage)
    Me.InfoTabControl.Controls.Add(Me.SpecificTabPage)
    Me.InfoTabControl.Location = New System.Drawing.Point(10, 41)
    Me.InfoTabControl.Name = "InfoTabControl"
    Me.InfoTabControl.SelectedIndex = 0
    Me.InfoTabControl.Size = New System.Drawing.Size(437, 157)
    Me.InfoTabControl.TabIndex = 23
    '
    'GeneralTabPage
    '
    Me.GeneralTabPage.Controls.Add(Me.HelpLinkValueTextBox)
    Me.GeneralTabPage.Controls.Add(Me.HelpLinkLabel)
    Me.GeneralTabPage.Controls.Add(Me.ExceptionSourceValueTextBox)
    Me.GeneralTabPage.Controls.Add(Me.ExceptionTargetMethodValueTextBox)
    Me.GeneralTabPage.Controls.Add(Me.ExceptionMessageValueTextBox)
    Me.GeneralTabPage.Controls.Add(Me.ExceptionTargetMethodLabel)
    Me.GeneralTabPage.Controls.Add(Me.ExceptionSourceLabel)
    Me.GeneralTabPage.Controls.Add(Me.ExceptionMessageLabel)
    Me.GeneralTabPage.Location = New System.Drawing.Point(4, 24)
    Me.GeneralTabPage.Name = "GeneralTabPage"
    Me.GeneralTabPage.Size = New System.Drawing.Size(429, 129)
    Me.GeneralTabPage.TabIndex = 0
    Me.GeneralTabPage.Text = "General Information"
    '
    'HelpLinkValueTextBox
    '
    Me.HelpLinkValueTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.HelpLinkValueTextBox.Location = New System.Drawing.Point(115, 89)
    Me.HelpLinkValueTextBox.Name = "HelpLinkValueTextBox"
    Me.HelpLinkValueTextBox.ReadOnly = True
    Me.HelpLinkValueTextBox.Size = New System.Drawing.Size(303, 23)
    Me.HelpLinkValueTextBox.TabIndex = 23
    Me.HelpLinkValueTextBox.TabStop = False
    '
    'HelpLinkLabel
    '
    Me.HelpLinkLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.HelpLinkLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.HelpLinkLabel.Location = New System.Drawing.Point(10, 89)
    Me.HelpLinkLabel.Name = "HelpLinkLabel"
    Me.HelpLinkLabel.Size = New System.Drawing.Size(96, 19)
    Me.HelpLinkLabel.TabIndex = 22
    Me.HelpLinkLabel.Text = "Help Link:"
    Me.HelpLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'ExceptionSourceValueTextBox
    '
    Me.ExceptionSourceValueTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.ExceptionSourceValueTextBox.Location = New System.Drawing.Point(115, 30)
    Me.ExceptionSourceValueTextBox.Name = "ExceptionSourceValueTextBox"
    Me.ExceptionSourceValueTextBox.ReadOnly = True
    Me.ExceptionSourceValueTextBox.Size = New System.Drawing.Size(303, 23)
    Me.ExceptionSourceValueTextBox.TabIndex = 21
    Me.ExceptionSourceValueTextBox.TabStop = False
    '
    'ExceptionTargetMethodValueTextBox
    '
    Me.ExceptionTargetMethodValueTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.ExceptionTargetMethodValueTextBox.Location = New System.Drawing.Point(115, 59)
    Me.ExceptionTargetMethodValueTextBox.Name = "ExceptionTargetMethodValueTextBox"
    Me.ExceptionTargetMethodValueTextBox.ReadOnly = True
    Me.ExceptionTargetMethodValueTextBox.Size = New System.Drawing.Size(303, 23)
    Me.ExceptionTargetMethodValueTextBox.TabIndex = 19
    Me.ExceptionTargetMethodValueTextBox.TabStop = False
    '
    'ExceptionMessageValueTextBox
    '
    Me.ExceptionMessageValueTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.ExceptionMessageValueTextBox.Location = New System.Drawing.Point(115, 10)
    Me.ExceptionMessageValueTextBox.Multiline = True
    Me.ExceptionMessageValueTextBox.Name = "ExceptionMessageValueTextBox"
    Me.ExceptionMessageValueTextBox.ReadOnly = True
    Me.ExceptionMessageValueTextBox.Size = New System.Drawing.Size(303, 10)
    Me.ExceptionMessageValueTextBox.TabIndex = 18
    Me.ExceptionMessageValueTextBox.TabStop = False
    '
    'ExceptionTargetMethodLabel
    '
    Me.ExceptionTargetMethodLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.ExceptionTargetMethodLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.ExceptionTargetMethodLabel.Location = New System.Drawing.Point(10, 59)
    Me.ExceptionTargetMethodLabel.Name = "ExceptionTargetMethodLabel"
    Me.ExceptionTargetMethodLabel.Size = New System.Drawing.Size(96, 20)
    Me.ExceptionTargetMethodLabel.TabIndex = 16
    Me.ExceptionTargetMethodLabel.Text = "Target Method:"
    Me.ExceptionTargetMethodLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'ExceptionSourceLabel
    '
    Me.ExceptionSourceLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.ExceptionSourceLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.ExceptionSourceLabel.Location = New System.Drawing.Point(10, 30)
    Me.ExceptionSourceLabel.Name = "ExceptionSourceLabel"
    Me.ExceptionSourceLabel.Size = New System.Drawing.Size(96, 19)
    Me.ExceptionSourceLabel.TabIndex = 14
    Me.ExceptionSourceLabel.Text = "Source:"
    Me.ExceptionSourceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'ExceptionMessageLabel
    '
    Me.ExceptionMessageLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.ExceptionMessageLabel.Location = New System.Drawing.Point(10, 10)
    Me.ExceptionMessageLabel.Name = "ExceptionMessageLabel"
    Me.ExceptionMessageLabel.Size = New System.Drawing.Size(96, 20)
    Me.ExceptionMessageLabel.TabIndex = 12
    Me.ExceptionMessageLabel.Text = "Message:"
    Me.ExceptionMessageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'StackTabPage
    '
    Me.StackTabPage.Controls.Add(Me.StackTraceListView)
    Me.StackTabPage.Location = New System.Drawing.Point(4, 24)
    Me.StackTabPage.Name = "StackTabPage"
    Me.StackTabPage.Size = New System.Drawing.Size(520, 188)
    Me.StackTabPage.TabIndex = 2
    Me.StackTabPage.Text = "Stack Trace"
    Me.StackTabPage.Visible = False
    '
    'StackTraceListView
    '
    Me.StackTraceListView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.StackTraceListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.MethodColumnHeader})
    Me.StackTraceListView.HideSelection = False
    Me.StackTraceListView.Location = New System.Drawing.Point(10, 9)
    Me.StackTraceListView.Name = "StackTraceListView"
    Me.StackTraceListView.Size = New System.Drawing.Size(499, 167)
    Me.StackTraceListView.TabIndex = 1
    Me.StackTraceListView.UseCompatibleStateImageBehavior = False
    Me.StackTraceListView.View = System.Windows.Forms.View.Details
    '
    'InnerTabPage
    '
    Me.InnerTabPage.Controls.Add(Me.InnerExceptionsTreeView)
    Me.InnerTabPage.Location = New System.Drawing.Point(4, 24)
    Me.InnerTabPage.Name = "InnerTabPage"
    Me.InnerTabPage.Size = New System.Drawing.Size(520, 188)
    Me.InnerTabPage.TabIndex = 1
    Me.InnerTabPage.Text = "Inner Exception Trace"
    Me.InnerTabPage.Visible = False
    '
    'InnerExceptionsTreeView
    '
    Me.InnerExceptionsTreeView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.InnerExceptionsTreeView.Location = New System.Drawing.Point(10, 10)
    Me.InnerExceptionsTreeView.Name = "InnerExceptionsTreeView"
    Me.InnerExceptionsTreeView.Size = New System.Drawing.Size(499, 167)
    Me.InnerExceptionsTreeView.TabIndex = 0
    '
    'SpecificTabPage
    '
    Me.SpecificTabPage.Controls.Add(Me.OtherInfoListView)
    Me.SpecificTabPage.Location = New System.Drawing.Point(4, 24)
    Me.SpecificTabPage.Name = "SpecificTabPage"
    Me.SpecificTabPage.Size = New System.Drawing.Size(520, 188)
    Me.SpecificTabPage.TabIndex = 3
    Me.SpecificTabPage.Text = "Other Information"
    Me.SpecificTabPage.Visible = False
    '
    'OtherInfoListView
    '
    Me.OtherInfoListView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.OtherInfoListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.NameColumnHeader, Me.DescriptionColumnHeader})
    Me.OtherInfoListView.HideSelection = False
    Me.OtherInfoListView.Location = New System.Drawing.Point(10, 10)
    Me.OtherInfoListView.Name = "OtherInfoListView"
    Me.OtherInfoListView.Size = New System.Drawing.Size(499, 167)
    Me.OtherInfoListView.TabIndex = 0
    Me.OtherInfoListView.UseCompatibleStateImageBehavior = False
    Me.OtherInfoListView.View = System.Windows.Forms.View.Details
    '
    'OkButton
    '
    Me.OkButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.OkButton.DialogResult = System.Windows.Forms.DialogResult.OK
    Me.OkButton.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.OkButton.Location = New System.Drawing.Point(351, 212)
    Me.OkButton.Name = "OkButton"
    Me.OkButton.Size = New System.Drawing.Size(96, 29)
    Me.OkButton.TabIndex = 21
    Me.OkButton.Text = "&OK"
    '
    'ErrorLabel
    '
    Me.ErrorLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.ErrorLabel.Location = New System.Drawing.Point(10, 11)
    Me.ErrorLabel.Name = "ErrorLabel"
    Me.ErrorLabel.Size = New System.Drawing.Size(240, 20)
    Me.ErrorLabel.TabIndex = 22
    Me.ErrorLabel.Text = "The following exception has occurred:"
    '
    'ErrorDialog
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(456, 254)
    Me.Controls.Add(Me.ExceptionTypeValueTextBox)
    Me.Controls.Add(Me.InfoTabControl)
    Me.Controls.Add(Me.OkButton)
    Me.Controls.Add(Me.ErrorLabel)
    Me.MinimizeBox = False
    Me.Name = "ErrorDialog"
    Me.Text = "Exception Information"
    Me.InfoTabControl.ResumeLayout(False)
    Me.GeneralTabPage.ResumeLayout(False)
    Me.GeneralTabPage.PerformLayout()
    Me.StackTabPage.ResumeLayout(False)
    Me.InnerTabPage.ResumeLayout(False)
    Me.SpecificTabPage.ResumeLayout(False)
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
End Class
