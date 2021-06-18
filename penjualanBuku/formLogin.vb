Imports System.Data.OleDb
Public Class formLogin
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub
    Sub login()
        Call koneksiServer()
        If txtUsername.Text = "" Or txtPassword.Text = "" Then
            MsgBox("Silakan masukkan Username/Password")
            txtUsername.Focus()
        Else
            cmd = New OleDbCommand("SELECT * FROM tbl_user WHERE user_name='" & txtUsername.Text &
                                   "' and password='" & txtPassword.Text & "'", conn)
            dataReader = cmd.ExecuteReader
            dataReader.Read()
            If dataReader.HasRows = True Then
                formMenu.statusName.Text = dataReader(3).ToString
                formMenu.statusLevel.Text = dataReader(1).ToString
                Me.Hide()
                formMenu.Show()
            Else
                    MsgBox("Username/Password salah")
            End If
        End If
    End Sub

    Private Sub bttnLogin_Click(sender As Object, e As EventArgs) Handles bttnLogin.Click
        Call login()
    End Sub

    Private Sub txtUsername_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUsername.KeyPress
        If e.KeyChar = Chr(13) Then
            txtPassword.Focus()
        End If
    End Sub

    Private Sub txtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPassword.KeyPress
        If e.KeyChar = Chr(13) Then
            Call login()
        End If
    End Sub
End Class