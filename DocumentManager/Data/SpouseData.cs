namespace DocumentManager.Data
{
    public class SpouseData : AbstractData
    {
        public string DateOfMarriageYear { get { return dateOfMarriageYear; } set { dateOfMarriageYear = value; OnPropertyChanged(); } }

        public string DateOfMarriageMonth { get { return dateOfMarriageMonth; } set { dateOfMarriageMonth = value; OnPropertyChanged(); } }

        public string DateOfMarriageDay { get { return dateOfMarriageDay; } set { dateOfMarriageDay = value; OnPropertyChanged(); } }

        public string PlaceOfMarriageCountry { get { return placeOfMarriageCountry; } set { placeOfMarriageCountry = value; OnPropertyChanged(); } }

        public string PlaceOfMarriageCity { get { return placeOfMarriageCity; } set { placeOfMarriageCity = value; OnPropertyChanged(); } }

        public string PlaceOfMarriageDistrict { get { return placeOfMarriageDistrict; } set { placeOfMarriageDistrict = value; OnPropertyChanged(); } }

        public string BirthSurname { get { return birthSurname; } set { birthSurname = value; OnPropertyChanged(); } }

        public string BirthForename { get { return birthForename; } set { birthForename = value; OnPropertyChanged(); } }

        public string MarriageName { get { return marriageName; } set { marriageName = value; OnPropertyChanged(); } }

        public string DateOfBirthYear { get { return dateOfBirthYear; } set { dateOfBirthYear = value; OnPropertyChanged(); } }

        public string DateOfBirthMonth { get { return dateOfBirthMonth; } set { dateOfBirthMonth = value; OnPropertyChanged(); } }

        public string DateOfBirthDay { get { return dateOfBirthDay; } set { dateOfBirthDay = value; OnPropertyChanged(); } }

        public string PlaceOfBirthCountry { get { return placeOfBirthCountry; } set { placeOfBirthCountry = value; OnPropertyChanged(); } }

        public string PersonalIdentifierNumber { get { return personalIdentifierNumber; } set { personalIdentifierNumber = value; OnPropertyChanged(); } }

        public string HomeCity { get { return homeCity; } set { homeCity = value; OnPropertyChanged(); } }

        public string HomeAddress { get { return homeAddress; } set { homeAddress = value; OnPropertyChanged(); } }

        public string HomeDistrict { get { return homeDistrict; } set { homeDistrict = value; OnPropertyChanged(); } }

        public string Nationality { get { return nationality; } set { nationality = value; OnPropertyChanged(); } }

        public string ResidenceCity { get { return residenceCity; } set { residenceCity = value; OnPropertyChanged(); } }

        public string ResidenceDistrict { get { return residenceDistrict; } set { residenceDistrict = value; OnPropertyChanged(); } }

        private string dateOfMarriageYear;

        private string dateOfMarriageMonth;

        private string dateOfMarriageDay;

        private string placeOfMarriageCountry;

        private string placeOfMarriageCity;

        private string placeOfMarriageDistrict;

        private string birthSurname;

        private string birthForename;

        private string marriageName;

        private string dateOfBirthYear;

        private string dateOfBirthMonth;

        private string dateOfBirthDay;

        private string placeOfBirthCountry;

        private string personalIdentifierNumber;

        private string homeCity;

        private string homeAddress;

        private string homeDistrict;

        private string nationality;

        private string residenceCity;

        private string residenceDistrict;
    }
}
