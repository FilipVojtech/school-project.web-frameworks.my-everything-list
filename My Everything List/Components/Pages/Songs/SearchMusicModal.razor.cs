using BlazorBootstrap;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using My_Everything_List.Models;
using My_Everything_List.Services.LastfmService;

namespace My_Everything_List.Components.Pages.Songs;

public partial class SearchMusicModal
{
    [Inject] private ILastfmService LastFmService { get; set; } = default!;

    [Parameter] public required string ButtonTitle { get; set; }
    [Parameter] public required EventHandler<MusicItem> OnItemSelected { get; set; }

    private string? Query { get; set; } = string.Empty;
    private Modal _modal = default!;
    private Tabs _tabs = default!;
    private bool _searching = false;
    private ArtistsSearchResults? _artists = null;
    private AlbumsSearchResults? _albums = null;
    private SongsSearchResults? _songs = null;
    private Task _searchTimeout = Task.CompletedTask;
    private CancellationTokenSource _tokenSource = new();

    private async Task ShowModal()
    {
        await _modal.ShowAsync();
    }

    private async Task OnInputHandler(string? query)
    {
        Query = query;
        _tokenSource.Cancel();
        _tokenSource.Dispose();
        _tokenSource = new CancellationTokenSource();
        var ct = _tokenSource.Token;
        if (string.IsNullOrWhiteSpace(Query))
        {
            _searching = false;
            return;
        }

        await Task.Run(async () =>
        {
            ct.ThrowIfCancellationRequested();

            _searching = true;

            _artists = null;
            _albums = null;
            _songs = null;
            await Task.Delay(1250, ct);
            _artists = await LastFmService.SearchArtists(Query);
            _albums = await LastFmService.SearchAlbums(Query);
            _songs = await LastFmService.SearchSongs(Query);

            _searching = false;
        }, ct);
    }

    private void OnSongClick(MouseEventArgs? args, Models.Song song)
    {
        OnItemSelected(null, song);
        Query = string.Empty;
        _songs = null;
        _albums = null;
        _artists = null;
        _modal.HideAsync();
    }

    private void OnAlbumClick(MouseEventArgs? args, Album album)
    {
        OnItemSelected(null, album);
        Query = string.Empty;
        _songs = null;
        _albums = null;
        _artists = null;
        _modal.HideAsync();
    }

    private void OnArtistClick(MouseEventArgs? args, Artist artist)
    {
        OnItemSelected(null, artist);
        Query = string.Empty;
        _songs = null;
        _albums = null;
        _artists = null;
        _modal.HideAsync();
    }
}
