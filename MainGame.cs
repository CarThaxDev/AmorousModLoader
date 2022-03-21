// Decompiled with JetBrains decompiler
// Type: MainGame
// Assembly: Amorous.Game.Mod.Windows, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B3839EFC-669C-411A-A58C-5C56D8B36777
// Assembly location: C:\Users\demon\Downloads\amorous\amorous\amorous\Amorous.Game.Mod.Windows.exe

using System;
using Amorous.Mod;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

public class MainGame : Game
{
  private readonly _JbeCmOie0phb2cbgG6DdGZrbs3pB _gameInstance;
  private readonly ModLoader _modLoader;

  public MainGame(bool safeMode)
  {
    /*
    GraphicsDeviceManager graphicsDeviceManager = new GraphicsDeviceManager(this);
    if (!safeMode)
    {
      DisplayMode currentDisplayMode = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode;
      graphicsDeviceManager.IsFullScreen = true;
      graphicsDeviceManager.PreferredBackBufferHeight = currentDisplayMode.Height;
      graphicsDeviceManager.PreferredBackBufferWidth = currentDisplayMode.Width;
      graphicsDeviceManager.SynchronizeWithVerticalRetrace = true;
    }
    else
    {
      graphicsDeviceManager.IsFullScreen = false;
      graphicsDeviceManager.PreferredBackBufferHeight = 768;
      graphicsDeviceManager.PreferredBackBufferWidth = 1024;
      graphicsDeviceManager.SynchronizeWithVerticalRetrace = true;
    }
  */
    this.Window.Title = "Amorous v1.0.4 (Windows, Modded)";
    this.Content.RootDirectory = "Content";
    try
    {
      this._gameInstance = (_JbeCmOie0phb2cbgG6DdGZrbs3pB) new _bj8iyyk84DtxcxcHgAHHFGgq8oN(this, safeMode);
    }
    catch (ArgumentException e)
    {
      // ignored
    }

    this._modLoader = new ModLoader((Game) this, this._gameInstance);
  }

  protected override void Initialize()
  {
    this._gameInstance._oD87G7SXjsTukw7IVWxVlVFEgvA();
    this._modLoader.Initialize();
    base.Initialize();
  }

  protected override void LoadContent()
  {
    this._gameInstance._eW1Nkl8VqFHVExM8l3IqxgSbMBg();
    this._modLoader.LoadContent();
    base.LoadContent();
  }

  protected override void UnloadContent()
  {
    this._gameInstance._wm1aB8mBRRffPWUAA0o5Xar2w5p();
    this._modLoader.UnloadContent();
    base.UnloadContent();
  }

  protected override void Update(GameTime gameTime)
  {
    if (this.IsActive)
    {
      this._gameInstance._tiBFUHPEkedkbgvuX3whdeyjhKo(gameTime);
      this._modLoader.Update(gameTime);
    }
    base.Update(gameTime);
  }

  protected override void Draw(GameTime gameTime)
  {
    this._gameInstance._f5ctqAmdNsZ889UjM4LxDm8WGxA(gameTime);
    this._modLoader.Draw(gameTime);
    base.Draw(gameTime);
  }
}
