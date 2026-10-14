using Homework22;

Storage<int> ints = new Storage<int>();
ints.Add(10);
ints.Add(20);
Console.WriteLine(ints.GetByIndex(1));

Storage<string> strings = new Storage<string>();
strings.Add("привет");
strings.Add("мир");
foreach (string s in strings.GetAll())
{
    Console.WriteLine(s);
}
Storage<Book> books = new Storage<Book>();
books.Add(new Book(1, "Джамиля", "Айтматов"));
books.Add(new Book(2, "Мастер и Маргарита", "Булгаков"));
books.Add(new Book(3, "Война и мир", "Толстой"));
books.Add(new Book(4, "Преступление и наказание", "Достоевский"));
books.Add(new Book(5, "Анна Каренина", "Толстой"));

foreach (Book b in books.GetAll())
{
    Console.WriteLine(b.Id + ": " + b.Title + " - " + b.Author);
}