Imports System.IO

Public Class Form2
    Private Sub FormatSemuaDGV()
        Dim grids As DataGridView() = {dgvLihatTim, dgvLihatPemain, dgvLihatCoach, dgvEditTim, dgvEditPemain, dgvEditCoach, dgvHapusTim, dgvHapusPemain, dgvHapusCoach, dgvSearchTim, dgvSearchPemain}
        For Each dgv In grids
            If dgv.Columns.Contains("foto") Then
                Dim imgCol As DataGridViewImageColumn = CType(dgv.Columns("foto"), DataGridViewImageColumn)
                imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom
                dgv.RowTemplate.Height = 80
            End If
        Next
    End Sub

    Private Sub LoadGambarKePictureBox(picBox As PictureBox, selValue As Object)
        If Not IsDBNull(selValue) AndAlso selValue IsNot Nothing Then
            Dim imgBytes As Byte() = CType(selValue, Byte())
            Using ms As New MemoryStream(imgBytes)
                picBox.Image = Image.FromStream(ms)
            End Using
        Else
            picBox.Image = Nothing
        End If
    End Sub

    Private Sub PilihFoto(picBox As PictureBox)
        OpenFileDialog1.Filter = "Images|*.jpg;*.png;*.jpeg"
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            picBox.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub RefreshSemuaData()
        Dim dtTim As DataTable = GetAllTim()
        Dim dtPemain As DataTable = GetAllPemain()
        Dim dtCoach As DataTable = GetAllCoach()

        dgvLihatTim.DataSource = dtTim
        dgvLihatPemain.DataSource = dtPemain
        dgvLihatCoach.DataSource = dtCoach
        dgvEditTim.DataSource = dtTim
        dgvEditPemain.DataSource = dtPemain
        dgvEditCoach.DataSource = dtCoach
        dgvHapusTim.DataSource = dtTim
        dgvHapusPemain.DataSource = dtPemain
        dgvHapusCoach.DataSource = dtCoach
        dgvSearchTim.DataSource = dtTim
        dgvSearchPemain.DataSource = dtPemain

        FormatSemuaDGV()

        Dim combos As ComboBox() = {cmbTimPemainTmb, cmbTimCoachTmb, cmbTimPemainEdt, cmbTimCoachEdt}
        For Each cmb In combos
            cmb.DataSource = dtTim.Copy()
            cmb.DisplayMember = "nama_tim"
            cmb.ValueMember = "id_tim"
        Next
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshSemuaData()
    End Sub

    Private Sub btnBrowseTimTmb_Click(sender As Object, e As EventArgs) Handles btnBrowseTimTmb.Click
        PilihFoto(picTimTmb)
    End Sub

    Private Sub btnBrowsePemainTmb_Click(sender As Object, e As EventArgs) Handles btnBrowsePemainTmb.Click
        PilihFoto(picPemainTmb)
    End Sub

    Private Sub btnBrowseCoachTmb_Click(sender As Object, e As EventArgs) Handles btnBrowseCoachTmb.Click
        PilihFoto(picCoachTmb)
    End Sub

    Private Sub btnBrowseTimEdt_Click(sender As Object, e As EventArgs) Handles btnBrowseTimEdt.Click
        PilihFoto(picTimEdt)
    End Sub

    Private Sub btnBrowsePemainEdt_Click(sender As Object, e As EventArgs) Handles btnBrowsePemainEdt.Click
        PilihFoto(picPemainEdt)
    End Sub

    Private Sub btnBrowseCoachEdt_Click(sender As Object, e As EventArgs) Handles btnBrowseCoachEdt.Click
        PilihFoto(picCoachEdt)
    End Sub

    Private Sub txtSearchTim_TextChanged(sender As Object, e As EventArgs) Handles txtSearchTim.TextChanged
        dgvSearchTim.DataSource = CariTim(txtSearchTim.Text)
    End Sub

    Private Sub txtSearchPemain_TextChanged(sender As Object, e As EventArgs) Handles txtSearchPemain.TextChanged
        dgvSearchPemain.DataSource = CariPemain(txtSearchPemain.Text)
    End Sub

    Private Sub btnSimpanTim_Click(sender As Object, e As EventArgs) Handles btnSimpanTim.Click
        If txtIdTimTmb.Text.Trim() = "" Or txtNamaTimTmb.Text.Trim() = "" Then
            MessageBox.Show("ID dan Nama Tim wajib diisi!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If SimpanTim(txtIdTimTmb.Text, txtNamaTimTmb.Text, cmbWilayahTimTmb.Text, picTimTmb.Image) Then
            RefreshSemuaData()
            picTimTmb.Image = Nothing
        End If
    End Sub

    Private Sub btnSimpanPemain_Click(sender As Object, e As EventArgs) Handles btnSimpanPemain.Click
        If txtIdPemainTmb.Text.Trim() = "" Or txtNamaPemainTmb.Text.Trim() = "" Or cmbTimPemainTmb.SelectedValue Is Nothing Then
            MessageBox.Show("Semua data utama wajib diisi!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If SimpanPemain(txtIdPemainTmb.Text, txtNamaPemainTmb.Text, cmbPosisiPemainTmb.Text, cmbTimPemainTmb.SelectedValue.ToString(), picPemainTmb.Image) Then
            RefreshSemuaData()
            picPemainTmb.Image = Nothing
        End If
    End Sub

    Private Sub btnSimpanCoach_Click(sender As Object, e As EventArgs) Handles btnSimpanCoach.Click
        If txtIdCoachTmb.Text.Trim() = "" Or txtNamaCoachTmb.Text.Trim() = "" Or cmbTimCoachTmb.SelectedValue Is Nothing Then
            MessageBox.Show("Semua data utama wajib diisi!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If SimpanCoach(txtIdCoachTmb.Text, txtNamaCoachTmb.Text, cmbJabatanCoachTmb.Text, cmbTimCoachTmb.SelectedValue.ToString(), picCoachTmb.Image) Then
            RefreshSemuaData()
            picCoachTmb.Image = Nothing
        End If
    End Sub

    Private Sub dgvEditTim_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEditTim.CellClick
        If e.RowIndex >= 0 Then
            txtIdTimEdt.Text = dgvEditTim.Rows(e.RowIndex).Cells("id_tim").Value.ToString()
            txtNamaTimEdt.Text = dgvEditTim.Rows(e.RowIndex).Cells("nama_tim").Value.ToString()
            cmbWilayahTimEdt.Text = dgvEditTim.Rows(e.RowIndex).Cells("wilayah").Value.ToString()
            LoadGambarKePictureBox(picTimEdt, dgvEditTim.Rows(e.RowIndex).Cells("foto").Value)
        End If
    End Sub

    Private Sub btnUbahTim_Click(sender As Object, e As EventArgs) Handles btnUbahTim.Click
        If txtIdTimEdt.Text.Trim() = "" Then Return
        If UbahTim(txtIdTimEdt.Text, txtNamaTimEdt.Text, cmbWilayahTimEdt.Text, picTimEdt.Image) Then RefreshSemuaData()
    End Sub

    Private Sub dgvEditPemain_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEditPemain.CellClick
        If e.RowIndex >= 0 Then
            txtIdPemainEdt.Text = dgvEditPemain.Rows(e.RowIndex).Cells("id_pemain").Value.ToString()
            txtNamaPemainEdt.Text = dgvEditPemain.Rows(e.RowIndex).Cells("nama_pemain").Value.ToString()
            cmbPosisiPemainEdt.Text = dgvEditPemain.Rows(e.RowIndex).Cells("posisi").Value.ToString()
            cmbTimPemainEdt.SelectedValue = dgvEditPemain.Rows(e.RowIndex).Cells("id_tim").Value.ToString()
            LoadGambarKePictureBox(picPemainEdt, dgvEditPemain.Rows(e.RowIndex).Cells("foto").Value)
        End If
    End Sub

    Private Sub btnUbahPemain_Click(sender As Object, e As EventArgs) Handles btnUbahPemain.Click
        If txtIdPemainEdt.Text.Trim() = "" Then Return
        If UbahPemain(txtIdPemainEdt.Text, txtNamaPemainEdt.Text, cmbPosisiPemainEdt.Text, cmbTimPemainEdt.SelectedValue.ToString(), picPemainEdt.Image) Then RefreshSemuaData()
    End Sub

    Private Sub dgvEditCoach_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEditCoach.CellClick
        If e.RowIndex >= 0 Then
            txtIdCoachEdt.Text = dgvEditCoach.Rows(e.RowIndex).Cells("id_coach").Value.ToString()
            txtNamaCoachEdt.Text = dgvEditCoach.Rows(e.RowIndex).Cells("nama_coach").Value.ToString()
            cmbJabatanCoachEdt.Text = dgvEditCoach.Rows(e.RowIndex).Cells("jabatan").Value.ToString()
            cmbTimCoachEdt.SelectedValue = dgvEditCoach.Rows(e.RowIndex).Cells("id_tim").Value.ToString()
            LoadGambarKePictureBox(picCoachEdt, dgvEditCoach.Rows(e.RowIndex).Cells("foto").Value)
        End If
    End Sub

    Private Sub btnUbahCoach_Click(sender As Object, e As EventArgs) Handles btnUbahCoach.Click
        If txtIdCoachEdt.Text.Trim() = "" Then Return
        If UbahCoach(txtIdCoachEdt.Text, txtNamaCoachEdt.Text, cmbJabatanCoachEdt.Text, cmbTimCoachEdt.SelectedValue.ToString(), picCoachEdt.Image) Then RefreshSemuaData()
    End Sub

    Private Sub dgvHapusTim_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvHapusTim.CellClick
        If e.RowIndex >= 0 Then txtIdTimHps.Text = dgvHapusTim.Rows(e.RowIndex).Cells("id_tim").Value.ToString()
    End Sub

    Private Sub btnHapusTim_Click(sender As Object, e As EventArgs) Handles btnHapusTim.Click
        If txtIdTimHps.Text = "" Then
            MessageBox.Show("Pilih data yang akan dihapus!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If HapusData("tb_tim", "id_tim", txtIdTimHps.Text) Then
            RefreshSemuaData()
            txtIdTimHps.Clear()
        End If
    End Sub

    Private Sub dgvHapusPemain_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvHapusPemain.CellClick
        If e.RowIndex >= 0 Then txtIdPemainHps.Text = dgvHapusPemain.Rows(e.RowIndex).Cells("id_pemain").Value.ToString()
    End Sub

    Private Sub btnHapusPemain_Click(sender As Object, e As EventArgs) Handles btnHapusPemain.Click
        If txtIdPemainHps.Text = "" Then Return
        If HapusData("tb_pemain", "id_pemain", txtIdPemainHps.Text) Then
            RefreshSemuaData()
            txtIdPemainHps.Clear()
        End If
    End Sub

    Private Sub dgvHapusCoach_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvHapusCoach.CellClick
        If e.RowIndex >= 0 Then txtIdCoachHps.Text = dgvHapusCoach.Rows(e.RowIndex).Cells("id_coach").Value.ToString()
    End Sub

    Private Sub btnHapusCoach_Click(sender As Object, e As EventArgs) Handles btnHapusCoach.Click
        If txtIdCoachHps.Text = "" Then Return
        If HapusData("tb_coach", "id_coach", txtIdCoachHps.Text) Then
            RefreshSemuaData()
            txtIdCoachHps.Clear()
        End If
    End Sub

End Class