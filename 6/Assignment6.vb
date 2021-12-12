Module Module1

    Sub Main()
        Dim NOD As Integer
        NOD = 0


        Console.Write("enter number of donuts :")
        NOD = Console.ReadLine

        If NOD < 10 Then
            Console.Write("number of donuts :" & NOD)

        Else
            Console.Write("number of donuts = many")

        End If
        Console.ReadKey()

    End Sub

End Module
