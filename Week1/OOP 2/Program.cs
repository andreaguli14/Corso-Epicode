using OOP2;

namespace OOP2;
class Program
{
    static void Main(string[] args)
    {

        ContoCorrente conto = new ContoCorrente();

        conto.Banca();
             
    }
   
}
class ContoCorrente
{
    private bool statoConto;
    private decimal saldo;

    public ContoCorrente()
    {
        statoConto = false;
        saldo = 0;
    }

    public void ApriConto(decimal depositoIniziale)
    {
        if (!statoConto && depositoIniziale >= 1000)
        {
            statoConto = true;
            saldo += depositoIniziale;
            Console.WriteLine("Conto aperto con successo.");
            Console.WriteLine($"Saldo: {saldo}");
        }
        else
        {
            Console.WriteLine("Impossibile aprire il conto");
        }
    }

    public void Versamento(decimal importo)
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

    public void Prelevamento(decimal importo)
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

    public void Banca()
    {
        CalcoloArray calcoloarray = new CalcoloArray();
        decimal versamentoIniziale;

        Console.WriteLine("Apertura in corso....");
        Console.Write("Fai un versamento per aprire il conto(min 1000): ");
        while (!decimal.TryParse(Console.ReadLine(), out versamentoIniziale))
        {
            Console.Write("Importo non valido. Rifai il versamento iniziale: ");
        }

        ApriConto(versamentoIniziale);
        

        int scelta = 0;
        decimal importo;

        while (statoConto && scelta != 5)
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
                    while (!decimal.TryParse(Console.ReadLine(), out importo) || importo <= 0)
                    {
                        Console.Write("Importo non valido. Inserisci nuovamente l'importo del versamento: ");
                    }
                    Versamento(importo);
                    break;

                case 2:
                    Console.Write("Inserisci l'importo del prelievo: ");
                    while (!decimal.TryParse(Console.ReadLine(), out importo) || importo <= 0)
                    {
                        Console.Write("Importo non valido. Inserisci nuovamente l'importo del prelievo: ");
                    }
                    Prelevamento(importo);
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
