namespace DocumentManager.Data
{
    public class ClientData : AbstractData
    {
        public string ClientName { get { return clientName; } set { clientName = value; OnPropertyChanged(); } }

        public string Surname { get { return surname; } set { surname = value; OnPropertyChanged(); } }

        public string Forename { get { return forename; } set { forename = value; OnPropertyChanged(); } }

        public string Relative { get { return relative; } set { relative = value; OnPropertyChanged(); } }

        public string IdentifierDocumentNumber { get { return identifierDocumentNumber; } set { identifierDocumentNumber = value; OnPropertyChanged(); } }

        public string HomeCountry { get { return homeCountry; } set { homeCountry = value; OnPropertyChanged(); } }

        public string HomePostcode { get { return homePostcode; } set { homePostcode = value; OnPropertyChanged(); } }

        public string HomeCity { get { return homeCity; } set { homeCity = value; OnPropertyChanged(); } }

        public string HomeAddress { get { return homeAddress; } set { homeAddress = value; OnPropertyChanged(); } }

        public string HomeDistrict { get { return homeDistrict; } set { homeDistrict = value; OnPropertyChanged(); } }

        private string clientName;

        private string surname;

        private string forename;

        private string relative;

        private string identifierDocumentNumber;

        private string homeCountry;

        private string homePostcode;

        private string homeCity;

        private string homeAddress;

        private string homeDistrict;
    }
}
