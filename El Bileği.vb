Imports UpperExtremityModule.Universal



Public Class ElBilegi


    Dim intKf As Integer
    Dim intKe As Integer
    Dim intKfea As Integer

    'Radyal ulnar deviasyon bölümü
    Dim intKrd As Integer
    Dim intKud As Integer
    Dim intKrduda As Integer

    Dim intFLEKSEKSANKKombine As Integer
    Dim intRADULNDEVANKKombine As Integer
    Dim intROMPuani As Integer


    Dim intLokalOzurlulukPuani As Integer



    Dim strLokalRapor As String
    Dim strElBilegiLokal As String


    '*************************************************************************************************************************
    '**************************ARRAY TANIMLANMASI*****************************************************************************
    '*************************************************************************************************************************

    'Arrayların Tanımlanması
    'Fleksiyon Ekstansiyon Arrayları
    Dim arrayFleksEks(,) As String = {
        {60, 0, 60, 0},
        {50, 2, 50, 2},
        {40, 3, 40, 4},
        {30, 5, 30, 5},
        {20, 7, 20, 7},
        {10, 8, 10, 8},
        {0, 10, 0, 11},
        {-10, 13, -10, 13},
        {-20, 17, -20, 18},
        {-30, 21, -30, 24},
        {-40, 25, -40, 30},
        {-50, 34, -50, 36},
        {-60, 42, -60, 42}}

    Dim arrayFleksEksAnkilozu(,) As String = {
        {0, 21, 21},
        {10, 21, 21},
        {20, 24, 25},
        {30, 26, 29},
        {40, 29, 33},
        {50, 36, 38},
        {60, 42, 42}}

    'Radyal UlnarDeviasyon Arrayları

    Dim arrayRadyalUlnarDev(,) As String = {
        {20, 0, 30, 0},
        {15, 1, 25, 1},
        {10, 2, 20, 2},
        {5, 3, 15, 3},
        {0, 4, 10, 4},
        {-5, 5, 5, 4},
        {-10, 5, 0, 5},
        {-15, 9, -5, 9},
        {-20, 12, -10, 12},
        {-25, 15, -15, 15},
        {-30, 18, -20, 18}}

    Dim arrayRadyalAnkiloz(,) As String = {
        {0, 9},
        {5, 12},
        {10, 14},
        {15, 16},
        {20, 18}}

    Dim arrayUlnarAnkiloz(,) As String = {
        {0, 9},
        {5, 9},
        {10, 9},
        {15, 12},
        {20, 14},
        {25, 16},
        {30, 18}}

    Dim arrayElBilegiEklemdeSislik(,) As String = {
       {"Yok (0)", 0, " Yok"},
       {"Hafif: gözle görülen (10)", 10, "Hafif şişlik"},
       {"Orta: elle palpe edilebilen (20)", 20, "Orta şişlik"},
       {"Ağır: eklem çevresinin %10'ndan fazla artışı (30)", 30, "Şiddetli şişlik"}}

    Dim arrayElBilegiEklemdeSubluksasyon(,) As String = {
       {"Yok (0)", 0, " Yok"},
       {"Hafif: manuel tamamen redükte edilebilir (20)", 20, "Hafif subluksasyon"},
       {"Orta: manuel olarak kısmen redükte edilebilir (40)", 40, "Orta subluksasyon"},
       {"Ağır: redükte edilemez (60)", 60, "Ağır subluksasyon/dislokasyon"}}

    Dim arrayElBilegiEklemdeInstabilite(,) As String = {
       {"Yok (0)", 0, " Yok"},
       {"Hafif: 10°den az (20)", 20, "Hafif instabilite"},
       {"Orta: 10-20° (40)", 40, "Orta instabilite"},
       {"Ağır: 20°den fazla (60)", 60, "Şiddetli instabilite"}}

    Dim arrayElBilegiEklemdeDeviasyon(,) As String = {
       {"Yok (0)", 0, " Yok"},
       {"Hafif: 20°den az (10)", 10, "Hafif deviasyon"},
       {"Orta: 20-30° (20)", 20, "Orta deviasyon"},
       {"Ağır: 30°den fazla (30)", 30, "Şiddetli deviasyon"}}

    '*************************************************************************************************************************
    '**************************ARRAY TANIMLANMASI BITTI***********************************************************************
    '*************************************************************************************************************************

    Private Sub ElBilegi_Load() Handles MyBase.Load
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
        ' ***********'Degiskenlerin resetlenmesi****************************************************

        intKf = 0
        intKe = 0
        intKfea = 0

        'Radyal ulnar deviasyon bölümü
        intKrd = 0
        intKud = 0
        intKrduda = 0

        intFLEKSEKSANKKombine = 0
        intRADULNDEVANKKombine = 0
        intROMPuani = 0

        intLokalOzurlulukPuani = 0

        strLokalRapor = ""
        strFinalOzetRapor = ""


        '/////////////////////////////////RESET COMPLETE


        Dim Newline As String
        Newline = System.Environment.NewLine

        '*************************************************************************************************************************
        '**************************LISTE LOAD*************************************************************************************
        '*************************************************************************************************************************
        'Arrayların Listeler Halinde Görüntülenmesi

        EnableAndPopulateList(listboxElBilegiFleks, arrayFleksEks, 0)
        EnableAndPopulateList(listboxElBilegiEkstansiyon, arrayFleksEks, 2)

        EnableAndPopulateList(listboxElBilegiRadyalDev, arrayRadyalUlnarDev, 0)
        EnableAndPopulateList(listboxElBilegiUlnarDev, arrayRadyalUlnarDev, 2)




        EnableAndPopulateList(listboxElBilegiEklemdeSislik, arrayElBilegiEklemdeSislik, 0)
        EnableAndPopulateList(listboxElBilegiEklemdeInstabilite, arrayElBilegiEklemdeInstabilite, 0)
        EnableAndPopulateList(listboxElBilegiSubluksasyon, arrayElBilegiEklemdeSubluksasyon, 0)
        EnableAndPopulateList(listboxElBilegiDeviasyon, arrayElBilegiEklemdeDeviasyon, 0)


        '*************************************************************************************************************************
        '**************************LISTE LOAD BITTI*******************************************************************************
        '*************************************************************************************************************************


        ''HOUSE KEEPING
        listboxElBilegiFleks.SetSelected(0, True)
        listboxElBilegiEkstansiyon.SetSelected(0, True)
        listboxElBilegiRadyalDev.SetSelected(0, True)
        listboxElBilegiUlnarDev.SetSelected(0, True)

        listboxElBilegiEklemdeSislik.SetSelected(0, True)
        listboxElBilegiEklemdeInstabilite.SetSelected(0, True)
        listboxElBilegiSubluksasyon.SetSelected(0, True)
        listboxElBilegiDeviasyon.SetSelected(0, True)


        rbFEAnkYOK.Checked = True
        rbRadUlAnkYok.Checked = True


        RadUlnRadioButtonUpdate()
        FleksEksRadioButtonUpdate()

        lblResult.Text = intLokalOzurlulukPuani
        textboxLokalRapor.Text = ""


    End Sub


    '*************************************************************************************************************************
    '**************************RADIO BUTTON DONGUSU **************************************************************************
    '*************************************************************************************************************************

    'FLEKSIYON EKSTANSIYON ICIN DONGU



    Private Sub rbFEAnkYOK_CheckedChanged(sender As Object, e As EventArgs) Handles rbFEAnkYOK.CheckedChanged
        FleksEksRadioButtonUpdate()
    End Sub

    Private Sub rbFleksiyonAnkVar_CheckedChanged(sender As Object, e As EventArgs) Handles rbFleksiyonAnkVar.CheckedChanged
        FleksEksRadioButtonUpdate()
    End Sub

    Private Sub rbEkstansiyondaAnkilozVar_CheckedChanged(sender As Object, e As EventArgs) Handles rbEkstansiyondaAnkilozVar.CheckedChanged
        FleksEksRadioButtonUpdate()
    End Sub


    Private Sub FleksEksRadioButtonUpdate()
        'FLEKSIYON EKSTANSİYON ANKİLOZ UPDATE

        If rbFEAnkYOK.Checked Then

            DisableAndClearList(listboxElBilegiFEAnkiloz)
            EnableAndPopulateList(listboxElBilegiFleks, arrayFleksEks, 0)
            EnableAndPopulateList(listboxElBilegiEkstansiyon, arrayFleksEks, 2)

            listboxElBilegiFleks.SetSelected(0, True)
            listboxElBilegiEkstansiyon.SetSelected(0, True)


            intKfea = 0

            lblElBilegiKf.Text = updateDisabilityValue(listboxElBilegiFleks, arrayFleksEks, 1)
            lblElBilegiKe.Text = updateDisabilityValue(listboxElBilegiEkstansiyon, arrayFleksEks, 3)
            lblElBilegiKfea.Text = intKfea

        End If

        If rbFleksiyonAnkVar.Checked Then

            DisableAndClearList(listboxElBilegiFleks)
            DisableAndClearList(listboxElBilegiEkstansiyon)
            EnableAndPopulateList(listboxElBilegiFEAnkiloz, arrayFleksEksAnkilozu, 0)

            intKf = 0
            intKe = 0


            listboxElBilegiFEAnkiloz.SetSelected(0, True)
            intKfea = updateDisabilityValue(listboxElBilegiFEAnkiloz, arrayFleksEksAnkilozu, 2)


            lblElBilegiKf.Text = intKf
            lblElBilegiKe.Text = intKe
            lblElBilegiKfea.Text = intKfea


        End If

        If rbEkstansiyondaAnkilozVar.Checked Then

            DisableAndClearList(listboxElBilegiFleks)
            DisableAndClearList(listboxElBilegiEkstansiyon)
            EnableAndPopulateList(listboxElBilegiFEAnkiloz, arrayFleksEksAnkilozu, 0)

            intKf = 0
            intKe = 0


            listboxElBilegiFEAnkiloz.SetSelected(0, True)
            intKfea = updateDisabilityValue(listboxElBilegiFEAnkiloz, arrayFleksEksAnkilozu, 1)


            lblElBilegiKf.Text = intKf
            lblElBilegiKe.Text = intKe
            lblElBilegiKfea.Text = intKfea


        End If
    End Sub


    'RADYAL ULNAR ICIN DONGU

    Private Sub rbRadUlAnkYok_CheckedChanged(sender As Object, e As EventArgs) Handles rbRadUlAnkYok.CheckedChanged
        RadUlnRadioButtonUpdate()
    End Sub

    Private Sub rbRadyalAnk_CheckedChanged(sender As Object, e As EventArgs) Handles rbRadyalAnk.CheckedChanged
        RadUlnRadioButtonUpdate()
    End Sub

    Private Sub rbUlnarAnk_CheckedChanged(sender As Object, e As EventArgs) Handles rbUlnarAnk.CheckedChanged
        RadUlnRadioButtonUpdate()
    End Sub


    Private Sub RadUlnRadioButtonUpdate()
        If rbRadUlAnkYok.Checked Then


            DisableAndClearList(listboxElBilegiRadyalAnkiloz)
            EnableAndPopulateList(listboxElBilegiRadyalDev, arrayRadyalUlnarDev, 0)
            EnableAndPopulateList(listboxElBilegiUlnarDev, arrayRadyalUlnarDev, 2)

            listboxElBilegiRadyalDev.SetSelected(0, True)
            listboxElBilegiUlnarDev.SetSelected(0, True)

            intKrduda = 0

            lblElBilegiKrd.Text = updateDisabilityValue(listboxElBilegiRadyalDev, arrayRadyalUlnarDev, 1)
            lblElBilegiKud.Text = updateDisabilityValue(listboxElBilegiUlnarDev, arrayRadyalUlnarDev, 3)
            lblElBilegiKrduda.Text = intKrduda

        End If

        If rbRadyalAnk.Checked Then

            DisableAndClearList(listboxElBilegiRadyalDev)
            DisableAndClearList(listboxElBilegiUlnarDev)
            EnableAndPopulateList(listboxElBilegiRadyalAnkiloz, arrayRadyalAnkiloz, 0)

            intKrd = 0
            intKud = 0

            listboxElBilegiRadyalAnkiloz.SetSelected(0, True)
            intKrduda = updateDisabilityValue(listboxElBilegiRadyalAnkiloz, arrayRadyalAnkiloz, 1)


            lblElBilegiKrd.Text = intKrd
            lblElBilegiKud.Text = intKud
            lblElBilegiKrduda.Text = intKrduda

        End If

        If rbUlnarAnk.Checked Then

            DisableAndClearList(listboxElBilegiRadyalDev)
            DisableAndClearList(listboxElBilegiUlnarDev)
            EnableAndPopulateList(listboxElBilegiRadyalAnkiloz, arrayUlnarAnkiloz, 0)

            intKrd = 0
            intKud = 0

            listboxElBilegiRadyalAnkiloz.SetSelected(0, True)
            intKrduda = updateDisabilityValue(listboxElBilegiRadyalAnkiloz, arrayUlnarAnkiloz, 1)

            lblElBilegiKrd.Text = intKrd
            lblElBilegiKud.Text = intKud
            lblElBilegiKrduda.Text = intKrduda

        End If
    End Sub





    '////////////////////////////////////////////////RADIOBUTTON DONGUSU BITTI//////////////////////////////////////////////


    '***************************************************LİSTE LABEL GÜNCELLEME************************************************

    'LİSTELERİN LABELLERİNİN GÜNCELLENMESİ

    'Fleksiyon Ekstansiyon Label Güncellemesi

    Private Sub listboxElBilegiFleks_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listboxElBilegiFleks.SelectedIndexChanged
        Dim typeofROM As Integer
        typeofROM = 1

        If booleanThereIsError = False Then
            checkUserCorrectInput(listboxElBilegiFleks, listboxElBilegiEkstansiyon, typeofROM)
        End If
        booleanThereIsError = False



        intKf = updateDisabilityValue(listboxElBilegiFleks, arrayFleksEks, 1)

        lblElBilegiKf.Text = intKf


    End Sub

    Private Sub listboxElBilegiEkstansiyon_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listboxElBilegiEkstansiyon.SelectedIndexChanged
        Dim typeofROM As Integer
        typeofROM = 1

        If booleanThereIsError = False Then
            checkUserCorrectInput(listboxElBilegiFleks, listboxElBilegiEkstansiyon, typeofROM)
        End If
        booleanThereIsError = False


        intKe = updateDisabilityValue(listboxElBilegiEkstansiyon, arrayFleksEks, 3)

        lblElBilegiKe.Text = intKe
    End Sub

    Private Sub listboxElBilegiFEAnkiloz_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listboxElBilegiFEAnkiloz.SelectedIndexChanged

        If rbFleksiyonAnkVar.Checked Then
            intKfea = updateDisabilityValue(listboxElBilegiFEAnkiloz, arrayFleksEksAnkilozu, 2)

        End If

        If rbEkstansiyondaAnkilozVar.Checked Then
            intKfea = updateDisabilityValue(listboxElBilegiFEAnkiloz, arrayFleksEksAnkilozu, 1)

        End If

        lblElBilegiKfea.Text = intKfea

    End Sub

    'Radyal Ulnar Label Güncellemesi

    Private Sub listboxElBilegiRadyalDev_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listboxElBilegiRadyalDev.SelectedIndexChanged
        Dim typeofROM As Integer
        typeofROM = 5

        If booleanThereIsError = False Then
            checkUserCorrectInput(listboxElBilegiRadyalDev, listboxElBilegiUlnarDev, typeofROM)

        End If
        booleanThereIsError = False

        intKrd = updateDisabilityValue(listboxElBilegiRadyalDev, arrayRadyalUlnarDev, 1)
        lblElBilegiKrd.Text = intKrd

    End Sub

    Private Sub listboxElBilegiUlnarDev_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listboxElBilegiUlnarDev.SelectedIndexChanged
        Dim typeofROM As Integer
        typeofROM = 5

        If booleanThereIsError = False Then
            checkUserCorrectInput(listboxElBilegiRadyalDev, listboxElBilegiUlnarDev, typeofROM)
        End If
        booleanThereIsError = False


        intKud = updateDisabilityValue(listboxElBilegiUlnarDev, arrayRadyalUlnarDev, 3)
        lblElBilegiKud.Text = intKud

    End Sub

    Private Sub listboxElBilegiRadyalAnkiloz_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listboxElBilegiRadyalAnkiloz.SelectedIndexChanged

        If rbRadyalAnk.Checked Then
            intKrduda = updateDisabilityValue(listboxElBilegiRadyalAnkiloz, arrayRadyalAnkiloz, 1)

        End If

        If rbUlnarAnk.Checked Then
            intKrduda = updateDisabilityValue(listboxElBilegiRadyalAnkiloz, arrayUlnarAnkiloz, 1)

        End If

        lblElBilegiKrduda.Text = intKrduda

    End Sub



    '////////////////////////////////////////////////LİSTE LABEL GÜNCELLEMESİ BÖLÜMÜ BİTTİ//////////////////////////////////////////////


    '**************************İŞLEMLER BÖLÜMÜ********************************************************************************


    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        Form_Reset()





    End Sub

    Public Sub Form_Reset()
        ElBilegi_Load()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click




        'House keeping

        listboxFinalOzetList.Items.Clear()



        '******************************************ROMDAN GELEN TABLO 2.1***********************************
        'Fleksiyon-Ekstansiyon-Ankiloz Hesaplaması ve Raporlaması
        If rbFEAnkYOK.Checked Then
            intFLEKSEKSANKKombine = intKf + intKe
        End If

        If rbFleksiyonAnkVar.Checked Or rbEkstansiyondaAnkilozVar.Checked Then
            intFLEKSEKSANKKombine = intKfea
        End If

        'Radyal Ulnar Deviasyon - Ankiloz Hesaplaması ve Raporlaması

        If rbRadUlAnkYok.Checked Then

            intRADULNDEVANKKombine = intKrd + intKud

        End If

        If rbRadyalAnk.Checked Or rbUlnarAnk.Checked Then

            intRADULNDEVANKKombine = intKrduda

        End If

        intROMPuani = intFLEKSEKSANKKombine + intRADULNDEVANKKombine
        '//////////////////////////////////////////////////////////////////////////////////////////////////////





        Raporla()

        Dim listFinalOzet As New List(Of Integer)

        intLokalOzurlulukPuani = Calc(listboxFinalOzetList, listFinalOzet)

        lblResult.Text = intLokalOzurlulukPuani



        '//////////////////////////////////////////////////////////////////////////////////////////////////////
    End Sub

    Private Sub Raporla()


        Dim Newline As String
        Newline = System.Environment.NewLine
        strLokalRapor = "***El Bileği*** " + Newline



        'Pozitif sonuçların taranması

        If intROMPuani <> 0 Then
            listboxFinalOzetList.Items.Add(intROMPuani)
            strLokalRapor = strLokalRapor + "          Eklem hareketinden " + Conversion.Str(intROMPuani) + Newline

        End If


        If listboxElBilegiEklemdeSislik.SelectedIndex <> 0 Then


            listboxFinalOzetList.Items.Add(arrayElBilegiEklemdeSislik(listboxElBilegiEklemdeSislik.SelectedIndex, 1))
            strLokalRapor = strLokalRapor + "          " + "Şişlik nedeniyle" + Conversion.Str(arrayElBilegiEklemdeSislik(listboxElBilegiEklemdeSislik.SelectedIndex, 1)) + Newline


        End If

        If listboxElBilegiEklemdeInstabilite.SelectedIndex <> 0 Then


            listboxFinalOzetList.Items.Add(arrayElBilegiEklemdeInstabilite(listboxElBilegiEklemdeInstabilite.SelectedIndex, 1))
            strLokalRapor = strLokalRapor + "          " + "İnstabilite nedeniyle" + Conversion.Str(arrayElBilegiEklemdeInstabilite(listboxElBilegiEklemdeInstabilite.SelectedIndex, 1)) + Newline


        End If

        If listboxElBilegiSubluksasyon.SelectedIndex <> 0 Then


            listboxFinalOzetList.Items.Add(arrayElBilegiEklemdeSubluksasyon(listboxElBilegiSubluksasyon.SelectedIndex, 1))
            strLokalRapor = strLokalRapor + "          " + "Subluksasyon nedeniyle" + Conversion.Str(arrayElBilegiEklemdeSubluksasyon(listboxElBilegiSubluksasyon.SelectedIndex, 1)) + Newline


        End If
        If listboxElBilegiDeviasyon.SelectedIndex <> 0 Then


            listboxFinalOzetList.Items.Add(arrayElBilegiEklemdeDeviasyon(listboxElBilegiDeviasyon.SelectedIndex, 1))
            strLokalRapor = strLokalRapor + "          " + "Deviasyon nedeniyle" + Conversion.Str(arrayElBilegiEklemdeDeviasyon(listboxElBilegiDeviasyon.SelectedIndex, 1)) + Newline


        End If

        textboxLokalRapor.Text = strLokalRapor
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Anasayfa.Enabled = True
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnSaveExit.Click
        If leftside = True Then
            intElBilegiFinalLeft = intLokalOzurlulukPuani
            strElBilegiRaporFinalLeft = strLokalRapor
        Else
            intElBilegiFinalRight = intLokalOzurlulukPuani
            strElBilegiRaporFinalRight = strLokalRapor
        End If


        Me.Visible = False
        Me.Enabled = False

        Anasayfa.Enabled = True


    End Sub


    Private Function updateDisabilityValue(ByVal listboxMe As ListBox, ByVal arrayMe As Array, ByVal intColumn As Integer)
        Dim intIndex As Integer
        intIndex = listboxMe.SelectedIndex

        Dim intResult As Integer

        intResult = arrayMe(intIndex, intColumn)

        Return intResult

    End Function


    '/////////////////////////////////////////İŞLEMLER BÖLÜMÜ BİTTİ//////////////////////////////////////////////////////////////////////////

    'Private Function ElBilegiRaporlama()
    '    '*******************************************************RAPORLAMA BÖLÜMÜ************************************************************************************
    '    Dim Newline As String
    '    Newline = System.Environment.NewLine

    '    Dim strLokalRaporHeader As String
    '    strLokalRaporHeader = "*******************************" + Newline + "2.1 Eklem hareket açıklığı ve 2.3 Diğer Eklem sorunlarından gelen özür puanları:" + Newline + Newline

    '    Dim strLokalRaporContent As String
    '    strLokalRaporContent = ""

    '    Dim strLokalSinir As String
    '    strLokalSinir = ""

    '    Dim strLokalRaporFinal As String
    '    strLokalRaporFinal = ""


    '    'Listboxu tarayarak stringe çevir

    '    Dim count As Integer

    '    For count = 0 To listboxLokalRaporOzeti.Items.Count - 1

    '        strLokalSinir = "      " + listboxLokalRaporOzeti.Items(count) + Newline + "            " +
    '        "Duyu Fonksiyon " + Conversion.Str(listboxduyugrade.Items(count)) + "/5" + " sebebiyle " + Conversion.Str(listboxduyupuani.Items(count)) + Newline + "            " +
    '        "Motor Fonksiyon " + Conversion.Str(listboxmotorgrade.Items(count)) + "/5" + " sebebiyle " + Conversion.Str(listboxmotorpuani.Items(count)) + Newline + "            " +
    '        "Kombine Puan= " + Conversion.Str(listboxkombinepuan.Items(count)) + Newline

    '        strLokalRaporContent = strLokalRaporContent + strLokalSinir




    '    Next


    '    strLokalRaporFinal = strLokalRaporHeader + strLokalRaporContent

    '    MessageBox.Show(strLokalRaporFinal)

    '    Return strLokalRaporFinal

    'End Function

    '////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
End Class