using System.Reflection;
using HarmonyLib;
using Verse;

namespace TransportDownedPawns;

[StaticConstructorOnStartup]
public class Main
{
    static Main()
    {
        new Harmony("com.github.duhranged.rimworld.mod.transportdownedpawns").PatchAll(Assembly.GetExecutingAssembly());
    }
}