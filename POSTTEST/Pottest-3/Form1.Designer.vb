<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        textnama = New TextBox()
        textumur = New TextBox()
        textnotelp = New TextBox()
        textalamat = New TextBox()
        tanggallahir = New DateTimePicker()
        jeniskelamin = New GroupBox()
        perempuan = New RadioButton()
        laki = New RadioButton()
        hobi = New GroupBox()
        hobi10 = New CheckBox()
        hobi9 = New CheckBox()
        hobi8 = New CheckBox()
        hobi7 = New CheckBox()
        hobi6 = New CheckBox()
        hobi5 = New CheckBox()
        hobi4 = New CheckBox()
        hobi3 = New CheckBox()
        hobi2 = New CheckBox()
        hobi1 = New CheckBox()
        foto = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        browse = New Button()
        print = New Button()
        PictureBox1 = New PictureBox()
        jeniskelamin.SuspendLayout()
        hobi.SuspendLayout()
        CType(foto, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' textnama
        ' 
        textnama.BorderStyle = BorderStyle.FixedSingle
        textnama.CharacterCasing = CharacterCasing.Upper
        textnama.Location = New Point(403, 21)
        textnama.Name = "textnama"
        textnama.Size = New Size(250, 27)
        textnama.TabIndex = 0
        ' 
        ' textumur
        ' 
        textumur.BorderStyle = BorderStyle.FixedSingle
        textumur.Location = New Point(403, 54)
        textumur.Name = "textumur"
        textumur.Size = New Size(250, 27)
        textumur.TabIndex = 1
        ' 
        ' textnotelp
        ' 
        textnotelp.BorderStyle = BorderStyle.FixedSingle
        textnotelp.Location = New Point(403, 120)
        textnotelp.Name = "textnotelp"
        textnotelp.Size = New Size(250, 27)
        textnotelp.TabIndex = 2
        ' 
        ' textalamat
        ' 
        textalamat.BorderStyle = BorderStyle.FixedSingle
        textalamat.Location = New Point(403, 153)
        textalamat.Name = "textalamat"
        textalamat.Size = New Size(250, 27)
        textalamat.TabIndex = 3
        ' 
        ' tanggallahir
        ' 
        tanggallahir.Location = New Point(403, 87)
        tanggallahir.Name = "tanggallahir"
        tanggallahir.Size = New Size(250, 27)
        tanggallahir.TabIndex = 4
        ' 
        ' jeniskelamin
        ' 
        jeniskelamin.Controls.Add(perempuan)
        jeniskelamin.Controls.Add(laki)
        jeniskelamin.Location = New Point(258, 193)
        jeniskelamin.Name = "jeniskelamin"
        jeniskelamin.Size = New Size(228, 191)
        jeniskelamin.TabIndex = 5
        jeniskelamin.TabStop = False
        jeniskelamin.Text = "Jenis Kelamin"
        ' 
        ' perempuan
        ' 
        perempuan.AutoSize = True
        perempuan.Location = New Point(6, 56)
        perempuan.Name = "perempuan"
        perempuan.Size = New Size(104, 24)
        perempuan.TabIndex = 1
        perempuan.TabStop = True
        perempuan.Text = "Perempuan"
        perempuan.UseVisualStyleBackColor = True
        ' 
        ' laki
        ' 
        laki.AutoSize = True
        laki.Location = New Point(6, 26)
        laki.Name = "laki"
        laki.Size = New Size(88, 24)
        laki.TabIndex = 0
        laki.TabStop = True
        laki.Text = "Laki-Laki"
        laki.UseVisualStyleBackColor = True
        ' 
        ' hobi
        ' 
        hobi.Controls.Add(hobi10)
        hobi.Controls.Add(hobi9)
        hobi.Controls.Add(hobi8)
        hobi.Controls.Add(hobi7)
        hobi.Controls.Add(hobi6)
        hobi.Controls.Add(hobi5)
        hobi.Controls.Add(hobi4)
        hobi.Controls.Add(hobi3)
        hobi.Controls.Add(hobi2)
        hobi.Controls.Add(hobi1)
        hobi.Location = New Point(496, 193)
        hobi.Name = "hobi"
        hobi.Size = New Size(282, 191)
        hobi.TabIndex = 6
        hobi.TabStop = False
        hobi.Text = "Hobi"
        ' 
        ' hobi10
        ' 
        hobi10.AutoSize = True
        hobi10.Location = New Point(151, 146)
        hobi10.Name = "hobi10"
        hobi10.Size = New Size(63, 24)
        hobi10.TabIndex = 9
        hobi10.Text = "Buku"
        hobi10.UseVisualStyleBackColor = True
        ' 
        ' hobi9
        ' 
        hobi9.AutoSize = True
        hobi9.Location = New Point(151, 116)
        hobi9.Name = "hobi9"
        hobi9.Size = New Size(69, 24)
        hobi9.TabIndex = 8
        hobi9.Text = "Futsal"
        hobi9.UseVisualStyleBackColor = True
        ' 
        ' hobi8
        ' 
        hobi8.AutoSize = True
        hobi8.Location = New Point(151, 86)
        hobi8.Name = "hobi8"
        hobi8.Size = New Size(94, 24)
        hobi8.TabIndex = 7
        hobi8.Text = "Berenang"
        hobi8.UseVisualStyleBackColor = True
        ' 
        ' hobi7
        ' 
        hobi7.AutoSize = True
        hobi7.Location = New Point(151, 56)
        hobi7.Name = "hobi7"
        hobi7.Size = New Size(122, 24)
        hobi7.TabIndex = 6
        hobi7.Text = "Sound Mixing"
        hobi7.UseVisualStyleBackColor = True
        ' 
        ' hobi6
        ' 
        hobi6.AutoSize = True
        hobi6.Location = New Point(151, 26)
        hobi6.Name = "hobi6"
        hobi6.Size = New Size(117, 24)
        hobi6.TabIndex = 5
        hobi6.Text = "Vidio Editing"
        hobi6.UseVisualStyleBackColor = True
        ' 
        ' hobi5
        ' 
        hobi5.AutoSize = True
        hobi5.Location = New Point(6, 146)
        hobi5.Name = "hobi5"
        hobi5.Size = New Size(112, 24)
        hobi5.TabIndex = 4
        hobi5.Text = "Vidiography"
        hobi5.UseVisualStyleBackColor = True
        ' 
        ' hobi4
        ' 
        hobi4.AutoSize = True
        hobi4.Location = New Point(6, 113)
        hobi4.Name = "hobi4"
        hobi4.Size = New Size(65, 24)
        hobi4.TabIndex = 3
        hobi4.Text = "Tidur"
        hobi4.UseVisualStyleBackColor = True
        ' 
        ' hobi3
        ' 
        hobi3.AutoSize = True
        hobi3.Location = New Point(6, 83)
        hobi3.Name = "hobi3"
        hobi3.Size = New Size(75, 24)
        hobi3.TabIndex = 2
        hobi3.Text = "Makan"
        hobi3.UseVisualStyleBackColor = True
        ' 
        ' hobi2
        ' 
        hobi2.AutoSize = True
        hobi2.Location = New Point(6, 53)
        hobi2.Name = "hobi2"
        hobi2.Size = New Size(73, 24)
        hobi2.TabIndex = 1
        hobi2.Text = "Masak"
        hobi2.UseVisualStyleBackColor = True
        ' 
        ' hobi1
        ' 
        hobi1.AutoSize = True
        hobi1.Location = New Point(6, 26)
        hobi1.Name = "hobi1"
        hobi1.Size = New Size(83, 24)
        hobi1.TabIndex = 0
        hobi1.Text = "Gaming"
        hobi1.UseVisualStyleBackColor = True
        ' 
        ' foto
        ' 
        foto.BorderStyle = BorderStyle.FixedSingle
        foto.Location = New Point(12, 12)
        foto.Name = "foto"
        foto.Size = New Size(237, 372)
        foto.SizeMode = PictureBoxSizeMode.StretchImage
        foto.TabIndex = 7
        foto.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Location = New Point(256, 28)
        Label1.Name = "Label1"
        Label1.Size = New Size(49, 20)
        Label1.TabIndex = 8
        Label1.Text = "Nama"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Location = New Point(257, 58)
        Label2.Name = "Label2"
        Label2.Size = New Size(45, 20)
        Label2.TabIndex = 9
        Label2.Text = "Umur"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Location = New Point(256, 90)
        Label3.Name = "Label3"
        Label3.Size = New Size(97, 20)
        Label3.TabIndex = 10
        Label3.Text = "Tanggal Lahir"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(258, 123)
        Label4.Name = "Label4"
        Label4.Size = New Size(86, 20)
        Label4.TabIndex = 11
        Label4.Text = "No Telepon"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(259, 155)
        Label5.Name = "Label5"
        Label5.Size = New Size(57, 20)
        Label5.TabIndex = 12
        Label5.Text = "Alamat"
        ' 
        ' browse
        ' 
        browse.Location = New Point(12, 390)
        browse.Name = "browse"
        browse.Size = New Size(237, 48)
        browse.TabIndex = 13
        browse.Text = "Cari Gambar"
        browse.UseVisualStyleBackColor = True
        ' 
        ' print
        ' 
        print.Location = New Point(258, 390)
        print.Name = "print"
        print.Size = New Size(520, 48)
        print.TabIndex = 14
        print.Text = "Print"
        print.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.InitialImage = Nothing
        PictureBox1.Location = New Point(-4, -2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(805, 455)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 15
        PictureBox1.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(print)
        Controls.Add(browse)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(foto)
        Controls.Add(hobi)
        Controls.Add(jeniskelamin)
        Controls.Add(tanggallahir)
        Controls.Add(textalamat)
        Controls.Add(textnotelp)
        Controls.Add(textumur)
        Controls.Add(textnama)
        Controls.Add(PictureBox1)
        Name = "Form1"
        Text = "Form1"
        jeniskelamin.ResumeLayout(False)
        jeniskelamin.PerformLayout()
        hobi.ResumeLayout(False)
        hobi.PerformLayout()
        CType(foto, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents textnama As TextBox
    Friend WithEvents textumur As TextBox
    Friend WithEvents textnotelp As TextBox
    Friend WithEvents textalamat As TextBox
    Friend WithEvents tanggallahir As DateTimePicker
    Friend WithEvents jeniskelamin As GroupBox
    Friend WithEvents hobi As GroupBox
    Friend WithEvents perempuan As RadioButton
    Friend WithEvents laki As RadioButton
    Friend WithEvents foto As PictureBox
    Friend WithEvents hobi1 As CheckBox
    Friend WithEvents hobi5 As CheckBox
    Friend WithEvents hobi4 As CheckBox
    Friend WithEvents hobi3 As CheckBox
    Friend WithEvents hobi2 As CheckBox
    Friend WithEvents hobi10 As CheckBox
    Friend WithEvents hobi9 As CheckBox
    Friend WithEvents hobi8 As CheckBox
    Friend WithEvents hobi7 As CheckBox
    Friend WithEvents hobi6 As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents browse As Button
    Friend WithEvents print As Button
    Friend WithEvents PictureBox1 As PictureBox

End Class
