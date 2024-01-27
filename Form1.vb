Imports System.IO
Imports UpperExtremityModule.Universal



Public Class Anasayfa
    Dim LeftArtroplasti As New artroplasti()
    Dim LeftAmputasyon As New Amputasyon()
    Dim LeftPeriferik As New PeriferikSinir()
    Dim LeftOmuz As New Omuz()
    Dim LeftElbow As New DirsekV2()
    Dim LeftWrist As New ElBilegi()
    Dim LeftD1 As New D1()
    Dim LeftD2 As New D2()
    Dim LeftD3 As New D3()
    Dim LeftD4 As New D4()
    Dim LeftD5 As New D5()

    Dim RightArtroplasti As New artroplasti()
    Dim RightAmputasyon As New Amputasyon()
    Dim RightPeriferik As New PeriferikSinir()
    Dim RightOmuz As New Omuz()
    Dim RightElbow As New DirsekV2()
    Dim RightWrist As New ElBilegi()
    Dim RightD1 As New D1()
    Dim RightD2 As New D2()
    Dim RightD3 As New D3()
    Dim RightD4 As New D4()
    Dim RightD5 As New D5()

    Dim intElOnToplamLeft As Integer
    Dim intElOnToplamRight As Integer
    Dim strUltimateRaporLeft As String
    Dim strUltimateRaporRight As String

    'En son özet üst ekstremite özürlülük listboxunu oluştur

    'Tablo2nokta1 array

    Dim arrayParmaktanEle(,) As String = {
        {0, 0, 0, 0, 0, 0},
        {1, 0, 1, 0, 1, 0},
        {2, 1, 2, 0, 2, 0},
        {3, 1, 3, 1, 3, 0},
        {4, 2, 4, 1, 4, 0},
        {5, 2, 5, 1, 5, 1},
        {6, 2, 6, 1, 6, 1},
        {7, 3, 7, 1, 7, 1},
        {8, 3, 8, 2, 8, 1},
        {9, 4, 9, 2, 9, 1},
        {10, 4, 10, 2, 10, 1},
        {11, 4, 11, 2, 11, 1},
        {12, 5, 12, 2, 12, 1},
        {13, 5, 13, 3, 13, 1},
        {14, 6, 14, 3, 14, 1},
        {15, 6, 15, 3, 15, 2},
        {16, 6, 16, 3, 16, 2},
        {17, 7, 17, 3, 17, 2},
        {18, 7, 18, 4, 18, 2},
        {19, 8, 19, 4, 19, 2},
        {20, 8, 20, 4, 20, 2},
        {21, 8, 21, 4, 21, 2},
        {22, 9, 22, 4, 22, 2},
        {23, 9, 23, 5, 23, 2},
        {24, 10, 24, 5, 24, 2},
        {25, 10, 25, 5, 25, 3},
        {26, 10, 26, 5, 26, 3},
        {27, 11, 27, 5, 27, 3},
        {28, 11, 28, 6, 28, 3},
        {29, 12, 29, 6, 29, 3},
        {30, 12, 30, 6, 30, 3},
        {31, 12, 31, 6, 31, 3},
        {32, 13, 32, 6, 32, 3},
        {33, 13, 33, 7, 33, 3},
        {34, 14, 34, 7, 34, 3},
        {35, 14, 35, 7, 35, 4},
        {36, 14, 36, 7, 36, 4},
        {37, 15, 37, 7, 37, 4},
        {38, 15, 38, 8, 38, 4},
        {39, 16, 39, 8, 39, 4},
        {40, 16, 40, 8, 40, 4},
        {41, 16, 41, 8, 41, 4},
        {42, 17, 42, 8, 42, 4},
        {43, 17, 43, 9, 43, 4},
        {44, 18, 44, 9, 44, 4},
        {45, 18, 45, 9, 45, 5},
        {46, 18, 46, 9, 46, 5},
        {47, 19, 47, 9, 47, 5},
        {48, 19, 48, 10, 48, 5},
        {49, 20, 49, 10, 49, 5},
        {50, 20, 50, 10, 50, 5},
        {51, 20, 51, 10, 51, 5},
        {52, 21, 52, 10, 52, 5},
        {53, 21, 53, 11, 53, 5},
        {54, 22, 54, 11, 54, 5},
        {55, 22, 55, 11, 55, 6},
        {56, 22, 56, 11, 56, 6},
        {57, 23, 57, 11, 57, 6},
        {58, 23, 58, 12, 58, 6},
        {59, 24, 59, 12, 59, 6},
        {60, 24, 60, 12, 60, 6},
        {61, 24, 61, 12, 61, 6},
        {62, 25, 62, 12, 62, 6},
        {63, 25, 63, 13, 63, 6},
        {64, 26, 64, 13, 64, 6},
        {65, 26, 65, 13, 65, 7},
        {66, 26, 66, 13, 66, 7},
        {67, 27, 67, 13, 67, 7},
        {68, 27, 68, 14, 68, 7},
        {69, 28, 69, 14, 69, 7},
        {70, 28, 70, 14, 70, 7},
        {71, 28, 71, 14, 71, 7},
        {72, 29, 72, 14, 72, 7},
        {73, 29, 73, 15, 73, 7},
        {74, 30, 74, 15, 74, 7},
        {75, 30, 75, 15, 75, 8},
        {76, 30, 76, 15, 76, 8},
        {77, 31, 77, 15, 77, 8},
        {78, 31, 78, 16, 78, 8},
        {79, 32, 79, 16, 79, 8},
        {80, 32, 80, 16, 80, 8},
        {81, 32, 81, 16, 81, 8},
        {82, 33, 82, 16, 82, 8},
        {83, 33, 83, 17, 83, 8},
        {84, 34, 84, 17, 84, 8},
        {85, 34, 85, 17, 85, 9},
        {86, 34, 86, 17, 86, 9},
        {87, 35, 87, 17, 87, 9},
        {88, 35, 88, 18, 88, 9},
        {89, 36, 89, 18, 89, 9},
        {90, 36, 90, 18, 90, 9},
        {91, 36, 91, 18, 91, 9},
        {92, 37, 92, 18, 92, 9},
        {93, 37, 93, 19, 93, 9},
        {94, 38, 94, 19, 94, 9},
        {95, 38, 95, 19, 95, 10},
        {96, 38, 96, 19, 96, 10},
        {97, 39, 97, 19, 97, 10},
        {98, 39, 98, 20, 98, 10},
        {99, 40, 99, 20, 99, 10},
        {100, 40, 100, 20, 100, 10}}



    ' Tablo2nokta2 Array
    Dim arrayEldenUste(,) As String = {
        {0, 0},
        {1, 1},
        {2, 2},
        {3, 3},
        {4, 4},
        {5, 5},
        {6, 5},
        {7, 6},
        {8, 7},
        {9, 8},
        {10, 9},
        {11, 10},
        {12, 11},
        {13, 12},
        {14, 13},
        {15, 14},
        {16, 14},
        {17, 15},
        {18, 16},
        {19, 17},
        {20, 18},
        {21, 19},
        {22, 20},
        {23, 21},
        {24, 22},
        {25, 23},
        {26, 23},
        {27, 24},
        {28, 25},
        {29, 26},
        {30, 27},
        {31, 28},
        {32, 29},
        {33, 30},
        {34, 31},
        {35, 32},
        {36, 32},
        {37, 33},
        {38, 34},
        {39, 35},
        {40, 36},
        {41, 37},
        {42, 38},
        {43, 39},
        {44, 40},
        {45, 41},
        {46, 41},
        {47, 42},
        {48, 43},
        {49, 44},
        {50, 45},
        {51, 46},
        {52, 47},
        {53, 48},
        {54, 49},
        {55, 50},
        {56, 50},
        {57, 51},
        {58, 52},
        {59, 53},
        {60, 54},
        {61, 55},
        {62, 56},
        {63, 57},
        {64, 58},
        {65, 59},
        {66, 59},
        {67, 60},
        {68, 61},
        {69, 62},
        {70, 63},
        {71, 64},
        {72, 65},
        {73, 66},
        {74, 67},
        {75, 68},
        {76, 68},
        {77, 69},
        {78, 70},
        {79, 71},
        {80, 72},
        {81, 73},
        {82, 74},
        {83, 75},
        {84, 76},
        {85, 77},
        {86, 77},
        {87, 78},
        {88, 79},
        {89, 80},
        {90, 81},
        {91, 82},
        {92, 83},
        {93, 84},
        {94, 85},
        {95, 86},
        {96, 86},
        {97, 87},
        {98, 88},
        {99, 89},
        {100, 90}}


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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


        'House keeping
        ' Set the Enabled property of the label to False.
        UpdateLabelValues()

        DisableForms()


    End Sub

    Public Sub DisableForms()
        LeftArtroplasti.Enabled = False
        LeftArtroplasti.Visible = False

        RightArtroplasti.Enabled = False
        RightArtroplasti.Visible = False

        LeftOmuz.Enabled = False
        RightOmuz.Enabled = False
    End Sub




    Private Sub UpdateLabelValues()
        ' Set the value of all labels in the GroupBoxLeft group.

        'INDEPENDENT LABELLARI RESETLE**************************************************

        'SOL TARAF*******************
        lblArtroplastiLeft.Text = intArtroplastiFinalLeft
        lblAmputasyonLeft.Text = intAmputasyonFinalLeft
        lblPeriferikSinirLeft.Text = intPeriferikSinirFinalLeft
        lblOmuzLeft.Text = intOmuzFinalLeft
        lblDirsekLeft.Text = intDirsekFinalLeft
        lblElBilegiLeft.Text = intElBilegiFinalLeft
        lblD1LeftFinger.Text = intD1FinalLeft
        lblD2LeftFinger.Text = intD2FinalLeft
        lblD3LeftFinger.Text = intD3FinalLeft
        lblD4LeftFinger.Text = intD4FinalLeft
        lblD5LeftFinger.Text = intD5FinalLeft
        '*****************************

        'SAĞ TARAF********************
        lblArtroplastiRight2.Text = intArtroplastiFinalRight
        lblAmputasyonRight2.Text = intAmputasyonFinalRight
        lblPeriferikRight2.Text = intPeriferikSinirFinalRight
        lblOmuzRight2.Text = intOmuzFinalRight
        lblDirsekRight2.Text = intDirsekFinalRight
        lblElBilegiRight2.Text = intElBilegiFinalRight
        lblD1RightFinger2.Text = intD1FinalRight
        lblD2RightFinger2.Text = intD2FinalRight
        lblD3RightFinger2.Text = intD3FinalRight
        lblD4RightFinger2.Text = intD4FinalRight
        lblD5RightFinger2.Text = intD5FinalRight
        '****************************



        '*******************************************************************************

        'DEPENDENT LABELLARI RESETLE****************************************************
        updateFingerHandandUEScores()
        UEOzetListeCikar()
        '*******************************************************************************


        lblParmak1.Text = "Parmak"
        lblParmak2.Text = "Parmak"
        lblHand1.Text = "El"
        lblHand2.Text = "El"

    End Sub
    Private Sub updateFingerHandandUEScores()


        'SOL UST EKSTREMİTE UPDATE *******************************************
        Dim intEl1Left As Integer
        Dim intEl2Left As Integer
        Dim intEl3Left As Integer
        Dim intEl4Left As Integer
        Dim intEl5Left As Integer

        intEl1Left = arrayParmaktanEle(intD1FinalLeft, 1)
        intEl2Left = arrayParmaktanEle(intD2FinalLeft, 3)
        intEl3Left = arrayParmaktanEle(intD3FinalLeft, 3)
        intEl4Left = arrayParmaktanEle(intD4FinalLeft, 5)
        intEl5Left = arrayParmaktanEle(intD5FinalLeft, 5)

        lblElD1Left.Text = intEl1Left
        lblElD2Left.Text = intEl2Left
        lblElD3Left.Text = intEl3Left
        lblElD4Left.Text = intEl4Left
        lblElD5Left.Text = intEl5Left

        intElOnToplamLeft = intEl1Left + intEl2Left + intEl3Left + intEl4Left + intEl5Left

        lblElOnToplamLeft.Text = intElOnToplamLeft

        'Elden üstü hesapla
        intElFinalLeft = arrayEldenUste(intElOnToplamLeft, 1)
        lblElToUstLeft.Text = intElFinalLeft

        lblElBilegiLeft.Text = intElBilegiFinalLeft
        lblDirsekLeft.Text = intDirsekFinalLeft
        lblOmuzLeft.Text = intOmuzFinalLeft
        lblArtroplastiLeft.Text = intArtroplastiFinalLeft
        lblAmputasyonLeft.Text = intAmputasyonFinalLeft
        lblPeriferikSinirLeft.Text = intPeriferikSinirFinalLeft
        '*********************************************************

        'SAĞ UST EKSTREMİTE UPDATE *******************************************
        Dim intEl1Right As Integer
        Dim intEl2Right As Integer
        Dim intEl3Right As Integer
        Dim intEl4Right As Integer
        Dim intEl5Right As Integer

        intEl1Right = arrayParmaktanEle(intD1FinalRight, 1)
        intEl2Right = arrayParmaktanEle(intD2FinalRight, 3)
        intEl3Right = arrayParmaktanEle(intD3FinalRight, 3)
        intEl4Right = arrayParmaktanEle(intD4FinalRight, 5)
        intEl5Right = arrayParmaktanEle(intD5FinalRight, 5)

        lblElD1Right2.Text = intEl1Right
        lblElD2Right2.Text = intEl2Right
        lblElD3Right2.Text = intEl3Right
        lblElD4Right2.Text = intEl4Right
        lblElD5Right2.Text = intEl5Right

        intElOnToplamRight = intEl1Right + intEl2Right + intEl3Right + intEl4Right + intEl5Right

        LabelRElFinal.Text = intElOnToplamRight

        'Elden üstü hesapla
        intElFinalRight = arrayEldenUste(intElOnToplamRight, 1)
        LabelREltoUstFinal.Text = intElFinalRight

        lblElBilegiRight.Text = intElBilegiFinalRight
        lblElbowRight.Text = intDirsekFinalRight
        lblOmuzRight.Text = intOmuzFinalRight
        lblArtroplastiRight.Text = intArtroplastiFinalRight
        lblAmputasyonRight.Text = intAmputasyonFinalRight
        lblPeriferikRight.Text = intPeriferikSinirFinalRight

        '*********************************************************



        lblFinalPersonal.Text = intPersonalDisability
        lblFinalUETotal.Text = intCombinedBothUEFinal

        txtUERaporAlani.Text = ""
        UEOzetListeCikar()

    End Sub


    Private Sub btnSaveExit_Click(sender As Object, e As EventArgs) Handles btnSaveExit.Click

        ' Create a save file dialog.
        Dim saveDialog As New SaveFileDialog()

        ' Set the default file name to the current timestamp.
        saveDialog.FileName = DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss")

        ' Set the default file extension to .txt.
        saveDialog.DefaultExt = "txt"

        ' Show the save file dialog.
        If saveDialog.ShowDialog() = DialogResult.OK Then
            ' Save the contents of the text box to the selected file.
            File.WriteAllText(saveDialog.FileName, txtUERaporAlani.Text)
        End If
    End Sub

    Private Sub btnArtroplasti_Click(sender As Object, e As EventArgs) Handles btnArtroplastiLeft.Click
        Me.Enabled = False
        leftside = True
        LeftArtroplasti.Enabled = True
        LeftArtroplasti.Show()
        LeftArtroplasti.BringToFront()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnArtroplastiRight.Click, btnArtroplastiRight2.Click
        Me.Enabled = False
        leftside = False
        RightArtroplasti.Enabled = True
        RightArtroplasti.Show()
        RightArtroplasti.BringToFront()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        LeftArtroplasti.Form_Reset()
        LeftAmputasyon.Form_Reset()
        LeftPeriferik.Form_Reset()
        LeftOmuz.Form_Reset()
        LeftElbow.Form_Reset()
        LeftWrist.Form_Reset()
        LeftD1.Form_Reset()
        LeftD2.Form_Reset()
        LeftD3.Form_Reset()
        LeftD4.Form_Reset()
        LeftD5.Form_Reset()


        RightArtroplasti.Form_Reset()
        RightAmputasyon.Form_Reset()
        RightPeriferik.Form_Reset()
        RightOmuz.Form_Reset()
        RightElbow.Form_Reset()
        RightWrist.Form_Reset()
        RightD1.Form_Reset()
        RightD2.Form_Reset()
        RightD3.Form_Reset()
        RightD4.Form_Reset()
        RightD5.Form_Reset()




        DisableForms()

        ListBoxOzetLeft.Items.Clear()
        ListBoxOzetRight.Items.Clear()


        intArtroplastiFinalLeft = 0
        intAmputasyonFinalLeft = 0
        intPeriferikSinirFinalLeft = 0
        intOmuzFinalLeft = 0
        intDirsekFinalLeft = 0
        intElBilegiFinalLeft = 0
        intD1FinalLeft = 0
        intD2FinalLeft = 0
        intD3FinalLeft = 0
        intD4FinalLeft = 0
        intD5FinalLeft = 0
        '*****************************

        'SAĞ TARAF********************
        intArtroplastiFinalRight = 0
        intAmputasyonFinalRight = 0
        intPeriferikSinirFinalRight = 0
        intOmuzFinalRight = 0
        intDirsekFinalRight = 0
        intElBilegiFinalRight = 0
        intD1FinalRight = 0
        intD2FinalRight = 0
        intD3FinalRight = 0
        intD4FinalRight = 0
        intD5FinalRight = 0

        intcombinedUELeft = 0
        intcombinedUERight = 0
        intCombinedBothUEFinal = 0
        intPersonalDisability = 0


        UpdateLabelValues()


    End Sub

    Private Sub btnOmuz_Click(sender As Object, e As EventArgs) Handles btnOmuzLeft.Click
        Me.Enabled = False
        leftside = True
        LeftOmuz.Enabled = True
        LeftOmuz.Show()
        LeftOmuz.BringToFront()
    End Sub

    Private Sub btnOmuzRight_Click(sender As Object, e As EventArgs) Handles btnOmuzRight.Click, Button5.Click
        Me.Enabled = False
        leftside = False
        RightOmuz.Enabled = True
        RightOmuz.Show()
        RightOmuz.BringToFront()
    End Sub

    Private Sub btnD1_Click(sender As Object, e As EventArgs) Handles btnD1Left.Click
        Me.Enabled = False
        leftside = True
        LeftD1.Enabled = True
        LeftD1.Show()
        LeftD1.BringToFront()
    End Sub

    Private Sub btnExitwithoutsave_Click(sender As Object, e As EventArgs) Handles btnExitwithoutsave.Click
        Application.Exit()
        End
    End Sub

    Private Sub Anasayfa_EnabledChanged(sender As Object, e As EventArgs) Handles MyBase.EnabledChanged
        ''Labelları update et
    End Sub

    Private Sub btnAmputasyonLeft_Click(sender As Object, e As EventArgs) Handles btnAmputasyonLeft.Click
        Me.Enabled = False
        leftside = True
        LeftAmputasyon.Enabled = True
        LeftAmputasyon.Show()
        LeftAmputasyon.BringToFront()
    End Sub

    Private Sub btnDirsekLeft_Click(sender As Object, e As EventArgs) Handles btnDirsekLeft.Click
        Me.Enabled = False
        leftside = True
        LeftElbow.Enabled = True
        LeftElbow.Show()
        LeftElbow.BringToFront()
    End Sub

    Private Sub btnElBilegiLeft_Click(sender As Object, e As EventArgs) Handles btnElBilegiLeft.Click
        Me.Enabled = False
        leftside = True
        LeftWrist.Enabled = True
        LeftWrist.Show()
        LeftWrist.BringToFront()
    End Sub

    Private Sub btnPeriferikLeft_Click(sender As Object, e As EventArgs) Handles btnPeriferikLeft.Click
        Me.Enabled = False
        leftside = True
        LeftPeriferik.Enabled = True
        LeftPeriferik.Show()
        LeftPeriferik.BringToFront()
    End Sub

    Private Sub btnD2Left_Click(sender As Object, e As EventArgs) Handles btnD2Left.Click
        Me.Enabled = False
        leftside = True
        LeftD2.Enabled = True
        LeftD2.Show()
        LeftD2.BringToFront()
    End Sub

    Private Sub btnD3Left_Click(sender As Object, e As EventArgs) Handles btnD3Left.Click
        Me.Enabled = False
        leftside = True
        LeftD3.Enabled = True
        LeftD3.Show()
        LeftD3.BringToFront()
    End Sub

    Private Sub btnD4Left_Click(sender As Object, e As EventArgs) Handles btnD4Left.Click
        Me.Enabled = False
        leftside = True
        LeftD4.Enabled = True
        LeftD4.Show()
        LeftD4.BringToFront()
    End Sub

    Private Sub btnD5Left_Click(sender As Object, e As EventArgs) Handles btnD5Left.Click
        Me.Enabled = False
        leftside = True
        LeftD5.Enabled = True
        LeftD5.Show()
        LeftD5.BringToFront()
    End Sub

    Private Sub btnDirsekRight_Click(sender As Object, e As EventArgs) Handles btnDirsekRight.Click, Button6.Click
        Me.Enabled = False
        leftside = False
        RightElbow.Enabled = True
        RightElbow.Show()
        RightElbow.BringToFront()
    End Sub

    Private Sub btnElbilegiRight_Click(sender As Object, e As EventArgs) Handles btnElbilegiRight.Click, Button4.Click
        Me.Enabled = False
        leftside = False
        RightWrist.Enabled = True
        RightWrist.Show()
        RightWrist.BringToFront()
    End Sub

    Private Sub btnAmputasyonRight_Click(sender As Object, e As EventArgs) Handles btnAmputasyonRight.Click, btnAmpRight.Click
        Me.Enabled = False
        leftside = False
        RightAmputasyon.Enabled = True
        RightAmputasyon.Show()
        RightAmputasyon.BringToFront()
    End Sub

    Private Sub btnPeriferikRight_Click(sender As Object, e As EventArgs) Handles btnPeriferikRight.Click, btnPeriferikRight2.Click
        Me.Enabled = False
        leftside = False
        RightPeriferik.Enabled = True
        RightPeriferik.Show()
        RightPeriferik.BringToFront()
    End Sub

    Private Sub btnD1Right_Click(sender As Object, e As EventArgs) Handles btnD1Right.Click, Button11.Click
        Me.Enabled = False
        leftside = False
        RightD1.Enabled = True
        RightD1.Show()
        RightD1.BringToFront()
    End Sub

    Private Sub btnD2Right_Click(sender As Object, e As EventArgs) Handles btnD2Right.Click, Button10.Click
        Me.Enabled = False
        leftside = False
        RightD2.Enabled = True
        RightD2.Show()
        RightD2.BringToFront()
    End Sub

    Private Sub btnD3Right_Click(sender As Object, e As EventArgs) Handles btnD3Right.Click, Button9.Click
        Me.Enabled = False
        leftside = False
        RightD3.Enabled = True
        RightD3.Show()
        RightD3.BringToFront()
    End Sub

    Private Sub btnD4Right_Click(sender As Object, e As EventArgs) Handles btnD4Right.Click, Button8.Click
        Me.Enabled = False
        leftside = False
        RightD4.Enabled = True
        RightD4.Show()
        RightD4.BringToFront()
    End Sub

    Private Sub btnD5Right_Click(sender As Object, e As EventArgs) Handles btnD5Right.Click, Button7.Click
        Me.Enabled = False
        leftside = False
        RightD5.Enabled = True
        RightD5.Show()
        RightD5.BringToFront()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click


        'Sol Taraf
        Dim listFinalLeft As New List(Of Integer)
        intcombinedUELeft = Calc(ListBoxOzetLeft, listFinalLeft)
        lblUEFinalLeft.Text = intcombinedUELeft
        '***********************************************
        'Sağ Taraf
        Dim listFinalRight As New List(Of Integer)
        intcombinedUERight = Calc(ListBoxOzetRight, listFinalRight)
        lblUEFinalRight2.Text = intcombinedUERight
        '*************************************************
        UpdateLabelValues()
        intCombinedBothUEFinal = Balthazard2Numbers(intcombinedUELeft, intcombinedUERight)
        lblFinalUETotal.Text = intCombinedBothUEFinal

        intPersonalDisability = Balthazard2Numbers(intcombinedUELeft, intcombinedUERight) * 0.6
        lblFinalPersonal.Text = intPersonalDisability

        Dim Newline As String
        Newline = System.Environment.NewLine
        strUltimateRaporLeft = ""
        strUltimateRaporRight = ""

        strUltimateRaporLeft = strAmputasyonFinalLeft + strArtroplastiFinalLeft + strD1RaporFinalLeft +
            strD2RaporFinalLeft + strD3RaporFinalLeft + strD4RaporFinalLeft + strD5RaporFinalLeft + strElBilegiRaporFinalLeft +
            strDirsekRaporFinalLeft + strOmuzRaporFinalLeft + strPeriferikRaporFinalLeft

        strUltimateRaporRight = strAmputasyonFinalRight + strArtroplastiFinalRight + strD1RaporFinalRight +
            strD2RaporFinalRight + strD3RaporFinalRight + strD4RaporFinalRight + strD5RaporFinalRight + strElBilegiRaporFinalRight +
            strDirsekRaporFinalRight + strOmuzRaporFinalRight + strPeriferikRaporFinalRight
        Dim currentDateTime As String = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")

        ' Right side detailed report
        Dim detailReportRight As String = ""
        If intAmputasyonFinalRight <> 0 Then detailReportRight &= "    Amputasyon: " & intAmputasyonFinalRight.ToString() & Environment.NewLine
        If intArtroplastiFinalRight <> 0 Then detailReportRight &= "    Artroplasti: " & intArtroplastiFinalRight.ToString() & Environment.NewLine
        If intD1FinalRight <> 0 Then detailReportRight &= "    D1: " & intD1FinalRight.ToString() & Environment.NewLine
        If intD2FinalRight <> 0 Then detailReportRight &= "    D2: " & intD2FinalRight.ToString() & Environment.NewLine
        If intD3FinalRight <> 0 Then detailReportRight &= "    D3: " & intD3FinalRight.ToString() & Environment.NewLine
        If intD4FinalRight <> 0 Then detailReportRight &= "    D4: " & intD4FinalRight.ToString() & Environment.NewLine
        If intD5FinalRight <> 0 Then detailReportRight &= "    D5: " & intD5FinalRight.ToString() & Environment.NewLine
        If intElBilegiFinalRight <> 0 Then detailReportRight &= "    El Bileği: " & intElBilegiFinalRight.ToString() & Environment.NewLine
        If intDirsekFinalRight <> 0 Then detailReportRight &= "    Dirsek: " & intDirsekFinalRight.ToString() & Environment.NewLine
        If intOmuzFinalRight <> 0 Then detailReportRight &= "    Omuz: " & intOmuzFinalRight.ToString() & Environment.NewLine
        If intPeriferikSinirFinalRight <> 0 Then detailReportRight &= "    Periferik Sinir: " & intPeriferikSinirFinalRight.ToString() & Environment.NewLine

        ' Left side detailed report
        Dim detailReportLeft As String = ""
        If intAmputasyonFinalLeft <> 0 Then detailReportLeft &= "    Amputasyon: " & intAmputasyonFinalLeft.ToString() & Environment.NewLine
        If intArtroplastiFinalLeft <> 0 Then detailReportLeft &= "    Artroplasti: " & intArtroplastiFinalLeft.ToString() & Environment.NewLine
        If intD1FinalLeft <> 0 Then detailReportLeft &= "    D1: " & intD1FinalLeft.ToString() & Environment.NewLine
        If intD2FinalLeft <> 0 Then detailReportLeft &= "    D2: " & intD2FinalLeft.ToString() & Environment.NewLine
        If intD3FinalLeft <> 0 Then detailReportLeft &= "    D3: " & intD3FinalLeft.ToString() & Environment.NewLine
        If intD4FinalLeft <> 0 Then detailReportLeft &= "    D4: " & intD4FinalLeft.ToString() & Environment.NewLine
        If intD5FinalLeft <> 0 Then detailReportLeft &= "    D5: " & intD5FinalLeft.ToString() & Environment.NewLine
        If intElBilegiFinalLeft <> 0 Then detailReportLeft &= "    El Bileği: " & intElBilegiFinalLeft.ToString() & Environment.NewLine
        If intDirsekFinalLeft <> 0 Then detailReportLeft &= "    Dirsek: " & intDirsekFinalLeft.ToString() & Environment.NewLine
        If intOmuzFinalLeft <> 0 Then detailReportLeft &= "    Omuz: " & intOmuzFinalLeft.ToString() & Environment.NewLine
        If intPeriferikSinirFinalLeft <> 0 Then detailReportLeft &= "    Periferik Sinir: " & intPeriferikSinirFinalLeft.ToString() & Environment.NewLine

        Dim reviewreport As String = "**************************" + Newline + "Hasta Adı: Anonim" + Newline &
                             currentDateTime & Newline & "**************************" + Newline &
                             "ÖZET RAPOR" + Newline + "**************************" & Environment.NewLine &
                            "Sağ Üst Ekstremite Özür Oranı: " & intcombinedUERight.ToString() & Environment.NewLine &
                            "Sol Üst Ekstremite Özür Oranı: " & intcombinedUELeft.ToString() & Environment.NewLine &
                            "Kombine Üst Ekstremite Özür Oranı: " & intCombinedBothUEFinal.ToString() & Environment.NewLine &
                            "Kişi Özür Oranı:" & intPersonalDisability.ToString() + Newline + "**************************" + Newline &
                            "DETAYLI RAPOR" + Newline + "**************************" + Newline + "  Sağ Üst Ekstremite" & Newline & detailReportRight &
                             "  Sol Üst Ekstremite" & Newline & detailReportLeft
        txtUERaporAlani.Text = reviewreport
    End Sub
    Private Sub UEOzetListeCikar()

        'SOL TARAF*********************************************************************
        ListBoxOzetLeft.Items.Clear()

        If booleanBasparmakExceptionLeft Then
            ListBoxOzetLeft.Items.Add(0)
        Else
            ListBoxOzetLeft.Items.Add(intAmputasyonFinalLeft)
        End If


        ListBoxOzetLeft.Items.Insert(0, intPeriferikSinirFinalLeft)
        ListBoxOzetLeft.Items.Insert(1, intAmputasyonFinalLeft)
        ListBoxOzetLeft.Items.Insert(2, intArtroplastiFinalLeft)
        ListBoxOzetLeft.Items.Insert(3, intOmuzFinalLeft)
        ListBoxOzetLeft.Items.Insert(4, intDirsekFinalLeft)
        ListBoxOzetLeft.Items.Insert(5, intElBilegiFinalLeft)
        ListBoxOzetLeft.Items.Insert(6, intElFinalLeft)

        '*********************************************************************************
        'SAĞ TARAF*********************************************************************
        ListBoxOzetRight.Items.Clear()

        If booleanBasparmakExceptionRight Then
            ListBoxOzetRight.Items.Add(0)
        Else
            ListBoxOzetRight.Items.Add(intAmputasyonFinalRight)
        End If


        ListBoxOzetRight.Items.Insert(0, intPeriferikSinirFinalRight)
        ListBoxOzetRight.Items.Insert(1, intAmputasyonFinalRight)
        ListBoxOzetRight.Items.Insert(2, intArtroplastiFinalRight)
        ListBoxOzetRight.Items.Insert(3, intOmuzFinalRight)
        ListBoxOzetRight.Items.Insert(4, intDirsekFinalRight)
        ListBoxOzetRight.Items.Insert(5, intElBilegiFinalRight)
        ListBoxOzetRight.Items.Insert(6, intElFinalRight)

        '*********************************************************************************




    End Sub
    Private Sub lblElOnToplamLeft_Click(sender As Object, e As EventArgs) Handles lblElOnToplamLeft.Click

    End Sub

    Private Sub GroupBoxRight_Enter(sender As Object, e As EventArgs) Handles GroupBoxRight.Enter, GroupBox1.Enter

    End Sub

    Private Sub Anasayfa_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.EnabledChanged
        UpdateLabelValues()
        Me.BringToFront()
    End Sub

    Private Sub lblElToUstLeft_Click(sender As Object, e As EventArgs) Handles lblElToUstLeft.Click

    End Sub
End Class

