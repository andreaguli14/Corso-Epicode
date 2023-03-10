using System;

class Program {
    static void Main(string[] args)
    {
        List<string> gruppo = new List<string>();
        Console.WriteLine("Quante Persone siete?");
        int n = int.Parse(Console.ReadLine());
        for(int i=1; i<=n; i++) {
            Console.WriteLine($"Insersci persona {i}:");
            string persona = Console.ReadLine();
            gruppo.Add(persona);
        }
        Randomizzatore<string> test = new Randomizzatore<string>();

        gruppo = test.Shuffle(gruppo);
        Console.WriteLine("=======ORDINE CASUALE========");
        foreach (var persona in gruppo) {

            Console.WriteLine(persona);
        }
    }
}

public class Randomizzatore<T>
{
    private Random n;

    public Randomizzatore()
    {
        n = new Random();
    }

    public List<T> Shuffle(List<T> list)
    {
      return list.OrderBy(x => n.Next()).ToList();
    }
}