class Program
{
    static void Main(string[] args)
    {
        Atleta atleta = new Atleta("andrea","gulisano","basket");
        Dipendente dipendente = new Dipendente("Kris","Camilleri","IT Manager");
        Animale animale = new Animale("Gatto", 3);
        Veicolo veicolo = new Veicolo("Nissan", "Juke", "AA000AA");

        Console.WriteLine($"L'atleta si chiama {atleta.nome} {atleta.cognome} e fa {atleta.sport}");
        Console.WriteLine($"Il dipendente si chiama {dipendente.nome} {dipendente.cognome} e il suo lavoro e` {dipendente.lavoro}");
        Console.WriteLine($"L'animale e` un {animale.specie} e ha {animale.eta} anni");
        Console.WriteLine($"Il veicolo e`una {veicolo.marca} il modello e`{veicolo.modello} ed e`targata {veicolo.targa}");
    }

}

class Atleta
{
   public string nome { get; }
   public string cognome { get; }
   public string sport { get; }

    public Atleta(string nome, string cognome, string sport)
    {
        this.nome = nome;
        this.cognome = cognome;
        this.sport = sport;
    }
}

class Dipendente
{
    public string nome { get; }
    public string cognome { get; }
    public string lavoro { get; }

    public Dipendente(string nome, string cognome, string lavoro)
    {
        this.nome = nome;
        this.cognome = cognome;
        this.lavoro = lavoro;
    }
}

class Animale
{
    public string specie { get; }
    public int eta { get; }

    public Animale(string specie, int eta)
    {
        this.specie = specie;
        this.eta = eta;
    }
}

class Veicolo
{
    public string marca { get; }
    public string modello { get; }
    public string targa { get; }

    public Veicolo(string marca, string modello, string targa)
    {
        this.marca = marca;
        this.modello = modello;
        this.targa = targa;
    }
}