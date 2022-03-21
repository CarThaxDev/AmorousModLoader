// Decompiled with JetBrains decompiler
// Type: Amorous.Mod.ModContentManager
// Assembly: Amorous.Mod, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 3274B8A3-D550-40ED-AEFB-01185EA8A335
// Assembly location: C:\Users\demon\Downloads\amorous\amorous\amorous\Amorous.Mod.dll

using Microsoft.Xna.Framework.Content;
using System;
using System.IO;
using System.IO.Compression;

namespace Amorous.Mod
{
  /// <summary>Content manager pointing to Content-Mods</summary>
  public class ModContentManager : ContentManager
  {
    /// <summary>Constructor</summary>
    /// <param name="serviceProvider">Service Provider</param>
    /// <param name="rootDirectory">Root directory except fuck you because it's set manually anyway</param>
    public ModContentManager(IServiceProvider serviceProvider, string rootDirectory)
      : base(serviceProvider, rootDirectory)
    {
      this.RootDirectory = "Content-Mods";
    }

    /// <summary>
    /// Overriding OpenStream function to decompress any and all assets that are being loaded
    /// </summary>
    /// <remarks>
    /// May or may not throw an exception if the file isn't actually compressed
    /// </remarks>
    /// <param name="assetName">Name of the asset to load</param>
    /// <returns>Stream</returns>
    protected override Stream OpenStream(string assetName)
    {
      try
      {
        return (Stream) new GZipStream(base.OpenStream(assetName), CompressionMode.Decompress);
      }
      catch
      {
        return base.OpenStream(assetName);
      }
    }
  }
}
