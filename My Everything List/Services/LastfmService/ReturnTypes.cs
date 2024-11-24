namespace My_Everything_List.Services.LastfmService;


// NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
/// <remarks/>
[Serializable()]
[System.ComponentModel.DesignerCategory("code")]
[System.Xml.Serialization.XmlType(AnonymousType = true)]
[System.Xml.Serialization.XmlRoot(Namespace = "", IsNullable = false)]
public partial class ArtistsSearchResults
{

    private Query queryField;

    private ushort totalResultsField;

    private byte startIndexField;

    private byte itemsPerPageField;

    private resultsArtistmatches artistmatchesField;

    private string forField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Namespace = "http://a9.com/-/spec/opensearch/1.1/")]
    public Query Query
    {
        get
        {
            return this.queryField;
        }
        set
        {
            this.queryField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Namespace = "http://a9.com/-/spec/opensearch/1.1/")]
    public ushort totalResults
    {
        get
        {
            return this.totalResultsField;
        }
        set
        {
            this.totalResultsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Namespace = "http://a9.com/-/spec/opensearch/1.1/")]
    public byte startIndex
    {
        get
        {
            return this.startIndexField;
        }
        set
        {
            this.startIndexField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Namespace = "http://a9.com/-/spec/opensearch/1.1/")]
    public byte itemsPerPage
    {
        get
        {
            return this.itemsPerPageField;
        }
        set
        {
            this.itemsPerPageField = value;
        }
    }

    /// <remarks/>
    public resultsArtistmatches artistmatches
    {
        get
        {
            return this.artistmatchesField;
        }
        set
        {
            this.artistmatchesField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttribute()]
    public string @for
    {
        get
        {
            return this.forField;
        }
        set
        {
            this.forField = value;
        }
    }
}

/// <remarks/>
[Serializable()]
[System.ComponentModel.DesignerCategory("code")]
[System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://a9.com/-/spec/opensearch/1.1/")]
[System.Xml.Serialization.XmlRoot(Namespace = "http://a9.com/-/spec/opensearch/1.1/", IsNullable = false)]
public partial class Query
{

    private string roleField;

    private string searchTermsField;

    private byte startPageField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttribute()]
    public string role
    {
        get
        {
            return this.roleField;
        }
        set
        {
            this.roleField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttribute()]
    public string searchTerms
    {
        get
        {
            return this.searchTermsField;
        }
        set
        {
            this.searchTermsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttribute()]
    public byte startPage
    {
        get
        {
            return this.startPageField;
        }
        set
        {
            this.startPageField = value;
        }
    }
}

/// <remarks/>
[Serializable()]
[System.ComponentModel.DesignerCategory("code")]
[System.Xml.Serialization.XmlType(AnonymousType = true)]
public partial class resultsArtistmatches
{

    private resultsArtistmatchesArtist artistField;

    private string[] textField;

    /// <remarks/>
    public resultsArtistmatchesArtist artist
    {
        get
        {
            return this.artistField;
        }
        set
        {
            this.artistField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlText()]
    public string[] Text
    {
        get
        {
            return this.textField;
        }
        set
        {
            this.textField = value;
        }
    }
}

/// <remarks/>
[Serializable()]
[System.ComponentModel.DesignerCategory("code")]
[System.Xml.Serialization.XmlType(AnonymousType = true)]
public partial class resultsArtistmatchesArtist
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
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <remarks/>
    public string mbid
    {
        get
        {
            return this.mbidField;
        }
        set
        {
            this.mbidField = value;
        }
    }

    /// <remarks/>
    public string url
    {
        get
        {
            return this.urlField;
        }
        set
        {
            this.urlField = value;
        }
    }

    /// <remarks/>
    public string image_small
    {
        get
        {
            return this.image_smallField;
        }
        set
        {
            this.image_smallField = value;
        }
    }

    /// <remarks/>
    public string image
    {
        get
        {
            return this.imageField;
        }
        set
        {
            this.imageField = value;
        }
    }

    /// <remarks/>
    public byte streamable
    {
        get
        {
            return this.streamableField;
        }
        set
        {
            this.streamableField = value;
        }
    }
}



