namespace My_Everything_List.Services.TmdbService;

public class FilmSearchResult
{
    public int page { get; set; }
    public Film[] results { get; set; }
    public int total_pages { get; set; }
    public int total_results { get; set; }
}

public class Film
{
    public bool adult { get; set; }
    public string backdrop_path { get; set; }
    public FilmCollection belongs_to_collection { get; set; }
    public int budget { get; set; }
    public Genre[] genres { get; set; }
    public string homepage { get; set; }
    public int id { get; set; }
    public string imdb_id { get; set; }
    public string[] origin_country { get; set; }
    public string original_language { get; set; }
    public string original_title { get; set; }
    public string overview { get; set; }
    public double popularity { get; set; }
    public string poster_path { get; set; }
    public ProductionCompany[] production_companies { get; set; }
    public ProductionCountry[] production_countries { get; set; }
    public string release_date { get; set; }
    public int revenue { get; set; }
    public int runtime { get; set; }
    public Spokenlanguage[] spoken_languages { get; set; }
    public string status { get; set; }
    public string tagline { get; set; }
    public string title { get; set; }
    public bool video { get; set; }
    public double vote_average { get; set; }
    public int vote_count { get; set; }
    public Credits? credits { get; set; }
}

public class FilmCollection
{
    public int id { get; set; }
    public string name { get; set; }
    public object poster_path { get; set; }
    public object backdrop_path { get; set; }
}

public class Genre
{
    public int id { get; set; }
    public string name { get; set; }
}

public class ProductionCompany
{
    public int id { get; set; }
    public object logo_path { get; set; }
    public string name { get; set; }
    public string origin_country { get; set; }
}

public class ProductionCountry
{
    public string iso_3166_1 { get; set; }
    public string name { get; set; }
}

public class Spokenlanguage
{
    public string english_name { get; set; }
    public string iso_639_1 { get; set; }
    public string name { get; set; }
}
public class Configuration
{
    public ImageSizes images { get; set; }
    public string[] change_keys { get; set; }
}

public class ImageSizes
{
    public string base_url { get; set; }
    public string secure_base_url { get; set; }
    public string[] backdrop_sizes { get; set; }
    public string[] logo_sizes { get; set; }
    public string[] poster_sizes { get; set; }
    public string[] profile_sizes { get; set; }
    public string[] still_sizes { get; set; }
}

public class Credits
{
    public Cast[] cast { get; set; }
    public Crew[] crew { get; set; }
}

public class Cast
{
    public bool adult { get; set; }
    public int gender { get; set; }
    public int id { get; set; }
    public string known_for_department { get; set; }
    public string name { get; set; }
    public string original_name { get; set; }
    public double popularity { get; set; }
    public string profile_path { get; set; }
    public int cast_id { get; set; }
    public string character { get; set; }
    public string credit_id { get; set; }
    public int order { get; set; }
}

public class Crew
{
    public bool adult { get; set; }
    public int gender { get; set; }
    public int id { get; set; }
    public string known_for_department { get; set; }
    public string name { get; set; }
    public string original_name { get; set; }
    public double popularity { get; set; }
    public string profile_path { get; set; }
    public string credit_id { get; set; }
    public string department { get; set; }
    public string job { get; set; }
}



