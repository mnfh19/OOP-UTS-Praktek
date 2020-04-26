using System;

namespace tugas_2
{
    class Program
    {
        static void Main(string[] args)
        {
            RetailItem [] r = new RetailItem[3];
            r[0] = new RetailItem("Jacket", 12, 59.95);
            r[1] = new RetailItem("Jeans", 40, 34.95);
            r[2] = new RetailItem("Shirt", 20, 24.95);

            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("\t Description \t Units on Hand \t Price");
            Console.WriteLine("-------------------------------------------------");

            for (int i = 0; i < r.Length; i++)
            {
                Console.WriteLine("Item " + (i + 1) + " \t " + r[i].description + " \t " + r[i].unitsOnHand + " \t " + r[i].price);
            }
            Console.WriteLine("-------------------------------------------------");
            Console.ReadLine();
        }
    }
    }

