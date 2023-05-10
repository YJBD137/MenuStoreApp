using MenuStoreApp.Database;

namespace MenuStoreApp
{
    class Setup
    {
        public Setup(string[] args)
        {
            
            Console.ForegroundColor = ConsoleColor.Green;

        start:
            Console.Beep(1000, 500);
            Console.WriteLine("Enter Credentials:");
            string? Cred = Console.ReadLine();

            string[] C = Cred.Split(' ');

                Console.Clear();

                DatabaseAccess.Setup setup;

                try
                {
                    setup = new DatabaseAccess.Setup(C[0], C[1]);
                    Console.WriteLine(setup.Msg);
                    Console.WriteLine(setup.ExecutedCode);

                    if (!(setup.isConnected))
                    {
                        goto start;
                    }

                    Console.Beep(1500, 500);
                    Console.Beep(2000, 750);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e + "\n\n");
                    goto start;
                }

                    Code:
                    Console.Beep(2500, 500);
                    Console.WriteLine("Write your own code? (y/n)");
                    string c = Console.ReadLine().ToLower();
                    
            //SQL Query Start

                    if (c.Equals("y"))
                    {

                        setup.Execute(Console.ReadLine());

                    }
                    else
                    {
                       
                        Console.WriteLine("Type of Query:");
                        string Query = Console.ReadLine();

                        Console.WriteLine("How many times will you use this Query in a row?:");
                        short repeats = Convert.ToInt16(Console.ReadLine());

                        for (int i = repeats; i > 0; i--)
                        {
                            Console.WriteLine("All Values of the Query:");
                            string Values = Console.ReadLine();

                            setup.Query(Query, Values);

                            Console.WriteLine(setup.ExecutedCode);
                        }

                    }


            //SQL Query End
                    
                    Console.WriteLine("\n==================================================");
                    Console.WriteLine("Output: " + setup.Msg);

                    if (c.Equals("y"))
                    {
                        Console.WriteLine(setup.ExecutedCode);
                    }

                    Console.Beep(2500, 500);
                    Console.Beep(2000, 750);

                    Console.WriteLine("Continue to code? (y/n)");
                    string a = Console.ReadLine().ToLower();

                    if (a.Equals("y")) { Console.WriteLine("\n\n");  goto Code; }

                    Console.Beep(1500, 500);
                    Console.Beep(1000, 500);
                    Console.Beep(500, 1000);

        }

    }
} 
