Module Module1

    Sub Main()
        Dim str1, str2, str3 As String
        Dim i, j, not1, a, bad As Integer

        str1 = ""
        str2 = ""
        not1 = 0
        bad = 0
        i = 0
        j = 0
        str3 = ""
        a = 0

        Console.Write("enter string to process :")
        str1 = Console.ReadLine
        a = Len(str1)
        For i = 1 To Len(str1)
            str2 = Mid(str1, i, 3)
            If str2 = "not" Then not1 = i
        Next
        For j = 1 To Len(str1)
            str3 = Mid(str1, j, 3)
            If str3 = "bad" Then bad = j

        Next

        Console.WriteLine("processed string :" & Left(str1, not1 - 1) & "good" & Right(str1, a - (bad + 2)))

        Console.ReadKey()



    End Sub

End Module