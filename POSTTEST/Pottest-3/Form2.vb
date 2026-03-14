Imports System.IO

Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        labelnama.Text = Module2.Nama
        labelumur.Text = Module2.Umur & " Tahun"
        labelnotelp.Text = Module2.NoTelp
        labeltanggalahir.Text = Module2.TglLahir.ToString("dd MMMM yyyy")
        labelalamat.Text = Module2.Alamat
        labelkelamin.Text = Module2.JK &
        labelhobi.Text = Module2.Hobi
        If File.Exists(Module2.Foto) Then
            foto.Image = Image.FromFile(Module2.Foto)
        End If
    End Sub

    Private Sub labelnama_Click(sender As Object, e As EventArgs) Handles labelnama.Click

    End Sub

    Private Sub labelumur_Click(sender As Object, e As EventArgs) Handles labelumur.Click

    End Sub
End Class