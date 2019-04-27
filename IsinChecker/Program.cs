using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISIN_Validator.Helpers;
using ISIN_Validator.Models;

namespace IsinChecker
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var app = new IsinCountryReader();

            var countryList = app.GetIsinCountries();
            foreach (var country in countryList)
            {
                Console.WriteLine(country);
            }
            Console.ReadLine();
        }
    }
}
