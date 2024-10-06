namespace ConsoleApp1;

public struct Book(string name, int pagesCount, string authorName)
{
    public string Name { get; set; } = name;
    public int PagesCount { get; set; } = pagesCount;
    public string AuthorName { get; set; } = authorName;
}