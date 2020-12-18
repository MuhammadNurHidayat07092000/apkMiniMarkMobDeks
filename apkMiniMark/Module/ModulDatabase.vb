Imports alfathNET

Module ModulDatabase
    Public _DB As New Database
    Public _FS As New Fungsi
    Public _LP As New Laporan


    Sub KoneksiDatabase()
        Dim IP, Username, Password, Database, Port As String
        With frm_Database
            IP = txtIP.Text
            Username = txtUsername.Text
            Password = txtPassword.Text
            Database = txtDatabase.Text
            Port = txtPort.Text

            Call _DB.Koneksi(IP, Username, Password, Database, Port, frmUtama.StatusDB)
        End With

    End Sub


End Module
