namespace MethodsExercise;

public class Program
{

    static void Main(string[] args)
    {
        Console.WriteLine("What is your name?");
        string name = Console.ReadLine();
        Console.WriteLine("What is your quest?");
        string quest = Console.ReadLine();
        Console.WriteLine("What is your favorite color?");
        string color = Console.ReadLine();
        Console.WriteLine("What is the airspeed volocity of an unladen swallow?");
        string velocity = Console.ReadLine();
        Console.WriteLine($"Hello {name}");
        Console.WriteLine($"Your quest is {quest}");
        Console.WriteLine($"Your favoirite color is {color}");
        Console.WriteLine($"Your guess is, {velocity}");

        Console.WriteLine(Methods.Add(5, 8));
        Console.WriteLine(Methods.Multiply(5, 8));
    }
    

   
    
}
