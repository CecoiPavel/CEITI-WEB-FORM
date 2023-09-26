using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using global::FireSharp.Config;
using global::FireSharp.Interfaces;
using global::FireSharp.Response;


namespace CEITI_Students
{
    public partial class AdaugăElev : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "lohBg7D3K20lVAL8dkbzihNZqYGzMSGM0SBpiPCH",
            BasePath = "https://ceiti-students-default-rtdb.europe-west1.firebasedatabase.app/"
        };
        IFirebaseClient client;

        public AdaugăElev()
        {
            InitializeComponent();
        }

        private void AdaugăElev_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                Elev elev = new Elev
                {
                    Nume = Nume.Text,
                    Prenume = Prenume.Text,
                    Patronimicul = Patronimicul.Text,
                    DataNașterii = DataNasterii.Value.ToShortDateString(),
                    Vârsta = Convert.ToInt32(Varsta.Text),
                    StatutulElevului = Statutul.Text,
                    MediaDeConcurs = decimal.Parse(Media.Text),
                    Specialitatea = Specialitatea.Text,
                    ActivitatiExtrașcolare = Activitati.Text,
                    Anul = Convert.ToInt32(Anul.Text),
                    InstituțiaAbsolvită = Absolvent.Text,
                    Grupa = Grupa.Text,
                    Diriginte = Diriginte.Text,
                    ÎREC = IREC.Text,

                };
                SetResponse response = await client.SetAsync("Elevi/" + elev.ID, elev);
                MessageBox.Show(string.Format("Elevul {0}, {1} a fost adăugat în baza de date", elev.Nume, elev.Prenume));
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Ceva nu a mers bine..");
            }
        }

        private void DataNasterii_ValueChanged(object sender, EventArgs e)
        {
            DateTime ZiNaștere = DataNasterii.Value;
            DateTime Azi = DateTime.Today;
            int ani = Azi.Year - ZiNaștere.Year;
            if (ZiNaștere > Azi.AddYears(-ani))
            {
                --ani;
            }
            Varsta.Text = ani.ToString();
        }
    }
}
