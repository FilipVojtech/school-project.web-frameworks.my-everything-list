using System.ComponentModel;
using System.Xml.Serialization;

namespace My_Everything_List.Services.LastfmService;

/// <remarks/>
[Serializable]
[DesignerCategory("code")]
[XmlType(AnonymousType = true)]
[XmlRoot(Namespace = "", IsNullable = false, ElementName = "results")]
public class ArtistsSearchResults
{
    private ArtistQuery queryField;

    private uint totalResultsField;

    private byte startIndexField;

    private byte itemsPerPageField;

    private resultsArtist[] artistmatchesField;

    private string forField;

    /// <remarks/>
    [XmlElement(Namespace = "http://a9.com/-/spec/opensearch/1.1/")]
    public ArtistQuery Query
    {
        get => queryField;
        set => queryField = value;
    }

    /// <remarks/>
    [XmlElement(Namespace = "http://a9.com/-/spec/opensearch/1.1/")]
    public uint totalResults
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
    [XmlArrayItem("artist", IsNullable = false)]
    public resultsArtist[] artistmatches
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
public class ArtistQuery
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
public class resultsArtist
{
    private string nameField;

    private uint listenersField;

    private string mbidField;

    private string urlField;

    private byte streamableField;

    private resultsArtistImage[] imageField;

    /// <remarks/>
    public string name
    {
        get => nameField;
        set => nameField = value;
    }

    /// <remarks/>
    public uint listeners
    {
        get => listenersField;
        set => listenersField = value;
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
    public byte streamable
    {
        get => streamableField;
        set => streamableField = value;
    }

    /// <remarks/>
    [XmlElement("image")]
    public resultsArtistImage[] image
    {
        get => imageField;
        set => imageField = value;
    }
}

/// <remarks/>
[Serializable]
[DesignerCategory("code")]
[XmlType(AnonymousType = true)]
public class resultsArtistImage
{
    private string sizeField;

    private string valueField;

    /// <remarks/>
    [XmlAttribute]
    public string size
    {
        get => sizeField;
        set => sizeField = value;
    }

    /// <remarks/>
    [XmlText]
    public string Value
    {
        get => valueField;
        set => valueField = value;
    }
}
