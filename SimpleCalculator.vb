'Calvin Coxen
'RCET0265
'Fall 2020
'Simple Calculator
'https://github.com/CalvinAC/SimpleCalculator.git

'Always add option statements to the top if your source code - TJR
'Your code crashes with these set to on
Option Strict On
Option Explicit On

Module SimpleCalculator

    Sub Main()

        'Variables for the numbers and mathematical operation selected by the user
        Dim userFirstNum As Integer
        Dim userSecondNum As Integer
        Dim userSelect As String
        Dim badInput As Boolean

        Do
            Try 'Converting user input to a number can result in an exception - TJR
                'Text prompting the user to input two integers
                Console.WriteLine("Select your first number: ")
                userFirstNum = CInt(Console.ReadLine()) ' Conversions must be explicit - TJR
                Console.WriteLine("Select your second number: ")
                userSecondNum = CInt(Console.ReadLine()) ' Conversions must be explicit - TJR
                badInput = False
            Catch e As Exception
                badInput = True
            End Try
        Loop While badInput = True

        'Text prompting the user to choose what math they would like to see done for the two numbers
        Console.WriteLine("Select the mathematical operation: ")
        Console.WriteLine("1. Sum")
        Console.WriteLine("2. Product")
        Console.WriteLine("3. Difference")
        Console.WriteLine("4. Divide")
        userSelect = Console.ReadLine()

        ' If statement that outputs what operation the user has chosen and displays the full equation
        'Comparing a string to an integer won't work with option strict on - TJR
        If userSelect = "1" Then
            Console.WriteLine(userFirstNum & " + " & userSecondNum & " = " & userFirstNum + userSecondNum)
        ElseIf userSelect = "2" Then
            Console.WriteLine(userFirstNum & " * " & userSecondNum & " = " & userFirstNum * userSecondNum)
        ElseIf userSelect = "3" Then
            Console.WriteLine(userFirstNum & " - " & userSecondNum & " = " & userFirstNum - userSecondNum)
        ElseIf userSelect = "4" Then
            Console.WriteLine(userFirstNum & " / " & userSecondNum & " = " & userFirstNum / userSecondNum)
        End If

        Console.ReadLine()
    End Sub

End Module
