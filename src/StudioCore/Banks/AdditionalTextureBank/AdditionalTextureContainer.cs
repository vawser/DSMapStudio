using System;
using System.IO;
using System.Text.Json;

namespace StudioCore.Banks.AdditionalTextureBank
{
    public class AdditionalTextureContainer
    {
        public AdditionalTextureResource Data;

        public AdditionalTextureContainer(bool load)
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

        private AdditionalTextureResource LoadMappingJSON()
        {
            var baseResource = new AdditionalTextureResource();

            var baseResourcePath = "";

            baseResourcePath = AppContext.BaseDirectory + $"\\Assets\\Mappings\\{Project.GetGameIDForDir()}\\AdditionalTextures.json";

            if (File.Exists(baseResourcePath))
            {
                using (var stream = File.OpenRead(baseResourcePath))
                {
                    baseResource = JsonSerializer.Deserialize(stream, AdditionalTextureSerializationContext.Default.AdditionalTextureResource);
                }
            }
            else
            {
                TaskLogs.AddLog($"{baseResourcePath} does not exist!");
            }

            return baseResource;
        }
    }
}
