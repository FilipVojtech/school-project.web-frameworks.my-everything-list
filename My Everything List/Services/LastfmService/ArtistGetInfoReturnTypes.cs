using System.ComponentModel;
using System.Xml.Serialization;

namespace My_Everything_List.Services.LastfmService;


// NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
/// <remarks/>
[Serializable]
[DesignerCategory("code")]
[XmlType(AnonymousType = true)]
[XmlRoot(Namespace = "", IsNullable = false)]
public class LfmForArtist
{

    private LfmArtist artistField;

    private string statusField;

    /// <remarks/>
    public LfmArtist artist
    {
        get => artistField;
        set => artistField = value;
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
public class LfmArtist
{

    private string nameField;

    private string mbidField;

    private string urlField;

    private lfmArtistImage[] imageField;

    private byte streamableField;

    private byte ontourField;

    private lfmArtistStats statsField;

    private object similarField;

    private lfmArtistTag[] tagsField;

    private lfmArtistBio bioField;

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
    [XmlElement("image")]
    public lfmArtistImage[] image
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

    /// <remarks/>
    public byte ontour
    {
        get => ontourField;
        set => ontourField = value;
    }

    /// <remarks/>
    public lfmArtistStats stats
    {
        get => statsField;
        set => statsField = value;
    }

    /// <remarks/>
    public object similar
    {
        get => similarField;
        set => similarField = value;
    }

    /// <remarks/>
    [XmlArrayItem("tag", IsNullable = false)]
    public lfmArtistTag[] tags
    {
        get => tagsField;
        set => tagsField = value;
    }

    /// <remarks/>
    public lfmArtistBio bio
    {
        get => bioField;
        set => bioField = value;
    }
}

/// <remarks/>
[Serializable]
[DesignerCategory("code")]
[XmlType(AnonymousType = true)]
public class lfmArtistImage
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
public class lfmArtistStats
{

    private uint listenersField;

    private uint playcountField;

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
}

/// <remarks/>
[Serializable]
[DesignerCategory("code")]
[XmlType(AnonymousType = true)]
public class lfmArtistTag
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
public class lfmArtistBio
{

    private lfmArtistBioLinks linksField;

    private string publishedField;

    private string summaryField;

    private string contentField;

    /// <remarks/>
    public lfmArtistBioLinks links
    {
        get => linksField;
        set => linksField = value;
    }

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

/// <remarks/>
[Serializable]
[DesignerCategory("code")]
[XmlType(AnonymousType = true)]
public class lfmArtistBioLinks
{

    private lfmArtistBioLinksLink linkField;

    /// <remarks/>
    public lfmArtistBioLinksLink link
    {
        get => linkField;
        set => linkField = value;
    }
}

/// <remarks/>
[Serializable]
[DesignerCategory("code")]
[XmlType(AnonymousType = true)]
public class lfmArtistBioLinksLink
{

    private string relField;

    private string hrefField;

    /// <remarks/>
    [XmlAttribute]
    public string rel
    {
        get => relField;
        set => relField = value;
    }

    /// <remarks/>
    [XmlAttribute]
    public string href
    {
        get => hrefField;
        set => hrefField = value;
    }
}


