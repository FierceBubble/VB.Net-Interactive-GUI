Imports System.Data.OleDb
Imports System.Data
Public Class Sign_In

    Public Name_Member As String
    Public Age_num As String

    Private Sub Login_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=Hospital_Membership .accdb"
    End Sub
    ReadOnly conn As New OleDb.OleDbConnection
    Dim adapter As OleDbDataAdapter
    Dim ds As DataSet

    Private Sub SignIn_btn_Click(sender As Object, e As EventArgs) Handles SignIn_btn.Click


        If Member_ID.Text = "" Or Password.Text = "" Then
            MsgBox("Please fill all the info")
        Else

            ds = New DataSet
            adapter = New OleDbDataAdapter("select * from [User] where [ID] = '" & Member_ID.Text & "' and [Password] = '" & Password.Text & "'", conn)
            adapter.Fill(ds, "User")


            If ds.Tables("User").Rows.Count > 0 Then
                MsgBox("Welcome back " + Member_ID.Text + "!", MsgBoxStyle.OkOnly, "Login succeed")
                conn.Open()
                Dim strsql As String
                strsql = "Select * from [User] where [ID] = '" + Member_ID.Text + "'"
                Dim cmd As New OleDbCommand(strsql, conn)
                Dim myreader As OleDbDataReader
                myreader = cmd.ExecuteReader
                myreader.Read()
                Dim Nam As String
                Dim Ag As Integer
                Nam = myreader("Name_member")
                Ag = myreader("Age")
                Name_Member = Nam.ToString
                Age_num = Ag.ToString
                conn.Close()
                Member_ID.Clear()
                Password.Clear()
                Main_Menu.Show()
                Me.Visible = False
            Else
                MsgBox("Login failed, check your credentials", MsgBoxStyle.OkOnly, "Login failed")
                Member_ID.Clear()
                Password.Clear()
            End If
        End If

    End Sub

    Private Sub SignUp_btn_Click(sender As Object, e As EventArgs) Handles SignUp_btn.Click
        Sign_Up.Show()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class
