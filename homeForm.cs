using Gestione_Libreria.Classi;
using System.ComponentModel;

namespace Gestione_Rubrica
{
    public partial class homeForm : Form
    {
        public static BindingList<Contatto> rubrica = new BindingList<Contatto>();
        public static homeForm? instance;
        public homeForm()
        {
            InitializeComponent();
            instance = this;
        }

        private void aggiungiButton_Click(object sender, EventArgs e)
        {
            actionPanel.Controls.Clear();
            var controllo = new AggiungiControl();
            controllo.Location = new Point(5, 8);
            actionPanel.Controls.Add(controllo);
        }

        private void grigliaButton_Click(object sender, EventArgs e)
        {
            grigliaForm form1 = new();
            form1.ShowDialog();
        }

        private void listacontatti_SelectedIndexChanged(object sender, EventArgs e)
        {
            Contatto? contattosel = rubrica.SingleOrDefault(p => p.ID == Convert.ToInt16(listacontatti.SelectedValue));
            actionPanel.Controls.Clear();
            var controllo = new ModificaControl(contattosel);
            controllo.Location = new Point(5, 8);
            actionPanel.Controls.Add(controllo);

        }

        private void homeForm_Load(object sender, EventArgs e)
        {
            listacontatti.DataSource = rubrica;
            listacontatti.DisplayMember = "Nomecompleto";
            listacontatti.ValueMember = "ID";
        }

        public void refreshList()
        {
            listacontatti.DataSource = null;
            listacontatti.Items.Clear();
            listacontatti.DataSource = rubrica;
            listacontatti.DisplayMember = "Nomecompleto";
            listacontatti.ValueMember = "ID";
        }
    }
}