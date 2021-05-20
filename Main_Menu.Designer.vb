<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main_Menu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main_Menu))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.InformationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox()
        Me.AppointmentDate = New System.Windows.Forms.DateTimePicker()
        Me.Doctor_requested = New System.Windows.Forms.ComboBox()
        Me.Comments_Box = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InformationToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(304, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'InformationToolStripMenuItem
        '
        Me.InformationToolStripMenuItem.Name = "InformationToolStripMenuItem"
        Me.InformationToolStripMenuItem.Size = New System.Drawing.Size(82, 20)
        Me.InformationToolStripMenuItem.Text = "Information"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RichTextBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(331, 41)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(250, 348)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Receipt"
        Me.GroupBox1.Visible = False
        '
        'RichTextBox2
        '
        Me.RichTextBox2.Location = New System.Drawing.Point(6, 19)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.ReadOnly = True
        Me.RichTextBox2.Size = New System.Drawing.Size(238, 322)
        Me.RichTextBox2.TabIndex = 5
        Me.RichTextBox2.Text = ""
        '
        'AppointmentDate
        '
        Me.AppointmentDate.Location = New System.Drawing.Point(32, 179)
        Me.AppointmentDate.Name = "AppointmentDate"
        Me.AppointmentDate.Size = New System.Drawing.Size(162, 20)
        Me.AppointmentDate.TabIndex = 2
        Me.AppointmentDate.Value = New Date(2020, 4, 18, 0, 0, 0, 0)
        '
        'Doctor_requested
        '
        Me.Doctor_requested.FormattingEnabled = True
        Me.Doctor_requested.Items.AddRange(New Object() {"Allergists", "Anesthesiologists", "Cardiac surgeons", "Cardiologists", "Dermatologists", "Endocrinologists", "Gastroenterologists", "General surgeons", "Infectious disease doctors", "Obstetrician/gynecologists", "Ophthalmologists", "Orthopedic surgeons", "Oncologists", "Otolaryngologists", "Pulmonologists", "Psychiatrists", "Radiologists", "Rheumatologists", "Nephrologists", "Neurologists", "Urologists"})
        Me.Doctor_requested.Location = New System.Drawing.Point(35, 123)
        Me.Doctor_requested.Name = "Doctor_requested"
        Me.Doctor_requested.Size = New System.Drawing.Size(159, 21)
        Me.Doctor_requested.TabIndex = 3
        '
        'Comments_Box
        '
        Me.Comments_Box.Location = New System.Drawing.Point(32, 231)
        Me.Comments_Box.Name = "Comments_Box"
        Me.Comments_Box.Size = New System.Drawing.Size(254, 108)
        Me.Comments_Box.TabIndex = 4
        Me.Comments_Box.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Doctor requested :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 163)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Appointment date :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 215)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Comments :"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(32, 359)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(142, 30)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Make an appointment"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label4.Location = New System.Drawing.Point(198, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(22, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "(?)"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.BP_Final_Assessment.My.Resources.Resources.DA1
        Me.PictureBox1.Location = New System.Drawing.Point(4, 32)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(194, 63)
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'Main_Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(304, 419)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Comments_Box)
        Me.Controls.Add(Me.Doctor_requested)
        Me.Controls.Add(Me.AppointmentDate)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Main_Menu"
        Me.Text = "Main Menu"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents InformationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RichTextBox2 As RichTextBox
    Friend WithEvents AppointmentDate As DateTimePicker
    Friend WithEvents Doctor_requested As ComboBox
    Friend WithEvents Comments_Box As RichTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
