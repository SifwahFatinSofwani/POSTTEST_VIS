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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        MenuStrip1 = New MenuStrip()
        InputToolStripMenuItem = New ToolStripMenuItem()
        LihatKartuToolStripMenuItem = New ToolStripMenuItem()
        SimpanDataToolStripMenuItem = New ToolStripMenuItem()
        BukaDataToolStripMenuItem = New ToolStripMenuItem()
        KeluarToolStripMenuItem = New ToolStripMenuItem()
        ToolStripMenuItem1 = New ToolStripMenuItem()
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        Label11 = New Label()
        Label5 = New Label()
        rbPerempuan = New RadioButton()
        cmbKomunitas = New ComboBox()
        rbLaki = New RadioButton()
        dtpTanggalLahir = New DateTimePicker()
        txtUmur = New TextBox()
        txtNama = New TextBox()
        txtID = New TextBox()
        Label3 = New Label()
        Label6 = New Label()
        Label2 = New Label()
        Label10 = New Label()
        Label4 = New Label()
        TabPage2 = New TabPage()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        txtAlamat = New TextBox()
        txtEmail = New TextBox()
        mtbTelepon = New MaskedTextBox()
        TabPage3 = New TabPage()
        btnSimpan = New Button()
        GroupBox2 = New GroupBox()
        cb13 = New CheckBox()
        cb18 = New CheckBox()
        cb17 = New CheckBox()
        cb16 = New CheckBox()
        cb15 = New CheckBox()
        cb14 = New CheckBox()
        cb7 = New CheckBox()
        cb12 = New CheckBox()
        cb11 = New CheckBox()
        cb10 = New CheckBox()
        cb9 = New CheckBox()
        cb8 = New CheckBox()
        cb1 = New CheckBox()
        cb6 = New CheckBox()
        cb5 = New CheckBox()
        cb4 = New CheckBox()
        cb3 = New CheckBox()
        cb2 = New CheckBox()
        PictureBox1 = New PictureBox()
        GroupBoxPerson = New GroupBox()
        rbCoach = New RadioButton()
        rbC = New RadioButton()
        rbPF = New RadioButton()
        rbSG = New RadioButton()
        rbSF = New RadioButton()
        rbPG = New RadioButton()
        btnBrowse = New Button()
        OpenFileDialog1 = New OpenFileDialog()
        SaveFileDialog1 = New SaveFileDialog()
        ErrorProvider1 = New ErrorProvider(components)
        Panel1 = New Panel()
        MenuStrip1.SuspendLayout()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        TabPage2.SuspendLayout()
        TabPage3.SuspendLayout()
        GroupBox2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBoxPerson.SuspendLayout()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = SystemColors.HighlightText
        MenuStrip1.Font = New Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {InputToolStripMenuItem, LihatKartuToolStripMenuItem, SimpanDataToolStripMenuItem, BukaDataToolStripMenuItem, KeluarToolStripMenuItem, ToolStripMenuItem1})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(766, 38)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' InputToolStripMenuItem
        ' 
        InputToolStripMenuItem.Name = "InputToolStripMenuItem"
        InputToolStripMenuItem.Size = New Size(120, 34)
        InputToolStripMenuItem.Text = "Input Data"
        ' 
        ' LihatKartuToolStripMenuItem
        ' 
        LihatKartuToolStripMenuItem.Name = "LihatKartuToolStripMenuItem"
        LihatKartuToolStripMenuItem.Size = New Size(123, 34)
        LihatKartuToolStripMenuItem.Text = "Lihat Kartu"
        ' 
        ' SimpanDataToolStripMenuItem
        ' 
        SimpanDataToolStripMenuItem.Name = "SimpanDataToolStripMenuItem"
        SimpanDataToolStripMenuItem.Size = New Size(142, 34)
        SimpanDataToolStripMenuItem.Text = "Simpan Data"
        ' 
        ' BukaDataToolStripMenuItem
        ' 
        BukaDataToolStripMenuItem.Name = "BukaDataToolStripMenuItem"
        BukaDataToolStripMenuItem.Size = New Size(119, 34)
        BukaDataToolStripMenuItem.Text = "Buka Data"
        ' 
        ' KeluarToolStripMenuItem
        ' 
        KeluarToolStripMenuItem.Font = New Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        KeluarToolStripMenuItem.Size = New Size(84, 34)
        KeluarToolStripMenuItem.Text = "Keluar"
        ' 
        ' ToolStripMenuItem1
        ' 
        ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        ToolStripMenuItem1.Size = New Size(14, 34)
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Controls.Add(TabPage3)
        TabControl1.Font = New Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TabControl1.Location = New Point(0, 187)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(765, 352)
        TabControl1.TabIndex = 3
        ' 
        ' TabPage1
        ' 
        TabPage1.BackColor = Color.OldLace
        TabPage1.Controls.Add(Label11)
        TabPage1.Controls.Add(Label5)
        TabPage1.Controls.Add(rbPerempuan)
        TabPage1.Controls.Add(cmbKomunitas)
        TabPage1.Controls.Add(rbLaki)
        TabPage1.Controls.Add(dtpTanggalLahir)
        TabPage1.Controls.Add(txtUmur)
        TabPage1.Controls.Add(txtNama)
        TabPage1.Controls.Add(txtID)
        TabPage1.Controls.Add(Label3)
        TabPage1.Controls.Add(Label6)
        TabPage1.Controls.Add(Label2)
        TabPage1.Controls.Add(Label10)
        TabPage1.Controls.Add(Label4)
        TabPage1.Location = New Point(4, 35)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(757, 313)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Data Utama"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Poppins", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(21, 258)
        Label11.Name = "Label11"
        Label11.Size = New Size(181, 40)
        Label11.TabIndex = 23
        Label11.Text = "Tanggal Lahir"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(54, 127)
        Label5.Name = "Label5"
        Label5.Size = New Size(0, 26)
        Label5.TabIndex = 17
        ' 
        ' rbPerempuan
        ' 
        rbPerempuan.AutoSize = True
        rbPerempuan.Font = New Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        rbPerempuan.Location = New Point(349, 210)
        rbPerempuan.Name = "rbPerempuan"
        rbPerempuan.Size = New Size(154, 40)
        rbPerempuan.TabIndex = 13
        rbPerempuan.TabStop = True
        rbPerempuan.Text = "Perempuan"
        rbPerempuan.UseVisualStyleBackColor = True
        ' 
        ' cmbKomunitas
        ' 
        cmbKomunitas.Font = New Font("Poppins", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cmbKomunitas.FormattingEnabled = True
        cmbKomunitas.Items.AddRange(New Object() {"Lakers", "Clippers", "Boston", "Golden State", "Raptors"})
        cmbKomunitas.Location = New Point(414, 150)
        cmbKomunitas.Name = "cmbKomunitas"
        cmbKomunitas.Size = New Size(311, 48)
        cmbKomunitas.TabIndex = 12
        ' 
        ' rbLaki
        ' 
        rbLaki.AutoSize = True
        rbLaki.Font = New Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        rbLaki.Location = New Point(210, 211)
        rbLaki.Name = "rbLaki"
        rbLaki.Size = New Size(133, 40)
        rbLaki.TabIndex = 11
        rbLaki.TabStop = True
        rbLaki.Text = "Laki - Laki"
        rbLaki.UseVisualStyleBackColor = True
        ' 
        ' dtpTanggalLahir
        ' 
        dtpTanggalLahir.Font = New Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        dtpTanggalLahir.Location = New Point(210, 259)
        dtpTanggalLahir.Name = "dtpTanggalLahir"
        dtpTanggalLahir.Size = New Size(515, 37)
        dtpTanggalLahir.TabIndex = 10
        ' 
        ' txtUmur
        ' 
        txtUmur.BorderStyle = BorderStyle.FixedSingle
        txtUmur.Font = New Font("Poppins", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtUmur.Location = New Point(31, 150)
        txtUmur.Name = "txtUmur"
        txtUmur.Size = New Size(351, 48)
        txtUmur.TabIndex = 9
        ' 
        ' txtNama
        ' 
        txtNama.BorderStyle = BorderStyle.FixedSingle
        txtNama.Font = New Font("Poppins", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtNama.Location = New Point(31, 52)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(351, 48)
        txtNama.TabIndex = 8
        ' 
        ' txtID
        ' 
        txtID.BorderStyle = BorderStyle.FixedSingle
        txtID.Font = New Font("Poppins", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtID.Location = New Point(414, 52)
        txtID.Name = "txtID"
        txtID.Size = New Size(311, 48)
        txtID.TabIndex = 7
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Poppins", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(408, 103)
        Label3.Name = "Label3"
        Label3.Size = New Size(182, 50)
        Label3.TabIndex = 21
        Label3.Text = "Komunitas"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Poppins", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(21, 211)
        Label6.Name = "Label6"
        Label6.Size = New Size(183, 40)
        Label6.TabIndex = 22
        Label6.Text = "Jenis Kelamin"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Poppins", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(21, 6)
        Label2.Name = "Label2"
        Label2.Size = New Size(111, 50)
        Label2.TabIndex = 14
        Label2.Text = "Nama"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Poppins", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(23, 103)
        Label10.Name = "Label10"
        Label10.Size = New Size(103, 50)
        Label10.TabIndex = 20
        Label10.Text = "Umur"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Poppins", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(407, 6)
        Label4.Name = "Label4"
        Label4.Size = New Size(50, 50)
        Label4.TabIndex = 19
        Label4.Text = "ID"
        ' 
        ' TabPage2
        ' 
        TabPage2.BackColor = Color.OldLace
        TabPage2.Controls.Add(Label9)
        TabPage2.Controls.Add(Label8)
        TabPage2.Controls.Add(Label7)
        TabPage2.Controls.Add(txtAlamat)
        TabPage2.Controls.Add(txtEmail)
        TabPage2.Controls.Add(mtbTelepon)
        TabPage2.Location = New Point(4, 35)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(757, 313)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Kontak & Info"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Poppins", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(17, 207)
        Label9.Name = "Label9"
        Label9.Size = New Size(130, 50)
        Label9.TabIndex = 5
        Label9.Text = "Alamat"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Poppins", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(17, 110)
        Label8.Name = "Label8"
        Label8.Size = New Size(102, 50)
        Label8.TabIndex = 4
        Label8.Text = "Email"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Poppins", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(17, 15)
        Label7.Name = "Label7"
        Label7.Size = New Size(236, 50)
        Label7.TabIndex = 3
        Label7.Text = "No Handphone"
        ' 
        ' txtAlamat
        ' 
        txtAlamat.Font = New Font("Poppins", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtAlamat.Location = New Point(27, 256)
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(706, 42)
        txtAlamat.TabIndex = 2
        ' 
        ' txtEmail
        ' 
        txtEmail.Font = New Font("Poppins", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtEmail.Location = New Point(27, 159)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(706, 42)
        txtEmail.TabIndex = 1
        ' 
        ' mtbTelepon
        ' 
        mtbTelepon.Font = New Font("Poppins", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        mtbTelepon.Location = New Point(27, 64)
        mtbTelepon.Mask = "0000-0000-0000"
        mtbTelepon.Name = "mtbTelepon"
        mtbTelepon.Size = New Size(706, 42)
        mtbTelepon.TabIndex = 0
        ' 
        ' TabPage3
        ' 
        TabPage3.BackColor = Color.OldLace
        TabPage3.Controls.Add(btnSimpan)
        TabPage3.Controls.Add(GroupBox2)
        TabPage3.Controls.Add(PictureBox1)
        TabPage3.Controls.Add(GroupBoxPerson)
        TabPage3.Controls.Add(btnBrowse)
        TabPage3.Location = New Point(4, 35)
        TabPage3.Name = "TabPage3"
        TabPage3.Padding = New Padding(3)
        TabPage3.Size = New Size(757, 313)
        TabPage3.TabIndex = 2
        TabPage3.Text = "Profil & Aktivitas"
        ' 
        ' btnSimpan
        ' 
        btnSimpan.Font = New Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnSimpan.Location = New Point(208, 275)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(529, 29)
        btnSimpan.TabIndex = 12
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(cb13)
        GroupBox2.Controls.Add(cb18)
        GroupBox2.Controls.Add(cb17)
        GroupBox2.Controls.Add(cb16)
        GroupBox2.Controls.Add(cb15)
        GroupBox2.Controls.Add(cb14)
        GroupBox2.Controls.Add(cb7)
        GroupBox2.Controls.Add(cb12)
        GroupBox2.Controls.Add(cb11)
        GroupBox2.Controls.Add(cb10)
        GroupBox2.Controls.Add(cb9)
        GroupBox2.Controls.Add(cb8)
        GroupBox2.Controls.Add(cb1)
        GroupBox2.Controls.Add(cb6)
        GroupBox2.Controls.Add(cb5)
        GroupBox2.Controls.Add(cb4)
        GroupBox2.Controls.Add(cb3)
        GroupBox2.Controls.Add(cb2)
        GroupBox2.Font = New Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GroupBox2.Location = New Point(392, 22)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(345, 247)
        GroupBox2.TabIndex = 11
        GroupBox2.TabStop = False
        GroupBox2.Text = "Hobi"
        ' 
        ' cb13
        ' 
        cb13.AutoSize = True
        cb13.Location = New Point(228, 26)
        cb13.Name = "cb13"
        cb13.Size = New Size(100, 30)
        cb13.TabIndex = 28
        cb13.Text = "Business"
        cb13.UseVisualStyleBackColor = True
        ' 
        ' cb18
        ' 
        cb18.AutoSize = True
        cb18.Location = New Point(228, 208)
        cb18.Name = "cb18"
        cb18.Size = New Size(73, 30)
        cb18.TabIndex = 27
        cb18.Text = "Draw"
        cb18.UseVisualStyleBackColor = True
        ' 
        ' cb17
        ' 
        cb17.AutoSize = True
        cb17.Location = New Point(228, 174)
        cb17.Name = "cb17"
        cb17.Size = New Size(91, 30)
        cb17.TabIndex = 26
        cb17.Text = "Singing"
        cb17.UseVisualStyleBackColor = True
        ' 
        ' cb16
        ' 
        cb16.AutoSize = True
        cb16.Location = New Point(228, 136)
        cb16.Name = "cb16"
        cb16.Size = New Size(98, 30)
        cb16.TabIndex = 25
        cb16.Text = "Cooking"
        cb16.UseVisualStyleBackColor = True
        ' 
        ' cb15
        ' 
        cb15.AutoSize = True
        cb15.Location = New Point(228, 98)
        cb15.Name = "cb15"
        cb15.Size = New Size(119, 30)
        cb15.TabIndex = 24
        cb15.Text = "Calisthenic"
        cb15.UseVisualStyleBackColor = True
        ' 
        ' cb14
        ' 
        cb14.AutoSize = True
        cb14.Location = New Point(228, 61)
        cb14.Name = "cb14"
        cb14.Size = New Size(69, 30)
        cb14.TabIndex = 23
        cb14.Text = "Gym"
        cb14.UseVisualStyleBackColor = True
        ' 
        ' cb7
        ' 
        cb7.AutoSize = True
        cb7.Location = New Point(122, 26)
        cb7.Name = "cb7"
        cb7.Size = New Size(92, 30)
        cb7.TabIndex = 22
        cb7.Text = "Renang"
        cb7.TextAlign = ContentAlignment.MiddleCenter
        cb7.UseVisualStyleBackColor = True
        ' 
        ' cb12
        ' 
        cb12.AutoSize = True
        cb12.Location = New Point(122, 208)
        cb12.Name = "cb12"
        cb12.Size = New Size(102, 30)
        cb12.TabIndex = 21
        cb12.Text = "Investing"
        cb12.UseVisualStyleBackColor = True
        ' 
        ' cb11
        ' 
        cb11.AutoSize = True
        cb11.Location = New Point(122, 174)
        cb11.Name = "cb11"
        cb11.Size = New Size(46, 30)
        cb11.TabIndex = 20
        cb11.Text = "IT"
        cb11.UseVisualStyleBackColor = True
        ' 
        ' cb10
        ' 
        cb10.AutoSize = True
        cb10.Location = New Point(122, 136)
        cb10.Name = "cb10"
        cb10.Size = New Size(105, 30)
        cb10.TabIndex = 19
        cb10.Text = "Berkebun"
        cb10.UseVisualStyleBackColor = True
        ' 
        ' cb9
        ' 
        cb9.AutoSize = True
        cb9.Location = New Point(122, 98)
        cb9.Name = "cb9"
        cb9.Size = New Size(62, 30)
        cb9.TabIndex = 18
        cb9.Text = "Voli"
        cb9.UseVisualStyleBackColor = True
        ' 
        ' cb8
        ' 
        cb8.AutoSize = True
        cb8.Location = New Point(122, 61)
        cb8.Name = "cb8"
        cb8.Size = New Size(77, 30)
        cb8.TabIndex = 17
        cb8.Text = "Catur"
        cb8.UseVisualStyleBackColor = True
        ' 
        ' cb1
        ' 
        cb1.AutoSize = True
        cb1.Location = New Point(13, 27)
        cb1.Name = "cb1"
        cb1.Size = New Size(72, 30)
        cb1.TabIndex = 16
        cb1.Text = "Tidur"
        cb1.UseVisualStyleBackColor = True
        ' 
        ' cb6
        ' 
        cb6.AutoSize = True
        cb6.Location = New Point(13, 209)
        cb6.Name = "cb6"
        cb6.Size = New Size(77, 30)
        cb6.TabIndex = 13
        cb6.Text = "Video"
        cb6.UseVisualStyleBackColor = True
        ' 
        ' cb5
        ' 
        cb5.AutoSize = True
        cb5.Location = New Point(13, 175)
        cb5.Name = "cb5"
        cb5.Size = New Size(78, 30)
        cb5.TabIndex = 12
        cb5.Text = "Photo"
        cb5.UseVisualStyleBackColor = True
        ' 
        ' cb4
        ' 
        cb4.AutoSize = True
        cb4.Location = New Point(13, 137)
        cb4.Name = "cb4"
        cb4.Size = New Size(90, 30)
        cb4.TabIndex = 11
        cb4.Text = "Design "
        cb4.UseVisualStyleBackColor = True
        ' 
        ' cb3
        ' 
        cb3.AutoSize = True
        cb3.Location = New Point(13, 99)
        cb3.Name = "cb3"
        cb3.Size = New Size(94, 30)
        cb3.TabIndex = 10
        cb3.Text = "Fashion"
        cb3.UseVisualStyleBackColor = True
        ' 
        ' cb2
        ' 
        cb2.AutoSize = True
        cb2.Location = New Point(13, 62)
        cb2.Name = "cb2"
        cb2.Size = New Size(105, 30)
        cb2.TabIndex = 9
        cb2.Text = "Makanan"
        cb2.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BorderStyle = BorderStyle.FixedSingle
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(18, 20)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(169, 247)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 10
        PictureBox1.TabStop = False
        ' 
        ' GroupBoxPerson
        ' 
        GroupBoxPerson.Controls.Add(rbCoach)
        GroupBoxPerson.Controls.Add(rbC)
        GroupBoxPerson.Controls.Add(rbPF)
        GroupBoxPerson.Controls.Add(rbSG)
        GroupBoxPerson.Controls.Add(rbSF)
        GroupBoxPerson.Controls.Add(rbPG)
        GroupBoxPerson.Font = New Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GroupBoxPerson.Location = New Point(208, 22)
        GroupBoxPerson.Name = "GroupBoxPerson"
        GroupBoxPerson.Size = New Size(159, 247)
        GroupBoxPerson.TabIndex = 8
        GroupBoxPerson.TabStop = False
        GroupBoxPerson.Text = "Posisi"
        ' 
        ' rbCoach
        ' 
        rbCoach.AutoSize = True
        rbCoach.Location = New Point(13, 209)
        rbCoach.Name = "rbCoach"
        rbCoach.Size = New Size(84, 30)
        rbCoach.TabIndex = 8
        rbCoach.TabStop = True
        rbCoach.Text = "Coach"
        rbCoach.UseVisualStyleBackColor = True
        ' 
        ' rbC
        ' 
        rbC.AutoSize = True
        rbC.Location = New Point(13, 174)
        rbC.Name = "rbC"
        rbC.Size = New Size(84, 30)
        rbC.TabIndex = 7
        rbC.TabStop = True
        rbC.Text = "Center"
        rbC.UseVisualStyleBackColor = True
        ' 
        ' rbPF
        ' 
        rbPF.AutoSize = True
        rbPF.Location = New Point(13, 137)
        rbPF.Name = "rbPF"
        rbPF.Size = New Size(145, 30)
        rbPF.TabIndex = 6
        rbPF.TabStop = True
        rbPF.Text = "Power Forward"
        rbPF.UseVisualStyleBackColor = True
        ' 
        ' rbSG
        ' 
        rbSG.AutoSize = True
        rbSG.Location = New Point(13, 62)
        rbSG.Name = "rbSG"
        rbSG.Size = New Size(153, 30)
        rbSG.TabIndex = 5
        rbSG.TabStop = True
        rbSG.Text = "Shooting Guard"
        rbSG.UseVisualStyleBackColor = True
        ' 
        ' rbSF
        ' 
        rbSF.AutoSize = True
        rbSF.Location = New Point(13, 99)
        rbSF.Name = "rbSF"
        rbSF.Size = New Size(135, 30)
        rbSF.TabIndex = 4
        rbSF.TabStop = True
        rbSF.Text = "Small Foward"
        rbSF.UseVisualStyleBackColor = True
        ' 
        ' rbPG
        ' 
        rbPG.AutoSize = True
        rbPG.Location = New Point(13, 26)
        rbPG.Name = "rbPG"
        rbPG.Size = New Size(123, 30)
        rbPG.TabIndex = 0
        rbPG.TabStop = True
        rbPG.Text = "Point Guard"
        rbPG.UseVisualStyleBackColor = True
        ' 
        ' btnBrowse
        ' 
        btnBrowse.Font = New Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnBrowse.Location = New Point(18, 275)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(169, 29)
        btnBrowse.TabIndex = 7
        btnBrowse.Text = "Browse"
        btnBrowse.UseVisualStyleBackColor = True
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' Panel1
        ' 
        Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), Image)
        Panel1.Location = New Point(0, 41)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(766, 140)
        Panel1.TabIndex = 4
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Linen
        ClientSize = New Size(766, 538)
        Controls.Add(Panel1)
        Controls.Add(TabControl1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "Form1"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        TabPage3.ResumeLayout(False)
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        GroupBoxPerson.ResumeLayout(False)
        GroupBoxPerson.PerformLayout()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents InputToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LihatKartuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SimpanDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BukaDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents pbLogo As PictureBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents btnBrowse As Button
    Friend WithEvents rbPerempuan As RadioButton
    Friend WithEvents cmbKomunitas As ComboBox
    Friend WithEvents rbLaki As RadioButton
    Friend WithEvents dtpTanggalLahir As DateTimePicker
    Friend WithEvents txtUmur As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents mtbTelepon As MaskedTextBox
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents cb2 As CheckBox
    Friend WithEvents GroupBoxPerson As GroupBox
    Friend WithEvents rbSF As RadioButton
    Friend WithEvents rbPG As RadioButton
    Friend WithEvents rbSG As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rbCoach As RadioButton
    Friend WithEvents rbC As RadioButton
    Friend WithEvents rbPF As RadioButton
    Friend WithEvents cb13 As CheckBox
    Friend WithEvents cb18 As CheckBox
    Friend WithEvents cb17 As CheckBox
    Friend WithEvents cb16 As CheckBox
    Friend WithEvents cb15 As CheckBox
    Friend WithEvents cb14 As CheckBox
    Friend WithEvents cb7 As CheckBox
    Friend WithEvents cb12 As CheckBox
    Friend WithEvents cb11 As CheckBox
    Friend WithEvents cb10 As CheckBox
    Friend WithEvents cb9 As CheckBox
    Friend WithEvents cb8 As CheckBox
    Friend WithEvents cb1 As CheckBox
    Friend WithEvents cb6 As CheckBox
    Friend WithEvents cb5 As CheckBox
    Friend WithEvents cb4 As CheckBox
    Friend WithEvents cb3 As CheckBox
    Friend WithEvents btnSimpan As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel1 As Panel

End Class
