// *************************************************************
//
//  Exercise task "Menu" for Lexicon
//
// *************************************************************
using System;
using System.Globalization;

namespace Lexicon_C
{
    static class Program
    {
        static readonly int EXITINT = int.MinValue;             // Error flag for integer value
        static readonly decimal EXITDEC = decimal.MinValue;     // Error flag for Decimal value
        static readonly int MenuitemMin = 1;
        static readonly int MenuitemMax = 17;

        // *************************************************************
        // Code begin
        // Display menu and wait for user input.

        // internal static Program Main;
        /// <summary>
        /// Start and exit point.
        /// </summary>
        static void Main() //string[] args
        {
          MainLoop();
          Environment.Exit(0);
        }

        /// <summary>
        /// My main loop for menu items.
        /// </summary>
        static void MainLoop()
        {
            int MenuItem;
            do
            {
                DisplayMenu();
                MenuItem = ReadMenuItem();
                ExecuteMenuItem(MenuItem);
            }
            while (MenuItem != EXITINT);   // EXITINT:  Keyword "End" typed by user. Flag to Exit app.

            
        }
        // ************************
        // Menu on screen
        // 
        /// <summary>
        /// Menu items.
        /// </summary>
        static void DisplayMenu()
        {

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("              Meny.");
            Console.WriteLine();
            Console.WriteLine("           0. Avsluta Meny.");
            Console.WriteLine();
            Console.WriteLine("           1. Hello World.");
            Console.WriteLine("           2. Input från användare.");
            Console.WriteLine("           3. Ändrar färg Till/Från.");
            Console.WriteLine("           4. Dagens datum.");
            Console.WriteLine("           5. Störst av två.");
            Console.WriteLine("           6. Gissa talet 1 - 100.");
            Console.WriteLine("           7. Spara text på fil.");
            Console.WriteLine("           8. Läser text från fil.");
            Console.WriteLine("           9. Roten ur ^2");
            Console.WriteLine("          10. Multiplikationstabell 1-10");
            Console.WriteLine("          11. Array 1.Slump och 2.Sorterad.");
            Console.WriteLine("          12. Kolla palindrom");
            Console.WriteLine("          13. Alla siffror mellan A & B");
            Console.WriteLine("          14. Separera Udda och Jämna tal");
            Console.WriteLine("          15. Addera mina tal.");
            Console.WriteLine("          16. Mina värden från Class.");
            Console.WriteLine("          17. Mina värden från gemensam Class. Bonus function.");
            //Console.WriteLine();
            //Console.WriteLine("              Skriv End eller 0 för att avsluta menyn.");
            Console.WriteLine();
            Console.WriteLine("              Välj önskat alternativ.");
            Console.Write("Ditt val: ");
        }

        // ************************
        // Read and check menu item for validity.
        // 
        /// <summary>
        /// Get user input for selected item.
        /// </summary>
        /// <returns>
        /// Return item or user error
        /// </returns>
        static int ReadMenuItem() 
        {
            //// Handle only number. "End" is a good way to go...
            // Nr = GetOnlyIntNumber("Meny val: ");
            // if (Nr == EXITINT)              // Don't need to exit on user error.
            //    return -1;

            string R = Console.ReadLine();
            if (R.ToLower() == "end")
                return EXITINT;             // User typed "End" old menu exit item. Just return and exit flag.
            int Nr;

            try
            {
                Nr = Convert.ToInt32(R);
            }
            catch (Exception)
            {
                return -1;                  // Invalid input. Will be ignored
            }

            if (Nr == 0 )
                return EXITINT;             // User typed "0". Just return and exit flag.

            if (Nr < MenuitemMin)
                    return -1;              // Invalid input. Will be ignored
                if (Nr > MenuitemMax)
                    return -1;              // Invalid input. Will be ignored
                return Nr;                  // Return valid input.
        }

        // ************************
        // Find and execute menu items
        // 
        /// <summary>
        /// Execute user item or exit on error
        /// </summary>
        /// <param name="Item"></param>
        static void ExecuteMenuItem(int Item)
        {
            if (Item == -1)
                return;         // Invalid Item
            if (Item == EXITINT)
                return;         // Exit App

            switch (Item)
            {
                case 1:
                    {
                        HelloWorld();
                        break;
                    }

                case 2:
                    {
                        InputFromUser();
                        break;
                    }

                case 3:
                    {
                        SwapTextColor();
                        break;
                    }

                case 4:
                    {
                        TodaysDate();
                        break;
                    }

                case 5:
                    {
                        CompareTwo();
                        break;
                    }

                case 6:
                    {
                        GuessMyNumber();
                        break;
                    }

                case 7:
                    {
                        WriteToFile();
                        break;
                    }

                case 8:
                    {
                        ReadFromFile();
                        break;
                    }

                case 9:
                    {
                        SqrPow2Pow10();
                        break;
                    }

                case 10:
                    {
                        MultOneToTen();
                        break;
                    }

                case 11:
                    {
                        TwoRandomArray();
                        break;
                    }

                case 12:
                    {
                        Palindrom();
                        break;
                    }

                case 13:
                    {
                        NumbersInBetween();
                        break;
                    }

                case 14:
                    {
                        SortPrintEvenOdd();
                        break;
                    }

                case 15:
                    {
                        AddNumbers();
                        break;
                    }

                case 16:
                    {
                        AvatarAndOpponent();
                        break;
                    }

                case 17:
                    {
                        StaticAvatarAndOpponent();
                        break;
                    }

                default:
                    {
                        break;
                    }
            }

           

        }
        // ***********************************************
        // Menu Item 0.    Exit program.
        // 
        //  No executable code here ;-)

        // ***********************************************
        // Menu Item 1.    Hello World.
        // 
        /// <summary>
        /// Write "Hello World.
        /// </summary>
        static void HelloWorld()
        {
            Head("Skriver ut Hello World.");
            Console.WriteLine("Hello World.");
            Foot();
        }

        // ***********************************************
        // Menu Item 2.    Input from User.
        // 
        /// <summary>
        /// Try some user input
        /// </summary>
        static void InputFromUser()
        {
            Head("Vänligen Skriv ditt Förnamn, Efternamn, Ålder.");

            Console.Write("Förnamn   ? ");
            string FirstName = Console.ReadLine();
            Console.Write("Efternamn ? ");
            string LastName = Console.ReadLine();
            // Console.Write("Ålder     ? ")
            int Age;
            Age = GetOnlyIntNumber("Ålder     ? ");
            if (Age == EXITINT)
                return; // User desided to exit. Ok..

            Console.WriteLine("Du heter " + FirstName + " " + LastName + " och är " + Age + " år gammal.");
            Foot();
        }

        // ***********************************************
        // Menu Item 3.    Change color.
        // 

        static bool OriginalColor = true;
        static ConsoleColor OrgCol;
        /// <summary>
        /// Change text color and change it back the next time.
        /// </summary>
        static void SwapTextColor()
        {
            if (OriginalColor)
            {
                OrgCol = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                OriginalColor = false;
                Head("Nu bytte vi färg till mörkgul.");
            }
            else
            {
                Console.ForegroundColor = OrgCol;
                OriginalColor = true;
                Head("Nu bytte vi tillbaka till orginalfärg.");
            }

            Foot();
        }

        // ***********************************************
        // Menu Item 4.    Todays date.
        // 
        /// <summary>
        /// Write todays date.
        /// </summary>
        static void TodaysDate()
        {
            Head("Dagens datum är.");

            Console.WriteLine("  År, Månad, Dag");
            Console.WriteLine(DateTime.Now.Year + "      " + DateTime.Now.Month + "   " + DateTime.Now.Day);
            Console.WriteLine();
            Console.WriteLine("Eller mer lättläsligt.");
            string monthName = CultureInfo.CurrentCulture.DateTimeFormat.GetAbbreviatedMonthName(DateTime.Now.Month);
            Console.WriteLine(DateTime.Today.DayOfWeek.ToString() + ", " + DateTime.Now.Day + " " + monthName + "  År " + DateTime.Now.Year);
            // DateTime .M
            Foot();
        }

        // ***********************************************
        // Menu Item 5.    Input 2 and compare.
        // 
        /// <summary>
        /// Input 2 values and compare them.
        /// </summary>
        static void CompareTwo()
        {
            Head("Skriv in två värden så tar vi reda på viket som är störst.");

            string a, b;
            Console.Write("Ange värde för A ");
            a = Console.ReadLine();
            Console.Write("Ange värde för B ");
            b = Console.ReadLine();
            Console.WriteLine();

            int cmp = String.Compare(a, b, comparisonType: StringComparison.OrdinalIgnoreCase);

            if (a == b)
                Console.WriteLine("A och B är lika");
     
            else
                Console.WriteLine((cmp > 0 ) ? "A är Större än B" : "B är Större än A");

            Foot();
        }

        // ***********************************************
        // Menu Item 6.    .
        // 
        /// <summary>
        /// User have to guess a number between 1 to 100.
        /// User can exit by typing 0 (zero)
        /// </summary>
        static void GuessMyNumber()
        {
            int MyNr = Rnr(1, 100);
            int Guess;
            int Guesses = 0;
            Head("Jag tänker på ett nummer mellan 1 och 100. Gissa vilket.");

            Console.WriteLine("Om du tröttnat, skriv 0 så avslutar vi.");
            Console.WriteLine();

            do
            {
                Guess = GetOnlyIntNumber("Vilket nummer tror du det är ? ");
                if (Guess == EXITINT)
                    return;
                if (Guess == 0)
                {
                    Console.WriteLine("Ok. Du har tröttnat, Tack för försöket.");
                    Foot();
                    return;
                }

                Guesses++;
                Console.WriteLine();
                if (Guess == MyNr)
                {
                    Console.WriteLine("Perfekt gissning. Du gissade helt rätt. Du tog det på " + Guesses + " Gissningar.");
                    Foot();
                    return;
                }
           
                // Inform user. To high or to low.
                if (Guess > MyNr)
                    Console.WriteLine("Gissning " + Guesses + ": Oj. Det talet var för högt. Försök igen.");
                else
                    Console.WriteLine("Gissning " + Guesses + ": Nej. Det talet var för lågt. Försök igen.");

                // Just for fun.
                if (Math.Abs(MyNr - Guess) < 5)
                    Console.WriteLine("Men du var väldigt nära. Kära nån!");
                else if (Math.Abs(MyNr - Guess) < 10)
                    Console.WriteLine("Men. Nu är du nära.");
                Console.WriteLine();
            }
            while (true);
    
        }
        // ***********************************************
        // Menu Item 7.    .
        // 
        /// <summary>
        /// Write a file containing user text
        /// </summary>
        static void WriteToFile()
        {
            string Text;
            Head("Skriv in lite text så sparar vi den i filen MinText.txt");
            Console.Write("Text att spara: ");
            Text = Console.ReadLine();
            System.IO.File.WriteAllText(@".\MinText.txt", Text);
            Console.WriteLine("Filen är nu sparad. Se texten i menyval 8");
            Foot();
        }

        // ***********************************************
        // Menu Item 8.    .
        // 
        /// <summary>
        /// Read file created above.
        /// </summary>
        static void ReadFromFile()
        {
            string Text; // = "";
            Head("Nu läser vi i filen MinText.txt");

            if (System.IO.File.Exists(@".\MinText.txt"))
            {
                Text = System.IO.File.ReadAllText(@".\MinText.txt");
                Console.WriteLine(Text);
            }
            else
                Console.WriteLine("Märkligt. Filen finns inte! Är du säker på att du skapat den med Menyval 7 ?");
            Foot();
        }



        // ***********************************************
        // Menu Item 9.    .
        // 
        /// <summary>
        /// Math skill. 
        /// Input a number
        /// Create Sqr(nr) 
        /// Create ^2(nr)
        /// create ^10(nr)
        /// BUGG.. Math.x cant use decimal.
        ///        Have to convert to double.
        /// </summary>
        static void SqrPow2Pow10()
        {
            Head("Mata in ett decimaltal och få tillbaka lite beräkningar.");

            decimal Decimaltal;
            Decimaltal = GetOnlyDecimalNumber("Ge mig ett tal: ");
            if (Decimaltal == EXITDEC)
                return;  // User not happy. 

            double MathDecimalProblem = Convert.ToDouble(Decimaltal);       // Dirty fix. Math does not handle type decimal.

            Console.WriteLine();
            Console.WriteLine("Roten ur        " + Decimaltal + " = " + Math.Sqrt(MathDecimalProblem));
            Console.WriteLine(Decimaltal + " Upphöjt till  2 = " + Decimaltal * Decimaltal);
            Console.WriteLine(Decimaltal + " Upphöjt till 10 = " + Math.Pow(MathDecimalProblem, 10));

            Foot();
        }

        // ***********************************************
        // Menu Item 10.    .
        // 
        /// <summary>
        /// Multiplication table from 1 to 10
        /// </summary>
        static void MultOneToTen()
        {
            Head("Multiplikationstabellen 1 till 10.");
            Console.WriteLine();
            Console.WriteLine("           1            2               3               4               5               6               7               8               9               10");

            string Line;
            for (var i = 0; i <= 10; i++)
            {
                Line = "   ";
                for (var j = 1; j <= 10; j++)
                    Line = Line + j + " * " + i + " = " + j * i + '\t';// Create lines.
                Console.WriteLine(Line);
            }

            Console.WriteLine();
            Console.WriteLine("Ser formateringen konstig ut får du utvidga consolfönstret.");
            Console.WriteLine();

            Foot();
        }

        // ***********************************************
        // Menu Item 11.    .
        // 
        /// <summary>
        /// Create a random array.
        /// Copy to a new array.
        /// Sort the second.
        /// Display.
        /// </summary>
        static void TwoRandomArray()
        {
            Head("Två lika arrayer, den till höger är sorterad.");
            int ArrayLen = 20;
            int[] OsortArr = new int[ArrayLen + 1];
            int[] SortArr = new int[ArrayLen + 1];

            for (var i = 0; i <= ArrayLen; i++)
                OsortArr[i] = Rnr(1, 100);
            Array.Copy(OsortArr, SortArr, ArrayLen + 1);
            Array.Sort(SortArr);

            for (var i = 0; i <= ArrayLen; i++)
                Console.WriteLine("   " + OsortArr[i] + '\t' + SortArr[i]);

            Foot();
        }


        // ***********************************************
        // Menu Item 12.    .
        // 
        /// <summary>
        /// Test if input is a palindrome
        /// </summary>
        static void Palindrom()
        {
            Head("Palindrom kontroll. Skriv en text så kollar vi.");
            string Test; // = "";
            Test = Console.ReadLine();
            int x, y;

            y = Test.Length;
            for (x = 1; x <= Test.Length; x++)
            {
                if (Mid(Test, x, 1) != Mid(Test, y, 1))
                    break;
                y--; // y = y - 1;
            }

            if (x < Test.Length)
                Console.WriteLine("Sorry.. Ordet " + Test + " var inget palindrom.");
            else
                Console.WriteLine("Jippi.. Ordet " + Test + " är ett palindrom.");
            Foot();
        }

        // Old habit....
        static string Mid(string s, int pos, int len)
        {
            pos--;  // zero based correction
            return s.Substring(pos, len);
        }

        // ***********************************************
        // Menu Item 13.    .
        // 
        /// <summary>
        /// From two numers.
        /// Print all numbers inbetween.
        /// </summary>
        static void NumbersInBetween()
        {
            Head("Ange två nummer så skriver jag alla nummer mellan.");

            int First, Last;
            First = GetOnlyIntNumber("Första nummret ");
            if (First == EXITINT)
                return;
            Last = GetOnlyIntNumber("Andra  nummret ");
            if (Last == EXITINT)
                return;

            if (First > Last)
            {
                int tmp = First;
                First = Last;
                Last = tmp;
            }

            if (Last - First < 2)
                Console.WriteLine("Inte mycket att göra här. Nummren är för nära eller lika. " + First + " <> " + Last);
            else
                for (var i = First + 1; i <= Last - 1; i++)
                {
                    Console.Write(i);
                    if (i < Last - 1)
                        Console.Write(", ");
                }

            Foot();
        }

        // ***********************************************
        // Menu Item 14.    .
        // 
        /// <summary>
        /// Get comma separated number from user input.
        /// Sort and display in two rows.
        /// One for Even and the other for Odd numbers.
        /// </summary>
        static void SortPrintEvenOdd()
        {
            Head("Skriv antal komma-separerade siffror på samma rad.");
            Console.WriteLine();
            string[] Str = Console.ReadLine().Split(',');
            int[] Number = new int[Str.Length - 1 + 1];

            for (var x = 0; x <= Str.Length - 1; x++)
            {
                try
                {
                    Number[x] = Convert.ToInt32(Str[x]);
                }
                catch (Exception )
                {
                    Console.WriteLine("Felaktigt nummer hittades. Endast heltal är giltliga här!");
                    Foot();
                    return;
                }
            }

            Array.Sort(Number);
            Console.WriteLine();
            Console.WriteLine("Jämna nummer:");
            int nr;
            for (var x = 0; x <= Number.Length - 1; x++)
            {
               nr = Number[x] & 1;

                if (nr == 0)
                {
                    Console.Write(Number[x]);
                    if (x < Number.Length - 1)
                        Console.Write(",  ");
                }
            }

            Console.WriteLine();
            Console.WriteLine("Udda nummer:");
            for (var x = 0; x <= Number.Length - 1; x++)
            {
                nr = Number[x] & 1;
                if (nr == 1)
                {
                    Console.Write(Number[x]);
                    if (x < Number.Length - 1)
                        Console.Write(",  ");
                }
            }

            Foot();
        }


        // ***********************************************
        // Menu Item 15.    .
        // Add numbers.
        /// <summary>
        /// From user comma separated input.
        /// Add all numbers and display result.
        /// </summary>
        static void AddNumbers()
        {
            Head("Skriv antal komma-separerade siffror på samma rad.");
            Console.WriteLine();
            string[] Str = Console.ReadLine().Split(',');
            int[] Number = new int[Str.Length - 1 + 1];

            for (var x = 0; x <= Str.Length - 1; x++)
            {
                try
                {
                    Number[x] = Convert.ToInt32(Str[x]);
                }
                catch (Exception)
                {
                    Console.WriteLine("Felaktigt nummer hittades. Endast heltal är giltliga här!");
                    Foot();
                    return;
                }
            }

            int Result = 0;
            for (var x = 0; x <= Number.Length - 1; x++)
            {
                Console.Write(Number[x]);
                if (x < Number.Length - 1)
                    Console.Write(" + ");
                Result += Number[x];  // Result = Result + Number(x)
            }
            Console.Write(" = " + Result);

            Foot();
        }

        // ***********************************************
        // Menu Item 16.    .
        // 
        /// <summary>
        /// Create two new instances of class Avatar.
        /// Give Name to me and opponent.
        /// Give random values to Health, Strengt and Luck
        /// </summary>
        static void AvatarAndOpponent()
        {

            Avatar MyAvatar = new Avatar();
            Avatar Opponent = new Avatar();
            Head("Skriv ditt Avatar namn samt din motståndares.");
            Console.WriteLine();
            Console.Write("Ditt Namn? ");
            MyAvatar.UserName = Console.ReadLine();
            Console.Write("Motståndares Namn? ");
            Opponent.UserName = Console.ReadLine();
            Console.WriteLine();

            FillAvatarRandomNumber(ref MyAvatar, ref Opponent);
            PresentAvatar(ref MyAvatar, ref Opponent);

            Foot();
        }

        // ***********************************************
        // Menu Item 17.    .
        // 
        /// <summary>
        /// Two instances are created outside funktion.
        /// 
        /// Given Name to me and opponent don't reset 
        /// from each visit to this funktion.
        /// Nor does Health, Strengt and Luck
        /// </summary>
        static Avatar MyAvatar = new Avatar();      // Declaration outside of Sub. Keep value in class until App ends.
        static Avatar Opponent = new Avatar();

        static void StaticAvatarAndOpponent()
        {
            Head("Vill du byta namn?");
            PresentAvatar(ref MyAvatar, ref Opponent);
            Console.WriteLine();
            Console.WriteLine("Tryck på en tangent för att fortsätta");
            ReadKey();
            Console.WriteLine();

            Head("Skriv nytt namn om du vill byta.");
            Console.WriteLine();
            Console.Write("Ditt Namn? ");
            string NewName; // = ""
            NewName = Console.ReadLine();
            if (NewName != "")
                MyAvatar.UserName = NewName;
            // NewName = ""
            Console.Write("Motståndares Namn? ");
            NewName = Console.ReadLine();
            if (NewName != "")
                Opponent.UserName = NewName;
            Console.WriteLine();

            FillAvatarRandomNumber(ref MyAvatar, ref Opponent);
            PresentAvatar(ref MyAvatar, ref Opponent);

            Foot();
        }

        /// <summary>
        ///  Set Healt, Strengt an luck to both Avatars.
        /// </summary>
        /// <param name="MyAvatar"></param>
        /// <param name="Opponent"></param>
        static void FillAvatarRandomNumber(ref Avatar MyAvatar, ref Avatar Opponent)
        {
            MyAvatar.Health = Rnr(10, 100);
            MyAvatar.Strengt = Rnr(10, 100);
            MyAvatar.Luck = Rnr(0, 10);

            Opponent.Health = Rnr(10, 100);
            Opponent.Strengt = Rnr(10, 100);
            Opponent.Luck = Rnr(0, 10);
        }

        /// <summary>
        /// Read Username , Health, Strangt and Luck of both avatars.
        /// </summary>
        /// <param name="MyAvatar"></param>
        /// <param name="Opponent"></param>
        static void PresentAvatar(ref Avatar MyAvatar, ref Avatar Opponent)
        {
            Console.WriteLine("Du är    " + MyAvatar.UserName + '\t' + " Motståndar är " + Opponent.UserName);
            Console.WriteLine();

            Console.WriteLine("Hälsa    " + MyAvatar.Health + '\t' + " Hälsa         " + Opponent.Health);
            Console.WriteLine("Styrka   " + MyAvatar.Strengt + '\t' + " Styrka        " + Opponent.Strengt);
            Console.WriteLine("Tur      " + MyAvatar.Luck + '\t' + " Tur           " + Opponent.Luck);
        }

        // **********************************************************************************************
        // *
        // *   Program functionallity. 
        // *   
        // *   Head                Clear and write header.
        // *   Foot                Wait for user to exit selected menu item
        // *   ReadKey             Wait for key input.
        // *
        // *   Rnr                 Random number.
        // *   GetOnlyIntNumber    Clean integer.
        // *   GetOnlyDoubleNumber Clean decimal (double)
        // *
        // **********************************************************************************************


        // **************************************************
        // Better random generator.
        // R = Rnr(0, 35)     ' Get a number from 0 to 35
        // static System.Random N_Rnd = new System.Random(System.Convert.ToInt32(System.DateTime.Now.Ticks % System.Int32.MaxValue));
        static readonly System.Random N_Rnd = new System.Random(System.Convert.ToInt32(System.DateTime.Now.Ticks % System.Int32.MaxValue));

        /// <summary>
        /// Better random generator.
        /// R = Rnr(0, 35)     ' Get a number from 0 to 35
        /// </summary>
        /// <param name="L return lowest  value."></param>
        /// <param name="H return highest value."></param>
        /// <returns>
        /// A random number from L to H
        /// </returns>
        static int Rnr(int L, int H)
        {
            return N_Rnd.Next(L, H + 1);
        }

        // ************************
        // First line for every menu item.
        // Clear screen and write menu header text.
        /// <summary>
        ///  Header for all menu selection.
        /// </summary>
        /// <param name="Header" >
        ///  Write menu item header text.
        /// </param>
        static void Head(string Header)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine(Header);
            Console.WriteLine();
        }

        // ************************
        // Wait for user input to exit menu item.
        /// <summary>
        /// Foot for all menu items.
        /// After user complete menu item Foot wait for key befor exit.
        /// </summary>
        static void Foot()
        {
            Console.WriteLine();
            Console.WriteLine("Tryck en tangent för att avsluta.");
            ReadKey();
        }

        // ************************
        // Read user input key.
        /// <summary>
        /// Wait for user to press a key
        /// </summary>
        /// <returns>
        /// Return key as Char
        /// </returns>
        static char ReadKey()
        {
            ConsoleKeyInfo Reply = Console.ReadKey();
            return Reply.KeyChar;
        }

        // ************************************************
        // Accept only integer here.
        // User have 3 try to get it right.
        /// <summary>
        /// Accept only integer here.
        /// </summary>
        /// <param name="InputText">
        /// Tell user what's expected here.
        /// </param>
        /// <returns>
        /// Return a valid integer.
        /// User get 3 try to create a valid number.
        /// If not valid... Return exit flag.
        /// </returns>
        static int GetOnlyIntNumber(string InputText)
        {
            string Test;

            // Get input. If NAN then try max 3 times.
            for (var UserTry = 1; UserTry <= 3; UserTry++)
            {
                Console.Write(InputText);
                Test = Console.ReadLine();

                // Try to use string as integer
                try
                {
                    return Convert.ToInt32(Test);
                }
                catch (Exception)
                {
                    Console.WriteLine("Endast heltal är giltliga här! Försök " + (UserTry + 1) + " av 3.");
                }
            }
            // User gone mad. Reply Exit flag.
            return EXITINT;
        }

        // ************************************************
        // Accept only Decimal number here.
        // User can exit by only press enter.

        /// <summary>
        /// Accept only Decimal number here.
        /// </summary>
        /// <param name="InputText">
        /// Tell user what's expected here.
        /// </param>
        /// <returns>
        /// Return a valid Decimal.
        /// User get 3 try to create a valid number.
        /// If not valid... Return exit flag.
        /// </returns>
        static decimal GetOnlyDecimalNumber(string InputText)
        {
            string Test;

            // Get input. If NAN then try max 3 times.
            for (var UserTry = 1; UserTry <= 3; UserTry++)
            {
                Console.Write(InputText);
                Test = Console.ReadLine();
                Test = SwapDotToComma(Test);            // If user type Dot then swap to Comma.  123.22 = 123,22

                // Try to use string as number.
                try
                {
                    return Convert.ToDecimal(Test);      // Sucess if exit here. A valid number found.
                }
                catch (Exception)
                {
                    Console.WriteLine("Endast nummer är giltliga här!  Försök " + (UserTry + 1)  + " av 3.");               
                }
            }
            // User didn't make it. 
            return EXITDEC;   
            
        }

        // *************************************************
        // Fix user error. If type Dot "." swap to Comma "," 
        /// <summary>
        /// Fix user error. If type Dot "." swap to Comma "," 
        /// </summary>
        /// <param name="T">
        /// String to be searched for Dot's
        /// </param>
        /// <returns>
        /// Return converted string using only comma. 
        /// </returns>
        static string SwapDotToComma(string T)
        {
            int x;
            string reply = "";
            // s.Substring(pos, 1)

            for (x = 0; x <= T.Length-1; x++)
            {
                if (T.Substring(x, 1) == ".")
                    reply += ",";
                else
                    reply += T.Substring(x, 1);
            }
            return reply;
        }
    }
}

// ************************************************************************************************
// *    Vb.net allow you to cheat and get away whit anything.  The result may be... spaghetti code.
// *    Avatar class correctly defined.        ... .. .  i hope ;-) . .. ...
// *    Anyway... It's really easy to read Get, Set in C#  vs  vb.net 
// ************************************************************************************************

namespace Lexicon_C
{ 
    public class Avatar

    {
        public string UserName  // property
        {  
            get { return _UserName; }
            set { _UserName = value; }
        }

        public int Health
        {  
            get { return _Health; }
            set { _Health = value; } 
        }

        public int Strengt
        {

            get { return  _Strengt; }
            set { _Strengt =  value   ; }
        }

        public int Luck
        {
            get { return _Luck; }
            set { _Luck = value; }
        }

        public string _UserName = "Nobody"; // Avatar
        public int _Health = 0;  // 
        public int _Strengt = 0;  // 
        public int _Luck = 0;  // 
    }

}