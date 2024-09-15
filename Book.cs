namespace LibraryChallenge;

public class Book
{
    int id { get; set; }
    public required string title { get; set; }
    public required string author { get; set; }
    public required string gender { get; set; }
    public required double price { get; set; }
    public required int stock { get; set; }
}
