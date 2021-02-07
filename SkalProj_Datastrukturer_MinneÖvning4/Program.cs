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
          Console.WriteLine($"***Examine a List***" 
             + $"\nUse + or - before name. " 
             + $"Examle: (+Adam) to Add or (-Adam) to Remove Adam "
             + $"\nUse 0 exit to main menue.");
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
                      {   //Adds value by String content
                          theList.Add(sValue); Console.WriteLine($"( {sValue} ) has been added to the list\n List capacity {theList.Capacity}, "
                               + $"\nList content of {theList.Count} elements:");// In both cases, look at the count and capacity of the list
                          //prints content of list
                          foreach (var item in theList){ Console.WriteLine($"({item})");}
                      }
                      break;
          
                  case '-':      // '-': Remove the rest of the input from the list (The user could write -Adam and "Adam" would be removed from the list)
                      if (sValue.Length > 0)
                      {   //Removes value by String content
                          if (theList.Remove(sValue)) { Console.WriteLine($"( {sValue} ) has been Removed from list "); }
                          else if (!theList.Remove(sValue)){ Console.WriteLine($"{sValue} has not been found, not able to be removed from list "); }
                          // In both cases, look at the count and capacity of the list
                          Console.WriteLine($"List capacity {theList.Capacity}, \nList content of {theList.Count} elements:");
                          //prints content of list
                          foreach (var item in theList){ Console.WriteLine($"({item})"); }
                      }
                      else if (sValue.Length < 0)
                      {Console.WriteLine($"use only + or - before name. Examle: (+Adam) to add or (-Adam) to remove Adam "); }
                      break;
          
                  case '0':
                      Console.WriteLine("0 exit to main menue.");
                      menuIsRunning = false;
                      Main();
                      break;
          
                  default:
                      Console.WriteLine($"Use only + or - before name. Examle: (+Adam) to add or (-Adam) to remove Adam \nUse 0 exit to main menue.");
                      break;
              }
          } while (menuIsRunning == true);
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
            Queue<string> q = new Queue<string> { };
            q.Clear();
            bool menuIsRunning = true;
            string input;
            char firstChar;
            string sValue;
            Console.WriteLine($"***Examine a Queue***\nUse; + before name \nUse: - to remove first name from line " 
               + $"\nRemember -First in -First Out \nUse: 0 exit to main menue.");
            do
            {
                input = Console.ReadLine();
                firstChar = input[0];
                sValue = input.Substring(1);

                switch (firstChar)
                {
                    //add new element in line
                    case '+':
                        if (sValue.Length > 0) { q.Enqueue(sValue); Console.WriteLine($"{sValue} was Added to Queue and is now last of {q.Count} elements: ");
                            //prints content of list
                            foreach (var item in q) { Console.WriteLine($"({item})"); } }
                        else if (sValue.Length < 1) { Console.WriteLine($"Nothing was Added after you typed + \nDo it Again!"); }
                        
                        break;

                    //remove element from list
                    case '-':
                        if (q.Count > 0) { string toBeRemoved = q.Dequeue(); Console.WriteLine($"{toBeRemoved} was Removed from Queue, now {q.Count} elements in the Queue"); 
                            foreach (var item in q) { Console.WriteLine($"({item})"); } }
                        else if (q.Count < 1) { Console.WriteLine($"{q.Count} elements in the Queue.... Seems hard to remove someone from queue now"); }
                        
                        break;
                    //user inputs something to exit to main menue.
                    case '0':
                        Console.WriteLine("0 exit to main menue.");
                        menuIsRunning = false;
                        Main();
                        break;

                    default:
                        Console.WriteLine($"Use only + before name " 
                           + $"\nor - to remove first name from line " 
                           + $"\nUse 0 exit to main menue.");
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
              Stack<string> s = new Stack<string> { };
         bool menuIsRunning = true;
         string input;
         char firstChar;
         string sValue;
         Console.WriteLine($"***Examine a Stack***"
             + "\n$Remember -First In -Last Out "
             + "\n$Use: + before name "
             + "\n$Use: - to remove last name from line "
             + "\n$Use: 1 before you write something and get it back reverse"
             + "\n$Use: 0 exit to main menue.");
         do
         {
             input = Console.ReadLine();
             firstChar = input[0];
             sValue = input.Substring(1);

             switch (firstChar)
             {
                    //cases to push items
                case '+':
                    if (sValue.Length > 0) { s.Push(sValue); Console.WriteLine($"{sValue} was Added to Stack and is now last of {s.Count} elements:");
                        //prints content of list
                        foreach (var item in s) { Console.WriteLine($"({item})"); } }
                    else if (sValue.Length < 1) { Console.WriteLine($"Nothing was Added after you typed + \nDo it Again!"); }
                    break;
                //cases to pop items
                case '-':
                    if (s.Count > 0) { string poped = s.Pop(); Console.WriteLine($"{poped} was Removed from Stack, now {s.Count} elements: "); 
                        foreach (var item in s) { Console.WriteLine($"({item})"); } }
                    else if (s.Count < 1) { Console.WriteLine($"{s.Count} elements in the Stack.... Seems hard to remove someone from stack now"); }
                    break;
                //loops strings back reverse
                case '1':
                    if (sValue.Length > 0)
                    {   Console.WriteLine($"reverse: ");
                        for (int i = 0; i < sValue.Length; i++){ char c = sValue[i]; string sx = c.ToString(); s.Push(sx);}
                        foreach (var item in s) { Console.Write($"{item}");}
                        s.Clear();
                    }
                    else if (sValue.Length < 1) { Console.WriteLine($"Nothing was Added after you typed 1 \nDo it Again!"); }
                    break;
                //user inputs something to exit to main menue.
                case '0':
                Console.WriteLine("0 exit to main menue.");
                menuIsRunning = false;
                Main();
                break;

                default:
                Console.WriteLine($"Use only:"
                   + "\n$ + before name"
                   + "\n$ - to remove last name from line "
                   + "\n$ 1 before you write something and get it back reverse"
                   + "\n$ 0 exit to main menue.");
                break;
             }
          } while (menuIsRunning == true);
      }

        static void CheckParanthesis()
        {
            /*
             * Use this method to check if the paranthesis in a string is Correct or incorrect.
             * Example of correct: (()), {}, [({})],  List<int> list = new List<int>() { 1, 2, 3, 4 };
             * Example of incorrect: (()]), [), {[()}],  List<int> list = new List<int>() { 1, 2, 3, 4 );
             */
            bool menuIsRunning = true;
            string input;
            int i = 0;
            char firstChar;
            string correct = "Example of correct: (()), { }, [({ })],  List<int> list = new List<int>() { 1, 2, 3, 4 };";
            string incorrect = "Example of incorrect: (()]), [), {[()}],  List<int> list = new List<int>() { 1, 2, 3, 4 );";
            
            Stack<char> ExpectedParanthesisStack = new Stack<char> { };
            Dictionary<char, char> ParanthesisDictionary = new Dictionary<char, char>  {
                 { '(',')' }, //   Parentheses()
                 { '[',']' }, //   Brackets[]
                 { '{','}' }  //   Braces {}
            };

            Console.WriteLine($"***CheckParanthesis***"
             + "\n$Check if the paranthesis in a string is Correct or incorrect "
             + "\n$Use: 1 To write something with paranthesis"
             + "\n$Use: 0 exit to main menue.");

            do
            {
                input = Console.ReadLine();
                firstChar = input[0];
                switch (firstChar)
                {
                    case ('1'):
                        bool isParanthesisCorrect = true;
                        Console.WriteLine($"Write something with paranthesis"
                            + "\n$ { () } Parentheses "
                            + "\n$ { [] }Brackets"
                            + "\n$ { {} } Braces");
                        input = Console.ReadLine();

                        if (input.Contains('(') || input.Contains(')')
                            || input.Contains('[') || input.Contains(']') 
                            || input.Contains('{') || input.Contains('}'))
                        {
                           foreach (char c in input)
                           {
                               if (ParanthesisDictionary.ContainsKey(c))
                               {ExpectedParanthesisStack.Push(ParanthesisDictionary[c]);}
                               if (ParanthesisDictionary.ContainsValue(c))
                               {if (c == ExpectedParanthesisStack.Peek()) { ExpectedParanthesisStack.Pop(); }
                                   else if (c != ExpectedParanthesisStack.Peek()) { isParanthesisCorrect = false; }
                               } i++;
                           }if(ExpectedParanthesisStack.Count != 0) { isParanthesisCorrect = false; }
                            Console.WriteLine($"You Writed: " + input);
                            if (isParanthesisCorrect){Console.WriteLine($"The paranthesis you writed is Correct");
                            }else if (!isParanthesisCorrect){Console.WriteLine($"The paranthesis you writed is inCorrect");}
                        }
                        else { Console.WriteLine($"Write something with paranthesis "); }

                        
                        break;
                    case '0':
                        Console.WriteLine("0 exit to main menue.");
                        menuIsRunning = false;
                        Main();
                        break;

                    default:
                        Console.WriteLine($"Use only:"
                           + "\n$ 1 To write something with paranthesis "
                           + "\n$ 0 exit to main menue.");
                        break;
                }
            } while (menuIsRunning);
        }
    }
}
