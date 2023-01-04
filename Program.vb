Imports System

Module Division_calculator
    Sub Main()
        Dim number1, number2, remainder As Decimal
        Dim total As Integer
        Console.WriteLine("Division calculator. Please enter the first number")
        number1 = Console.ReadLine()
        Console.WriteLine("Please enter the second number")
        number2 = Console.ReadLine()
        remainder = number1 Mod number2
        total = number1 \ number2
        Console.WriteLine(number1 & " divided by " & number2 & " is " & total & " has a remainder of: " & remainder)
    End Sub
End Module
