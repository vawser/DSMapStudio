﻿using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Text.Json;

namespace StudioCore.Banks.CorrectedTextureBank;

[JsonSourceGenerationOptions(
    WriteIndented = true,
    GenerationMode = JsonSourceGenerationMode.Metadata,
    IncludeFields = true,
    ReadCommentHandling = JsonCommentHandling.Skip)
]
[JsonSerializable(typeof(CorrectedTextureResource))]
[JsonSerializable(typeof(CorrectedTextureReference))]
public partial class CorrectedTextureSerializationContext
    : JsonSerializerContext
{ }

public class CorrectedTextureResource
{
    public List<CorrectedTextureReference> list { get; set; }
}

public class CorrectedTextureReference
{
    public string VirtualPath { get; set; }
    public string CorrectedPath { get; set; }
    public string AssetID { get; set; }
}
