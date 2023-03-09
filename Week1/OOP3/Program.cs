class Program
{
    static void Main(string[] args)
    {

        Utente.Start();
    }
}

static class Utente
{
        private static string Username { get;  set; }
        private static bool UtenteLoggato { get;  set; }
        private static DateTime Accesso { get; set; }
        private static List<DateTime> Accessi = new List<DateTime>();

        private static void Login()
        {
            Console.Write("Inserisci username: ");
            string username = Console.ReadLine();
            Console.Write("Inserisci password: ");
            string password = Console.ReadLine();
            Console.Write("Conferma password: ");
            string confermaPassword = Console.ReadLine();

            if (string.IsNullOrEmpty(username) || password != confermaPassword)
            {
                Console.WriteLine("Errore: username o password non validi ");
            }
            else
            {
                Username = username;
                UtenteLoggato = true;
                Accesso = DateTime.Now;
                Accessi.Add(Accesso);
                Console.WriteLine("Login effettuato con successo ");
            }
        }

        private static void Logout()
        {
            if (!UtenteLoggato)
            {
                Console.WriteLine("Errore: nessun utente loggato ");
            }
            else
            {
                Username = null;
                UtenteLoggato = false;
                Console.WriteLine("Logout effettuato con successo ");
            }
        }

        private static void VerificaAccesso()
        {
            if (!UtenteLoggato)
            {
                Console.WriteLine("Errore: nessun utente loggato ");
            }
            else
            {
                Console.WriteLine($"L'utente {Username} ha effettuato il login in data {Accesso} ");
            }
        }

        private static void ListaAccessi()
        {
            if (!UtenteLoggato)
            {
                Console.WriteLine("Errore: nessun utente loggato ");
            }
            else
            {
                Console.WriteLine($"Storico accessi per l'utente {Username}: ");
                foreach (var accesso in Accessi)
                {
                    Console.WriteLine(accesso);
                }
            }
        }

        public static void Start()
        {
            int scelta = 0;
            do
            {
                Console.WriteLine("===============OPERAZIONI==============");
                Console.WriteLine("Scegli l'operazione da effettuare:");
                Console.WriteLine("1. Login");
                Console.WriteLine("2. Logout");
                Console.WriteLine("3. Verifica ora e data di login");
                Console.WriteLine("4. Lista degli accessi");
                Console.WriteLine("5. Esci");
                Console.WriteLine("========================================");

                if (int.TryParse(Console.ReadLine(), out scelta))
                {
                    switch (scelta)
                    {
                        case 1:
                            Utente.Login();
                            break;
                        case 2:
                            Utente.Logout();
                            break;
                        case 3:
                            Utente.VerificaAccesso();
                            break;
                        case 4:
                            Utente.ListaAccessi();
                            break;
                        case 5:
                            Console.WriteLine("Uscita dall'applicazione ");
                            break;
                        default:
                            Console.WriteLine("Scelta non valida" );
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Scelta non valida ");
                }

                Console.WriteLine();
            } while (scelta != 5);
        }
}

