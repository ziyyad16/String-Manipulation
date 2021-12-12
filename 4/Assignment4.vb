Module Module1

    Sub Main()
        Dim str1 As String
        Dim char1, char2, char3 As Char
        Dim counter, mrc, i, j As Integer

        str1 = ""
        char1 = ""
        char2 = ""
        char3 = ""
        counter = 0
        mrc = 0
        i = 0
        j = 0

        Console.Write("enter string to process :")
        str1 = Console.ReadLine

        For i = 1 To Len(str1)
            char1 = Mid(str1, i, 1)
            counter = 0
            For j = 1 To Len(str1)
                char2 = Mid(str1, j, 1)
                If char2 = char1 Then counter = counter + 1
            Next
            If counter > mrc Then
                mrc = counter
                char3 = char1

            End If
    

        Next

        Console.WriteLine(char3 & " appeared " & mrc & " number of times ")
        Console.ReadKey()

    End Sub

End Module
