Class Form1
    Private Sub RefreshTable()
        dgvbuku.Rows.Clear()
        For i As Integer = 0 To jumlahBuku - 1
            dgvbuku.Rows.Add(daftarBuku(i, 0), daftarBuku(i, 1))
        Next
    End Sub

    Private Sub buttontambah_Click(sender As Object, e As EventArgs) Handles buttontambah.Click
        Dim judul As String = inputtambah.Text.Trim()
        Dim genre As String = inputgenre.Text.Trim()

        If judul <> "" And genre <> "" Then
            If jumlahBuku < 100 Then
                daftarBuku(jumlahBuku, 0) = judul
                daftarBuku(jumlahBuku, 1) = genre
                jumlahBuku += 1

                RefreshTable()
                inputtambah.Clear()
                inputgenre.Clear()
            End If
        Else
            MessageBox.Show("Harap isi Judul dan Genre!")
        End If
    End Sub

    Private Sub buttonhapus_Click(sender As Object, e As EventArgs) Handles buttonhapus.Click
        Dim target As String = inputhapus.Text.Trim()

        If target <> "" Then
            HapusBuku(target)
            RefreshTable()
            inputhapus.Clear()
        End If
    End Sub

End Class