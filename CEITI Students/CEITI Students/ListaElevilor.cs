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
    public partial class ListaElevilor : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "lohBg7D3K20lVAL8dkbzihNZqYGzMSGM0SBpiPCH",
            BasePath = "https://ceiti-students-default-rtdb.europe-west1.firebasedatabase.app/"
        };
        IFirebaseClient client;
        Dictionary<string, Elev> listaDictionary;
        List<Elev> listaelevilor = new List<Elev>();
        public ListaElevilor()
        {
            InitializeComponent();
            client = new FireSharp.FirebaseClient(config);
        }

        private void ListaElevilor_Load(object sender, EventArgs e)
        {
            loadElevi();
        }
        private async void loadElevi()
        {
            listaelevilor.Clear();
            try
            {
                dataGridView1.Rows.Clear();
                var afiseaza = await client.GetAsync("Elevi");
                listaDictionary = afiseaza.ResultAs<Dictionary<string, Elev>>();
                if (listaDictionary != null)
                {
                    var nume = from x in listaDictionary orderby x.Value.Nume ascending select x;
                    foreach (var item in nume)
                    {
                        listaelevilor.Add(item.Value);
                        dataGridView1.Rows.Add(item.Value.Nume, item.Value.ID, item.Value.Vârsta);
                    }
                }
                else
                {
                    MessageBox.Show("Nu sunt date de afișat.");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Ceva nu a mers bine..");
            }
        }

        private void Editează_Click(object sender, EventArgs e)
        {
            Elev obj = new Elev();
            obj = listaelevilor[dataGridView1.CurrentCell.RowIndex];    

            using (EditeazăElev ade = new EditeazăElev () { elevinfo = obj })
            {
                if (ade.ShowDialog()==DialogResult.OK)
                {

                }
            }
            loadElevi();
        }
    }
}
