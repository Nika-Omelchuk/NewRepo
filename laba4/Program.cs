using System;
using System.Collections.Generic;
using System.Linq;

class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Year { get; set; }
    public int Pages { get; set; }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("ПIБ: Омельчук Нiка Романiвна");
        Console.WriteLine("Група: 42 ІПЗ");

        List<Book> books = new List<Book>
        {
            new Book { Title = "Кобзар", Author = "Шевченко", Year = 1840, Pages = 200 },
            new Book { Title = "Лiсова пiсня", Author = "Леся Українка", Year = 1911, Pages = 120 },
            new Book { Title = "Тигролови", Author = "Iван Багряний", Year = 1944, Pages = 320 },
            new Book { Title = "Сто рокiв самотностi", Author = "Маркес", Year = 1967, Pages = 416 },
            new Book { Title = "Майстер i Маргарита", Author = "Булгаков", Year = 1940, Pages = 480 }
        };

        // Методи вибірки даних
        var thickBooks = books.Where(b => b.Pages > 300);
        var shortTitles = books.Select(b => b.Title);
        var authors = books.Select(b => b.Author).Distinct();

        // Методи зміни порядку
        var sortedByPages = books.OrderBy(b => b.Pages);
        var sortedByYearDesc = books.OrderByDescending(b => b.Year);
        var thenSorted = books.OrderBy(b => b.Author).ThenBy(b => b.Title);

        // Агрегація
        var averagePages = books.Average(b => b.Pages);
        var maxPages = books.Max(b => b.Pages);

        // Управління запитом – пропустити перші 2
        var skipped = books.Skip(2);

        Console.WriteLine("\nКниги з кiлькiстю сторiнок > 300:");
        foreach (var book in thickBooks) Console.WriteLine(book.Title);

        Console.WriteLine("\nСередня кiлькiсть сторiнок: " + averagePages);
        Console.WriteLine("Найбiльша кiлькiсть сторiнок: " + maxPages);
    }
}

