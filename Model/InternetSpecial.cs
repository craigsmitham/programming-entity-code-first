using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class InternetSpecial
    {
        public int InternetSpecialId { get; set; }
        public int Nights { get; set; }
        public decimal CostUSD { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }

        public int AccomodationId { get; set; }
        public Lodging Accomodation { get; set; }
    }
}
