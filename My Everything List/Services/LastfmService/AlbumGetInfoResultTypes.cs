using System.ComponentModel;
using System.Xml.Serialization;

namespace My_Everything_List.Services.LastfmService;

/// <remarks/>
[Serializable]
[DesignerCategory("code")]
[XmlType(AnonymousType = true)]
[XmlRoot(Namespace = "", IsNullable = false)]
public class LfmForAlbum
{

    private LfmAlbum albumField;

    private string statusField;

    /// <remarks/>
    public LfmAlbum album
    {
        get => albumField;
        set => albumField = value;
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
public class LfmAlbum
{

    private string nameField;

    private string artistField;

    private string mbidField;

    private string urlField;

    private lfmAlbumImage[] imageField;

    private uint listenersField;

    private uint playcountField;

    private lfmAlbumTrack[] tracksField;

    private lfmAlbumTag[] tagsField;

    private lfmAlbumWiki wikiField;

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
    [XmlElement("image")]
    public lfmAlbumImage[] image
    {
        get => imageField;
        set => imageField = value;
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
    [XmlArrayItem("track", IsNullable = false)]
    public lfmAlbumTrack[] tracks
    {
        get => tracksField;
        set => tracksField = value;
    }

    /// <remarks/>
    [XmlArrayItem("tag", IsNullable = false)]
    public lfmAlbumTag[] tags
    {
        get => tagsField;
        set => tagsField = value;
    }

    /// <remarks/>
    public lfmAlbumWiki wiki
    {
        get => wikiField;
        set => wikiField = value;
    }
}

/// <remarks/>
[Serializable]
[DesignerCategory("code")]
[XmlType(AnonymousType = true)]
public class lfmAlbumImage
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

/// <remarks/>
[Serializable]
[DesignerCategory("code")]
[XmlType(AnonymousType = true)]
public class lfmAlbumTrack
{

    private string nameField;

    private string urlField;

    private ushort durationField;

    private lfmAlbumTrackStreamable streamableField;

    private lfmAlbumTrackArtist artistField;

    private byte rankField;

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
    public ushort duration
    {
        get => durationField;
        set => durationField = value;
    }

    /// <remarks/>
    public lfmAlbumTrackStreamable streamable
    {
        get => streamableField;
        set => streamableField = value;
    }

    /// <remarks/>
    public lfmAlbumTrackArtist artist
    {
        get => artistField;
        set => artistField = value;
    }

    /// <remarks/>
    [XmlAttribute]
    public byte rank
    {
        get => rankField;
        set => rankField = value;
    }
}

/// <remarks/>
[Serializable]
[DesignerCategory("code")]
[XmlType(AnonymousType = true)]
public class lfmAlbumTrackStreamable
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
public class lfmAlbumTrackArtist
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
public class lfmAlbumTag
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
public class lfmAlbumWiki
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



