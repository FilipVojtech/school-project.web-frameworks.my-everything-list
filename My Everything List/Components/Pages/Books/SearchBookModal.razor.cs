using BlazorBootstrap;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using My_Everything_List.Models;
using My_Everything_List.Services.GoogleBooksService;

namespace My_Everything_List.Components.Pages.Books;

public partial class SearchBookModal
{
    [Inject] private IGoogleBooksService BooksService { get; set; } = default!;

    [Parameter] public required string ButtonTitle { get; set; }
    [Parameter] public required EventHandler<Book> OnItemSelected { get; set; }
    private string? Query { get; set; } = string.Empty;
    private Modal _modal = default!;
    private bool _searching = false;
    private BookSearchResult? _books = null;
    private Task _searchTimeout = Task.CompletedTask;
    private CancellationTokenSource _tokenSource = new();

    private async Task ShowModal()
    {
        await _modal.ShowAsync();
    }

    /// <summary>
    /// Search for films with debounce to limit API usage
    /// </summary>
    /// <param name="query">Query from the search field</param>
    private async Task OnInputHandler(string? query)
    {
        // Set query
        Query = query;
        // Cancel and dispose of previous token sources (if any)
        _tokenSource.Cancel();
        _tokenSource.Dispose();
        // Create new token source
        _tokenSource = new CancellationTokenSource();
        var ct = _tokenSource.Token;
        // Check if search is possible
        if (string.IsNullOrWhiteSpace(Query))
        {
            _searching = false;
            return;
        }

        // Debounce logic
        await Task.Run(async () =>
        {
            ct.ThrowIfCancellationRequested();
            _books = null;
            _searching = true;

            // Wait for 1250 ms before searching
            await Task.Delay(1250, ct);

            _books = await BooksService.Search(Query);
            _searching = false;
        }, ct);
    }

    private void OnBookClick(MouseEventArgs args, Volume book)
    {
        var bookInfo = book.volumeInfo;
        OnItemSelected(null, new Book(book));
        Query = string.Empty;
        _books = null;
        _modal.HideAsync();
    }
}
