using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ASSIGNMENT01_N00481777_BRYANHUGHES.Controllers
{
    public class AssignmentController : ApiController
    {
        // GET: api/assignment/{id}
        public int Get(int id)
        {
            int SquaredNumber = id * id;
            return SquaredNumber;
        }

        // POST: api/assignment
        public void Post()
        {
            string Greeting = "Hello World!";
            Console.Write(Greeting);
        }

        // PUT: api/assignment/
        public void Put(int id)
        {
            int NumberOfPeople = id;
            string Greeting = $"Greetings to {NumberOfPeople} people!";
            Console.Write(Greeting);
        }

        // GET: /api/assignment
        public double GetHostingCost(int id)
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

// This assignment was challenging for me. I think my logic is correct, but I just tried my best when it came
// to writing the comments for each method, and the name of each method. I did learn a lot from the project, but I
// wanted to write this to tell you where I struggled, and if I got them all wrong, this is why.
