using System;
using System.Collections.Generic;

Console.Write("Enter an input: ");
string? userInput = Console.ReadLine();

int inputTypeInt;
while(true)
{
    Console.Write("Here are the possible types of input:\n"+
                "Press 1 for String\nPress 2 for Integer\nPress 3 for Boolean\n"+
                "What is the type of your input? ");
    string? inputTypeStr = Console.ReadLine();

    bool success = Int32.TryParse(inputTypeStr, out inputTypeInt);

    if (success && (inputTypeInt >= 1) && (inputTypeInt <= 3))
        break;
    else
        Console.WriteLine("Invalid input.");
}


switch (inputTypeInt)
{
    case 1:
        bool validString = true;
        int charToInt;
        Console.WriteLine("======================================================");
        Console.WriteLine("Listing the characters you entered:");
        for (int i = 0; i < userInput.Length; i++)
        {
            charToInt = (int)userInput[i];
            Console.WriteLine($"char: {userInput[i]} | ASCII: {charToInt}");
            if ((charToInt <= 64 && charToInt != 32) || (charToInt >= 91 && charToInt <= 96)
            || (charToInt >= 123))
            {
                Console.WriteLine($"An invalid character was found: {userInput[i]}"+
                $"\n\tIts ASCII value is {charToInt}"+
                $"\n\tIndex position: {i}\n\tThis character is not a letter. Please restart "
                + "the program and reenter the input using only letters from the Latin alphabet.");
                Console.WriteLine($"The value '{userInput}' contains one or more invalid characters,"+
                " so it is not a valid string.");
                validString = false;
                break;
            }
        }

        if (validString == true)
        {
            Console.WriteLine($"The value '{userInput}' is a valid string.");
            break;
        } else
            break;
    case 2:
        //int userInputInt;
        bool success2 = Int32.TryParse(userInput, out int userInputInt);
        if (success2)
        {
            Console.WriteLine($"The value '{userInputInt}' is a valid integer.");
            break;
        }else
        {
            Console.WriteLine($"The value '{userInput}' is not a valid integer.");
            break;
        }
    default:
        bool success3 = Boolean.TryParse(userInput, out bool userInputBool);
        if (success3)
        {
            Console.WriteLine($"The value '{userInputBool}' is a valid boolean.");
            break;
        }else
        {
            Console.WriteLine($"The value '{userInput}' is not a valid boolean.");
            break;
        }
}