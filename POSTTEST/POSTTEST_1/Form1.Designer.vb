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
        label1 = New Label()
        label2 = New Label()
        label3 = New Label()
        Label4 = New Label()
        box1 = New TextBox()
        box2 = New TextBox()
        buttontambah = New Button()
        buttonreset = New Button()
        SuspendLayout()
        ' 
        ' label1
        ' 
        label1.AutoSize = True
        label1.BackColor = Color.Transparent
        label1.FlatStyle = FlatStyle.Flat
        label1.Font = New Font("JetBrains Mono NL", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        label1.Location = New Point(297, 165)
        label1.Name = "label1"
        label1.Size = New Size(204, 26)
        label1.TabIndex = 0
        label1.Text = "Masukkan IP Anda"
        ' 
        ' label2
        ' 
        label2.AutoSize = True
        label2.BackColor = Color.Transparent
        label2.Font = New Font("JetBrains Mono", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        label2.Location = New Point(318, 121)
        label2.Name = "label2"
        label2.Size = New Size(156, 26)
        label2.TabIndex = 1
        label2.Text = "IP Kumulatif"
        ' 
        ' label3
        ' 
        label3.AutoSize = True
        label3.BackColor = Color.Transparent
        label3.Font = New Font("JetBrains Mono NL", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        label3.Location = New Point(492, 78)
        label3.Name = "label3"
        label3.Size = New Size(216, 26)
        label3.TabIndex = 2
        label3.Text = "Predikat IPK Anda"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Aharoni", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(182, 31)
        Label4.Name = "Label4"
        Label4.Size = New Size(423, 30)
        Label4.TabIndex = 3
        Label4.Text = "PROGRAM PENGHITUNG IPK"
        ' 
        ' box1
        ' 
        box1.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(255))
        box1.Font = New Font("JetBrains Mono NL SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        box1.ForeColor = SystemColors.Desktop
        box1.Location = New Point(321, 207)
        box1.Name = "box1"
        box1.Size = New Size(153, 27)
        box1.TabIndex = 4
        ' 
        ' box2
        ' 
        box2.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        box2.ForeColor = SystemColors.ControlText
        box2.Location = New Point(318, 77)
        box2.Name = "box2"
        box2.ReadOnly = True
        box2.Size = New Size(164, 27)
        box2.TabIndex = 5
        ' 
        ' buttontambah
        ' 
        buttontambah.BackColor = Color.FromArgb(CByte(255), CByte(224), CByte(192))
        buttontambah.Font = New Font("JetBrains Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        buttontambah.ForeColor = Color.Black
        buttontambah.Location = New Point(211, 205)
        buttontambah.Name = "buttontambah"
        buttontambah.Size = New Size(94, 29)
        buttontambah.TabIndex = 6
        buttontambah.Text = "Tambah"
        buttontambah.UseVisualStyleBackColor = False
        ' 
        ' buttonreset
        ' 
        buttonreset.BackColor = Color.FromArgb(CByte(255), CByte(224), CByte(192))
        buttonreset.Font = New Font("JetBrains Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        buttonreset.Location = New Point(211, 77)
        buttonreset.Name = "buttonreset"
        buttonreset.Size = New Size(94, 29)
        buttonreset.TabIndex = 7
        buttonreset.Text = "Reset"
        buttonreset.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        ClientSize = New Size(800, 450)
        Controls.Add(buttonreset)
        Controls.Add(buttontambah)
        Controls.Add(box2)
        Controls.Add(box1)
        Controls.Add(Label4)
        Controls.Add(label3)
        Controls.Add(label2)
        Controls.Add(label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents label1 As Label
    Friend WithEvents label2 As Label
    Friend WithEvents label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents box1 As TextBox
    Friend WithEvents box2 As TextBox
    Friend WithEvents buttontambah As Button
    Friend WithEvents buttonreset As Button

End Class
