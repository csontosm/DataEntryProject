namespace DocumentManager.Data
{
    public class DeceasedData : AbstractData
    {
        public string DateOfDeathYear { get { return dateOfDeathYear; } set { dateOfDeathYear = value; OnPropertyChanged(); } }

        public string DateOfDeathMonth { get { return dateOfDeathMonth; } set { dateOfDeathMonth = value; OnPropertyChanged(); } }

        public string DateOfDeathDay { get { return dateOfDeathDay; } set { dateOfDeathDay = value; OnPropertyChanged(); } }

        public string PlaceOfDeathCity { get { return placeOfDeathCity; } set { placeOfDeathCity = value; OnPropertyChanged(); } }

        public string BirthSurname { get { return birthSurname; } set { birthSurname = value; OnPropertyChanged(); } }

        public string BirthForename { get { return birthForename; } set { birthForename = value; OnPropertyChanged(); } }

        public string MarriageName { get { return marriageName; } set { marriageName = value; OnPropertyChanged(); } }

        public string DateOfBirthYear { get { return dateOfBirthYear; } set { dateOfBirthYear = value; OnPropertyChanged(); } }

        public string DateOfBirthMonth { get { return dateOfBirthMonth; } set { dateOfBirthMonth = value; OnPropertyChanged(); } }

        public string DateOfBirthDay { get { return dateOfBirthDay; } set { dateOfBirthDay = value; OnPropertyChanged(); } }

        public string PlaceOfBirthCountry { get { return placeOfBirthCountry; } set { placeOfBirthCountry = value; OnPropertyChanged(); } }

        public string PlaceOfBirthCity { get { return placeOfBirthCity; } set { placeOfBirthCity = value; OnPropertyChanged(); } }

        public string PersonalIdentifierNumber { get { return personalIdentifierNumber; } set { personalIdentifierNumber = value; OnPropertyChanged(); } }

        public string HomeCardNumber { get { return homeCardNumber; } set { homeCardNumber = value; OnPropertyChanged(); } }

        public string IdentifierDocumentNumber { get { return identifierDocumentNumber; } set { identifierDocumentNumber = value; OnPropertyChanged(); } }

        public string IdentifierDocumentExpireYear
        {
            get
            {
                return identifierDocumentExpireYear;
            }
            set
            {
                identifierDocumentExpireYear = value;
                OnPropertyChanged();
                if (value == "Hat.Nélk.")
                {
                    IdentifierDocumentExpireMonth = "";
                    IdentifierDocumentExpireDay = "";
                }
            }
        }

        public string IdentifierDocumentExpireMonth { get { return identifierDocumentExpireMonth; } set { identifierDocumentExpireMonth = value; OnPropertyChanged(); } }

        public string IdentifierDocumentExpireDay { get { return identifierDocumentExpireDay; } set { identifierDocumentExpireDay = value; OnPropertyChanged(); } }

        public string Nationality { get { return nationality; } set { nationality = value; OnPropertyChanged(); } }

        public string HomeCountry { get { return homeCountry; } set { homeCountry = value; OnPropertyChanged(); } }

        public string HomeCity { get { return homeCity; } set { homeCity = value; OnPropertyChanged(); } }

        public string HomeAddress { get { return homeAddress; } set { homeAddress = value; OnPropertyChanged(); } }

        public string FatherBirthSurname { get { return fatherBirthSurname; } set { fatherBirthSurname = value; OnPropertyChanged(); } }

        public string FatherBirthForename { get { return fatherBirthForename; } set { fatherBirthForename = value; OnPropertyChanged(); } }

        public string MotherBirthSurname { get { return motherBirthSurname; } set { motherBirthSurname = value; OnPropertyChanged(); } }

        public string MotherBirthForename { get { return motherBirthForename; } set { motherBirthForename = value; OnPropertyChanged(); } }

        public string KidsFromLastMarriageAll
        {
            get
            {
                return kidsFromLastMarriageAll;
            }
            set
            {
                kidsFromLastMarriageAll = value;
                OnPropertyChanged();
                if (!HasKidsFromOtherMarriage) KidsAlltogetherAll = value;
            }
        }

        public string KidsFromLastMarriageBornAlive
        {
            get
            {
                return kidsFromLastMarriageBornAlive;
            }
            set
            {
                kidsFromLastMarriageBornAlive = value;
                OnPropertyChanged();
                if (!HasKidsFromOtherMarriage) KidsAlltogetherBornAlive = value;
            }
        }

        public string KidsFromLastMarriageAlive
        {
            get
            {
                return kidsFromLastMarriageAlive;
            }
            set
            {
                kidsFromLastMarriageAlive = value;
                OnPropertyChanged();
                if (!HasKidsFromOtherMarriage) KidsAlltogetherAlive = value;
            }
        }

        public string KidsAlltogetherAll { get { return kidsAlltogetherAll; } set { kidsAlltogetherAll = value; OnPropertyChanged(); } }

        public string KidsAlltogetherBornAlive { get { return kidsAlltogetherBornAlive; } set { kidsAlltogetherBornAlive = value; OnPropertyChanged(); } }

        public string KidsAlltogetherAlive { get { return kidsAlltogetherAlive; } set { kidsAlltogetherAlive = value; OnPropertyChanged(); } }

        public string Profession { get { return profession; } set { profession = value; OnPropertyChanged(); } }

        public string Name { get { return name; } set { name = value; OnPropertyChanged(); } }

        public string Gender { get { return gender; } set { gender = value; OnPropertyChanged(); } }

        public string PlaceOfBrithDistrict { get { return placeOfBrithDistrict; } set { placeOfBrithDistrict = value; OnPropertyChanged(); } }

        public string PlaceOfDeathDistrict { get { return placeOfDeathDistrict; } set { placeOfDeathDistrict = value; OnPropertyChanged(); } }

        public string HomeDistrict { get { return homeDistrict; } set { homeDistrict = value; OnPropertyChanged(); } }

        public string ResidenceCity { get { return residenceCity; } set { residenceCity = value; OnPropertyChanged(); } }

        public string ResidenceDistrict { get { return residenceDistrict; } set { residenceDistrict = value; OnPropertyChanged(); } }

        public string Qualification { get { return qualification; } set { qualification = value; OnPropertyChanged(); } }

        public bool IsMarried { get { return isMarried; } set { isMarried = value; OnPropertyChanged(); } }

        public bool HasKidsFromOtherMarriage
        {
            get
            {
                return hasKidsFromOtherMarriage;
            }
            set
            {
                hasKidsFromOtherMarriage = value;
                OnPropertyChanged();
                if (value)
                {
                    KidsAlltogetherAll = "";
                    KidsAlltogetherBornAlive = "";
                    KidsAlltogetherAlive = "";

                }
                else
                {
                    KidsAlltogetherAll = KidsFromLastMarriageAll;
                    KidsAlltogetherBornAlive = KidsFromLastMarriageBornAlive;
                    KidsAlltogetherAlive = KidsFromLastMarriageAlive;
                }
            }
        }

        public bool IsDeceasedHomeEqualsResidence
        {
            get
            {
                return isDeceasedHomeEqualsResidence;
            }
            set
            {
                isDeceasedHomeEqualsResidence = value;
                OnPropertyChanged();
                if (value)
                {
                    ResidenceCity = HomeCity;
                    ResidenceDistrict = HomeDistrict;
                }
                else
                {
                    ResidenceCity = "";
                    ResidenceDistrict = "";
                }
            }
        }

        private string dateOfDeathYear;

        private string dateOfDeathMonth;

        private string dateOfDeathDay;

        private string placeOfDeathCity;

        private string birthSurname;

        private string birthForename;

        private string marriageName;

        private string dateOfBirthYear;

        private string dateOfBirthMonth;

        private string dateOfBirthDay;

        private string placeOfBirthCountry;

        private string placeOfBirthCity;

        private string personalIdentifierNumber;

        private string homeCardNumber;

        private string identifierDocumentNumber;

        private string identifierDocumentExpireYear;

        private string identifierDocumentExpireMonth;

        private string identifierDocumentExpireDay;

        private string nationality;

        private string homeCountry;

        private string homeCity;

        private string homeAddress;

        private string fatherBirthSurname;

        private string fatherBirthForename;

        private string motherBirthSurname;

        private string motherBirthForename;

        private string kidsFromLastMarriageAll;

        private string kidsFromLastMarriageBornAlive;

        private string kidsFromLastMarriageAlive;

        private string kidsAlltogetherAll;

        private string kidsAlltogetherBornAlive;

        private string kidsAlltogetherAlive;

        private string profession;

        private string name;

        private string gender;

        private string placeOfBrithDistrict;

        private string placeOfDeathDistrict;

        private string homeDistrict;

        private string residenceCity;

        private string residenceDistrict;

        private string qualification;

        private bool isMarried;

        private bool hasKidsFromOtherMarriage;

        private bool isDeceasedHomeEqualsResidence;
    }
}