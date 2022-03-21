// Decompiled with JetBrains decompiler
// Type: Amorous.Mod.Helpers.PlayerHelper
// Assembly: Amorous.Mod, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 3274B8A3-D550-40ED-AEFB-01185EA8A335
// Assembly location: C:\Users\demon\Downloads\amorous\amorous\amorous\Amorous.Mod.dll

namespace Amorous.Mod.Helpers
{
  /// <summary>Player helper</summary>
  public static class PlayerHelper
  {
    /// <summary>
    /// Gets a player flag, which can be set manually or through cutscenes (quests)
    /// </summary>
    /// <param name="flag">Flag to get</param>
    /// <returns>Value</returns>
    public static bool GetPlayerFlag(string flag) => _Z6EKIW3ycAwV2npYuxbFLcnCTrJ._yuFBJdi7mxrwMFQ57BjLjSq6ESj._Hnb6mPvrZFgOMCIApIeMW88jSsF._Cs2b43EFDtJdhoWWSmCcssGUmHZA.ContainsKey(flag) && _Z6EKIW3ycAwV2npYuxbFLcnCTrJ._yuFBJdi7mxrwMFQ57BjLjSq6ESj._Hnb6mPvrZFgOMCIApIeMW88jSsF._Cs2b43EFDtJdhoWWSmCcssGUmHZA[flag];

    /// <summary>
    /// Sets a player flag which is useful for tracking progression
    /// </summary>
    /// <param name="flag">Flag to set</param>
    /// <param name="value">Value to set the flag to</param>
    public static void SetPlayerFlag(string flag, bool value)
    {
      if (_Z6EKIW3ycAwV2npYuxbFLcnCTrJ._yuFBJdi7mxrwMFQ57BjLjSq6ESj._Hnb6mPvrZFgOMCIApIeMW88jSsF._Cs2b43EFDtJdhoWWSmCcssGUmHZA.ContainsKey(flag))
        _Z6EKIW3ycAwV2npYuxbFLcnCTrJ._yuFBJdi7mxrwMFQ57BjLjSq6ESj._Hnb6mPvrZFgOMCIApIeMW88jSsF._Cs2b43EFDtJdhoWWSmCcssGUmHZA[flag] = value;
      else
        _Z6EKIW3ycAwV2npYuxbFLcnCTrJ._yuFBJdi7mxrwMFQ57BjLjSq6ESj._Hnb6mPvrZFgOMCIApIeMW88jSsF._Cs2b43EFDtJdhoWWSmCcssGUmHZA.Add(flag, value);
    }
  }
}
