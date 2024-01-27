<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Amputasyon
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Amputasyon))
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbD1KMK = New System.Windows.Forms.RadioButton()
        Me.rbD1HaricTumParmaklar = New System.Windows.Forms.RadioButton()
        Me.rbElTümMKF = New System.Windows.Forms.RadioButton()
        Me.rbOnKol = New System.Windows.Forms.RadioButton()
        Me.rbDeltoidbicepsarasi = New System.Windows.Forms.RadioButton()
        Me.rbDeltoidproksimali = New System.Windows.Forms.RadioButton()
        Me.rbOmuzDezartikulasyon = New System.Windows.Forms.RadioButton()
        Me.rbD1MKDistali = New System.Windows.Forms.RadioButton()
        Me.GroupBox12 = New System.Windows.Forms.GroupBox()
        Me.textboxLokalRapor = New System.Windows.Forms.TextBox()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.GroupBox11 = New System.Windows.Forms.GroupBox()
        Me.lblAmputasyon = New System.Windows.Forms.Label()
        Me.btnSaveExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox12.SuspendLayout()
        Me.GroupBox11.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblDescription
        '
        Me.lblDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblDescription.Location = New System.Drawing.Point(12, 31)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(992, 243)
        Me.lblDescription.TabIndex = 15
        Me.lblDescription.Text = resources.GetString("lblDescription.Text")
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 115)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(911, 243)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Ek not: Tablo 2.7'ye göre skapulotorasik amputasyon üst ekstremite özür puanı ver" &
    "meden doğrudan %70 kişi özür puanı vermektedir."
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbD1KMK)
        Me.GroupBox1.Controls.Add(Me.rbD1HaricTumParmaklar)
        Me.GroupBox1.Controls.Add(Me.rbElTümMKF)
        Me.GroupBox1.Controls.Add(Me.rbOnKol)
        Me.GroupBox1.Controls.Add(Me.rbDeltoidbicepsarasi)
        Me.GroupBox1.Controls.Add(Me.rbDeltoidproksimali)
        Me.GroupBox1.Controls.Add(Me.rbOmuzDezartikulasyon)
        Me.GroupBox1.Controls.Add(Me.rbD1MKDistali)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(27, 186)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(552, 548)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Üst Ekstremite Özür Oranı Veren Amputasyonlar (Tablo 2.7)"
        '
        'rbD1KMK
        '
        Me.rbD1KMK.Location = New System.Drawing.Point(52, 379)
        Me.rbD1KMK.Name = "rbD1KMK"
        Me.rbD1KMK.Size = New System.Drawing.Size(367, 81)
        Me.rbD1KMK.TabIndex = 30
        Me.rbD1KMK.TabStop = True
        Me.rbD1KMK.Text = "Baş parmak KMK eklem"
        Me.rbD1KMK.UseVisualStyleBackColor = True
        '
        'rbD1HaricTumParmaklar
        '
        Me.rbD1HaricTumParmaklar.Location = New System.Drawing.Point(52, 318)
        Me.rbD1HaricTumParmaklar.Name = "rbD1HaricTumParmaklar"
        Me.rbD1HaricTumParmaklar.Size = New System.Drawing.Size(367, 81)
        Me.rbD1HaricTumParmaklar.TabIndex = 29
        Me.rbD1HaricTumParmaklar.TabStop = True
        Me.rbD1HaricTumParmaklar.Text = "El: baş parmak hariç tüm parmakların MF"
        Me.rbD1HaricTumParmaklar.UseVisualStyleBackColor = True
        '
        'rbElTümMKF
        '
        Me.rbElTümMKF.Location = New System.Drawing.Point(52, 244)
        Me.rbElTümMKF.Name = "rbElTümMKF"
        Me.rbElTümMKF.Size = New System.Drawing.Size(367, 81)
        Me.rbElTümMKF.TabIndex = 28
        Me.rbElTümMKF.TabStop = True
        Me.rbElTümMKF.Text = "El: MF eklemden tüm parmakların kaybı"
        Me.rbElTümMKF.UseVisualStyleBackColor = True
        '
        'rbOnKol
        '
        Me.rbOnKol.Location = New System.Drawing.Point(52, 173)
        Me.rbOnKol.Name = "rbOnKol"
        Me.rbOnKol.Size = New System.Drawing.Size(367, 81)
        Me.rbOnKol.TabIndex = 27
        Me.rbOnKol.TabStop = True
        Me.rbOnKol.Text = "Ön kol/el: bisipital insersiyo distali - transmetakarpofalangiyal eklem"
        Me.rbOnKol.UseVisualStyleBackColor = True
        '
        'rbDeltoidbicepsarasi
        '
        Me.rbDeltoidbicepsarasi.AutoSize = True
        Me.rbDeltoidbicepsarasi.Location = New System.Drawing.Point(52, 139)
        Me.rbDeltoidbicepsarasi.Name = "rbDeltoidbicepsarasi"
        Me.rbDeltoidbicepsarasi.Size = New System.Drawing.Size(367, 28)
        Me.rbDeltoidbicepsarasi.TabIndex = 26
        Me.rbDeltoidbicepsarasi.TabStop = True
        Me.rbDeltoidbicepsarasi.Text = "Kol/ön kol: deltoid-bisipital insersiyo arası"
        Me.rbDeltoidbicepsarasi.UseVisualStyleBackColor = True
        '
        'rbDeltoidproksimali
        '
        Me.rbDeltoidproksimali.AutoSize = True
        Me.rbDeltoidproksimali.Location = New System.Drawing.Point(52, 91)
        Me.rbDeltoidproksimali.Name = "rbDeltoidproksimali"
        Me.rbDeltoidproksimali.Size = New System.Drawing.Size(336, 28)
        Me.rbDeltoidproksimali.TabIndex = 25
        Me.rbDeltoidproksimali.TabStop = True
        Me.rbDeltoidproksimali.Text = "Kol: Deltoid insersiyosu ve proksimali"
        Me.rbDeltoidproksimali.UseVisualStyleBackColor = True
        '
        'rbOmuzDezartikulasyon
        '
        Me.rbOmuzDezartikulasyon.AutoSize = True
        Me.rbOmuzDezartikulasyon.Location = New System.Drawing.Point(52, 42)
        Me.rbOmuzDezartikulasyon.Name = "rbOmuzDezartikulasyon"
        Me.rbOmuzDezartikulasyon.Size = New System.Drawing.Size(224, 28)
        Me.rbOmuzDezartikulasyon.TabIndex = 24
        Me.rbOmuzDezartikulasyon.TabStop = True
        Me.rbOmuzDezartikulasyon.Text = "Omuz dezartikülasyonu"
        Me.rbOmuzDezartikulasyon.UseVisualStyleBackColor = True
        '
        'rbD1MKDistali
        '
        Me.rbD1MKDistali.Location = New System.Drawing.Point(52, 452)
        Me.rbD1MKDistali.Name = "rbD1MKDistali"
        Me.rbD1MKDistali.Size = New System.Drawing.Size(367, 81)
        Me.rbD1MKDistali.TabIndex = 23
        Me.rbD1MKDistali.TabStop = True
        Me.rbD1MKDistali.Text = "Birinci metakarpın 1/3 distali"
        Me.rbD1MKDistali.UseVisualStyleBackColor = True
        '
        'GroupBox12
        '
        Me.GroupBox12.Controls.Add(Me.textboxLokalRapor)
        Me.GroupBox12.Controls.Add(Me.btnReset)
        Me.GroupBox12.Controls.Add(Me.GroupBox11)
        Me.GroupBox12.Controls.Add(Me.btnSaveExit)
        Me.GroupBox12.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GroupBox12.Location = New System.Drawing.Point(608, 186)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Size = New System.Drawing.Size(525, 382)
        Me.GroupBox12.TabIndex = 30
        Me.GroupBox12.TabStop = False
        Me.GroupBox12.Text = "İşlemler"
        '
        'textboxLokalRapor
        '
        Me.textboxLokalRapor.Location = New System.Drawing.Point(201, 41)
        Me.textboxLokalRapor.Multiline = True
        Me.textboxLokalRapor.Name = "textboxLokalRapor"
        Me.textboxLokalRapor.ReadOnly = True
        Me.textboxLokalRapor.Size = New System.Drawing.Size(318, 327)
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
        'GroupBox11
        '
        Me.GroupBox11.Controls.Add(Me.lblAmputasyon)
        Me.GroupBox11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GroupBox11.Location = New System.Drawing.Point(9, 149)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(229, 109)
        Me.GroupBox11.TabIndex = 26
        Me.GroupBox11.TabStop = False
        Me.GroupBox11.Text = "Üst Eks. Özürlülük Oranı"
        '
        'lblAmputasyon
        '
        Me.lblAmputasyon.AutoSize = True
        Me.lblAmputasyon.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblAmputasyon.Location = New System.Drawing.Point(28, 24)
        Me.lblAmputasyon.Name = "lblAmputasyon"
        Me.lblAmputasyon.Size = New System.Drawing.Size(68, 73)
        Me.lblAmputasyon.TabIndex = 0
        Me.lblAmputasyon.Text = "0"
        '
        'btnSaveExit
        '
        Me.btnSaveExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnSaveExit.Image = CType(resources.GetObject("btnSaveExit.Image"), System.Drawing.Image)
        Me.btnSaveExit.Location = New System.Drawing.Point(9, 94)
        Me.btnSaveExit.Name = "btnSaveExit"
        Me.btnSaveExit.Size = New System.Drawing.Size(177, 49)
        Me.btnSaveExit.TabIndex = 27
        Me.btnSaveExit.Text = "Kaydet ve Çık"
        Me.btnSaveExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSaveExit.UseVisualStyleBackColor = True
        '
        'Amputasyon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1188, 649)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox12)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblDescription)
        Me.Name = "Amputasyon"
        Me.Text = "Amputasyon"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox12.ResumeLayout(False)
        Me.GroupBox12.PerformLayout()
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox11.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblDescription As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox12 As GroupBox
    Friend WithEvents textboxLokalRapor As TextBox
    Friend WithEvents btnReset As Button
    Friend WithEvents GroupBox11 As GroupBox
    Friend WithEvents lblAmputasyon As Label
    Friend WithEvents btnSaveExit As Button
    Friend WithEvents rbD1MKDistali As RadioButton
    Friend WithEvents rbOmuzDezartikulasyon As RadioButton
    Friend WithEvents rbD1KMK As RadioButton
    Friend WithEvents rbD1HaricTumParmaklar As RadioButton
    Friend WithEvents rbElTümMKF As RadioButton
    Friend WithEvents rbOnKol As RadioButton
    Friend WithEvents rbDeltoidbicepsarasi As RadioButton
    Friend WithEvents rbDeltoidproksimali As RadioButton
End Class
