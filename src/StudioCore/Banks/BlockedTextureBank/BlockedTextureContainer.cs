using System;
using System.IO;
using System.Text.Json;

namespace StudioCore.Banks.BlockedTextureBank;

public class BlockedTextureContainer
{
    public BlockedTextureResource Data;

    public BlockedTextureContainer(bool load)
    {
        if (load)
        {
            Data = LoadMappingJSON();
        }
        else
        {
            Data = null;
        }
    }

    private BlockedTextureResource LoadMappingJSON()
    {
        var baseResource = new BlockedTextureResource();

        var baseResourcePath = "";

        baseResourcePath = AppContext.BaseDirectory + $"\\Assets\\Mappings\\{Project.GetGameIDForDir()}\\BlockedTextures.json";

        if (File.Exists(baseResourcePath))
        {
            using (var stream = File.OpenRead(baseResourcePath))
            {
                baseResource = JsonSerializer.Deserialize(stream, BlockedTextureSerializationContext.Default.BlockedTextureResource);
            }
        }
        else
        {
            TaskLogs.AddLog($"{baseResourcePath} does not exist!");
        }

        return baseResource;
    }
}
