using MelonLoader;
using BTD_Mod_Helper;
using BubblegumMonkey;
using BubblegumMonkey;
using BTD_Mod_Helper.Api.ModOptions;
using BTD_Mod_Helper.Api.Towers;
using Il2CppAssets.Scripts.Unity;
using BTD_Mod_Helper.Extensions;

[assembly: MelonInfo(typeof(BubblegumMonkey.BubblegumMonkey), ModHelperData.Name, ModHelperData.Version, ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]

namespace BubblegumMonkey;

public class BubblegumMonkey : BloonsTD6Mod
{
    public override void OnApplicationStart()
    {
        ModHelper.Msg<BubblegumMonkey>("BubblegumMonkey loaded!");


    }
    public static ParagonMode idk(bool x)
    {
        var i = ParagonMode.None;
        if (x)
        {
            return ParagonMode.Base555;
        }
        return i;
    }

    public static readonly ModSettingCategory Category = "Paragon?";
    public static readonly ModSettingBool Paragon = new(false)
    {
        description = "Currently uses Boomerang Paragon Display, and doesn't have full functionality (Kinda OP)1. Will fix soon",
        requiresRestart = true,
        category = Category
    };


}