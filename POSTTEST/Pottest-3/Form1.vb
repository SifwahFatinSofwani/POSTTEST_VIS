Imports System.IO

Public Class Form1
    Dim grupHobi() As CheckBox
    Dim grupJK() As RadioButton
    Dim pesanError As String = "Inputan tidak boleh kosong"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler textnama.KeyPress, AddressOf huruf
        AddHandler textumur.KeyPress, AddressOf angka
        AddHandler textnotelp.KeyPress, AddressOf angka
    End Sub

    Private Function CekData() As Boolean
        grupHobi = {hobi1, hobi2, hobi3, hobi4, hobi5, hobi6, hobi7, hobi8, hobi9, hobi10}
        grupJK = {laki, perempuan}

        If Not validasitb(textnama, pesanError) Then Return False
        If Not validasitb(textumur, pesanError) Then Return False
        If Not validasitb(textnotelp, pesanError) Then Return False
        If Not validasitb(textalamat, pesanError) Then Return False
        If Not validasirb(grupJK, pesanError) Then Return False
        If Not validasicb(grupHobi, pesanError) Then Return False
        If Not validasipb(foto, pesanError) Then Return False

        Return True
    End Function

    Private Sub browse_Click(sender As Object, e As EventArgs) Handles browse.Click
        If validasitb(textnama, "Isi nama terlebih dahulu sebelum upload foto!") Then
            Dim NamaFile As String = textnama.Text.Trim()
            Dim openFileDialog As New OpenFileDialog()
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
            openFileDialog.Title = "Pilih Gambar"

            If openFileDialog.ShowDialog() = DialogResult.OK Then
                Dim folderPath As String = Path.Combine(Application.StartupPath, "Foto")
                Dim fileName As String = NamaFile & Path.GetExtension(openFileDialog.FileName)
                Dim destinationPath As String = Path.Combine(folderPath, fileName)

                If Not Directory.Exists(folderPath) Then
                    Directory.CreateDirectory(folderPath)
                End If

                File.Copy(openFileDialog.FileName, destinationPath, True)
                Module2.Foto = destinationPath
                foto.Image = Image.FromFile(destinationPath)
            End If
        End If
    End Sub

    Private Sub print_Click(sender As Object, e As EventArgs) Handles print.Click
        If CekData() Then
            Module2.Nama = textnama.Text
            Module2.Umur = textumur.Text
            Module2.NoTelp = textnotelp.Text
            Module2.Alamat = textalamat.Text
            Module2.TglLahir = tanggallahir.Value.Date
            Module2.JK = rbinput(grupJK)
            Module2.Hobi = cbinput(grupHobi)
            Form2.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub
End Class