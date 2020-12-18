Public Class frm_DataJenis

    Private Sub frm_DataJenis_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call _DB.tampilTabel1(gridDataJenis, "SELECT * FROM tbl_jenis")
    End Sub
End Class