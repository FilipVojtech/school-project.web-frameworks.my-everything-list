using My_Everything_List.Models;

namespace My_Everything_List.Services.LastfmService;

public interface ILastfmService
{
    Task<ArtistsSearchResults?> SearchArtists(string artist);
    Task<LfmArtist?> GetArtist(Artist artist);

    /// <summary>
    /// Get currently top artists
    /// </summary>
    /// <returns>List of artists</returns>
    Task<object> GetTopArtists();

    Task<AlbumsSearchResults?> SearchAlbums(string album);
    Task<LfmAlbum?> GetAlbum(Album album);
    Task<TracksSearchResults?> SearchSongs(string song);
    Task<LfmTrack?> GetSong(Song song);

    /// <summary>
    /// Get currently top tracks
    /// </summary>
    /// <returns>List of top tracks</returns>
    Task<object> GetTopTracks();
}
