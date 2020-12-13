namespace OwnProject.Data
{
    public class FuneralData : AbstractData
    {
        public string Method { get { return method; } set { method = value; OnPropertyChanged(); } }

        public string Type { get { return type; } set { type = value; OnPropertyChanged(); } }

        public string Date { get { return date; } set { date = value; OnPropertyChanged(); } }

        public string Catafalque { get { return catafalque; } set { catafalque = value; OnPropertyChanged(); } }

        public string CoffinOrUrnType { get { return coffinOrUrnType; } set { coffinOrUrnType = value; OnPropertyChanged(); } }

        public string CryptOrCaissionType { get { return cryptOrCaissionType; } set { cryptOrCaissionType = value; OnPropertyChanged(); } }

        public bool UrnCloth { get { return urnCloth; } set { urnCloth = value; OnPropertyChanged(); } }

        public string Grave { get { return grave; } set { grave = value; OnPropertyChanged(); } }

        public string GarveDigging { get { return garveDigging; } set { garveDigging = value; OnPropertyChanged(); } }

        public string GraveMarker { get { return graveMarker; } set { graveMarker = value; OnPropertyChanged(); } }

        public string Music { get { return music; } set { music = value; OnPropertyChanged(); } }



        //Taken over documents

        public bool isIDCardTaken { get { return isIDCardTaken; } set { isIDCardTaken = value; OnPropertyChanged(); } }

        public bool isAddressCardTaken { get { return isAddressCardTaken; } set { isAddressCardTaken = value; OnPropertyChanged(); } }

        public bool isDeathCertificateTaken { get { return isDeathCertificateTaken; } set { isDeathCertificateTaken = value; OnPropertyChanged(); } }

        public bool isBirthCertificateTaken { get { return isBirthCertificateTaken; } set { isBirthCertificateTaken = value; OnPropertyChanged(); } }

        public bool isMarriageCertificateTaken { get { return isMarriageCertificateTaken; } set { isMarriageCertificateTaken = value; OnPropertyChanged(); } }

        public bool isSpouseDeathCertificateTaken { get { return isSpouseDeathCertificateTaken; } set { isSpouseDeathCertificateTaken = value; OnPropertyChanged(); } }

        public bool isIDCardNeededByClient { get { return isIDCardNeededByClient; } set { isIDCardNeededByClient = value; OnPropertyChanged(); } }

        private string method;

        private string type;

        private string date;

        private string catafalque;

        private string coffinOrUrnType;

        private string cryptOrCaissionType;

        private bool urnCloth;

        private string grave;

        private string garveDigging;

        private string graveMarker;

        private string music;
    }
}
