<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        foto = New PictureBox()
        labelnama = New Label()
        labelumur = New Label()
        labelnotelp = New Label()
        labeltanggalahir = New Label()
        labelalamat = New Label()
        labelkelamin = New Label()
        labelhobi = New Label()
        CType(foto, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' foto
        ' 
        foto.Location = New Point(751, 30)
        foto.Name = "foto"
        foto.Size = New Size(251, 254)
        foto.SizeMode = PictureBoxSizeMode.StretchImage
        foto.TabIndex = 0
        foto.TabStop = False
        ' 
        ' labelnama
        ' 
        labelnama.AutoSize = True
        labelnama.BackColor = Color.Transparent
        labelnama.Font = New Font("Arial", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        labelnama.ForeColor = Color.White
        labelnama.Location = New Point(38, 332)
        labelnama.Name = "labelnama"
        labelnama.Size = New Size(111, 40)
        labelnama.TabIndex = 1
        labelnama.Text = "Nama"
        ' 
        ' labelumur
        ' 
        labelumur.AutoSize = True
        labelumur.BackColor = Color.Transparent
        labelumur.Font = New Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        labelumur.ForeColor = Color.White
        labelumur.Location = New Point(40, 364)
        labelumur.Name = "labelumur"
        labelumur.Size = New Size(89, 35)
        labelumur.TabIndex = 2
        labelumur.Text = "umur"
        ' 
        ' labelnotelp
        ' 
        labelnotelp.AutoSize = True
        labelnotelp.BackColor = Color.Transparent
        labelnotelp.Font = New Font("Arial", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        labelnotelp.ForeColor = Color.White
        labelnotelp.Location = New Point(41, 485)
        labelnotelp.Name = "labelnotelp"
        labelnotelp.Size = New Size(73, 24)
        labelnotelp.TabIndex = 3
        labelnotelp.Text = "Label1"
        ' 
        ' labeltanggalahir
        ' 
        labeltanggalahir.AutoSize = True
        labeltanggalahir.BackColor = Color.Transparent
        labeltanggalahir.Font = New Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        labeltanggalahir.ForeColor = Color.White
        labeltanggalahir.Location = New Point(40, 422)
        labeltanggalahir.Name = "labeltanggalahir"
        labeltanggalahir.Size = New Size(176, 35)
        labeltanggalahir.TabIndex = 4
        labeltanggalahir.Text = "tanggalahir"
        ' 
        ' labelalamat
        ' 
        labelalamat.AutoSize = True
        labelalamat.BackColor = Color.Transparent
        labelalamat.Font = New Font("Arial", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        labelalamat.ForeColor = Color.White
        labelalamat.Location = New Point(41, 458)
        labelalamat.Name = "labelalamat"
        labelalamat.Size = New Size(73, 24)
        labelalamat.TabIndex = 5
        labelalamat.Text = "Label1"
        ' 
        ' labelkelamin
        ' 
        labelkelamin.AutoSize = True
        labelkelamin.BackColor = Color.Transparent
        labelkelamin.Font = New Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        labelkelamin.ForeColor = Color.White
        labelkelamin.Location = New Point(40, 394)
        labelkelamin.Name = "labelkelamin"
        labelkelamin.Size = New Size(126, 35)
        labelkelamin.TabIndex = 6
        labelkelamin.Text = "kelamin"
        ' 
        ' labelhobi
        ' 
        labelhobi.AutoSize = True
        labelhobi.BackColor = Color.Transparent
        labelhobi.Font = New Font("Arial", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        labelhobi.ForeColor = Color.White
        labelhobi.Location = New Point(40, 509)
        labelhobi.Name = "labelhobi"
        labelhobi.Size = New Size(73, 24)
        labelhobi.TabIndex = 7
        labelhobi.Text = "Label1"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(1038, 585)
        Controls.Add(labelhobi)
        Controls.Add(labelkelamin)
        Controls.Add(labelalamat)
        Controls.Add(labeltanggalahir)
        Controls.Add(labelnotelp)
        Controls.Add(labelumur)
        Controls.Add(labelnama)
        Controls.Add(foto)
        Name = "Form2"
        Text = "Form2"
        CType(foto, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents foto As PictureBox
    Friend WithEvents labelnama As Label
    Friend WithEvents labelumur As Label
    Friend WithEvents labelnotelp As Label
    Friend WithEvents labeltanggalahir As Label
    Friend WithEvents labelalamat As Label
    Friend WithEvents labelkelamin As Label
    Friend WithEvents labelhobi As Label
End Class
