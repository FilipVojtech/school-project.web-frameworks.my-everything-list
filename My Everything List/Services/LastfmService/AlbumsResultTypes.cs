using System.ComponentModel;
using System.Xml.Serialization;

namespace My_Everything_List.Services.LastfmService;

/// <remarks/>
[Serializable]
[DesignerCategory("code")]
[XmlType(AnonymousType = true)]
[XmlRoot(Namespace = "", IsNullable = false)]
public class AlbumsSearchResults
{
    private AlbumQuery queryField;

    private ushort totalResultsField;

    private byte startIndexField;

    private byte itemsPerPageField;

    private resultsAlbummatches albummatchesField;

    private string forField;

    /// <remarks/>
    [XmlElement(Namespace = "http://a9.com/-/spec/opensearch/1.1/")]
    public AlbumQuery QueryField
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
    public resultsAlbummatches albummatches
    {
        get => albummatchesField;
        set => albummatchesField = value;
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
public class AlbumQuery
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
public class resultsAlbummatches
{
    private resultsAlbummatchesAlbum albumField;

    private string[] textField;

    /// <remarks/>
    public resultsAlbummatchesAlbum album
    {
        get => albumField;
        set => albumField = value;
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
public class resultsAlbummatchesAlbum
{
    private string nameField;

    private string artistField;

    private uint idField;

    private string urlField;

    private resultsAlbummatchesAlbumImage[] imageField;

    private byte streamableField;

    /// <remarks/>
    public string name
    {
        get => nameField;
        set => nameField = value;
    }

    /// <remarks/>
    public string artist
    {
        get => artistField;
        set => artistField = value;
    }

    /// <remarks/>
    public uint id
    {
        get => idField;
        set => idField = value;
    }

    /// <remarks/>
    public string url
    {
        get => urlField;
        set => urlField = value;
    }

    /// <remarks/>
    [XmlElement("image")]
    public resultsAlbummatchesAlbumImage[] image
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

/// <remarks/>
[Serializable]
[DesignerCategory("code")]
[XmlType(AnonymousType = true)]
public class resultsAlbummatchesAlbumImage
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
