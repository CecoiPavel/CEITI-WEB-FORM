using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEITI_Students
{
    public class Elev
    {
        public string ID { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Patronimicul { get; set;}
        public string DataNașterii { get; set; }
        public int Vârsta { get; set; }
        public string StatutulElevului { get; set; }
        public decimal MediaDeConcurs { get; set; }
        public string Specialitatea { get; set; }
        public string ActivitatiExtrașcolare { get; set; }
        public int Anul { get; set; }
        public string InstituțiaAbsolvită { get; set; }
        public string Grupa { get; set; }
        public string Diriginte { get; set; }
        public string ÎREC { get; set;}

        Random Rnd = new Random();
        public Elev() 
        {
            this.ID = randomString();
        }
        string randomString()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string litere = new string(Enumerable.Repeat(chars, 3)
                .Select(s => s[Rnd.Next(s.Length)]).ToArray());
            const string nums = "1234567890";
            string numere = new string(Enumerable.Repeat(nums,3)
                .Select(s => s[Rnd.Next(s.Length)]).ToArray());
            return litere + numere;

        }



    }
}
