'Calvin Coxen
'RCET0265
'Fall 2020
'Simple Calculator


Module SimpleCalculator

    Sub Main()

        'Variables for the numbers and mathematical operation selected by the user
        Dim userFirstNum As Integer
        Dim userSecondNum As Integer
        Dim userSelect As String

        'Text prompting the user to input two integers
        Console.WriteLine("Select your first number: ")
        userFirstNum = Console.ReadLine()
        Console.WriteLine("Select your second number: ")
        userSecondNum = Console.ReadLine()

        'Text prompting the user to choose what math they would like to see done for the two numbers
        Console.WriteLine("Select the mathematical operation: ")
        Console.WriteLine("1. Sum")
        Console.WriteLine("2. Product")
        Console.WriteLine("3. Difference")
        Console.WriteLine("4. Divide")
        userSelect = Console.ReadLine()

        ' If statement that outputs what operation the user has chosen and displays the full equation
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
