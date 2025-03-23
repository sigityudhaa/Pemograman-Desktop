<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtnip = New System.Windows.Forms.TextBox()
        Me.txtnama = New System.Windows.Forms.TextBox()
        Me.cbmatkul = New System.Windows.Forms.ComboBox()
        Me.cbjurusan = New System.Windows.Forms.ComboBox()
        Me.rbl = New System.Windows.Forms.RadioButton()
        Me.rbp = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Txttugas = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtuts = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtuas = New System.Windows.Forms.TextBox()
        Me.lblgrade = New System.Windows.Forms.Label()
        Me.btnnew = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.dgvdata = New System.Windows.Forms.DataGridView()
        Me.dgnip = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgnama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgjeniskelamin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgjurusan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgmatkul = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dggrade = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvdata, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NIP"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 183)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Mata Kuliah"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(33, 137)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Jurusan"
        '
        'txtnip
        '
        Me.txtnip.Location = New System.Drawing.Point(130, 9)
        Me.txtnip.Name = "txtnip"
        Me.txtnip.Size = New System.Drawing.Size(222, 20)
        Me.txtnip.TabIndex = 4
        '
        'txtnama
        '
        Me.txtnama.Location = New System.Drawing.Point(130, 58)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(222, 20)
        Me.txtnama.TabIndex = 5
        '
        'cbmatkul
        '
        Me.cbmatkul.FormattingEnabled = True
        Me.cbmatkul.Location = New System.Drawing.Point(130, 175)
        Me.cbmatkul.Name = "cbmatkul"
        Me.cbmatkul.Size = New System.Drawing.Size(222, 21)
        Me.cbmatkul.TabIndex = 6
        '
        'cbjurusan
        '
        Me.cbjurusan.FormattingEnabled = True
        Me.cbjurusan.Location = New System.Drawing.Point(130, 129)
        Me.cbjurusan.Name = "cbjurusan"
        Me.cbjurusan.Size = New System.Drawing.Size(222, 21)
        Me.cbjurusan.TabIndex = 7
        '
        'rbl
        '
        Me.rbl.AutoSize = True
        Me.rbl.Location = New System.Drawing.Point(134, 90)
        Me.rbl.Name = "rbl"
        Me.rbl.Size = New System.Drawing.Size(60, 17)
        Me.rbl.TabIndex = 9
        Me.rbl.TabStop = True
        Me.rbl.Text = "laki laki"
        Me.rbl.UseVisualStyleBackColor = True
        '
        'rbp
        '
        Me.rbp.AutoSize = True
        Me.rbp.Location = New System.Drawing.Point(222, 90)
        Me.rbp.Name = "rbp"
        Me.rbp.Size = New System.Drawing.Size(78, 17)
        Me.rbp.TabIndex = 10
        Me.rbp.TabStop = True
        Me.rbp.Text = "perempuan"
        Me.rbp.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(30, 94)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Jenis Kelamin"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(35, 209)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(27, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Nilai"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(106, 209)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Tugas"
        '
        'Txttugas
        '
        Me.Txttugas.Location = New System.Drawing.Point(149, 202)
        Me.Txttugas.Name = "Txttugas"
        Me.Txttugas.Size = New System.Drawing.Size(62, 20)
        Me.Txttugas.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(217, 209)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(29, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "UTS"
        '
        'txtuts
        '
        Me.txtuts.Location = New System.Drawing.Point(252, 202)
        Me.txtuts.Name = "txtuts"
        Me.txtuts.Size = New System.Drawing.Size(62, 20)
        Me.txtuts.TabIndex = 16
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(336, 209)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(29, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "UAS"
        '
        'txtuas
        '
        Me.txtuas.Location = New System.Drawing.Point(371, 202)
        Me.txtuas.Name = "txtuas"
        Me.txtuas.Size = New System.Drawing.Size(62, 20)
        Me.txtuas.TabIndex = 18
        '
        'lblgrade
        '
        Me.lblgrade.AutoSize = True
        Me.lblgrade.Location = New System.Drawing.Point(470, 209)
        Me.lblgrade.Name = "lblgrade"
        Me.lblgrade.Size = New System.Drawing.Size(57, 13)
        Me.lblgrade.TabIndex = 19
        Me.lblgrade.Text = "- GRADE -"
        '
        'btnnew
        '
        Me.btnnew.Location = New System.Drawing.Point(14, 247)
        Me.btnnew.Name = "btnnew"
        Me.btnnew.Size = New System.Drawing.Size(75, 23)
        Me.btnnew.TabIndex = 20
        Me.btnnew.Text = "New"
        Me.btnnew.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Location = New System.Drawing.Point(109, 247)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(75, 23)
        Me.btnsave.TabIndex = 21
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'btndelete
        '
        Me.btndelete.Location = New System.Drawing.Point(199, 247)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(75, 23)
        Me.btndelete.TabIndex = 22
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'btnclose
        '
        Me.btnclose.Location = New System.Drawing.Point(290, 247)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(75, 23)
        Me.btnclose.TabIndex = 23
        Me.btnclose.Text = "Close"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'dgvdata
        '
        Me.dgvdata.AllowUserToAddRows = False
        Me.dgvdata.AllowUserToDeleteRows = False
        Me.dgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvdata.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgnip, Me.dgnama, Me.dgjeniskelamin, Me.dgjurusan, Me.dgmatkul, Me.dggrade})
        Me.dgvdata.Location = New System.Drawing.Point(4, 314)
        Me.dgvdata.Name = "dgvdata"
        Me.dgvdata.ReadOnly = True
        Me.dgvdata.Size = New System.Drawing.Size(715, 210)
        Me.dgvdata.TabIndex = 24
        '
        'dgnip
        '
        Me.dgnip.HeaderText = "NIP"
        Me.dgnip.Name = "dgnip"
        Me.dgnip.ReadOnly = True
        '
        'dgnama
        '
        Me.dgnama.HeaderText = "NAMA"
        Me.dgnama.Name = "dgnama"
        Me.dgnama.ReadOnly = True
        '
        'dgjeniskelamin
        '
        Me.dgjeniskelamin.HeaderText = "Jenis Kelamin"
        Me.dgjeniskelamin.Name = "dgjeniskelamin"
        Me.dgjeniskelamin.ReadOnly = True
        '
        'dgjurusan
        '
        Me.dgjurusan.HeaderText = "Jurusan"
        Me.dgjurusan.Name = "dgjurusan"
        Me.dgjurusan.ReadOnly = True
        '
        'dgmatkul
        '
        Me.dgmatkul.HeaderText = "Mata Kuliah"
        Me.dgmatkul.Name = "dgmatkul"
        Me.dgmatkul.ReadOnly = True
        '
        'dggrade
        '
        Me.dggrade.HeaderText = "Grade"
        Me.dggrade.Name = "dggrade"
        Me.dggrade.ReadOnly = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(748, 527)
        Me.Controls.Add(Me.dgvdata)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.btnnew)
        Me.Controls.Add(Me.lblgrade)
        Me.Controls.Add(Me.txtuas)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtuts)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Txttugas)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.rbp)
        Me.Controls.Add(Me.rbl)
        Me.Controls.Add(Me.cbjurusan)
        Me.Controls.Add(Me.cbmatkul)
        Me.Controls.Add(Me.txtnama)
        Me.Controls.Add(Me.txtnip)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dgvdata, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtnip As System.Windows.Forms.TextBox
    Friend WithEvents txtnama As System.Windows.Forms.TextBox
    Friend WithEvents cbmatkul As System.Windows.Forms.ComboBox
    Friend WithEvents cbjurusan As System.Windows.Forms.ComboBox
    Friend WithEvents rbl As System.Windows.Forms.RadioButton
    Friend WithEvents rbp As System.Windows.Forms.RadioButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Txttugas As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtuts As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtuas As System.Windows.Forms.TextBox
    Friend WithEvents lblgrade As System.Windows.Forms.Label
    Friend WithEvents btnnew As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents dgvdata As System.Windows.Forms.DataGridView
    Friend WithEvents dgnip As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgnama As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgjeniskelamin As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgjurusan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgmatkul As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dggrade As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
