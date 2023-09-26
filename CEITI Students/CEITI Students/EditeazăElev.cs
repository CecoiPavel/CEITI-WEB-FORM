using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace CEITI_Students
{
    public partial class EditeazăElev : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "lohBg7D3K20lVAL8dkbzihNZqYGzMSGM0SBpiPCH",
            BasePath = "https://ceiti-students-default-rtdb.europe-west1.firebasedatabase.app/"
        };
        IFirebaseClient client;
        public EditeazăElev()
        {
            InitializeComponent();
            client = new FireSharp.FirebaseClient(config);
        }
        public Elev elevinfo { get; set; }

        private void EditeazăElev_Load(object sender, EventArgs e)
        {
            if (elevinfo != null)
            {
                Nume.Text = elevinfo.Nume;
                Prenume.Text = elevinfo.Prenume;
                Patronimicul.Text = elevinfo.Patronimicul;
                Varsta.Text = elevinfo.Vârsta.ToString();
                Statutul.Text = elevinfo.StatutulElevului;
                Specialitatea.Text = elevinfo.Specialitatea;
                Activitati.Text = elevinfo.ActivitatiExtrașcolare;
                Anul.Text = elevinfo.Anul.ToString();
                Absolvent.Text = elevinfo.InstituțiaAbsolvită;
                Grupa.Text = elevinfo.Grupa;
                Diriginte.Text = elevinfo.Diriginte;
                IREC.Text = elevinfo.ÎREC;
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                elevinfo.Nume = Nume.Text;
                elevinfo.Prenume = Prenume.Text;
                elevinfo.Patronimicul = Patronimicul.Text;
                elevinfo.Vârsta = Convert.ToInt32(Varsta.Text);
                elevinfo.StatutulElevului = Statutul.Text;
                elevinfo.Specialitatea = Specialitatea.Text;
                elevinfo.ActivitatiExtrașcolare = Activitati.Text;
                elevinfo.Anul = Convert.ToInt32(Anul.Text);
                elevinfo.InstituțiaAbsolvită = Absolvent.Text;
                elevinfo.Grupa = Grupa.Text;
                elevinfo.Diriginte = Diriginte.Text;
                elevinfo.ÎREC = IREC.Text;
                SetResponse response = await client.SetAsync("Elevi/" + elevinfo.ID, elevinfo);
                MessageBox.Show("Noile date s-au adăugat..");

            }
            catch (Exception)
            {

                MessageBox.Show("Ceva nu a mers bine..");
            }
        }
    }
}
