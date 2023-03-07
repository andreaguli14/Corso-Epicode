class Program
{
    static void Main(string[] args)
    {
       
        List<Persona> persone = new List<Persona>();
        persone.Add(new Persona("Mario","Rossi",45));
        persone.Add(new Persona("Andrea", "Gulisano", 18));
        persone.Add(new Persona("Rosario", "Bianchi", 32));


        Console.WriteLine("Persone:\n------------");
        foreach (Persona Persona in persone)
        {
            Console.WriteLine(Persona.GetNome());
            Console.WriteLine(Persona.GetCognome());
            Console.WriteLine(Persona.GetEta());
            Console.WriteLine(Persona.GetDettagli());
            Console.WriteLine("------------");

        }
    }
}

class Persona
{
    string nome { get; }
    string cognome { get; }
    int eta { get; }

    public Persona(string nome, string cognome, int eta)
    {
        this.nome = nome;
        this.cognome = cognome;
        this.eta = eta;
    }
    public string GetNome()
    {
        return this.nome;
    }

    public string GetCognome()
    {
        return this.cognome;
    }
    public int GetEta()
    {
        return this.eta;
    }

    public string GetDettagli()
    {
        return $"Dettagli completi:\nNome:{this.nome}\nCognome:{this.cognome}\nEta`:{this.eta}";
    }

}