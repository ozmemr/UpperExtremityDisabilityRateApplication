<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PeriferikSinir
    Inherits System.Windows.Forms.Form

    'Form, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
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

    'Windows Form Tasarımcısı tarafından gerektirilir
    Private components As System.ComponentModel.IContainer

    'NOT: Aşağıdaki yordam Windows Form Tasarımcısı için gereklidir
    'Windows Form Tasarımcısı kullanılarak değiştirilebilir.  
    'Kod düzenleyicisini kullanarak değiştirmeyin.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PeriferikSinir))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbD0 = New System.Windows.Forms.RadioButton()
        Me.rbD1 = New System.Windows.Forms.RadioButton()
        Me.rbD2 = New System.Windows.Forms.RadioButton()
        Me.rbD3 = New System.Windows.Forms.RadioButton()
        Me.rbD4 = New System.Windows.Forms.RadioButton()
        Me.rbD5 = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbM0 = New System.Windows.Forms.RadioButton()
        Me.rbM1 = New System.Windows.Forms.RadioButton()
        Me.rbM2 = New System.Windows.Forms.RadioButton()
        Me.rbM3 = New System.Windows.Forms.RadioButton()
        Me.rbM4 = New System.Windows.Forms.RadioButton()
        Me.rbM5 = New System.Windows.Forms.RadioButton()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.listboxSinirler = New System.Windows.Forms.ListBox()
        Me.listBoxOzet2 = New System.Windows.Forms.ListBox()
        Me.listboxKombinePuanlar = New System.Windows.Forms.ListBox()
        Me.listboxDuyu = New System.Windows.Forms.ListBox()
        Me.listboxMotor = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.listBoxDuyuSiddet = New System.Windows.Forms.ListBox()
        Me.listBoxMotorSiddet = New System.Windows.Forms.ListBox()
        Me.GroupBox12 = New System.Windows.Forms.GroupBox()
        Me.textboxLokalRapor = New System.Windows.Forms.TextBox()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox11 = New System.Windows.Forms.GroupBox()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.btnSaveExit = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox12.SuspendLayout()
        Me.GroupBox11.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbD0)
        Me.GroupBox1.Controls.Add(Me.rbD1)
        Me.GroupBox1.Controls.Add(Me.rbD2)
        Me.GroupBox1.Controls.Add(Me.rbD3)
        Me.GroupBox1.Controls.Add(Me.rbD4)
        Me.GroupBox1.Controls.Add(Me.rbD5)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(310, 36)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1092, 362)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ağrı veya Duyu Kaybı Derecesi (Tablo 2.10)"
        '
        'rbD0
        '
        Me.rbD0.AutoSize = True
        Me.rbD0.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.rbD0.Location = New System.Drawing.Point(32, 313)
        Me.rbD0.Name = "rbD0"
        Me.rbD0.Size = New System.Drawing.Size(497, 24)
        Me.rbD0.TabIndex = 5
        Me.rbD0.Text = "Aktiviteyi tam engelleyen anormal duyu, ciddi ağrı ve tam duyu kaybı"
        Me.rbD0.UseVisualStyleBackColor = True
        '
        'rbD1
        '
        Me.rbD1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.rbD1.Location = New System.Drawing.Point(32, 244)
        Me.rbD1.Name = "rbD1"
        Me.rbD1.Size = New System.Drawing.Size(749, 63)
        Me.rbD1.TabIndex = 4
        Me.rbD1.Text = "Birçok aktiviteyi engelleyen, anormal duyunun (örn. disestezi) veya ciddi dereced" &
    "e ağrının eşlik ettiği, yüzeyel ve taktil duyu kaybı (derin duyu korunmuş)"
        Me.rbD1.UseVisualStyleBackColor = True
        '
        'rbD2
        '
        Me.rbD2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.rbD2.Location = New System.Drawing.Point(32, 175)
        Me.rbD2.Name = "rbD2"
        Me.rbD2.Size = New System.Drawing.Size(773, 63)
        Me.rbD2.TabIndex = 3
        Me.rbD2.Text = "Bazı aktiviteleri engelleyen, anormal duyunun (örn. disestezi) veya orta derecede" &
    " ağrının eşlik ettiği azalmış yüzeyel ve taktil duyu"
        Me.rbD2.UseVisualStyleBackColor = True
        '
        'rbD3
        '
        Me.rbD3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.rbD3.Location = New System.Drawing.Point(32, 117)
        Me.rbD3.Name = "rbD3"
        Me.rbD3.Size = New System.Drawing.Size(767, 52)
        Me.rbD3.TabIndex = 2
        Me.rbD3.Text = "Bazı aktiviteleri etkileyen, anormal duyunun (örn. disestezi) veya hafif ağrının " &
    "eşlik ettiği bozulmuş yüzeyel duyu (azalmış hafif dokunma ve iki nokta ayırımı)"
        Me.rbD3.UseVisualStyleBackColor = True
        '
        'rbD4
        '
        Me.rbD4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.rbD4.Location = New System.Drawing.Point(32, 71)
        Me.rbD4.Name = "rbD4"
        Me.rbD4.Size = New System.Drawing.Size(767, 55)
        Me.rbD4.TabIndex = 1
        Me.rbD4.Text = "Aktivite esnasında unutulan bozulmuş yüzeyel duyu (azalmış hafif dokunma) veya ağ" &
    "rı ile birlikte olan veya olmayan hafif duyu kaybı dokunma) veya ağrı ile birlik" &
    "te olan veya olmayan hafif duyu kaybı"
        Me.rbD4.UseVisualStyleBackColor = True
        '
        'rbD5
        '
        Me.rbD5.Checked = True
        Me.rbD5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.rbD5.Location = New System.Drawing.Point(32, 41)
        Me.rbD5.Name = "rbD5"
        Me.rbD5.Size = New System.Drawing.Size(305, 24)
        Me.rbD5.TabIndex = 0
        Me.rbD5.TabStop = True
        Me.rbD5.Text = "Duyu kaybı, anormal duyu veya ağrı yok "
        Me.rbD5.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbM0)
        Me.GroupBox2.Controls.Add(Me.rbM1)
        Me.GroupBox2.Controls.Add(Me.rbM2)
        Me.GroupBox2.Controls.Add(Me.rbM3)
        Me.GroupBox2.Controls.Add(Me.rbM4)
        Me.GroupBox2.Controls.Add(Me.rbM5)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(310, 418)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(549, 401)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Kuvvet ve Motor Kaybı Derecesi (Tablo 2.11)"
        '
        'rbM0
        '
        Me.rbM0.AutoSize = True
        Me.rbM0.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.rbM0.Location = New System.Drawing.Point(32, 227)
        Me.rbM0.Name = "rbM0"
        Me.rbM0.Size = New System.Drawing.Size(224, 24)
        Me.rbM0.TabIndex = 5
        Me.rbM0.Text = "Kontraksiyon ve hareket yok"
        Me.rbM0.UseVisualStyleBackColor = True
        '
        'rbM1
        '
        Me.rbM1.AutoSize = True
        Me.rbM1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.rbM1.Location = New System.Drawing.Point(32, 193)
        Me.rbM1.Name = "rbM1"
        Me.rbM1.Size = New System.Drawing.Size(244, 24)
        Me.rbM1.TabIndex = 4
        Me.rbM1.Text = "Hafif kontraksiyon, hareket yok"
        Me.rbM1.UseVisualStyleBackColor = True
        '
        'rbM2
        '
        Me.rbM2.AutoSize = True
        Me.rbM2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.rbM2.Location = New System.Drawing.Point(32, 159)
        Me.rbM2.Name = "rbM2"
        Me.rbM2.Size = New System.Drawing.Size(370, 24)
        Me.rbM2.TabIndex = 3
        Me.rbM2.Text = "Yerçekimi ortadan kaldırıldığı zaman aktif hareket"
        Me.rbM2.UseVisualStyleBackColor = True
        '
        'rbM3
        '
        Me.rbM3.AutoSize = True
        Me.rbM3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.rbM3.Location = New System.Drawing.Point(32, 125)
        Me.rbM3.Name = "rbM3"
        Me.rbM3.Size = New System.Drawing.Size(298, 24)
        Me.rbM3.TabIndex = 2
        Me.rbM3.Text = "Sadece yerçekimine karşı aktif hareket"
        Me.rbM3.UseVisualStyleBackColor = True
        '
        'rbM4
        '
        Me.rbM4.AutoSize = True
        Me.rbM4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.rbM4.Location = New System.Drawing.Point(32, 91)
        Me.rbM4.Name = "rbM4"
        Me.rbM4.Size = New System.Drawing.Size(347, 24)
        Me.rbM4.TabIndex = 1
        Me.rbM4.Text = "Kısmi direnç ve yerçekimine karşı aktif hareket"
        Me.rbM4.UseVisualStyleBackColor = True
        '
        'rbM5
        '
        Me.rbM5.AutoSize = True
        Me.rbM5.Checked = True
        Me.rbM5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.rbM5.Location = New System.Drawing.Point(32, 57)
        Me.rbM5.Name = "rbM5"
        Me.rbM5.Size = New System.Drawing.Size(510, 24)
        Me.rbM5.TabIndex = 0
        Me.rbM5.TabStop = True
        Me.rbM5.Text = "Yer çekimine karşı maksimum dirençle engellenemeyen aktif hareket "
        Me.rbM5.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnRemove.Location = New System.Drawing.Point(151, 418)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(111, 49)
        Me.btnRemove.TabIndex = 4
        Me.btnRemove.Text = "Kaldır ↑"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(34, 418)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(111, 49)
        Me.btnAdd.TabIndex = 3
        Me.btnAdd.Text = "Ekle ↓"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'listboxSinirler
        '
        Me.listboxSinirler.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.listboxSinirler.FormattingEnabled = True
        Me.listboxSinirler.ItemHeight = 18
        Me.listboxSinirler.Location = New System.Drawing.Point(22, 48)
        Me.listboxSinirler.Name = "listboxSinirler"
        Me.listboxSinirler.Size = New System.Drawing.Size(272, 364)
        Me.listboxSinirler.TabIndex = 6
        '
        'listBoxOzet2
        '
        Me.listBoxOzet2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.listBoxOzet2.FormattingEnabled = True
        Me.listBoxOzet2.HorizontalScrollbar = True
        Me.listBoxOzet2.ItemHeight = 18
        Me.listBoxOzet2.Location = New System.Drawing.Point(22, 509)
        Me.listBoxOzet2.Name = "listBoxOzet2"
        Me.listBoxOzet2.Size = New System.Drawing.Size(272, 310)
        Me.listBoxOzet2.TabIndex = 7
        '
        'listboxKombinePuanlar
        '
        Me.listboxKombinePuanlar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.listboxKombinePuanlar.FormattingEnabled = True
        Me.listboxKombinePuanlar.ItemHeight = 18
        Me.listboxKombinePuanlar.Location = New System.Drawing.Point(1146, 5)
        Me.listboxKombinePuanlar.Name = "listboxKombinePuanlar"
        Me.listboxKombinePuanlar.Size = New System.Drawing.Size(95, 40)
        Me.listboxKombinePuanlar.TabIndex = 12
        Me.listboxKombinePuanlar.Visible = False
        '
        'listboxDuyu
        '
        Me.listboxDuyu.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.listboxDuyu.FormattingEnabled = True
        Me.listboxDuyu.ItemHeight = 18
        Me.listboxDuyu.Location = New System.Drawing.Point(1048, 5)
        Me.listboxDuyu.Name = "listboxDuyu"
        Me.listboxDuyu.Size = New System.Drawing.Size(43, 40)
        Me.listboxDuyu.TabIndex = 13
        Me.listboxDuyu.Visible = False
        '
        'listboxMotor
        '
        Me.listboxMotor.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.listboxMotor.FormattingEnabled = True
        Me.listboxMotor.ItemHeight = 18
        Me.listboxMotor.Location = New System.Drawing.Point(1097, 5)
        Me.listboxMotor.Name = "listboxMotor"
        Me.listboxMotor.Size = New System.Drawing.Size(43, 40)
        Me.listboxMotor.TabIndex = 14
        Me.listboxMotor.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 486)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(246, 20)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Etkilenen Sinirler ve Özür Puanları"
        '
        'listBoxDuyuSiddet
        '
        Me.listBoxDuyuSiddet.FormattingEnabled = True
        Me.listBoxDuyuSiddet.Location = New System.Drawing.Point(934, 5)
        Me.listBoxDuyuSiddet.Name = "listBoxDuyuSiddet"
        Me.listBoxDuyuSiddet.Size = New System.Drawing.Size(40, 30)
        Me.listBoxDuyuSiddet.TabIndex = 19
        Me.listBoxDuyuSiddet.Visible = False
        '
        'listBoxMotorSiddet
        '
        Me.listBoxMotorSiddet.FormattingEnabled = True
        Me.listBoxMotorSiddet.Location = New System.Drawing.Point(980, 5)
        Me.listBoxMotorSiddet.Name = "listBoxMotorSiddet"
        Me.listBoxMotorSiddet.Size = New System.Drawing.Size(40, 30)
        Me.listBoxMotorSiddet.TabIndex = 20
        Me.listBoxMotorSiddet.Visible = False
        '
        'GroupBox12
        '
        Me.GroupBox12.Controls.Add(Me.textboxLokalRapor)
        Me.GroupBox12.Controls.Add(Me.btnReset)
        Me.GroupBox12.Controls.Add(Me.Button1)
        Me.GroupBox12.Controls.Add(Me.GroupBox11)
        Me.GroupBox12.Controls.Add(Me.btnSaveExit)
        Me.GroupBox12.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GroupBox12.Location = New System.Drawing.Point(877, 418)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Size = New System.Drawing.Size(525, 401)
        Me.GroupBox12.TabIndex = 30
        Me.GroupBox12.TabStop = False
        Me.GroupBox12.Text = "İşlemler"
        '
        'textboxLokalRapor
        '
        Me.textboxLokalRapor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.textboxLokalRapor.Location = New System.Drawing.Point(201, 41)
        Me.textboxLokalRapor.Multiline = True
        Me.textboxLokalRapor.Name = "textboxLokalRapor"
        Me.textboxLokalRapor.ReadOnly = True
        Me.textboxLokalRapor.Size = New System.Drawing.Size(318, 354)
        Me.textboxLokalRapor.TabIndex = 30
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
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(9, 94)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(177, 57)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "Hesapla ve Raporla"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox11
        '
        Me.GroupBox11.Controls.Add(Me.lblResult)
        Me.GroupBox11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GroupBox11.Location = New System.Drawing.Point(9, 273)
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 20)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Periferik Sinir Listesi"
        '
        'PeriferikSinir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1541, 826)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox12)
        Me.Controls.Add(Me.listBoxMotorSiddet)
        Me.Controls.Add(Me.listBoxDuyuSiddet)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.listboxMotor)
        Me.Controls.Add(Me.listboxDuyu)
        Me.Controls.Add(Me.listboxKombinePuanlar)
        Me.Controls.Add(Me.listBoxOzet2)
        Me.Controls.Add(Me.listboxSinirler)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "PeriferikSinir"
        Me.Text = "Periferik Sinir"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox12.ResumeLayout(False)
        Me.GroupBox12.PerformLayout()
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox11.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rbD0 As RadioButton
    Friend WithEvents rbD1 As RadioButton
    Friend WithEvents rbD2 As RadioButton
    Friend WithEvents rbD3 As RadioButton
    Friend WithEvents rbD4 As RadioButton
    Friend WithEvents rbD5 As RadioButton
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents rbM0 As RadioButton
    Friend WithEvents rbM1 As RadioButton
    Friend WithEvents rbM2 As RadioButton
    Friend WithEvents rbM3 As RadioButton
    Friend WithEvents rbM4 As RadioButton
    Friend WithEvents rbM5 As RadioButton
    Friend WithEvents listboxSinirler As ListBox
    Friend WithEvents listBoxOzet2 As ListBox
    Friend WithEvents listboxKombinePuanlar As ListBox
    Friend WithEvents listboxDuyu As ListBox
    Friend WithEvents listboxMotor As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents listBoxDuyuSiddet As ListBox
    Friend WithEvents listBoxMotorSiddet As ListBox
    Friend WithEvents GroupBox12 As GroupBox
    Friend WithEvents textboxLokalRapor As TextBox
    Friend WithEvents btnReset As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox11 As GroupBox
    Friend WithEvents lblResult As Label
    Friend WithEvents btnSaveExit As Button
    Friend WithEvents Label2 As Label
End Class
