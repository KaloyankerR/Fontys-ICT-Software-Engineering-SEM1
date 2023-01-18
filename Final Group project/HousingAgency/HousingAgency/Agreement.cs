using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingAgency
{
    internal class Agreement
    {
        private string agreement;

        public string AgreementElement
        {
            get { return agreement; }
            set { agreement = value; }
        }

        public void SetAgreement(string agreement)
        {
            this.agreement = agreement;
        }

        public string Display()
        {
            return this.agreement;
        }
    }
}
