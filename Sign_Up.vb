Imports System.Data.OleDb
Imports System.Data
Public Class Sign_Up
    Private Sub Sign_Up_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=Hospital_Membership .accdb"
    End Sub

    ReadOnly conn As New OleDb.OleDbConnection
    Dim adapter As OleDbDataAdapter
    Dim ds As DataSet
    Private Sub SignUp_btn_Click(sender As Object, e As EventArgs) Handles SignUp_btn.Click
        ds = New DataSet
        If Member_ID.Text = "" Or Password.Text = "" Or Confirm_Password.Text = "" Or NameMem.Text = "" Or Age.Text = "" Then
            MsgBox("please fill the info")
        ElseIf Password.Text = Confirm_Password.Text Then

            adapter = New OleDbDataAdapter("insert into [User] ([ID], [Password], [Name_member], [Age]) VALUES" & "('" & Member_ID.Text & "','" & Password.Text & "','" & NameMem.Text & "','" & Age.Text & "')", conn)
            adapter.Fill(ds, "User")
            MsgBox("Membership successfully created!")
            Member_ID.Clear()
            Password.Clear()
            Confirm_Password.Clear()
            Me.Visible = False
        ElseIf Password.Text <> Confirm_Password.Text Then
            MsgBox("Password is not the same, please retry", MsgBoxStyle.OkOnly, "Password does not match")
            Member_ID.Clear()
            Password.Clear()
            Confirm_Password.Clear()
        End If
    End Sub
End Class