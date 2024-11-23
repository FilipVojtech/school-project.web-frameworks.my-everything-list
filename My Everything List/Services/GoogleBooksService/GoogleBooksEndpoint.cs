namespace My_Everything_List.Services.GoogleBooksService;

public static class GoogleBooksEndpoint
{
    private const string RequestBasePath = "books/v1";

    public const string SearchBook = $"{RequestBasePath}/volumes";

    public static string GetBook(string volumeId) => $"{RequestBasePath}/volumes/{volumeId}";
}
