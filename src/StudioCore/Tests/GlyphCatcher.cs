using DotNext.Collections.Generic;
using SoulsFormats;
using StudioCore.Locators;
using StudioCore.TextEditor;
using StudioCore.UserProjectSpace;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Andre.Native.ImGuiBindings;

namespace StudioCore.Tests;

public static class GlyphCatcher
{
    public static string ExistingChars = null;

    private static void WriteToFile(HashSet<char> chars)
    {
        chars.AddAll(ExistingChars);

        if (File.Exists("LooseGlyphs.txt"))
        {
            var file = File.ReadAllText("LooseGlyphs.txt");
            char[] oldChars = file.ToCharArray();

            chars.AddAll(oldChars);
        }
        File.WriteAllText("LooseGlyphs.txt", string.Join("", chars));
    }

    /// <summary>
    ///     Goes through entries in project's MSBs to find characters that do not load with current font glyph ranges.
    /// </summary>
    public static unsafe void CheckMSB()
    {
        var maps = MapAssetLocator.GetFullMapList();
        HashSet<char> msbChars = new();
        foreach (var mapName in maps)
        {
            IMsb msb = null;
            var path = MapAssetLocator.GetMapMSB(mapName).AssetPath;

            switch (Project.Type)
            {
                case ProjectType.DES:
                    msb = MSBD.Read(path);
                    break;
                case ProjectType.DS1:
                case ProjectType.DS1R:
                    msb = MSB1.Read(path);
                    break;
                case ProjectType.DS2S:
                    msb = MSB2.Read(path);
                    break;
                case ProjectType.DS3:
                    msb = MSB3.Read(path);
                    break;
                case ProjectType.BB:
                    msb = MSBB.Read(path);
                    break;
                case ProjectType.SDT:
                    msb = MSBS.Read(path);
                    break;
                case ProjectType.ER:
                    msb = MSBE.Read(path);
                    break;
                case ProjectType.AC6:
                    msb = MSB_AC6.Read(path);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            msb.Events.GetEntries().Select(f => f.Name).ForEach(f => msbChars.AddAll(f.ToCharArray()));
            msb.Parts.GetEntries().Select(f => f.Name).ForEach(f => msbChars.AddAll(f.ToCharArray()));
            msb.Regions.GetEntries().Select(f => f.Name).ForEach(f => msbChars.AddAll(f.ToCharArray()));
        }

        HashSet<char> chars = new();
        var font = ImGui.GetFont();
        foreach (var c in msbChars)
        {
            var ret = ImFontFindGlyphNoFallback(font, c);
            if (ret == default)
            {
                chars.Add(c);
            }
        }

        WriteToFile(chars);
        TaskLogs.AddLog($"Done fetching glyphs from MSB. Total count: {chars.Count}");
    }

    /// <summary>
    ///     Goes through entries in project's currently loaded FMGs to find characters that do not load with current font glyph ranges.
    /// </summary>
    public static unsafe void CheckFMG()
    {
        HashSet<char> chars = new();
        var font = ImGui.GetFont();
        foreach (var info in FMGBank.FmgInfoBank)
        {
            foreach (var entry in info.Fmg.Entries)
            {
                if (entry.Text == null)
                    continue;

                foreach (var c in entry.Text)
                {
                    var ret = ImFontFindGlyphNoFallback(font, c);
                    if (ret == default)
                    {
                        chars.Add(c);
                    }
                }
            }
        }

        WriteToFile(chars);
        TaskLogs.AddLog($"Done fetching glyphs from FMG. Total count: {chars.Count}");
    }
}
