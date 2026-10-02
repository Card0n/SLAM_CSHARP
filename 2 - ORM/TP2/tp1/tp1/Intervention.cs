using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Text;

namespace tp1
{
    public class Intervention
    {
        public int InterventionId { get; set; }
        public DateTime Date { get; set; }
        public int MontantTTC { get; set; }
        public string Information { get; set; }

        public Intervention()
        { 
        }
        public Intervention(DateTime uneDate, int unMontantTTC, string uneInformation)
        {
            this.Date = uneDate;
            this.MontantTTC = unMontantTTC;
            this.Information = uneInformation;
        }

       
    }
}
