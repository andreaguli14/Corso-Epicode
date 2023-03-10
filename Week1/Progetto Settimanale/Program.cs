class Program
{
    static void Main(string[] args)
    {
        Console.Write("Inserisci il nome del contribuente: ");
        string nome = Console.ReadLine();

        Console.Write("Inserisci il cognome del contribuente: ");
        string cognome = Console.ReadLine();

        Console.Write("Inserisci la data di nascita del contribuente (formato dd/mm/yyyy): ");
        DateTime dataNascita = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

        Console.Write("Inserisci il codice fiscale del contribuente: ");
        string codiceFiscale = Console.ReadLine();

        Console.Write("Inserisci il sesso del contribuente (M/F): ");
        char sesso = char.Parse(Console.ReadLine().ToUpper());

        Console.Write("Inserisci il comune di residenza del contribuente: ");
        string comuneResidenza = Console.ReadLine();

        Console.Write("Inserisci il reddito annuale del contribuente: ");
        double redditoAnnuale = double.Parse(Console.ReadLine());

        Contribuente contribuente = new Contribuente(nome, cognome, dataNascita, codiceFiscale, sesso, comuneResidenza, redditoAnnuale);

        contribuente.Print();

    }
}
public class Contribuente
{
    private string Nome { get; set; }
    private string Cognome { get; set; }
    private DateTime DataNascita { get; set; }
    private string CodiceFiscale { get; set; }
    private char Sesso { get; set; }
    private string ComuneResidenza { get; set; }
    private double RedditoAnnuale { get; set; }
    private double Imposta { get; set; }

    public Contribuente(string nome, string cognome, DateTime dataNascita, string codiceFiscale, char sesso, string comuneResidenza, double redditoAnnuale)
    {
        Nome = nome;
        Cognome = cognome;
        DataNascita = dataNascita;
        CodiceFiscale = codiceFiscale;
        Sesso = sesso;
        ComuneResidenza = comuneResidenza;
        RedditoAnnuale = redditoAnnuale;
    }

    private double CalcolaImposta()
    {
        double reddito = RedditoAnnuale;
        double imposta = 0.0;
        double aliquota;

        if (reddito <= 15000)
        {
            aliquota = 0.23;
            imposta = reddito * aliquota;
        }
        else if (reddito <= 28000)
        {
            aliquota = 0.27;
            imposta = 3450 + (reddito - 15000) * aliquota;
        }
        else if (reddito <= 55000)
        {
            aliquota = 0.38;
            imposta = 6960 + (reddito - 28000) * aliquota;
        }
        else if (reddito <= 75000)
        {
            aliquota = 0.41;
            imposta = 17220 + (reddito - 55000) * aliquota;
        }
        else
        {
            aliquota = 0.43;
            imposta = 25420 + (reddito - 75000) * aliquota;
        }

        return imposta;
    }
    public void Print()
    {
        Console.WriteLine("==================================================");
        Console.WriteLine("CALCOLO DELL'IMPOSTA DA VERSARE:\n");
        Console.WriteLine($"Contribuente: {Nome} {Cognome},");
        Console.WriteLine($"nato il {DataNascita.ToString("dd/MM/yyyy")} ({Sesso}),");
        Console.WriteLine($"residente in {ComuneResidenza},");
        Console.WriteLine($"codice fiscale {CodiceFiscale}");
        Console.WriteLine($"Reddito dichiarato: {RedditoAnnuale}");
        Console.WriteLine($"IMPOSTA DA VERSARE: {CalcolaImposta()}");
    }
}