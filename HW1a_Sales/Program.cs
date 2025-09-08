// HW1a Sales Total

// Your Name: Tony Hernandez
// Did you seek help ? If yes, specify the helper or web link here: 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1a_Sales
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double qty;
            double price;
            double subtotal;
            double tax;
            double total;
            double salestax;

            string qtyAsString;
            string priceAsString;
            string salestaxAsString;
            double taxAsString;
            double totalAsString;
            double subtotalAsString;

            tax = 0.085;

            Console.WriteLine("What is the product name of the item that you are purchasing?");
            Console.ReadLine();

            Console.WriteLine("How many Football Tickets do you want to buy?");
            qtyAsString = Console.ReadLine();

            Console.WriteLine("What is the price for each Football Ticket?");
            priceAsString = Console.ReadLine();

            qty = Convert.ToDouble(qtyAsString);
            price = Convert.ToDouble(priceAsString);

            subtotal = qty * price;

            salestax = subtotal * tax;

            total = salestax + subtotal;

            Console.WriteLine($"Your subtotal is {subtotal}");
            Console.WriteLine($"Your sales tax is {salestax}");
            Console.WriteLine($"Your total is {total}");

            Console.ReadKey();
                




        }
    }
}
