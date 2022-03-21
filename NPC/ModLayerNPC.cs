// Decompiled with JetBrains decompiler
// Type: Amorous.Mod.NPC.ModLayerNPC`3
// Assembly: Amorous.Mod, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 3274B8A3-D550-40ED-AEFB-01185EA8A335
// Assembly location: C:\Users\demon\Downloads\amorous\amorous\amorous\Amorous.Mod.dll

using Amorous.Engine.NPC;
using Microsoft.Xna.Framework.Content;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Amorous.Mod.NPC
{
  /// <summary>Use this for all your NPC needs</summary>
  /// <typeparam name="THead">Head types</typeparam>
  /// <typeparam name="TPose">Body pose types</typeparam>
  /// <typeparam name="TClothes">Clothes types</typeparam>
  public class ModLayerNPC<THead, TPose, TClothes> : _xZgbANe7gi6i2DAhBEkKpR1QFLe
    where THead : struct, IConvertible
    where TPose : struct, IConvertible
    where TClothes : struct, IConvertible
  {
    private ModLoader _modLoader;

    /// <summary>Called when the NPC is clicked</summary>
    public Action Click
    {
      get => this._ZVpZ5Oing5kbbVhbmbOHyrofGH7;
      set => this._ZVpZ5Oing5kbbVhbmbOHyrofGH7 = value;
    }

    /// <summary>X position</summary>
    public float X
    {
      get => ((_QGGOTxZ8aNWGh0hc26wcmx8wmwT) this)._7Xn1C5tjYnmIif1iZKV8AWsEEbL;
      set => ((_QGGOTxZ8aNWGh0hc26wcmx8wmwT) this)._7Xn1C5tjYnmIif1iZKV8AWsEEbL = value;
    }

    /// <summary>Y position</summary>
    public float Y
    {
      get => ((_QGGOTxZ8aNWGh0hc26wcmx8wmwT) this)._bCjZ3VSXGKyhmykd2zCnQBiSpDf;
      set => ((_QGGOTxZ8aNWGh0hc26wcmx8wmwT) this)._bCjZ3VSXGKyhmykd2zCnQBiSpDf = value;
    }

    /// <summary>Whether or not should the NPC be flipped</summary>
    public bool Flip
    {
      get => this._Pv8G2bIbjHmJYrVXhNyr64NSPXn;
      set => this._Pv8G2bIbjHmJYrVXhNyr64NSPXn = value;
    }

    /// <summary>Scale</summary>
    public float Size
    {
      get => this._fO7gSlrDDNMoHR4FO5QXAq8fUyA;
      set => this._fO7gSlrDDNMoHR4FO5QXAq8fUyA = value;
    }

    /// <summary>
    /// Hitbox width, needed for clicking to work. Usually should be the same as the texture width.
    /// </summary>
    public int HitboxWidth
    {
      get => this._je8rVfyg4zywmqSi4Ozx1z7wJ4b;
      set => this._je8rVfyg4zywmqSi4Ozx1z7wJ4b = value;
    }

    /// <summary>
    /// Hitbox height, needed for clicking to work. Usually should be the same as the texture height.
    /// </summary>
    public int HitboxHeight
    {
      get => this._je8rVfyg4zywmqSi4Ozx1z7wJ4b;
      set => this._je8rVfyg4zywmqSi4Ozx1z7wJ4b = value;
    }

    /// <summary>True when cursor is hovering over the NPC</summary>
    public bool Selected
    {
      get => this._IvIFs0Tl6RHdTn3daJXsNCXCNyO;
      set => this._IvIFs0Tl6RHdTn3daJXsNCXCNyO = value;
    }

    /// <summary>Constructor</summary>
    /// <param name="gameInstance">Amorous game instance</param>
    /// <param name="modLoader">Mod loader instance</param>
    /// <param name="assetPath">Base path to NPC textures</param>
    /// <param name="scale">Size</param>
    protected ModLayerNPC(
      _JbeCmOie0phb2cbgG6DdGZrbs3pB gameInstance,
      ModLoader modLoader,
      string assetPath,
      float scale = 1f)
      : base(gameInstance, assetPath, scale)
    {
      this._modLoader = modLoader;
    }

    /// <summary>Adds a head texture corresponding to head type enum</summary>
    /// <param name="headType">Head type</param>
    /// <param name="assetNames">Asset names for all textures for the corresponding head type</param>
    /// <returns>Asset</returns>
    public _xmfdPa5IagU3cXbLL61gyoXAV7gA AddHead(
      THead headType,
      params string[] assetNames)
    {
      return this._aRXZ6kQYnlqRUMIC19x1vIPD62D(Enum.GetName(typeof (THead), (object) headType), assetNames);
    }

    /// <summary>
    /// Adds a body texture corresponding to body pose type enum
    /// </summary>
    /// <param name="poseType">Body pose type</param>
    /// <param name="assetNames">Asset names for all textures for the corresponding body pose type</param>
    /// <returns>Asset</returns>
    public _NaKchYC4I4GjWR34SfBLAktysCE AddBody(
      TPose poseType,
      params string[] assetNames)
    {
      return this._zDmJ8ztQTMoRvRw2LsNKu5foPpF(Enum.GetName(typeof (TPose), (object) poseType), assetNames);
    }

    /// <summary>
    /// Adds clothes texture corresponding to body pose type and clothes type enum
    /// </summary>
    /// <param name="poseType">Body pose type</param>
    /// <param name="clothesType">Clothes type</param>
    /// <param name="assetNames">Asset names for all textures for the corresponding body pose + clothes type</param>
    /// <returns>Asset</returns>
    public _EZ0kOLXoEoEfWGQDdTbNqaPzDUh AddClothes(
      TPose poseType,
      TClothes clothesType,
      params string[] assetNames)
    {
      return this._ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(Enum.GetName(typeof (TPose), (object) poseType), Enum.GetName(typeof (TClothes), (object) clothesType), assetNames);
    }

    /// <summary>Sets a head type to use</summary>
    /// <param name="headType">Head type to use</param>
    public void SetHead(THead headType) => this._g3oEqGBkN3YHUPosRq2nIP2sX0D(Enum.GetName(typeof (THead), (object) headType));

    /// <summary>Sets a body pose type to use</summary>
    /// <param name="poseType">Body pose type to use</param>
    public void SetBody(TPose poseType) => this._tDFvus0ZCanjp81eOiDzoMXJiuf(Enum.GetName(typeof (TPose), (object) poseType));

    /// <summary>Sets clothes type to use</summary>
    /// <param name="clothesTypes">Clothes types to use</param>
    public void SetClothes(params TClothes[] clothesTypes) => this._09vxUzgOn7J7DFZEwsTh7lgEIhB(((IEnumerable<TClothes>) clothesTypes).Select<TClothes, string>((Func<TClothes, string>) (clothesType => Enum.GetName(typeof (TClothes), (object) clothesType))).ToArray<string>());

    /// <summary>Adds an attachment to the NPC</summary>
    /// <param name="contentManager_0">Content manager used for loading the textures</param>
    /// <param name="path">Path to the texture</param>
    public void AddAttachment(ContentManager contentManager_0, string path) => typeof (_xZgbANe7gi6i2DAhBEkKpR1QFLe).GetMethod("_wKyvqIzFCeVgn62yYXdOxlqw4In", BindingFlags.Instance | BindingFlags.NonPublic)?.Invoke((object) this, new object[2]
    {
      (object) contentManager_0,
      (object) path
    });

    /// <summary>
    /// Method that gets called when NPC location on screen is changed during a cutscene (left, middle, right)
    /// </summary>
    /// <example>
    /// Use a switch statement to change values for specific locations:
    /// <code>
    /// public override void _obvu1L6KrxGqH1z2XacOoFxfneg(NPCLocation location)
    /// {
    ///     base._obvu1L6KrxGqH1z2XacOoFxfneg(location);
    ///     switch (location)
    ///     {
    ///         case NPCLocation.Middle:
    ///             Size = 1f;
    ///             Flip = true;
    ///             X = 240f;
    ///             Y = 50f;
    ///             return;
    ///         case NPCLocation.Left:
    ///             Size = 0.85f;
    ///             Flip = true;
    ///             X = -300f;
    ///             Y = 50f;
    ///             return;
    ///         case NPCLocation.Right:
    ///             Size = 0.85f;
    ///             Flip = false;
    ///             X = 990f;
    ///             Y = 50f;
    ///             return;
    ///         default:
    ///             return;
    ///     }
    /// }
    /// </code>
    /// </example>
    /// <param name="location">NPC location</param>
    public override void _nGGBtYpZ8pI1BmE2c2ke63UjGDP(NPCLocation location) => base._nGGBtYpZ8pI1BmE2c2ke63UjGDP(location);

    /// <summary>Initialization method</summary>
    public override void _g9Sx54kMPiHz5jrqWh4Kb1pTijH()
    {
      foreach (_NaKchYC4I4GjWR34SfBLAktysCE x3H8v8ol92joGxMwI in this._EcxlglhukYZdLVkSogxZZE3XdVj)
      {
        x3H8v8ol92joGxMwI._CjFYKEH7Vq8U6urMqr8ixn5Z8li.ForEach((Action<string>) (string_0 => this.AddAttachment((ContentManager) this._modLoader.ModContentManager, string_0)));
        x3H8v8ol92joGxMwI._l11eB5s4oGaWqILnwn3dX83PzrN.ForEach((Action<string>) (string_0 => this.AddAttachment((ContentManager) this._modLoader.ModContentManager, string_0)));
        foreach (_EZ0kOLXoEoEfWGQDdTbNqaPzDUh kwddA2IsycsbGmok in x3H8v8ol92joGxMwI._wUcbLpwYJ1T1bI8GaQwj9Jxx4YX)
          kwddA2IsycsbGmok._CjFYKEH7Vq8U6urMqr8ixn5Z8li.ForEach((Action<string>) (string_0 => this.AddAttachment((ContentManager) this._modLoader.ModContentManager, string_0)));
      }
      foreach (_xmfdPa5IagU3cXbLL61gyoXAV7gA ughDicwK7iTvgdnB in this._uZyXmbTsZVxXsadCzSsIs0z4xdb)
      {
        ughDicwK7iTvgdnB._CjFYKEH7Vq8U6urMqr8ixn5Z8li.ForEach((Action<string>) (string_0 => this.AddAttachment((ContentManager) this._modLoader.ModContentManager, string_0)));
        if (!string.IsNullOrEmpty(ughDicwK7iTvgdnB._RaPHmtsFBJiVmlc8lVytEMOT6ZA))
          this.AddAttachment((ContentManager) this._modLoader.ModContentManager, ughDicwK7iTvgdnB._RaPHmtsFBJiVmlc8lVytEMOT6ZA);
      }
    }
  }
}
