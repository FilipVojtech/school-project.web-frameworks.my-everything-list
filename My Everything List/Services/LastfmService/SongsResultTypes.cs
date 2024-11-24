using System.ComponentModel;
using System.Xml.Serialization;

namespace My_Everything_List.Services.LastfmService;

/// <remarks/>
[Serializable]
[DesignerCategory("code")]
[XmlType(AnonymousType = true)]
[XmlRoot(Namespace = "", IsNullable = false)]
public class SongsSearchResults
{
    private SongQuery queryField;

    private ushort totalResultsField;

    private byte startIndexField;

    private byte itemsPerPageField;

    private resultsTrackmatches trackmatchesField;

    private string forField;

    /// <remarks/>
    [XmlElement(Namespace = "http://a9.com/-/spec/opensearch/1.1/")]
    public SongQuery Query
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
    public resultsTrackmatches trackmatches
    {
        get => trackmatchesField;
        set => trackmatchesField = value;
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
public class SongQuery
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
public class resultsTrackmatches
{
    private resultsTrackmatchesTrack trackField;

    private string[] textField;

    /// <remarks/>
    public resultsTrackmatchesTrack track
    {
        get => trackField;
        set => trackField = value;
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
public class resultsTrackmatchesTrack
{
    private string nameField;

    private string artistField;

    private string urlField;

    private resultsTrackmatchesTrackStreamable streamableField;

    private uint listenersField;

    private resultsTrackmatchesTrackImage imageField;

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
    public resultsTrackmatchesTrackStreamable streamable
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
    public resultsTrackmatchesTrackImage image
    {
        get => imageField;
        set => imageField = value;
    }
}

/// <remarks/>
[Serializable]
[DesignerCategory("code")]
[XmlType(AnonymousType = true)]
public class resultsTrackmatchesTrackStreamable
{
    private byte fulltrackField;

    private byte valueField;

    /// <remarks/>
    [XmlAttribute]
    public byte fulltrack
    {
        get => fulltrackField;
        set => fulltrackField = value;
    }

    /// <remarks/>
    [XmlText]
    public byte Value
    {
        get => valueField;
        set => valueField = value;
    }
}

/// <remarks/>
[Serializable]
[DesignerCategory("code")]
[XmlType(AnonymousType = true)]
public class resultsTrackmatchesTrackImage
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
