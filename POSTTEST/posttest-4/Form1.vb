Public Class Form1

    Dim lokasiFoto As String = ""

    Private Sub TransferDataKeForm2()
        Form2.lblHasilNama.Text = "Nama: " & txtNama.Text
        Form2.lblHasilID.Text = "ID: " & txtID.Text
        Form2.lblHasilKomunitas.Text = "Komunitas: " & cmbKomunitas.Text

        Form2.lblHasilKontak.Text = "No HP: " & mtbTelepon.Text
        Form2.lblHasilEmail.Text = "Email: " & txtEmail.Text
        Form2.lblHasilAlamat.Text = "Alamat: " & txtAlamat.Text

        Dim posisi As String = ""
        If rbPG.Checked Then posisi = rbPG.Text
        If rbSG.Checked Then posisi = rbSG.Text
        If rbSF.Checked Then posisi = rbSF.Text
        If rbPF.Checked Then posisi = rbPF.Text
        If rbC.Checked Then posisi = rbC.Text
        If rbCoach.Checked Then posisi = rbCoach.Text
        Form2.lblHasilPeran.Text = "Posisi: " & posisi

        Dim daftarHobi As String = ""
        For Each ctrl As Control In GroupBox2.Controls
            If TypeOf ctrl Is CheckBox Then
                Dim cb As CheckBox = DirectCast(ctrl, CheckBox)
                If cb.Checked Then daftarHobi &= cb.Text & ", "
            End If
        Next
        Form2.lblHasilHobi.Text = "Hobi: " & daftarHobi.TrimEnd(CChar(", "), CChar(" "))

        If PictureBox1.Image IsNot Nothing Then
            Form2.pbFotoHasil.Image = PictureBox1.Image
        End If
    End Sub

    Private Sub InputToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InputToolStripMenuItem.Click
        TabControl1.SelectedTab = TabPage1
    End Sub

    Private Sub LihatKartuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LihatKartuToolStripMenuItem.Click
        TransferDataKeForm2()
        Form2.Show()
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        Dim hasil As DialogResult = MessageBox.Show("Apakah Anda yakin ingin keluar?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If hasil = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub SimpanDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SimpanDataToolStripMenuItem.Click
        Dim jk As String = ""
        If rbLaki.Checked Then jk = rbLaki.Text
        If rbPerempuan.Checked Then jk = rbPerempuan.Text

        Dim posisi As String = ""
        If rbPG.Checked Then posisi = rbPG.Text
        If rbSG.Checked Then posisi = rbSG.Text
        If rbSF.Checked Then posisi = rbSF.Text
        If rbPF.Checked Then posisi = rbPF.Text
        If rbC.Checked Then posisi = rbC.Text
        If rbCoach.Checked Then posisi = rbCoach.Text

        Dim daftarHobi As String = ""
        For Each ctrl As Control In GroupBox2.Controls
            If TypeOf ctrl Is CheckBox Then
                Dim cb As CheckBox = DirectCast(ctrl, CheckBox)
                If cb.Checked Then daftarHobi &= cb.Text & ", "
            End If
        Next
        daftarHobi = daftarHobi.TrimEnd(CChar(", "), CChar(" "))

        Dim isi As String = BuatIsiFile(txtNama.Text, txtID.Text, txtUmur.Text, dtpTanggalLahir.Text, jk, cmbKomunitas.Text, mtbTelepon.Text, txtEmail.Text, txtAlamat.Text, posisi, daftarHobi, lokasiFoto)

        If SimpanDataKeFile(SaveFileDialog1, isi, "data_komunitas.txt") Then
            MessageBox.Show("File berhasil disimpan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub BukaDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BukaDataToolStripMenuItem.Click
        Dim data As Dictionary(Of String, String) = BukaDataDariFile(OpenFileDialog1)

        If data IsNot Nothing AndAlso data.Count > 0 Then
            txtNama.Text = AmbilNilai(data, "Nama")
            txtID.Text = AmbilNilai(data, "ID")
            txtUmur.Text = AmbilNilai(data, "Umur")
            dtpTanggalLahir.Text = AmbilNilai(data, "TanggalLahir")
            cmbKomunitas.Text = AmbilNilai(data, "Komunitas")
            mtbTelepon.Text = AmbilNilai(data, "NoHP")
            txtEmail.Text = AmbilNilai(data, "Email")
            txtAlamat.Text = AmbilNilai(data, "Alamat")

            Dim jk As String = AmbilNilai(data, "JenisKelamin")
            rbLaki.Checked = (jk = rbLaki.Text)
            rbPerempuan.Checked = (jk = rbPerempuan.Text)

            Dim pos As String = AmbilNilai(data, "Posisi")
            rbPG.Checked = (pos = rbPG.Text)
            rbSG.Checked = (pos = rbSG.Text)
            rbSF.Checked = (pos = rbSF.Text)
            rbPF.Checked = (pos = rbPF.Text)
            rbC.Checked = (pos = rbC.Text)
            rbCoach.Checked = (pos = rbCoach.Text)

            Dim hobiStr As String = AmbilNilai(data, "Hobi")
            For Each ctrl As Control In GroupBox2.Controls
                If TypeOf ctrl Is CheckBox Then
                    Dim cb As CheckBox = DirectCast(ctrl, CheckBox)
                    cb.Checked = hobiStr.Contains(cb.Text)
                End If
            Next

            lokasiFoto = AmbilNilai(data, "PathFoto")

            ' ==========================================
            ' INI BAGIAN YANG SEBELUMNYA KURANG END IF
            ' ==========================================
            If System.IO.File.Exists(lokasiFoto) Then
                PictureBox1.Image = Image.FromFile(lokasiFoto)
            Else
                PictureBox1.Image = Nothing
            End If ' <--- Tambahan End If pertama

            MessageBox.Show("Data berhasil dimuat", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If ' <--- End If ini untuk menutup blok baris 85
    End Sub

    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        HanyaHuruf(e)
    End Sub

    Private Sub txtID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtID.KeyPress
        HanyaAngka(e)
    End Sub

    Private Sub txtUmur_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUmur.KeyPress
        HanyaAngka(e)
    End Sub

    Private Sub mtbTelepon_KeyPress(sender As Object, e As KeyPressEventArgs) Handles mtbTelepon.KeyPress
        HanyaAngka(e)
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        OpenFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
        OpenFileDialog1.Title = "Pilih Gambar"

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim folderPath As String = System.IO.Path.Combine(Application.StartupPath, "Foto")
            If Not System.IO.Directory.Exists(folderPath) Then
                System.IO.Directory.CreateDirectory(folderPath)
            End If

            Dim namaFile As String = System.IO.Path.GetFileName(OpenFileDialog1.FileName)
            Dim destinationPath As String = System.IO.Path.Combine(folderPath, namaFile)

            System.IO.File.Copy(OpenFileDialog1.FileName, destinationPath, True)

            lokasiFoto = destinationPath
            PictureBox1.Image = Image.FromFile(lokasiFoto)
        End If
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        ErrorProvider1.Clear()

        Dim namaValid As Boolean = ValidasiTextBox(ErrorProvider1, txtNama, "Inputan tidak boleh kosong")
        Dim idValid As Boolean = ValidasiTextBox(ErrorProvider1, txtID, "Inputan tidak boleh kosong")
        Dim umurValid As Boolean = ValidasiTextBox(ErrorProvider1, txtUmur, "Inputan tidak boleh kosong")
        Dim telpValid As Boolean = ValidasiMaskedTextBox(ErrorProvider1, mtbTelepon, "Inputan tidak boleh kosong")
        Dim emailValid As Boolean = ValidasiTextBox(ErrorProvider1, txtEmail, "Inputan tidak boleh kosong")
        Dim alamatValid As Boolean = ValidasiTextBox(ErrorProvider1, txtAlamat, "Inputan tidak boleh kosong")

        Dim cmbValid As Boolean = True
        If cmbKomunitas.Text.Trim() = "" Then
            ErrorProvider1.SetError(cmbKomunitas, "Inputan tidak boleh kosong")
            cmbValid = False
        End If

        Dim genderValid As Boolean = rbLaki.Checked Or rbPerempuan.Checked
        Dim posisiValid As Boolean = rbPG.Checked Or rbSG.Checked Or rbSF.Checked Or rbPF.Checked Or rbC.Checked Or rbCoach.Checked

        Dim hobiValid As Boolean = False
        For Each ctrl As Control In GroupBox2.Controls
            If TypeOf ctrl Is CheckBox Then
                Dim cb As CheckBox = DirectCast(ctrl, CheckBox)
                If cb.Checked Then hobiValid = True
            End If
        Next

        If Not (namaValid And idValid And umurValid And telpValid And emailValid And alamatValid And cmbValid And genderValid And posisiValid And hobiValid) Then
            MessageBox.Show("Inputan tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim hasil As DialogResult = MessageBox.Show("Apakah data ingin disimpan dan dicetak?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If hasil = DialogResult.Yes Then
            TransferDataKeForm2()
            Form2.Show()
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

End Class