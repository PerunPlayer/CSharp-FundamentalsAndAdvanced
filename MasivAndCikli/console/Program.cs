using System;

class companyInfo
{
    static void Main()
    {
        string name = Console.ReadLine();
        string address = Console.ReadLine();
        string phone = Console.ReadLine();
        string fax = Console.ReadLine();
        string webSite = Console.ReadLine();
        string firstName = Console.ReadLine();
        string lastName = Console.ReadLine();
        int age = int.Parse(Console.ReadLine());
        string managerPhone = Console.ReadLine();

        if (fax.CompareTo(string.Empty) == 0)
        {
            fax = "(no fax)";
        }

        Console.WriteLine(name);
        Console.WriteLine("Address: {0}", address);
        Console.WriteLine("Tel. {0}", phone);
        Console.WriteLine("Fax: {0}", fax);
        Console.WriteLine("Web site: {0}", webSite);
        Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})", firstName, lastName, age, managerPhone);
    }
}
