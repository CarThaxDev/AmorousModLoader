// Decompiled with JetBrains decompiler
// Type: MainGame
// Assembly: Amorous.Game.Mod.Windows, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B3839EFC-669C-411A-A58C-5C56D8B36777
// Assembly location: C:\Users\demon\Downloads\amorous\amorous\amorous\Amorous.Game.Mod.Windows.exe

using Amorous.Mod;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

public class MainGame : Game
{
  private readonly _JbeCmOie0phb2cbgG6DdGZrbs3pB _gameInstance;
  private readonly ModLoader _modLoader;

  public MainGame(bool safeMode)
  {
    /*GraphicsDeviceManager graphicsDeviceManager;
    if (!safeMode)
    {
      DisplayMode currentDisplayMode = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode;
      graphicsDeviceManager = new GraphicsDeviceManager((Game) this)
      {
        IsFullScreen = true,
        PreferredBackBufferWidth = currentDisplayMode.Width,
        PreferredBackBufferHeight = currentDisplayMode.Height,
        SynchronizeWithVerticalRetrace = true
      };
    }
    else
      graphicsDeviceManager = new GraphicsDeviceManager((Game) this)
      {
        IsFullScreen = false,
        PreferredBackBufferWidth = 1024,
        PreferredBackBufferHeight = 768,
        SynchronizeWithVerticalRetrace = true
      };
      */
    this.Window.Title = "Amorous v1.0.3 (Windows, Modded)";
    this.Content.RootDirectory = "Content";
    this._gameInstance = (_JbeCmOie0phb2cbgG6DdGZrbs3pB) new _bj8iyyk84DtxcxcHgAHHFGgq8oN(this, !safeMode);
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
