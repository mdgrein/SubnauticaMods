using System.Reflection;

using Harmony;

using MDMods.QuartzProcessor.Craftables;

namespace MDMods.QuartzProcessor
{
    public static class QPatch
    {
        public static void Patch()
        {
            var harmony = HarmonyInstance.Create("com.quartzprocessor");
            harmony.PatchAll(Assembly.GetExecutingAssembly());
        }
    }
}
