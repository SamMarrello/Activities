namespace Backend.Domain;

public class Activity
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTimeOffset Date { get; set; }
    public string Catagory { get; set; }
    public string City { get; set; }
    public string? Venue { get; set; }
}