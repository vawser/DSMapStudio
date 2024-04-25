using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Text.Json;

namespace StudioCore.Banks.AliasBank;

[JsonSourceGenerationOptions(
    WriteIndented = true,
    GenerationMode = JsonSourceGenerationMode.Metadata,
    IncludeFields = true,
    ReadCommentHandling = JsonCommentHandling.Skip)
]
[JsonSerializable(typeof(AliasResource))]
[JsonSerializable(typeof(AliasReference))]
public partial class AliasResourceSerializationContext
    : JsonSerializerContext
{ }

public class AliasResource
{
    public List<AliasReference> list { get; set; }
}

public class AliasReference
{
    public string id { get; set; }
    public string name { get; set; }
    public List<string> tags { get; set; }
}
