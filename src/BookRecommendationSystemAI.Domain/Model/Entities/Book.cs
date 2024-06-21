namespace BookRecommendationSystemAI.Domain.Model.Entities;

public class Book
{
    public Ulid Id { get; private set; }
    public string Name { get; private set; }
    public string Author { get; private set; }
    public DateOnly PublicationYear { get; private set; }
    
    public Book(Ulid id, string name, string author, DateOnly publicationYear)
    {
        Id = id;
        Name = name;
        Author = author;
        PublicationYear = publicationYear;
    }
}