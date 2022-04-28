Public Class Form1
    

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'SET AN ARRAY VARIABLE TO STORE THE VALUE OF THE ZODIAC SIGNS ON IT.
        Dim zodiacSign() As String = {"Aries", "Taurus", "Gemini", "Cancer", _
                                  "Leo", "Virgo", "Libra", "Scorpio", "Sagittarius", _
                                  "Capricorn", "Aquarius", "Pisces"}

        'SET A VARIABLE TO REPRESENTS YOUR AGE.
        Dim AGE As Integer
        'SET THE STRING VARIABLE REPRESENT A FORMATED DATETIMEPICKER TO THE NAME OF THE MONTHS.
        Dim MONTHS As String = Format(DTPdateBIRTH.Value, "MMMM")
        'SET THE INTEGR VARIABLE REPRESENT A FORMATED DATETIMEPICKER TO A VALUE OF THE DAY.
        Dim DAYS As Integer = Format(DTPdateBIRTH.Value, "dd")

        'CALCULATING THE INTERVAL BETWEEN THE DATE OF BIRTH AND THE END OF THE DATE.
        age = DateDiff(DateInterval.Year, DTPdateBIRTH.Value, DTPendDATE.Value)
        'CLEARING THE LISTBOX.
        ListBox1.Items.Clear()
        'ADDING THE VALUE OF THE AGE IN THE LISTBOX TAHT YOU HAVE CALCULATED.
        ListBox1.Items.Add("Age : " & age).ToString()
        'YOU HAVE TO PUT A CONDITION IN ORDER TO SET THE SPECIFIC ZODIAC ZIGN OF THE DAYS IN THE MONTHS.
        Select Case MONTHS
            Case "January"
                If DAYS >= 1 And DAYS <= 19 Then
                    'ADDING A ZODIAC SIGN IN THE LIST BOXS.
                    ListBox1.Items.Add("Zodiac Sign :" & zodiacSign(9))
                Else
                    ListBox1.Items.Add("Zodiac Sign :" & zodiacSign(10))
                End If
            Case "February"
                If DAYS >= 1 And DAYS <= 18 Then
                    ListBox1.Items.Add("Zodiac Sign :" & zodiacSign(10))
                Else
                    ListBox1.Items.Add("Zodiac Sign :" & zodiacSign(11))
                End If
            Case "March"
                If DAYS >= 21 Then
                    ListBox1.Items.Add("Zodiac Sign :" & zodiacSign(0))
                Else
                    ListBox1.Items.Add("Zodiac Sign :" & zodiacSign(11))
                End If
            Case "April"
                If DAYS >= 1 And DAYS <= 19 Then
                    ListBox1.Items.Add("Zodiac Sign :" & zodiacSign(0))
                Else
                    ListBox1.Items.Add("Zodiac Sign :" & zodiacSign(1))
                End If
            Case "May"
                If DAYS >= 1 And DAYS <= 20 Then
                    ListBox1.Items.Add("Zodiac Sign :" & zodiacSign(1))
                Else
                    ListBox1.Items.Add("Zodiac Sign :" & zodiacSign(2))
                End If
            Case "June"
                If DAYS >= 1 And DAYS <= 21 Then
                    ListBox1.Items.Add("Zodiac Sign :" & zodiacSign(2))
                Else
                    ListBox1.Items.Add("Zodiac Sign :" & zodiacSign(3))
                End If
            Case "July"
                If DAYS >= 1 And DAYS <= 22 Then
                    ListBox1.Items.Add("Zodiac Sign :" & zodiacSign(3))
                Else
                    ListBox1.Items.Add("Zodiac Sign :" & zodiacSign(4))
                End If
            Case "August"
                If DAYS >= 1 And DAYS <= 22 Then
                    ListBox1.Items.Add("Zodiac Sign :" & zodiacSign(4))
                Else
                    ListBox1.Items.Add("Zodiac Sign :" & zodiacSign(5))
                End If
            Case "September"
                If DAYS >= 1 And DAYS <= 22 Then
                    ListBox1.Items.Add("Zodiac Sign :" & zodiacSign(5))
                Else
                    ListBox1.Items.Add("Zodiac Sign :" & zodiacSign(6))
                End If
            Case "October"
                If DAYS >= 1 And DAYS <= 22 Then
                    ListBox1.Items.Add("Zodiac Sign :" & zodiacSign(6))
                Else
                    ListBox1.Items.Add("Zodiac Sign :" & zodiacSign(7))
                End If
            Case "November"
                If DAYS >= 1 And DAYS <= 21 Then
                    ListBox1.Items.Add("Zodiac Sign :" & zodiacSign(7))
                Else
                    ListBox1.Items.Add("Zodiac Sign :" & zodiacSign(8))
                End If
            Case "December"
                If DAYS >= 1 And DAYS <= 21 Then
                    ListBox1.Items.Add("Zodiac Sign :" & zodiacSign(8))
                Else
                    ListBox1.Items.Add("Zodiac Sign :" & zodiacSign(9))
                End If
        End Select

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
