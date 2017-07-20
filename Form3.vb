Imports System.Data.OleDb

Public Class Form3
    Dim provider As String
    Dim datafile As String
    Dim connstring As String
    Dim myconnection As OleDbConnection = New OleDbConnection
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'KeyboardFinalDataSet.KeyboardDB' table. You can move, or remove it, as needed.
        Me.KeyboardDBTableAdapter.Fill(Me.KeyboardFinalDataSet.KeyboardDB)
        Try
            ComboBox1.DataSource = KeyboardFinalDataSet.Tables(0)
            ComboBox1.ValueMember = "Issue"
            ComboBox1.DisplayMember = "Issue"
        Catch ex As Exception
            MessageBox.Show("Can not open connection ! ")
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        provider = "Provider= Microsoft.Jet.OLEDB.4.0; Data Source ="
        datafile = "C:\Users\Rjrahul24\Desktop\KeyboardFinal.mdb"
        connstring = provider & datafile
        myconnection.ConnectionString = connstring
        myconnection.Open()
        Dim i, Sno As Integer
        Dim Issue As String
        Dim rw As DataRow
        Dim str As String
        rw = KeyboardFinalDataSet.Tables(0).NewRow
        Issue = InputBox("Enter the issue name")
        Sno = InputBox("Enter the issue number")
        rw.Item("Sno") = Sno
        rw.Item("Issue") = Issue
        str = "insert into KeyboardDB values('" & Issue & "',' " & Sno & " ')"
        Dim cmd As OleDbCommand = New OleDbCommand(str, myconnection)

        Try
            i = KeyboardDBTableAdapter.Update(KeyboardFinalDataSet)
            KeyboardDBTableAdapter.Update(KeyboardFinalDataSet)
            cmd.ExecuteNonQuery()
            myconnection.Close()
            KeyboardFinalDataSet.Tables(0).Rows.Add(rw)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


        MessageBox.Show("No. of rows updated= " & i)
        Dim str2 As String
        str2 = "select * from KeyboardDB"
        Dim cmd2 As OleDbCommand = New OleDbCommand(str2, myconnection)


    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        ComboBox1.DataSource = KeyboardFinalDataSet.Tables(0)
        ComboBox1.ValueMember = "Issue"
        ComboBox1.DisplayMember = "Issue"
        Form1.TextBox1.Text = ComboBox1.Text()
    End Sub
End Class