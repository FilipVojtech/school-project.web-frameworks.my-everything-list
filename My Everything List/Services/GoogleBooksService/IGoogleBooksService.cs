namespace My_Everything_List.Services.GoogleBooksService;

public interface IGoogleBooksService
{
    /// <summary>
    /// Get a book from Google Books
    /// </summary>
    /// <param name="id">ID of the book</param>
    /// <returns>Volume (Book in google speak) or null</returns>
    Task<Volume?> GetBook(string id);

    /// <summary>
    /// Search for books on Google Books
    /// </summary>
    /// <param name="query">The searched term</param>
    /// <returns>List of Volumes (Book in google speak)</returns>
    Task<BookSearchResult?> Search(string query);
}
