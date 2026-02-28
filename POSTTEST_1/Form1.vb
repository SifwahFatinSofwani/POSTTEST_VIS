Imports System.Reflection.Emit

Public Class Form1
    Dim totalip As Double = 0
    Dim jumlahsemester As Integer = 0

    Private Sub buttontambah_Click(sender As Object, e As EventArgs) Handles buttontambah.Click
        Dim ipsemester As Double
        Dim predikat As String = ""

        If Double.TryParse(box1.Text, ipsemester) Then
            totalip = totalip + ipsemester
            jumlahsemester = jumlahsemester + 1

            Dim ipk As Double = totalip / jumlahsemester
            box2.Text = ipk.ToString()

            If ipk >= 3.01 Then
                predikat = "Sangat Memuaskan"
            ElseIf ipk >= 2.76 Then
                predikat = "Memuaskan"
            ElseIf ipk >= 2.0 Then
                predikat = "Cukup"
            Else
                predikat = "Kurang"
            End If

            label3.Text = predikat
        Else
            MessageBox.Show("Input IP Semester harus angka")
        End If
    End Sub

    Private Sub buttonreset_Click(sender As Object, e As EventArgs) Handles buttonreset.Click
        totalip = 0
        jumlahsemester = 0
        box1.Text = ""
        box2.Text = ""
        label3.Text = "Predikat IPK"
    End Sub

    Private Sub label1_Click(sender As Object, e As EventArgs) Handles label1.Click

    End Sub

    Private Sub label2_Click(sender As Object, e As EventArgs) Handles label2.Click

    End Sub
End Class