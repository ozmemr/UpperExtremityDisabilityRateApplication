Public Class Universal

    Public Shared booleanThereIsError As Boolean

    Public Shared leftside As Boolean

    ' ////////////////////////////////////////////////////////////////////////////////////////////////////////////
    '**********************************ÖZÜR ORANI DEĞİŞKENLERİ SAĞ*************************************************
    Public Shared intD1FinalLocal As Integer
    Public Shared intD2FinalLocal As Integer
    Public Shared intD3FinalLocal As Integer
    Public Shared intD4FinalLocal As Integer
    Public Shared intD5FinalLocal As Integer

    Public Shared intElFinalLocal As Integer
    Public Shared intElBilegiFinalLocal As Integer
    Public Shared intDirsekFinalLocal As Integer
    Public Shared intOmuzFinalLocal As Integer

    Public Shared intArtroplastiFinalLocal As Integer
    Public Shared intAmputasyonFinalLocal As Integer
    Public Shared intPeriferikSinirFinalLocal As Integer



    ' //////////////////////////////////////////////////////////////////////////////////////////////////////////


    '**********************************ÖZÜR ORANI DEĞİŞKENLERİ*************************************************
    Public Shared intD1FinalLeft As Integer
    Public Shared intD2FinalLeft As Integer
    Public Shared intD3FinalLeft As Integer
    Public Shared intD4FinalLeft As Integer
    Public Shared intD5FinalLeft As Integer

    Public Shared intElFinalLeft As Integer
    Public Shared intElBilegiFinalLeft As Integer
    Public Shared intDirsekFinalLeft As Integer
    Public Shared intOmuzFinalLeft As Integer

    Public Shared intArtroplastiFinalLeft As Integer
    Public Shared intAmputasyonFinalLeft As Integer
    Public Shared intPeriferikSinirFinalLeft As Integer

    Public Shared intcombinedUELeft As Integer

    ' ////////////////////////////////////////////////////////////////////////////////////////////////////////////
    '**********************************ÖZÜR ORANI DEĞİŞKENLERİ SAĞ*************************************************
    Public Shared intD1FinalRight As Integer
    Public Shared intD2FinalRight As Integer
    Public Shared intD3FinalRight As Integer
    Public Shared intD4FinalRight As Integer
    Public Shared intD5FinalRight As Integer

    Public Shared intElFinalRight As Integer
    Public Shared intElBilegiFinalRight As Integer
    Public Shared intDirsekFinalRight As Integer
    Public Shared intOmuzFinalRight As Integer

    Public Shared intArtroplastiFinalRight As Integer
    Public Shared intAmputasyonFinalRight As Integer
    Public Shared intPeriferikSinirFinalRight As Integer

    Public Shared intcombinedUERight As Integer

    ' ////////////////////////////////////////////////////////////////////////////////////////////////////////////
    Public Shared intCombinedBothUEFinal



    '************************************RAPOR DEĞİŞKENLERİ**************************************************
    Public Shared intPersonalDisability As Integer


    Public Shared strD1RaporFinalLeft As String
    Public Shared strD2RaporFinalLeft As String
    Public Shared strD3RaporFinalLeft As String
    Public Shared strD4RaporFinalLeft As String
    Public Shared strD5RaporFinalLeft As String
    Public Shared strElRaporFinalLeft As String
    Public Shared strElBilegiRaporFinalLeft As String
    Public Shared strDirsekRaporFinalLeft As String
    Public Shared strOmuzRaporFinalLeft As String
    Public Shared strPeriferikRaporFinalLeft As String
    Public Shared strAmputasyonFinalLeft As String
    Public Shared strArtroplastiFinalLeft As String


    Public Shared strKombineDetayliRaporLeft As String
    Public Shared strFinalOzetRaporLeft As String
    Public Shared strFinalOzetRapor As String

    Public Shared strD1RaporFinalRight As String
    Public Shared strD2RaporFinalRight As String
    Public Shared strD3RaporFinalRight As String
    Public Shared strD4RaporFinalRight As String
    Public Shared strD5RaporFinalRight As String
    Public Shared strElRaporFinalRight As String
    Public Shared strElBilegiRaporFinalRight As String
    Public Shared strDirsekRaporFinalRight As String
    Public Shared strOmuzRaporFinalRight As String
    Public Shared strPeriferikRaporFinalRight As String
    Public Shared strAmputasyonFinalRight As String
    Public Shared strArtroplastiFinalRight As String


    Public Shared strKombineDetayliRaporRight As String
    Public Shared strFinalOzetRaporRight As String
    '////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    Public Shared intExceptionAmputasyonYedekLeft As Integer
    Public Shared intExceptionAmputasyonYedekRight As Integer
    Public Shared booleanBasparmakExceptionLeft As Boolean
    Public Shared booleanBasparmakExceptionRight As Boolean

    Dim intElBilegiExc As Integer

        'LİSTEDEN KALDIR



        'Listboxtan Listeye geçerek balthazardla

        Public Shared Function Calc(ByVal listboxozet As ListBox, ByVal listOzet As List(Of Integer))

            Dim count As Integer
            Dim result As Integer

            If listboxozet IsNot Nothing And listOzet IsNot Nothing Then
                For count = 0 To listboxozet.Items.Count - 1

                    listOzet.Add(listboxozet.Items(count))


                Next

                result = BalthazardList(listOzet)
            End If






            Return result

        End Function

        'Listboxtan Listeye geçerek balthazardla222222222222








        'LİSTEYİ BALTHAZARDLA
        Public Shared Function BalthazardList(ByVal listOzurListesi As List(Of Integer))

            Dim intBalthazardcount As Integer
            Dim intBalthazard1 As Integer
            Dim intBalthazard2 As Integer
            Dim intBalthazardfinal As Integer


            listOzurListesi.Sort()

            If listOzurListesi.Count = 1 Then
                intBalthazardfinal = listOzurListesi.Item(0)
            End If

            For intBalthazardcount = listOzurListesi.Count - 2 To 0 Step -1

                intBalthazard1 = listOzurListesi.Item(intBalthazardcount)
                intBalthazard2 = listOzurListesi.Item(intBalthazardcount + 1)
                intBalthazardfinal = intBalthazard1 + (100 - intBalthazard1) * intBalthazard2 / 100

                listOzurListesi.Item(intBalthazardcount) = intBalthazardfinal

            Next

            Return intBalthazardfinal
        End Function




        'Sadece iki değeri balthazardla

        Public Shared Function Balthazard2Numbers(ByVal inta As Integer, ByVal intb As Integer)

            Dim intBalthazardfinal As Integer


            If inta >= intb Then
                intBalthazardfinal = inta + (100 - inta) * intb / 100

            End If

            If intb > inta Then
                intBalthazardfinal = intb + (100 - intb) * inta / 100
            End If



            Return intBalthazardfinal
        End Function

        Public Shared Sub DisableAndClearList(ByVal listboxMe As ListBox)
            listboxMe.Items.Clear()
            listboxMe.BackColor() = Color.FromArgb(235, 231, 231)
            listboxMe.Enabled = False
        End Sub

        Public Shared Sub EnableAndPopulateList(ByVal listboxMe As ListBox, ByVal arrayMe As Array, ByVal columnMe As Integer)
            Dim count As Integer

            listboxMe.Items.Clear()
            listboxMe.BackColor() = Color.White


            For count = 0 To arrayMe.GetLength(0) - 1
                listboxMe.Items.Add(arrayMe(count, columnMe))
            Next

            listboxMe.Enabled = True

        End Sub



    Public Shared Sub checkUserCorrectInput(ByVal listbox As ListBox, ByVal listbox2 As ListBox, ByVal type As Integer)
        Dim stringROM1 As String
        Dim stringROM2 As String
        booleanThereIsError = False

        If type = 1 Then
            stringROM1 = "Fleksiyon: "
            stringROM2 = "Ekstansiyon: "

        ElseIf type = 2 Then
            stringROM1 = "Abdüksiyon: "
            stringROM2 = "Addüksiyon: "

        ElseIf type = 3 Then
            stringROM1 = "İç Rot: "
            stringROM2 = "Dış Rot: "

        ElseIf type = 4 Then
            stringROM1 = "Pronasyon: "
            stringROM2 = "Supinasyon: "

        ElseIf type = 5 Then
            stringROM1 = "Radyal Deviasyon: "
            stringROM2 = "Ulnar Deviasyon: "
        ElseIf type = 6 Then
            stringROM1 = "Fleksiyon: "
            stringROM2 = "Ekstansiyon Kısıtlılığı: "
        End If

        If listbox.SelectedIndex + listbox2.SelectedIndex = listbox.Items.Count - 1 Then
            MessageBox.Show("Hata: Girdiğiniz değerler ankiloz ile uyumlu. Ankiloz seçmelisiniz")
            booleanThereIsError = True
        ElseIf listbox.SelectedIndex + listbox2.SelectedIndex > listbox.Items.Count - 1 Then
            MessageBox.Show("Hata: Girdiğiniz değerler hatalı gözüküyor. Aynı anda " + stringROM1 + listbox.SelectedItem + " ve " + stringROM2 + listbox2.SelectedItem + " seçemezsiniz.")
            booleanThereIsError = True
        End If
        If booleanThereIsError Then
            listbox.SelectedIndex = 0
            listbox2.SelectedIndex = 0
        Else
            booleanThereIsError = False
        End If

    End Sub

    Public Shared Sub AnamenuButtonKapatvePuaniSil(ByVal btn1 As Button, ByVal int1 As Integer)

        btn1.Enabled = False
        int1 = 0

    End Sub
    Private Sub Universal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


End Class

