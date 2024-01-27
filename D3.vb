Imports UpperExtremityModule.Universal

Public Class D3

    'DIF Puanları
    Dim intDifKf As Integer
    Dim intDifKe As Integer
    Dim intDifKfea As Integer

    Dim intDifFleksEksKombine As Integer

    'PIF Puanları
    Dim intPifKf As Integer
    Dim intPifKe As Integer
    Dim intPifKfea As Integer

    Dim intPifFleksEksKombine As Integer

    'MKF Puanları
    Dim intMkfKf As Integer
    Dim intMkfKfe As Integer
    Dim intMkfKfea As Integer

    Dim intMkfFleksEksKombine As Integer

    'Kombine Puanlar
    Dim intDIFROMPuani As Integer
    Dim intPIFROMPuani As Integer
    Dim intMKFROMPuani As Integer

    Dim intAmputasyonSkoru As Integer

    Dim intLokalOzurlulukPuani As Integer


    Dim strParmakDIF As String
    Dim strParmakPIF As String
    Dim strParmakMKF As String
    Dim strParmakAmputasyon As String
    Dim strParmakSorunları As String


    Dim strParmakLokalRapor As String


    '*************************************************************************************************************************
    '**************************ARRAY TANIMLANMASI*****************************************************************************
    '*************************************************************************************************************************

    'Arrayların Tanımlanması
    'Fleksiyon Ekstansiyon Arrayları
    Dim arrayDifFleksEks(,) As String = {
        {70, 0, 30, 0},
        {60, 5, 20, 0},
        {50, 10, 10, 0},
        {40, 15, 0, 0},
        {30, 21, -10, 2},
        {20, 26, -20, 4},
        {10, 31, -30, 12},
        {0, 36, -40, 20},
        {-10, 39, -50, 29},
        {-20, 42, -60, 37},
        {-30, 45, -70, 45}}

    Dim arrayDifFleksAnkilozu(,) As String = {
        {70, 45},
        {60, 42},
        {50, 39},
        {40, 35},
        {30, 33},
        {20, 30},
        {10, 33},
        {0, 36}}


    Dim arrayDifEksAnkilozu(,) As String = {
        {30, 45},
        {20, 42},
        {10, 39}}

    '/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    'PIF FLeks Ekstansiyon Arraylari

    Dim arrayPifFleksEks(,) As String = {
        {100, 0, 30, 0},
        {90, 6, 20, 0},
        {80, 12, 10, 0},
        {70, 18, 0, 0},
        {60, 24, -10, 3},
        {50, 30, -20, 7},
        {40, 36, -30, 11},
        {30, 42, -40, 14},
        {20, 48, -50, 25},
        {10, 54, -60, 36},
        {0, 60, -70, 47},
        {-10, 66, -80, 58},
        {-20, 73, -90, 69},
        {-30, 80, -100, 80}}


    Dim arrayPifFleksAnk(,) As String = {
        {100, 80},
        {90, 75},
        {80, 70},
        {70, 65},
        {60, 60},
        {50, 55},
        {40, 50},
        {30, 53},
        {20, 55},
        {10, 57},
        {0, 60}}

    Dim arrayPifEksAnk(,) As String = {
        {30, 80},
        {20, 73},
        {10, 66}}

    '*********************MKF Fleks Eks Arrayleri

    Dim arrayMkfFleksEks(,) As String = {
        {90, 0, 20, 0},
        {80, 6, 10, 3},
        {70, 11, 0, 5},
        {60, 17, -10, 7},
        {50, 22, -20, 10},
        {40, 27, -30, 12},
        {30, 33, -40, 27},
        {20, 38, -50, 41},
        {10, 44, -60, 56},
        {0, 49, -70, 71},
        {-10, 54, -80, 85},
        {-20, 60, -90, 100}}


    Dim arrayMkfFleksAnk(,) As String = {
        {90, 100},
        {80, 91},
        {70, 82},
        {60, 73},
        {50, 63},
        {40, 54},
        {30, 45},
        {20, 48},
        {10, 51},
        {0, 54}}


    Dim arrayMkfEksAnk(,) As String = {
        {20, 60},
        {10, 57}}






    Dim arrayEklemdeSislik(,) As String = {
       {"Yok (0)", 0, " Yok"},
       {"Hafif: gözle görülen (10)", 10, "Hafif şişlik"},
       {"Orta: elle palpe edilebilen (20)", 20, "Orta şişlik"},
       {"Ağır: eklem çevresinin %10'ndan fazla artışı (30)", 30, "Şiddetli şişlik"}}

    Dim arrayEklemdeSubluksasyon(,) As String = {
       {"Yok (0)", 0, " Yok"},
       {"Hafif: manuel tamamen redükte edilebilir (20)", 20, "Hafif subluksasyon"},
       {"Orta: manuel olarak kısmen redükte edilebilir (40)", 40, "Orta subluksasyon"},
       {"Ağır: redükte edilemez (60)", 60, "Ağır subluksasyon/dislokasyon"}}

    Dim arrayEklemdeInstabilite(,) As String = {
       {"Yok (0)", 0, " Yok"},
       {"Hafif: 10°den az (20)", 20, "Hafif instabilite"},
       {"Orta: 10-20° (40)", 40, "Orta instabilite"},
       {"Ağır: 20°den fazla (60)", 60, "Şiddetli instabilite"}}

    Dim arrayParmaktaDeformite(,) As String = {
       {"Yok (0)", 0},
       {"Hafif: 10°den az (10)", 10},
       {"Orta: 10-30° (20)", 20},
       {"Ağır: 30°den fazla (30)", 30}}

    Dim arrayParmaktaTenosinovit(,) As String = {
       {"Yok (0)", 0},
       {"Hafif: aktif hareket sırasında ara sıra takılma (20)", 20},
       {"Orta: aktif hareket sırasında sürekli takılma (40)", 40},
       {"Ağır: pasif hareket sırasında sürekli takılma (60)", 60}}




    '*************************************************************************************************************************
    '**************************ARRAY TANIMLANMASI BITTI***********************************************************************
    '*************************************************************************************************************************

    Private Sub D3_Load() Handles MyBase.Load
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
        intDifKf = 0
        intDifKe = 0
        intDifKfea = 0

        'Abd Add bölümü
        intPifKf = 0
        intPifKe = 0
        intPifKfea = 0

        'IR ER bölümü
        intMkfKf = 0
        intMkfKfe = 0
        intMkfKfea = 0

        intDifFleksEksKombine = 0
        intPifFleksEksKombine = 0
        intMkfFleksEksKombine = 0
        intDIFROMPuani = 0
        intPIFROMPuani = 0
        intMKFROMPuani = 0


        intLokalOzurlulukPuani = 0

        strParmakLokalRapor = ""
        strFinalOzetRapor = ""

        listboxDIFOzet.Items.Clear()
        listboxPIFOzet.Items.Clear()
        listboxMKFOzet.Items.Clear()
        listboxFinalOzet.Items.Clear()
        '/////////////////////////////////RESET COMPLETE


        Dim Newline As String
        Newline = System.Environment.NewLine

        '*************************************************************************************************************************
        '**************************LISTE LOAD*************************************************************************************
        '*************************************************************************************************************************
        'Arrayların Listeler Halinde Görüntülenmesi

        EnableAndPopulateList(listboxDifFleks, arrayDifFleksEks, 0)
        EnableAndPopulateList(listboxDifEks, arrayDifFleksEks, 2)

        EnableAndPopulateList(listboxPifFleks, arrayPifFleksEks, 0)
        EnableAndPopulateList(listboxPifEks, arrayPifFleksEks, 2)

        EnableAndPopulateList(listboxMkfFleks, arrayMkfFleksEks, 0)
        EnableAndPopulateList(listboxMkfEks, arrayMkfFleksEks, 2)

        EnableAndPopulateList(listboxDifSislik, arrayEklemdeSislik, 0)
        EnableAndPopulateList(listBoxDifİnstabilite, arrayEklemdeInstabilite, 0)
        EnableAndPopulateList(listboxDifSubluksasyon, arrayEklemdeSubluksasyon, 0)

        EnableAndPopulateList(listboxPifSislik, arrayEklemdeSislik, 0)
        EnableAndPopulateList(listBoxPifİnstabilite, arrayEklemdeInstabilite, 0)
        EnableAndPopulateList(listboxPifSubluksasyon, arrayEklemdeSubluksasyon, 0)

        EnableAndPopulateList(listboxMkfSislik, arrayEklemdeSislik, 0)
        EnableAndPopulateList(listBoxMkfİnstabilite, arrayEklemdeInstabilite, 0)
        EnableAndPopulateList(listboxMkfSubluksasyon, arrayEklemdeSubluksasyon, 0)

        EnableAndPopulateList(listboxParmakDeformite, arrayParmaktaDeformite, 0)
        EnableAndPopulateList(listboxParmakTenosinovit, arrayParmaktaTenosinovit, 0)
        '*************************************************************************************************************************
        '**************************LISTE LOAD BITTI*******************************************************************************
        '*************************************************************************************************************************


        ''HOUSE KEEPING
        groupboxDİF.Enabled = True
        groupboxPİF.Enabled = True
        groupboxMKF.Enabled = True

        listboxDifFleks.SetSelected(0, True)
        listboxDifEks.SetSelected(0, True)
        listboxPifFleks.SetSelected(0, True)
        listboxPifEks.SetSelected(0, True)
        listboxMkfFleks.SetSelected(0, True)
        listboxMkfEks.SetSelected(0, True)

        listboxDifSislik.SetSelected(0, True)
        listBoxDifİnstabilite.SetSelected(0, True)
        listboxDifSubluksasyon.SetSelected(0, True)

        listboxPifSislik.SetSelected(0, True)
        listBoxPifİnstabilite.SetSelected(0, True)
        listboxPifSubluksasyon.SetSelected(0, True)

        listboxMkfSislik.SetSelected(0, True)
        listBoxMkfİnstabilite.SetSelected(0, True)
        listboxMkfSubluksasyon.SetSelected(0, True)

        listboxParmakTenosinovit.SetSelected(0, True)
        listboxParmakDeformite.SetSelected(0, True)

        rbDifFleksEksAnkYok.Checked = True
        rbPifFleksEksAnkYok.Checked = True
        rbMkfFleksEksAnkYok.Checked = True

        DifRadioButtonUpdate()
        PifRadioButtonUpdate()
        MkfRadioButtonUpdate()

        lblResult.Text = intLokalOzurlulukPuani
        textboxLokalRapor.Text = ""


    End Sub


    '*************************************************************************************************************************
    '**************************RADIO BUTTON DONGUSU **************************************************************************
    '*************************************************************************************************************************

    'FLEKSIYON EKSTANSIYON ICIN DONGU



    Private Sub rbFEAnkYOK_CheckedChanged(sender As Object, e As EventArgs) Handles rbDifFleksEksAnkYok.CheckedChanged
        DifRadioButtonUpdate()
    End Sub

    Private Sub rbFleksiyonAnkVar_CheckedChanged(sender As Object, e As EventArgs) Handles rbDifFleksAnkVar.CheckedChanged

        DifRadioButtonUpdate()
    End Sub

    Private Sub rbEkstansiyondaAnkilozVar_CheckedChanged(sender As Object, e As EventArgs) Handles rbDifEksAnkVar.CheckedChanged

        DifRadioButtonUpdate()
    End Sub


    Private Sub DifRadioButtonUpdate()
        'FLEKSIYON EKSTANSİYON ANKİLOZ UPDATE
        listboxDifFleksEksAnk.Items.Clear()

        If rbDifFleksEksAnkYok.Checked Then

            DisableAndClearList(listboxDifFleksEksAnk)
            EnableAndPopulateList(listboxDifFleks, arrayDifFleksEks, 0)
            EnableAndPopulateList(listboxDifEks, arrayDifFleksEks, 2)

            listboxDifFleks.SetSelected(0, True)
            listboxDifEks.SetSelected(0, True)


            intDifKfea = 0

            lblParmakDIFKf.Text = updateDisabilityValue(listboxDifFleks, arrayDifFleksEks, 1)
            lblParmakDIFKe.Text = updateDisabilityValue(listboxDifEks, arrayDifFleksEks, 3)
            lblElBilegiKfea.Text = intDifKfea

        End If

        If rbDifFleksAnkVar.Checked Then

            DisableAndClearList(listboxDifFleks)
            DisableAndClearList(listboxDifEks)
            EnableAndPopulateList(listboxDifFleksEksAnk, arrayDifFleksAnkilozu, 0)

            listboxDifFleksEksAnk.SetSelected(0, True)
            intDifKfea = updateDisabilityValue(listboxDifFleksEksAnk, arrayDifFleksAnkilozu, 1)

            intDifKf = 0
            intDifKe = 0



            lblParmakDIFKf.Text = intDifKf
            lblParmakDIFKe.Text = intDifKe
            lblElBilegiKfea.Text = intDifKfea


        End If

        If rbDifEksAnkVar.Checked Then

            DisableAndClearList(listboxDifFleks)
            DisableAndClearList(listboxDifEks)
            EnableAndPopulateList(listboxDifFleksEksAnk, arrayDifEksAnkilozu, 0)

            listboxDifFleksEksAnk.SetSelected(0, True)
            intDifKfea = updateDisabilityValue(listboxDifFleksEksAnk, arrayDifEksAnkilozu, 1)

            intDifKf = 0
            intDifKe = 0



            lblParmakDIFKf.Text = intDifKf
            lblParmakDIFKe.Text = intDifKe
            lblElBilegiKfea.Text = intDifKfea


        End If
    End Sub


    'RADYAL ULNAR ICIN DONGU

    Private Sub rbRadUlAnkYok_CheckedChanged(sender As Object, e As EventArgs) Handles rbPifFleksEksAnkYok.CheckedChanged
        PifRadioButtonUpdate()
    End Sub

    Private Sub rbRadyalAnk_CheckedChanged(sender As Object, e As EventArgs) Handles rbPifFleksAnkVar.CheckedChanged
        PifRadioButtonUpdate()
    End Sub

    Private Sub rbUlnarAnk_CheckedChanged(sender As Object, e As EventArgs) Handles rbPifEksAnkVar.CheckedChanged
        PifRadioButtonUpdate()
    End Sub


    Private Sub PifRadioButtonUpdate()
        listboxDifFleksEksAnk.Items.Clear()

        If rbPifFleksEksAnkYok.Checked Then


            DisableAndClearList(listboxPifFleksEksAnk)
            EnableAndPopulateList(listboxPifFleks, arrayPifFleksEks, 0)
            EnableAndPopulateList(listboxPifEks, arrayPifFleksEks, 2)

            listboxPifFleks.SetSelected(0, True)
            listboxPifEks.SetSelected(0, True)

            intPifKfea = 0

            lblParmakPIFKf.Text = updateDisabilityValue(listboxPifFleks, arrayPifFleksEks, 1)
            lblParmakPIFKe.Text = updateDisabilityValue(listboxPifEks, arrayPifFleksEks, 3)
            lblElBilegiKrduda.Text = intPifKfea

        End If

        If rbPifFleksAnkVar.Checked Then

            DisableAndClearList(listboxPifFleks)
            DisableAndClearList(listboxPifEks)
            EnableAndPopulateList(listboxPifFleksEksAnk, arrayPifFleksAnk, 0)

            listboxPifFleksEksAnk.SetSelected(0, True)
            intPifKfea = updateDisabilityValue(listboxPifFleksEksAnk, arrayPifFleksAnk, 1)

            intPifKf = 0
            intPifKe = 0


            lblParmakPIFKf.Text = intPifKf
            lblParmakPIFKe.Text = intPifKe
            lblElBilegiKrduda.Text = intPifKfea

        End If

        If rbPifEksAnkVar.Checked Then

            DisableAndClearList(listboxPifFleks)
            DisableAndClearList(listboxPifEks)
            EnableAndPopulateList(listboxPifFleksEksAnk, arrayPifEksAnk, 0)

            listboxPifFleksEksAnk.SetSelected(0, True)
            intPifKfea = updateDisabilityValue(listboxPifFleksEksAnk, arrayPifEksAnk, 1)

            intPifKf = 0
            intPifKe = 0


            lblParmakPIFKf.Text = intPifKf
            lblParmakPIFKe.Text = intPifKe
            lblElBilegiKrduda.Text = intPifKfea

        End If
    End Sub


    Private Sub rbIRERAnkYok_CheckedChanged(sender As Object, e As EventArgs) Handles rbMkfFleksEksAnkYok.CheckedChanged
        MkfRadioButtonUpdate()
    End Sub

    Private Sub rbIRAnkVar_CheckedChanged(sender As Object, e As EventArgs) Handles rbMkfFleksAnkVar.CheckedChanged
        MkfRadioButtonUpdate()
    End Sub

    Private Sub rbERAnkVar_CheckedChanged(sender As Object, e As EventArgs) Handles rbMkfEksAnkVar.CheckedChanged
        MkfRadioButtonUpdate()
    End Sub

    Private Sub MkfRadioButtonUpdate()
        If rbMkfFleksEksAnkYok.Checked Then


            DisableAndClearList(listboxMkfFleksEksAnk)
            EnableAndPopulateList(listboxMkfFleks, arrayMkfFleksEks, 0)
            EnableAndPopulateList(listboxMkfEks, arrayMkfFleksEks, 2)

            listboxMkfFleks.SetSelected(0, True)
            listboxMkfEks.SetSelected(0, True)

            intMkfKfea = 0

            lblParmakMKFKf.Text = updateDisabilityValue(listboxMkfFleks, arrayMkfFleksEks, 1)
            lblParmakMKFKe.Text = updateDisabilityValue(listboxMkfEks, arrayMkfFleksEks, 3)
            lblOmuzKirera.Text = intMkfKfea

        End If

        If rbMkfFleksAnkVar.Checked Then

            DisableAndClearList(listboxMkfFleks)
            DisableAndClearList(listboxMkfEks)
            EnableAndPopulateList(listboxMkfFleksEksAnk, arrayMkfFleksAnk, 0)

            listboxMkfFleksEksAnk.SetSelected(0, True)
            intMkfKfea = updateDisabilityValue(listboxMkfFleksEksAnk, arrayMkfFleksAnk, 1)

            intMkfKf = 0
            intMkfKfe = 0


            lblParmakMKFKf.Text = intMkfKf
            lblParmakMKFKe.Text = intMkfKfe
            lblOmuzKirera.Text = intMkfKfea

        End If

        If rbMkfEksAnkVar.Checked Then

            DisableAndClearList(listboxMkfFleks)
            DisableAndClearList(listboxMkfEks)
            EnableAndPopulateList(listboxMkfFleksEksAnk, arrayMkfEksAnk, 0)

            listboxMkfFleksEksAnk.SetSelected(0, True)
            intMkfKfea = updateDisabilityValue(listboxMkfFleksEksAnk, arrayMkfEksAnk, 1)

            intMkfKf = 0
            intMkfKfe = 0


            lblParmakMKFKf.Text = intMkfKf
            lblParmakMKFKe.Text = intMkfKfe
            lblOmuzKirera.Text = intMkfKfea

        End If
    End Sub

    '////////////////////////////////////////////////RADIOBUTTON DONGUSU BITTI//////////////////////////////////////////////


    '***************************************************LİSTE LABEL GÜNCELLEME************************************************

    'LİSTELERİN LABELLERİNİN GÜNCELLENMESİ

    'Fleksiyon Ekstansiyon Label Güncellemesi

    Private Sub listboxElBilegiFleks_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listboxDifFleks.SelectedIndexChanged
        Dim typeofROM As Integer
        typeofROM = 1
        If booleanThereIsError = False Then
            checkUserCorrectInput(listboxDifFleks, listboxDifEks, typeofROM)
        End If
        booleanThereIsError = False
        intDifKf = updateDisabilityValue(listboxDifFleks, arrayDifFleksEks, 1)

        lblParmakDIFKf.Text = intDifKf


    End Sub

    Private Sub listboxElBilegiEkstansiyon_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listboxDifEks.SelectedIndexChanged
        Dim typeofROM As Integer
        typeofROM = 1
        If booleanThereIsError = False Then
            checkUserCorrectInput(listboxDifFleks, listboxDifEks, typeofROM)
        End If
        booleanThereIsError = False
        intDifKe = updateDisabilityValue(listboxDifEks, arrayDifFleksEks, 3)

        lblParmakDIFKe.Text = intDifKe
    End Sub

    Private Sub listboxElBilegiFEAnkiloz_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listboxDifFleksEksAnk.SelectedIndexChanged

        If rbDifFleksAnkVar.Checked Then
            intDifKfea = updateDisabilityValue(listboxDifFleksEksAnk, arrayDifFleksAnkilozu, 1)

        End If

        If rbDifEksAnkVar.Checked Then
            intDifKfea = updateDisabilityValue(listboxDifFleksEksAnk, arrayDifEksAnkilozu, 1)

        End If

        lblElBilegiKfea.Text = intDifKfea

    End Sub

    'Abd Add Label Güncellemesi

    Private Sub listboxElBilegiRadyalDev_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listboxPifFleks.SelectedIndexChanged
        Dim typeofROM As Integer
        typeofROM = 1
        If booleanThereIsError = False Then
            checkUserCorrectInput(listboxPifFleks, listboxPifEks, typeofROM)
        End If
        booleanThereIsError = False
        intPifKf = updateDisabilityValue(listboxPifFleks, arrayPifFleksEks, 1)
        lblParmakPIFKf.Text = intPifKf

    End Sub

    Private Sub listboxElBilegiUlnarDev_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listboxPifEks.SelectedIndexChanged
        Dim typeofROM As Integer
        typeofROM = 1
        If booleanThereIsError = False Then
            checkUserCorrectInput(listboxPifFleks, listboxPifEks, typeofROM)
        End If
        booleanThereIsError = False
        intPifKe = updateDisabilityValue(listboxPifEks, arrayPifFleksEks, 3)
        lblParmakPIFKe.Text = intPifKe

    End Sub

    Private Sub listboxElBilegiRadyalAnkiloz_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listboxPifFleksEksAnk.SelectedIndexChanged

        If rbPifFleksAnkVar.Checked Then
            intPifKfea = updateDisabilityValue(listboxPifFleksEksAnk, arrayPifFleksAnk, 1)

        End If

        If rbPifEksAnkVar.Checked Then
            intPifKfea = updateDisabilityValue(listboxPifFleksEksAnk, arrayPifEksAnk, 1)

        End If

        lblElBilegiKrduda.Text = intPifKfea

    End Sub


    'İç Rot Dış Rot Güncellemesi

    Private Sub listboxOmuzIR_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listboxMkfFleks.SelectedIndexChanged
        Dim typeofROM As Integer
        typeofROM = 1
        If booleanThereIsError = False Then
            checkUserCorrectInput(listboxMkfFleks, listboxMkfEks, typeofROM)
        End If
        booleanThereIsError = False

        intMkfKf = updateDisabilityValue(listboxMkfFleks, arrayMkfFleksEks, 1)
        lblParmakMKFKf.Text = intMkfKf

    End Sub

    Private Sub listboxOmuzER_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listboxMkfEks.SelectedIndexChanged
        Dim typeofROM As Integer
        typeofROM = 1
        If booleanThereIsError = False Then
            checkUserCorrectInput(listboxMkfFleks, listboxMkfEks, typeofROM)
        End If
        booleanThereIsError = False

        intMkfKfe = updateDisabilityValue(listboxMkfEks, arrayMkfFleksEks, 3)
        lblParmakMKFKe.Text = intMkfKfe

    End Sub

    Private Sub listboxOmuzIRERAnk_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listboxMkfFleksEksAnk.SelectedIndexChanged
        If rbMkfFleksAnkVar.Checked Then
            intMkfKfea = updateDisabilityValue(listboxMkfFleksEksAnk, arrayMkfFleksAnk, 1)

        End If

        If rbMkfEksAnkVar.Checked Then
            intMkfKfea = updateDisabilityValue(listboxMkfFleksEksAnk, arrayMkfEksAnk, 1)

        End If

        lblOmuzKirera.Text = intMkfKfea
    End Sub



    '////////////////////////////////////////////////LİSTE LABEL GÜNCELLEMESİ BÖLÜMÜ BİTTİ//////////////////////////////////////////////


    '**************************İŞLEMLER BÖLÜMÜ********************************************************************************


    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click


        Form_Reset()





    End Sub

    Public Sub Form_Reset()
        groupboxDİF.Enabled = True
        groupboxPİF.Enabled = True
        groupboxMKF.Enabled = True

        rbSeviyeDif.Checked = False
        rbSeviyePif.Checked = False
        rbSeviyeMkf.Checked = False

        D3_Load()
    End Sub


    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click

        intDIFROMPuani = 0
        intPIFROMPuani = 0
        intMKFROMPuani = 0



        'House keeping

        listboxFinalOzet.Items.Clear()
        listboxDIFOzet.Items.Clear()
        listboxPIFOzet.Items.Clear()
        listboxMKFOzet.Items.Clear()


        Raporla()

        Dim listFinalOzet As New List(Of Integer)

        intLokalOzurlulukPuani = Calc(listboxFinalOzet, listFinalOzet)

        lblResult.Text = intLokalOzurlulukPuani

        If intLokalOzurlulukPuani > 0 Then
            btnSaveExit.Enabled = True
        End If



        '//////////////////////////////////////////////////////////////////////////////////////////////////////
    End Sub

    Private Sub Raporla()


        Dim Newline As String
        Newline = System.Environment.NewLine
        strParmakLokalRapor = "***D3*** " + Newline
        strParmakDIF = ""
        strParmakPIF = ""
        strParmakMKF = ""
        strParmakSorunları = ""
        strParmakAmputasyon = ""



        'AMPUTASYON CHECK

        If rbSeviyeDif.Checked = False And rbSeviyePif.Checked = False And rbSeviyeMkf.Checked = False Then
            intAmputasyonSkoru = 0
        ElseIf rbSeviyeDif.Checked Then
            intAmputasyonSkoru = 45
        ElseIf rbSeviyePif.Checked Then
            intAmputasyonSkoru = 80
        ElseIf rbSeviyeMkf.Checked Then
            intAmputasyonSkoru = 100
        End If

        '******************************************ROMDAN GELEN TABLO 2.1***********************************







        'DIF İÇİN HESAPLAMA**************************************************************************************************
        'Fleksiyon-Ekstansiyon-Ankiloz Hesaplaması ve Raporlaması
        If rbDifFleksEksAnkYok.Checked Then

            intDifFleksEksKombine = intDifKf + intDifKe

        End If

        If rbDifFleksAnkVar.Checked Or rbDifEksAnkVar.Checked Then

            intDifFleksEksKombine = intDifKfea

        End If

        intDIFROMPuani = intDifFleksEksKombine

        'DifEklemSorunlarıCheck
        If intDIFROMPuani > 0 Then
            listboxDIFOzet.Items.Add(intDIFROMPuani)
            strParmakDIF = strParmakDIF + "         " + "Eklem hareketinden " + Conversion.Str(intDIFROMPuani) + Newline

        End If


        If listboxDifSislik.SelectedIndex > 0 Then


            listboxDIFOzet.Items.Add(arrayEklemdeSislik(listboxDifSislik.SelectedIndex, 1))
            strParmakDIF = strParmakDIF + "         " + "Şişlik nedeniyle" + Conversion.Str(arrayEklemdeSislik(listboxDifSislik.SelectedIndex, 1)) + Newline


        End If

        If listBoxDifİnstabilite.SelectedIndex > 0 Then


            listboxDIFOzet.Items.Add(arrayEklemdeInstabilite(listBoxDifİnstabilite.SelectedIndex, 1))
            strParmakDIF = strParmakDIF + "         " + "İnstabilite nedeniyle" + Conversion.Str(arrayEklemdeInstabilite(listBoxDifİnstabilite.SelectedIndex, 1)) + Newline


        End If

        If listboxDifSubluksasyon.SelectedIndex > 0 Then


            listboxDIFOzet.Items.Add(arrayEklemdeSubluksasyon(listboxDifSubluksasyon.SelectedIndex, 1))
            strParmakDIF = strParmakDIF + "         " + "Subluksasyon nedeniyle" + Conversion.Str(arrayEklemdeSubluksasyon(listboxDifSubluksasyon.SelectedIndex, 1)) + Newline


        End If

        '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        'PIF İÇİN HESAPLAMA'*************************************************************************************
        'Fleksiyon-Ekstansiyon-Ankiloz Hesaplaması ve Raporlaması
        If rbPifFleksEksAnkYok.Checked Then

            intPifFleksEksKombine = intPifKf + intPifKe

        End If

        If rbPifFleksAnkVar.Checked Or rbPifEksAnkVar.Checked Then

            intPifFleksEksKombine = intPifKfea

        End If

        intPIFROMPuani = intPifFleksEksKombine

        'PifEklemSorunlarıCheck
        If intPIFROMPuani > 0 Then
            listboxPIFOzet.Items.Add(intPIFROMPuani)
            strParmakPIF = strParmakPIF + "         " + "Eklem hareketinden " + Conversion.Str(intPIFROMPuani) + Newline + Newline

        End If


        If listboxPifSislik.SelectedIndex > 0 Then


            listboxPIFOzet.Items.Add(arrayEklemdeSislik(listboxPifSislik.SelectedIndex, 1))
            strParmakPIF = strParmakPIF + "         " + "Şişlik nedeniyle" + Conversion.Str(arrayEklemdeSislik(listboxPifSislik.SelectedIndex, 1)) + Newline


        End If

        If listBoxPifİnstabilite.SelectedIndex > 0 Then


            listboxPIFOzet.Items.Add(arrayEklemdeInstabilite(listBoxPifİnstabilite.SelectedIndex, 1))
            strParmakPIF = strParmakPIF + "         " + "İnstabilite nedeniyle" + Conversion.Str(arrayEklemdeInstabilite(listBoxPifİnstabilite.SelectedIndex, 1)) + Newline


        End If

        If listboxPifSubluksasyon.SelectedIndex > 0 Then


            listboxPIFOzet.Items.Add(arrayEklemdeSubluksasyon(listboxPifSubluksasyon.SelectedIndex, 1))
            strParmakPIF = strParmakPIF + "         " + "Subluksasyon nedeniyle" + Conversion.Str(arrayEklemdeSubluksasyon(listboxPifSubluksasyon.SelectedIndex, 1)) + Newline


        End If

        '///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        'MKF İÇİN HESAPLAMA******************************************************************************************************
        'Fleksiyon-Ekstansiyon-Ankiloz Hesaplaması ve Raporlaması


        If rbMkfFleksEksAnkYok.Checked Then

            intMkfFleksEksKombine = intMkfKf + intMkfKfe

        End If

        If rbMkfFleksAnkVar.Checked Or rbMkfEksAnkVar.Checked Then

            intMkfFleksEksKombine = intMkfKfea

        End If

        intMKFROMPuani = intMkfFleksEksKombine

        'MkfEklemSorunlarıCheck
        If intMKFROMPuani > 0 Then
            listboxMKFOzet.Items.Add(intMKFROMPuani)
            strParmakMKF = strParmakMKF + "         " + "Eklem hareketinden " + Conversion.Str(intMKFROMPuani) + Newline + Newline

        End If


        If listboxMkfSislik.SelectedIndex > 0 Then


            listboxMKFOzet.Items.Add(arrayEklemdeSislik(listboxMkfSislik.SelectedIndex, 1))
            strParmakMKF = strParmakMKF + "         " + "Şişlik nedeniyle" + Conversion.Str(arrayEklemdeSislik(listboxMkfSislik.SelectedIndex, 1)) + Newline


        End If

        If listBoxMkfİnstabilite.SelectedIndex > 0 Then


            listboxMKFOzet.Items.Add(arrayEklemdeInstabilite(listBoxMkfİnstabilite.SelectedIndex, 1))
            strParmakMKF = strParmakMKF + "         " + "İnstabilite nedeniyle" + Conversion.Str(arrayEklemdeInstabilite(listBoxMkfİnstabilite.SelectedIndex, 1)) + Newline


        End If

        If listboxMkfSubluksasyon.SelectedIndex > 0 Then


            listboxMKFOzet.Items.Add(arrayEklemdeSubluksasyon(listboxMkfSubluksasyon.SelectedIndex, 1))
            strParmakMKF = strParmakMKF + "         " + "Subluksasyon nedeniyle" + Conversion.Str(arrayEklemdeSubluksasyon(listboxMkfSubluksasyon.SelectedIndex, 1)) + Newline


        End If

        '**********Amputasyon skorunu raporla
        listboxFinalOzet.Items.Add(intAmputasyonSkoru)
        strParmakAmputasyon = "       " + "Amputasyon nedeniyle " + Conversion.Str(intAmputasyonSkoru)


        If listboxParmakDeformite.SelectedIndex > 0 Then


            listboxFinalOzet.Items.Add(arrayParmaktaDeformite(listboxParmakDeformite.SelectedIndex, 1))
            strParmakSorunları = strParmakSorunları + "         " + "Açısal deformite nedeniyle" + Conversion.Str(arrayParmaktaDeformite(listboxParmakDeformite.SelectedIndex, 1)) + Newline


        End If

        If listboxParmakTenosinovit.SelectedIndex > 0 Then


            listboxFinalOzet.Items.Add(arrayParmaktaTenosinovit(listboxParmakTenosinovit.SelectedIndex, 1))
            strParmakSorunları = strParmakSorunları + "         " + "Tenosinovit nedeniyle" + Conversion.Str(arrayParmaktaTenosinovit(listboxParmakTenosinovit.SelectedIndex, 1)) + Newline


        End If






        'MKF puanlarını blatazar ile kombine et ve final ozet listeye ekle

        Dim listMKFOzet As New List(Of Integer)

        listboxFinalOzet.Items.Add(Calc(listboxMKFOzet, listMKFOzet))

        'PIF puanlarını baltazar ile kombine et ve final ozet listeye ekle
        Dim listPIFOzet As New List(Of Integer)

        listboxFinalOzet.Items.Add(Calc(listboxPIFOzet, listPIFOzet))

        'DIF puanlarını baltazar ile kombine et ve final ozet listeye ekle
        Dim listDIFOzet As New List(Of Integer)

        listboxFinalOzet.Items.Add(Calc(listboxDIFOzet, listDIFOzet))




        strParmakLokalRapor = strParmakLokalRapor + "       " + "DIF: " + Newline + strParmakDIF + Newline
        strParmakLokalRapor = strParmakLokalRapor + "       " + "PIF: " + Newline + strParmakPIF + Newline
        strParmakLokalRapor = strParmakLokalRapor + "       " + "MKF: " + Newline + strParmakMKF + Newline

        strParmakLokalRapor = strParmakLokalRapor + "       " + "Parmak Sorunları" + Newline + strParmakSorunları

        strParmakLokalRapor = strParmakLokalRapor + Newline + strParmakAmputasyon







        textboxLokalRapor.Text = strParmakLokalRapor
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnSaveExit.Click
        If leftside = True Then
            intD3FinalLeft = intLokalOzurlulukPuani
            strD3RaporFinalLeft = strParmakLokalRapor
        Else
            intD3FinalRight = intLokalOzurlulukPuani
            strD3RaporFinalRight = strParmakLokalRapor
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

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles rbSeviyeDif.CheckedChanged
        DisableAndClearList(listboxDifFleks)
        DisableAndClearList(listboxDifEks)
        DisableAndClearList(listboxDifFleksEksAnk)
        DisableAndClearList(listboxDifSislik)
        DisableAndClearList(listBoxDifİnstabilite)
        DisableAndClearList(listboxDifSubluksasyon)
        groupboxDİF.Enabled = False

        intDifKf = 0
        intDifKe = 0
        intDifKfea = 0


        EnableAndPopulateList(listboxPifFleks, arrayPifFleksEks, 0)
        EnableAndPopulateList(listboxPifEks, arrayPifFleksEks, 2)
        EnableAndPopulateList(listboxPifSislik, arrayEklemdeSislik, 0)
        EnableAndPopulateList(listBoxPifİnstabilite, arrayEklemdeInstabilite, 0)
        EnableAndPopulateList(listboxPifSubluksasyon, arrayEklemdeSubluksasyon, 0)
        groupboxPİF.Enabled = True

        EnableAndPopulateList(listboxMkfFleks, arrayMkfFleksEks, 0)
        EnableAndPopulateList(listboxMkfEks, arrayMkfFleksEks, 2)
        EnableAndPopulateList(listboxMkfSislik, arrayEklemdeSislik, 0)
        EnableAndPopulateList(listBoxMkfİnstabilite, arrayEklemdeInstabilite, 0)
        EnableAndPopulateList(listboxMkfSubluksasyon, arrayEklemdeSubluksasyon, 0)
        groupboxMKF.Enabled = True

    End Sub

    Private Sub btnSeviyePif_CheckedChanged(sender As Object, e As EventArgs) Handles rbSeviyePif.CheckedChanged
        DisableAndClearList(listboxDifFleks)
        DisableAndClearList(listboxDifEks)
        DisableAndClearList(listboxDifFleksEksAnk)
        DisableAndClearList(listboxDifSislik)
        DisableAndClearList(listBoxDifİnstabilite)
        DisableAndClearList(listboxDifSubluksasyon)
        groupboxDİF.Enabled = False

        intDifKf = 0
        intDifKe = 0
        intDifKfea = 0



        DisableAndClearList(listboxPifFleks)
        DisableAndClearList(listboxPifEks)
        DisableAndClearList(listboxPifFleksEksAnk)
        DisableAndClearList(listboxPifSislik)
        DisableAndClearList(listBoxPifİnstabilite)
        DisableAndClearList(listboxPifSubluksasyon)
        groupboxPİF.Enabled = False

        intPifKf = 0
        intPifKe = 0
        intPifKfea = 0



        EnableAndPopulateList(listboxMkfFleks, arrayMkfFleksEks, 0)
        EnableAndPopulateList(listboxMkfEks, arrayMkfFleksEks, 2)
        EnableAndPopulateList(listboxMkfSislik, arrayEklemdeSislik, 0)
        EnableAndPopulateList(listBoxMkfİnstabilite, arrayEklemdeInstabilite, 0)
        EnableAndPopulateList(listboxMkfSubluksasyon, arrayEklemdeSubluksasyon, 0)
        groupboxMKF.Enabled = True

    End Sub

    Private Sub btnSeviyeMkf_CheckedChanged(sender As Object, e As EventArgs) Handles rbSeviyeMkf.CheckedChanged
        DisableAndClearList(listboxDifFleks)
        DisableAndClearList(listboxDifEks)
        DisableAndClearList(listboxDifFleksEksAnk)
        DisableAndClearList(listboxDifSislik)
        DisableAndClearList(listBoxDifİnstabilite)
        DisableAndClearList(listboxDifSubluksasyon)
        groupboxDİF.Enabled = False

        intDifKf = 0
        intDifKe = 0
        intDifKfea = 0


        DisableAndClearList(listboxPifFleks)
        DisableAndClearList(listboxPifEks)
        DisableAndClearList(listboxPifFleksEksAnk)
        DisableAndClearList(listboxPifSislik)
        DisableAndClearList(listBoxPifİnstabilite)
        DisableAndClearList(listboxPifSubluksasyon)
        groupboxPİF.Enabled = False

        intPifKf = 0
        intPifKe = 0
        intPifKfea = 0


        DisableAndClearList(listboxMkfFleks)
        DisableAndClearList(listboxMkfEks)
        DisableAndClearList(listboxMkfFleksEksAnk)
        DisableAndClearList(listboxMkfSislik)
        DisableAndClearList(listBoxMkfİnstabilite)
        DisableAndClearList(listboxMkfSubluksasyon)
        groupboxMKF.Enabled = False

        intMkfKf = 0
        intMkfKfe = 0
        intMkfKfea = 0


    End Sub

    Private Sub listboxFinalOzet_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listboxFinalOzet.SelectedIndexChanged

    End Sub





    '/////////////////////////////////////////İŞLEMLER BÖLÜMÜ BİTTİ//////////////////////////////////////////////////////////////////////////



    '////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
End Class