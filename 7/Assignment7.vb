Module Module1

    Sub Main()
        Dim str1, str2 As String
        Dim a As Integer

        str1 = ""
        str2 = ""
        a = 0

        Console.Write("enter string to process :")
        str1 = Console.ReadLine

        a = Len(str1)
        If a > 2 Then str2 = Left(str1, 2) & Right(str1, 2) Else str2 = str1

        Console.WriteLine("processed string :" & str2)
        Console.ReadKey()


    End Sub

End Module
