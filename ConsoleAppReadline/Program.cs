using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleAppReadline
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Please add a Username");
            //string Username = Console.ReadLine();

            //Console.WriteLine("Please add a Surname");
            //string Surname = Console.ReadLine();

            //Console.WriteLine("Please add a Password");
            //string Password = Console.ReadLine();

            //Console.WriteLine("username : "+Username);
            //Console.WriteLine("surname : "+Surname);
            //Console.WriteLine("password : "+Password);

            //Console.ReadLine();

            //----------------------------------------------------------------

            //Misal - 1

            //int num1 = 5;

            //int num2 = 8;

            //int cem = num1 + num2;

            //if (cem % 2 == 0)
            //{
            //    Console.WriteLine($"Cem, yeni {cem} cut ededdir");
            //}
            //else
            //{
            //    Console.WriteLine($"Cem, yeni {cem} tek ededdir");
            //}

            //----------------------------------------------------------------

            //Misal - 2
            //int[] ededler = { 1, 4, 22, 5, 9, 14, 20, 6, 8, 10 };

            //Console.WriteLine($"massivdeki cut ededler:");
            //foreach (int eded in ededler)
            //{
            //    if (eded % 2 == 0)
            //    {
            //        Console.WriteLine(eded);
            //    }
            //}

            //-------------------------------------------------------------------

            //Misal - 3

            //int[] Ededler = { 1, 3, 12, 8, 11, 5, 9, 10, 33, 7 };

            //Console.WriteLine("Tek ededler:");
            //int tekEdedlerinCemi = 0;

            //foreach (int n in Ededler)
            //{
            //    if (n % 2 != 0)
            //    {
            //        Console.WriteLine(n);
            //        tekEdedlerinCemi += n;
            //    }
            //}

            //Console.WriteLine($"Tek ededlerin cemi: {tekEdedlerinCemi}");

            //Misal - 4 

            //var adam1 = new
            //{
            //    name = "Eli",
            //    surname = "Eliyev",
            //    age = 22,
            //    speciality = "Designer",
            //    groupNo = 313

            //};

            //var adam2 = new
            //{
            //    name = "Hesen",
            //    surname = "Abbasov",
            //    age = 25,
            //    speciality = "Developer",
            //    groupNo = 566

            //};

            //var x = new[] { adam1, adam2 };

            //for (int i = 0; i < 2; i++)
            //{
            //    Console.WriteLine($"{x[i].name} {x[i].surname} {x[i].age} {x[i].speciality} {x[i].groupNo}");
            //    Console.WriteLine();
            //}

            //----------------------------------------------------------------

            //Misal - 5

            Console.Write("Dort reqemli sayi daxil edin");
            string input = Console.ReadLine();

            if (input.Length == 4 && int.TryParse(input, out int number))
            {
                int EdedinCemi = 0;
                 
                foreach (char reqem in input)
                {
                    int EdedinDeyeri = Convert.ToInt32(reqem.ToString());
                    Console.WriteLine($"{EdedinDeyeri} +");
                    EdedinCemi += EdedinDeyeri;
                }

                Console.WriteLine($"{EdedinCemi}");

                Console.WriteLine($"Daxil olunan ededin reqemlerinin cemi: {EdedinCemi}");
            }
            else
            {
                Console.WriteLine("Girilen eded 4 reqemli deyil");
            }
        }
    }
}