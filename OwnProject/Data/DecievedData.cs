using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwnProject.Data
{
    public class DecievedData: AbstractData
    {
        public string DateOfDeathYear { get { return dateOfDeathYear; } set { dateOfDeathYear = value; OnPropertyChanged(); } }

        public string DateOfDeathMonth { get { return dateOfDeathMonth; } set { dateOfDeathMonth = value; OnPropertyChanged(); } }

        public string DateOfDeathDay { get { return dateOfDeathDay; } set { dateOfDeathDay = value; OnPropertyChanged(); } }

        public string PlaceOfDeathCity { get { return placeOfDeathCity; } set { placeOfDeathCity = value; OnPropertyChanged(); } }

        public string BirthSurname { get { return birthSurname; } set { birthSurname = value; OnPropertyChanged(); } }

        public string BirthForename { get; set; }

        public string MarriageName { get; set; }

        public string DateOfBirthYear { get; set; }

        public string DateOfBirthMonth { get; set; }

        public string DateOfBirthDay { get; set; }

        public string PlaceOfBirthCountry { get; set; }

        public string PlaceOfBirthCity { get; set; }

        public string PersonalIdentifierNumber { get; set; }

        public string HomeCardNumber { get; set; }

        public string IdentifierDocumentNumber { get; set; }

        public string Nationality { get; set; }

        public string HomeCountry { get; set; }

        public string HomeCity { get; set; }

        public string HomeAddress { get; set; }

        public string FatherBirthSurname { get; set; }

        public string FatherBirthForename { get; set; }

        public string MotherBirthSurname { get; set; }

        public string MotherBirthForename { get; set; }

        public string KidsFromLastMarriageAll { get; set; }

        public string KidsFromLastMarriageBornAlive { get; set; }

        public string KidsFromLastMarriageAlive { get; set; }

        public string KidsAlltogetherAll { get; set; }

        public string KidsAlltogetherBornAlive { get; set; }

        public string KidsAlltogetherAlive { get; set; }

        public string Profession { get; set; }

        public string Name { get; set; }

        public string Age { get; set; }

        public string Gender { get; set; }

        public string PlaceOfBrithDistrict { get; set; }

        public string PlaceOfDeathDistrict { get; set; }

        public string HomeDistrict { get; set; }

        public string ResidenceCity { get; set; }

        public string ResidenceDistrict { get; set; }

        public string Qualification { get; set; }

        public bool IsMarried { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        private string dateOfDeathYear;

        private string dateOfDeathMonth;

        private string dateOfDeathDay;

        private string placeOfDeathCity;

        private string birthSurname;
    }
}
