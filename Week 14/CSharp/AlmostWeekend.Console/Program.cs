// See https://aka.ms/new-console-template for more information

using AlmostWeekend.Console;
using System.Text.Json;

var students = new List<Student>
{
    new Student
    {
        Name = "Zakaria",
        Number = 1234,
        Purpose = "Do something with Bi4es",
        Traits = new List<Trait>
        {
            new Trait
            {
                Description = "Smell like kebab",
                Title = "Smelly",
                IsImportant = true
            }
        }
    },
    new Student
    {
        Name = "Nikola",
        Purpose = "Eat, sleep, Eat, repeat",
        Number = 1,
        Traits = new List<Trait>
        {
            new Trait
            {
                Title = "Intelligent",
                Description = "Is smarter than teacher",
                IsImportant = false
            }
        }
    }
};

string? studentsJson = JsonSerializer.Serialize(students);
File.WriteAllText("best-students-ever.json", studentsJson);

Console.WriteLine(studentsJson);
Console.ReadLine();

var studentsJson2 = File.ReadAllText("best-students-ever.json");
List<Student>? students2 = JsonSerializer.Deserialize<List<Student>>(studentsJson2);
