namespace SkalProj_Datastrukturer_Minne
{
    //Frågor
    //1. I stack lagras value types. Om man länkar ett värde till en value type som finns i stack så skapas en kopia av denna med samma värde. x = 99, y = x, y == 99. Ändras därefter värdet på y, y = 65 så blir y == 65 och x == 99.
    //Kopian y ändrar sitt värde, men x förblir detsamma.
    //I heap ligger reference types så som till exempel class. Ett värde satt i en class lagras i heap. En kopia av ett värde på heap länkas till värdet i class, både x och y skulle hänvisa till samma class vilket innebär att om y ändrar värdet så kommer class
    //värdet att ändras och därav också värdet på x som också länkas till class.
    //
    //2. Value types är direkt satta värden på tex en int, c = 10.
    //Reference types innehåller värden och koder som refereras till istället för att direkt sättas.
    //
    //3. Jag råkade förklara detta i fråga 1. y är en kopia av x i den första kodsträngen, ändra värdet på y ändrar inte värdet på x. I andra kodsträngen refererar både x och y mot MyInt vilket innebär att om någon av de ändrar på på värdet i MyInt så kommer
    //värden att ändras för både x och y.
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
             Loop this method untill the user inputs something to exit to main menue.
             Create a switch statement with cases '+' and '-'
             '+': Add the rest of the input to the list (The user could write +Adam and "Adam" would be added to the list)
             '-': Remove the rest of the input from the list (The user could write -Adam and "Adam" would be removed from the list)
             In both cases, look at the count and capacity of the list
             As a default case, tell them to use only + or -
             Below you can see some inspirational code to begin working.
            */

            List<string> theList = new List<string>();
            Console.WriteLine("För att addera till listan skriv + och därefter namn, klicka sen Enter. För att ta bort från listan skriv - och därefter namn, klicka sen Enter. För att återgå till huvudmenyn skriv inget och klicka Enter.");
            string? input;

            do
            {
                input = Console.ReadLine();
                char nav = input![0];
                string value = input.Substring(1);

                switch (nav)
                {
                    case '+':
                        theList.Add(value);
                        break;

                    case '-':
                        theList.Remove(value);
                        break;

                    default :
                        Console.WriteLine("Du måste börja med ett + för lägga till, eller ett - för att ta bort. Vänligen försök igen.");
                    break;

                }
                Console.WriteLine($"Antal poster: {theList.Count}, total kapacitet: {theList.Capacity}");
                foreach (var item in theList) { Console.WriteLine(item); }
            }
            while (input != "");
        }

        //Frågor
        //2. Ökar varje gång man går över den storlek som är. skriver man ett 5:e inlägg så öker array från 4 till 8.
        //3. Kapaciteten dubblas vid varje ökning av arrayn. 4-8, 8-16, 16-32 osv
        //4. Jag antar att det har att göra med processen och för att ev minska på data användning eller problem som kan uppstå om array kontinueligt uppdateras allt eftersom ny data läggs till.
        //5. Nej de minskar inte, den kvarstår som den är. Men det går att ta ner den igen med kod om man önskar minska sin array igen.
        //6. Om man vet hur många poster som ska användas och det inte finns behov att utöka denna mängd speciellt ofta så är nog en array ett bättre val, om man tex sätter värdena hårdkodat. Array är
        //även bra om man vill ha en limit i inmatningen så att det inte blir fler poster än vad man vill tillåta för processen. Om man vill att ny data ska läggas till kontinueligt och utan gräns så bör man använda en lista.

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
            Queue<string> icaQueue = new Queue<string>();
            Console.WriteLine("För att addera till kön skriv + och därefter namn, klicka sen Enter. För att ta bort personen längst fram i kön skriv - och därefter klicka Enter. För att återgå till huvudmenyn skriv inget och klicka Enter.");
            string? input;

            do
            {
                input = Console.ReadLine();
                char nav = input![0];
                string value = input.Substring(1);

                //icaQueue.Enqueue(Kalle);
                //icaQueue.Enqueue(Greta);
                //icaQueue.Dequeue();
                //icaQueue.Enqueue(Stina);
                //icaQueue.Dequeue();
                //icaQueue.Enqueue(Olle);

                try
                {
                    switch (nav)
                    {
                        case '+':
                            icaQueue.Enqueue(value);
                            break;

                        case '-':
                            icaQueue.Dequeue();
                            break;

                        default:
                            Console.WriteLine("Du måste börja med ett + för lägga till, eller ett - för att ta bort. Vänligen försök igen.");
                            break;

                    }
                }
                catch { Console.WriteLine("Ett felaktigt val gjordes!\nOm kön består av 0 personer kan du inte välja alternativ - för att ta bort personen längst fram i kön.\nVänligen försök igen:"); }

                Console.WriteLine($"Antal personer i kön: {icaQueue.Count}");

                foreach (var item in icaQueue)
                {
                    Console.WriteLine(item);
                }
            }
            while (input != "");
        
    }

        /// <summary>
        /// Examines the datastructure Stack
        /// </summary>
        public static string Reverse(string regular)
        {
            char[] charArray = regular.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        static void ExamineStack()
        {
            /*
             * Loop this method until the user inputs something to exit to main menue.
             * Create a switch with cases to push or pop items
             * Make sure to look at the stack after pushing and and poping to see how it behaves
            */

            Stack<string> theStack = new Stack<string>();
            Console.WriteLine("För att addera till kön skriv + och därefter namn, klicka sen Enter. För att ta bort personen längst fram i kön skriv - och därefter klicka Enter. För att återgå till huvudmenyn skriv inget och klicka Enter.");
            string? input;
            string? inputReverse;

            do
            {
                input = Console.ReadLine();

                char nav = input![0];
                string value = input.Substring(1);

                inputReverse = Reverse(value);

                try
                {

                    switch (nav)
                    {
                        case '+':
                            theStack.Push(inputReverse);
                            break;

                        case '-':
                            theStack.Pop();
                            break;

                        default:
                            Console.WriteLine("Du måste börja med ett + för lägga till, eller ett - för att ta bort. Vänligen försök igen.");
                            break;

                    }
                }
                catch  {Console.WriteLine("Ett felaktigt val gjordes!\nOm kön består av 0 personer kan du inte välja alternativ - för att ta bort personen längst bak i kön.\nVänligen försök igen:"); }
            

                Console.WriteLine($"Antal personer i kön: {theStack.Count}");
                foreach (var item in theStack) { Console.WriteLine(item); }
            }
            while (input != "");
        }

        static void CheckParanthesis()
        {
            /*
             * Use this method to check if the paranthesis in a string is Correct or incorrect.
             * Example of correct: (()), {}, [({})],  List<int> list = new List<int>() { 1, 2, 3, 4 };
             * Example of incorrect: (()]), [), {[()}],  List<int> list = new List<int>() { 1, 2, 3, 4 );
             */

            //char[] checkCharLeft = new char[] { '(', '[', '<', '{' };
            //char[] checkCharRight = new char[] { ')', ']', '>', '}' };
            //List<char> identifyParenthesis = new List<char>();

            var identifyParanthesis = new Dictionary<char, char>() { { '{', '}' }, { '(', ')' }, { '[', ']' }, { '<', '>' } };
            
            Console.WriteLine("Vänligen skriv in en text med givna paranteser för att testa:");
            string? input = Console.ReadLine();
            var startParenth = new Stack<char>();

            foreach (char c in input)
            {
                if (startParenth.Count == 0 && identifyParanthesis.ContainsValue(c))
                {
                    Console.WriteLine($"Fel hittades, du saknar motsvarande parantes för {c}, vänligen försök igen.");
                    break;
                }
                if (identifyParanthesis.ContainsValue(c) && identifyParanthesis[startParenth.Pop()] != c)
                {
                    Console.WriteLine($"Fel hittades, motsvarande parantes för {c} ligger fel eller saknas.");
                    break;
                }
                if (identifyParanthesis.ContainsKey(c))
                {
                    startParenth.Push(c);
                }


            }



            //while (identifyParenthesis.Count > 0)
            //{
            //    if (identifyParenthesis[0] == '(')
            //    {
            //        if (identifyParenthesis.Contains(')'))
            //        {
            //            identifyParenthesis.Remove('(');
            //            identifyParenthesis.Remove(')');
            //        }
            //        else
            //        {
            //            Console.WriteLine("Det saknas minst en ) i din sträng, vänligen försök igen.");
            //            break;
            //        }
            //    }
            //    else if (identifyParenthesis[0] == '[')
            //    {
            //        if (identifyParenthesis.Contains(']'))
            //        {
            //            identifyParenthesis.Remove('[');
            //            identifyParenthesis.Remove(']');
            //        }
            //        else
            //        {
            //            Console.WriteLine("Det saknas minst en ] i din sträng, vänligen försök igen.");
            //            break;
            //        }
            //    }
            //    else if (identifyParenthesis[0] == '<')
            //    {
            //        if (identifyParenthesis.Contains('>'))
            //        {
            //            identifyParenthesis.Remove('<');
            //            identifyParenthesis.Remove('>');
            //        }
            //        else
            //        {
            //            Console.WriteLine("Det saknas minst en > i din sträng, vänligen försök igen.");
            //            break;
            //        }
            //    }
            //    else if (identifyParenthesis[0] == '{')
            //    {
            //        if (identifyParenthesis.Contains('}'))
            //        {
            //            identifyParenthesis.Remove('{');
            //            identifyParenthesis.Remove('}');
            //        }
            //        else
            //        {
            //            Console.WriteLine("Det saknas minst en } i din sträng, vänligen försök igen.");
            //            break;
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Det finns paranteser som inte har ett en motsvarande part, vänligen försök igen");
            //        break;
            //    }
            //}

            //int amountOfParenthesis = identifyParenthesis.Count();
            //if (amountOfParenthesis == 0)
            //{
            //    Console.WriteLine("Grattis din text är korrekt");
            //}
            //else
            //{
            //    Console.WriteLine("Det finns paranteser som inte har ett en motsvarande part, vänligen försök igen");
            //    Console.ReadLine();
            //}
        }

    }
}

