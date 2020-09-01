'Calvin Coxen
'RCET0265
'Fall 2020
'Simple Calculator


Module Module1

    Sub Main()

        Dim userFirstNum As Integer
        Dim userSecondNum As Integer
        Dim userSelect As String

        Console.WriteLine("Select your first number: ")
        userFirstNum = Console.ReadLine()

        Console.WriteLine("Select your second number: ")
        userSecondNum = Console.ReadLine()

        Console.WriteLine("Select the mathematical operation: ")
        Console.WriteLine("1. Sum")
        Console.WriteLine("2. Product")
        Console.WriteLine("3. Difference")
        Console.WriteLine("4. Divide")
        userSelect = Console.ReadLine()

        If userSelect = 1 Then
            Console.WriteLine(userFirstNum & " + " & userSecondNum & " = " & userFirstNum + userSecondNum)

        ElseIf userSelect = 2 Then
            Console.WriteLine(userFirstNum & " * " & userSecondNum & " = " & userFirstNum * userSecondNum)
        ElseIf userSelect = 3 Then
            Console.WriteLine(userFirstNum & " - " & userSecondNum & " = " & userFirstNum - userSecondNum)
        ElseIf userSelect = 4 Then
            Console.WriteLine(userFirstNum & " / " & userSecondNum & " = " & userFirstNum / userSecondNum)
        End If

        Console.ReadLine()
    End Sub

End Module
