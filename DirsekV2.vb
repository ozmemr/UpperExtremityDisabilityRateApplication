Imports UpperExtremityModule.Universal


Public Class DirsekV2

    'Fleks Eks Puanları
    Dim intKf As Integer
    Dim intKe As Integer
    Dim intKfea As Integer

    Dim intFLEKSEKSANKKombine As Integer

    'Pro Sup Puanları
    Dim intKpro As Integer
    Dim intKsup As Integer
    Dim intKprosupa As Integer

    Dim intPROSUPANKKombine As Integer



    'Kombine Puanlar
    Dim intROMPuani As Integer
    Dim intLokalOzurlulukPuani As Integer



    Dim strLokalRapor As String
    Dim strDirsekLokal As String


    '*************************************************************************************************************************
    '**************************ARRAY TANIMLANMASI*****************************************************************************
    '*************************************************************************************************************************

    'Arrayların Tanımlanması
    'Fleksiyon Ekstansiyon Arrayları
    Dim arrayFleksEks(,) As String = {
        {140, 0, 0, 0, 140, 42},
        {130, 1, 10, 1, 130, 38},
        {120, 2, 20, 2, 120, 34},
        {110, 4, 30, 3, 110, 31},
        {100, 6, 40, 4, 100, 27},
        {90, 8, 50, 5, 90, 25},
        {80, 10, 60, 6, 80, 21},
        {70, 15, 70, 8, 70, 23},
        {60, 19, 80, 11, 60, 25},
        {50, 23, 90, 17, 50, 28},
        {40, 27, 100, 21, 40, 31},
        {30, 31, 110, 27, 30, 34},
        {20, 34, 120, 32, 20, 36},
        {10, 37, 130, 37, 10, 38},
        {0, 42, 140, 42, 0, 42}}




    '/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    'Pronasyon Supinasyon Arrayları

    Dim arrayProSup(,) As String = {
        {80, 0, 80, 0},
        {70, 1, 70, 0},
        {60, 1, 60, 1},
        {50, 2, 50, 1},
        {40, 3, 40, 2},
        {30, 3, 30, 2},
        {20, 4, 20, 3},
        {10, 8, 10, 3},
        {0, 2, 0, 3},
        {-10, 15, -10, 4},
        {-20, 19, -20, 4},
        {-30, 21, -30, 6},
        {-40, 22, -40, 8},
        {-50, 24, -50, 13},
        {-60, 25, -60, 18},
        {-70, 27, -70, 22},
        {-80, 28, -80, 28}}



    Dim arrayProSupAnkiloz(,) As String = {
        {0, 5, 0, 5},
        {10, 18, 10, 12},
        {20, 22, 20, 8},
        {30, 23, 30, 9},
        {40, 24, 40, 11},
        {50, 25, 50, 15},
        {60, 26, 60, 19},
        {70, 27, 70, 23},
        {80, 28, 80, 28}}




    Dim arrayDirsekEklemdeSislik(,) As String = {
       {"Yok (0)", 0, " Yok"},
       {"Hafif: gözle görülen (10)", 10, "Hafif şişlik"},
       {"Orta: elle palpe edilebilen (20)", 20, "Orta şişlik"},
       {"Ağır: eklem çevresinin %10'ndan fazla artışı (30)", 30, "Şiddetli şişlik"}}

    Dim arrayDirsekEklemdeSubluksasyon(,) As String = {
       {"Yok (0)", 0, " Yok"},
       {"Hafif: manuel tamamen redükte edilebilir (20)", 20, "Hafif subluksasyon"},
       {"Orta: manuel olarak kısmen redükte edilebilir (40)", 40, "Orta subluksasyon"},
       {"Ağır: redükte edilemez (60)", 60, "Ağır subluksasyon/dislokasyon"}}

    Dim arrayDirsekEklemdeInstabilite(,) As String = {
       {"Yok (0)", 0, " Yok"},
       {"Hafif: 10°den az (20)", 20, "Hafif instabilite"},
       {"Orta: 10-20° (40)", 40, "Orta instabilite"},
       {"Ağır: 20°den fazla (60)", 60, "Şiddetli instabilite"}}

    Dim arrayDirsekEklemdeDeviasyon(,) As String = {
       {"Yok (0)", 0, " Yok"},
       {"Hafif: 20°den az (10)", 10, "Hafif deviasyon"},
       {"Orta: 20-30° (20)", 20, "Orta deviasyon"},
       {"Ağır: 30°den fazla (30)", 30, "Şiddetli deviasyon"}}

    '*************************************************************************************************************************
    '**************************ARRAY TANIMLANMASI BITTI***********************************************************************
    '*************************************************************************************************************************

    Private Sub DirsekV2_Load() Handles MyBase.Load
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
        'Fleks - Eks
        intKf = 0
        intKe = 0
        intKfea = 0

        'Pro SUp bölümü
        intKpro = 0
        intKsup = 0
        intKprosupa = 0


        intFLEKSEKSANKKombine = 0
        intPROSUPANKKombine = 0

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

        EnableAndPopulateList(listboxDirsekFleks, arrayFleksEks, 0)
        EnableAndPopulateList(listboxDirsekEks, arrayFleksEks, 2)

        EnableAndPopulateList(listboxDirsekPro, arrayProSup, 0)
        EnableAndPopulateList(listboxDirsekSup, arrayProSup, 2)


        EnableAndPopulateList(listboxDirsekEklemdeSislik, arrayDirsekEklemdeSislik, 0)
        EnableAndPopulateList(listboxDirsekEklemdeInstabilite, arrayDirsekEklemdeInstabilite, 0)
        EnableAndPopulateList(listboxDirsekSubluksasyon, arrayDirsekEklemdeSubluksasyon, 0)
        EnableAndPopulateList(listboxDirsekDeviasyon, arrayDirsekEklemdeDeviasyon, 0)


        '*************************************************************************************************************************
        '**************************LISTE LOAD BITTI*******************************************************************************
        '*************************************************************************************************************************


        ''HOUSE KEEPING
        listboxDirsekFleks.SetSelected(0, True)
        listboxDirsekEks.SetSelected(0, True)
        listboxDirsekPro.SetSelected(0, True)
        listboxDirsekSup.SetSelected(0, True)

        listboxDirsekEklemdeSislik.SetSelected(0, True)
        listboxDirsekEklemdeInstabilite.SetSelected(0, True)
        listboxDirsekSubluksasyon.SetSelected(0, True)
        listboxDirsekDeviasyon.SetSelected(0, True)


        rbFleksEksAnkYok.Checked = True
        rbProSupAnkYok.Checked = True


        ProSupRadioButtonUpdate()
        FleksEksRadioButtonUpdate()


        lblResult.Text = intLokalOzurlulukPuani
        textboxLokalRapor.Text = ""


    End Sub


    '*************************************************************************************************************************
    '**************************RADIO BUTTON DONGUSU **************************************************************************
    '*************************************************************************************************************************

    'FLEKSIYON EKSTANSIYON ICIN DONGU



    Private Sub rbFEAnkYOK_CheckedChanged(sender As Object, e As EventArgs) Handles rbFleksEksAnkYok.CheckedChanged
        FleksEksRadioButtonUpdate()
    End Sub

    Private Sub rbFleksiyonAnkVar_CheckedChanged(sender As Object, e As EventArgs) Handles rbAnkVar.CheckedChanged
        FleksEksRadioButtonUpdate()
    End Sub

    Private Sub rbEkstansiyondaAnkilozVar_CheckedChanged(sender As Object, e As EventArgs)
        FleksEksRadioButtonUpdate()
    End Sub


    Private Sub FleksEksRadioButtonUpdate()
        'FLEKSIYON EKSTANSİYON ANKİLOZ UPDATE

        If rbFleksEksAnkYok.Checked Then

            DisableAndClearList(listboxDirsekFleksEksAnk)
            EnableAndPopulateList(listboxDirsekFleks, arrayFleksEks, 0)
            EnableAndPopulateList(listboxDirsekEks, arrayFleksEks, 2)

            listboxDirsekFleks.SetSelected(0, True)
            listboxDirsekEks.SetSelected(0, True)


            intKfea = 0

            lblDirsekKf.Text = updateDisabilityValue(listboxDirsekFleks, arrayFleksEks, 1)
            lblDirsekKe.Text = updateDisabilityValue(listboxDirsekEks, arrayFleksEks, 3)
            lblDirsekKfea.Text = intKfea

        End If

        If rbAnkVar.Checked Then

            DisableAndClearList(listboxDirsekFleks)
            DisableAndClearList(listboxDirsekEks)
            EnableAndPopulateList(listboxDirsekFleksEksAnk, arrayFleksEks, 4)

            intKf = 0
            intKe = 0
            intKfea = 0


            lblDirsekKf.Text = intKf
            lblDirsekKe.Text = intKe
            lblDirsekKfea.Text = intKfea


        End If


    End Sub


    'Pro Sup

    Private Sub rbRadUlAnkYok_CheckedChanged(sender As Object, e As EventArgs) Handles rbProSupAnkYok.CheckedChanged
        ProSupRadioButtonUpdate()
    End Sub

    Private Sub rbRadyalAnk_CheckedChanged(sender As Object, e As EventArgs) Handles rbProAnkVar.CheckedChanged
        ProSupRadioButtonUpdate()
    End Sub

    Private Sub rbUlnarAnk_CheckedChanged(sender As Object, e As EventArgs) Handles rbSupAnkVar.CheckedChanged
        ProSupRadioButtonUpdate()
    End Sub


    Private Sub ProSupRadioButtonUpdate()
        If rbProSupAnkYok.Checked Then


            DisableAndClearList(listboxDirsekProSupAnk)
            EnableAndPopulateList(listboxDirsekPro, arrayProSup, 0)
            EnableAndPopulateList(listboxDirsekSup, arrayProSup, 0)

            listboxDirsekPro.SetSelected(0, True)
            listboxDirsekSup.SetSelected(0, True)

            intKprosupa = 0

            lblDirsekKpro.Text = updateDisabilityValue(listboxDirsekPro, arrayProSup, 1)
            lblDirsekKsup.Text = updateDisabilityValue(listboxDirsekSup, arrayProSup, 3)
            lblDirsekKprosupa.Text = intKprosupa

        End If

        If rbProAnkVar.Checked Then

            DisableAndClearList(listboxDirsekPro)
            DisableAndClearList(listboxDirsekSup)
            EnableAndPopulateList(listboxDirsekProSupAnk, arrayProSupAnkiloz, 2)

            intKpro = 0
            intKsup = 0

            listboxDirsekProSupAnk.SetSelected(0, True)
            intKprosupa = updateDisabilityValue(listboxDirsekProSupAnk, arrayProSupAnkiloz, 3)

            lblDirsekKpro.Text = intKpro
            lblDirsekKsup.Text = intKsup
            lblDirsekKprosupa.Text = intKprosupa

        End If

        If rbSupAnkVar.Checked Then

            DisableAndClearList(listboxDirsekPro)
            DisableAndClearList(listboxDirsekSup)
            EnableAndPopulateList(listboxDirsekProSupAnk, arrayProSupAnkiloz, 0)

            intKpro = 0
            intKsup = 0

            listboxDirsekProSupAnk.SetSelected(0, True)
            intKprosupa = updateDisabilityValue(listboxDirsekProSupAnk, arrayProSupAnkiloz, 1)

            lblDirsekKpro.Text = intKpro
            lblDirsekKsup.Text = intKsup
            lblDirsekKprosupa.Text = intKprosupa

        End If
    End Sub




    '////////////////////////////////////////////////RADIOBUTTON DONGUSU BITTI//////////////////////////////////////////////


    '***************************************************LİSTE LABEL GÜNCELLEME************************************************

    'LİSTELERİN LABELLERİNİN GÜNCELLENMESİ

    'Fleksiyon Ekstansiyon Label Güncellemesi

    Private Sub listboxElBilegiFleks_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listboxDirsekFleks.SelectedIndexChanged
        Dim typeofROM As Integer
        typeofROM = 6
        If booleanThereIsError = False Then
            checkUserCorrectInput(listboxDirsekFleks, listboxDirsekEks, typeofROM)
        End If
        booleanThereIsError = False




        intKf = updateDisabilityValue(listboxDirsekFleks, arrayFleksEks, 1)

        lblDirsekKf.Text = intKf


    End Sub

    Private Sub listboxElBilegiEkstansiyon_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listboxDirsekEks.SelectedIndexChanged
        Dim typeofROM As Integer
        typeofROM = 6
        If booleanThereIsError = False Then
            checkUserCorrectInput(listboxDirsekFleks, listboxDirsekEks, typeofROM)
        End If
        booleanThereIsError = False



        intKe = updateDisabilityValue(listboxDirsekEks, arrayFleksEks, 3)

        lblDirsekKe.Text = intKe
    End Sub

    Private Sub listboxElBilegiFEAnkiloz_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listboxDirsekFleksEksAnk.SelectedIndexChanged

        If rbAnkVar.Checked Then
            intKfea = updateDisabilityValue(listboxDirsekFleksEksAnk, arrayFleksEks, 5)

        End If



        lblDirsekKfea.Text = intKfea

    End Sub

    'Abd Add Label Güncellemesi

    Private Sub listboxElBilegiRadyalDev_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listboxDirsekPro.SelectedIndexChanged
        Dim typeofROM As Integer
        typeofROM = 4
        If booleanThereIsError = False Then
            checkUserCorrectInput(listboxDirsekPro, listboxDirsekSup, typeofROM)
        End If
        booleanThereIsError = False




        intKpro = updateDisabilityValue(listboxDirsekPro, arrayProSup, 1)
        lblDirsekKpro.Text = intKpro

    End Sub

    Private Sub listboxElBilegiUlnarDev_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listboxDirsekSup.SelectedIndexChanged
        Dim typeofROM As Integer
        typeofROM = 4
        If booleanThereIsError = False Then
            checkUserCorrectInput(listboxDirsekPro, listboxDirsekSup, typeofROM)
        End If
        booleanThereIsError = False



        intKsup = updateDisabilityValue(listboxDirsekSup, arrayProSup, 3)
        lblDirsekKsup.Text = intKsup

    End Sub

    Private Sub listboxElBilegiRadyalAnkiloz_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listboxDirsekProSupAnk.SelectedIndexChanged

        If rbProAnkVar.Checked Then
            intKprosupa = updateDisabilityValue(listboxDirsekProSupAnk, arrayProSupAnkiloz, 3)

        End If

        If rbSupAnkVar.Checked Then
            intKprosupa = updateDisabilityValue(listboxDirsekProSupAnk, arrayProSupAnkiloz, 1)

        End If

        lblDirsekKprosupa.Text = intKprosupa

    End Sub






    '////////////////////////////////////////////////LİSTE LABEL GÜNCELLEMESİ BÖLÜMÜ BİTTİ//////////////////////////////////////////////


    '**************************İŞLEMLER BÖLÜMÜ********************************************************************************


    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        Form_Reset()





    End Sub

    Public Sub Form_Reset()
        DirsekV2_Load()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click




        'House keeping

        listboxFinalOzetList.Items.Clear()



        '******************************************ROMDAN GELEN TABLO 2.1***********************************
        'Fleksiyon-Ekstansiyon-Ankiloz Hesaplaması ve Raporlaması
        If rbFleksEksAnkYok.Checked Then

            intFLEKSEKSANKKombine = intKf + intKe

        End If

        If rbAnkVar.Checked Then

            intFLEKSEKSANKKombine = intKfea

        End If

        'Abdüksiyon Addüksiyon Deviasyon - Ankiloz Hesaplaması ve Raporlaması

        If rbProSupAnkYok.Checked Then

            intPROSUPANKKombine = intKpro + intKsup

        End If

        If rbProAnkVar.Checked Or rbSupAnkVar.Checked Then

            intPROSUPANKKombine = intKprosupa

        End If


        '//////////////////////////////////////////////////////////////////////////////////////////////////////


        intROMPuani = intFLEKSEKSANKKombine + intPROSUPANKKombine


        Raporla()

        Dim listFinalOzet As New List(Of Integer)

        intLokalOzurlulukPuani = Calc(listboxFinalOzetList, listFinalOzet)

        lblResult.Text = intLokalOzurlulukPuani





        '//////////////////////////////////////////////////////////////////////////////////////////////////////
    End Sub

    Private Sub Raporla()


        Dim Newline As String
        Newline = System.Environment.NewLine
        strLokalRapor = "***Dirsek*** " + Newline



        'Pozitif sonuçların taranması

        If intROMPuani <> 0 Then
            listboxFinalOzetList.Items.Add(intROMPuani)
            strLokalRapor = strLokalRapor + "          Eklem hareketinden " + Conversion.Str(intROMPuani) + Newline

        End If


        If listboxDirsekEklemdeSislik.SelectedIndex <> 0 Then


            listboxFinalOzetList.Items.Add(arrayDirsekEklemdeSislik(listboxDirsekEklemdeSislik.SelectedIndex, 1))
            strLokalRapor = strLokalRapor + "          " + "Şişlik nedeniyle" + Conversion.Str(arrayDirsekEklemdeSislik(listboxDirsekEklemdeSislik.SelectedIndex, 1)) + Newline


        End If

        If listboxDirsekEklemdeInstabilite.SelectedIndex <> 0 Then


            listboxFinalOzetList.Items.Add(arrayDirsekEklemdeInstabilite(listboxDirsekEklemdeInstabilite.SelectedIndex, 1))
            strLokalRapor = strLokalRapor + "          " + "İnstabilite nedeniyle" + Conversion.Str(arrayDirsekEklemdeInstabilite(listboxDirsekEklemdeInstabilite.SelectedIndex, 1)) + Newline


        End If

        If listboxDirsekSubluksasyon.SelectedIndex <> 0 Then


            listboxFinalOzetList.Items.Add(arrayDirsekEklemdeSubluksasyon(listboxDirsekSubluksasyon.SelectedIndex, 1))
            strLokalRapor = strLokalRapor + "          " + "Subluksasyon nedeniyle" + Conversion.Str(arrayDirsekEklemdeSubluksasyon(listboxDirsekSubluksasyon.SelectedIndex, 1)) + Newline


        End If
        If listboxDirsekDeviasyon.SelectedIndex <> 0 Then


            listboxFinalOzetList.Items.Add(arrayDirsekEklemdeDeviasyon(listboxDirsekDeviasyon.SelectedIndex, 1))
            strLokalRapor = strLokalRapor + "          " + "Deviasyon nedeniyle" + Conversion.Str(arrayDirsekEklemdeDeviasyon(listboxDirsekDeviasyon.SelectedIndex, 1)) + Newline


        End If

        textboxLokalRapor.Text = strLokalRapor
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Anasayfa.Enabled = True
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnSaveExit.Click
        If leftside = True Then
            intDirsekFinalLeft = intLokalOzurlulukPuani
            strDirsekRaporFinalLeft = strLokalRapor
        Else
            intDirsekFinalRight = intLokalOzurlulukPuani
            strDirsekRaporFinalRight = strLokalRapor
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

    Private Sub GroupBox12_Enter(sender As Object, e As EventArgs) Handles GroupBox12.Enter

    End Sub





    '/////////////////////////////////////////İŞLEMLER BÖLÜMÜ BİTTİ//////////////////////////////////////////////////////////////////////////



    '////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
End Class