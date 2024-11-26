using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice01.Classes
{
    public class Reservation
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime ArrivalDate { get; set; }

        public override string ToString()
        {
            return $"""
                {FirstName} {LastName.ToUpper()}
                {ArrivalDate.ToString("dd/MM/yyyy")}
                """;
        }
    }
}
