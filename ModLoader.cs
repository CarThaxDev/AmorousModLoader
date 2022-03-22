// Decompiled with JetBrains decompiler
// Type: Amorous.Mod.ModLoader
// Assembly: Amorous.Mod, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 3274B8A3-D550-40ED-AEFB-01185EA8A335
// Assembly location: C:\Users\demon\Downloads\amorous\amorous\amorous\Amorous.Mod.dll

using Amorous.Mod.Helpers;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace Amorous.Mod
{
  /// <summary>Yup, it's real</summary>
  public class ModLoader
  {
    /// <summary>Game</summary>
    public Microsoft.Xna.Framework.Game Game;
    private readonly FakeGameInstance _fakeInstance;
    private readonly List<IModBase> _modList;
    private List<Type> _npcList;
    /// <summary>Instance of this class, there can only be one</summary>
    public static ModLoader Instance;

    /// <summary>
    /// Amorous game instance, lots of obfuscated stuff, might release deobfuscated version if anyone finds this text
    /// </summary>
    public _JbeCmOie0phb2cbgG6DdGZrbs3pB GameInstance { get; private set; }

    /// <summary>Vanilla content manager, points to Content-Release</summary>
    public ContentManager ContentManager => this.GameInstance._uwNDZuqdFb9tyQtlQMxiz1DQ7x8;

    /// <summary>Mod content manager, points to Content-Mods</summary>
    public ModContentManager ModContentManager { get; private set; }

    /// <summary>Gets the current scene</summary>
    /// <example>
    /// In order to add an NPC to the current scene you would do something like
    /// <code>
    /// if (ModLoader.Instance.CurrentScene is ClubUpstairsScene clubUpstairsScene)
    /// {
    ///     var npcLayer = GetNPCLayer(clubUpstairsScene, nameof(NPC));
    ///     if (npcLayer == null)
    ///     {
    ///         var npc = ModLoader.Instance.AddNPC&lt;NPC&gt;(_bRA4WJRW7AfFyNcbS8anXPvTZZc.Background);
    ///         if (npc != null)
    ///         {
    ///             npc.Click = NPCClickAction;
    ///             npc.X = 1000f;
    ///             npc.Y = 125f;
    ///         }
    ///     }
    /// }
    /// </code>
    /// </example>
    public _7UlnfykmEmZDFt3BmCKZekI43Ih CurrentScene => this.GameInstance._XbOXR6AypLIdJ3gBMGseGi3Wi2i;

    /// <summary>Gets an NPC layer from specified scene</summary>
    /// <param name="scene">Scene</param>
    /// <param name="npcName">NPC name</param>
    /// <returns>NPC layer</returns>
    public static _3IHp43rpkJgOBcY9lrIrwMuwWve GetNPCLayer(
      _7UlnfykmEmZDFt3BmCKZekI43Ih scene,
      string npcName)
    {
      return scene._VvFE2zgy4FbDjvaEvb67tXJ7aRm(npcName);
    }

    /// <summary>Constructor</summary>
    /// <param name="game">FNA Game</param>
    /// <param name="gameInstance">Amorous game instance</param>
    public ModLoader(Microsoft.Xna.Framework.Game game, _JbeCmOie0phb2cbgG6DdGZrbs3pB gameInstance)
    {
      this.GameInstance = gameInstance;
      this.Game = game;
      this._fakeInstance = new FakeGameInstance(this);
      ModLoader.Instance = this;
      this._modList = new List<IModBase>();
      this._npcList = new List<Type>();
      string str = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Content-Mods");
      if (!Directory.Exists(str))
      {
        Directory.CreateDirectory(str);
      }

      LogHelper.LogInfo(str);
      foreach (string file in Directory.GetFiles(str, "*.dll", SearchOption.TopDirectoryOnly))
      {
        LogHelper.LogInfo(file);
        try
        {
          Assembly assembly = Assembly.LoadFile(file);
          bool flag = false;
          foreach (Type type in ((IEnumerable<Type>) assembly.GetTypes()).Where<Type>((Func<Type, bool>) (test => ((IEnumerable<Type>) test.GetInterfaces()).Contains<Type>(typeof (IModBase)))))
          {
            this._modList.Add(Activator.CreateInstance(type) as IModBase);
            flag = true;
          }
          if (!flag)
          {
            LogHelper.LogError("Could not find an implementation of IModBase in assembly " + assembly.FullName + "!");
          }
          else
          {
            foreach (Type type in assembly.GetTypes())
            {
              if (typeof (_QGGOTxZ8aNWGh0hc26wcmx8wmwT).IsAssignableFrom(type))
                this._npcList.Add(type);
            }
            LogHelper.LogInfo("Successfully loaded assembly " + assembly.FullName);
          }
        }
        catch (FileLoadException ex)
        {
          LogHelper.LogError(ex.FileName + " is already loaded!");
        }
        catch (BadImageFormatException ex)
        {
          LogHelper.LogError(ex.FileName + " is not a valid assembly!");
        }
      }
    }

    /// <summary>Initialize</summary>
    public void Initialize()
    {
      this.ModContentManager = new ModContentManager(this.Game.Content.ServiceProvider, this.Game.Content.RootDirectory);
      foreach (IModBase mod in this._modList)
        mod?.Initialize();
    }

    /// <summary>Load</summary>
    public void LoadContent()
    {
      foreach (IModBase mod in this._modList)
        mod?.LoadContent();
    }

    /// <summary>Unload</summary>
    public void UnloadContent()
    {
      foreach (IModBase mod in this._modList)
        mod?.UnloadContent();
    }

    /// <summary>Update</summary>
    /// <param name="gameTime">Time</param>
    public void Update(GameTime gameTime)
    {
      foreach (IModBase mod in this._modList)
        mod?.Update(gameTime);
    }

    /// <summary>Draw</summary>
    /// <param name="gameTime">Time</param>
    public void Draw(GameTime gameTime)
    {
      foreach (IModBase mod in this._modList)
        mod?.Draw(gameTime);
    }

    /// <summary>
    /// Loads a cutscene (Data/Quests) use filename without extension
    /// </summary>
    /// <param name="name">Name of the cutscene (quest) to load</param>
    public void LoadScene(string name) => this.GameInstance._xyl3Tv5KdR5eezDgagxbBcS3cwt(LoadCutscene(name));

    private _nR8eroJOHehP0ZGyyTveo6aMTHg LoadCutscene(string string_2)
    {
      string path1 = string.Format("Content-Mods/Data/Quests/{0}.json", (object) string_2);
      string path2 = string.Format("{0}/Data/Quests/{1}.json", (object) this.Game.Content.RootDirectory, (object) string_2);
      string str;
      if (!File.Exists(path1))
      {
        if (!File.Exists(path2))
        {
          LogHelper.LogError("Failed to load cutscene '" + string_2 + "'");
          return null;
        }
        str = _K2047A8SCJdaw0LZKStEHOiH110._GxOfTBefEUfWKWaWgxVRKsjugxE(path2);
      }
      else
      {
        LogHelper.LogWarn("Loaded modded cutscene '" + string_2 + "'");
        str = _K2047A8SCJdaw0LZKStEHOiH110._mDCA4AzhICQie5tejcL2uH7mcwf(path1);
      }
      JsonSerializerSettings serializerSettings = new JsonSerializerSettings();
      serializerSettings.TypeNameHandling = TypeNameHandling.Auto;
      serializerSettings.Converters.Add((JsonConverter) new _VSQz6uDf5A6KqE8xqKxxcrkhZkA());
      JsonSerializerSettings settings = serializerSettings;
      _0SvCRe0EgzR9DhI3QPe1GUqubAt zfcM84VaYogm9W10lC = JsonConvert.DeserializeObject<_0SvCRe0EgzR9DhI3QPe1GUqubAt>(str, settings);
      if (zfcM84VaYogm9W10lC == null)
        return null;
      return new _nR8eroJOHehP0ZGyyTveo6aMTHg((_JbeCmOie0phb2cbgG6DdGZrbs3pB) this._fakeInstance, zfcM84VaYogm9W10lC, new Assembly[2]
      {
        Assembly.Load("Amorous.Game"),
        Assembly.Load("Amorous.Mod")
      });
    }

    /// <summary>Adds an NPC to current scene</summary>
    /// <typeparam name="T">NPC Type</typeparam>
    /// <param name="layerType">Which layer to put the NPC on</param>
    /// <returns>NPC instance</returns>
    public T AddNPC<T>(_a2qVgWDIm3fBp49WubttSTPsx8K layerType) where T : _QGGOTxZ8aNWGh0hc26wcmx8wmwT => this.AddNPC(typeof (T).Name, layerType, typeof (T)) as T;

    /// <summary>Adds an NPC to current scene</summary>
    /// <param name="name">NPC Name</param>
    /// <param name="layerType">Which layer to put the NPC on</param>
    /// <param name="npcType">Used when creating a modded NPC</param>
    /// <returns>NPC Instance</returns>
    public _QGGOTxZ8aNWGh0hc26wcmx8wmwT AddNPC(string name,_a2qVgWDIm3fBp49WubttSTPsx8K layerType, Type npcType = null)
    {
      if (this.GameInstance._XbOXR6AypLIdJ3gBMGseGi3Wi2i == null) return null;
      _3IHp43rpkJgOBcY9lrIrwMuwWve m0Nf6CoDoIkMjFtr = this.GameInstance._XbOXR6AypLIdJ3gBMGseGi3Wi2i._VvFE2zgy4FbDjvaEvb67tXJ7aRm(name);
      if (m0Nf6CoDoIkMjFtr != null)
      {
        _QGGOTxZ8aNWGh0hc26wcmx8wmwT ewoCvx6j5lfMrGd5Rg = m0Nf6CoDoIkMjFtr._4QLHHCk23T1BjK7acKxASbkCefG;
        if (ewoCvx6j5lfMrGd5Rg != null && ewoCvx6j5lfMrGd5Rg._SC7QlorMIWTLSkD757wC7ybszpE)
          return  null;
        m0Nf6CoDoIkMjFtr._dPmC8tBC0iph2YBAFmztEsmwUdSA = layerType == _a2qVgWDIm3fBp49WubttSTPsx8K.None ? m0Nf6CoDoIkMjFtr._dPmC8tBC0iph2YBAFmztEsmwUdSA : layerType;
        m0Nf6CoDoIkMjFtr._ac2H6kMdrgPhXXxabsikjji4SiT = m0Nf6CoDoIkMjFtr._dPmC8tBC0iph2YBAFmztEsmwUdSA == _a2qVgWDIm3fBp49WubttSTPsx8K.Background ? 1 : 3;
        this.GameInstance._XbOXR6AypLIdJ3gBMGseGi3Wi2i._yMMFQ2n4dqXlB1AEzmdkoKkPkX5();
        return m0Nf6CoDoIkMjFtr._4QLHHCk23T1BjK7acKxASbkCefG;
      }
      Type type = npcType;
      if (type == (Type) null)
        type = this._npcList.FirstOrDefault<Type>((Func<Type, bool>) (type0 => type0.Name == name));
      if (type == (Type) null)
      {
        _QGGOTxZ8aNWGh0hc26wcmx8wmwT l118EdoBiV8uL9I5b = this.GameInstance._TwQHHdbdRFRy2ctTZabNfz1Htrg(name, layerType);
        if (l118EdoBiV8uL9I5b != null)
          return l118EdoBiV8uL9I5b;
        LogHelper.LogError("Failed to load modded npc '" + name + "'");
        return null;
      }
      if (!(Activator.CreateInstance(type, (object) this.GameInstance, (object) this) is _QGGOTxZ8aNWGh0hc26wcmx8wmwT instance))
      {
        LogHelper.LogError("Failed to instance modded npc '" + name + "'");
        return null;
      }
      instance._ZzBuoSDMWwerejOO9Goyv2OCKgE = this.GameInstance;    
      instance._g9Sx54kMPiHz5jrqWh4Kb1pTijH();
      this.GameInstance._XbOXR6AypLIdJ3gBMGseGi3Wi2i._gWHVDvr9GDtRXP2zf2Md18MgZ4b(instance, layerType == _a2qVgWDIm3fBp49WubttSTPsx8K.None ? _a2qVgWDIm3fBp49WubttSTPsx8K.Background : layerType);
      return instance;
    }
  }
}
