using MelonLoader;
using BTD_Mod_Helper;
using infiniteCash;
using BubbleGum_Monkey;
using BTD_Mod_Helper.Api.ModOptions;
using BTD_Mod_Helper.Api.Towers;
using Il2CppAssets.Scripts.Unity;
using BTD_Mod_Helper.Extensions;

[assembly: MelonInfo(typeof(infiniteCash.infiniteCash), ModHelperData.Name, ModHelperData.Version, ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]

namespace infiniteCash;

public class infiniteCash : BloonsTD6Mod
{
    public override void OnApplicationStart()
    {
        ModHelper.Msg<infiniteCash>("infiniteCash loaded!");


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