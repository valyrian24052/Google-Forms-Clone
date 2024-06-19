<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCreateSubmission
    Inherits System.Windows.Forms.Form

    ' Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    ' Note: The following procedure is required by the Windows Form Designer
    ' It can be modified using the Windows Form Designer.  
    ' Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.btnToggleStopwatch = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtGithubLink = New System.Windows.Forms.TextBox()
        Me.lblStopwatch = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.lblGithubLink = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        ' lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(12, 9)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(310, 24)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Shashank Sharma, Slidely Task 2 - Create Submission"
        '
        ' btnToggleStopwatch
        '
        Me.btnToggleStopwatch.BackColor = System.Drawing.Color.Gold
        Me.btnToggleStopwatch.Location = New System.Drawing.Point(12, 215)
        Me.btnToggleStopwatch.Name = "btnToggleStopwatch"
        Me.btnToggleStopwatch.Size = New System.Drawing.Size(200, 23)
        Me.btnToggleStopwatch.TabIndex = 6
        Me.btnToggleStopwatch.Text = "TOGGLE STOPWATCH (CTRL + T)"
        Me.btnToggleStopwatch.UseVisualStyleBackColor = False
        '
        ' btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnSubmit.Location = New System.Drawing.Point(12, 244)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(150, 23)
        Me.btnSubmit.TabIndex = 7
        Me.btnSubmit.Text = "SUBMIT (CTRL + S)"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        ' txtName
        '
        Me.txtName.Location = New System.Drawing.Point(12, 50)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(310, 20)
        Me.txtName.TabIndex = 1
        '
        ' txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(12, 89)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(310, 20)
        Me.txtEmail.TabIndex = 2
        '
        ' txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(12, 128)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(310, 20)
        Me.txtPhone.TabIndex = 3
        '
        ' txtGithubLink
        '
        Me.txtGithubLink.Location = New System.Drawing.Point(12, 167)
        Me.txtGithubLink.Name = "txtGithubLink"
        Me.txtGithubLink.Size = New System.Drawing.Size(310, 20)
        Me.txtGithubLink.TabIndex = 4
        '
        ' lblStopwatch
        '
        Me.lblStopwatch.AutoSize = True
        Me.lblStopwatch.Location = New System.Drawing.Point(12, 190)
        Me.lblStopwatch.Name = "lblStopwatch"
        Me.lblStopwatch.Size = New System.Drawing.Size(49, 13)
        Me.lblStopwatch.TabIndex = 5
        Me.lblStopwatch.Text = "00:00:00"
        '
        ' lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(12, 34)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(35, 13)
        Me.lblName.TabIndex = 8
        Me.lblName.Text = "Name"
        '
        ' lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(12, 73)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(32, 13)
        Me.lblEmail.TabIndex = 9
        Me.lblEmail.Text = "Email"
        '
        ' lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Location = New System.Drawing.Point(12, 112)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(78, 13)
        Me.lblPhone.TabIndex = 10
        Me.lblPhone.Text = "Phone Number"
        '
        ' lblGithubLink
        '
        Me.lblGithubLink.AutoSize = True
        Me.lblGithubLink.Location = New System.Drawing.Point(12, 151)
        Me.lblGithubLink.Name = "lblGithubLink"
        Me.lblGithubLink.Size = New System.Drawing.Size(64, 13)
        Me.lblGithubLink.TabIndex = 11
        Me.lblGithubLink.Text = "GitHub Link"
        '
        ' frmCreateSubmission
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(334, 281)
        Me.Controls.Add(Me.lblGithubLink)
        Me.Controls.Add(Me.lblPhone)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblStopwatch)
        Me.Controls.Add(Me.txtGithubLink)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.btnToggleStopwatch)
        Me.Controls.Add(Me.lblHeading)
        Me.Name = "frmCreateSubmission"
        Me.Text = "Create Submission"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeading As System.Windows.Forms.Label
    Friend WithEvents btnToggleStopwatch As System.Windows.Forms.Button
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents txtGithubLink As System.Windows.Forms.TextBox
    Friend WithEvents lblStopwatch As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents lblPhone As System.Windows.Forms.Label
    Friend WithEvents lblGithubLink As System.Windows.Forms.Label
End Class
