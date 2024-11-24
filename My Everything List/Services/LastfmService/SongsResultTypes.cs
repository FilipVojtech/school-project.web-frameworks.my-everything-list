namespace My_Everything_List.Services.LastfmService;


// NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
public partial class SongsSearchResults
{

    private SongQuery queryField;

    private ushort totalResultsField;

    private byte startIndexField;

    private byte itemsPerPageField;

    private resultsTrackmatches trackmatchesField;

    private string forField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://a9.com/-/spec/opensearch/1.1/")]
    public SongQuery Query
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
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://a9.com/-/spec/opensearch/1.1/")]
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
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://a9.com/-/spec/opensearch/1.1/")]
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
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://a9.com/-/spec/opensearch/1.1/")]
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
    public resultsTrackmatches trackmatches
    {
        get
        {
            return this.trackmatchesField;
        }
        set
        {
            this.trackmatchesField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
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
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://a9.com/-/spec/opensearch/1.1/")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://a9.com/-/spec/opensearch/1.1/", IsNullable = false)]
public partial class SongQuery
{

    private string roleField;

    private string searchTermsField;

    private byte startPageField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
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
    [System.Xml.Serialization.XmlAttributeAttribute()]
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
    [System.Xml.Serialization.XmlAttributeAttribute()]
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
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class resultsTrackmatches
{

    private resultsTrackmatchesTrack trackField;

    private string[] textField;

    /// <remarks/>
    public resultsTrackmatchesTrack track
    {
        get
        {
            return this.trackField;
        }
        set
        {
            this.trackField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
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
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class resultsTrackmatchesTrack
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
    public string artist
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
    public resultsTrackmatchesTrackStreamable streamable
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

    /// <remarks/>
    public uint listeners
    {
        get
        {
            return this.listenersField;
        }
        set
        {
            this.listenersField = value;
        }
    }

    /// <remarks/>
    public resultsTrackmatchesTrackImage image
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
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class resultsTrackmatchesTrackStreamable
{

    private byte fulltrackField;

    private byte valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte fulltrack
    {
        get
        {
            return this.fulltrackField;
        }
        set
        {
            this.fulltrackField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public byte Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class resultsTrackmatchesTrackImage
{

    private string sizeField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string size
    {
        get
        {
            return this.sizeField;
        }
        set
        {
            this.sizeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}


