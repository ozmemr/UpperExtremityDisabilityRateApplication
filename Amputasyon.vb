Imports UpperExtremityModule.Universal


Public Class Amputasyon


    Dim intLocalAmputasyonPuani As Integer

    Dim strLokalAmputasyonRapor As String
    Dim strRadioButtonName As String
    Private Sub Amputasyon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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


        lblAmputasyon.Text = intLocalAmputasyonPuani


        For Each ctrl As RadioButton In GroupBox1.Controls
            ctrl.Checked = False
        Next




    End Sub

    Private Sub updateRadioBoxes()
        If rbOmuzDezartikulasyon.Checked Then
            intLocalAmputasyonPuani = 100

        End If

        If rbDeltoidproksimali.Checked Then
            intLocalAmputasyonPuani = 100
        End If


        If rbDeltoidbicepsarasi.Checked Then
            intLocalAmputasyonPuani = 95

        End If

        If rbOnKol.Checked Then
            intLocalAmputasyonPuani = 94
        End If


        'ÖZEL FONKSİYONLAR ÇAĞIRILIYOR
        If rbElTümMKF.Checked Then
            intLocalAmputasyonPuani = 90

        End If



        If rbD1HaricTumParmaklar.Checked Then
            intLocalAmputasyonPuani = 54
        End If
        '*****************************************************************
        If rbD1KMK.Checked Then
            intLocalAmputasyonPuani = 38
        End If

        If rbD1MKDistali.Checked Then
            intLocalAmputasyonPuani = 37


        End If

        lblAmputasyon.Text = intLocalAmputasyonPuani
    End Sub











    'İŞLEMLER/************************************************************************




    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Anasayfa.Enabled = True


    End Sub
    Private Sub btnSaveExit_Click(sender As Object, e As EventArgs) Handles btnSaveExit.Click


        If leftside = True Then
            intAmputasyonFinalLeft = intLocalAmputasyonPuani
            strAmputasyonFinalLeft = strLokalAmputasyonRapor
        Else
            intAmputasyonFinalRight = intLocalAmputasyonPuani
            strAmputasyonFinalRight = strLokalAmputasyonRapor

        End If






        ''ÖZEL FONKSİYONLAR ÇAĞIRILIYOR
        If rbElTümMKF.Checked Then

            '    AnamenuButtonKapatvePuaniSil(Anasayfa.btnD1Left, intD1Final)
            '    AnamenuButtonKapatvePuaniSil(Anasayfa.btnD2Left, intD2Final)
            '    AnamenuButtonKapatvePuaniSil(Anasayfa.btnD3Left, intD3Final)
            '    AnamenuButtonKapatvePuaniSil(Anasayfa.btnD4Left, intD4Final)
            '    AnamenuButtonKapatvePuaniSil(Anasayfa.btnD5Left, intD5Final)
            If leftside = True Then
                intElFinalLeft = 100
            Else
                intElFinalRight = 100
            End If



        ElseIf rbD1HaricTumParmaklar.Checked Then
            '  

            If leftside = True Then
                intExceptionAmputasyonYedekLeft = 60
                booleanBasparmakExceptionLeft = True
            Else
                intExceptionAmputasyonYedekRight = 60
                booleanBasparmakExceptionRight = True

                '    '/////////////////////////////////////////////////

            End If
        End If
        Me.Visible = False
        Me.Enabled = False

        Anasayfa.Enabled = True

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Form_Reset()



    End Sub

    Public Sub Form_Reset()
        For Each ctrl As RadioButton In GroupBox1.Controls
            ctrl.Checked = False
        Next

        intLocalAmputasyonPuani = 0

        lblAmputasyon.Text = intLocalAmputasyonPuani
    End Sub

    Private Sub rbOmuzDezartikulasyon_CheckedChanged(sender As Object, e As EventArgs) Handles rbOmuzDezartikulasyon.CheckedChanged
        updateRadioBoxes()
    End Sub

    Private Sub rbDeltoidproksimali_CheckedChanged(sender As Object, e As EventArgs) Handles rbDeltoidproksimali.CheckedChanged
        updateRadioBoxes()
    End Sub

    Private Sub rbDeltoidbicepsarasi_CheckedChanged(sender As Object, e As EventArgs) Handles rbDeltoidbicepsarasi.CheckedChanged
        updateRadioBoxes()
    End Sub

    Private Sub rbOnKol_CheckedChanged(sender As Object, e As EventArgs) Handles rbOnKol.CheckedChanged
        updateRadioBoxes()
    End Sub

    Private Sub rbElTümMKF_CheckedChanged(sender As Object, e As EventArgs) Handles rbElTümMKF.CheckedChanged
        updateRadioBoxes()
    End Sub

    Private Sub rbD1HaricTumParmaklar_CheckedChanged(sender As Object, e As EventArgs) Handles rbD1HaricTumParmaklar.CheckedChanged
        updateRadioBoxes()
    End Sub

    Private Sub rbD1KMK_CheckedChanged(sender As Object, e As EventArgs) Handles rbD1KMK.CheckedChanged
        updateRadioBoxes()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs)




    End Sub
    Private Sub Raporla()
        If intLocalAmputasyonPuani > 0 Then
            updateRadioBoxes()

            Dim Newline As String
            Newline = System.Environment.NewLine
            ReturnNameOfRadioButton()
            strLokalAmputasyonRapor = "***Amputasyon Puanı***" + Newline + Newline + strRadioButtonName + "amputasyonu sebebiyle " + Conversion.Str(intLocalAmputasyonPuani)
            textboxLokalRapor.Text = strLokalAmputasyonRapor

        End If


    End Sub
    Private Function ReturnNameOfRadioButton()

        strRadioButtonName = ""

        For Each ctrl As RadioButton In GroupBox1.Controls
            If ctrl.Checked = True Then
                strRadioButtonName = ctrl.Text
            End If
        Next

        Return strRadioButtonName
    End Function

    Private Sub lblDescription_Click(sender As Object, e As EventArgs) Handles lblDescription.Click

    End Sub
End Class