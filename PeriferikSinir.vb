Imports UpperExtremityModule.Universal



Public Class PeriferikSinir


    Dim intLokalPeriferikOrani As Integer

    Dim strPeriferikRaporLokal As String




    'Arrayların Tanımlanması

    Dim arrayAllLevels(,) As String = {
        {"C5", 5, 30},
        {"C6", 8, 35},
        {"C7", 5, 35},
        {"C8", 5, 45},
        {"T1", 5, 20},
        {"Brakiyel Pleksus (C5-T1)", 100, 100},
        {"Üst Trunkus (C5-6), Erb-Duchenne", 25, 75},
        {"Orta Trunkus (C7)", 5, 35},
        {"Alt Trunkus (C8,T1) Klumpke", 20, 70},
        {"Pektoral (medial ve lateral)", 0, 5},
        {"Aksiler ", 5, 35},
        {"Dorsal skapular ", 0, 5},
        {"Uzun torasik ", 0, 15},
        {"Medial antebrakial kutanöz ", 5, 0},
        {"Medial brakial kutanöz ", 5, 0},
        {"Median (ön kol proksimali) ", 39, 44},
        {"Median (anterior interosseöz dal) ", 0, 15},
        {"Median (ön kol distali)", 39, 10},
        {"Başparmağın radial palmar dalı", 7, 0},
        {"Başparmağın ulnar palmar dalı", 11, 0},
        {"II.parmak radial palmar dal", 5, 0},
        {"II.parmak ulnar palmar dal", 4, 0},
        {"III.parmak radial palmar dal", 5, 0},
        {"III.parmak ulnar palmar dal", 4, 0},
        {"IV.parmak radial palmar dal", 2, 0},
        {"Muskulokutanöz ", 5, 25},
        {"Radial (dirsek üstü, triceps kaybı) ", 5, 42},
        {"Radial (dirsek,triceps sağlam) ", 5, 35},
        {"Subskapularis(üst ve alt) ", 0, 5},
        {"Supraskapularis ", 5, 16},
        {"Torakodorsal ", 0, 10},
        {"Ulnar (ön kol proksimali) ", 7, 46},
        {"Ulnar (ön kol distali)", 7, 35},
        {"IV.parmak ulnar palmar dal", 2, 0},
        {"V.parmak radial palmar dal", 2, 0},
        {"V.parmak ulnar palmar dal", 3, 0}}

    'Raporlama ile ilgili Değişkenler

    Dim intDuyuSiddet As Integer
    Dim intMotorSiddet As Integer





    Sub updateMotorDuyu()

        GroupBox1.Enabled = True
        GroupBox2.Enabled = True

        Dim indexValue As Integer

        indexValue = listboxSinirler.SelectedIndex

        If arrayAllLevels(indexValue, 1) = 0 Then
            GroupBox1.Enabled = False

        End If

        If arrayAllLevels(indexValue, 2) = 0 Then
            GroupBox2.Enabled = False

        End If

    End Sub


    Private Function DuyuValue()
        If rbD5.Checked Then
            Return 0
        End If
        If rbD4.Checked Then
            Return 0.13
        End If
        If rbD3.Checked Then
            Return 0.43
        End If
        If rbD2.Checked Then
            Return 0.705
        End If
        If rbD1.Checked Then
            Return 0.9
        End If
        If rbD0.Checked Then
            Return 1
        End If

        Return 0
    End Function

    Private Function MotorValue()
        If rbM5.Checked Then
            Return 0
        End If
        If rbM4.Checked Then
            Return 0.13
        End If
        If rbM3.Checked Then
            Return 0.38
        End If
        If rbM2.Checked Then
            Return 0.63
        End If
        If rbM1.Checked Then
            Return 0.875
        End If
        If rbM0.Checked Then
            Return 1
        End If

        Return 0
    End Function


    Private Sub PeriferikSinir_Load() Handles MyBase.Load
        'Ekranın ortasına al ********************************************************
        Me.AutoSize = True
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        ' Get the current screen dimensions
        Dim screenWidth As Integer = Screen.PrimaryScreen.Bounds.Width
        Dim screenHeight As Integer = Screen.PrimaryScreen.Bounds.Height

        ' Calculate the coordinates for the top left corner of the form
        Dim x As Integer = (screenWidth - Me.Width) / 2
        Dim y As Integer = (screenHeight - Me.Height) / 2

        ' Set the location of the form
        Me.Location = New Point(x, y)
        '*********************************************************************************
        Dim count1 As Integer
        count1 = 0

        For count1 = 0 To arrayAllLevels.GetLength(0) - 1

            listboxSinirler.Items.Add(arrayAllLevels(count1, 0))
        Next



        listBoxOzet2.Items.Clear()
        listboxDuyu.Items.Clear()
        listBoxDuyuSiddet.Items.Clear()
        listboxMotor.Items.Clear()
        listBoxMotorSiddet.Items.Clear()

        GroupBox1.Enabled = True
        GroupBox2.Enabled = True

        strPeriferikRaporLokal = ""
        textboxLokalRapor.Text = strPeriferikRaporLokal

        intLokalPeriferikOrani = 0
        lblResult.Text = intLokalPeriferikOrani

    End Sub

    Private Sub listboxSinirler_Click(sender As Object, e As EventArgs) Handles listboxSinirler.Click
        Call updateMotorDuyu()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim intMotor As Integer
        Dim intDuyu As Integer
        Dim intCombinedResult As Integer

        Dim intSelection As Integer



        intSelection = listboxSinirler.SelectedIndex

        If intSelection >= 0 Then

            'Duyu hesaplama
            intDuyu = arrayAllLevels(intSelection, 1) * DuyuValue()



            'Motor hesaplama
            intMotor = arrayAllLevels(intSelection, 2) * MotorValue()



            intCombinedResult = Balthazard2Numbers(intDuyu, intMotor)


            listBoxOzet2.Items.Add(listboxSinirler.Items(intSelection) + " - " + "Duyu: " + Conversion.Str(intDuyu) + " " + "Motor: " + Conversion.Str(intMotor))
            listboxDuyu.Items.Add(intDuyu)
            listboxMotor.Items.Add(intMotor)
            listboxKombinePuanlar.Items.Add(intCombinedResult)

            intDuyuSiddet = DuyuSiddetHesaplama()
            intMotorSiddet = MotorSiddetHesaplama()
            listBoxDuyuSiddet.Items.Add(intDuyuSiddet)
            listBoxMotorSiddet.Items.Add(intMotorSiddet)

        End If
    End Sub

    Private Sub btnSaveandexit_Click(sender As Object, e As EventArgs)



    End Sub


    Private Function DuyuSiddetHesaplama()
        If rbD5.Checked Then
            Return 5
        End If
        If rbD4.Checked Then
            Return 4
        End If
        If rbD3.Checked Then
            Return 3
        End If
        If rbD2.Checked Then
            Return 2
        End If
        If rbD1.Checked Then
            Return 1
        End If
        If rbD0.Checked Then
            Return 0
        End If

        Return 5
    End Function

    Private Function MotorSiddetHesaplama()
        If rbM5.Checked Then
            Return 5
        End If
        If rbM4.Checked Then
            Return 4
        End If
        If rbM3.Checked Then
            Return 3
        End If
        If rbM2.Checked Then
            Return 2
        End If
        If rbM1.Checked Then
            Return 1
        End If
        If rbM0.Checked Then
            Return 0
        End If

        Return 5
    End Function



    '''''''RAPORLAMA''''''''''''''''''''''''''''

    Private Function PeriferikSinirRaporla(ByVal listboxLokalRaporOzeti As ListBox, ByVal listboxduyugrade As ListBox, ByVal listboxduyupuani As ListBox, ByVal listboxmotorgrade As ListBox, ByVal listboxmotorpuani As ListBox, ByVal listboxkombinepuan As ListBox)

        Dim Newline As String
        Newline = System.Environment.NewLine

        Dim strLokalRaporHeader As String
        strLokalRaporHeader = "*******************************" + Newline + "Spinal/Brakiyal Pleksus/Periferik Sinir Hasarına Bağlı Puanların Dökümü:" + Newline + Newline

        Dim strLokalRaporContent As String
        strLokalRaporContent = ""

        Dim strLokalSinir As String
        strLokalSinir = ""


        strPeriferikRaporLokal = ""
        'Listboxu tarayarak stringe çevir

        Dim count As Integer

        For count = 0 To listboxLokalRaporOzeti.Items.Count - 1

            Dim strTrimmedString As String


            strTrimmedString = listboxLokalRaporOzeti.Items(count)
            strTrimmedString = strTrimmedString.Substring(0, strTrimmedString.IndexOf("-")).Trim()


            strLokalSinir = "      " + strTrimmedString + Newline + "            " +
             "Duyu Fonksiyon " + Conversion.Str(listboxduyugrade.Items(count)) + "/5" + " sebebiyle " + Conversion.Str(listboxduyupuani.Items(count)) + Newline + "            " +
             "Motor Fonksiyon " + Conversion.Str(listboxmotorgrade.Items(count)) + "/5" + " sebebiyle " + Conversion.Str(listboxmotorpuani.Items(count)) + Newline + "            " +
              "Kombine Puan= " + Conversion.Str(listboxkombinepuan.Items(count)) + Newline

            strLokalRaporContent = strLokalRaporContent + strLokalSinir


            'TestString = TestString.Substring(0,TestString.IndexOf('-')).Trim()

        Next


        strPeriferikRaporLokal = strLokalRaporHeader + strLokalRaporContent

        textboxLokalRapor.Text = strPeriferikRaporLokal

        Return strPeriferikRaporLokal

    End Function



    Private Sub btnExitwithoutsave_Click(sender As Object, e As EventArgs)
        Anasayfa.Enabled = True
        Me.Close()
    End Sub

    Private Sub btnSaveExit_Click(sender As Object, e As EventArgs) Handles btnSaveExit.Click
        If leftside = True Then
            intPeriferikSinirFinalLeft = intLokalPeriferikOrani
            strPeriferikRaporFinalLeft = strPeriferikRaporLokal
        Else
            intPeriferikSinirFinalRight = intLokalPeriferikOrani
            strPeriferikRaporFinalRight = strPeriferikRaporLokal
        End If


        Me.Visible = False
        Me.Enabled = False
        Anasayfa.Enabled = True

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Form_Reset()

    End Sub

    Public Sub Form_Reset()
        PeriferikSinir_Load()
    End Sub
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

        Dim listFinal As New List(Of Integer)

        'Oran Hesapla
        intLokalPeriferikOrani = Calc(listboxKombinePuanlar, listFinal)

        lblResult.Text = intLokalPeriferikOrani

        'Raporla
        PeriferikSinirRaporla(listBoxOzet2, listBoxDuyuSiddet, listboxDuyu, listBoxMotorSiddet, listboxMotor, listboxKombinePuanlar)

        btnSaveExit.Enabled = True

    End Sub





    Private Sub button2_click(sender As Object, e As EventArgs) Handles btnRemove.Click


        Dim intremovalindex = listBoxOzet2.SelectedIndex

        If intremovalindex >= 0 Then
            listBoxOzet2.Items.RemoveAt(intremovalindex)
            listboxDuyu.Items.RemoveAt(intremovalindex)
            listboxMotor.Items.RemoveAt(intremovalindex)
            listboxKombinePuanlar.Items.RemoveAt(intremovalindex)
            listBoxDuyuSiddet.Items.RemoveAt(intremovalindex)
            listBoxMotorSiddet.Items.RemoveAt(intremovalindex)

        End If

    End Sub

    Private Sub listBoxOzet2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listBoxOzet2.SelectedIndexChanged

    End Sub

    Private Sub GroupBox12_Enter(sender As Object, e As EventArgs) Handles GroupBox12.Enter

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
    '///////////////////////işlemler



End Class