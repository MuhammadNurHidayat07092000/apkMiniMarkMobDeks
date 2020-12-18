Public Class frm_Database

    Private Sub btnKoneksi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKoneksi.Click
        If txtIP.Text = "" Or txtUsername.Text = "" Or txtPassword.Text = "" Or txtDatabase = "" Or cbPort.Text = "" Then
            MsgBox("Setingan belum lengkap!", MsgBoxStyle.Exclamation, "Peringatan")
        Else
            Call KoneksiDatabase()
            Me.Close()
        End If
    End Sub
End Class