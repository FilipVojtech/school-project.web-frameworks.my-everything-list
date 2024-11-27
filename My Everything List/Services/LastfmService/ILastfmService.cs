namespace My_Everything_List.Services.LastfmService;

public interface ILastfmService
{
    Task<ArtistsSearchResults?> SearchArtists(string artist);
    Task<AlbumsSearchResults?> SearchAlbums(string album);
    Task<SongsSearchResults?> SearchSongs(string song);
}
