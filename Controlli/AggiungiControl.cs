using Gestione_Libreria.Classi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            MessageBox.Show(nomeTextBox.Texts+
                                         cognomeTextBox.Texts+
                                         telefonoTextBox.Texts+
                                         cellulareTextBox.Texts+
                                         emailTextBox.Texts+
                                         datanascitaTextBox.Texts+
                                         indirizzoTextBox.Texts+
                                         cittaTextBox.Texts+
                                         capTextBox.Texts+
                                         noteTextBox.Texts);
            Contatto contattonuovo = new(nomeTextBox.Texts,
                                         cognomeTextBox.Texts,
                                         Convert.ToInt32(cellulareTextBox.Texts),
                                         0,
                                         emailTextBox.Texts,
                                         datanascitaTextBox.Texts,
                                         indirizzoTextBox.Texts,
                                         cittaTextBox.Texts,
                                         Convert.ToInt32(capTextBox.Texts),
                                         noteTextBox.Texts);
            contattonuovo.ID=homeForm.rubrica.Count + 1;
            homeForm.rubrica.Add(contattonuovo);
        }
    }
}
