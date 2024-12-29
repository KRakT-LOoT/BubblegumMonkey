using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using BubblegumMonkey;
using Il2CppAssets.Scripts.Models.Bloons.Behaviors;
using Il2CppAssets.Scripts.Models.Towers;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Emissions;
using Il2CppAssets.Scripts.Models.Towers.Filters;
using Il2CppAssets.Scripts.Models.Towers.Projectiles.Behaviors;
using Octokit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BubblegumMonkey.TestingMonkey;

namespace BubblegumMonkey.Upgrades.BottomPath
{
    internal class TestingUpgradesBottomPath1 : ModUpgrade<TestingMonkey>
    {
        public override int Path => 2;

        public override int Tier => 1;

        public override int Cost => 170;
        public override string Description => "Spicy Gum deal Damage over Time to the Bloons";
        public override string DisplayName => "Spicy Gum";

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            var weapon = towerModel.GetWeapon();
            var proj = weapon.projectile;
            var stuck = proj.GetBehaviors<CreateProjectileOnExhaustFractionModel>()[0].projectile;
            stuck.GetBehaviors<AddBehaviorToBloonModel>()[0].GetBehavior<DamageOverTimeModel>().interval /= 8;
            stuck.GetBehaviors<AddBehaviorToBloonModel>()[0].GetBehavior<DamageOverTimeModel>().Interval /= 8;
            stuck.GetBehaviors<AddBehaviorToBloonModel>()[1].GetBehavior<DamageOverTimeModel>().interval /= 8;
            stuck.GetBehaviors<AddBehaviorToBloonModel>()[1].GetBehavior<DamageOverTimeModel>().Interval /= 8;
            stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<AddBehaviorToBloonModel>().GetBehavior<DamageOverTimeModel>().interval /= 8;
            stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<AddBehaviorToBloonModel>().GetBehavior<DamageOverTimeModel>().Interval /= 8;
            var pro = towerModel.GetWeapon().projectile.GetBehaviors<CreateProjectileOnExhaustFractionModel>()[1].projectile;
            pro.GetBehavior<CreateProjectileOnContactModel>().projectile.GetDamageModel().damage += 1;
            stuck.radius *= 1.2f;
            stuck.GetBehavior<CreateProjectileOnContactModel>().projectile.radius *= 1.2f;
            pro.GetBehavior<CreateProjectileOnContactModel>().projectile.radius *= 1.2f;
        }
    }
    internal class TestingUpgradesBottomPath2 : ModUpgrade<TestingMonkey>
    {
        public override int Path => 2;

        public override int Tier => 2;

        public override int Cost => 355;
        public override string Description => "Corrosive Gum can melt through Bloons even faster than before. Melts through Camo just as fast";
        public override string DisplayName => "Corrosive Gum";
        public override void ApplyUpgrade(TowerModel towerModel)
        {
            var weapon = towerModel.GetWeapon();
            var proj = weapon.projectile;
            var stuck = proj.GetBehaviors<CreateProjectileOnExhaustFractionModel>()[0].projectile;
            stuck.GetBehaviors<AddBehaviorToBloonModel>()[0].GetBehavior<DamageOverTimeModel>().interval *= 0.25f;
            stuck.GetBehaviors<AddBehaviorToBloonModel>()[0].GetBehavior<DamageOverTimeModel>().Interval *= 0.25f;
            stuck.GetBehaviors<AddBehaviorToBloonModel>()[1].GetBehavior<DamageOverTimeModel>().interval *= 0.25f;
            stuck.GetBehaviors<AddBehaviorToBloonModel>()[1].GetBehavior<DamageOverTimeModel>().Interval *= 0.25f;
            stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<AddBehaviorToBloonModel>().GetBehavior<DamageOverTimeModel>().interval *= 0.25f;
            stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<AddBehaviorToBloonModel>().GetBehavior<DamageOverTimeModel>().Interval *= 0.25f;
            var pro = towerModel.GetWeapon().projectile.GetBehaviors<CreateProjectileOnExhaustFractionModel>()[1].projectile;
            pro.GetBehavior<CreateProjectileOnContactModel>().projectile.GetDamageModel().damage += 1;
            towerModel.GetDescendants<FilterInvisibleModel>().ForEach(model => model.isActive = false);
            towerModel.range *= 1.2f;
            towerModel.GetAttackModel().range *= 1.2f;
            stuck.radius *= 1.2f;
            stuck.GetBehavior<CreateProjectileOnContactModel>().projectile.radius *= 1.2f;
            pro.GetBehavior<CreateProjectileOnContactModel>().projectile.radius *= 1.2f;
        }
    }
    internal class TestingUpgradesBottomPath3 : ModUpgrade<TestingMonkey>
    {
        public override int Path => 2;

        public override int Tier => 3;

        public override int Cost => 2630;
        public override string Description => "Took all this time just to pop lead. Also does extra DoT damage.";
        public override string DisplayName => "The Scorcher";

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            var weapon = towerModel.GetWeapon();
            var proj = weapon.projectile;
            var stuck = proj.GetBehaviors<CreateProjectileOnExhaustFractionModel>()[0].projectile;
            stuck.GetBehaviors<AddBehaviorToBloonModel>()[0].GetBehavior<DamageOverTimeModel>().interval *= 2/3f;
            stuck.GetBehaviors<AddBehaviorToBloonModel>()[0].GetBehavior<DamageOverTimeModel>().Interval *= 2 / 3f;
            stuck.GetBehaviors<AddBehaviorToBloonModel>()[0].GetBehavior<DamageOverTimeModel>().damage *= 2f;
            stuck.GetBehaviors<AddBehaviorToBloonModel>()[1].GetBehavior<DamageOverTimeModel>().damage *= 2f;
            stuck.GetBehaviors<AddBehaviorToBloonModel>()[1].GetBehavior<DamageOverTimeModel>().interval *= 2 / 3f;
            stuck.GetBehaviors<AddBehaviorToBloonModel>()[1].GetBehavior<DamageOverTimeModel>().Interval *= 2 / 3f;
            stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<AddBehaviorToBloonModel>().GetBehavior<DamageOverTimeModel>().interval *= 2 / 3f;
            stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<AddBehaviorToBloonModel>().GetBehavior<DamageOverTimeModel>().damage *= 2f;
            stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<AddBehaviorToBloonModel>().GetBehavior<DamageOverTimeModel>().Interval *= 2 / 3f;
            var pro = towerModel.GetWeapon().projectile.GetBehaviors<CreateProjectileOnExhaustFractionModel>()[1].projectile;
            pro.GetBehavior<CreateProjectileOnContactModel>().projectile.GetDamageModel().damage += 1;
            pro.GetBehavior<CreateProjectileOnContactModel>().projectile.GetDamageModel().immuneBloonProperties = (Il2Cpp.BloonProperties)0;
            pro.GetBehavior<CreateProjectileOnContactModel>().projectile.GetDamageModel().immuneBloonPropertiesOriginal = (Il2Cpp.BloonProperties)0;
            towerModel.range *= 1.2f;
            towerModel.GetAttackModel().range *= 1.2f;
            stuck.radius *= 1.2f;
            stuck.GetBehavior<CreateProjectileOnContactModel>().projectile.radius *= 1.2f;
            pro.GetBehavior<CreateProjectileOnContactModel>().projectile.radius *= 1.2f;

        }
    }
    internal class TestingUpgradesBottomPath4 : ModUpgrade<TestingMonkey>
    {
        public override int Path => 2;

        public override int Tier => 4;

        public override int Cost => 6000;
        public override string Description => "Getting Really Dangerous now. Should we even be chewing this???";
        public override string DisplayName => "Mouth Liquifier";

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            var weapon = towerModel.GetWeapon();
            var proj = weapon.projectile;
            var stuck = proj.GetBehaviors<CreateProjectileOnExhaustFractionModel>()[0].projectile;
            stuck.GetBehaviors<AddBehaviorToBloonModel>()[0].GetBehavior<DamageOverTimeModel>().interval *= 0.5f;
            stuck.GetBehaviors<AddBehaviorToBloonModel>()[0].GetBehavior<DamageOverTimeModel>().Interval *= 0.5f;
            stuck.GetBehaviors<AddBehaviorToBloonModel>()[0].GetBehavior<DamageOverTimeModel>().damage *= 1.5f;
            stuck.GetBehaviors<AddBehaviorToBloonModel>()[1].GetBehavior<DamageOverTimeModel>().damage *= 1.5f;
            stuck.GetBehaviors<AddBehaviorToBloonModel>()[1].GetBehavior<DamageOverTimeModel>().interval *= 0.5f;
            stuck.GetBehaviors<AddBehaviorToBloonModel>()[1].GetBehavior<DamageOverTimeModel>().Interval *= 0.5f;
            stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<AddBehaviorToBloonModel>().GetBehavior<DamageOverTimeModel>().interval *= 0.5f;
            stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<AddBehaviorToBloonModel>().GetBehavior<DamageOverTimeModel>().damage *= 1.5f;
            stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<AddBehaviorToBloonModel>().GetBehavior<DamageOverTimeModel>().Interval *= 0.5f;
            var pro = towerModel.GetWeapon().projectile.GetBehaviors<CreateProjectileOnExhaustFractionModel>()[1].projectile;
            pro.GetBehavior<CreateProjectileOnContactModel>().projectile.GetDamageModel().damage += 1;
            towerModel.range *= 1.2f;
            towerModel.GetAttackModel().range *= 1.2f;
            stuck.radius *= 1.2f;
            stuck.GetBehavior<CreateProjectileOnContactModel>().projectile.radius *= 1.2f;
            pro.GetBehavior<CreateProjectileOnContactModel>().projectile.radius *= 1.2f;
        }
    }
    internal class TestingUpgradesBottomPath5 : ModUpgrade<TestingMonkey>
    {
        public override int Path => 2;

        public override int Tier => 5;

        public override int Cost => 15666;
        public override string Description => "Where did you even find this?";
        public override string DisplayName => "Nuclear Gum";

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            var weapon = towerModel.GetWeapon();
            var proj = weapon.projectile;
            var stuck = proj.GetBehaviors<CreateProjectileOnExhaustFractionModel>()[0].projectile;
            stuck.GetBehaviors<AddBehaviorToBloonModel>()[0].GetBehavior<DamageOverTimeModel>().interval *= 0.40f;
            stuck.GetBehaviors<AddBehaviorToBloonModel>()[0].GetBehavior<DamageOverTimeModel>().Interval *= 0.40f;
            stuck.GetBehaviors<AddBehaviorToBloonModel>()[0].GetBehavior<DamageOverTimeModel>().damage *= 2f;
            stuck.GetBehaviors<AddBehaviorToBloonModel>()[1].GetBehavior<DamageOverTimeModel>().damage *= 2f;
            stuck.GetBehaviors<AddBehaviorToBloonModel>()[1].GetBehavior<DamageOverTimeModel>().interval *= 0.40f;
            stuck.GetBehaviors<AddBehaviorToBloonModel>()[1].GetBehavior<DamageOverTimeModel>().Interval *= 0.40f;
            stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<AddBehaviorToBloonModel>().GetBehavior<DamageOverTimeModel>().interval *= 0.40f;
            stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<AddBehaviorToBloonModel>().GetBehavior<DamageOverTimeModel>().damage *= 2f;
            stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<AddBehaviorToBloonModel>().GetBehavior<DamageOverTimeModel>().Interval *= 0.40f;
            var pro = towerModel.GetWeapon().projectile.GetBehaviors<CreateProjectileOnExhaustFractionModel>()[1].projectile;
            pro.GetBehavior<CreateProjectileOnContactModel>().projectile.GetDamageModel().damage += 1;
            towerModel.range *= 1.2f;
            towerModel.GetAttackModel().range *= 1.2f;
            stuck.radius *= 1.2f;
            stuck.GetBehavior<CreateProjectileOnContactModel>().projectile.radius *= 1.2f;
            pro.GetBehavior<CreateProjectileOnContactModel>().projectile.radius *= 1.2f;
        }
    }
}
