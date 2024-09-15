namespace LibraryChallenge.Communication.Request;

public class RequestRegisterBookJSON
{
    public required string title { get; set; }
    public string? author { get; set; } = string.Empty;
    public string? gender { get; set; } = string.Empty;
    public required double price { get; set; }
    public required int stock { get; set; }
}
