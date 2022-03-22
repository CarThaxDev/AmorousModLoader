// Decompiled with JetBrains decompiler
// Type: araghon007.AmorousTestMod.NPC.Stickman
// Assembly: AmorousTestMod, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2CA59860-14AD-4237-B2C6-BB1163EEC49A
// Assembly location: C:\Users\demon\Downloads\amorous\amorous\amorous\Content-Mods\AmorousTestMod.dll

using System.Linq.Expressions;
using Amorous.Engine.NPC;
using Amorous.Mod;
using Amorous.Mod.Helpers;
using Amorous.Mod.NPC;

namespace araghon007.AmorousTestMod.NPC
{
  public class Stickman : ModLayerNPC<Stickman.Heads, Stickman.Poses, Stickman.Clothes>
  {
    public Stickman(_JbeCmOie0phb2cbgG6DdGZrbs3pB gameInstance, ModLoader modLoader)
      : base(gameInstance, modLoader, "Assets/NPC/Stickman", 1f)
    {
      this.AddBody(Stickman.Poses.Default, new string[1]
      {
        nameof (Stickman)
      });
      this.AddHead(Stickman.Heads.Default, new string[1]
      {
        "Default"
      });
      this.AddHead(Stickman.Heads.Angry, new string[1]
      {
        "Angry"
      });
      this.Size = 0.4f;
      this.HitboxWidth = 1411;
      this.HitboxHeight = 1602;
      this._J4giDjnRtYmiHMmzwRZ0ThvfAhH = false;
      this._upl1k7yzBzlU7vErvbydGmXROfA = true;
      this._je8rVfyg4zywmqSi4Ozx1z7wJ4b = HitboxWidth;
      this._WJfGWBzn4wgdGBnMWRH2pcJ3AqH = HitboxHeight;
    }

    public override void _g9Sx54kMPiHz5jrqWh4Kb1pTijH()
    {
      base._g9Sx54kMPiHz5jrqWh4Kb1pTijH();
      this.SetHead(Stickman.Heads.Default);
      this.SetBody(Stickman.Poses.Default);
    }
    


    public override void _nGGBtYpZ8pI1BmE2c2ke63UjGDP(NPCLocation location)
    {
      LogHelper.LogInfo($"New NPCLocation for Stickman is {location.ToString()}");
      base._nGGBtYpZ8pI1BmE2c2ke63UjGDP(location);
      switch (location)
      {
        case NPCLocation.Middle:
          this.Size = 1f;
          this.Flip = true;
          this.X = 240f;
          this.Y = 50f;
          return;
        case NPCLocation.Left:
          this.Size = 0.85f;
          this.Flip = true;
          this.X = -300f;
          this.Y = 50f;
          return;
        case NPCLocation.Right:
          this.Size = 0.85f;
          this.Flip = false;
          this.X = 990f;
          this.Y = 50f;
          return;
        default:
          return;
      }
    }

    public enum Heads
    {
      Default,
      Angry,
    }

    public enum Poses
    {
      Default,
    }

    public enum Clothes
    {
      Default,
    }
  }
}
