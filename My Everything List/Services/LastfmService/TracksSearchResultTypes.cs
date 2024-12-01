using System.ComponentModel;
using System.Xml.Serialization;

namespace My_Everything_List.Services.LastfmService;

/// <remarks/>
[Serializable]
[DesignerCategory("code")]
[XmlType(AnonymousType = true)]
[XmlRoot(Namespace = "", IsNullable = false, ElementName = "results")]
public class TracksSearchResults
{
    private SongQuery queryField;

    private uint totalResultsField;

    private byte startIndexField;

    private byte itemsPerPageField;

    private resultsTrack[] trackmatchesField;

    /// <remarks/>
    [XmlElement(Namespace = "http://a9.com/-/spec/opensearch/1.1/")]
    public SongQuery Query
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
    [XmlArrayItem("track", IsNullable = false)]
    public resultsTrack[] trackmatches
    {
        get => trackmatchesField;
        set => trackmatchesField = value;
    }
}

/// <remarks/>
[Serializable]
[DesignerCategory("code")]
[XmlType(AnonymousType = true, Namespace = "http://a9.com/-/spec/opensearch/1.1/")]
[XmlRoot(Namespace = "http://a9.com/-/spec/opensearch/1.1/", IsNullable = false)]
public class SongQuery
{
    private string roleField;

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
public class resultsTrack
{
    private string nameField;

    private string artistField;

    private string urlField;

    private string streamableField;

    private uint listenersField;

    private resultsTrackImage[] imageField;

    private string mbidField;

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
    public string url
    {
        get => urlField;
        set => urlField = value;
    }

    /// <remarks/>
    public string streamable
    {
        get => streamableField;
        set => streamableField = value;
    }

    /// <remarks/>
    public uint listeners
    {
        get => listenersField;
        set => listenersField = value;
    }

    /// <remarks/>
    [XmlElement("image")]
    public resultsTrackImage[] image
    {
        get => imageField;
        set => imageField = value;
    }

    /// <remarks/>
    public string mbid
    {
        get => mbidField;
        set => mbidField = value;
    }
}

/// <remarks/>
[Serializable]
[DesignerCategory("code")]
[XmlType(AnonymousType = true)]
public class resultsTrackImage
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
