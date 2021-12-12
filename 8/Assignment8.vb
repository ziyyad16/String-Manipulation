Module Module1

    Sub Main()
        Dim STR1, STR2 As String
        Dim CHAR1, CHAR2 As Char

        Dim i As Integer


        STR1 = ""
        STR2 = ""
        CHAR1 = ""
        CHAR2 = ""

        i = 0


        Console.Write("ENTER STRING TO PROCESS :")
        STR1 = Console.ReadLine



        CHAR1 = Left(STR1, 1)
        For i = 2 To Len(STR1)
            CHAR2 = Mid(STR1, i, 1)
            If CHAR2 <> CHAR1 Then STR2 = STR2 & CHAR2 Else STR2 = STR2 & "*"


        Next i


        Console.WriteLine("PROCESSED STRING :" & Left(STR1, 1) & STR2)
        Console.ReadKey()
    End Sub

End Module
