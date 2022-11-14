using BankAccountConsoleApp;

BankAccount client = new BankAccount("Kaloyan", "Kulov", 1232);
client.SetBalance(1000);
Console.WriteLine("\n" + client.Represent());

