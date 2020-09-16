using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Xceed.Words.NET;
using System.Diagnostics;

namespace OwnProject
{
    public static class HelperMethods
    {
        public static int CalculateAge(string birthDate, string deathDate)
        {
            DateTime birth = Convert.ToDateTime(birthDate);
            DateTime death = Convert.ToDateTime(deathDate);

            int age = death.Year - birth.Year;

            if (birth > death.AddYears(-age))
                age--;

            return age;
        }
    }
}
