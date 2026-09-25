using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Text;

namespace tp1
{
    public class Intervention
    {
        private DateTime date;
        private int montantTTC;
        private string information;

        public Intervention(DateTime uneDate, int unMontantTTC, string uneInformation)
        {
            this.date = uneDate;
            this.montantTTC = unMontantTTC;
            this.information = uneInformation;
        }

        public DateTime getDate()
        {
            return this.date;
        }

        public void setDate(DateTime uneDate)
        {
            this.date = uneDate;
        }

        public int getMontantTTC()
        {
            return this.montantTTC;
        }

        public void setMontantTTC(int unMontantTTC)
        {
            this.montantTTC = unMontantTTC;
        }

        public string getInformation()
        {
            return this.information;
        }

        public void setInformation(string uneInformation)
        {
            this.information = uneInformation;
        }
    }
}
