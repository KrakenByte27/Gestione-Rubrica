namespace Gestione_Libreria.Classi
{
    public class Contatto
    {
        public Contatto(string nome,
                        string cognome,
                        int telefono,
                        int cellulare,
                        string email,
                        string datanascita,
                        string indirizzo,
                        string citta,
                        int cap,
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
        public int Telefono { get; set; }
        public int Cellulare { get; set; }
        public string Email { get; set; }
        public string Datanascita { get; set; }
        public string Indirizzo { get; set; }
        public string Citta { get; set;}
        public int Cap { get; set; } 
        public string Note { get; set; }
        public int ID { get; set; }
        public string Nomecompleto { get; set; }
    }
}
