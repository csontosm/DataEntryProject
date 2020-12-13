using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwnProject.Data
{
   public class ClientData: AbstractData
    {
        public string ClientName { get; set; }

        public string Surname { get; set; }

        public string Forename { get; set; }

        public string Relative { get; set; }

        public string IdentifierDocumentNumber { get; set; }

        public string HomeCountry { get; set; }

        public string HomePostcode { get; set; }

        public string HomeCity { get; set; }

        public string HomeAddress { get; set; }

        public string HomeDistrict { get; set; }

        public string Reach { get; set; }
    }
}
