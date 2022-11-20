using System.Collections;
using System.Xml.Linq;

class MyClass
{
    static void Main()
    {
        Console.Write("Please input the amount of persons:");
        int peopleAmount = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(new string('-', 30));
        string[,] people = new string[peopleAmount, 2]; 

        for (int i = 0; i < peopleAmount; i ++)
        {
            Console.Write($"Please input the name for person {i + 1}:");
            string name = Console.ReadLine();

            Console.Write($"Please input the age for person {i + 1}:");
            string age = Console.ReadLine();
            
            people[i, 0] = name;
            people[i, 1] = age;
            
        }

        Console.WriteLine(new string('-', 30));
        Console.WriteLine("You've inputted the following data:");

        for (int j = 0; j < peopleAmount; j++)
        {
            Console.WriteLine($"{people[j, 0]} ({people[j, 1]} year(s) old)");
        }

    }

    /*
    static string[] GetInput(int count)
    {
        Console.Write($"Please input the name for person {count}:");
        string name = Console.ReadLine();

        Console.Write($"Please input the age for person {count}:");
        string age = Console.ReadLine();

        string[] result = { name, age };

        return result;
    }

    static void Main()
    {
        Console.Write("Please input the amount of persons:");
        int peopleAmount = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("---------------------------");

        List<string> people = new List<string>();
        // var people = new ArrayList();

        for (int i = 1; i <= peopleAmount; i++)
        {
            people.AddRange(GetInput(count: i));
        }

        Console.WriteLine("You've inputted the following data:");
        for (int j = 0; j < people.Count; j++)
        {
            string name = people[j];
            string age = people[j][1];

            Console.WriteLine($"{name} ({age} year(s) old)");
            
        }
    }
    */

}