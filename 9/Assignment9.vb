Module Module1

    Sub Main()

        Dim STR1, STR2, STR3, STR4, STR5, STR6 As String
        Dim CHAR1, CHAR2 As Char
        Dim i, j As Integer


        STR1 = ""
        STR2 = ""
        STR3 = ""
        STR4 = ""
        STR5 = ""
        STR6 = ""
        CHAR1 = ""
        CHAR2 = ""
        i = 0
        j = 0


        Console.Write("ENTER STRING 1 :")
        STR1 = Console.ReadLine
        Console.Write("ENTER STRING 2 :")
        STR2 = Console.ReadLine


        STR3 = Left(STR1, 2)
        STR4 = Left(STR2, 2)

        For i = 3 To Len(STR1)
            CHAR1 = Mid(STR1, i, 1)
            STR5 = STR5 & CHAR1
        Next i

        For j = 3 To Len(STR2)
            CHAR2 = Mid(STR2, j, 1)
            STR6 = STR6 & CHAR2
        Next j

        Console.WriteLine("PROCESSED STRING :" & STR4 & STR5 & " " & STR3 & STR6)
        Console.ReadKey()
    End Sub

End Module
