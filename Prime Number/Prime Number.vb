Imports System.Math
Public Class PrimeNumber


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles calculatePrimesButton.Click
        primeNumbersListBox.Items.Clear()
        Dim upper As String = upperBoundryTextBox.Text
        Dim lower As String = lowerBoundryTextBox.Text

        If IsNumeric(lowerBoundryTextBox.Text) And IsNumeric(upperBoundryTextBox.Text) Then


            If (Val(lower) < Val(upper)) Then
                Dim i As Integer = -1
                Dim count As Integer = upper - lower

                Do While (i < count)
                    TestPrimes(lower)
                    'incrememts
                    i += 1
                    lower += 1
                Loop


            Else
                MsgBox("Upper Limit must be larger number than Lower Limit")

            End If 'end value compairson
        Else
            MsgBox("both inputs must be a number")

        End If ' end isnumeric

    End Sub

    Function TestPrimes(ByVal num As Integer)
        Dim primeBool As Boolean = True

        '1 is always prime
        If num = 1 Then
            primeBool = True
            Exit Function
        End If

        'Checks num is positive
        If num <= 0 Then
            primeBool = False
            Exit Function
        End If
        Dim toNum As Integer = Math.Sqrt(num)
        For o = 2 To toNum
            If num Mod o = 0 Then ' checks if divisable by every number between 2 and the square root of the number.
                primeBool = False
                Exit Function
            End If
        Next


    primeNumbersListBox.Items.Add(num)

    End Function


End Class
