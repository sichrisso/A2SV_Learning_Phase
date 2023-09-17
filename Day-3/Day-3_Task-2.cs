using System;
using System.Collections.Generic;

class Library
{
    public string Name { get; set; }
    public string Address { get; set; }
    public List<Book> Books { get; set; }
    public List<MediaItem> MediaItems { get; set; }

    public Library(string name, string address)
    {
        Name = name;
        Address = address;
        Books = new List<Book>();
        MediaItems = new List<MediaItem>();
    }

    public void AddBook(Book book)
    {
        Books.Add(book);
        Console.WriteLine($"Added '{book.Title}' from the library's collection.");
    }

    public void RemoveBook(Book book)
    {
        if (Books.Contains(book))
        {
            Books.Remove(book);
            Console.WriteLine($"Removed '{book.Title}' from the library's collection.");
        }
        else
        {
            Console.WriteLine($"'{book.Title}' not found in the library's collection.");
        }
    }

    public void AddMediaItem(MediaItem item)
    {
        MediaItems.Add(item);
        Console.WriteLine($"Added '{item.Title}' ({item.MediaType}) to the library's collection.");
    }

    public void RemoveMediaItem(MediaItem item)
    {
        if (MediaItems.Contains(item))
        {
            MediaItems.Remove(item);
            Console.WriteLine($"Removed '{item.Title}' ({item.MediaType}) from the library's collection.");
        }
        else
        {
            Console.WriteLine($"'{item.Title}' not found in the library's collection.");
        }
    }

    public void PrintCatalog()
    {
        Console.WriteLine($"Library: {Name}");
        Console.WriteLine($"Address: {Address}\n");

        Console.WriteLine("Books:");
        foreach (var book in Books)
        {
            Console.WriteLine($"Title: {book.Title}");
            Console.WriteLine($"Author: {book.Author}");
            Console.WriteLine($"ISBN: {book.ISBN}");
            Console.WriteLine($"Publication Year: {book.PublicationYear}\n");
        }

        Console.WriteLine("Media Items:");
        foreach (var item in MediaItems)
        {
            Console.WriteLine($"Title: {item.Title}");
            Console.WriteLine($"Media Type: {item.MediaType}");
            Console.WriteLine($"Duration: {item.Duration} minutes\n");
        }
    }
}

class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string ISBN { get; set; }
    public int PublicationYear { get; set; }

    public Book(string title, string author, string isbn, int publicationYear)
    {
        Title = title;
        Author = author;
        ISBN = isbn;
        PublicationYear = publicationYear;
    }
}

class MediaItem
{
    public string Title { get; set; }
    public string MediaType { get; set; }
    public int Duration { get; set; }

    public MediaItem(string title, string mediaType, int duration)
    {
        Title = title;
        MediaType = mediaType;
        Duration = duration;
    }
}

class Program
{
    static void Main()
    {
        // Create a library
        Library library = new Library("My Library", "123 Main St");

        // Add books to the library
        library.AddBook(new Book("Book1", "Author1", "ISBN123", 2022));
        library.AddBook(new Book("Book2", "Author2", "ISBN456", 2019));

        // Add media items to the library
        library.AddMediaItem(new MediaItem("DVD1", "DVD", 120));
        library.AddMediaItem(new MediaItem("CD1", "CD", 60));

        // Print the library's catalog
        library.PrintCatalog();
    }
}
