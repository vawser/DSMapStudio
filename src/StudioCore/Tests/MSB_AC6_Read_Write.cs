﻿using SoulsFormats;
using StudioCore.Locators;
using System;
using System.Collections.Generic;
using System.IO;

namespace StudioCore.Tests;
public static class MSB_AC6_Read_Write
{
    public static bool Run()
    {
        List<string> msbs = MapAssetLocator.GetFullMapList();

        // m00_90_00_00

        foreach (var msb in msbs)
        {
            if (msb == "m00_90_00_00")
            {
                AssetDescription path = MapAssetLocator.GetMapMSB(msb);
                var bytes = File.ReadAllBytes(path.AssetPath);
                Memory<byte> decompressed = DCX.Decompress(bytes);
                MSB_AC6 m = MSB_AC6.Read(decompressed);
                var written = m.Write(DCX.Type.None);
                if (!decompressed.Span.SequenceEqual(written))
                {
                    var basepath = Path.GetDirectoryName(path.AssetPath);
                    if (!Directory.Exists($@"{basepath}\mismatches"))
                    {
                        Directory.CreateDirectory($@"{basepath}\mismatches");
                    }

                    Console.WriteLine($@"Mismatch: {msb}");
                    File.WriteAllBytes($@"{basepath}\mismatches\{Path.GetFileNameWithoutExtension(path.AssetPath)}",
                        written);
                }
            }
        }

        return true;
    }
}
