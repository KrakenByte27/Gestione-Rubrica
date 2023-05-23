namespace Gestione_Libreria.Classi
{
    public class Contatto
    {
        public Contatto(string nome,
                        string cognome,
                        string telefono,
                        string cellulare,
                        string email,
                        string datanascita,
                        string indirizzo,
                        string citta,
                        string cap,
                        string note)
        {
            Nome = nome;
            Cognome = cognome;
            Telefono = telefono;
            Cellulare = cellulare;
            Email = email;
            Datanascita = datanascita;
            Indirizzo = indirizzo;
            Citta = citta;
            Cap = cap;
            Note = note;
            Nomecompleto = nome + " " + cognome;
        }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string Telefono { get; set; }
        public string Cellulare { get; set; }
        public string Email { get; set; }
        public string Datanascita { get; set; }
        public string Indirizzo { get; set; }
        public string Citta { get; set;}
        public string Cap { get; set; } 
        public string Note { get; set; }
        public int ID { get; set; }
        public string Nomecompleto { get; set; }
    }
}
