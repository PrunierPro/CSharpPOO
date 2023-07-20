namespace Exercice6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client("Mairesse", "Guillaume", "FR00 1234 5678 9123 4567 8912 345");
            Console.WriteLine(client);
            Console.WriteLine("--------------------");
            var compte = new CheckingAccount(client);
            client.AddAccount(compte);
            client.AddAccount(new SavingsAccount(client, 0.5));
            client.AddAccount(new PayingAccount(client));
            Console.WriteLine("Comptes du client :");
            foreach (BankAccount compteBancaire in client.Accounts)
                Console.WriteLine(compteBancaire);
            Console.WriteLine("--------------------");
            Console.WriteLine("Opération sur le premier compte :");
            Console.WriteLine("Dépot de 2000");
            compte.AddMoney(2000);
            Console.WriteLine(compte);
            Console.WriteLine("--------------------");
            Console.WriteLine("Retrait de 90000?");
            bool reussite = compte.RetrieveMoney(90000);
            Console.WriteLine("Réussi ? " + reussite);
            Console.WriteLine(compte);
            Console.WriteLine("--------------------");
            Console.WriteLine("Retrait de 500");
            compte.RetrieveMoney(500);
            Console.WriteLine(compte);
        }
    }
}