﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            ////PART ONE greeting statement
            //string messageOne = "Hello World!";
            //string messageTwo = "I am Spartacus";



            //PART TWO set initial Spartacus attriutes
            //int ageOne = 35;
            //int ageTwo = 45;
            //int ageThree = 80;
            //double heightOne = 72.50;
            //double heightTwo = 91.45;
            //float weightOne = 210.0284606f;
            //float weightTwo = 331.12345678f;
            //bool isGodLikeOne = true;
            //bool isGodLikeTwo = false;
            //char genderMale = 'M';
            //char genderFemale = 'F';



            ////PART THREE display variable values
            //Console.WriteLine(messageOne);//Displays intial greeting to console
            //Console.WriteLine(messageTwo);



            ////PART FOUR mathematical operator, bool and char examples
            //Console.WriteLine(ageOne + ageTwo);//Addition example
            //Console.WriteLine(heightOne - heightTwo);//Subtraction example
            //Console.WriteLine(weightOne * weightTwo);//Multiplication example
            //Console.WriteLine(isGodLikeOne);//Bool example
            //Console.WriteLine(genderMale);//Char example



            ////PART FIVE variable reassignment
            //ageTwo = 70;
            //heightTwo = 35.12345f;
            //weightTwo = -429.1234573f;



            ////PART SIX mathematical operator example
            //Console.WriteLine(ageOne + ageTwo);
            //Console.WriteLine(heightOne - heightTwo);
            //Console.WriteLine(weightOne * weightTwo);
            //Console.WriteLine(ageTwo / ageOne);
            //Console.WriteLine(ageTwo % ageOne);
            //Console.WriteLine(ageThree / ageOne);
            //Console.WriteLine(ageThree % ageOne);



            ////PART SEVEN increment and decrement operator example
            //ageTwo = ageTwo + 1;
            //Console.WriteLine(ageTwo);
            //ageTwo++;
            //Console.WriteLine(ageTwo);
            //ageTwo--;
            //Console.WriteLine(ageTwo);

            //Console.WriteLine("5" == "5");
            //Console.WriteLine(40 != 40);
            //Console.WriteLine(11 < 4);



            //PART EIGHT concatenation example
            //Console.WriteLine(messageOne + " " + messageTwo + ".");
            //Console.WriteLine("I am " + ageOne + " years old, and yes it's " + isGodLikeOne + " I am godlike.");
            //Console.WriteLine("I weigh around " + weightOne + " pounds, and I am around " + heightOne + " inches tall.");
            //Console.WriteLine("I am {0} years old, and yes it's {1} I am godlike.", ageOne, isGodLikeOne);
            //Console.WriteLine("I weigh around {0} pounds, and I am around {} inches tall.", weightOne, heightOne);



            //PART NINE string equality examples
            //Console.WriteLine(messageTwo.Equals(messageOne));
            //Console.WriteLine(messageTwo.Equals("I am Spartacus"));

            //string myGreeting = "Hello";
            //Console.WriteLine(myGreeting.ToUpper());//prints "HELLO"
            //Console.WriteLine(myGreeting.ToLower());//prints "hello"
            //Console.WriteLine(myGreeting);// prints "Hello"



            //PART TEN string length examples
            //int messOneLength = messageOne.Length;
            //int messTwoLength = messageTwo.Length;

            //Console.WriteLine("The lenght of messageOne is " + messageOne.Length);
            //Console.WriteLine("The length of messageTwo is " + messageTwo.Length);
            //Console.WriteLine("The length of messageOne is " + messOneLength);
            //Console.WriteLine("The length of messageTwo is " + messTwoLength);

            //Console.WriteLine("Phil said,\"You've got red on you.\"");//Writing QUOTES



            ////PART ELEVEN conditional examples
            ////string city1 = "Vesuvius";
            ////string city2 = "Nola";
            ////string city3 = "Nuceria";
            ////int city1Distance, city2Distance, city3Distance;//allowed to put in one line as long a amount is not assigned

            //////Solicit user input examples
            ////Console.WriteLine("What is the distance to {0}", city1);
            ////city1Distance = int.Parse(Console.ReadLine());//converts string to int
            ////Console.WriteLine("What is the distance to " + city2 + "?");
            ////city2Distance = int.Parse(Console.ReadLine());
            ////Console.WriteLine("What is the distance to Nuceria?");
            ////city3Distance = int.Parse(Console.ReadLine());

            //if ((city1Distance <= 125)  && ((city1Distance) < city2Distance) && (city1Distance < city3Distance))
            //{
            //    Console.WriteLine("We will march to Vesuvius");
            //}
            //if ((city2Distance <= 125) && ((city2Distance < city1Distance) && (city2Distance < city3Distance)))
            //{
            //    Console.WriteLine("We will march to Nola");
            //}
            //if ((city3Distance <= 125) && ((city3Distance < city1Distance) && (city3Distance < city2Distance)))
            //{
            //    Console.WriteLine("We will march to Nuceria");
            //}



            ////PART TWELVE Parse examples
            //Console.WriteLine("What is your rank soldier?");
            //string rank = Console.ReadLine();

            //Console.WriteLine("What is your age soldier?");
            //int age = int.Parse(Console.ReadLine());

            //Console.WriteLine("What is your job soldier?");
            //string job = Console.ReadLine();

            //if ((rank == "officer") || (age <= 26))
            //{
            //    Console.WriteLine("Get your gear, kiss your family goodbye, put on your marching boots.");
            //}
            //else if ((job == "cook") || (age >= 26))
            //{
            //    Console.WriteLine("My army has to eat. Pack your pots and pans.");
            //}
            //else
            //{
            //    Console.WriteLine("Sorry you are staying home.");
            //}

            //switch (job)
            //{
            //    case "infantry":
            //        Console.WriteLine("You will carry a sword.");
            //        break;

            //    case "archers":
            //        Console.WriteLine("You will carry a now and arrow");
            //        break;

            //    case "supply":
            //        Console.WriteLine("You will carry parts and pans.");
            //        break;

            //    case "specialist":
            //        Console.WriteLine("You will operate the catapult.");
            //        break;

            //    default:
            //        Console.WriteLine("You will ride horseback.");
            //        break;
            //}



            ////PART THIRTEEN array examples
            //string[] foodList = new string[5];
            //foodList[0] = "Milk";
            //foodList[1] = "Fruit";
            //foodList[2] = "Meat";
            //foodList[3] = "Wine";
            //foodList[4] = "Bread";
            //Console.WriteLine("{0}, {1}, {2}, {3}, {4}", foodList[0], foodList[1], foodList[2], foodList[3], foodList[4]);

            //int[] foodAmount = new int[5];
            //foodAmount[0] = 1000;
            //foodAmount[1] = 100;
            //foodAmount[2] = 2000;
            //foodAmount[3] = 10000;
            //foodAmount[4] = 1500;
            ////int[] foodAmount = new int[] { 1000, 100, 2000, 10000, 1500 };//shortcut to write varibles below
            //Console.WriteLine(foodList[0] + ";" + foodAmount[0] + ", " + foodList[1] + ";" + foodAmount[1] + ", " + foodList[2] + ";" + foodAmount[2] + ", " + foodList[3] + ";" + foodAmount[3] + ", " + foodList[4] + ";" + foodAmount[4]);

            //Console.WriteLine(foodList.Length);

            //string[] elements = messageTwo.Split(" ");
            //Console.WriteLine(elements[0]); //prints "I"
            //Console.WriteLine(elements[1]); // prints "am"
            //Console.WriteLine(elements[2]); // prints "Spartacus"

            //String myName = "Sue";
            //char[] letters = myName.ToCharArray();
            //Console.Write(letters[0]);
            //Console.Write(letters[1]);
            //Console.WriteLine(letters[2]);



            //// PART FOURTEEN while loop example
            ////While Loop
            //string action = " ";
            //while (action != "exit")
            //{
            //    Console.WriteLine("What is your rank soldier?");
            //    string rank = Console.ReadLine();

            //    Console.WriteLine("What is your age soldier?");
            //    int age = int.Parse(Console.ReadLine());

            //    Console.WriteLine("What is your job soldier?");
            //    string job = Console.ReadLine();

            //    if ((rank == "officer") || (age <= 26))
            //    {
            //        Console.WriteLine("Get your gear, kiss your family goodbye, put on your marching boots.");
            //    }
            //    else if ((job == "cook") || (age >= 26))
            //    {
            //        Console.WriteLine("My army has to eat. Pack your pots and pans");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Sorry you are staying home.");
            //    }
            //    Console.WriteLine("Add another? Type exit to quit");
            //    action = Console.ReadLine();
            //}


            //// Do While Loop
            //string action = " ";
            //do
            //{
            //    Console.WriteLine("What is your rank soldier?");
            //    string rank = Console.ReadLine();

            //    Console.WriteLine("What is your age soldier?");
            //    int age = int.Parse(Console.ReadLine());

            //    Console.WriteLine("What is your job soldier?");
            //    string job = Console.ReadLine();

            //    if ((rank == "officer") || (age <= 26))
            //    {
            //        Console.WriteLine("Get your gear, kiss your family goodbye, put on your marching boots.");
            //    }
            //    else if ((job == "cook") || (age >= 26))
            //    {
            //        Console.WriteLine("My army has to eat. Pack your pots and pans");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Sorry you are staying home.");
            //    }
            //    Console.WriteLine("Add another? Type exit to quit");
            //    action = Console.ReadLine();
            //} while (action != "exit");

            ////PART FIFTEEN for -ParallelLoopResult examples
            //for (int i = 0; i < foodAmount.Length; i++) {
            //    Console.WriteLine(i); // if i = 0 then result = 0
            //}

            //for (int i = 0; i < foodAmount.Length; i++) {
            //    Console.WriteLine("Enter a value for " + foodList[i]);
            //    foodAmount[i] = int.Parse(Console.ReadLine());
            //    Console.WriteLine("");
            //}


            //PART SIXTEEN Methods

            int ageOne = 35;
            int ageTwo = 34;
            bool isGodLikeOne = true; // I am not showing all the code.
            bool isGodLikeTwo = false;
            isGodLikeOne = IsGodLike(ageOne);
            isGodLikeOne = IsGodLike(ageTwo);
            Console.WriteLine("To say our hero is God like is " + isGodLikeOne);
            Console.WriteLine("To say our hero is God like is " + isGodLikeTwo);

        }//Closes static Main Method

        static bool IsGodLike(int age)
        {
            bool status;
            if (age % 2 == 0)
            {
                status = false;
            }
            else
            {
                status = true;
            }
            return status;
        }


        //// Sting Method

        static string Reverse(string text)
        {
            char[] cArray = text.ToCharArray();
            string reverse = " ";
            for (int i = cArray.Length - 1; i > -1; i--)
            {
                reverse += cArray[i];
            }
            return reverse;
        }

        //// Int Array Method

        //static void Main(string[] args)
        //{
        //    Console.WriteLine("To say our hero is God like is " + isGodLikeOne);
        //    Console.WriteLine(Reverse(messageTwo));
        //}
        //static int[] Reverse(int[] text)
        //{
        //    char[] cArray = text.ToCharArray();
        //    string reverse = " ";
        //    for (int i = cArray.Length - 1; i > -1; i--)
        //    {
        //        reverse += cArray[i];
        //    }
        //    return reverse;
        //}
    }

}  