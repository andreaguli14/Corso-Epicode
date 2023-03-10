using System;

class Program {
    static void Main(string[] args)
    {
        List<string> gruppo = new List<string>();
        gruppo.Add("franco");
        gruppo.Add("armando");
        gruppo.Add("saro");
        gruppo.Add("andrea");

        var test = new Test<string>();

        gruppo = test.Shuffle(gruppo);
        
        foreach (var persona in gruppo) {

            Console.WriteLine(persona);
        }
    }
}

public class Test<T>
{
    private Random random;

    public Test()
    {
        random = new Random();
    }

    public List<T> Shuffle(List<T> list)
    {
      return list.OrderBy(x => random.Next()).ToList();
    }
}