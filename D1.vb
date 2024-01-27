Imports UpperExtremityModule.Universal



Public Class D1

    'DIF Puanları
    Dim intIfKf As Integer
    Dim intIfKe As Integer
    Dim intIfKfea As Integer

    Dim intIfFleksEksKombine As Integer

    'MKF Puanları
    Dim intMkfKf As Integer
    Dim intMkfKe As Integer
    Dim intMkfKea As Integer

    Dim intMkfFleksEksKombine As Integer

    Dim intKadd As Integer
    Dim intKabd As Integer
    Dim intKopp As Integer

    Dim intKombineROMPuani As Integer



    Dim intAmputasyonSkoru As Integer

    Dim intLokalOzurlulukPuani As Integer


    Dim strParmakIF As String
    Dim strParmakMKF As String
    Dim strParmakAmputasyon As String
    Dim strParmakSorunları As String


    Dim strParmakLokalRapor As String


    '*************************************************************************************************************************
    '**************************ARRAY TANIMLANMASI*****************************************************************************
    '*************************************************************************************************************************

    'Arrayların Tanımlanması
    'Fleksiyon Ekstansiyon Arrayları
    Dim arrayIfFleksEks(,) As String = {
        {80, 0, 30, 0},
        {70, 1, 20, 0},
        {60, 1, 10, 0},
        {50, 2, 0, 1},
        {40, 3, -10, 2},
        {30, 4, -20, 3},
        {20, 4, -30, 5},
        {10, 6, -40, 7},
        {0, 8, -50, 9},
        {-10, 11, -60, 11},
        {-20, 13, -70, 13},
        {-30, 15, -80, 15}}

    Dim arrayIfFleksAnkilozu(,) As String = {
        {80, 15},
        {70, 14},
        {60, 12},
        {50, 11},
        {40, 10},
        {30, 9},
        {20, 7},
        {10, 8},
        {0, 9}}


    Dim arrayIfEksAnkilozu(,) As String = {
        {30, 15},
        {20, 13},
        {10, 11}}

    '/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


    '*********************MKF Fleks Eks Arrayleri

    Dim arrayMkfFleksEks(,) As String = {
        {60, 0, 40, 0},
        {50, 1, 30, 0},
        {40, 2, 20, 0},
        {30, 3, 10, 0},
        {20, 4, 0, 0},
        {10, 5, -10, 1},
        {0, 6, -20, 1},
        {-10, 7, -30, 3},
        {-20, 8, -40, 5},
        {-30, 9, -50, 8},
        {-40, 10, -60, 10}}


    Dim arrayMkfFleksAnk(,) As String = {
        {60, 10},
        {50, 9},
        {40, 7},
        {30, 6},
        {20, 5},
        {10, 6},
        {0, 6}}




    Dim arrayMkfEksAnk(,) As String = {
        {40, 10},
        {30, 9},
        {20, 8},
        {10, 7}}


    '////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    '****ADD ABD ve OPP arraylari*****************************************************************************
    Dim arrayAddKaybi(,) As String = {
        {0, 0, 20},
        {1, 0, 19},
        {2, 1, 17},
        {3, 3, 15},
        {4, 4, 10},
        {5, 6, 15},
        {6, 8, 17},
        {7, 13, 19},
        {8, 20, 20}}

    Dim arrayAbdKaybi(,) As String = {
        {50, 0, 10},
        {40, 1, 10},
        {30, 3, 10},
        {20, 7, 10},
        {10, 9, 10},
        {0, 10, 10}}


    Dim arrayOppKaybi(,) As String = {
        {8, 0, 29},
        {7, 1, 27},
        {6, 3, 24},
        {5, 5, 22},
        {4, 9, 27},
        {3, 13, 31},
        {2, 22, 36},
        {1, 31, 40},
        {0, 45, 45}}


    '///////////////////////////////////////////////////////////////////////////////////////////////////////////////





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

    Private Sub D1_Load() Handles MyBase.Load
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
        'If Fleks - Eks
        intIfKf = 0
        intIfKe = 0
        intIfKfea = 0



        'MKF Fleks Eks
        intMkfKf = 0
        intMkfKe = 0
        intMkfKea = 0

        'Abd Add Opp Puanları
        intKadd = 0
        intKabd = 0
        intKopp = 0


        intIfFleksEksKombine = 0
        intMkfFleksEksKombine = 0
        intKombineROMPuani = 0


        intLokalOzurlulukPuani = 0

        strParmakLokalRapor = ""
        strFinalOzetRapor = ""


        '/////////////////////////////////RESET COMPLETE


        Dim Newline As String
        Newline = System.Environment.NewLine

        '*************************************************************************************************************************
        '**************************LISTE LOAD*************************************************************************************
        '*************************************************************************************************************************
        'Arrayların Listeler Halinde Görüntülenmesi

        EnableAndPopulateList(listboxIfFleks, arrayIfFleksEks, 0)
        EnableAndPopulateList(listboxIfEks, arrayIfFleksEks, 2)

        EnableAndPopulateList(listboxMkfFleks, arrayMkfFleksEks, 0)
        EnableAndPopulateList(listboxMkfEks, arrayMkfFleksEks, 2)

        EnableAndPopulateList(listBoxAddMesafesi, arrayAddKaybi, 0)
        EnableAndPopulateList(listboxAbdAcisi, arrayAbdKaybi, 0)
        EnableAndPopulateList(listboxOppMesafesi, arrayOppKaybi, 0)

        EnableAndPopulateList(listboxIfSislik, arrayEklemdeSislik, 0)
        EnableAndPopulateList(listBoxIfİnstabilite, arrayEklemdeInstabilite, 0)
        EnableAndPopulateList(listboxIfSubluksasyon, arrayEklemdeSubluksasyon, 0)

        EnableAndPopulateList(listboxMkfSislik, arrayEklemdeSislik, 0)
        EnableAndPopulateList(listBoxMkfİnstabilite, arrayEklemdeInstabilite, 0)
        EnableAndPopulateList(listboxMkfSubluksasyon, arrayEklemdeSubluksasyon, 0)



        EnableAndPopulateList(listboxParmakDeformite, arrayParmaktaDeformite, 0)
        EnableAndPopulateList(listboxParmakTenosinovit, arrayParmaktaTenosinovit, 0)
        '*************************************************************************************************************************
        '**************************LISTE LOAD BITTI*******************************************************************************
        '*************************************************************************************************************************


        ''HOUSE KEEPING
        groupboxİF.Enabled = True
        groupboxMKF.Enabled = True
        groupboxAdd.Enabled = True
        groupBoxAbd.Enabled = True
        groupboxOpp.Enabled = True

        listboxIfFleks.SetSelected(0, True)
        listboxIfEks.SetSelected(0, True)
        listboxMkfFleks.SetSelected(0, True)
        listboxMkfEks.SetSelected(0, True)

        listBoxAddMesafesi.SetSelected(0, True)
        listboxAbdAcisi.SetSelected(0, True)
        listboxOppMesafesi.SetSelected(0, True)

        listboxIfSislik.SetSelected(0, True)
        listBoxIfİnstabilite.SetSelected(0, True)
        listboxIfSubluksasyon.SetSelected(0, True)

        listboxMkfSislik.SetSelected(0, True)
        listBoxMkfİnstabilite.SetSelected(0, True)
        listboxMkfSubluksasyon.SetSelected(0, True)

        listboxParmakTenosinovit.SetSelected(0, True)
        listboxParmakDeformite.SetSelected(0, True)



        rbifFleksEksAnkYok.Checked = True
        rbMkfFleksEksAnkYok.Checked = True
        rbAddHKVar.Checked = True
        rbAbdHKVar.Checked = True
        rbOppHKVar.Checked = True





        lblResult.Text = intLokalOzurlulukPuani
        textboxLokalRapor.Text = ""

    End Sub


    '*************************************************************************************************************************
    '**************************RADIO BUTTON DONGUSU **************************************************************************
    '*************************************************************************************************************************

    'FLEKSIYON EKSTANSIYON ICIN DONGU






    Private Sub IfRadioButtonUpdate()
        'FLEKSIYON EKSTANSİYON ANKİLOZ UPDATE
        listboxIfFleksEksAnk.Items.Clear()

        If rbifFleksEksAnkYok.Checked Then

            DisableAndClearList(listboxIfFleksEksAnk)
            EnableAndPopulateList(listboxIfFleks, arrayIfFleksEks, 0)
            EnableAndPopulateList(listboxIfEks, arrayIfFleksEks, 2)

            listboxIfFleks.SetSelected(0, True)
            listboxIfEks.SetSelected(0, True)


            intIfKfea = 0

            lblD1IFKf.Text = updateDisabilityValue(listboxIfFleks, arrayIfFleksEks, 1)
            lblD1IFKe.Text = updateDisabilityValue(listboxIfEks, arrayIfFleksEks, 3)
            lblD1IFKfea.Text = intIfKfea

        End If

        If rbifFleksAnkVar.Checked Then

            DisableAndClearList(listboxIfFleks)
            DisableAndClearList(listboxIfEks)
            EnableAndPopulateList(listboxIfFleksEksAnk, arrayIfFleksAnkilozu, 0)

            listboxIfFleksEksAnk.SetSelected(0, True)
            intIfKfea = updateDisabilityValue(listboxIfFleksEksAnk, arrayIfFleksAnkilozu, 1)

            intIfKf = 0
            intIfKe = 0



            lblD1IFKf.Text = intIfKf
            lblD1IFKe.Text = intIfKe
            lblD1IFKfea.Text = intIfKfea


        End If

        If rbifEksAnkVar.Checked Then

            DisableAndClearList(listboxIfFleks)
            DisableAndClearList(listboxIfEks)
            EnableAndPopulateList(listboxIfFleksEksAnk, arrayIfEksAnkilozu, 0)

            listboxIfFleksEksAnk.SetSelected(0, True)
            intIfKfea = updateDisabilityValue(listboxIfFleksEksAnk, arrayIfEksAnkilozu, 1)

            intIfKf = 0
            intIfKe = 0



            lblD1IFKf.Text = intIfKf
            lblD1IFKe.Text = intIfKe
            lblD1IFKfea.Text = intIfKfea


        End If
    End Sub






    Private Sub MkfRadioButtonUpdate()
        If rbMkfFleksEksAnkYok.Checked Then


            DisableAndClearList(listboxMkfFleksEksAnk)
            EnableAndPopulateList(listboxMkfFleks, arrayMkfFleksEks, 0)
            EnableAndPopulateList(listboxMkfEks, arrayMkfFleksEks, 2)

            listboxMkfFleks.SetSelected(0, True)
            listboxMkfEks.SetSelected(0, True)

            intMkfKea = 0

            lblD1MKFKf.Text = updateDisabilityValue(listboxMkfFleks, arrayMkfFleksEks, 1)
            lblD1MkfKe.Text = updateDisabilityValue(listboxMkfEks, arrayMkfFleksEks, 3)

            lblD1MkfKfea.Text = intMkfKea

        End If

        If rbMkfFleksAnkVar.Checked Then

            DisableAndClearList(listboxMkfFleks)
            DisableAndClearList(listboxMkfEks)
            EnableAndPopulateList(listboxMkfFleksEksAnk, arrayMkfFleksAnk, 0)

            listboxMkfFleksEksAnk.SetSelected(0, True)
            intMkfKea = updateDisabilityValue(listboxMkfFleksEksAnk, arrayMkfFleksAnk, 1)

            intMkfKf = 0
            intMkfKe = 0


            lblD1MKFKf.Text = intMkfKf
            lblD1MkfKe.Text = intMkfKe
            lblD1MkfKfea.Text = intMkfKea

        End If

        If rbMkfEksAnkVar.Checked Then

            DisableAndClearList(listboxMkfFleks)
            DisableAndClearList(listboxMkfEks)
            EnableAndPopulateList(listboxMkfFleksEksAnk, arrayMkfEksAnk, 0)

            listboxMkfFleksEksAnk.SetSelected(0, True)
            intMkfKea = updateDisabilityValue(listboxMkfFleksEksAnk, arrayMkfEksAnk, 1)

            intMkfKf = 0
            intMkfKe = 0


            lblD1MKFKf.Text = intMkfKf
            lblD1MkfKe.Text = intMkfKe
            lblD1MkfKfea.Text = intMkfKe

        End If
    End Sub




    '////////////////////////////////////////////////RADIOBUTTON DONGUSU BITTI//////////////////////////////////////////////


    '***************************************************LİSTE LABEL GÜNCELLEME************************************************

    'LİSTELERİN LABELLERİNİN GÜNCELLENMESİ

    'Fleksiyon Ekstansiyon Label Güncellemesi

    Private Sub listboxElBilegiFleks_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listboxIfFleks.SelectedIndexChanged
        Dim typeofROM As Integer
        typeofROM = 1
        If booleanThereIsError = False Then
            checkUserCorrectInput(listboxIfFleks, listboxIfEks, typeofROM)
        End If
        booleanThereIsError = False


        intIfKf = updateDisabilityValue(listboxIfFleks, arrayIfFleksEks, 1)



        lblD1IFKf.Text = intIfKf


    End Sub

    Private Sub listboxElBilegiEkstansiyon_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listboxIfEks.SelectedIndexChanged
        Dim typeofROM As Integer
        typeofROM = 1
        If booleanThereIsError = False Then
            checkUserCorrectInput(listboxIfFleks, listboxIfEks, typeofROM)
        End If
        booleanThereIsError = False
        intIfKe = updateDisabilityValue(listboxIfEks, arrayIfFleksEks, 3)

        lblD1IFKe.Text = intIfKe
    End Sub

    Private Sub listboxElBilegiFEAnkiloz_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listboxIfFleksEksAnk.SelectedIndexChanged

        If rbifFleksAnkVar.Checked Then
            intIfKfea = updateDisabilityValue(listboxIfFleksEksAnk, arrayIfFleksAnkilozu, 1)

        End If

        If rbifEksAnkVar.Checked Then
            intIfKfea = updateDisabilityValue(listboxIfFleksEksAnk, arrayIfEksAnkilozu, 1)

        End If

        lblD1IFKfea.Text = intIfKfea

    End Sub

    'Mkf Eklem
    Private Sub listboxMkfFleks_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listboxMkfFleks.SelectedIndexChanged
        Dim typeofROM As Integer
        typeofROM = 1
        If booleanThereIsError = False Then
            checkUserCorrectInput(listboxMkfFleks, listboxMkfEks, typeofROM)
        End If
        booleanThereIsError = False

        intMkfKf = updateDisabilityValue(listboxMkfFleks, arrayMkfFleksEks, 1)

        lblD1MKFKf.Text = intMkfKf
    End Sub

    Private Sub listboxMkfEks_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listboxMkfEks.SelectedIndexChanged
        Dim typeofROM As Integer
        typeofROM = 1
        If booleanThereIsError = False Then
            checkUserCorrectInput(listboxMkfFleks, listboxMkfEks, typeofROM)
        End If
        booleanThereIsError = False

        intMkfKe = updateDisabilityValue(listboxMkfEks, arrayMkfFleksEks, 3)

        lblD1MkfKe.Text = intMkfKe
    End Sub
    Private Sub listboxMkfFleksEksAnk_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listboxMkfFleksEksAnk.SelectedIndexChanged
        If rbMkfFleksAnkVar.Checked Then
            intMkfKea = updateDisabilityValue(listboxIfFleksEksAnk, arrayIfFleksAnkilozu, 1)

        End If

        If rbMkfEksAnkVar.Checked Then
            intMkfKea = updateDisabilityValue(listboxIfFleksEksAnk, arrayIfEksAnkilozu, 1)

        End If

        lblD1MkfKfea.Text = intMkfKea

    End Sub


    Private Sub listBoxAddMesafesi_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listBoxAddMesafesi.SelectedIndexChanged
        If rbAddHKVar.Checked Then
            intKadd = updateDisabilityValue(listBoxAddMesafesi, arrayAddKaybi, 1)
        ElseIf rbAddAnkVar.Checked Then
            intKadd = updateDisabilityValue(listBoxAddMesafesi, arrayAddKaybi, 2)
        End If

        lblKadd.Text = intKadd
    End Sub

    Private Sub listboxAbdAcisi_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listboxAbdAcisi.SelectedIndexChanged
        If rbAbdHKVar.Checked Then
            intKabd = updateDisabilityValue(listboxAbdAcisi, arrayAbdKaybi, 1)
        ElseIf rbAbdAnkVar.Checked Then
            intKabd = updateDisabilityValue(listboxAbdAcisi, arrayAbdKaybi, 2)
        End If

        lblKabd.Text = intKabd
    End Sub

    Private Sub listboxOppMesafesi_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listboxOppMesafesi.SelectedIndexChanged
        If rbOppHKVar.Checked Then
            intKopp = updateDisabilityValue(listboxOppMesafesi, arrayOppKaybi, 1)
        ElseIf rbOppAnkVar.Checked Then
            intKopp = updateDisabilityValue(listboxOppMesafesi, arrayOppKaybi, 2)
        End If

        lblKopp.Text = intKopp
    End Sub



    '////////////////////////////////////////////////LİSTE LABEL GÜNCELLEMESİ BÖLÜMÜ BİTTİ//////////////////////////////////////////////


    '**************************İŞLEMLER BÖLÜMÜ********************************************************************************


    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click


        Form_Reset()




    End Sub

    Public Sub Form_Reset()
        groupboxİF.Enabled = True
        groupboxMKF.Enabled = True
        groupboxAdd.Enabled = True
        groupBoxAbd.Enabled = True
        groupboxOpp.Enabled = True




        rbSeviyeIf.Checked = False
        rbSeviyeMkf.Checked = False

        D1_Load()

    End Sub


    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click

        intIfFleksEksKombine = 0
        intMkfFleksEksKombine = 0
        intKombineROMPuani = 0
        intLokalOzurlulukPuani = 0


        listboxFinalOzet.Items.Clear()
        listboxIF.Items.Clear()
        listboxMKF.Items.Clear()

        Raporla()


        '////////////////////BAŞPARMAĞIN ÖZEL HESAPLAMASI, EKLEMLER TOPLANIYOR KOMBİNE EDİLMİYOR///////////////////////////////

        '*****************önce eklemler kendi içinde baltazarlanır**********************************
        Dim intIFOzet As Integer
        Dim intMKFOzet As Integer
        Dim intIFveMKFToplam

        Dim listIfOzet As New List(Of Integer)
        intIFOzet = Calc(listboxIF, listIfOzet)


        Dim listMkfOzet As New List(Of Integer)
        intMKFOzet = Calc(listboxMKF, listMkfOzet)


        intIFveMKFToplam = intIFOzet + intMKFOzet
        If intIFveMKFToplam > 100 Then
            intIFveMKFToplam = 100
        End If
        listboxFinalOzet.Items.Add(intIFveMKFToplam)


        Dim listFinalOzet As New List(Of Integer)

        intLokalOzurlulukPuani = Calc(listboxFinalOzet, listFinalOzet)

        lblResult.Text = intLokalOzurlulukPuani

        If intLokalOzurlulukPuani > 0 Then
            btnSaveExit.Enabled = True
        End If

        If leftside = True Then
            intD1FinalLeft = intLokalOzurlulukPuani
        Else
            intD1FinalRight = intLokalOzurlulukPuani
        End If




        '//////////////////////////////////////////////////////////////////////////////////////////////////////
    End Sub

    Private Sub Raporla()


        Dim Newline As String
        Newline = System.Environment.NewLine
        strParmakLokalRapor = "***D1*** " + Newline
        strParmakIF = ""

        strParmakMKF = ""
        strParmakSorunları = ""
        strParmakAmputasyon = ""



        'AMPUTASYON CHECK

        If rbSeviyeIf.Checked = False And rbSeviyeMkf.Checked = False Then
            intAmputasyonSkoru = 0

        ElseIf rbSeviyeIf.Checked Then
            intAmputasyonSkoru = 50
        ElseIf rbSeviyeMkf.Checked Then
            intAmputasyonSkoru = 100

        End If
        listboxFinalOzet.Items.Add(intAmputasyonSkoru)

        '**********Amputasyon skorunu raporla 

        strParmakAmputasyon = "       " + "Amputasyon nedeniyle " + Conversion.Str(intAmputasyonSkoru)
        '/////////////////////////////////////////////////////////////////////////////////////////////

        '******************************************ROMDAN GELEN TABLO 2.1***********************************





        'IF İÇİN HESAPLAMA**************************************************************************************************
        'Fleksiyon-Ekstansiyon-Ankiloz Hesaplaması ve Raporlaması
        If rbifFleksEksAnkYok.Checked Then

            intIfFleksEksKombine = intIfKf + intIfKe

        End If

        If rbifFleksAnkVar.Checked Or rbifEksAnkVar.Checked Then

            intIfFleksEksKombine = intIfKfea

        End If



        'IfEklemSorunlarıCheck
        If intIfFleksEksKombine > 0 Then

            listboxIF.Items.Add(intIfFleksEksKombine)
            strParmakIF = strParmakIF + "         " + "Eklem hareketinden " + Conversion.Str(intIfFleksEksKombine) + Newline

        End If


        If listboxIfSislik.SelectedIndex > 0 Then


            listboxIF.Items.Add(arrayEklemdeSislik(listboxIfSislik.SelectedIndex, 1))
            strParmakIF = strParmakIF + "         " + "Şişlik nedeniyle" + Conversion.Str(arrayEklemdeSislik(listboxIfSislik.SelectedIndex, 1)) + Newline


        End If

        If listBoxIfİnstabilite.SelectedIndex > 0 Then

            listboxIF.Items.Add(arrayEklemdeInstabilite(listBoxIfİnstabilite.SelectedIndex, 1))
            strParmakIF = strParmakIF + "         " + "İnstabilite nedeniyle" + Conversion.Str(arrayEklemdeInstabilite(listBoxIfİnstabilite.SelectedIndex, 1)) + Newline


        End If

        If listboxIfSubluksasyon.SelectedIndex > 0 Then

            listboxIF.Items.Add(arrayEklemdeSubluksasyon(listboxIfSubluksasyon.SelectedIndex, 1))
            strParmakIF = strParmakIF + "         " + "Subluksasyon nedeniyle" + Conversion.Str(arrayEklemdeSubluksasyon(listboxIfSubluksasyon.SelectedIndex, 1)) + Newline


        End If

        '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////



        'MKF İÇİN HESAPLAMA******************************************************************************************************
        'Fleksiyon-Ekstansiyon-Ankiloz Hesaplaması ve Raporlaması


        If rbMkfFleksEksAnkYok.Checked Then

            intMkfFleksEksKombine = intMkfKf + intMkfKe

        End If

        If rbMkfFleksAnkVar.Checked Or rbMkfEksAnkVar.Checked Then

            intMkfFleksEksKombine = intMkfKea

        End If


        'MkfEklemSorunlarıCheck
        If intMkfFleksEksKombine > 0 Then

            strParmakMKF = strParmakMKF + "         " + "Eklem hareketinden " + Conversion.Str(intMkfFleksEksKombine) + Newline + Newline

        End If


        If listboxMkfSislik.SelectedIndex > 0 Then


            listboxMKF.Items.Add(arrayEklemdeSislik(listboxMkfSislik.SelectedIndex, 1))
            strParmakMKF = strParmakMKF + "         " + "Şişlik nedeniyle" + Conversion.Str(arrayEklemdeSislik(listboxMkfSislik.SelectedIndex, 1)) + Newline


        End If

        If listBoxMkfİnstabilite.SelectedIndex > 0 Then


            listboxMKF.Items.Add(arrayEklemdeInstabilite(listBoxMkfİnstabilite.SelectedIndex, 1))
            strParmakMKF = strParmakMKF + "         " + "İnstabilite nedeniyle" + Conversion.Str(arrayEklemdeInstabilite(listBoxMkfİnstabilite.SelectedIndex, 1)) + Newline


        End If

        If listboxMkfSubluksasyon.SelectedIndex > 0 Then


            listboxMKF.Items.Add(arrayEklemdeSubluksasyon(listboxMkfSubluksasyon.SelectedIndex, 1))
            strParmakMKF = strParmakMKF + "         " + "Subluksasyon nedeniyle" + Conversion.Str(arrayEklemdeSubluksasyon(listboxMkfSubluksasyon.SelectedIndex, 1)) + Newline


        End If

        listboxMKF.Items.Add(intKadd + intKabd + intKopp + intMkfFleksEksKombine)









        '*************Parmak skorunu raporla ve özet listeye ekle
        If listboxParmakDeformite.SelectedIndex > 0 Then


            listboxFinalOzet.Items.Add(arrayParmaktaDeformite(listboxParmakDeformite.SelectedIndex, 1))
            strParmakSorunları = strParmakSorunları + "         " + "Açısal deformite nedeniyle" + Conversion.Str(arrayParmaktaDeformite(listboxParmakDeformite.SelectedIndex, 1)) + Newline


        End If

        If listboxParmakTenosinovit.SelectedIndex > 0 Then


            listboxFinalOzet.Items.Add(arrayParmaktaTenosinovit(listboxParmakTenosinovit.SelectedIndex, 1))
            strParmakSorunları = strParmakSorunları + "         " + "Tenosinovit nedeniyle" + Conversion.Str(arrayParmaktaTenosinovit(listboxParmakTenosinovit.SelectedIndex, 1)) + Newline


        End If
        '**************************************************************************************************








        strParmakLokalRapor = strParmakLokalRapor + "       " + "IF: " + Newline + strParmakIF + Newline

        strParmakLokalRapor = strParmakLokalRapor + "       " + "MKF: " + Newline + strParmakMKF + Newline

        strParmakLokalRapor = strParmakLokalRapor + "       " + "Parmak Sorunları" + Newline + strParmakSorunları

        strParmakLokalRapor = strParmakLokalRapor + Newline + strParmakAmputasyon







        textboxLokalRapor.Text = strParmakLokalRapor
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Anasayfa.Enabled = True
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnSaveExit.Click
        If leftside = True Then
            intD1FinalLeft = intLokalOzurlulukPuani
            strD1RaporFinalLeft = strParmakLokalRapor
        Else
            intD1FinalRight = intLokalOzurlulukPuani
            strD1RaporFinalRight = strParmakLokalRapor
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



    Private Sub btnSeviyeIf_CheckedChanged(sender As Object, e As EventArgs) Handles rbSeviyeIf.CheckedChanged
        DisableAndClearList(listboxIfFleks)
        DisableAndClearList(listboxIfEks)
        DisableAndClearList(listboxIfFleksEksAnk)
        DisableAndClearList(listboxIfSislik)
        DisableAndClearList(listBoxIfİnstabilite)
        DisableAndClearList(listboxIfSubluksasyon)
        groupboxİF.Enabled = False

        intIfKf = 0
        intIfKe = 0
        intIfKfea = 0



        EnableAndPopulateList(listboxMkfFleks, arrayMkfFleksEks, 0)
        EnableAndPopulateList(listboxMkfEks, arrayMkfFleksEks, 2)
        EnableAndPopulateList(listboxMkfSislik, arrayEklemdeSislik, 0)
        EnableAndPopulateList(listBoxMkfİnstabilite, arrayEklemdeInstabilite, 0)
        EnableAndPopulateList(listboxMkfSubluksasyon, arrayEklemdeSubluksasyon, 0)
        groupboxMKF.Enabled = True

        intMkfKe = 0
        intMkfKea = 0
        intMkfKf = 0

        EnableAndPopulateList(listBoxAddMesafesi, arrayAddKaybi, 0)
        EnableAndPopulateList(listboxAbdAcisi, arrayAbdKaybi, 0)
        EnableAndPopulateList(listboxOppMesafesi, arrayOppKaybi, 0)

        groupboxAdd.Enabled = True
        groupBoxAbd.Enabled = True
        groupboxOpp.Enabled = True

    End Sub

    Private Sub btnSeviyeMkf_CheckedChanged(sender As Object, e As EventArgs) Handles rbSeviyeMkf.CheckedChanged
        DisableAndClearList(listboxIfFleks)
        DisableAndClearList(listboxIfEks)
        DisableAndClearList(listboxIfFleksEksAnk)
        DisableAndClearList(listboxIfSislik)
        DisableAndClearList(listBoxIfİnstabilite)
        DisableAndClearList(listboxIfSubluksasyon)


        groupboxİF.Enabled = False

        intIfKf = 0
        intIfKe = 0
        intIfKfea = 0

        DisableAndClearList(listboxMkfFleks)
        DisableAndClearList(listboxMkfEks)
        DisableAndClearList(listboxMkfFleksEksAnk)
        DisableAndClearList(listboxMkfSislik)
        DisableAndClearList(listBoxMkfİnstabilite)
        DisableAndClearList(listboxMkfSubluksasyon)
        groupboxMKF.Enabled = False

        intMkfKf = 0
        intMkfKe = 0
        intMkfKea = 0

        DisableAndClearList(listboxParmakDeformite)
        DisableAndClearList(listboxParmakTenosinovit)



        DisableAndClearList(listBoxAddMesafesi)
        DisableAndClearList(listboxAbdAcisi)
        DisableAndClearList(listboxOppMesafesi)
    End Sub




    Private Sub AddRadioButtonUpdate()



        If rbAddHKVar.Checked Then

            EnableAndPopulateList(listBoxAddMesafesi, arrayAddKaybi, 0)
            listBoxAddMesafesi.SetSelected(0, True)
            intKadd = updateDisabilityValue(listBoxAddMesafesi, arrayAddKaybi, 1)
            lblKadd.Text = intKadd

        End If
        If rbAddAnkVar.Checked Then
            EnableAndPopulateList(listBoxAddMesafesi, arrayAddKaybi, 0)
            listBoxAddMesafesi.SetSelected(0, True)
            intKadd = updateDisabilityValue(listBoxAddMesafesi, arrayAddKaybi, 2)
            lblKadd.Text = intKadd
        End If
    End Sub

    Private Sub AbdRadioButtonUpdate()
        If rbAbdHKVar.Checked Then

            EnableAndPopulateList(listboxAbdAcisi, arrayAbdKaybi, 0)
            listboxAbdAcisi.SetSelected(0, True)
            intKabd = updateDisabilityValue(listboxAbdAcisi, arrayAbdKaybi, 1)
            lblKabd.Text = intKabd
        End If
        If rbAbdAnkVar.Checked Then
            EnableAndPopulateList(listboxAbdAcisi, arrayAbdKaybi, 0)
            listboxAbdAcisi.SetSelected(0, True)
            intKabd = updateDisabilityValue(listboxAbdAcisi, arrayAbdKaybi, 2)
            lblKabd.Text = intKabd
        End If

    End Sub


    Private Sub OppRadioButtonUpdate()
        If rbOppHKVar.Checked Then
            EnableAndPopulateList(listboxOppMesafesi, arrayOppKaybi, 0)
            listboxOppMesafesi.SetSelected(0, True)

            intKopp = updateDisabilityValue(listboxOppMesafesi, arrayOppKaybi, 1)
            lblKopp.Text = intKopp
        End If


        If rbAddAnkVar.Checked Then
            EnableAndPopulateList(listboxOppMesafesi, arrayOppKaybi, 0)
            listboxOppMesafesi.SetSelected(0, True)

            intKopp = updateDisabilityValue(listboxOppMesafesi, arrayOppKaybi, 2)
            lblKopp.Text = intKopp
        End If
    End Sub

    Private Sub rbAddHKVar_CheckedChanged(sender As Object, e As EventArgs) Handles rbAddHKVar.CheckedChanged
        AddRadioButtonUpdate()
    End Sub

    Private Sub rbAddAnkVar_CheckedChanged(sender As Object, e As EventArgs) Handles rbAddAnkVar.CheckedChanged
        AddRadioButtonUpdate()
    End Sub

    Private Sub rbMkfFleksEksAnkYok_CheckedChanged(sender As Object, e As EventArgs) Handles rbMkfFleksEksAnkYok.CheckedChanged
        MkfRadioButtonUpdate()
    End Sub

    Private Sub rbMkfFleksAnkVar_CheckedChanged(sender As Object, e As EventArgs) Handles rbMkfFleksAnkVar.CheckedChanged
        MkfRadioButtonUpdate()
    End Sub

    Private Sub rbMkfEksAnkVar_CheckedChanged(sender As Object, e As EventArgs) Handles rbMkfEksAnkVar.CheckedChanged
        MkfRadioButtonUpdate()
    End Sub

    Private Sub rbifFleksEksAnkYok_CheckedChanged(sender As Object, e As EventArgs) Handles rbifFleksEksAnkYok.CheckedChanged
        IfRadioButtonUpdate()

    End Sub

    Private Sub rbifFleksAnkVar_CheckedChanged(sender As Object, e As EventArgs) Handles rbifFleksAnkVar.CheckedChanged
        IfRadioButtonUpdate()

    End Sub

    Private Sub rbifEksAnkVar_CheckedChanged(sender As Object, e As EventArgs) Handles rbifEksAnkVar.CheckedChanged
        IfRadioButtonUpdate()

    End Sub

    Private Sub rbAbdHKVar_CheckedChanged(sender As Object, e As EventArgs) Handles rbAbdHKVar.CheckedChanged
        AbdRadioButtonUpdate()
    End Sub

    Private Sub rbAbdAnkVar_CheckedChanged(sender As Object, e As EventArgs) Handles rbAbdAnkVar.CheckedChanged
        AbdRadioButtonUpdate()
    End Sub

    Private Sub rbOppHKVar_CheckedChanged(sender As Object, e As EventArgs) Handles rbOppHKVar.CheckedChanged
        OppRadioButtonUpdate()
    End Sub

    Private Sub rbOppAnkVar_CheckedChanged(sender As Object, e As EventArgs) Handles rbOppAnkVar.CheckedChanged
        OppRadioButtonUpdate()
    End Sub

    Private Sub GroupBox12_Enter(sender As Object, e As EventArgs) Handles GroupBox12.Enter

    End Sub


    '/////////////////////////////////////////İŞLEMLER BÖLÜMÜ BİTTİ//////////////////////////////////////////////////////////////////////////



    '////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
End Class