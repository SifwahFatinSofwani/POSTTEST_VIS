Module Module1
    Public daftarBuku(99, 1) As String
    Public jumlahBuku As Integer = 0

    Public Function CariIndeksBuku(judul As String) As Integer
        For i As Integer = 0 To jumlahBuku - 1
            If daftarBuku(i, 0).ToLower() = judul.ToLower() Then
                Return i
            End If
        Next
        Return -1
    End Function

    Public Sub HapusBuku(ByRef judul As String)
        Dim indeks As Integer = CariIndeksBuku(judul)
        If indeks <> -1 Then
            For i As Integer = indeks To jumlahBuku - 2
                daftarBuku(i, 0) = daftarBuku(i + 1, 0)
                daftarBuku(i, 1) = daftarBuku(i + 1, 1)
            Next
            jumlahBuku -= 1
            MessageBox.Show("Data '" & judul & "' berhasil dihapus!")
        Else
            MessageBox.Show("Judul tidak ditemukan!")
        End If
    End Sub
End Module