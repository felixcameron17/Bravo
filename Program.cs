using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//string[] args

namespace Project_001
{
    class Program
    {

        static List<string> Names = new List<string>();
        static void Name()
        {
            {
                int z = 0;
                do
                {
                    z = 0;
                    Console.Clear();

                    Console.Write("First Name: ");
                    string FirstName = Console.ReadLine();

                    Console.Write("Last Name: ");
                    string LastName = Console.ReadLine();

                    string FullName = (FirstName + " " + LastName);
                    Names.Add(FullName);
                    string NamesAmount = Convert.ToString(Names.Count);
                    Console.WriteLine("Added: " + FullName + "\n(Number of names in system : " + NamesAmount + ")");

                    Console.Write("Press 1 to add more names or 2 to close the program or 3 to return to the menu: ");
                    char ButtonPress = Convert.ToChar(Console.ReadLine());


                    switch (ButtonPress)
                    {
                        case '1':
                            Name();
                            break;

                        case '2':
                            Environment.Exit(0);
                            break;

                        case '3':
                            z = 1;
                            break;

                    }
                } while (z == 0);
            }

        }

        static void Insert()
        {
            Console.Clear();

            string MaxNum = Convert.ToString(Names.Count - 1);
            Console.Write("Where would you like to insert your name into? (Can be between 0 and " + MaxNum + "): ");
            int InsertChoice = Convert.ToInt32(Console.ReadLine());

            Console.Write("First Name: ");
            string FirstName1 = Console.ReadLine();

            Console.Write("Last Name: ");
            string LastName1 = Console.ReadLine();

            string FullName1 = (FirstName1 + " " + LastName1);
            string NamesAmount = Convert.ToString(Names.Count);
            Console.WriteLine("Added: " + FullName1 + "\n(Number of names in system : " + NamesAmount + ")");

            Names.Insert(InsertChoice, FullName1);
        }

        static void Update()
        {
            Console.Clear();

            string MaxNum1 = Convert.ToString(Names.Count - 1);
            Console.Write("What value would you like to update? (Can be between 0 and " + MaxNum1 + "): ");
            int UpdateChoice = Convert.ToInt32(Console.ReadLine());

            Console.Write("New First Name: ");
            string FirstName2 = Console.ReadLine();

            Console.Write("New Last Name: ");
            string LastName2 = Console.ReadLine();

            string FullName2 = (FirstName2 + " " + LastName2);

            Names.Insert(UpdateChoice, FullName2);
            Names.RemoveAt(UpdateChoice + 1);

        }

        static void Delete()
        {
            Console.Clear();

            string MaxNum2 = Convert.ToString(Names.Count - 1);
            Console.Write("What value would you like to delete? (Can be between 0 and " + MaxNum2 + "): ");
            int DeleteChoice = Convert.ToInt32(Console.ReadLine());

            Names.RemoveAt(DeleteChoice);
            Console.Write("Done! Press any key to continue");
            Console.ReadKey();
        }

        static void Search()
        {
            Console.Clear();

            Console.Write("What would you like to find: ");
            string SearchChoice = Convert.ToString(Console.ReadLine());

            int y = -1;
            foreach (object x in Names)
            {
                y = (y + 1);
                string yString = Convert.ToString(y);


                if (Names[y] == SearchChoice)
                    Console.WriteLine("Found it! In place " + yString + ", " + SearchChoice);
            }

            Console.Write("Press any key to continue");
            Console.ReadKey();

        }

        static void Main(string[] args)
        {
            int a = 0;

            do
            {
                Console.Clear();

                Console.WriteLine("==========Employee Information==========");
                Console.WriteLine("Press 1 to add information\nPress 2 to insert information\nPress 3 to update information\nPress 4 to delete information\nPress 5 to search information\nPress 6 to show the current employees\nPress 7 to exit");

                char Choice = Convert.ToChar(Console.ReadLine());

                switch (Choice)
                {
                    case '1':
                        Name();
                        break;

                    case '2':
                        if (Names.Count <= 0)
                            Console.WriteLine("There are no values, you need to add values before inserting!");

                        else
                            Insert();
                        break;

                    case '3':
                        Update();
                        break;

                    case '4':
                        Delete();
                        break;

                    case '5':
                        Search();
                        break;


                    case '6':
                        Console.Clear();
                        int z = 0;
                        foreach (object x in Names)
                        {
                            z = (z + 1);
                            string zString = Convert.ToString(z - 1);
                            Console.WriteLine(zString + ": " + x);
                        }

                        Console.Write("Press any key to continue");
                        Console.ReadKey();

                        break;

                    case '7':
                        Environment.Exit(0);
                        break;
                }
            } while (a == 0);

            Console.ReadKey();
        }
    }
}
