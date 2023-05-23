using Gestione_Libreria.Classi;

namespace Gestione_Rubrica
{
    public partial class ModificaControl : UserControl
    {
        Contatto contattosel;
        public ModificaControl(Contatto contatto1)
        {
            InitializeComponent();
            contattosel = contatto1;
        }

        private void ModificaControl_Load(object sender, EventArgs e)
        {
            if (contattosel != null)
            {
                nomeTextBox.Texts = contattosel.Nome;
                cognomeTextBox.Texts = contattosel.Cognome;
                telefonoTextBox.Texts = contattosel.Telefono;
                cellulareTextBox.Texts = contattosel.Cellulare;
                emailTextBox.Texts = contattosel.Email;
                datanascitaTextBox.Texts = contattosel.Datanascita;
                indirizzoTextBox.Texts = contattosel.Indirizzo;
                cittaTextBox.Texts = contattosel.Citta;
                capTextBox.Texts = contattosel.Cap;
                noteTextBox.Texts = contattosel.Note;
            }
        }

        private void salvaButton_Click(object sender, EventArgs e)
        {
            contattosel.Nome = nomeTextBox.Texts;
            contattosel.Cognome = cognomeTextBox.Texts;
            contattosel.Telefono = telefonoTextBox.Texts;
            contattosel.Cellulare = cellulareTextBox.Texts;
            contattosel.Email = emailTextBox.Texts;
            contattosel.Datanascita = datanascitaTextBox.Texts;
            contattosel.Indirizzo = indirizzoTextBox.Texts;
            contattosel.Citta = cittaTextBox.Texts;
            contattosel.Cap = capTextBox.Texts;
            contattosel.Note = noteTextBox.Texts;
            contattosel.Nomecompleto= nomeTextBox.Texts + cognomeTextBox.Texts;

            homeForm.instance.refreshList();
        }
    }
}
