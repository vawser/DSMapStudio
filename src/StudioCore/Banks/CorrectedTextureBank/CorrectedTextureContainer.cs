using StudioCore.UserProjectSpace;
using System;
using System.IO;
using System.Text.Json;

namespace StudioCore.Banks.CorrectedTextureBank;

public class CorrectedTextureContainer
{
    public CorrectedTextureResource Data;

    public CorrectedTextureContainer()
    {
        Data = LoadMappingJSON();
    }

    private CorrectedTextureResource LoadMappingJSON()
    {
        var baseResource = new CorrectedTextureResource();

        var baseResourcePath = "";

        baseResourcePath = AppContext.BaseDirectory + $"\\Assets\\Mappings\\{Project.GetGameIDForDir()}\\CorrectedTextures.json";

        if (File.Exists(baseResourcePath))
        {
            using (var stream = File.OpenRead(baseResourcePath))
            {
                baseResource = JsonSerializer.Deserialize(stream, CorrectedTextureSerializationContext.Default.CorrectedTextureResource);
            }
        }
        else
        {
            TaskLogs.AddLog($"{baseResourcePath} does not exist!");
        }

        return baseResource;
    }
}
