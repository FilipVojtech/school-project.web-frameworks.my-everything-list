namespace My_Everything_List.Services.LastfmService;


// NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
public partial class AlbumsSearchResults
{

    private Query queryField;

    private ushort totalResultsField;

    private byte startIndexField;

    private byte itemsPerPageField;

    private resultsAlbummatches albummatchesField;

    private string forField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://a9.com/-/spec/opensearch/1.1/")]
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
    public resultsAlbummatches albummatches
    {
        get
        {
            return this.albummatchesField;
        }
        set
        {
            this.albummatchesField = value;
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
public partial class Query
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
public partial class resultsAlbummatches
{

    private resultsAlbummatchesAlbum albumField;

    private string[] textField;

    /// <remarks/>
    public resultsAlbummatchesAlbum album
    {
        get
        {
            return this.albumField;
        }
        set
        {
            this.albumField = value;
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
public partial class resultsAlbummatchesAlbum
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
    public uint id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
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
    [System.Xml.Serialization.XmlElementAttribute("image")]
    public resultsAlbummatchesAlbumImage[] image
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

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class resultsAlbummatchesAlbumImage
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



