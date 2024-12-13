using static System.Runtime.InteropServices.JavaScript.JSType;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Drawing;

namespace Assignment_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Question1
            /*1)Write a program that takes a number from the user 
                then print yes if that number can be divided by
                 3 and 4 otherwise print no.*/

            Console.WriteLine("Enter number");
            int number = int.Parse(Console.ReadLine());
            if (num % 3 == 0 && num % 4 == 0)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");

            #endregion

            #region Question2
            /*2) Write a program that allows the user to insert an
                 integer then print negative if it is negative
                  number otherwise print positive.*/
            Console.WriteLine("Enter integer number");
            int Numb = int.Parse(Console.ReadLine());
            if (Numb > 0)
                Console.WriteLine("positive");
            else if (Numb < 0)
                Console.WriteLine("negative");
            #endregion

            #region Question3
            /* 3)Write a program that takes 3 integers from the user
                  then prints the max element and the min element.*/
            Console.WriteLine("Enter the first integer:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second integer:");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the third integer:");
            int num3 = int.Parse(Console.ReadLine());
            int max = num1;
            if (num2 > max)
            {
                max = num2;
            }
            if (num3 > max)
            {
                max = num3;
            }

            int min = num1;
            if (num2 < min)
            {
                min = num2;
            }
            if (num3 < min)
            {
                min = num3;
            }
            Console.WriteLine($"max element={max}");
            Console.WriteLine($"min element={min}");
            #endregion

            #region Question4
            /*4)Write a program that allows the user to insert an
               integer number then check If a number is even or odd.*/
            Console.WriteLine("enter integer number ");
            int Ino = int.Parse(Console.ReadLine());
            if (Ino % 2 == 0)
                Console.WriteLine("even");
            else
                Console.WriteLine("odd");
            #endregion

            #region Question5
            5)Write a program that takes character from the user
   
               then if it is a vowel chars(a, e, I, o, u) then print
               (vowel) otherwise print(consonant).
             Console.Write("Enter a character: ");
            char text = char.Parse(Console.ReadLine());
            if (text == 'a' || text == 'e' || text == 'i' || text == 'o' || text == 'u')
                Console.WriteLine("vowel");
            else
                Console.WriteLine("consonant");
            #endregion

            #region Question7
            /*7)Write a program that allows the user to insert an 
                integer then print a multiplication table up to 12.*/
            bool flag;
            int input;
            Console.WriteLine("Enter an integer number");
            flag = int.TryParse(Console.ReadLine(), out input);
            if (flag)
            {

                for (int i = 1; i <= 12; i++)
                {
                    Console.Write($"{input * i} ");
                }

            }
            #endregion

            #region Question9
            /*9) Write a program that takes two integers then prints
                    the power.*/
            Console.WriteLine("enter frist num");
            int fnum = int.Parse(Console.ReadLine());
            Console.WriteLine("enter second num");
            int snum = int.Parse(Console.ReadLine());
            double res = Math.Pow(fnum, snum);
            Console.WriteLine(res);
            #endregion

            #region Question10
            /*10)Write a program to enter marks of five subjects and
                 calculate total, average and percentage.*/
            int tot = 0;
            int numberOfSubjects = 5;
            double average, percentage;
            for (int i = 1; i <= numberOfSubjects; i++)
            {
                Console.Write("Enter marks for five subject ");
                int marks = int.Parse(Console.ReadLine());
                tot += marks;
            }
            average = tot / numberOfSubjects;
            percentage = ((tot / numberOfSubjects) * 100) / 100;
            Console.WriteLine("Total Marks= " + tot);
            Console.WriteLine("Average Marks= " + average);
            Console.WriteLine("Percentage=" + percentage); 
            #endregion

            #region Question11
            /*11)Write a program to input the month number and
                   print the number of days in that month.*/
            Console.WriteLine(" year Number:");
            int Yno = int.Parse(Console.ReadLine());
            Console.WriteLine(" Month Number:");
            int moNo = int.Parse(Console.ReadLine());
            int Days = DateTime.DaysInMonth(Yno, moNo);
            Console.WriteLine($"Days in Month:{Days}");
            #endregion

            #region Question18
            /*18) Within a company, the efficiency of workers is evaluated based on the duration required to complete a specific task. A worker's efficiency level is determined as follows: 
             - If the worker completes the job within 2 to 3 hours, they are considered highly efficient. 
              -If the worker takes 3 to 4 hours, they are instructed to increase their speed. 
             -If the worker takes 4 to 5 hours, they are provided with training to enhance their speed. 
            - If the worker takes more than 5 hours, they are required to leave the company. 
            To calculate the efficiency of a worker, the time taken for the task is obtained via user input from the keyboard.*/
            Console.WriteLine("Enter the time:");
            double time = double.Parse(Console.ReadLine());
            if (time >= 2 && time <= 3)
            {
                Console.WriteLine("The worker is highly efficient.");
            }
            else if (time > 3 && time <= 4)
            {
                Console.WriteLine("The worker is instructed to increase their speed.");
            }
            else if (time > 4 && time <= 5)
            {
                Console.WriteLine("The worker is provided with training to enhance their speed.");
            }
            else if (time > 5)
            {
                Console.WriteLine("The worker is required to leave the company.");
            }
            #endregion

            #region Question21
            /*21) Write C# program that Assigning one value type
                variable to another and modifying the value
                of one variable and mention what will happen*/

            int A;
            A = 8;
            Console.WriteLine(A);
            int B;
            B = 6;
            Console.WriteLine(B);
            B = A;
            Console.WriteLine(B);
            A--;
            Console.WriteLine("-------------------------");
            Console.WriteLine(A);
            Console.WriteLine(B);
            // B took the same value of A and wasn't changed after modifying A 
            #endregion

            #region Question22
            /*22) Write C# program that Assigning one reference
                 type variable to another and modifying the
                 object through one variable and mention what will happen*/
            Rectangle rec1; //Allocate 4 byte in stack
            // zero byte in Heap
            rec1 = new Rectangle();//Allocate required byte in Heap
            Console.WriteLine(rec1.GetHashCode());
            // Default width and height
            Console.WriteLine(rec1.Width);
            Console.WriteLine(rec1.Height);
            Rectangle rec2 = new Rectangle();
            Console.WriteLine(rec2.GetHashCode());
            rec2 = rec1;
            Console.WriteLine("-------------------------");
            Console.WriteLine(rec1.GetHashCode());
            Console.WriteLine(rec2.GetHashCode());
            #endregion

            #region Question23
            //23)Which of the following statements is correct about the C#.NET code snippet given below?
            int d;
            d = Convert.ToInt32(!(30 < 20));
            // answer A value 1 will be assigned to d. 
            #endregion

            #region Question24
            //24)Which of the following is the correct output for the C# code given below?
            Console.WriteLine(13 / 2 + " " + 13 % 2);
            // answer 6 1  
            #endregion

            #region Question25
            //25)What will be the output of the C# code given below?
            int num = 1, z = 5;
            if (!(num <= 0))
                Console.WriteLine(++num + z++ + " " + ++z);
            else
                Console.WriteLine(--num + z-- + " " + --z); */
            // answer 7 7 
            #endregion















        }
    }
}








            

        
    






    
    

