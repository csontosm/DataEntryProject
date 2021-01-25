using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentManager
{
    public static class Constants
    {
        public static string pathCoffinTypes = @"C:\Users\Csontos\Source\Repos\DataEntryProject\CoffinTypes.txt";
        public static string pathUrnTypes = @"C:\Users\Csontos\Source\Repos\DataEntryProject\UrnTypes.txt";
        public static string pathSettings = @"C:\Users\Csontos\Source\Repos\DataEntryProject\Settings.txt";

        public static string[] funeralTypes = {"Polgári", "Katolikus", "Református", "Evangélikus", "Görög Katolikus", "Baptista", "Jehova", "Szombatista"};
        public static string[] funeralGraveOrCrypt = {"Sirkő", "Nincs sirkő", "Kripta", "Kolombárium"};
        public static string[] funeralGraveMarkers = {"Kereszt", "Fejfa"};
        public static string[] funeralCryptOrCassion = {"-", "Vakkripta", "1 Személyes", "2 Személyes", "4 Személyes"};
        public static string[] funeralGraveDigging = {"Sima", "Mélyitett", "Sima bővitett", "Méylitett bővitett"};
        public static string[] funeralCatafalques = {"Pax", "Városi", "Sirnál"};
    }
}
