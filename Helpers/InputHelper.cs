// Decompiled with JetBrains decompiler
// Type: Amorous.Mod.Helpers.InputHelper
// Assembly: Amorous.Mod, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 3274B8A3-D550-40ED-AEFB-01185EA8A335
// Assembly location: C:\Users\demon\Downloads\amorous\amorous\amorous\Amorous.Mod.dll

using Microsoft.Xna.Framework.Input;

namespace Amorous.Mod.Helpers
{
  /// <summary>Input stuff</summary>
  public static class InputHelper
  {
    /// <summary>
    /// Checks if key that was previously pressed is now released
    /// </summary>
    /// <param name="key">Key to check</param>
    /// <returns>Value</returns>
    public static bool IsReleased(Keys key) => ModLoader.Instance.GameInstance._RbWJ7YGnYHCSoD44MRW1h5X6E7E._KGCwEHf8akeXdkHLKFg1caFxXUJ(key);

    /// <summary>
    /// Checks if mouse button that was previously pressed is now released
    /// </summary>
    /// <param name="button">Mouse button to check</param>
    /// <returns>Value</returns>
    public static bool IsReleased(_PMeRYZJaBCqgB9uADJFP3c14lxq button) => ModLoader.Instance.GameInstance._RbWJ7YGnYHCSoD44MRW1h5X6E7E._KGCwEHf8akeXdkHLKFg1caFxXUJ(button);

    /// <summary>Checks if mouse button is down</summary>
    /// <param name="button">Mouse button to check</param>
    /// <returns>Value</returns>
    public static bool IsDown(_PMeRYZJaBCqgB9uADJFP3c14lxq button) => ModLoader.Instance.GameInstance._RbWJ7YGnYHCSoD44MRW1h5X6E7E._WZ4xYI5Q3hoCNX9QFzE3jfDwZBJ(button);

    /// <summary>Checks if key is pressed down</summary>
    /// <param name="key">Key to check</param>
    /// <returns>Value</returns>
    public static bool IsDown(Keys key) => ModLoader.Instance.GameInstance._RbWJ7YGnYHCSoD44MRW1h5X6E7E._WZ4xYI5Q3hoCNX9QFzE3jfDwZBJ(key);

    /// <summary>
    /// Checks if mouse button that was previously up is now pressed
    /// </summary>
    /// <param name="button">Mouse button to check</param>
    /// <returns>Value</returns>
    public static bool WasPressed(_PMeRYZJaBCqgB9uADJFP3c14lxq button) => ModLoader.Instance.GameInstance._RbWJ7YGnYHCSoD44MRW1h5X6E7E._fy5ebLnmRsRXv9v7RKTFU5CGMaH(button);

    /// <summary>Checks if key that was previously up is now pressed</summary>
    /// <param name="key">Key to check</param>
    /// <returns>Value</returns>
    public static bool WasPressed(Keys key) => ModLoader.Instance.GameInstance._RbWJ7YGnYHCSoD44MRW1h5X6E7E._fy5ebLnmRsRXv9v7RKTFU5CGMaH(key);

    /// <summary>Gets an array of all pressed keys</summary>
    /// <returns>Value</returns>
    public static Keys[] GetPressedKeys() => ModLoader.Instance.GameInstance._RbWJ7YGnYHCSoD44MRW1h5X6E7E._fy5ebLnmRsRXv9v7RKTFU5CGMaH();
  }
}
