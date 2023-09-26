global using global::FireSharp.Config;
global using global::FireSharp.Interfaces;
global using global::FireSharp.Response;

namespace CEITI_Students
{
    public partial class MainForm : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "lohBg7D3K20lVAL8dkbzihNZqYGzMSGM0SBpiPCH",
            BasePath = "https://ceiti-students-default-rtdb.europe-west1.firebasedatabase.app/"
        };

        IFirebaseClient client;
        public MainForm()
        {
            InitializeComponent();
            client = new FireSharp.FirebaseClient(config);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void ieșireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            mainDisplayPanel.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }
        private void acasăToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new Acasă());
        }

        private void adaugăElevToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new AdaugăElev());
        }

        private void listaElevilorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new ListaElevilor());
        }
    }
}