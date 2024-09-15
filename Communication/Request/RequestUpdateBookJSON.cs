namespace LibraryChallenge.Communication.Request;

public class RequestUpdateBookJSON
{
    public string? title { get; set; } = string.Empty;
    public string? author { get; set; } = string.Empty;
    public string? gender { get; set; } = string.Empty;
    public double? price { get; set; } = 0;
    public int? stock { get; set; } = 0;
}
