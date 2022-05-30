using System;

namespace SkalProj_Datastrukturer_Minne
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
                    + "\n5. Fibonacci"
                    + "\n0. Exit the application");
                char input = ' '; //Creates the character input to be used with the switch-case below.
                try
                {
                    input = Console.ReadLine()![0]; //Tries to set input to the first char in an input line
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
                    case '5':
                       Console.WriteLine("Number 7 into the sequence: " + F(7));
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
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch statement with cases '+' and '-'
             * '+': Add the rest of the input to the list (The user could write +Adam and "Adam" would be added to the list)
             * '-': Remove the rest of the input from the list (The user could write -Adam and "Adam" would be removed from the list)
             * In both cases, look at the count and capacity of the list
             * As a default case, tell them to use only + or -
             * Below you can see some inspirational code to begin working.
            */

            //List<string> theList = new List<string>();
            //string input = Console.ReadLine();
            //char nav = input[0];
            //string value = input.substring(1);

            //switch(nav){...}
            List<string> theList = new List<string>();
            bool done = false;
            do
            {

                Console.WriteLine("\n+Name to add\n-name to remove\n0 to exit\n");

                string input = Console.ReadLine()!;
                char nav = input[0];
                string value = input.Substring(1);

                switch (nav)
                {
                    case '+':
                        theList.Add(value);
                        Console.WriteLine($"\nCurrent capacity: { theList.Capacity}");
                        Console.WriteLine($"\nCurrent COUNT: { theList.Count}");
                        break;
                    case '-':
                        theList.Remove(value);
                        Console.WriteLine($"\nCurrent capacity: { theList.Capacity}");
                        Console.WriteLine($"\nCurrent COUNT: { theList.Count}");

                        break;
                    case '0':
                        done = true;
                        break;
                    default:
                        Console.WriteLine("\nthe first character must be + or -");
                        break;
                }
            } while (!done);

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
            Queue<string> theQueue = new Queue<string>();

            bool done = false;
            do
            {

                Console.WriteLine("\nWrite +Customername to add an ICA-customer\nWrite - to assist the first customer\n0 to exit\n");

                string input = Console.ReadLine()!;
                char nav = input[0];
                string value = input.Substring(1);

                switch (nav)
                {
                    case '+':
                        theQueue.Enqueue(value);
                        ShowCustomers(theQueue);
                        break;
                    case '-':
                        if (theQueue.Count > 0)
                        {
                            Console.WriteLine($"\nassisted: {theQueue.Dequeue()}");
                            ShowCustomers(theQueue);
                        }
                        else
                            Console.WriteLine("\nno customers in line");
                        break;
                    case '0':
                        done = true;
                        break;
                    default:
                        Console.WriteLine("\nplease use only + or -");
                        break;
                }
            } while (!done);
        
    }
         private static void ShowCustomers(Queue<string> theQueue)
        {
            Console.WriteLine("\nPeople in line: ");
            foreach (String customer in theQueue)
            {
                Console.WriteLine(customer);
            }


            /// <summary>
            /// Examines the datastructure Stack
            /// </summary>

        }
        static void ExamineStack()
        {
            /*
             * Loop this method until the user inputs something to exit to main menue.
             * Create a switch with cases to push or pop items
             * Make sure to look at the stack after pushing and and poping to see how it behaves
            */
            Stack<string> theSackQueue = new Stack<string>();

            bool done = false;
            do
            {
                Console.WriteLine("\n+word to add word to reversed a text\n- to remove the last word\n0 to exit");

                string input = Console.ReadLine()!;
                char nav = input[0];
                string value = input.Substring(1);

                switch (nav)
                {
                    case '+':
                        theSackQueue.Push(value);
                        ShowReveresedWords(theSackQueue);
                        break;
                    case '-':
                        if (theSackQueue.Count > 0)
                        {
                            theSackQueue.Pop();
                            ShowReveresedWords(theSackQueue);
                        }
                        else
                            Console.WriteLine("\nno text to reverse");
                        break;
                    case '0':
                        done = true;
                        break;
                    default:
                        Console.WriteLine("\nplease use only + or -");
                        break;
                }
            } while (!done);

        }
        private static void ShowReveresedWords(Stack<string> text)
        {
            Console.WriteLine("\ncurrent state of reversed the text: ");
            foreach (String word in text)
            {
                Console.WriteLine(word);
            }
           
        }

        static void CheckParanthesis()
        {
            /*
             * Use this method to check if the paranthesis in a string is Correct or incorrect.
             * Example of correct: (()), {}, [({})],  List<int> list = new List<int>() { 1, 2, 3, 4 };
             * Example of incorrect: (()]), [), {[()}],  List<int> list = new List<int>() { 1, 2, 3, 4 );
             */
            bool isCorrect = true;

            Console.Write("\nEnter the string: ");
            string input = Console.ReadLine()!;

            Stack<char> stack = new Stack<char>();

            foreach (char item in input)
            {
                if (item == '(' || item == '{' || item == '[')
                {
                    stack.Push(item);
                }
                else if (item == ')' || item == '}' || item == ']')
                {
                    //if (stack.Count > 0 && stack.Pop() != GetOppositParentesis(alphabet))
                    //{
                    //    isCorrect = false;
                    //    break;
                    //}
                    if (stack.Count == 0)
                    {
                        isCorrect= false;
                    }
                    else if (!isMatchingPair(stack.Pop(),item))
                                         
                    {
                        isCorrect= false;
                    }
                }
            }

            if (!isCorrect || stack.Count > 0)
                Console.WriteLine("\nThe string is incorrect\n");
            else
                Console.WriteLine("\nThe string is correct\n");

        }
        static Boolean isMatchingPair(char character1,char character2)
        {
            if (character1 == '(' && character2 == ')')
                return true;
            else if (character1 == '{' && character2 == '}')
                return true;
            else if (character1 == '[' && character2 == ']')
                return true;
            else
                return false;
        }
   
        static int F(int n)
        {
            if (n <= 2)
                return 1;
            return F(n - 1)+F(n-2);
        }
    }
}

