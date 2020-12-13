using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Xceed.Words.NET;
using System.Diagnostics;

namespace DocumentManager
{
    public static class HelperMethods
    {
        public static int CalculateAge(DateTime birthDate, DateTime deathDate)
        {
            int age = deathDate.Year - birthDate.Year;

            if (birthDate > deathDate.AddYears(-age))
                age--;

            return age;
        }
    }
}
