namespace My_Everything_List.Services.LastfmService;

public interface ILastfmService
{
    Task<ArtistsSearchResults?> SearchArtists();
    Task<AlbumsSearchResults?> SearchAlbums();
    Task<SongsSearchResults?> SearchSongs();
}
