// Decompiled with JetBrains decompiler
// Type: araghon007.AmorousTestMod.Main
// Assembly: AmorousTestMod, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2CA59860-14AD-4237-B2C6-BB1163EEC49A
// Assembly location: C:\Users\demon\Downloads\amorous\amorous\amorous\Content-Mods\AmorousTestMod.dll

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Amorous.Game.NPC;
using Amorous.Game.Scenes;
using Amorous.Mod;
using Amorous.Mod.Helpers;
using araghon007.AmorousTestMod.NPC;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using SDL2;
using Squid;
using Keys = Microsoft.Xna.Framework.Input.Keys;
using Point = Microsoft.Xna.Framework.Point;
using Rectangle = Microsoft.Xna.Framework.Rectangle;

namespace araghon007.AmorousTestMod
{
	public class Main : IModBase
	{
		
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		public void Initialize()
		{
			spriteBatch = typeof(_bj8iyyk84DtxcxcHgAHHFGgq8oN).GetField("_ZXUztyGtStF4WzGVig7wu43cfnf",
				BindingFlags.Instance | BindingFlags.NonPublic);
			spriteFont = typeof(_bj8iyyk84DtxcxcHgAHHFGgq8oN).GetField("_xnYepZuegigJCU2jcbZsfVIakzF",
				BindingFlags.Instance | BindingFlags.NonPublic);
			textPos = typeof(_bj8iyyk84DtxcxcHgAHHFGgq8oN).GetField("_Vh2qdN4Ha62herl19def6PyuanQ",
				BindingFlags.Instance | BindingFlags.NonPublic);
		}

		// Token: 0x06000002 RID: 2 RVA: 0x000020B1 File Offset: 0x000002B1
		public void LoadContent()
		{
		}

		// Token: 0x06000003 RID: 3 RVA: 0x000020B3 File Offset: 0x000002B3
		public void UnloadContent()
		{
		}

		// Token: 0x06000004 RID: 4 RVA: 0x000020B8 File Offset: 0x000002B8
		public void Draw(GameTime gameTime)
		{
			if (devmode)
			{
				
				SpriteBatch spriteBatch = (SpriteBatch)this.spriteBatch.GetValue(ModLoader.Instance.GameInstance);
				SpriteFont spriteFont = (SpriteFont)this.spriteFont.GetValue(ModLoader.Instance.GameInstance);
				Vector2 vector = (Vector2)textPos.GetValue(ModLoader.Instance.GameInstance);
				LogHelper.LogInfo(spriteBatch.ToString());
				LogHelper.LogInfo(vector.ToString());
				LogHelper.LogInfo(spriteFont.ToString());
				spriteBatch.Begin();
				LogHelper.LogInfo("1");
				spriteBatch._FY70IFLoBond3ORPe0ndCLvIeVcA(spriteFont, "Devmode enabled", vector, Color.Red);
				LogHelper.LogInfo("2");
				spriteBatch._FY70IFLoBond3ORPe0ndCLvIeVcA(spriteFont,
					"DevMode Test", vector, Color.Red);
				foreach (_ujAkjlfN5TywwbLAUDzPvtab6uJ hClNIa2MAAqcV9tfVNkRq6Q9UNy in _assets)
				{
					LogHelper.LogInfo("1");
					vector.Y += 200f;
					LogHelper.LogInfo("2");
					spriteBatch._FY70IFLoBond3ORPe0ndCLvIeVcA(spriteFont,
						"DevMode Test", vector, Color.Red);
					LogHelper.LogInfo("3");
					
				}
				foreach (_QGGOTxZ8aNWGh0hc26wcmx8wmwT up4orz9jE5L118EdoBiV8uL9I5b in npcs)
				{
					vector.Y += 200f;
					LogHelper.LogInfo("4");
					spriteBatch._FY70IFLoBond3ORPe0ndCLvIeVcA(spriteFont, "DevMode Test 2", vector, Color.Red);
				}
				LogHelper.LogInfo("5");
				spriteBatch.End();
				LogHelper.LogInfo("6");
			
			}
			
		}

		// Token: 0x06000005 RID: 5 RVA: 0x0000228C File Offset: 0x0000048C
		public void Update(GameTime gameTime)
		{

			previousMouseState = mouseState;
			mouseState = Mouse.GetState();
			ClubInsideScene clubInsideScene = ModLoader.Instance.CurrentScene as ClubInsideScene;

			if (clubInsideScene != null)
			{

				_3IHp43rpkJgOBcY9lrIrwMuwWve npclayer = ModLoader.GetNPCLayer(clubInsideScene, "ClubInsideANPC");
				if (npclayer != null && npclayer._4QLHHCk23T1BjK7acKxASbkCefG._ZVpZ5Oing5kbbVhbmbOHyrofGH7 == null)
				{
					LogHelper.LogInfo("He exist2");
					npclayer._4QLHHCk23T1BjK7acKxASbkCefG._ZVpZ5Oing5kbbVhbmbOHyrofGH7 = ClickAction;
					PropertyInfo property = typeof(ClubInsideANPC).GetProperty("_je8rVfyg4zywmqSi4Ozx1z7wJ4b");
					if (property != null)
					{
						property.SetValue(npclayer._4QLHHCk23T1BjK7acKxASbkCefG, 375);
					}

					PropertyInfo property2 = typeof(ClubInsideANPC).GetProperty("_WJfGWBzn4wgdGBnMWRH2pcJ3AqH");
					if (property2 != null)
					{
						property2.SetValue(npclayer._4QLHHCk23T1BjK7acKxASbkCefG, 967);
					}
				}

				LogHelper.LogInfo("clubInsideScene go brr");
			}
			else
			{
				ClubUpstairsScene clubUpstairsScene = ModLoader.Instance.CurrentScene as ClubUpstairsScene;
				if (clubUpstairsScene != null &&
				    !PlayerHelper.GetPlayerFlag("araghon007.AmorousTestMod.StickmanHidden") &&
				    ModLoader.GetNPCLayer(clubUpstairsScene, "Stickman") == null)
				{
					LogHelper.LogInfo("He appear");
					Stickman stickman = ModLoader.Instance.AddNPC<Stickman>(_a2qVgWDIm3fBp49WubttSTPsx8K.Background);
					if (stickman != null)
					{
						stickman.Click = StickmanClickAction;
						stickman.X = 1600f;
						stickman.Y = 125f;
						stickman.HitboxHeight = 1602;
						stickman.HitboxWidth = 1411;
					}
				}else if(clubUpstairsScene != null && !PlayerHelper.GetPlayerFlag("araghon007.AmorousTestMod.StickmanHidden") && ModLoader.GetNPCLayer(clubUpstairsScene, "Stickman") != null)
				{
					
				}
			}

			if (InputHelper.WasPressed((_PMeRYZJaBCqgB9uADJFP3c14lxq) 0))
			{
				LogHelper.LogInfo(ModLoader.Instance.GameInstance._vsceSzSIjBy2nZrCxAzKZbUiwLq
					._e6KgAy4CTN1JFYwA88grvAEmDxX(ModLoader.Instance.GameInstance._RbWJ7YGnYHCSoD44MRW1h5X6E7E
						._U7CeYBJ1v1SoUxpX8emsQ9mWl5b).ToString());
			}


			if (InputHelper.IsDown(Keys.LeftControl) &&
			    InputHelper.WasPressed(Keys.Tab))
			{
				devmode = !devmode;
				PlayerHelper.SetPlayerFlag("araghon007.AmorousTestMod.Devmode", devmode);
				LogHelper.LogWarn("DevMode does not work on this, please ignore.");
			}

			if (devmode)
			{

				Point point = ModLoader.Instance.GameInstance._vsceSzSIjBy2nZrCxAzKZbUiwLq
					._e6KgAy4CTN1JFYwA88grvAEmDxX(ModLoader.Instance.GameInstance._RbWJ7YGnYHCSoD44MRW1h5X6E7E
						._U7CeYBJ1v1SoUxpX8emsQ9mWl5b);
				//this.TestHit(point,
				//ModLoader.Instance.GameInstance._XbOXR6AypLIdJ3gBMGseGi3Wi2i._quUC3a4OhsceDfLxPlEs4hmM7Nq());
				if (!test2 && InputHelper.IsDown(Keys.LeftControl) &&
				    InputHelper.WasPressed((_PMeRYZJaBCqgB9uADJFP3c14lxq) 2))
				{

					test2 = true;
					/*
					_QGGOTxZ8aNWGh0hc26wcmx8wmwT up4orz9jE5L118EdoBiV8uL9I5b =
						this.npcs.LastOrDefault<_QGGOTxZ8aNWGh0hc26wcmx8wmwT>();
					if (up4orz9jE5L118EdoBiV8uL9I5b != null)
					{
						this.obj.Item1 = up4orz9jE5L118EdoBiV8uL9I5b;
						this.obj.Item2.X = up4orz9jE5L118EdoBiV8uL9I5b._HpxiFIPCZeo2dAljY1izNPGOrIF() - (float) point.X;
						this.obj.Item2.Y = up4orz9jE5L118EdoBiV8uL9I5b._asVHWb7aUUFT8rJYFD3SpiY2bfA() - (float) point.Y;
					}
					else
					{
						_ujAkjlfN5TywwbLAUDzPvtab6uJ hClNIa2MAAqcV9tfVNkRq6Q9UNy =
							this._assets.LastOrDefault<_ujAkjlfN5TywwbLAUDzPvtab6uJ>();
						if (hClNIa2MAAqcV9tfVNkRq6Q9UNy != null)
						{
							this.obj.Item1 = hClNIa2MAAqcV9tfVNkRq6Q9UNy;
							this.obj.Item2.X = hClNIa2MAAqcV9tfVNkRq6Q9UNy._HpxiFIPCZeo2dAljY1izNPGOrIF() -
							                   (float) point.X;
							this.obj.Item2.Y = hClNIa2MAAqcV9tfVNkRq6Q9UNy._asVHWb7aUUFT8rJYFD3SpiY2bfA() -
							                   (float) point.Y;
						}
					}
					*/
					LogHelper.LogWarn("Again, dev mode DOES NOT WORK");
				}
				else if (!test2 && InputHelper.WasPressed((_PMeRYZJaBCqgB9uADJFP3c14lxq) 2))

				{
					LogHelper.LogInfo("ShowThing");
					MouseState state = Mouse.GetState();
					Window test = new Window
					{
						Modal = true,
						Dock = DockStyle.None,
						Position = new Squid.Point(state.X, state.Y),
						Size = new Squid.Point(120, 0),
						AutoSize = AutoSize.Vertical
					};
					Button button = new Button
					{
						Dock = DockStyle.Top,
						TextAlign = Alignment.MiddleCenter,
						Text = "Test",
						AutoSize = AutoSize.Vertical
					};
					button.MouseClick += delegate { test.Close(); };
					test.Controls.Add(button);
					test.Show(
						ModLoader.Instance.GameInstance._XbOXR6AypLIdJ3gBMGseGi3Wi2i._PnkAlVnMv0SZvRBFexqzE5DF9tp);
				}

				if (InputHelper.IsDown(Keys.LeftControl) &&
				    previousMouseState.ScrollWheelValue != mouseState.ScrollWheelValue)
				{
					LogHelper.LogInfo(
						(mouseState.ScrollWheelValue - previousMouseState.ScrollWheelValue).ToString());
					float num = 1200f;
					if (InputHelper.IsDown(Keys.LeftShift))
					{
						num = 600f;
					}
					else if (InputHelper.IsDown(Keys.LeftAlt))
					{
						num = 2400f;
					}


					_QGGOTxZ8aNWGh0hc26wcmx8wmwT up4orz9jE5L118EdoBiV8uL9I5b2 =
						this.npcs.LastOrDefault();
					if (up4orz9jE5L118EdoBiV8uL9I5b2 != null)
					{
						_QGGOTxZ8aNWGh0hc26wcmx8wmwT up4orz9jE5L118EdoBiV8uL9I5b3 = up4orz9jE5L118EdoBiV8uL9I5b2;
						up4orz9jE5L118EdoBiV8uL9I5b3._fO7gSlrDDNMoHR4FO5QXAq8fUyA += (float) (this.mouseState.ScrollWheelValue - this.previousMouseState.ScrollWheelValue) /
							num;
					}
					else
					{
						_ujAkjlfN5TywwbLAUDzPvtab6uJ hClNIa2MAAqcV9tfVNkRq6Q9UNy2 =
							this._assets.LastOrDefault<_ujAkjlfN5TywwbLAUDzPvtab6uJ>();
						if (hClNIa2MAAqcV9tfVNkRq6Q9UNy2 != null)
						{
							hClNIa2MAAqcV9tfVNkRq6Q9UNy2._fO7gSlrDDNMoHR4FO5QXAq8fUyA +=
								(float) (this.mouseState.ScrollWheelValue - this.previousMouseState.ScrollWheelValue) /
								num;
						}
					}

					LogHelper.LogWarn("Again, DevMode DOES NOT WORK");
				}

				if (test2)
				{
					if (InputHelper.IsReleased((_PMeRYZJaBCqgB9uADJFP3c14lxq) 2))
					{
						test2 = false;
						obj.Item1 = null;
						return;
					}

					if (obj.Item1 != null)
					{
						/*
						Microsoft.Xna.Framework.Point point2 = ModLoader.Instance.GameInstance._vsceSzSIjBy2nZrCxAzKZbUiwLq
							._e6KgAy4CTN1JFYwA88grvAEmDxX(ModLoader.Instance.GameInstance._RbWJ7YGnYHCSoD44MRW1h5X6E7E
								._U7CeYBJ1v1SoUxpX8emsQ9mWl5b);
						if (this.obj.Item1 is _QGGOTxZ8aNWGh0hc26wcmx8wmwT up4orz9jE5L118EdoBiV8uL9I5b4)
						{
							up4orz9jE5L118EdoBiV8uL9I5b4.GetType().GetMethod("_PdRLTpsImBScBFQhILtCHJpcsllA", BindingFlags.Instance | BindingFlags.NonPublic).Invoke(this,new Object[1]
							{
								point2.X + this.obj.Item2.X
							});
							// up4orz9jE5L118EdoBiV8uL9I5b4._PdRLTpsImBScBFQhILtCHJpcsllA((float) point2.X + this.obj.Item2.X);
							up4orz9jE5L118EdoBiV8uL9I5b4._loAL5ifnD5oZdNHb7JwpsEKbYFU(point2.Y + this.obj.Item2.Y);
							return;
						}
	
						_ujAkjlfN5TywwbLAUDzPvtab6uJ hClNIa2MAAqcV9tfVNkRq6Q9UNy3 =
							this.obj.Item1 as _ujAkjlfN5TywwbLAUDzPvtab6uJ;
						if (hClNIa2MAAqcV9tfVNkRq6Q9UNy3 != null)
						{
							hClNIa2MAAqcV9tfVNkRq6Q9UNy3.GetType().GetMethod("_PdRLTpsImBScBFQhILtCHJpcsllA", BindingFlags.Instance | BindingFlags.NonPublic).Invoke(this,new Object[1]
							{
								point2.X + this.obj.Item2.X
							});
							hClNIa2MAAqcV9tfVNkRq6Q9UNy3._loAL5ifnD5oZdNHb7JwpsEKbYFU((float) point2.Y + this.obj.Item2.Y);
						}
						*/

					}
				}
			}
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002880 File Offset: 0x00000A80
	
			private List<Texture2D> GetTexture(_xZgbANe7gi6i2DAhBEkKpR1QFLe npc)
			{
				IEnumerable enumerable = typeof(_xZgbANe7gi6i2DAhBEkKpR1QFLe).GetField("_uCN0rAUpYyEIvrweCRehrSN3Vsm", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(npc) as IList;
				List<Texture2D> list = new List<Texture2D>();
				foreach (object obj in enumerable)
				{
					list.Add(obj.GetType().GetField("_OzFEGvZu5tqLcitcWhX3j9pIBZM", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(obj) as Texture2D);
				}
				return list;
			}
		
			// Token: 0x06000007 RID: 7 RVA: 0x00002914 File Offset: 0x00000B14
		
			private void TestHit(Point point, List<_ujAkjlfN5TywwbLAUDzPvtab6uJ> assets)
			{
				foreach (_ujAkjlfN5TywwbLAUDzPvtab6uJ hClNIa2MAAqcV9tfVNkRq6Q9UNy in assets)
				{
					_3IHp43rpkJgOBcY9lrIrwMuwWve nebeB8680apM0Nf6CoDoIKMjFTr = hClNIa2MAAqcV9tfVNkRq6Q9UNy as _3IHp43rpkJgOBcY9lrIrwMuwWve;
					if (nebeB8680apM0Nf6CoDoIKMjFTr != null)
					{
						_QGGOTxZ8aNWGh0hc26wcmx8wmwT o3ipX9xd6EWoCvx6j5lfMrGd5RG = nebeB8680apM0Nf6CoDoIKMjFTr._4QLHHCk23T1BjK7acKxASbkCefG;
						Rectangle rectangle;
					
						rectangle.X = (int)o3ipX9xd6EWoCvx6j5lfMrGd5RG._7Xn1C5tjYnmIif1iZKV8AWsEEbL;
						rectangle.Y = (int)o3ipX9xd6EWoCvx6j5lfMrGd5RG._bCjZ3VSXGKyhmykd2zCnQBiSpDf;
						/*
						rectangle.Width = (int)((float)o3ipX9xd6EWoCvx6j5lfMrGd5RG._Y47jcTkhGiQhLlnym0IWMz0y0Qe() * o3ipX9xd6EWoCvx6j5lfMrGd5RG._83t30IhBGJYeWKtrIbO2IQqGMfW());
						rectangle.Height = (int)((float)o3ipX9xd6EWoCvx6j5lfMrGd5RG._A5pCs6IAoDy1N9ubtdQzdmWxZ7G() * o3ipX9xd6EWoCvx6j5lfMrGd5RG._83t30IhBGJYeWKtrIbO2IQqGMfW());
						*/
					
						rectangle.Width = 300;
						rectangle.Height = 600;
						if (o3ipX9xd6EWoCvx6j5lfMrGd5RG is _tfDAeR6npiqJMLRSXPO1DxGA0TgA)
						{
							rectangle.X -= rectangle.Width / 2;
							rectangle.Y -= rectangle.Height;
						}
						if (rectangle.Contains(point))
						{
							npcs.Add(o3ipX9xd6EWoCvx6j5lfMrGd5RG);
						}
					}
					else
					{
						Rectangle rectangle;
						rectangle.X = (int)hClNIa2MAAqcV9tfVNkRq6Q9UNy._7Xn1C5tjYnmIif1iZKV8AWsEEbL;
						rectangle.Y = (int)hClNIa2MAAqcV9tfVNkRq6Q9UNy._bCjZ3VSXGKyhmykd2zCnQBiSpDf;
						rectangle.Width = 300;
						rectangle.Height = 600;
						if (rectangle.Contains(point))
						{
							_assets.Add(hClNIa2MAAqcV9tfVNkRq6Q9UNy);
						}
					}
				}
			}
		
			// Token: 0x06000008 RID: 8 RVA: 0x00002A98 File Offset: 0x00000C98
			private void ClickAction()
			{
				_ETHljYp3aQy9GQ1ZAzhfOYDI1sO._8GJSgyb6FWRvKxxAcjyaU02i18E("Haha, it works", Array.Empty<object>());
				SDL.SDL_MessageBoxData sdl_MessageBoxData = new SDL.SDL_MessageBoxData
				{
					flags = SDL.SDL_MessageBoxFlags.SDL_MESSAGEBOX_ERROR,
					title = "ModLoader",
					message = "Fuck you, this mod works perfectly",
					numbuttons = 1,
					buttons = new[]
					{
						new SDL.SDL_MessageBoxButtonData
						{
							flags = SDL.SDL_MessageBoxButtonFlags.SDL_MESSAGEBOX_BUTTON_RETURNKEY_DEFAULT,
							buttonid = 0,
							text = "OK"
						}
					}
				};
				int num;
				SDL.SDL_ShowMessageBox(ref sdl_MessageBoxData, out num);
			}

			// Token: 0x06000009 RID: 9 RVA: 0x00002B2A File Offset: 0x00000D2A
			private void StickmanClickAction()
			{
				if (!PlayerHelper.GetPlayerFlag("araghon007.AmorousTestMod.StickmanTalked"))
				{
					ModLoader.Instance.LoadScene("StickmanPreDate");
					return;
				}
				ModLoader.Instance.LoadScene("StickmanQuotes");
			}

		// Token: 0x04000001 RID: 1
		private bool devmode;

		// Token: 0x04000002 RID: 2
		private FieldInfo spriteBatch;

		// Token: 0x04000003 RID: 3
		private FieldInfo spriteFont;

		// Token: 0x04000004 RID: 4
		private FieldInfo textPos;

		// Token: 0x04000005 RID: 5
		private MouseState previousMouseState;

		// Token: 0x04000006 RID: 6
		private MouseState mouseState;

		// Token: 0x04000007 RID: 7
		private bool test2;

		// Token: 0x04000008 RID: 8
		private (object, Vector2) obj;

		// Token: 0x04000009 RID: 9
		private List<_ujAkjlfN5TywwbLAUDzPvtab6uJ> _assets = new List<_ujAkjlfN5TywwbLAUDzPvtab6uJ>();

		// Token: 0x0400000A RID: 10
		private List<_QGGOTxZ8aNWGh0hc26wcmx8wmwT> npcs = new List<_QGGOTxZ8aNWGh0hc26wcmx8wmwT>();
		/*
		public void Initialize()
		{
			LogHelper.LogInfo("Mod Loading works and Initialize was called.");
		}

		public void LoadContent()
		{
			LogHelper.LogInfo("Mod Loading works and LoadContent was called.");
		}

		public void UnloadContent()
		{
			LogHelper.LogInfo("Mod Loading works and UnloadContent was called.");
		}

		public void Update(GameTime gameTime)
		{
			LogHelper.LogInfo("Mod Loading works and Update was called.");
		}

		public void Draw(GameTime gameTime)
		{
			LogHelper.LogInfo("Mod Loading works and Draw was called.");
		}
		*/
	}

}
