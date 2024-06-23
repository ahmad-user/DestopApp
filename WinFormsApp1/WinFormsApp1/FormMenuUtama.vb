Public Class FormMenuUtama

    Private Sub DataGudangToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DataGudangToolStripMenuItem1.Click
        FormGudang.MdiParent = Me
        FormGudang.Show()
    End Sub

    Private Sub DataBarangToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles DataBarangToolStripMenuItem2.Click
        FormBarang.MdiParent = Me
        FormBarang.Show()
    End Sub

    Private Sub FormMenuUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call terkunci()
        sbtanggal.Text = "[" & Format(Now, "dddd") & " " & Format(Now, "dd MMM yyyy") & "]"
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        FormLogin.MdiParent = Me
        FormLogin.Show()
    End Sub

    Sub terkunci()
        LoginToolStripMenuItem.Enabled = True
        LogoutToolStripMenuItem.Enabled = False
        DataGudangToolStripMenuItem1.Enabled = False
        DataBarangToolStripMenuItem2.Enabled = False

    End Sub
End Class