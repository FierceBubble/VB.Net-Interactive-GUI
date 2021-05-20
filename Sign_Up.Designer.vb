<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sign_Up
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Sign_Up))
        Me.SignUp_btn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Password = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Member_ID = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Confirm_Password = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.NameMem = New System.Windows.Forms.TextBox()
        Me.label5 = New System.Windows.Forms.Label()
        Me.Age = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SignUp_btn
        '
        Me.SignUp_btn.Location = New System.Drawing.Point(108, 440)
        Me.SignUp_btn.Name = "SignUp_btn"
        Me.SignUp_btn.Size = New System.Drawing.Size(95, 23)
        Me.SignUp_btn.TabIndex = 13
        Me.SignUp_btn.Text = "Sign-Up"
        Me.SignUp_btn.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(77, 311)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Password :"
        '
        'Password
        '
        Me.Password.Location = New System.Drawing.Point(80, 327)
        Me.Password.Name = "Password"
        Me.Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Password.Size = New System.Drawing.Size(157, 20)
        Me.Password.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(77, 258)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Membership ID :"
        '
        'Member_ID
        '
        Me.Member_ID.Location = New System.Drawing.Point(80, 274)
        Me.Member_ID.Name = "Member_ID"
        Me.Member_ID.Size = New System.Drawing.Size(157, 20)
        Me.Member_ID.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(77, 370)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Confirm Password :"
        '
        'Confirm_Password
        '
        Me.Confirm_Password.Location = New System.Drawing.Point(80, 386)
        Me.Confirm_Password.Name = "Confirm_Password"
        Me.Confirm_Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Confirm_Password.Size = New System.Drawing.Size(157, 20)
        Me.Confirm_Password.TabIndex = 12
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.BP_Final_Assessment.My.Resources.Resources.DA1
        Me.PictureBox1.Location = New System.Drawing.Point(63, 59)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(192, 63)
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(77, 144)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(41, 13)
        Me.label4.TabIndex = 17
        Me.label4.Text = "Name :"
        '
        'NameMem
        '
        Me.NameMem.Location = New System.Drawing.Point(80, 160)
        Me.NameMem.Name = "NameMem"
        Me.NameMem.Size = New System.Drawing.Size(157, 20)
        Me.NameMem.TabIndex = 16
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(77, 201)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(32, 13)
        Me.label5.TabIndex = 19
        Me.label5.Text = "Age :"
        '
        'Age
        '
        Me.Age.Location = New System.Drawing.Point(80, 217)
        Me.Age.Name = "Age"
        Me.Age.Size = New System.Drawing.Size(157, 20)
        Me.Age.TabIndex = 18
        '
        'Sign_Up
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(314, 511)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.Age)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.NameMem)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Confirm_Password)
        Me.Controls.Add(Me.SignUp_btn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Password)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Member_ID)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Sign_Up"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "Sign-Up"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SignUp_btn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Password As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Member_ID As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Confirm_Password As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents label4 As Label
    Friend WithEvents NameMem As TextBox
    Friend WithEvents label5 As Label
    Friend WithEvents Age As TextBox
End Class
