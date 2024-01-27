<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class artroplasti
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(artroplasti))
        Me.listBoxMevcutArtroplastilerPuan = New System.Windows.Forms.ListBox()
        Me.GroupBox12 = New System.Windows.Forms.GroupBox()
        Me.textboxArtroplastiLokalRapor = New System.Windows.Forms.TextBox()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.GroupBox11 = New System.Windows.Forms.GroupBox()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.btnSaveExit = New System.Windows.Forms.Button()
        Me.listboxMevcutArtroplastiler = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbRezeksiyon = New System.Windows.Forms.RadioButton()
        Me.rbImplant = New System.Windows.Forms.RadioButton()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.listboxArtroplastiTipleri = New System.Windows.Forms.ListBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.GroupBox12.SuspendLayout()
        Me.GroupBox11.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'listBoxMevcutArtroplastilerPuan
        '
        Me.listBoxMevcutArtroplastilerPuan.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.listBoxMevcutArtroplastilerPuan.FormattingEnabled = True
        Me.listBoxMevcutArtroplastilerPuan.ItemHeight = 24
        Me.listBoxMevcutArtroplastilerPuan.Location = New System.Drawing.Point(493, 289)
        Me.listBoxMevcutArtroplastilerPuan.Name = "listBoxMevcutArtroplastilerPuan"
        Me.listBoxMevcutArtroplastilerPuan.Size = New System.Drawing.Size(52, 76)
        Me.listBoxMevcutArtroplastilerPuan.TabIndex = 46
        Me.listBoxMevcutArtroplastilerPuan.Visible = False
        '
        'GroupBox12
        '
        Me.GroupBox12.Controls.Add(Me.textboxArtroplastiLokalRapor)
        Me.GroupBox12.Controls.Add(Me.btnReset)
        Me.GroupBox12.Controls.Add(Me.btnCalc)
        Me.GroupBox12.Controls.Add(Me.GroupBox11)
        Me.GroupBox12.Controls.Add(Me.btnSaveExit)
        Me.GroupBox12.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GroupBox12.Location = New System.Drawing.Point(444, 383)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Size = New System.Drawing.Size(672, 401)
        Me.GroupBox12.TabIndex = 45
        Me.GroupBox12.TabStop = False
        Me.GroupBox12.Text = "İşlemler"
        '
        'textboxArtroplastiLokalRapor
        '
        Me.textboxArtroplastiLokalRapor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.textboxArtroplastiLokalRapor.Location = New System.Drawing.Point(201, 41)
        Me.textboxArtroplastiLokalRapor.Multiline = True
        Me.textboxArtroplastiLokalRapor.Name = "textboxArtroplastiLokalRapor"
        Me.textboxArtroplastiLokalRapor.ReadOnly = True
        Me.textboxArtroplastiLokalRapor.Size = New System.Drawing.Size(444, 354)
        Me.textboxArtroplastiLokalRapor.TabIndex = 30
        '
        'btnReset
        '
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnReset.Image = CType(resources.GetObject("btnReset.Image"), System.Drawing.Image)
        Me.btnReset.Location = New System.Drawing.Point(9, 39)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(177, 49)
        Me.btnReset.TabIndex = 29
        Me.btnReset.Text = "Sıfırla"
        Me.btnReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnCalc
        '
        Me.btnCalc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnCalc.Image = CType(resources.GetObject("btnCalc.Image"), System.Drawing.Image)
        Me.btnCalc.Location = New System.Drawing.Point(9, 94)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(177, 57)
        Me.btnCalc.TabIndex = 25
        Me.btnCalc.Text = "Hesapla ve Raporla"
        Me.btnCalc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'GroupBox11
        '
        Me.GroupBox11.Controls.Add(Me.lblResult)
        Me.GroupBox11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GroupBox11.Location = New System.Drawing.Point(9, 212)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(177, 122)
        Me.GroupBox11.TabIndex = 26
        Me.GroupBox11.TabStop = False
        Me.GroupBox11.Text = "Üst Eks. Özürlülük Oranı"
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblResult.Location = New System.Drawing.Point(56, 33)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(68, 73)
        Me.lblResult.TabIndex = 0
        Me.lblResult.Text = "0"
        '
        'btnSaveExit
        '
        Me.btnSaveExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnSaveExit.Image = CType(resources.GetObject("btnSaveExit.Image"), System.Drawing.Image)
        Me.btnSaveExit.Location = New System.Drawing.Point(9, 157)
        Me.btnSaveExit.Name = "btnSaveExit"
        Me.btnSaveExit.Size = New System.Drawing.Size(177, 49)
        Me.btnSaveExit.TabIndex = 27
        Me.btnSaveExit.Text = "Kaydet ve Çık"
        Me.btnSaveExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSaveExit.UseVisualStyleBackColor = True
        '
        'listboxMevcutArtroplastiler
        '
        Me.listboxMevcutArtroplastiler.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.listboxMevcutArtroplastiler.FormattingEnabled = True
        Me.listboxMevcutArtroplastiler.ItemHeight = 24
        Me.listboxMevcutArtroplastiler.Location = New System.Drawing.Point(645, 12)
        Me.listboxMevcutArtroplastiler.Name = "listboxMevcutArtroplastiler"
        Me.listboxMevcutArtroplastiler.Size = New System.Drawing.Size(471, 364)
        Me.listboxMevcutArtroplastiler.TabIndex = 44
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbRezeksiyon)
        Me.GroupBox1.Controls.Add(Me.rbImplant)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(444, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(147, 122)
        Me.GroupBox1.TabIndex = 43
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Artroplasti Tipi"
        '
        'rbRezeksiyon
        '
        Me.rbRezeksiyon.AutoSize = True
        Me.rbRezeksiyon.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.rbRezeksiyon.Location = New System.Drawing.Point(21, 68)
        Me.rbRezeksiyon.Name = "rbRezeksiyon"
        Me.rbRezeksiyon.Size = New System.Drawing.Size(109, 24)
        Me.rbRezeksiyon.TabIndex = 1
        Me.rbRezeksiyon.Text = "Rezeksiyon"
        Me.rbRezeksiyon.UseVisualStyleBackColor = True
        '
        'rbImplant
        '
        Me.rbImplant.AutoSize = True
        Me.rbImplant.Checked = True
        Me.rbImplant.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.rbImplant.Location = New System.Drawing.Point(21, 36)
        Me.rbImplant.Name = "rbImplant"
        Me.rbImplant.Size = New System.Drawing.Size(80, 24)
        Me.rbImplant.TabIndex = 0
        Me.rbImplant.TabStop = True
        Me.rbImplant.Text = "İmplant"
        Me.rbImplant.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnRemove.Location = New System.Drawing.Point(444, 212)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(149, 49)
        Me.btnRemove.TabIndex = 42
        Me.btnRemove.Text = "<<< Kaldır"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'listboxArtroplastiTipleri
        '
        Me.listboxArtroplastiTipleri.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.listboxArtroplastiTipleri.FormattingEnabled = True
        Me.listboxArtroplastiTipleri.ItemHeight = 24
        Me.listboxArtroplastiTipleri.Location = New System.Drawing.Point(28, 12)
        Me.listboxArtroplastiTipleri.Name = "listboxArtroplastiTipleri"
        Me.listboxArtroplastiTipleri.Size = New System.Drawing.Size(382, 772)
        Me.listboxArtroplastiTipleri.TabIndex = 41
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(444, 157)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(149, 49)
        Me.btnAdd.TabIndex = 40
        Me.btnAdd.Text = "Ekle >>>"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'artroplasti
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1271, 799)
        Me.ControlBox = False
        Me.Controls.Add(Me.listBoxMevcutArtroplastilerPuan)
        Me.Controls.Add(Me.GroupBox12)
        Me.Controls.Add(Me.listboxMevcutArtroplastiler)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.listboxArtroplastiTipleri)
        Me.Controls.Add(Me.btnAdd)
        Me.Name = "artroplasti"
        Me.Text = "artroplasti"
        Me.GroupBox12.ResumeLayout(False)
        Me.GroupBox12.PerformLayout()
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox11.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents listBoxMevcutArtroplastilerPuan As ListBox
    Friend WithEvents GroupBox12 As GroupBox
    Friend WithEvents textboxArtroplastiLokalRapor As TextBox
    Friend WithEvents btnReset As Button
    Friend WithEvents btnCalc As Button
    Friend WithEvents GroupBox11 As GroupBox
    Friend WithEvents lblResult As Label
    Friend WithEvents btnSaveExit As Button
    Friend WithEvents listboxMevcutArtroplastiler As ListBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbRezeksiyon As RadioButton
    Friend WithEvents rbImplant As RadioButton
    Friend WithEvents btnRemove As Button
    Friend WithEvents listboxArtroplastiTipleri As ListBox
    Friend WithEvents btnAdd As Button
End Class
