namespace OOP3;

	public class CalcoloArray
	{
		public void sommaMedia()
		{
            Console.Write("Quanti numeri vupi inserire? : ");
            int n = int.Parse(Console.ReadLine());

            int[] numeri = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Inserisci il numero {i + 1}: ");
                numeri[i] = int.Parse(Console.ReadLine());
            }

            int somma = 0;
            for (int i = 0; i < n; i++)
            {
                somma += numeri[i];
            }

            double media = (double)somma / n;

            Console.WriteLine($"La somma dei numeri inseriti è: {somma} ");
            Console.WriteLine($"La media dei numeri inseriti è: {media} ");

        }
        public void cercaNome()
        {
            Console.Write("Quanti nomi vuoi inserire? : ");
            int x = int.Parse(Console.ReadLine());

            string[] nomi = new string[x];

            for (int i = 0; i < x; i++)
            {
                Console.Write($"Inserisci il nome {i + 1}: ");
                nomi[i] = Console.ReadLine();
            }

            Console.Write("Inserisci il nome da cercare: ");
            string nomeCercato = Console.ReadLine();

            bool trovato = false;
            int posizione = 0;
            for (int i = 0; i < x; i++)
            {
                if (nomi[i] == nomeCercato)
                {
                    trovato = true;
                    posizione = i + 1;
                    break;
                }
            }

            if (trovato)
            {
                Console.WriteLine($"Il nome {nomeCercato} è presente nell'array nella posizione {posizione} ");
            }
            else
            {
                Console.WriteLine($"Il nome {nomeCercato} non è presente nell'array ");
            }

    }
}

