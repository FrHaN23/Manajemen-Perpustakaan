Public Class formMenu

    Private Sub JenisBukuToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub StatusStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles StatusStrip1.ItemClicked

    End Sub

    Private Sub formMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If statusLevel IsNot "ADMINISTRATOR" Then
            UserToolStripMenuItem.Enabled = False
        Else
            UserToolStripMenuItem.Enabled = True
        End If
        formDataBuku.TopLevel = False
        formJenisBuku.TopLevel = False

    End Sub

    Private Sub DataBukuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataBukuToolStripMenuItem.Click
        Me.Panel1.Controls.Clear()
        Me.Panel1.Controls.Add(formDataBuku)
        formDataBuku.Show()
        Me.Size = formDataBuku.Size
    End Sub

    Private Sub DataJenisBukuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataJenisBukuToolStripMenuItem.Click
        Me.Panel1.Controls.Clear()
        Me.Panel1.Controls.Add(formJenisBuku)
        formJenisBuku.Show()
        Me.Size = formJenisBuku.Size
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        End
    End Sub
End Class