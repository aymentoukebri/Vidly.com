using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly_Application.Models
{
    public class MembershipType
    {
        public byte id { get; set; }
        public string Name { get; set; }
        public short SignUpFee { get; set; }
        public byte DurationInMonths { get; set; } // on a utilisé byte car la valeur maximale est 12 ( 12 mois)
        public byte DiscountRate { get; set; } // on a une valeur maximale du pourcentage du discount ( 100 )

        public static readonly byte unknow = 0;
        public static readonly byte PayAsYouGo = 1;

    }
}
