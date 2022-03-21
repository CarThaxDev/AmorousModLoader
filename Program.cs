// Decompiled with JetBrains decompiler
// Type: Program
// Assembly: Amorous.Game.Mod.Windows, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B3839EFC-669C-411A-A58C-5C56D8B36777
// Assembly location: C:\Users\demon\Downloads\amorous\amorous\amorous\Amorous.Game.Mod.Windows.exe

using Microsoft.Xna.Framework;
using SDL2;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;

public static class Program
{
  [DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
  private static extern void AddDllDirectory(string newDirectory);

  [STAThread]
  public static void Main(string[] args)
  {
    Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
    Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en-US");
    Program.SetDefaultDllDirectories(4096U);
    Program.AddDllDirectory(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, Environment.Is64BitProcess ? "x64" : "x86"));
    _ETHljYp3aQy9GQ1ZAzhfOYDI1sO._oD87G7SXjsTukw7IVWxVlVFEgvA();
    FNALoggerEXT.LogInfo = new Action<string>(Program.Log.LogInfo);
    FNALoggerEXT.LogWarn = new Action<string>(Program.Log.LogWarn);
    FNALoggerEXT.LogError = new Action<string>(Program.Log.LogError);
    Environment.SetEnvironmentVariable("FNA_OPENGL_DISABLE_LATESWAPTEAR", "1");
    try
    {
      int num = ((IEnumerable<string>) args).Contains<string>("-safemode") ? 1 : 0;
      if (((IEnumerable<string>) args).Contains<string>("-disablesound"))
        Environment.SetEnvironmentVariable("FNA_AUDIO_DISABLE_SOUND", "1");
      using (MainGame mainGame = new MainGame(num != 0))
        mainGame.Run();
    }
    catch (Exception ex)
    {
      Program.ReportException(ex);
    }
  }

  [DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
  private static extern bool SetDefaultDllDirectories(uint directoryFlags);

  private static void ReportException(Exception e)
  {
    _ETHljYp3aQy9GQ1ZAzhfOYDI1sO._0rEYVY1cDKfLPVuLw54UlaIts2m(string.Format("Unhandled exception: {0}", (object) e));
    string str = e.GetType().FullName + ": " + e.Message + "\n\n";
    SDL.SDL_MessageBoxData sdlMessageBoxData = new SDL.SDL_MessageBoxData();
    sdlMessageBoxData.flags = SDL.SDL_MessageBoxFlags.SDL_MESSAGEBOX_ERROR;
    sdlMessageBoxData.title = "Oh no, a crash!";
    sdlMessageBoxData.message = str;
    sdlMessageBoxData.numbuttons = 1;
    // ISSUE: explicit reference operation
    sdlMessageBoxData.buttons = new SDL.SDL_MessageBoxButtonData[1]
    {
      new SDL.SDL_MessageBoxButtonData()
      {
        flags = SDL.SDL_MessageBoxButtonFlags.SDL_MESSAGEBOX_BUTTON_RETURNKEY_DEFAULT,
        buttonid = 0,
        text = "OK"
      }
    };
    SDL.SDL_MessageBoxData messageboxdata = sdlMessageBoxData;
    SDL.SDL_ShowMessageBox(ref messageboxdata, out int _);
  }

  private static class Log
  {
    internal static void LogInfo(string message) => _ETHljYp3aQy9GQ1ZAzhfOYDI1sO._8GJSgyb6FWRvKxxAcjyaU02i18E(message);

    internal static void LogWarn(string message) => _ETHljYp3aQy9GQ1ZAzhfOYDI1sO._IGmWy5uYuv50rXGtBNbMPGzJhWh(message);

    internal static void LogError(string message) => _ETHljYp3aQy9GQ1ZAzhfOYDI1sO._0rEYVY1cDKfLPVuLw54UlaIts2m(message);
  }
}
