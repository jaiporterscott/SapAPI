using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Sap.Model.EHSIncident;

/// <summary>
///
/// </summary>
public class Metadata : IValidatableObject
{
    /// <summary>
    ///
    /// </summary>
    [DataMember(Name = "id", EmitDefaultValue = true)]
    public string? Id { get; set; }
    /// <summary>
    ///
    /// </summary>
    [DataMember(Name = "uri", EmitDefaultValue = true)]
    public string? Uri { get; set; }
    /// <summary>
    ///
    /// </summary>
    [DataMember(Name = "type", EmitDefaultValue = true)]
    public string? Type { get; set; }
    /// <summary>
    ///
    /// </summary>
    [DataMember(Name = "content_type", EmitDefaultValue = true)]
    public string? ContentType { get; set; }
    /// <summary>
    ///
    /// </summary>
    [DataMember(Name = "media_src", EmitDefaultValue = true)]
    public string? MediaSrc { get; set; }


    /// <summary>
    ///
    /// </summary>
    /// <param name="id"></param>
    /// <param name="uri"></param>
    /// <param name="type"></param>
    /// <param name="content_type"></param>
    /// <param name="media_src"></param>
    [JsonConstructor]
    public Metadata(string? id, string? uri, string? type, string? content_type, string? media_src)
    {
        Id = id;
        Uri = uri;
        Type = type;
        ContentType = content_type;
        MediaSrc = media_src;
    }
    /// <summary>
    ///
    /// </summary>
    /// <param name="metadata"></param>
    public Metadata(Metadata metadata)
    {
        Id = metadata.Id;
        Uri = metadata.Uri;
        Type = metadata.Type;
        ContentType = metadata.ContentType;
        MediaSrc = metadata.MediaSrc;
    }

    public Metadata()
    {

    }

    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        yield break;
    }
}
