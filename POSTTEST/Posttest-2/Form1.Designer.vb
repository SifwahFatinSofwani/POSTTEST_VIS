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
        Dim Label1 As Label
        dgvbuku = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Label2 = New Label()
        Label3 = New Label()
        buttontambah = New Button()
        buttonhapus = New Button()
        inputgenre = New TextBox()
        inputhapus = New TextBox()
        Label5 = New Label()
        inputtambah = New TextBox()
        Label4 = New Label()
        Label6 = New Label()
        Panel1 = New Panel()
        GroupBox1 = New GroupBox()
        GroupBox2 = New GroupBox()
        Label1 = New Label()
        CType(dgvbuku, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.ForeColor = SystemColors.ActiveCaptionText
        Label1.Location = New Point(469, 119)
        Label1.Name = "Label1"
        Label1.Size = New Size(86, 20)
        Label1.TabIndex = 1
        Label1.Text = "Judul Buku: "
        ' 
        ' dgvbuku
        ' 
        dgvbuku.BackgroundColor = SystemColors.ButtonFace
        dgvbuku.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvbuku.Columns.AddRange(New DataGridViewColumn() {Column1, Column2})
        dgvbuku.Location = New Point(53, 133)
        dgvbuku.Name = "dgvbuku"
        dgvbuku.RowHeadersWidth = 51
        dgvbuku.Size = New Size(303, 199)
        dgvbuku.TabIndex = 0
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "judul"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        Column1.Width = 125
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "genre"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        Column2.Width = 125
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Location = New Point(504, 158)
        Label2.Name = "Label2"
        Label2.Size = New Size(51, 20)
        Label2.TabIndex = 2
        Label2.Text = "Genre:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Location = New Point(473, 283)
        Label3.Name = "Label3"
        Label3.Size = New Size(82, 20)
        Label3.TabIndex = 3
        Label3.Text = "Judul Buku:"
        ' 
        ' buttontambah
        ' 
        buttontambah.BackColor = Color.LightGreen
        buttontambah.BackgroundImageLayout = ImageLayout.Stretch
        buttontambah.FlatStyle = FlatStyle.Flat
        buttontambah.ForeColor = Color.White
        buttontambah.Location = New Point(561, 191)
        buttontambah.Name = "buttontambah"
        buttontambah.Size = New Size(171, 29)
        buttontambah.TabIndex = 4
        buttontambah.Text = "Tambah"
        buttontambah.UseVisualStyleBackColor = False
        ' 
        ' buttonhapus
        ' 
        buttonhapus.BackColor = Color.Red
        buttonhapus.FlatStyle = FlatStyle.Flat
        buttonhapus.ForeColor = SystemColors.ButtonFace
        buttonhapus.Location = New Point(561, 316)
        buttonhapus.Name = "buttonhapus"
        buttonhapus.Size = New Size(171, 29)
        buttonhapus.TabIndex = 5
        buttonhapus.Text = "Hapus"
        buttonhapus.UseVisualStyleBackColor = False
        ' 
        ' inputgenre
        ' 
        inputgenre.Location = New Point(561, 158)
        inputgenre.Name = "inputgenre"
        inputgenre.Size = New Size(171, 27)
        inputgenre.TabIndex = 7
        ' 
        ' inputhapus
        ' 
        inputhapus.BorderStyle = BorderStyle.None
        inputhapus.Location = New Point(561, 283)
        inputhapus.Name = "inputhapus"
        inputhapus.Size = New Size(171, 20)
        inputhapus.TabIndex = 8
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(589, 242)
        Label5.Name = "Label5"
        Label5.Size = New Size(115, 25)
        Label5.TabIndex = 10
        Label5.Text = "Hapus Buku"
        ' 
        ' inputtambah
        ' 
        inputtambah.Location = New Point(561, 119)
        inputtambah.Name = "inputtambah"
        inputtambah.Size = New Size(171, 27)
        inputtambah.TabIndex = 6
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = SystemColors.ActiveCaptionText
        Label4.Location = New Point(575, 70)
        Label4.Name = "Label4"
        Label4.Size = New Size(140, 28)
        Label4.TabIndex = 12
        Label4.Text = "Tambah Buku"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = SystemColors.ActiveCaption
        Label6.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = SystemColors.ActiveCaptionText
        Label6.Location = New Point(72, 82)
        Label6.Name = "Label6"
        Label6.Size = New Size(269, 38)
        Label6.TabIndex = 13
        Label6.Text = "Buku yang tersedia"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ActiveCaption
        Panel1.Controls.Add(Label6)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(425, 453)
        Panel1.TabIndex = 14
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Location = New Point(457, 78)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(300, 162)
        GroupBox1.TabIndex = 15
        GroupBox1.TabStop = False
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Location = New Point(457, 246)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(300, 125)
        GroupBox2.TabIndex = 16
        GroupBox2.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(inputtambah)
        Controls.Add(Label4)
        Controls.Add(Label5)
        Controls.Add(inputhapus)
        Controls.Add(inputgenre)
        Controls.Add(buttonhapus)
        Controls.Add(buttontambah)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(dgvbuku)
        Controls.Add(Panel1)
        Controls.Add(GroupBox1)
        Controls.Add(GroupBox2)
        Name = "Form1"
        Text = "Form1"
        CType(dgvbuku, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvbuku As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents buttontambah As Button
    Friend WithEvents buttonhapus As Button
    Friend WithEvents inputgenre As TextBox
    Friend WithEvents inputhapus As TextBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Label5 As Label
    Friend WithEvents inputtambah As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox

End Class
