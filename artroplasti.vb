Imports UpperExtremityModule.Universal



Public Class artroplasti


    Private Sub artroplasti_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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



        Form_Reset()

        For count1 = 0 To arrArtroplasti.GetLength(0) - 1

            listboxArtroplastiTipleri.Items.Add(arrArtroplasti(count1, 0))

        Next




    End Sub

    Public Sub btnSaveExit_Click(sender As Object, e As EventArgs) Handles btnSaveExit.Click
        If leftside = True Then
            intArtroplastiFinalLeft = intArtroplastiLokal
            strArtroplastiFinalLeft = strArtroplastiLokal
        Else
            intArtroplastiFinalRight = intArtroplastiLokal
            strArtroplastiFinalRight = strArtroplastiLokal
        End If
        Me.Visible = False
        Me.Enabled = False

        Anasayfa.Enabled = True
    End Sub


    Dim intArtroplastiLokal As Integer
    Dim strArtroplastiLokal As String

    'Bu bölümde kullanılacak tabloların array olarak tanımlanmas
    Dim arrArtroplasti(,) As String = {
    {"Tüm omuz", 24, 30},
    {"Distal klavikula (izole)", 0, 10},
    {"Proksimal klavikula (izole)", 0, 3},
    {"Tüm dirsek", 28, 35},
    {"Radial baş (izole)", 8, 10},
    {"Tüm el bileği", 24, 0},
    {"Radiokarpal", 16, 0},
    {"Ulnar baş (izole)", 8, 10},
    {"Proksimal karpal dizi ", 0, 12},
    {"Karpal kemikler (izole)", 8, 10},
    {"Radiyal stiloid (izole)", 0, 5},
    {"D1 KMK eklem", 9, 11},
    {"D1 MF eklem", 2, 3},
    {"D1 İF eklem", 4, 5},
    {"D2/D3 MF eklem", 4, 5},
    {"D2/D3 PİF eklem", 2, 3},
    {"D2/D3 DİF eklem", 1, 2},
    {"D4/D5 MF eklem", 2, 2},
    {"D4/D5 PİF eklem", 1, 1},
    {"D4/D5 DİF eklem", 1, 1}}




    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        Dim intSelection As Integer

        intSelection = listboxArtroplastiTipleri.SelectedIndex
        If intSelection >= 0 Then



            If rbImplant.Checked() Then
                listboxMevcutArtroplastiler.Items.Add(arrArtroplasti(intSelection, 0) + " implant")
                listBoxMevcutArtroplastilerPuan.Items.Add(arrArtroplasti(intSelection, 1))
            End If
            If rbRezeksiyon.Checked() Then
                listboxMevcutArtroplastiler.Items.Add(arrArtroplasti(intSelection, 0) + " rezeksiyon")
                listBoxMevcutArtroplastilerPuan.Items.Add(arrArtroplasti(intSelection, 2))
            End If
        End If

    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnRemove.Click

        Dim intremovalindex = listboxMevcutArtroplastiler.SelectedIndex
        If intremovalindex >= 0 Then
            listboxMevcutArtroplastiler.Items.RemoveAt(intremovalindex)
            listBoxMevcutArtroplastilerPuan.Items.RemoveAt(intremovalindex)
        End If
    End Sub




    Private Sub Raporla()

        Dim Newline As String
        Newline = System.Environment.NewLine

        strArtroplastiLokal = "***Artroplastiye Bağlı Üst Ekstremite Yüzdeleri*** " + Newline + Newline






    End Sub



    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        Form_Reset()

    End Sub

    Public Sub Form_Reset()
        listboxMevcutArtroplastiler.Items.Clear()

        intArtroplastiLokal = 0
        strArtroplastiLokal = 0

        lblResult.Text = intArtroplastiLokal

        textboxArtroplastiLokalRapor.Text = ""

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Raporla()

        Dim listFinalOzet As New List(Of Integer)

        intArtroplastiLokal = Calc(listBoxMevcutArtroplastilerPuan, listFinalOzet)

        lblResult.Text = intArtroplastiLokal

        If intArtroplastiLokal > 0 Then
            btnSaveExit.Enabled = True

        ElseIf intArtroplastiLokal = 0 Then
            btnSaveExit.Enabled = False
        End If

    End Sub




End Class