using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwnProject
{
   public class FuneralData
    {
        public string Method { get; set; }

        public string Type { get; set; }

        public string Date { get; set; }

        public string Catafalque { get; set; }

        public string CoffinOrUrnType { get; set; }

        public string CryptOrCaissionType { get; set; }

        public bool UrnCloth { get; set; }

        public string Grave { get; set; }

        public string GarveDigging { get; set; }

        public string GraveMarker { get; set; }

        public string Music { get; set; }



        //Taken over documents

        public bool isIDCardTaken { get; set; }

        public bool isAddressCardTaken { get; set; }

        public bool isDeathCertificateTaken { get; set; }

        public bool isBirthCertificateTaken { get; set; }

        public bool isMarriageCertificateTaken { get; set; }

        public bool isSpouseDeathCertificateTaken { get; set; }

        public bool isIDCardNeededByClient { get; set; }
    }
}
