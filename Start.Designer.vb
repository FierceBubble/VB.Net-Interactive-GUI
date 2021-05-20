<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Sign_In
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Sign_In))
        Me.Member_ID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Password = New System.Windows.Forms.TextBox()
        Me.SignIn_btn = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SignUp_btn = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Member_ID
        '
        Me.Member_ID.Location = New System.Drawing.Point(79, 183)
        Me.Member_ID.Name = "Member_ID"
        Me.Member_ID.Size = New System.Drawing.Size(157, 20)
        Me.Member_ID.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(76, 167)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Membership ID :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(76, 239)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Password :"
        '
        'Password
        '
        Me.Password.Location = New System.Drawing.Point(79, 255)
        Me.Password.Name = "Password"
        Me.Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Password.Size = New System.Drawing.Size(157, 20)
        Me.Password.TabIndex = 2
        '
        'SignIn_btn
        '
        Me.SignIn_btn.Location = New System.Drawing.Point(107, 322)
        Me.SignIn_btn.Name = "SignIn_btn"
        Me.SignIn_btn.Size = New System.Drawing.Size(95, 23)
        Me.SignIn_btn.TabIndex = 4
        Me.SignIn_btn.Text = "Sign-In"
        Me.SignIn_btn.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label3.Location = New System.Drawing.Point(63, 371)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(189, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "---------------------------Or------------------------------" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'SignUp_btn
        '
        Me.SignUp_btn.Location = New System.Drawing.Point(107, 415)
        Me.SignUp_btn.Name = "SignUp_btn"
        Me.SignUp_btn.Size = New System.Drawing.Size(95, 23)
        Me.SignUp_btn.TabIndex = 7
        Me.SignUp_btn.Text = "Sign-Up"
        Me.SignUp_btn.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox1.Image = Global.BP_Final_Assessment.My.Resources.Resources.DA1
        Me.PictureBox1.Location = New System.Drawing.Point(63, 59)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(192, 63)
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'Sign_In
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(314, 511)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.SignUp_btn)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.SignIn_btn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Password)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Member_ID)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Sign_In"
        Me.Text = "Sign-In"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Member_ID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Password As TextBox
    Friend WithEvents SignIn_btn As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents SignUp_btn As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
