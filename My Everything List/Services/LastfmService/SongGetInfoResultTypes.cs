namespace My_Everything_List.Services.LastfmService;


// NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
public partial class lfm
{

    private lfmTrack trackField;

    private string statusField;

    /// <remarks/>
    public lfmTrack track
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
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string status
    {
        get
        {
            return this.statusField;
        }
        set
        {
            this.statusField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class lfmTrack
{

    private string nameField;

    private string urlField;

    private byte durationField;

    private lfmTrackStreamable streamableField;

    private uint listenersField;

    private uint playcountField;

    private lfmTrackArtist artistField;

    private lfmTrackTag[] toptagsField;

    private lfmTrackWiki wikiField;

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
    public byte duration
    {
        get
        {
            return this.durationField;
        }
        set
        {
            this.durationField = value;
        }
    }

    /// <remarks/>
    public lfmTrackStreamable streamable
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
    public uint playcount
    {
        get
        {
            return this.playcountField;
        }
        set
        {
            this.playcountField = value;
        }
    }

    /// <remarks/>
    public lfmTrackArtist artist
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
    [System.Xml.Serialization.XmlArrayItemAttribute("tag", IsNullable = false)]
    public lfmTrackTag[] toptags
    {
        get
        {
            return this.toptagsField;
        }
        set
        {
            this.toptagsField = value;
        }
    }

    /// <remarks/>
    public lfmTrackWiki wiki
    {
        get
        {
            return this.wikiField;
        }
        set
        {
            this.wikiField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class lfmTrackStreamable
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
public partial class lfmTrackArtist
{

    private string nameField;

    private string mbidField;

    private string urlField;

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
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class lfmTrackTag
{

    private string nameField;

    private string urlField;

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
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class lfmTrackWiki
{

    private string publishedField;

    private string summaryField;

    private string contentField;

    /// <remarks/>
    public string published
    {
        get
        {
            return this.publishedField;
        }
        set
        {
            this.publishedField = value;
        }
    }

    /// <remarks/>
    public string summary
    {
        get
        {
            return this.summaryField;
        }
        set
        {
            this.summaryField = value;
        }
    }

    /// <remarks/>
    public string content
    {
        get
        {
            return this.contentField;
        }
        set
        {
            this.contentField = value;
        }
    }
}



