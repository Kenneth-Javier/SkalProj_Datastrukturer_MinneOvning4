using System;
using System.Collections.Generic;

namespace SkalProj_Datastrukturer_MinneÖvning4
{
   class Program
   {
            /// <summary>
            /// The main method, vill handle the menues for the program
            /// </summary>
            /// <param name="args"></param>
      static void Main()
      {

         while (true)
         {
            Console.WriteLine("Please navigate through the menu by inputting the number \n(1, 2, 3 ,4, 0) of your choice"
                + "\n1. Examine a List"
                + "\n2. Examine a Queue"
                + "\n3. Examine a Stack"
                + "\n4. CheckParanthesis"
                + "\n0. Exit the application");
            char input = ' '; //Creates the character input to be used with the switch-case below.
            try
            {
                input = Console.ReadLine()[0]; //Tries to set input to the first char in an input line
            }
            catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
            {
                Console.Clear();
                Console.WriteLine("Please enter some input!");
            }
            switch (input)
            {
                case '1':
                    ExamineList();
                    break;
                case '2':
                    ExamineQueue();
                    break;
                case '3':
                    ExamineStack();
                    break;
                case '4':
                    CheckParanthesis();
                    break;
                /*
                 * Extend the menu to include the recursive 
                 * and iterative exercises.
                 */
                case '0':
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4)");
                    break;
            }
         }
      }

      /// <summary>
      /// Examines the datastructure List
      /// </summary>
      static void ExamineList()
      {
          bool menuIsRunning = true;
          List<string> theList = new List<string>(10);
          string input;
          char firstChar;
          string sValue;
          Console.WriteLine($"Use + or - before name. Examle: (+Adam) to Add or (-Adam) to Remove Adam \nUse 0 to quit");
          // Loop this method untill the user inputs something to exit to main menue.
          do
          {
              input = Console.ReadLine();
              firstChar = input[0];
              sValue = input.Substring(1);
          
          
              // Create a switch statement with cases '+' and '-'
              switch (firstChar)
              {
                  case '+':      // '+': Add the rest of the input to the list (The user could write +Adam and "Adam" would be added to the list)
                      if (sValue.Length > 0)
                      {
                          //Adds value by String content
                          theList.Add(sValue);
                          Console.WriteLine($"( {sValue} ) has been added to the list");
                          Console.WriteLine($"List capacity {theList.Capacity}, \nList content of {theList.Count} elements:");// In both cases, look at the count and capacity of the list
                          //prints content of list
                          foreach (var item in theList)
                          { Console.WriteLine($"({item})"); }
                      }
                      break;
          
                  case '-':      // '-': Remove the rest of the input from the list (The user could write -Adam and "Adam" would be removed from the list)
                      if (sValue.Length > 0)
                      {
                          //Removes value by String content
                          if (theList.Remove(sValue))
                          { Console.WriteLine($"( {sValue} ) has been removed from list "); }
                          else if (!theList.Remove(sValue))
                          { Console.WriteLine($"{sValue} has not been found, not able to be removed from list "); }
                          // In both cases, look at the count and capacity of the list
                          Console.WriteLine($"List capacity {theList.Capacity}, \nList content of {theList.Count} elements:");
                          //prints content of list
                          foreach (var item in theList)
                          { Console.WriteLine($"({item})"); }
                      }
                      else if (sValue.Length < 0)
                      {
                          Console.WriteLine($"use only + or - before name. Examle: (+Adam) to add or (-Adam) to remove Adam ");
                      }
                      break;
          
                  case '0':
                      Console.WriteLine("0 for Quit");
                      menuIsRunning = false;
                      Environment.Exit(0);
                      break;
          
                  default:
                      Console.WriteLine($"Use only + or - before name. Examle: (+Adam) to add or (-Adam) to remove Adam \nUse 0 to Quit");
                      break;
              }
          } while (menuIsRunning == true);
      }
        static void TestQueue()
        {

        }

      /// <summary>
      /// Examines the datastructure Queue
      /// </summary>
      static void ExamineQueue()
      {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch with cases to enqueue items or dequeue items
             * Make sure to look at the queue after Enqueueing and Dequeueing to see how it behaves
            */
            Queue<string> examineQueue = new Queue<string> { };

          bool menuIsRunning = true;
          string input;
          char firstChar;
            Console.WriteLine($"Use 0 to quit");
            do
            {
                input = Console.ReadLine();
                firstChar = input[0];

                switch (firstChar)
                {
                    case '0':
                        Console.WriteLine("0 for Quit");
                        menuIsRunning = false;
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine($"Use only \nUse 0 to Quit");
                        break;
                }

            } while (menuIsRunning == true);
      }

      /// <summary>
      /// Examines the datastructure Stack
      /// </summary>
      static void ExamineStack()
      {
          /*
           * Loop this method until the user inputs something to exit to main menue.
           * Create a switch with cases to push or pop items
           * Make sure to look at the stack after pushing and and poping to see how it behaves
          */
      }

      static void CheckParanthesis()
      {
          /*
           * Use this method to check if the paranthesis in a string is Correct or incorrect.
           * Example of correct: (()), {}, [({})],  List<int> list = new List<int>() { 1, 2, 3, 4 };
           * Example of incorrect: (()]), [), {[()}],  List<int> list = new List<int>() { 1, 2, 3, 4 );
           */

      }
   }

}
