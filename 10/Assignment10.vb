Module Module1

    Sub Main()

        Dim STR1, STR2 As String

        Dim a As Integer


        STR1 = ""
        STR2 = ""
        a = 0




        Console.Write("STRING TO PROCESS :")
        STR1 = Console.ReadLine
        a = Len(STR1)
        STR1 = LCase(STR1)
        If a < 3 Then STR2 = STR1
        If a > 2 And Right(STR1, 3) = "ing" Then
            STR2 = STR1 & "ly"
        ElseIf a > 2 And Right(STR1, 3) <> "ing" Then
            STR2 = STR1 & "ing"
            End If

        Console.WriteLine("PROCESSED STRING :" & STR2)
        Console.ReadKey()

    End Sub

End Module
