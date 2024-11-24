using System.ComponentModel;
using System.Xml.Serialization;

namespace My_Everything_List.Services.LastfmService;

/// <remarks/>
[Serializable]
[DesignerCategory("code")]
[XmlType(AnonymousType = true)]
[XmlRoot(Namespace = "", IsNullable = false)]
public class ArtistsSearchResults
{
    private Query queryField;

    private ushort totalResultsField;

    private byte startIndexField;

    private byte itemsPerPageField;

    private resultsArtistmatches artistmatchesField;

    private string forField;

    /// <remarks/>
    [XmlElement(Namespace = "http://a9.com/-/spec/opensearch/1.1/")]
    public Query Query
    {
        get => queryField;
        set => queryField = value;
    }

    /// <remarks/>
    [XmlElement(Namespace = "http://a9.com/-/spec/opensearch/1.1/")]
    public ushort totalResults
    {
        get => totalResultsField;
        set => totalResultsField = value;
    }

    /// <remarks/>
    [XmlElement(Namespace = "http://a9.com/-/spec/opensearch/1.1/")]
    public byte startIndex
    {
        get => startIndexField;
        set => startIndexField = value;
    }

    /// <remarks/>
    [XmlElement(Namespace = "http://a9.com/-/spec/opensearch/1.1/")]
    public byte itemsPerPage
    {
        get => itemsPerPageField;
        set => itemsPerPageField = value;
    }

    /// <remarks/>
    public resultsArtistmatches artistmatches
    {
        get => artistmatchesField;
        set => artistmatchesField = value;
    }

    /// <remarks/>
    [XmlAttribute]
    public string @for
    {
        get => forField;
        set => forField = value;
    }
}

/// <remarks/>
[Serializable]
[DesignerCategory("code")]
[XmlType(AnonymousType = true, Namespace = "http://a9.com/-/spec/opensearch/1.1/")]
[XmlRoot(Namespace = "http://a9.com/-/spec/opensearch/1.1/", IsNullable = false)]
public class Query
{
    private string roleField;

    private string searchTermsField;

    private byte startPageField;

    /// <remarks/>
    [XmlAttribute]
    public string role
    {
        get => roleField;
        set => roleField = value;
    }

    /// <remarks/>
    [XmlAttribute]
    public string searchTerms
    {
        get => searchTermsField;
        set => searchTermsField = value;
    }

    /// <remarks/>
    [XmlAttribute]
    public byte startPage
    {
        get => startPageField;
        set => startPageField = value;
    }
}

/// <remarks/>
[Serializable]
[DesignerCategory("code")]
[XmlType(AnonymousType = true)]
public class resultsArtistmatches
{
    private resultsArtistmatchesArtist artistField;

    private string[] textField;

    /// <remarks/>
    public resultsArtistmatchesArtist artist
    {
        get => artistField;
        set => artistField = value;
    }

    /// <remarks/>
    [XmlText]
    public string[] Text
    {
        get => textField;
        set => textField = value;
    }
}

/// <remarks/>
[Serializable]
[DesignerCategory("code")]
[XmlType(AnonymousType = true)]
public class resultsArtistmatchesArtist
{
    private string nameField;

    private string mbidField;

    private string urlField;

    private string image_smallField;

    private string imageField;

    private byte streamableField;

    /// <remarks/>
    public string name
    {
        get => nameField;
        set => nameField = value;
    }

    /// <remarks/>
    public string mbid
    {
        get => mbidField;
        set => mbidField = value;
    }

    /// <remarks/>
    public string url
    {
        get => urlField;
        set => urlField = value;
    }

    /// <remarks/>
    public string image_small
    {
        get => image_smallField;
        set => image_smallField = value;
    }

    /// <remarks/>
    public string image
    {
        get => imageField;
        set => imageField = value;
    }

    /// <remarks/>
    public byte streamable
    {
        get => streamableField;
        set => streamableField = value;
    }
}
