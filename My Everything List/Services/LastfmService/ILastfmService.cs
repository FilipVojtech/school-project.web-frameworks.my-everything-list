using My_Everything_List.Models;

namespace My_Everything_List.Services.LastfmService;

public interface ILastfmService
{
    Task<ArtistsSearchResults?> SearchArtists(string artist);
    Task<lfmArtist?> GetArtist(Artist artist);
    Task<AlbumsSearchResults?> SearchAlbums(string album);
    Task<SongsSearchResults?> SearchSongs(string song);
}
