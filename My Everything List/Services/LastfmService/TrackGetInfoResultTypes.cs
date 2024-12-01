using System.ComponentModel;
using System.Xml.Serialization;

namespace My_Everything_List.Services.LastfmService;

/// <remarks/>
[Serializable]
[DesignerCategory("code")]
[XmlType(AnonymousType = true)]
[XmlRoot(Namespace = "", IsNullable = false)]
public class lfm
{

    private lfmTrack trackField;

    private string statusField;

    /// <remarks/>
    public lfmTrack track
    {
        get => trackField;
        set => trackField = value;
    }

    /// <remarks/>
    [XmlAttribute]
    public string status
    {
        get => statusField;
        set => statusField = value;
    }
}

/// <remarks/>
[Serializable]
[DesignerCategory("code")]
[XmlType(AnonymousType = true)]
public class lfmTrack
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
        get => nameField;
        set => nameField = value;
    }

    /// <remarks/>
    public string url
    {
        get => urlField;
        set => urlField = value;
    }

    /// <remarks/>
    public byte duration
    {
        get => durationField;
        set => durationField = value;
    }

    /// <remarks/>
    public lfmTrackStreamable streamable
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
    public uint playcount
    {
        get => playcountField;
        set => playcountField = value;
    }

    /// <remarks/>
    public lfmTrackArtist artist
    {
        get => artistField;
        set => artistField = value;
    }

    /// <remarks/>
    [XmlArrayItem("tag", IsNullable = false)]
    public lfmTrackTag[] toptags
    {
        get => toptagsField;
        set => toptagsField = value;
    }

    /// <remarks/>
    public lfmTrackWiki wiki
    {
        get => wikiField;
        set => wikiField = value;
    }
}

/// <remarks/>
[Serializable]
[DesignerCategory("code")]
[XmlType(AnonymousType = true)]
public class lfmTrackStreamable
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
public class lfmTrackArtist
{

    private string nameField;

    private string mbidField;

    private string urlField;

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
}

/// <remarks/>
[Serializable]
[DesignerCategory("code")]
[XmlType(AnonymousType = true)]
public class lfmTrackTag
{

    private string nameField;

    private string urlField;

    /// <remarks/>
    public string name
    {
        get => nameField;
        set => nameField = value;
    }

    /// <remarks/>
    public string url
    {
        get => urlField;
        set => urlField = value;
    }
}

/// <remarks/>
[Serializable]
[DesignerCategory("code")]
[XmlType(AnonymousType = true)]
public class lfmTrackWiki
{

    private string publishedField;

    private string summaryField;

    private string contentField;

    /// <remarks/>
    public string published
    {
        get => publishedField;
        set => publishedField = value;
    }

    /// <remarks/>
    public string summary
    {
        get => summaryField;
        set => summaryField = value;
    }

    /// <remarks/>
    public string content
    {
        get => contentField;
        set => contentField = value;
    }
}



