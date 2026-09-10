using Digitalroot.Valheim.Common;
using HarmonyLib;
using JetBrains.Annotations;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;

namespace Digitalroot.HeightmapUnlimitedJvL
{
  [UsedImplicitly]
  public class Patch
  {
    [UsedImplicitly]
    [HarmonyPatch(typeof(TerrainComp))]
    public static class PatchTerrainComp
    {
      [HarmonyPriority(Priority.Normal)]
      [HarmonyTranspiler, HarmonyPatch(typeof(TerrainComp), nameof(TerrainComp.LevelTerrain))]
      // ReSharper disable once InconsistentNaming
      public static IEnumerable<CodeInstruction> TerrainCompLevelTerrainTranspiler(IEnumerable<CodeInstruction> instructions)
      {
        Log.Trace(Main.Instance, $"{Main.Namespace}.{MethodBase.GetCurrentMethod()?.DeclaringType?.Name}.{MethodBase.GetCurrentMethod()?.Name}");
        foreach (var codeInstruction in instructions)
        {
          if (codeInstruction.Is(OpCodes.Ldc_R4, -8f))
          {
            yield return new CodeInstruction(OpCodes.Call, AccessTools.Method(typeof(Main), nameof(Main.Min)));
            continue;
          }

          if (codeInstruction.Is(OpCodes.Ldc_R4, 8f))
          {
            yield return new CodeInstruction(OpCodes.Call, AccessTools.Method(typeof(Main), nameof(Main.Max)));
            continue;
          }

          yield return codeInstruction;
        }
      }

      [HarmonyPriority(Priority.Normal)]
      [HarmonyTranspiler, HarmonyPatch(typeof(TerrainComp), nameof(TerrainComp.RaiseTerrain))]
      // [HarmonyDebug]
      // ReSharper disable once IdentifierTypo
      public static IEnumerable<CodeInstruction> TerrainCompRaiseTerrainTranspiler(IEnumerable<CodeInstruction> instructions)
      {
        foreach (var codeInstruction in instructions)
        {
          if (codeInstruction.Is(OpCodes.Ldc_R4, -8f))
          {
            yield return new CodeInstruction(OpCodes.Call, AccessTools.Method(typeof(Main), nameof(Main.Min)));
            continue;
          }

          if (codeInstruction.Is(OpCodes.Ldc_R4, 8f))
          {
            yield return new CodeInstruction(OpCodes.Call, AccessTools.Method(typeof(Main), nameof(Main.Max)));
            continue;
          }

          yield return codeInstruction;
        }
      }

      [HarmonyPriority(Priority.Normal)]
      [HarmonyTranspiler, HarmonyPatch(typeof(TerrainComp), nameof(TerrainComp.ApplyToHeightmap))]
      // [HarmonyDebug]
      // ReSharper disable once IdentifierTypo
      public static IEnumerable<CodeInstruction> TerrainCompApplyToHeightmapTranspiler(IEnumerable<CodeInstruction> instructions)
      {
        var i = 0;
        foreach (var codeInstruction in instructions)
        {
          if (codeInstruction.Is(OpCodes.Ldc_R4, 8f))
          {
            if (i == 0)
            {
              yield return new CodeInstruction(OpCodes.Call, AccessTools.Method(typeof(Main), nameof(Main.MinAbs)));
            }
            else
            {
              yield return new CodeInstruction(OpCodes.Call, AccessTools.Method(typeof(Main), nameof(Main.Max)));
            }

            i++;
            continue;
          }

          yield return codeInstruction;
        }
      }
    }
  }
}
