using System;
using System.Linq;

public class Company
{
    public string Name { get; set; }
    public DateTime FoundedDate { get; set; }
    public string BusinessProfile { get; set; }
    public string CEO { get; set; }
    public int NumberOfEmployees { get; set; }
    public string Address { get; set; }
}

class Program
{
    static void Main()
    {
        Company[] companies = new Company[]
        {
            new Company { Name = "FoodMart", FoundedDate = new DateTime(2000, 5, 10), BusinessProfile = "Food", CEO = "John Smith", NumberOfEmployees = 150, Address = "123 Main St, London" },
            new Company { Name = "Tech Solutions", FoundedDate = new DateTime(2010, 12, 3), BusinessProfile = "IT", CEO = "Emily Johnson", NumberOfEmployees = 200, Address = "456 Elm St, New York" },
            new Company { Name = "MarketingPro", FoundedDate = new DateTime(2005, 8, 20), BusinessProfile = "Marketing", CEO = "Michael Brown", NumberOfEmployees = 80, Address = "789 Oak St, Paris" },
            new Company { Name = "White & Black Consulting", FoundedDate = new DateTime(2018, 6, 15), BusinessProfile = "Consulting", CEO = "Sarah White", NumberOfEmployees = 300, Address = "321 Maple St, London" }
        };
        //Отримати інформацію про всі фірми.
        var allCompanies = companies;
        //Отримати фірми, які мають у назві слово «Food».
        var foodCompanies = companies.Where(c => c.Name.Contains("Food"));
        //Отримати фірми, які працюють у галузі маркетингу.
        var marketingCompanies = companies.Where(c => c.BusinessProfile == "Marketing");
        //Отримати фірми, які працюють у галузі маркетингу або IT.
        var marketingOrITCompanies = companies.Where(c => c.BusinessProfile == "Marketing" || c.BusinessProfile == "IT");
        // Отримати фірми з кількістю працівників більшою, ніж 100.
        var companiesWithMoreThan100Employees = companies.Where(c => c.NumberOfEmployees > 100);
        //Отримати фірми з кількістю працівників у діапазоні від 100 до 300.
        var companiesWith100To300Employees = companies.Where(c => c.NumberOfEmployees >= 100 && c.NumberOfEmployees <= 300);
        //Отримати фірми, які знаходяться в Лондоні.
        var londonCompanies = companies.Where(c => c.Address.Contains("London"));
        // Отримати фірми, в яких прізвище директора White.
        var companiesWithDirectorLastNameWhite = companies.Where(c => c.CEO.Split(' ').Last() == "White");
        //Отримати фірми, які засновані більше двох років тому.
        var companiesFoundedMoreThan2YearsAgo = companies.Where(c => (DateTime.Now - c.FoundedDate).TotalDays > 365 * 2);
        //Отримати фірми з дня заснування яких минуло 123 дні
        var companiesFounded123DaysAgo = companies.Where(c => (DateTime.Now - c.FoundedDate).TotalDays == 123);
        //Отримати фірми, в яких прізвище директора Black і мають у назві фірми слово «White»
        var companiesWithDirectorLastNameBlackAndNameContainsWhite = companies.Where(c => c.CEO.Split(' ').Last() == "Black" && c.Name.Contains("White"));

        Console.WriteLine("All Companies:");
        foreach (var company in allCompanies)
        {
            Console.WriteLine(company.Name);
        }

        Console.WriteLine("\nFood Companies:");
        foreach (var company in foodCompanies)
        {
            Console.WriteLine(company.Name);
        }

        Console.WriteLine("\nMarketing Companies:");
        foreach (var company in marketingCompanies)
        {
            Console.WriteLine(company.Name);
        }

        Console.WriteLine("\nMarketing or IT Companies:");
        foreach (var company in marketingOrITCompanies)
        {
            Console.WriteLine(company.Name);
        }

        Console.WriteLine("\nCompanies with more than 100 employees:");
        foreach (var company in companiesWithMoreThan100Employees)
        {
            Console.WriteLine(company.Name);
        }

        Console.WriteLine("\nCompanies with 100 to 300 employees:");
        foreach (var company in companiesWith100To300Employees)
        {
            Console.WriteLine(company.Name);
        }

        Console.WriteLine("\nLondon Companies:");
        foreach (var company in londonCompanies)
        {
            Console.WriteLine(company.Name);
        }

        Console.WriteLine("\nCompanies with CEO's last name White:");
        foreach (var company in companiesWithDirectorLastNameWhite)
        {
            Console.WriteLine(company.Name);
        }

        Console.WriteLine("\nCompanies founded more than 2 years ago:");
        foreach (var company in companiesFoundedMoreThan2YearsAgo)
        {
            Console.WriteLine(company.Name);
        }

        Console.WriteLine("\nCompanies founded 123 days ago:");
        foreach (var company in companiesFounded123DaysAgo)
        {
            Console.WriteLine(company.Name);
        }

        Console.WriteLine("\nCompanies with CEO's last name Black and name contains White:");
        foreach (var company in companiesWithDirectorLastNameBlackAndNameContainsWhite)
        {
            Console.WriteLine(company.Name);
        }
    }
}
