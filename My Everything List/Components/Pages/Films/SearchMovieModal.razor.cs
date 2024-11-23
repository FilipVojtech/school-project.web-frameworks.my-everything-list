using BlazorBootstrap;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using My_Everything_List.Services.TmdbService;

namespace My_Everything_List.Components.Pages.Films;

public partial class SearchMovieModal
{
    [Inject] private ITmdbService TmdbService { get; set; } = default!;

    [Parameter] public required string ButtonTitle { get; set; }
    [Parameter] public required EventHandler<Film> OnItemSelected { get; set; }
    private string? Query { get; set; } = string.Empty;
    private Modal _modal = default!;
    private bool _searching = false;
    private FilmSearchResult? _films = null;
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
            _films = null;
            _searching = true;

            // Wait for 1250 ms before searching
            await Task.Delay(1250, ct);

            _films = await TmdbService.SearchFilm(Query);
            _searching = false;
        }, ct);
    }

    private void OnFilmClick(MouseEventArgs args, Film film)
    {
        OnItemSelected(null, film);
        Query = string.Empty;
        _films = null;
        _modal.HideAsync();
    }
}
