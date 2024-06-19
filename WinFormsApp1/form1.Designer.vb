<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    ' Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    ' Note: The following procedure is required by the Windows Form Designer
    ' It can be modified using the Windows Form Designer.  
    ' Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.btnViewSubmissions = New System.Windows.Forms.Button()
        Me.btnCreateSubmission = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        ' lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(12, 9)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(260, 24)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Shashank Sharma, Slidely Task 2 - Slidely Form App"
        '
        ' btnViewSubmissions
        '
        Me.btnViewSubmissions.BackColor = System.Drawing.Color.Gold
        Me.btnViewSubmissions.Location = New System.Drawing.Point(12, 50)
        Me.btnViewSubmissions.Name = "btnViewSubmissions"
        Me.btnViewSubmissions.Size = New System.Drawing.Size(260, 23)
        Me.btnViewSubmissions.TabIndex = 1
        Me.btnViewSubmissions.Text = "VIEW SUBMISSIONS (CTRL + V)"
        Me.btnViewSubmissions.UseVisualStyleBackColor = False
        '
        ' btnCreateSubmission
        '
        Me.btnCreateSubmission.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnCreateSubmission.Location = New System.Drawing.Point(12, 79)
        Me.btnCreateSubmission.Name = "btnCreateSubmission"
        Me.btnCreateSubmission.Size = New System.Drawing.Size(260, 23)
        Me.btnCreateSubmission.TabIndex = 2
        Me.btnCreateSubmission.Text = "CREATE NEW SUBMISSION (CTRL + N)"
        Me.btnCreateSubmission.UseVisualStyleBackColor = False
        '
        ' Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 111)
        Me.Controls.Add(Me.lblHeading)
        Me.Controls.Add(Me.btnCreateSubmission)
        Me.Controls.Add(Me.btnViewSubmissions)
        Me.KeyPreview = True
        Me.Name = "Form1"
        Me.Text = "Slidely Form App"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeading As System.Windows.Forms.Label
    Friend WithEvents btnViewSubmissions As System.Windows.Forms.Button
    Friend WithEvents btnCreateSubmission As System.Windows.Forms.Button

End Class
