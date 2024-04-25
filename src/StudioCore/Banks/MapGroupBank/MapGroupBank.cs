﻿using StudioCore.Editor;
using StudioCore.UserProjectSpace;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

namespace StudioCore.Editors.MapEditor.MapGroup;

public class MapGroupBank
{
    public MapGroupContainer _MapGroupBank { get; set; }

    public bool IsMapGroupBankLoading { get; set; }
    public bool CanReloadMapGroupBank { get; set; }

    private string TemplateName = "Template.json";

    private string ProgramDirectory = ".smithbox";

    private string FileName = "";

    public MapGroupBank()
    {
        CanReloadMapGroupBank = false;
    }

    public MapGroupResource Entries
    {
        get
        {
            if (IsMapGroupBankLoading)
            {
                return new MapGroupResource();
            }

            return _MapGroupBank.Data;
        }
    }

    public void ReloadMapGroupBank()
    {
        TaskManager.Run(new TaskManager.LiveTask($"Map Groups - Load", TaskManager.RequeueType.None, false,
        () =>
        {
            _MapGroupBank = new MapGroupContainer();
            IsMapGroupBankLoading = true;

            if (Project.Type != ProjectType.Undefined)
            {
                try
                {
                    _MapGroupBank = new MapGroupContainer();
                }
                catch (Exception e)
                {
                    TaskLogs.AddLog($"FAILED LOAD: {e.Message}");
                }

                IsMapGroupBankLoading = false;
            }
            else
                IsMapGroupBankLoading = false;
        }));
    }

    public MapGroupResource LoadTargetBank(string path)
    {
        var newResource = new MapGroupResource();

        if (File.Exists(path))
        {
            using (var stream = File.OpenRead(path))
            {
                newResource = JsonSerializer.Deserialize(stream, MapGroupResourceSerializationContext.Default.MapGroupResource);
            }
        }

        return newResource;
    }

    public void WriteTargetBank(MapGroupResource targetBank)
    {
        var resourceFilePath = Project.GameModDirectory + $"\\{ProgramDirectory}\\Assets\\MapGroups\\{Project.GetGameIDForDir()}.json";

        if (File.Exists(resourceFilePath))
        {
            string jsonString = JsonSerializer.Serialize(targetBank, typeof(MapGroupResource), MapGroupResourceSerializationContext.Default);

            try
            {
                var fs = new FileStream(resourceFilePath, System.IO.FileMode.Create);
                var data = Encoding.ASCII.GetBytes(jsonString);
                fs.Write(data, 0, data.Length);
                fs.Flush();
                fs.Dispose();
            }
            catch (Exception ex)
            {
                TaskLogs.AddLog($"{ex}");
            }
        }
    }

    public void AddToLocalBank(string refID, string refName, string refDesc, string refCategory, List<MapGroupMember> refMembers)
    {
        var templateResource = AppContext.BaseDirectory + $"\\Assets\\MapGroups\\{TemplateName}";

        var resourcePath = Project.GameModDirectory + $"\\{ProgramDirectory}\\Assets\\MapGroups\\";

        var resourceFilePath = Project.GameModDirectory + $"\\{ProgramDirectory}\\Assets\\MapGroups\\{Project.GetGameIDForDir()}.json";

        // Create directory/file if they don't exist
        if (!Directory.Exists(resourcePath))
        {
            Directory.CreateDirectory(resourcePath);
        }

        if (!File.Exists(resourceFilePath))
        {
            File.Copy(templateResource, resourceFilePath);
        }

        if (File.Exists(resourceFilePath))
        {
            // Load up the target local model alias bank.
            var targetResource = LoadTargetBank(resourceFilePath);

            var doesExist = false;

            // If it exists within the mod local file, update the contents
            foreach (var entry in targetResource.list)
            {
                if (entry.id == refID)
                {
                    doesExist = true;

                    entry.name = refName;
                    entry.description = refDesc;
                    entry.category = refCategory;
                    entry.members = refMembers;
                }
            }

            // If it doesn't exist in the mod local file, add it in
            if (!doesExist)
            {
                var entry = new MapGroupReference();
                entry.id = refID;
                entry.name = refName;
                entry.description = refDesc;
                entry.category = refCategory;
                entry.members = refMembers;

                targetResource.list.Add(entry);
            }

            WriteTargetBank(targetResource);
        }
    }

    /// <summary>
    /// Removes specified reference from local model alias bank.
    /// </summary>
    public void RemoveFromLocalBank(string refID)
    {
        var resourcePath = Project.GameModDirectory + $"\\{ProgramDirectory}\\Assets\\MapGroups\\{Project.GetGameIDForDir()}.json";

        if (File.Exists(resourcePath))
        {
            var targetResource = LoadTargetBank(resourcePath);

            for (var i = 0; i <= targetResource.list.Count - 1; i++)
            {
                var entry = targetResource.list[i];
                if (entry.id == refID)
                {
                    targetResource.list.Remove(entry);
                    break;
                }
            }

            WriteTargetBank(targetResource);
        }
    }

    public bool IsLocalMapGroup(string refID)
    {
        var baseResourcePath = AppContext.BaseDirectory + $"\\Assets\\MapGroups\\{Project.GetGameIDForDir()}.json";

        var resourcePath = Project.GameModDirectory + $"\\{ProgramDirectory}\\Assets\\MapGroups\\{Project.GetGameIDForDir()}.json";

        var isInBase = false;

        if (File.Exists(baseResourcePath))
        {
            var targetResource = LoadTargetBank(baseResourcePath);

            for (var i = 0; i <= targetResource.list.Count - 1; i++)
            {
                var entry = targetResource.list[i];
                if (entry.id == refID)
                {
                    isInBase = true;
                }
            }
        }

        var isInProject = false;

        if (File.Exists(resourcePath))
        {
            var targetResource = LoadTargetBank(resourcePath);

            for (var i = 0; i <= targetResource.list.Count - 1; i++)
            {
                var entry = targetResource.list[i];
                if (entry.id == refID)
                {
                    isInProject = true;
                }
            }
        }

        if (isInProject && !isInBase)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
