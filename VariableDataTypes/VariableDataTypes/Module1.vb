
'----------------------------------------------------------------------------
'Program Info
'----------------------------------------------------------------------------
'Program: Variable Data Types
'Date: 9/24/2025
'Author: Mike Catrone
'Operation: This program will display several outputs of different data types I have
'           chosen for the given variable.
'
'
'
'
'-----------------------------------------------------------------------------
'Change Log
'-----------------------------------------------------------------------------
'Date                   Programmer                      Change
'-----------------------------------------------------------------------------
'9/24/2025              Mike Catrone                    Initial Build




Module Module1

    Sub Main()

        '1 - Someone's Age. I chose Byte because someone's age will never be larger than 255 or less than 0.
        Dim Age As Byte = 39


        '2 - Someone's DoB. I chose Date because it is specificially built for storing date and time information. Using the .toString("MM/dd/yyyy") method helps get just the date.
        Const DateOfBirth As Date = #05/11/1986#


        '3 - Bank Account Balance. I chose Decimal with a "D" at the end of the value because we want a precise decimal value for someone's finances.
        Dim BankBalance As Decimal = 1000000.56D


        '4 - Scale 1-10. I chose Byte because we only want a very small number within the range of 0-255
        Dim Rating As Byte = 10


        '5 - Time Class Starts. I chose Date because it contains the time as well. Adding the .toString("HH:mm") method gives us the time by itself.
        Dim ClassTime As Date = #8:30#


        '6 - PI. I chose decimal with the "D" at the end of the value so we can get a precise decimal-type value for pi.
        Const Pi As Decimal = 3.14159D


        '7 - Celsius temp, without decimal points. SByte is a great use of negative and positive values in a small range.
        Dim CelsiusTemp As SByte = -10


        '8 - Y or N Prompt. The Boolean type is made specifically for True False situations.
        Dim TrueFalse As Boolean = True


        '9 - Car's Odometer. UInteger is a good choice for values above 0 that need to stretch into the hundred-thousands in value.
        Dim CarOdometer As UInteger = 220150


        '10 - Someone's Full Name. I chose String because a full name isn't a very large character value in general.
        Dim FullName As String = "Mike Catrone"



        'Program Title and line skip
        Console.WriteLine("-----------------------------------------")
        Console.WriteLine("-       Variable Data Types             -")
        Console.WriteLine("-----------------------------------------")
        Console.WriteLine("")

        Console.WriteLine("Here is a list of different data types")
        Console.WriteLine("")


        'Main data output
        Console.WriteLine($"  Age (Byte) = {Age} 
  Date of Birth (Date) = {DateOfBirth.toString("MM/dd/yyyy")}
  Bank Balance (Decimal)  = {BankBalance}
  Scale 1-10 (Byte) = {Rating}
  Class Time (Date) = {ClassTime.toString("HH:mm") & "AM"}
  Pi (Decimal) = {Pi}
  Celsius Temp (SByte) = {CelsiusTemp}c
  Y or N Prompt (Boolean) = {TrueFalse}
  Car's Odometer (UInteger) = {CarOdometer}km
  Full Name (String) = {FullName}
  ")



        'Waiting for keypress to terminate
        Console.Write("Press any key to Exit ")
        Console.ReadKey()


    End Sub

End Module
