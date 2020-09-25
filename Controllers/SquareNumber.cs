using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ASSIGNMENT01_N00481777_BRYANHUGHES.Controllers
{
    public class SquareNumberController : ApiController
    {
        // GET: api/SquareNumber/
        public int Get(int id)
        {
            int SquaredNumber = id * id;
            return SquaredNumber;
        }
    }
}