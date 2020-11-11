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
  <System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
        Me.OpaqueExceptionDialogButton = New System.Windows.Forms.Button()
        Me.CreateAnotherCustomExceptionButton = New System.Windows.Forms.Button()
        Me.CreateExceptionWithStackFrameButton = New System.Windows.Forms.Button()
        Me.CustomExceptionButton = New System.Windows.Forms.Button()
        Me.CreateInnerExceptionButton = New System.Windows.Forms.Button()
        Me.CreateExceptionButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'OpaqueExceptionDialogButton
        '
        Me.OpaqueExceptionDialogButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.OpaqueExceptionDialogButton.Location = New System.Drawing.Point(12, 209)
        Me.OpaqueExceptionDialogButton.Name = "OpaqueExceptionDialogButton"
        Me.OpaqueExceptionDialogButton.Size = New System.Drawing.Size(326, 30)
        Me.OpaqueExceptionDialogButton.TabIndex = 18
        Me.OpaqueExceptionDialogButton.Text = "Display Opaque Error Dialog"
        '
        'CreateAnotherCustomExceptionButton
        '
        Me.CreateAnotherCustomExceptionButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CreateAnotherCustomExceptionButton.Location = New System.Drawing.Point(12, 170)
        Me.CreateAnotherCustomExceptionButton.Name = "CreateAnotherCustomExceptionButton"
        Me.CreateAnotherCustomExceptionButton.Size = New System.Drawing.Size(326, 29)
        Me.CreateAnotherCustomExceptionButton.TabIndex = 17
        Me.CreateAnotherCustomExceptionButton.Text = "Create Another Custom Exception"
        '
        'CreateExceptionWithStackFrameButton
        '
        Me.CreateExceptionWithStackFrameButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CreateExceptionWithStackFrameButton.Location = New System.Drawing.Point(12, 52)
        Me.CreateExceptionWithStackFrameButton.Name = "CreateExceptionWithStackFrameButton"
        Me.CreateExceptionWithStackFrameButton.Size = New System.Drawing.Size(326, 29)
        Me.CreateExceptionWithStackFrameButton.TabIndex = 14
        Me.CreateExceptionWithStackFrameButton.Text = "Create Exception W/ Stack Frame"
        '
        'CustomExceptionButton
        '
        Me.CustomExceptionButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CustomExceptionButton.Location = New System.Drawing.Point(12, 131)
        Me.CustomExceptionButton.Name = "CustomExceptionButton"
        Me.CustomExceptionButton.Size = New System.Drawing.Size(326, 29)
        Me.CustomExceptionButton.TabIndex = 16
        Me.CustomExceptionButton.Text = "Create Custom Exception"
        '
        'CreateInnerExceptionButton
        '
        Me.CreateInnerExceptionButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CreateInnerExceptionButton.Location = New System.Drawing.Point(12, 91)
        Me.CreateInnerExceptionButton.Name = "CreateInnerExceptionButton"
        Me.CreateInnerExceptionButton.Size = New System.Drawing.Size(326, 30)
        Me.CreateInnerExceptionButton.TabIndex = 15
        Me.CreateInnerExceptionButton.Text = "Create Exception With Inner Exceptions"
        '
        'CreateExceptionButton
        '
        Me.CreateExceptionButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CreateExceptionButton.Location = New System.Drawing.Point(12, 12)
        Me.CreateExceptionButton.Name = "CreateExceptionButton"
        Me.CreateExceptionButton.Size = New System.Drawing.Size(326, 30)
        Me.CreateExceptionButton.TabIndex = 13
        Me.CreateExceptionButton.Text = "Create Exception"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(357, 256)
        Me.Controls.Add(Me.OpaqueExceptionDialogButton)
        Me.Controls.Add(Me.CreateAnotherCustomExceptionButton)
        Me.Controls.Add(Me.CreateExceptionWithStackFrameButton)
        Me.Controls.Add(Me.CustomExceptionButton)
        Me.Controls.Add(Me.CreateInnerExceptionButton)
        Me.Controls.Add(Me.CreateExceptionButton)
        Me.Name = "Form1"
        Me.Text = "Exception Handling Tests"
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents OpaqueExceptionDialogButton As Button
    Private WithEvents CreateAnotherCustomExceptionButton As Button
    Private WithEvents CreateExceptionWithStackFrameButton As Button
    Private WithEvents CustomExceptionButton As Button
    Private WithEvents CreateInnerExceptionButton As Button
    Private WithEvents CreateExceptionButton As Button
End Class
