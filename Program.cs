using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mashike_Puniki_Salome
{
    class Program
    {
        enum Menu
        {
            Add = 1,
            show,
            search,
            modify,
            delete,
            sort,
            nomalize,
            end
        }


        static void Main(string[] args)
        {
            string[,] arrayItems = new string[5, 5];
            Console.WriteLine("Welcome Please select an option from below");
            string response;

            do
            {
                Console.WriteLine("1.add new expense");
                Console.WriteLine("2.show all expense");
                Console.WriteLine("3.search iteam");
                Console.WriteLine("4.Modify item");
                Console.WriteLine("5.Delete items");
                Console.WriteLine("6.sort items alphabetically");
                Console.WriteLine("7.nomalize description");
                Console.WriteLine("0. Exit");


                int userPick = int.Parse(Console.ReadLine());
                int u;
                int s;
                switch ((Menu)userPick)
                {
                    case Menu.Add:
                        Console.WriteLine("How Many  items would you like to add ?");

                        int how = Convert.ToInt32(Console.ReadLine());

                        for (u = how; u < how + 1; u++)
                        {
                            for (s = 0; s < 5; s++)
                            {
                                if (s == 0)
                                {
                                    s++;
                                    Console.WriteLine("Please enter the date (e.g. MM/DD/YYYY)");
                                    string dat = Console.ReadLine();
                                    arrayItems[u, s] = dat;

                                    if (s == 1)
                                    {
                                        s++;
                                        Console.WriteLine("PLease type in your Item");
                                        string ItemName = Console.ReadLine();
                                        arrayItems[u, s] = ItemName;

                                        if (s == 2)
                                        {
                                            s++;
                                            Console.WriteLine("PLease enter item Price");
                                            string ItemsPrice = Console.ReadLine();
                                            arrayItems[u, s] = ItemsPrice;
                                            if (s == 3)
                                            {
                                                s++;
                                                Console.WriteLine(" enter the item's description");
                                                string itemDescriptions = Console.ReadLine();
                                                arrayItems[u, s] = itemDescriptions;
                                                if (s == 4)
                                                {

                                                    Console.WriteLine(" enter the item's category");
                                                    string ItemCateg = Console.ReadLine();
                                                    arrayItems[u, s] = ItemCateg;
                                                }
                                            }
                                        }
                                    }
                                }
                            }

                        }

                        break;
                    case Menu.show:
                        Console.WriteLine(" ");

                        int rowLength = arrayItems.GetLength(0);
                        int colLength = arrayItems.GetLength(1);

                        for (int m = 0; m < rowLength; m++)
                        {
                            for (int k = 0; k < colLength; k++)
                            {
                                Console.Write(string.Format("{0} ", arrayItems[m, k]));
                            }
                            Console.Write(Environment.NewLine + Environment.NewLine);

                        }

                        Console.WriteLine(" ");


                        break;
                    case Menu.search:
                        Console.WriteLine("Enter the data you'll like to find");
                        string searchItems = Console.ReadLine();

                        for (u = 0; u < 10; u++)
                        {
                            for (s = 0; s < 5; s++)
                            {
                                if (searchItems == arrayItems[u, s])

                                {
                                    Console.WriteLine(searchItems + " " + " " + "  found");
                                    Console.Write(arrayItems[u, s]);

                                }
                            }
                        }

                        break;
                    case Menu.modify:
                        Console.WriteLine("Enter data you will like to modify");
                        string dataChange = Console.ReadLine();

                        Console.WriteLine("Enter new data");
                        string newChanged = Console.ReadLine();


                        for (u = 0; u < 10; u++)
                        {
                            for (s = 0; s < 5; s++)
                            {
                                if (dataChange == arrayItems[u, s])
                                {
                                    for (int k = 0; k < 5; k++)

                                    {
                                        Console.WriteLine("Old data");
                                        Console.Write(arrayItems[u, k]);
                                        Console.WriteLine(" ");

                                        arrayItems[u, k] = (newChanged);
                                        Console.WriteLine("New data");
                                        Console.Write(arrayItems[u, k]);
                                        Console.WriteLine(" ");
                                    }
                                    Console.WriteLine();
                                }

                            }
                        }
                        break;
                    case Menu.delete:
                        Console.WriteLine("Please enter data you would like to Delete");
                        string del = Console.ReadLine();

                        for (u = 0; u < 10; u++)
                        {
                            for (s = 0; s < 4; s++)
                            {
                                if (del == arrayItems[u, s])
                                {
                                    for (int k = 0; k < 5; k++)
                                    {
                                        Console.WriteLine("Here is old Value");
                                        Console.Write(arrayItems[u, k]);
                                        Console.WriteLine(" ");

                                        arrayItems[u, k] = " ";
                                        Console.WriteLine(del + " " + " " + " Deleted");

                                    }
                                    Console.WriteLine();
                                }
                            }
                        }
                        break;
                    
                    case Menu.end:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("The userInput was invalid");
                        break;
                }
                Console.WriteLine("Would You Like To do contiu?\n Type Y for Yes \n Type x or No");
                response = Console.ReadLine();
            } while (response.Equals("Y") || response.Equals("y"));


            Console.ReadLine();
        }

    }

}

