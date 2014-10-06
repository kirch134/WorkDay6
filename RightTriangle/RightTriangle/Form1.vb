Option Strict On
Public Class Form1


    Private Sub btnCalculate_Click(sender As System.Object, e As System.EventArgs) Handles btnCalculate.Click
        Dim result As Double
        Dim strA, strB As String
        strA = txtSideOne.Text
        strB = txtSideTwo.Text

        Dim a, b As Double
        a = CDbl(strA)
        b = CDbl(strB)

        result = Hypotenuse(a, b)
        txtHyp.Text = CStr(result)

    End Sub
    Function Hypotenuse(ByVal a As Double, ByVal b As Double) As Double
        Dim c As Double
        c = Math.Sqrt((a ^ 2) + (b ^ 2))
        Return c
    End Function
End Class
