namespace OOP2;
class Program
{
    static void Main(string[] args)
    {

        CalcoloArray calcoloarray = new CalcoloArray();
        ContoCorrente conto = new ContoCorrente();
        double versamentoIniziale;

        Console.WriteLine("Apertura in corso....");
        Console.Write("Fai un versamento per aprire il conto(min 1000): ");
        while (!double.TryParse(Console.ReadLine(), out versamentoIniziale))
        {
            Console.Write("Importo non valido. Rifai il versamento iniziale: ");
        }

        conto.ApriConto(versamentoIniziale);
        Console.WriteLine($"Saldo: {conto.saldo}");

        int scelta = 0;
        double importo;

        while (conto.statoConto && scelta != 5)
        {
            Console.WriteLine();
            Console.WriteLine("Cosa vuoi fare?");
            Console.WriteLine("1 - Effettuare un versamento");
            Console.WriteLine("2 - Effettuare un prelievo");
            Console.WriteLine("3 - Somma e Media di un array");
            Console.WriteLine("4 - Cerca un nome in un array");
            Console.WriteLine("5 - Esci");

            while (!int.TryParse(Console.ReadLine(), out scelta) || scelta < 1 || scelta > 5)
            {
                Console.WriteLine("Scelta non valida. Inserisci nuovamente la scelta:");
            }

            switch (scelta)
            {
                case 1:
                    Console.Write("Inserisci l'importo del versamento: ");
                    while (!double.TryParse(Console.ReadLine(), out importo) || importo <= 0)
                    {
                        Console.Write("Importo non valido. Inserisci nuovamente l'importo del versamento: ");
                    }
                    conto.Versamento(importo);
                    break;

                case 2:
                    Console.Write("Inserisci l'importo del prelievo: ");
                    while (!double.TryParse(Console.ReadLine(), out importo) || importo <= 0)
                    {
                        Console.Write("Importo non valido. Inserisci nuovamente l'importo del prelievo: ");
                    }
                    conto.Prelevamento(importo);
                    break;
                case 3:
                    calcoloarray.sommaMedia();
                    break;
                case 4:
                    calcoloarray.cercaNome();
                    break;
            }


        }
        
        
    }
   
}
class ContoCorrente
{
    public bool statoConto;
    public double saldo;

    public ContoCorrente()
    {
        statoConto = false;
        saldo = 0;
    }

    public void ApriConto(double depositoIniziale)
    {
        if (!statoConto && depositoIniziale >= 1000)
        {
            statoConto = true;
            saldo += depositoIniziale;
            Console.WriteLine("Conto aperto con successo.");
        }
        else
        {
            Console.WriteLine("Impossibile aprire il conto");
        }
    }

    public void Versamento(double importo)
    {
        if (statoConto && importo > 0)
        {
            saldo += importo;
            Console.WriteLine($"Versamento di {importo} euro effettuato con successo. Nuovo saldo: {saldo} euro.");
        }
        else
        {
            Console.WriteLine("Impossibile effettuare il versamento.");
        }
    }

    public void Prelevamento(double importo)
    {
        if (statoConto && importo > 0 && importo <= saldo)
        {
            saldo -= importo;
            Console.WriteLine($"Prelievo di {importo} euro effettuato con successo. Nuovo saldo: {saldo} euro.");
        }
        else
        {
            Console.WriteLine("Impossibile effettuare il prelievo.");
        }

        
    }

    
}
