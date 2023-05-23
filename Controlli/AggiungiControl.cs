using Gestione_Libreria.Classi;

namespace Gestione_Rubrica
{
    public partial class AggiungiControl : UserControl
    {
        public AggiungiControl()
        {
            InitializeComponent();
        }

        private void salvaButton_Click(object sender, EventArgs e)
        {
            Contatto contattonuovo = new(nomeTextBox.Texts,
                                         cognomeTextBox.Texts,
                                         telefonoTextBox.Texts,
                                         cellulareTextBox.Texts,
                                         emailTextBox.Texts,
                                         datanascitaTextBox.Texts,
                                         indirizzoTextBox.Texts,
                                         cittaTextBox.Texts,
                                         capTextBox.Texts,
                                         noteTextBox.Texts);
            contattonuovo.ID=homeForm.rubrica.Count + 1;
            homeForm.rubrica.Add(contattonuovo);
        }
    }
}
