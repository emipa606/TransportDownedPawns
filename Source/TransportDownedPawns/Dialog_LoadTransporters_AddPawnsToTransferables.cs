using System.Reflection;
using HarmonyLib;
using RimWorld;
using RimWorld.Planet;
using Verse;

namespace TransportDownedPawns;

[HarmonyPatch(typeof(Dialog_LoadTransporters), "AddPawnsToTransferables")]
public static class Dialog_LoadTransporters_AddPawnsToTransferables
{
    private static readonly MethodInfo addToTransferablesMethod = AccessTools.Method(typeof(Dialog_LoadTransporters),
        "AddToTransferables", [typeof(Thing)]);

    public static bool Prefix(Dialog_LoadTransporters __instance, Map ___map)
    {
        var list = CaravanFormingUtility.AllSendablePawns(___map, true, true, true, true);
        foreach (var item in list)
        {
            addToTransferablesMethod.Invoke(__instance, [item]);
        }

        return false;
    }
}