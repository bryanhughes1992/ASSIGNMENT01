using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ASSIGNMENT01_BRYANHUGHES.Controllers
{
    public class ASSIGNMENTController : ApiController
    {
        //QUESTION #1 - AddTen
        public int AddTen(int id)
        {  
            int sum = id + 10;
            return sum;
        }

        //QUESTION #2 - Square
        public int Square(int id)
        {
            int SquaredNumber = id * id;
            return SquaredNumber;
        }

        //QUESTION #3 - Greeting
        public void GetGreeting()
        {
            string Greeting = "Hello World!";
            Console.Write(Greeting);
        }

        //QUESTION #4 - Advanced Greeting
        public void CountGuests(int id)
        {
            int NumberOfPeople = id;
            string Greeting = $"Greetings to {NumberOfPeople} people!";
            Console.Write(Greeting);
        }

        //BONUS QUESTION - HostingCost
        public double HostingCost(int id)
        {
            int DaysStayed = id;
            int FortNite = 14;
            int NumOfFortnite;
            double Cost = 5.50;
            double SalesTax = 1.13;
            double SubTotal; 
            double Total;

            if (DaysStayed <= 0)
            {
                return 0;
            }

            if (DaysStayed > 14)
            {
                if (DaysStayed > 14 && DaysStayed < 28)
                {
                    DaysStayed = FortNite;
                    NumOfFortnite = DaysStayed / FortNite;
                    SubTotal = NumOfFortnite * Cost;
                    Total = SubTotal * SalesTax;

                    return Total;
                };

                if (DaysStayed > 28 && DaysStayed > 42)
                {
                    DaysStayed = FortNite * 2;
                    NumOfFortnite = DaysStayed / FortNite;
                    SubTotal = NumOfFortnite * Cost;
                    Total = SubTotal * SalesTax;

                    return Total;
                };
            }
            else
            {
                DaysStayed = FortNite;
                NumOfFortnite = DaysStayed / FortNite;
                SubTotal = NumOfFortnite * Cost;
                Total = SubTotal * SalesTax;

                return Total;
            }

            return 0;
        }
    }
}
