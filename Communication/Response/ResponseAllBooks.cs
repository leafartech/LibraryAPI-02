namespace LibraryChallenge.Communication.Response;

public class ResponseAllBooks
{
    int id { get; set; }
    string title { get; set; } = string.Empty;
    string author {  get; set; } = string.Empty;
    string gender {  get; set; } = string.Empty;
    float price {  get; set; } = 0;
    int stock { get; set; } = 0;
}
