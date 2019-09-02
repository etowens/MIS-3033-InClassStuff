using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWK1_Owens
{
    class Program
    {
        public const double cogPrice = 79.99;
        public const double gearPrice = 250.00;
        public const double standardMarkup = .15;
        public const double bulkMarkup = .125;
        public const double salesTax = .089;
        static void Main(string[] args)
        {
            double cogsAndGearsPrice;
            double discount;
            double totalCogsAndGearsPrice;
            double markupPercentage;
            double finalPrice;
            int cogs;
            int gears;
            Console.Write("Please type in the number of cogs you would like to purchase: ");
            cogs = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please type in the number of gears you would like to purchase: ");
            gears = Convert.ToInt32(Console.ReadLine());
            if (cogs >= 10 || gears >= 10 || cogs + gears >= 16)
            {
                markupPercentage = bulkMarkup;
                discount = .025;
             
            }
            else
            {
                markupPercentage = standardMarkup;
                discount = 0;
            }
            cogsAndGearsPrice = ((cogs * cogPrice) + (gears * gearPrice));
            totalCogsAndGearsPrice = cogsAndGearsPrice * markupPercentage + cogsAndGearsPrice;
            finalPrice = cogsAndGearsPrice * salesTax + cogsAndGearsPrice;
            Console.Write($"\nYour total cost for your cogs and gears was: {totalCogsAndGearsPrice:C}.\nYour total discount amount was: {cogsAndGearsPrice * discount:C}.\n" +
                $"The total sales tax was: {salesTax * cogsAndGearsPrice:C}.\nYour grand total is: {finalPrice:C}.");
            Console.ReadKey();
            
        }
    }
}
