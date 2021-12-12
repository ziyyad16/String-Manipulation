Module Module1

    Sub Main()
        'DECLARATIONS
        Dim Str1, alphabets As String
        Dim isPangram As Boolean
        Dim i As Integer
        Dim Char1 As Char

        'INITIALISATION
        Str1 = ""
        alphabets = "abcdefghijklmnopqrstuvwxyz"
        isPangram = True
        i = 0
        Char1 = ""

        'INPUT
        Console.Write("Enter string to process: ")
        Str1 = Console.ReadLine
        Str1 = LCase(Str1)

        'PROCESS
        For i = 1 To Len(alphabets)
            Char1 = Mid(alphabets, i, 1)
            If InStr(Str1, Char1) = 0 Then isPangram = False
            If isPangram = False Then Exit For
        Next i

        'OUTPUT
        If isPangram = True Then
            Console.WriteLine("Entered string is a Pangram.")
        Else
            Console.WriteLine("Entered string is NOT a Pangram.")
        End If

        console.readkey()
    End Sub

End Module
