Public Class frmMeterCalculator
    Private Sub frmMeterCalculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        radMeterKilometer.Select()
    End Sub
    Private Sub btnMeters_Click(sender As Object, e As EventArgs) Handles btnMeters.Click
        Dim strMeter As String
        Dim decMeter As Decimal
        Dim decSumOfMeters As Decimal
        Dim decConversion As Decimal = 0D

        Dim strIBoxMsg As String = "Enter the number of Meters you would like to convert "
        Dim strIBoxTitle As String = "Meter Conversion"

        Dim intMaxEntries As Integer = 10
        Dim intEntries As Integer = 1

        strMeter = InputBox(strIBoxMsg & intEntries, strIBoxTitle)

        Do Until intEntries > intMaxEntries Or strMeter = ""
            If IsNumeric(strMeter) Then
                decMeter = Convert.ToDecimal(strMeter)
                If decMeter > 0 Then
                    lstMeters.Items.Add(decMeter)
                    decSumOfMeters += decMeter
                    intEntries += 1
                    strIBoxMsg = strIBoxMsg
                Else
                    MsgBox("Enter a positive number", , "Invalid Number Error")
                End If
                If intEntries <= intMaxEntries Then
                    strMeter = InputBox(strIBoxMsg & intEntries, strIBoxTitle)
                End If
            Else
                MsgBox("Enter a Number", , "Invalid Input Error")
                strMeter = InputBox(strIBoxMsg & intEntries, strIBoxTitle)
            End If
        Loop

        lblMeterConversion.Visible = True

        If intEntries > 1 Then
            ConversionCalculate(decConversion, decSumOfMeters)

        Else
            lblMeterConversion.Text = "No Meter Values Entered"
        End If

        btnMeters.Enabled = False
    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lstMeters.Items.Clear()
        lblMeterConversion.Text = ""
        btnMeters.Enabled = True
        radMeterKilometer.Select()
    End Sub

    Private Sub ConversionCalculate(ByVal decConversion As Decimal, ByVal decSumOfMeters As Decimal)
        If radMeterKilometer.Checked Then
            decConversion = decSumOfMeters * 0.001
            lblMeterConversion.Text = decSumOfMeters & " Meters is " & decConversion.ToString("F2") & " Kilometers "
        ElseIf radMeterCentimeter.Checked Then
            decConversion = decSumOfMeters * 100
            lblMeterConversion.Text = "Meters to Centimeters " & decConversion.ToString("F2") & " Centimeters "
        ElseIf radKilometerMeter.Checked Then
            decConversion = decSumOfMeters * 1000
            lblMeterConversion.Text = decSumOfMeters & " Kilometers is " & decConversion.ToString("F2") & " Meters "
        ElseIf radKilometerCentimeter.Checked Then
            decConversion = decSumOfMeters * 100000
            lblMeterConversion.Text = decSumOfMeters & " Kilometers is " & decConversion.ToString("F2") & " Centimeters "
        ElseIf radCentimeterMeter.Checked Then
            decConversion = decSumOfMeters * 0.01
            lblMeterConversion.Text = decSumOfMeters & " Centimeters is " & decConversion.ToString("F2") & " Meters "
        ElseIf radCentimeterKilometer.Checked Then
            decConversion = decSumOfMeters * 0.00001
            lblMeterConversion.Text = decSumOfMeters & " Centimeters is " & decConversion.ToString("F5") & " Kilometers "
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub
End Class
