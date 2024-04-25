﻿using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Text.Json;

namespace StudioCore.Banks.BlockedTextureBank;

[JsonSourceGenerationOptions(
    WriteIndented = true,
    GenerationMode = JsonSourceGenerationMode.Metadata,
    IncludeFields = true,
    ReadCommentHandling = JsonCommentHandling.Skip)
]
[JsonSerializable(typeof(BlockedTextureResource))]
public partial class BlockedTextureSerializationContext
    : JsonSerializerContext
{ }

public class BlockedTextureResource
{
    public List<string> list { get; set; }
}

