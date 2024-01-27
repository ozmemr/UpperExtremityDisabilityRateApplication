Imports UpperExtremityModule.Universal



Public Class Omuz

    'Fleks Eks Puanları
    Dim intKf As Integer
    Dim intKe As Integer
    Dim intKfea As Integer

    Dim intFLEKSEKSANKKombine As Integer

    'Abd Add Puanları
    Dim intKabd As Integer
    Dim intKadd As Integer
    Dim intKrabdadda As Integer

    Dim intABDADDKombine As Integer

    'IR ER Puanları
    Dim intKir As Integer
    Dim intKer As Integer
    Dim intKirera As Integer

    Dim intIRERKombine As Integer

    'Kombine Puanlar
    Dim intROMPuani As Integer
    Dim intLokalOzurlulukPuani As Integer



    Dim strLokalRapor As String
    Dim strOmuzLokal As String


    '*************************************************************************************************************************
    '**************************ARRAY TANIMLANMASI*****************************************************************************
    '*************************************************************************************************************************

    'Arrayların Tanımlanması
    'Fleksiyon Ekstansiyon Arrayları
    Dim arrayFleksEks(,) As String = {
        {180, 0, 50, 0},
        {170, 1, 40, 1},
        {160, 1, 30, 1},
        {150, 2, 20, 2},
        {140, 3, 10, 2},
        {130, 3, 0, 3},
        {120, 4, -10, 3},
        {110, 5, -20, 4},
        {100, 5, -30, 5},
        {90, 6, -40, 5},
        {80, 7, -50, 8},
        {70, 7, -60, 12},
        {60, 8, -70, 15},
        {50, 9, -80, 18},
        {40, 10, -90, 21},
        {30, 10, -100, 22},
        {20, 11, -110, 23},
        {10, 16, -120, 24},
        {0, 21, -130, 25},
        {-10, 23, -140, 26},
        {-20, 24, -150, 27},
        {-30, 26, -160, 28},
        {-40, 28, -170, 29},
        {-50, 30, -180, 30}}

    Dim arrayFleksAnkilozu(,) As String = {
        {180, 30},
        {170, 30},
        {160, 29},
        {150, 29},
        {140, 29},
        {130, 28},
        {120, 28},
        {110, 28},
        {100, 27},
        {90, 27},
        {80, 25},
        {70, 22},
        {60, 20},
        {50, 17},
        {40, 15},
        {30, 15},
        {20, 15},
        {10, 19},
        {0, 24}}

    Dim arrayEksAnkilozu(,) As String = {
        {50, 30},
        {40, 29},
        {30, 27},
        {20, 26},
        {10, 25},
        {0, 24}}

    '/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    'Abdüksiyon Addüksiyon Arrayları

    Dim arrayAbdAdd(,) As String = {
        {180, 0, 50, 0},
        {170, 0, 40, 0},
        {160, 1, 30, 1},
        {150, 1, 20, 1},
        {140, 2, 10, 1},
        {130, 2, 0, 2},
        {120, 3, -10, 2},
        {110, 3, -20, 2},
        {100, 4, -30, 2},
        {90, 4, -40, 3},
        {80, 5, -50, 3},
        {70, 5, -60, 5},
        {60, 6, -70, 7},
        {50, 6, -80, 9},
        {40, 6, -90, 12},
        {30, 7, -100, 12},
        {20, 7, -110, 13},
        {10, 10, -120, 14},
        {0, 12, -130, 15},
        {-10, 14, -140, 15},
        {-20, 15, -150, 16},
        {-30, 16, -160, 16},
        {-40, 17, -170, 18},
        {-50, 18, -180, 18}}

    Dim arrayAbdAnkiloz(,) As String = {
        {180, 18},
        {170, 18},
        {160, 17},
        {150, 17},
        {140, 17},
        {130, 17},
        {120, 17},
        {110, 16},
        {100, 16},
        {90, 16},
        {80, 14},
        {70, 12},
        {60, 11},
        {50, 9},
        {40, 9},
        {30, 9},
        {20, 9},
        {10, 12},
        {0, 14}}

    Dim arrayAddAnkiloz(,) As String = {
        {50, 18},
        {40, 17},
        {30, 17},
        {20, 16},
        {10, 15},
        {0, 14}}


    Dim arrayIRER(,) As String = {
        {90, 0, 90, 0},
        {80, 0, 80, 0},
        {70, 1, 70, 0},
        {60, 2, 60, 0},
        {50, 2, 50, 1},
        {40, 3, 40, 1},
        {30, 4, 30, 1},
        {20, 4, 20, 1},
        {10, 5, 10, 2},
        {0, 5, 0, 2},
        {-10, 6, -10, 2},
        {-20, 7, -20, 2},
        {-30, 8, -30, 2},
        {-40, 8, -40, 3},
        {-50, 9, -50, 4},
        {-60, 10, -60, 5},
        {-70, 11, -70, 8},
        {-80, 11, -80, 10},
        {-90, 12, -90, 12}}

    Dim arrayIRAnkiloz(,) As String = {
        {90, 12},
        {80, 10},
        {70, 9},
        {60, 7},
        {50, 6},
        {40, 6},
        {30, 6},
        {20, 6},
        {10, 7},
        {0, 7}}

    Dim arrayERAnkiloz(,) As String = {
        {90, 12},
        {80, 10},
        {70, 9},
        {60, 7},
        {50, 6},
        {40, 6},
        {30, 6},
        {20, 6},
        {10, 7},
        {0, 7}}






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

    Private Sub Omuz_Load() Handles MyBase.Load
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
        ' ***********'Degiskenlerin resetlenmesi****************************************************
        'Fleks - Eks
        intKf = 0
        intKe = 0
        intKfea = 0

        'Abd Add bölümü
        intKabd = 0
        intKadd = 0
        intKrabdadda = 0

        'IR ER bölümü
        intKir = 0
        intKer = 0
        intKirera = 0

        intFLEKSEKSANKKombine = 0
        intABDADDKombine = 0
        intIRERKombine = 0
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

        EnableAndPopulateList(listboxOmuzFleks, arrayFleksEks, 0)
        EnableAndPopulateList(listboxOmuzEkstansiyon, arrayFleksEks, 2)

        EnableAndPopulateList(listboxOmuzAbd, arrayAbdAdd, 0)
        EnableAndPopulateList(listboxOmuzAdd, arrayAbdAdd, 2)

        EnableAndPopulateList(listboxOmuzIR, arrayIRER, 0)
        EnableAndPopulateList(listboxOmuzER, arrayIRER, 2)

        EnableAndPopulateList(listboxElBilegiEklemdeSislik, arrayElBilegiEklemdeSislik, 0)
        EnableAndPopulateList(listboxElBilegiEklemdeInstabilite, arrayElBilegiEklemdeInstabilite, 0)
        EnableAndPopulateList(listboxElBilegiSubluksasyon, arrayElBilegiEklemdeSubluksasyon, 0)
        EnableAndPopulateList(listboxElBilegiDeviasyon, arrayElBilegiEklemdeDeviasyon, 0)


        '*************************************************************************************************************************
        '**************************LISTE LOAD BITTI*******************************************************************************
        '*************************************************************************************************************************


        ''HOUSE KEEPING
        listboxOmuzFleks.SetSelected(0, True)
        listboxOmuzEkstansiyon.SetSelected(0, True)
        listboxOmuzAbd.SetSelected(0, True)
        listboxOmuzAdd.SetSelected(0, True)
        listboxOmuzIR.SetSelected(0, True)
        listboxOmuzER.SetSelected(0, True)

        listboxElBilegiEklemdeSislik.SetSelected(0, True)
        listboxElBilegiEklemdeInstabilite.SetSelected(0, True)
        listboxElBilegiSubluksasyon.SetSelected(0, True)
        listboxElBilegiDeviasyon.SetSelected(0, True)


        rbFEAnkYOK.Checked = True
        rbAbdaddankYok.Checked = True
        rbIRERAnkYok.Checked = True

        AbdAddRadioButtonUpdate()
        FleksEksRadioButtonUpdate()
        IRERRadioButtonUpdate()

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

            DisableAndClearList(listboxOmuzFEAnkiloz)
            EnableAndPopulateList(listboxOmuzFleks, arrayFleksEks, 0)
            EnableAndPopulateList(listboxOmuzEkstansiyon, arrayFleksEks, 2)

            listboxOmuzFleks.SetSelected(0, True)
            listboxOmuzEkstansiyon.SetSelected(0, True)


            intKfea = 0

            lblElBilegiKf.Text = updateDisabilityValue(listboxOmuzFleks, arrayFleksEks, 1)
            lblElBilegiKe.Text = updateDisabilityValue(listboxOmuzEkstansiyon, arrayFleksEks, 3)
            lblElBilegiKfea.Text = intKfea

        End If

        If rbFleksiyonAnkVar.Checked Then

            DisableAndClearList(listboxOmuzFleks)
            DisableAndClearList(listboxOmuzEkstansiyon)
            EnableAndPopulateList(listboxOmuzFEAnkiloz, arrayFleksAnkilozu, 0)

            intKf = 0
            intKe = 0

            listboxOmuzFEAnkiloz.SetSelected(0, True)
            intKfea = updateDisabilityValue(listboxOmuzFEAnkiloz, arrayFleksAnkilozu, 1)


            lblElBilegiKf.Text = intKf
            lblElBilegiKe.Text = intKe
            lblElBilegiKfea.Text = intKfea


        End If

        If rbEkstansiyondaAnkilozVar.Checked Then

            DisableAndClearList(listboxOmuzFleks)
            DisableAndClearList(listboxOmuzEkstansiyon)
            EnableAndPopulateList(listboxOmuzFEAnkiloz, arrayEksAnkilozu, 0)

            listboxOmuzFEAnkiloz.SetSelected(0, True)
            intKfea = updateDisabilityValue(listboxOmuzFEAnkiloz, arrayEksAnkilozu, 1)

            intKf = 0
            intKe = 0



            lblElBilegiKf.Text = intKf
            lblElBilegiKe.Text = intKe
            lblElBilegiKfea.Text = intKfea


        End If
    End Sub


    'RADYAL ULNAR ICIN DONGU

    Private Sub rbRadUlAnkYok_CheckedChanged(sender As Object, e As EventArgs) Handles rbAbdaddankYok.CheckedChanged
        AbdAddRadioButtonUpdate()
    End Sub

    Private Sub rbRadyalAnk_CheckedChanged(sender As Object, e As EventArgs) Handles rbAbdAnk.CheckedChanged
        AbdAddRadioButtonUpdate()
    End Sub

    Private Sub rbUlnarAnk_CheckedChanged(sender As Object, e As EventArgs) Handles rbAddAnk.CheckedChanged
        AbdAddRadioButtonUpdate()
    End Sub


    Private Sub AbdAddRadioButtonUpdate()
        If rbAbdaddankYok.Checked Then


            DisableAndClearList(listboxOmuzAbdAddAnk)
            EnableAndPopulateList(listboxOmuzAbd, arrayAbdAdd, 0)
            EnableAndPopulateList(listboxOmuzAdd, arrayAbdAdd, 2)

            listboxOmuzAbd.SetSelected(0, True)
            listboxOmuzAdd.SetSelected(0, True)

            intKrabdadda = 0

            lblElBilegiKrd.Text = updateDisabilityValue(listboxOmuzAbd, arrayAbdAdd, 1)
            lblElBilegiKud.Text = updateDisabilityValue(listboxOmuzAdd, arrayAbdAdd, 3)
            lblElBilegiKrduda.Text = intKrabdadda

        End If

        If rbAbdAnk.Checked Then

            DisableAndClearList(listboxOmuzAbd)
            DisableAndClearList(listboxOmuzAdd)
            EnableAndPopulateList(listboxOmuzAbdAddAnk, arrayAbdAnkiloz, 0)

            intKabd = 0
            intKadd = 0

            listboxOmuzAbdAddAnk.SetSelected(0, True)
            intKrabdadda = updateDisabilityValue(listboxOmuzAbdAddAnk, arrayAbdAnkiloz, 1)


            lblElBilegiKrd.Text = intKabd
            lblElBilegiKud.Text = intKadd
            lblElBilegiKrduda.Text = intKrabdadda

        End If

        If rbAddAnk.Checked Then

            DisableAndClearList(listboxOmuzAbd)
            DisableAndClearList(listboxOmuzAdd)
            EnableAndPopulateList(listboxOmuzAbdAddAnk, arrayAddAnkiloz, 0)

            intKabd = 0
            intKadd = 0

            listboxOmuzAbdAddAnk.SetSelected(0, True)
            intKrabdadda = updateDisabilityValue(listboxOmuzAbdAddAnk, arrayAddAnkiloz, 1)

            lblElBilegiKrd.Text = intKabd
            lblElBilegiKud.Text = intKadd
            lblElBilegiKrduda.Text = intKrabdadda

        End If
    End Sub


    Private Sub rbIRERAnkYok_CheckedChanged(sender As Object, e As EventArgs) Handles rbIRERAnkYok.CheckedChanged
        IRERRadiobuttonUpdate()
    End Sub

    Private Sub rbIRAnkVar_CheckedChanged(sender As Object, e As EventArgs) Handles rbIRAnkVar.CheckedChanged
        IRERRadiobuttonUpdate()
    End Sub

    Private Sub rbERAnkVar_CheckedChanged(sender As Object, e As EventArgs) Handles rbERAnkVar.CheckedChanged
        IRERRadiobuttonUpdate()
    End Sub

    Private Sub IRERRadioButtonUpdate()
        If rbIRERAnkYok.Checked Then


            DisableAndClearList(listboxOmuzIRERAnk)
            EnableAndPopulateList(listboxOmuzIR, arrayIRER, 0)
            EnableAndPopulateList(listboxOmuzER, arrayIRER, 2)

            listboxOmuzIR.SetSelected(0, True)
            listboxOmuzER.SetSelected(0, True)

            intKirera = 0

            lblOmuzKir.Text = updateDisabilityValue(listboxOmuzIR, arrayIRER, 1)
            lblOmuzKer.Text = updateDisabilityValue(listboxOmuzER, arrayIRER, 3)
            lblOmuzKirera.Text = intKirera

        End If

        If rbIRAnkVar.Checked Then

            DisableAndClearList(listboxOmuzIR)
            DisableAndClearList(listboxOmuzER)
            EnableAndPopulateList(listboxOmuzIRERAnk, arrayIRAnkiloz, 0)

            intKir = 0
            intKer = 0

            listboxOmuzIRERAnk.SetSelected(0, True)
            intKirera = updateDisabilityValue(listboxOmuzIRERAnk, arrayIRAnkiloz, 1)

            lblOmuzKir.Text = intKir
            lblOmuzKer.Text = intKer
            lblOmuzKirera.Text = intKirera

        End If

        If rbERAnkVar.Checked Then

            DisableAndClearList(listboxOmuzIR)
            DisableAndClearList(listboxOmuzER)
            EnableAndPopulateList(listboxOmuzIRERAnk, arrayERAnkiloz, 0)

            intKir = 0
            intKer = 0

            listboxOmuzIRERAnk.SetSelected(0, True)
            intKirera = updateDisabilityValue(listboxOmuzIRERAnk, arrayIRAnkiloz, 1)

            lblOmuzKir.Text = intKir
            lblOmuzKer.Text = intKer
            lblOmuzKirera.Text = intKirera

        End If
    End Sub

    '////////////////////////////////////////////////RADIOBUTTON DONGUSU BITTI//////////////////////////////////////////////


    '***************************************************LİSTE LABEL GÜNCELLEME************************************************

    'LİSTELERİN LABELLERİNİN GÜNCELLENMESİ

    'Fleksiyon Ekstansiyon Label Güncellemesi
    'Fleks Eks=1 Abd-Add=2


    Private Sub listboxElBilegiFleks_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listboxOmuzFleks.SelectedIndexChanged
        Dim typeofROM As Integer
        typeofROM = 1
        If booleanThereIsError = False Then
            checkUserCorrectInput(listboxOmuzFleks, listboxOmuzEkstansiyon, typeofROM)
        End If
        booleanThereIsError = False


        intKf = updateDisabilityValue(listboxOmuzFleks, arrayFleksEks, 1)

        lblElBilegiKf.Text = intKf


    End Sub

    Private Sub listboxElBilegiEkstansiyon_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listboxOmuzEkstansiyon.SelectedIndexChanged
        Dim typeofROM As Integer
        typeofROM = 1
        If booleanThereIsError = False Then
            checkUserCorrectInput(listboxOmuzFleks, listboxOmuzEkstansiyon, typeofROM)
        End If
        booleanThereIsError = False


        intKe = updateDisabilityValue(listboxOmuzEkstansiyon, arrayFleksEks, 3)

        lblElBilegiKe.Text = intKe
    End Sub

    Private Sub listboxElBilegiFEAnkiloz_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listboxOmuzFEAnkiloz.SelectedIndexChanged

        If rbFleksiyonAnkVar.Checked Then
            intKfea = updateDisabilityValue(listboxOmuzFEAnkiloz, arrayFleksAnkilozu, 1)

        End If

        If rbEkstansiyondaAnkilozVar.Checked Then
            intKfea = updateDisabilityValue(listboxOmuzFEAnkiloz, arrayEksAnkilozu, 1)

        End If

        lblElBilegiKfea.Text = intKfea

    End Sub

    'Abd Add Label Güncellemesi

    Private Sub listboxElBilegiRadyalDev_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listboxOmuzAbd.SelectedIndexChanged
        Dim typeofROM As Integer
        typeofROM = 2
        If booleanThereIsError = False Then
            checkUserCorrectInput(listboxOmuzAbd, listboxOmuzAdd, typeofROM)
        End If
        booleanThereIsError = False




        intKabd = updateDisabilityValue(listboxOmuzAbd, arrayAbdAdd, 1)
        lblElBilegiKrd.Text = intKabd

    End Sub

    Private Sub listboxElBilegiUlnarDev_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listboxOmuzAdd.SelectedIndexChanged
        Dim typeofROM As Integer
        typeofROM = 2
        If booleanThereIsError = False Then
            checkUserCorrectInput(listboxOmuzAbd, listboxOmuzAdd, typeofROM)
        End If
        booleanThereIsError = False

        intKadd = updateDisabilityValue(listboxOmuzAdd, arrayAbdAdd, 3)
        lblElBilegiKud.Text = intKadd

    End Sub

    Private Sub listboxElBilegiRadyalAnkiloz_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listboxOmuzAbdAddAnk.SelectedIndexChanged

        If rbAbdAnk.Checked Then
            intKrabdadda = updateDisabilityValue(listboxOmuzAbdAddAnk, arrayAbdAnkiloz, 1)

        End If

        If rbAddAnk.Checked Then
            intKrabdadda = updateDisabilityValue(listboxOmuzAbdAddAnk, arrayAddAnkiloz, 1)

        End If

        lblElBilegiKrduda.Text = intKrabdadda

    End Sub


    'İç Rot Dış Rot Güncellemesi

    Private Sub listboxOmuzIR_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listboxOmuzIR.SelectedIndexChanged
        Dim typeofROM As Integer
        typeofROM = 3
        If booleanThereIsError = False Then
            checkUserCorrectInput(listboxOmuzIR, listboxOmuzER, typeofROM)
        End If
        booleanThereIsError = False



        intKir = updateDisabilityValue(listboxOmuzIR, arrayIRER, 1)
        lblOmuzKir.Text = intKir

    End Sub

    Private Sub listboxOmuzER_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listboxOmuzER.SelectedIndexChanged
        Dim typeofROM As Integer
        typeofROM = 3
        If booleanThereIsError = False Then
            checkUserCorrectInput(listboxOmuzIR, listboxOmuzER, typeofROM)
        End If
        booleanThereIsError = False



        intKer = updateDisabilityValue(listboxOmuzER, arrayIRER, 3)
        lblOmuzKer.Text = intKer

    End Sub

    Private Sub listboxOmuzIRERAnk_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listboxOmuzIRERAnk.SelectedIndexChanged
        If rbIRAnkVar.Checked Then
            intKirera = updateDisabilityValue(listboxOmuzIRERAnk, arrayIRAnkiloz, 1)

        End If

        If rbERAnkVar.Checked Then
            intKirera = updateDisabilityValue(listboxOmuzIRERAnk, arrayERAnkiloz, 1)

        End If

        lblOmuzKirera.Text = intKirera
    End Sub



    '////////////////////////////////////////////////LİSTE LABEL GÜNCELLEMESİ BÖLÜMÜ BİTTİ//////////////////////////////////////////////


    '**************************İŞLEMLER BÖLÜMÜ********************************************************************************


    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        Form_Reset()




    End Sub

    Public Sub Form_Reset()
        Omuz_Load()

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

        'Abdüksiyon Addüksiyon Deviasyon - Ankiloz Hesaplaması ve Raporlaması

        If rbAbdaddankYok.Checked Then

            intABDADDKombine = intKabd + intKadd

        End If

        If rbAbdAnk.Checked Or rbAddAnk.Checked Then

            intABDADDKombine = intKrabdadda

        End If

        'IR ER Ankiloz Hesaplaması ve Raporlaması


        If rbIRERAnkYok.Checked Then

            intIRERKombine = intKir + intKer

        End If

        If rbIRAnkVar.Checked Or rbERAnkVar.Checked Then

            intIRERKombine = intKirera

        End If

        intROMPuani = intFLEKSEKSANKKombine + intABDADDKombine + intIRERKombine
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
        strLokalRapor = "***Omuz*** " + Newline



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



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnSaveExit.Click
        If leftside = True Then
            intOmuzFinalLeft = intLokalOzurlulukPuani
            strOmuzRaporFinalLeft = strLokalRapor
        Else
            intOmuzFinalRight = intLokalOzurlulukPuani
            strOmuzRaporFinalRight = strLokalRapor

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



    '////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
End Class