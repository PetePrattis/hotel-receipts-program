Sub Main() 
        Dim hotels(10) As String
        Dim receipts(10, 12) As Integer

        For i As Integer = 0 To hotels.GetLength(0) - 1
            hotels(i) = InputBox("Give a hotel name")
            For j As Integer = 0 To receipts.GetLength(1) - 1
                receipts(i, j) = InputBox("Give hotel receipts " & hotels(i) & " for the month " & j)
            Next
        Next

        Dim sum_receipts As Integer
        Dim min_receipts As Integer
        Dim hotel_min_receipts As String
        min_receipts = 10000000
        For i As Integer = 0 To hotels.GetLength(0) - 1
            sum_receipts = 0
            For j As Integer = 0 To receipts.GetLength(1) - 1 - 6
                sum_receipts = sum_receipts + receipts(i, j)
            Next
            If min_receipts > sum_receipts Then
                min_receipts = sum_receipts
                hotel_min_receipts = hotels(i)
            End If
        Next
        MsgBox("The hotel had the lowest receipts " & hotel_min_receipts)

        Dim average_monthly_summer_receipts(10) As Integer
        Dim summer_receipts(10) As Integer

        For i As Integer = 0 To hotels.GetLength(0) - 1

            For j As Integer = 6 - 1 To receipts.GetLength(1) - 1 - 4
                summer_receipts(i) = summer_receipts(i) + receipts(i, j)
            Next
            average_monthly_summer_receipts(i) = summer_receipts(i) / 3
            MsgBox("The average monthly fee for June-July-August for the hotel " & hotels(i) & " is " & average_monthly_summer_receipts(i))
        Next

        Dim max_average_montlhy_summer_receipts As Integer
        Dim min_average_montlhy_summer_receipts As Integer
        Dim diff_maxmin_montlhy_summer_receipts As Integer

        max_average_montlhy_summer_receipts = 0
        min_average_montlhy_summer_receipts = 10000000

        For i As Integer = 0 To average_monthly_summer_receipts.GetLength(0) - 1
            If max_average_montlhy_summer_receipts < average_monthly_summer_receipts(i) Then
                max_average_montlhy_summer_receipts = average_monthly_summer_receipts(i)
            End If

            If min_average_montlhy_summer_receipts > average_monthly_summer_receipts(i) Then
                min_average_montlhy_summer_receipts = average_monthly_summer_receipts(i)
            End If
        Next
        diff_maxmin_montlhy_summer_receipts = max_average_montlhy_summer_receipts - min_average_montlhy_summer_receipts
        MsgBox("The average monthly fee for a hotel is June-July-August " & diff_maxmin_montlhy_summer_receipts)


        Dim sum_receipts(10) As Integer

        For i As Integer = 0 To hotels.GetLength(0) - 1
            sum_receipts(i) = 0
            For j As Integer = 0 To receipts.GetLength(1) - 1
                sum_receipts(i) = sum_receipts(i) + receipts(i, j)
            Next
            If sum_receipts(i) > 1000000 Then
                MsgBox("The hotel " & hotels(i) & " has an annual receipts over 1,000,000")
            End If
        Next

    End Sub