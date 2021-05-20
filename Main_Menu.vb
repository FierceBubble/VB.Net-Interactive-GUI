Public Class Main_Menu
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Doctor_Explanation.Show()
    End Sub

    Private Sub RichTextBox2_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox2.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Width = 623
        Height = 458
        GroupBox1.Visible = True
        MsgBox("Appointment has been submitted!", MsgBoxStyle.OkOnly, "Appointment succeed")
        RichTextBox2.Text = "Name: " + Sign_In.Name_Member + "" & vbCrLf & "" & vbCrLf & "Age: " + Sign_In.Age_num + "" & vbCrLf & "" & vbCrLf & "Doctor required: " + Doctor_requested.Text + "" & vbCrLf & "" & vbCrLf & "Appointment date: " + AppointmentDate.Value + "" & vbCrLf & "" & vbCrLf & "Personal comments: " & vbCrLf & Comments_Box.Text & vbCrLf & "" & vbCrLf & "" & vbCrLf & "Thank you for your appointment, we will reach back to you when the appointment has been confirm by the doctor." & vbCrLf & "Have a good day!"

    End Sub

    Private Sub InformationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InformationToolStripMenuItem.Click
        MsgBox("This application was made by Daniel Ryan Sunjaya (id: 1001851873)." & vbCrLf & "" & vbCrLf & "This application is used for patients to make an appointment to a specific doctor for their medical treatment.", MsgBoxStyle.OkOnly, "Information")
    End Sub
End Class