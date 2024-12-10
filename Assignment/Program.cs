using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Program
    {
        static void Main()
        {
            #region Question 1
            //1- Write a program that takes a number from the user then print yes
            //if that number can be divided by 3 and 4 otherwise print no.
            //Example(1)
            //Input: 12
            //Output:Yes
            //Example(2)
            //Input: 9
            //Output:No

            //Console.WriteLine("please Enter a Number: ");
            //int.TryParse(Console.ReadLine(), out int Number);
            //if (Number / 3 == 4 && Number / 4 == 3)
            //{
            //    Console.WriteLine("Yes");
            //}
            //else
            //{
            //    Console.WriteLine("No");
            //}

            //Another solution

            //Console.WriteLine("please Enter a Number: ");
            //int.TryParse(Console.ReadLine(), out int Number);
            //if (Number == 12)
            //{
            //    Console.WriteLine("Yes");
            //}
            //else
            //{
            //    Console.WriteLine("No");
            //}
            #endregion

            #region Question 2
            //2- Write a program that allows the user to insert an integer then print negative
            //if it is negative number otherwise print positive.
            //Example(1)
            //Input: -5
            //Output:negative
            //Example(2)
            //Input: 10
            //Output:positive

            //Console.WriteLine("please insert integer : ");
            //int.TryParse(Console.ReadLine(), out int integer);
            //if (integer < 0)
            //{
            //    Console.WriteLine("negative");
            //}
            //else
            //{
            //    Console.WriteLine("positive");
            //}
            #endregion

            #region Question 3
            //3- Write a program that takes 3 integers from the user then prints the max element and the min element.
            //Example(1)
            //Input:7,8,5
            //Output:
            //max element = 8
            //min element = 5
            //Example(2)
            //Input:3 6 9
            //Outputs:
            //Max element = 9
            //Min element = 3

            //Console.WriteLine("please Enter the first Number");
            //if (!int.TryParse(Console.ReadLine(), out int num1))
            //{
            //    Console.WriteLine("invaled Number");
            //    return;
            //}
            //Console.WriteLine("please Enter the second Number");
            //if (!int.TryParse(Console.ReadLine(), out int num2) )
            //{
            //    Console.WriteLine("invaled Number");
            //    return;
            //}
            //Console.WriteLine("please Enter the Third Number");
            //if (!int.TryParse(Console.ReadLine(), out int num3) )
            //{
            //    Console.WriteLine("invaled Number");
            //    return;
            //}
            //int max = Math.Max(num1, Math.Max(num2, num3));
            //int min = Math.Min(num1, Math.Min(num2, num3));
            //Console.WriteLine("Max element = " + max);
            //Console.WriteLine("Min element = " + min);
            #endregion

            #region Question 4
            //4- Write a program that allows the user to insert an integer number then check
            //If a number is even or odd.

            //Console.WriteLine("please insert an integer number");
            //int.TryParse(Console.ReadLine(), out int number);
            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("this is even number");
            //}
            //else
            //{
            //    Console.WriteLine("this is odd number");
            //}
            #endregion

            #region Question 5
            //5- Write a program that takes character from the user then
            //if it is a vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant).
            //Example(1)
            //Input: O
            //Output:vowel
            //Example(2)
            //Input: b
            //Output:Consonant

            // Console.WriteLine("please Enter the character");
            //char character = Console.ReadLine()[0];
            // switch (character) 
            // {
            //     case 'a':
            //         Console.WriteLine("Vowel");
            //         break;
            //     case 'e':
            //         Console.WriteLine("Vowel");
            //         break;
            //     case 'i':
            //         Console.WriteLine("Vowel");
            //         break;
            //     case 'o':
            //         Console.WriteLine("Vowel");
            //         break;
            //     case 'u':
            //         Console.WriteLine("Vowel");  
            //         break;
            //     default:
            //         Console.WriteLine("Consonant"); 
            //         break;
            // }
            #endregion

            #region Question 6
            //6- Write a program that allows the user to insert an integer
            //then print all numbers between 1 to that number.
            //Example
            //Input: 5
            //Output:1, 2, 3, 4, 5

            //Console.WriteLine("Please insert an integer");
            //int.TryParse(Console.ReadLine(), out int number);
            //Console.WriteLine("------------------------------");
            //for (int i =1; i <=number; i++)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion

            #region Question 7
            //7- Write a program that allows the user to insert an integer then 
            //print a multiplication table up to 12.
            //Example
            //Input: 5
            //Outputs: 5 10 15 20 25 30 35 40 45 50 55 60

            //Console.WriteLine("Please insert an integer");
            //int.TryParse(Console.ReadLine(), out int number);
            //Console.WriteLine("------------------------------");
            //for (int i = 1; i <= 12; i++)
            //{
            //    Console.WriteLine(number * i);
            //}
            #endregion

            #region Question 8
            //8- Write a program that allows to user to insert number
            //then print all even numbers between 1 to this number
            //Example:
            //Input: 15
            //Output: 2 4 6 8 10 12 14

            //Console.WriteLine("Please insert an integer");
            //int.TryParse(Console.ReadLine(), out int number);
            //Console.WriteLine("------------------------------");
            //for (int i =2; i <= number; i +=2)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion

            #region Question 9
            //9- Write a program that takes two integers then prints the power.
            //Example:
            //Input: 4 3
            //Output:64
            //Hint: how to calculate 4 ^ 3 = 4 * 4 * 4 = 64

            //Console.WriteLine("Enter the First Number: ");
            //int.TryParse(Console.ReadLine(), out int x);

            //Console.WriteLine("Enter the Second Number: ");
            //int.TryParse(Console.ReadLine(), out int y);
            //int result = 1;
            //for (int i = 0; i < 3; i++)
            //{
            //    result = result * 4;
            //}
            //Console.WriteLine($"Power: {result}");
            #endregion

            #region Question 10
            //10- Write a program to enter marks of five subjects and calculate total, average and percentage.
            //Example
            //Input: -Enter Marks of five subjects: 95 76 58 90 89
            //Output: Total marks = 408
            //Average Marks = 81
            //Percentage = 81

            //Console.WriteLine("please enter mark1 : ");
            //int.TryParse(Console.ReadLine(), out int mark1);
            //Console.WriteLine("please enter mark2 : ");
            //int.TryParse(Console.ReadLine(), out int mark2);
            //Console.WriteLine("please enter mark3 : ");
            //int.TryParse(Console.ReadLine(), out int mark3);
            //Console.WriteLine("please enter mark4 : ");
            //int.TryParse(Console.ReadLine(), out int mark4);
            //Console.WriteLine("please enter mark5 : ");
            //int.TryParse(Console.ReadLine(), out int mark5);
            //Decimal sum =mark1 + mark2+mark3 + mark4+ mark4;
            //Console.WriteLine($"sum= {sum}");
            //Decimal Average =sum/5;
            //Console.WriteLine($"Average= {Average}");
            //Decimal Percentage = (sum/500)*100;
            //Console.WriteLine($"Percentage ={Percentage}");
            #endregion

            #region Question 11
            //11 - Write a program to input the month number and print the number of days in that month.
            //Example
            //Input: Month Number: 1
            //Output: Days in Month: 31

            //Console.WriteLine("please Enter the month number : ");
            //int.TryParse(Console.ReadLine(), out int Num);
            //switch (Num)
            //{
            //    case 1:
            //        Console.WriteLine(" the number of days in that month 31");
            //        break;
            //    case 2:
            //        Console.WriteLine("the number of days in that month 29");
            //        break;
            //    case 3:
            //        Console.WriteLine("the number of days in that month 31");
            //        break;
            //    case 4:
            //        Console.WriteLine("the number of days in that month 30");
            //        break;
            //    case 5:
            //        Console.WriteLine("the number of days in that month 31");
            //        break;
            //    case 6:
            //        Console.WriteLine("the number of days in that month 30");
            //        break;
            //    case 7:
            //        Console.WriteLine("the number of days in that month 31");
            //        break;
            //    case 8:
            //        Console.WriteLine("the number of days in that month 31");
            //        break;
            //    case 9:
            //        Console.WriteLine("the number of days in that month 30");
            //        break;
            //    case 10:
            //        Console.WriteLine("the number of days in that month 31");
            //        break;
            //    case 11:
            //        Console.WriteLine("the number of days in that month 30");
            //        break;
            //    default:
            //        Console.WriteLine("the number of days in that month 31");
            //        break;
            //}
            #endregion

            #region Question 12
            //12- Write a program to create a Simple Calculator.

            //Console.WriteLine("please Enter the first Num : ");
            //int.TryParse(Console.ReadLine(), out int Num1);
            //Console.WriteLine("please Enter the Second Num :");
            //int.TryParse(Console.ReadLine(), out int Num2);
            //Console.WriteLine("please Enter the operation (+, _, *, /, %): ");
            //Char.TryParse(Console.ReadLine(), out Char operation);

            //switch (operation)
            //{
            //    case '+':
            //        Console.WriteLine($"sum= {Num1 + Num2}");
            //        break;
            //    case '_':
            //        Console.WriteLine($"Sub= {Num1 - Num2}");
            //        break;
            //    case '*':
            //        Console.WriteLine($"Multiply= {Num1 * Num2}");
            //        break;
            //    case '/':
            //        Console.WriteLine($"Divides= {Num1 / Num2}");
            //        break;
            //    case '%':
            //        Console.WriteLine($"moduls= {Num1 % Num2}");
            //        break;
            //    default:
            //        Console.WriteLine("Not Available");
            //        break;
            //}
            #endregion

            #region Question 13
            //13- Write a program to allow the user to enter a string and print the REVERSE of it.

            //Console.WriteLine("please Enter the text: ");
            //string text = Console.ReadLine();
            //string reversed = "";
            //for (int i = text.Length - 1; i >= 0; i--)
            //{
            //    reversed += text[i];
            //}
            //Console.WriteLine("the reverse text: " + reversed);
            #endregion

            #region Question 14
            //14- Write a program to allow the user to enter int and print the REVERSED of it.

            //Console.WriteLine("please Enter the Number: ");
            //string num = Console.ReadLine();
            //string reversed = "";
            //for (int i = num.Length - 1; i >= 0; i--)
            //{
            //    reversed += num[i];
            //}
            //Console.WriteLine("the reverse num: " + reversed);
            #endregion

            #region Question 15
            //15- Write a program in C# Sharp to find prime numbers within a range of numbers.
            //Test Data :
            //Input starting number of range: 1
            //Input ending number of range: 50
            //Expected Output :
            //The prime number between 1 and 50 are:
            //2 3 5 7 11 13 17 19 23 29 31 37 41 43 47

            //Console.Write("Input starting number of range: ");
            //int start = int.Parse(Console.ReadLine());
            //Console.Write("Input ending number of range: ");
            //int end = int.Parse(Console.ReadLine());
            //Console.WriteLine($"The prime numbers between {start} and {end} are:");
            #endregion

            #region Question 16
            //16- . Write a program in C# Sharp to convert a decimal number into binary without using an array.
            //Test Data :
            //Enter a number to convert: 25
            //Expected Output :
            //The Binary of 25 is 11001.

            //Console.Write("Enter a number to convert: ");
            //int number = int.Parse(Console.ReadLine());
            //string binary = "";
            //while (number > 0)
            //{
            //    binary = (number % 2) + binary; // Add the remainder to the front of the binary string
            //    number = number / 2; // Divide the number by 2
            //}


            //Console.WriteLine("The Binary of " + number + " is " + binary);
            #endregion

            #region Question 17
            //17- Create a program that asks the user to input three points (x1, y1), (x2, y2), and (x3, y3),
            //and determines whether these points lie on a single straight line.

            //Console.Write("Enter x1: ");
            //double x1 = double.Parse(Console.ReadLine());
            //Console.Write("Enter y1: ");
            //double y1 = double.Parse(Console.ReadLine());
            //Console.Write("Enter x2: ");
            //double x2 = double.Parse(Console.ReadLine());
            //Console.Write("Enter y2: ");
            //double y2 = double.Parse(Console.ReadLine());
            //Console.Write("Enter x3: ");
            //double x3 = double.Parse(Console.ReadLine());
            //Console.Write("Enter y3: ");
            //double y3 = double.Parse(Console.ReadLine());
            //double SL1 = (y2 - y1) / (x2 - x1);
            //double SL2 = (y3 - y2) / (x3 - x2);
            //if (SL1 == SL2)
            //{
            //    Console.WriteLine("The points lie on a single straight line.");
            //}
            //else
            //{
            //    Console.WriteLine("The points do not lie on a single straight line.");
            //}
            #endregion

            #region Question 18
            //18- Within a company, the efficiency of workers is evaluated based on the duration
            //required to complete a specific task. A worker's efficiency level is determined as follows: 
            //-If the worker completes the job within 2 to 3 hours, they are considered highly efficient.
            //- If the worker takes 3 to 4 hours, they are instructed to increase their speed.
            //- If the worker takes 4 to 5 hours, they are provided with training to enhance their speed.
            //- If the worker takes more than 5 hours, they are required to leave the company.
            //To calculate the efficiency of a worker, the time taken for the task is obtained via user input from the keyboard.

            //Console.WriteLine("Enter the time taken to complete the task (in hours): ");
            //int.TryParse(Console.ReadLine(), out int time);
            //switch (time)
            //{
            //    case 2:
            //    case 3:
            //        Console.WriteLine("Highly efficient");
            //        break;
            //    case 4:
            //        Console.WriteLine("Increase speed");
            //        break;
            //    case 5:
            //        Console.WriteLine("Training required to enhance speed");
            //        break;

            //    default:
            //        {
            //            Console.WriteLine("they are required to leave the company.");
            //        }
            //        break;
            #endregion


        }
    }
}
