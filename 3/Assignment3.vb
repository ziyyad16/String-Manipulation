Module Module1

    Sub Main()
        Dim str1 As String
        Dim char1 As Char
        Dim i, alphaCounter, digitCounter, specialChars As Integer

        str1 = ""
        char1 = ""
        i = 0
        alphaCounter = 0
        digitCounter = 0
        specialChars = 0

        Console.Write("enter string to process :")
        str1 = Console.ReadLine

        str1 = LCase(str1)
        For i = 1 To Len(str1)
            char1 = Mid(str1, i, 1)
            If char1 >= "a" And char1 <= "z" Then
                alphaCounter = alphaCounter + 1
            ElseIf char1 >= "0" And char1 <= "9" Then
                digitCounter = digitCounter + 1
            Else : specialChars = specialChars + 1

            End If

        Next

        Console.WriteLine("number of alphabets :" & alphaCounter)
        Console.WriteLine("number of digits :" & digitCounter)
        Console.WriteLine("number of special characters :" & specialChars)
        Console.ReadKey()



    End Sub

End Module
