// Decompiled with JetBrains decompiler
// Type: Amorous.Mod.IModBase
// Assembly: Amorous.Mod, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 3274B8A3-D550-40ED-AEFB-01185EA8A335
// Assembly location: C:\Users\demon\Downloads\amorous\amorous\amorous\Amorous.Mod.dll

using Microsoft.Xna.Framework;

namespace Amorous.Mod
{
  /// <summary>
  /// Implement this interface so your mod can be loaded by the mod loader
  /// </summary>
  public interface IModBase
  {
    /// <summary>
    /// Called when the game starts, used for initialization (duh)
    /// </summary>
    void Initialize();

    /// <summary>Load</summary>
    void LoadContent();

    /// <summary>Unload</summary>
    void UnloadContent();

    /// <summary>Called on each frame</summary>
    /// <param name="gameTime"></param>
    void Update(GameTime gameTime);

    /// <summary>Called on each frame but, for drawing</summary>
    /// <param name="gameTime"></param>
    void Draw(GameTime gameTime);
  }
}
