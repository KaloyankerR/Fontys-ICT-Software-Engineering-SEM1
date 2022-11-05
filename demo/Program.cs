using System.Linq;

static bool CheckCondition(string name , string age)
{
    if (age.All(char.IsDigit)) {
        return true;
    } else {
        return false;
    }
}

List<string> names = new List<string>();
List<int> ages = new List<int>();

string userName, userAge;
Console.Write("Enter your name: ");
userName = Console.ReadLine();
Console.Write("Enter your age: ");
userAge = Console.ReadLine();

while (CheckCondition(userName, userAge))
{
    names.Add(userName);
    ages.Add(int.Parse(userAge));

    Console.Write("Enter your name: ");
    userName = Console.ReadLine();
    Console.Write("Enter your age: ");
    userAge = Console.ReadLine();
}

Console.WriteLine("Elements in the list: " + names.Count + " " + ages.Count);
