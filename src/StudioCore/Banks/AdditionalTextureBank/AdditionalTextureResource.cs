using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Text.Json;

namespace StudioCore.Banks.AdditionalTextureBank;

[JsonSourceGenerationOptions(
    WriteIndented = true,
    GenerationMode = JsonSourceGenerationMode.Metadata,
    IncludeFields = true,
    ReadCommentHandling = JsonCommentHandling.Skip)
]
[JsonSerializable(typeof(AdditionalTextureResource))]
[JsonSerializable(typeof(AdditionalTextureReference))]
public partial class AdditionalTextureSerializationContext
    : JsonSerializerContext
{ }

public class AdditionalTextureResource
{
    public List<AdditionalTextureReference> list { get; set; }
}

public class AdditionalTextureReference
{
    public string BaseID { get; set; }
    public List<string> AdditionalIDs { get; set; }
}
