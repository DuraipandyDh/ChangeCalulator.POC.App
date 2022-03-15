using ChangeCalulator.POC.BusinessLogic.Cureency;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeCalulator.POC.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Amount in Given Amount");
            string givenamount = Console.ReadLine();

            Console.WriteLine("Enter Amount in Given Amount");
            string productprice = Console.ReadLine();

            if (decimal.TryParse(givenamount, out decimal amount) && decimal.TryParse(productprice, out decimal price))
            {           
                CurrenncyBL currenncybalance = new CurrenncyBL(amount, price);

                for (int i = currenncybalance.NoteCount.Length - 1; i >= 0; i--)
                {
                    if (currenncybalance.NoteCount[i] > 0)
                    {                      
                        if (CurrenncyBL.Notes[i] <= (Decimal) 0.5)
                        {
                            var coin = Math.Round(CurrenncyBL.Notes[i] * 100);
                            Console.WriteLine($"  {currenncybalance.NoteCount[i]} X {coin}P");
                        }
                        else
                        {
                            Console.WriteLine($"  {currenncybalance.NoteCount[i]} X £{CurrenncyBL.Notes[i]}");
                        }                        
                    }
                }

                Console.WriteLine($"  Sum of balance   : {currenncybalance.NotesValue}");
                Console.ReadLine();
            }
        }
    }
}
