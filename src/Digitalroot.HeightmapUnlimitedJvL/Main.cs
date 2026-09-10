using BepInEx;
using BepInEx.Configuration;
using Digitalroot.Valheim.Common;
using HarmonyLib;
using JetBrains.Annotations;
using Jotunn.Utils;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;

namespace Digitalroot.HeightmapUnlimitedJvL
{
  [BepInPlugin(Guid, Name, Version)]
  [BepInDependency(Jotunn.Main.ModGuid)]
  [NetworkCompatibility(CompatibilityLevel.ServerMustHaveMod, VersionStrictness.Patch)]
  [SuppressMessage("ReSharper", "MemberCanBePrivate.Global")]
  public partial class Main : BaseUnityPlugin, ITraceableLogging
  {
    private Harmony _harmony;

    [UsedImplicitly]
    public static ConfigEntry<int> NexusId;
    public static ConfigEntry<float> MaxHeight;
    public static ConfigEntry<float> MinHeight;

    public static float Min() => MinHeight.Value;
    public static float MinAbs() => Math.Abs(MinHeight.Value);
    public static float Max() => MaxHeight.Value;

    public static Main Instance;

    public Main()
    {
      try
      {
        Instance = this;
        #if DEBUG
        EnableTrace = true;
        Log.RegisterSource(Instance);
        #else
        EnableTrace = false;
        #endif
        Log.Trace(Instance, $"{Namespace}.{MethodBase.GetCurrentMethod()?.DeclaringType?.Name}.{MethodBase.GetCurrentMethod()?.Name}");
      }
      catch (Exception ex)
      {
        ZLog.LogError(ex);
      }
    }

    [UsedImplicitly]
    private void Awake()
    {
      try
      {
        Log.Trace(Instance, $"{Namespace}.{MethodBase.GetCurrentMethod()?.DeclaringType?.Name}.{MethodBase.GetCurrentMethod()?.Name}");
        NexusId = Config.Bind("General", "NexusID", 3612, new ConfigDescription("Nexus mod ID for updates", null, new ConfigurationManagerAttributes { Browsable = false, ReadOnly = true }));
        InitializeConfig();
        if (Valheim.Common.Utils.IsHeadless()) return;
        _harmony = Harmony.CreateAndPatchAll(typeof(Main).Assembly, Guid);
      }
      catch (Exception e)
      {
        Log.Error(Instance, e);
      }
    }

    private void InitializeConfig()
    {
      Config.SaveOnConfigSet = true;
      NexusId   = Config.Bind("General", "NexusID",    3612, new ConfigDescription("Nexus mod ID for updates", null, new ConfigurationManagerAttributes { IsAdminOnly = false, Browsable = false, ReadOnly = true }));
      MaxHeight = Config.Bind("General", "Max Height", 200f, new ConfigDescription("How high you can stack up relative to the heightmap's original position.", new AcceptableValueRange<float>(1, 200), new ConfigurationManagerAttributes { IsAdminOnly = true, Browsable = true}));
      MinHeight = Config.Bind("General", "Min Height",-200f, new ConfigDescription("How far you can dig down relative to the heightmap's original position.", new AcceptableValueRange<float>(-200, -1), new ConfigurationManagerAttributes { IsAdminOnly = true, Browsable = true}));
    }

    [UsedImplicitly]
    private void OnDestroy()
    {
      try
      {
        Log.Trace(Instance, $"{Namespace}.{MethodBase.GetCurrentMethod()?.DeclaringType?.Name}.{MethodBase.GetCurrentMethod()?.Name}");
        _harmony?.UnpatchSelf();
      }
      catch (Exception e)
      {
        Log.Error(Instance, e);
      }
    }

    #region Implementation of ITraceableLogging

    /// <inheritdoc />
    public string Source => Namespace;

    /// <inheritdoc />
    public bool EnableTrace { get; }

    #endregion
  }
}
