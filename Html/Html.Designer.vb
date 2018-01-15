<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Html
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
      Me.Parse = New System.Windows.Forms.Button()
      Me.SuspendLayout()
      '
      'Parse
      '
      Me.Parse.Location = New System.Drawing.Point(12, 227)
      Me.Parse.Name = "Parse"
      Me.Parse.Size = New System.Drawing.Size(75, 23)
      Me.Parse.TabIndex = 0
      Me.Parse.Text = "Parse"
      Me.Parse.UseVisualStyleBackColor = True
      '
      'Html
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(284, 262)
      Me.Controls.Add(Me.Parse)
      Me.Name = "Html"
      Me.Text = "Html"
      Me.ResumeLayout(False)

   End Sub

   Friend WithEvents Parse As Button
End Class
