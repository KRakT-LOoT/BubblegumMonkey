using Il2CppAssets.Scripts.Models.Towers;
using Il2CppAssets.Scripts.Models.TowerSets;
using Il2CppAssets.Scripts.Unity.Display;
using Il2CppAssets.Scripts.Models.Towers.Projectiles.Behaviors;
using Il2CppAssets.Scripts.Unity;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Emissions;
using Il2CppAssets.Scripts.Models.Towers.Mods;
using Il2CppAssets.Scripts.Models.Bloons.Behaviors;
using System;
using Il2CppAssets.Scripts.Models.Towers.Projectiles;
using Il2CppAssets.Scripts.Models.Towers.Behaviors;
using BTD_Mod_Helper.Api.Display;
using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Api.Components;
using BTD_Mod_Helper.Extensions;
using BTD_Mod_Helper;
using BTD_Mod_Helper.Api.ModOptions;
using System.Reflection.Metadata;
using BubblegumMonkey;
using Il2CppAssets.Scripts.Data.ParagonData;

namespace BubblegumMonkey
{


    internal class TestingMonkey : ModTower
    {
        public override TowerSet TowerSet => TowerSet.Primary;
        public override bool Use2DModel => true;
        public override string BaseTower => TowerType.Alchemist;
        public override int Cost => 450;
        public override int TopPathUpgrades => 5;
        public override int MiddlePathUpgrades => 5;
        public override int BottomPathUpgrades => 5;
        public override string Description => "Tower Hit Damage and Blast Radius Increases With EVERY upgrade!!!";
        public override string DisplayName => "Bubblegum Monkey";
        public override ParagonMode ParagonMode => BubblegumMonkey.idk(BubblegumMonkey.Paragon);


        public override void ModifyBaseTowerModel(TowerModel towerModel)
        {
            var attack = towerModel.GetAttackModel();
            var weapon = towerModel.GetWeapon();
            var project = weapon.projectile;
            towerModel.displayScale -= 0.6f;
            //range
            towerModel.range += 10;
            attack.range += 10;

            //attackSpeed
            weapon.rate = 1.75f;
            project.ApplyDisplay<projectile>();
            project.scale -= 0.5f;
            project.RemoveBehavior<CreateProjectileOnExhaustFractionModel>();
            var stuck = Game.instance.model.GetTowerFromId("GlueGunner-320").GetWeapon().projectile.Duplicate();
            stuck.GetBehavior<TravelStraitModel>().lifespan = 0.001f;
            stuck.GetBehaviors<AddBehaviorToBloonModel>()[0].overlayType = "GlueStronger";
            stuck.GetBehaviors<AddBehaviorToBloonModel>()[1].overlayType = "GlueStronger";
            stuck.GetBehaviors<AddBehaviorToBloonModel>()[0].GetBehavior<DamageOverTimeModel>().interval = 24;
            stuck.GetBehaviors<AddBehaviorToBloonModel>()[0].GetBehavior<DamageOverTimeModel>().Interval = 24;
            stuck.GetBehaviors<AddBehaviorToBloonModel>()[1].GetBehavior<DamageOverTimeModel>().interval = 24;
            stuck.GetBehaviors<AddBehaviorToBloonModel>()[0].GetBehavior<DamageOverTimeModel>().immuneBloonProperties = (Il2Cpp.BloonProperties)17;
            stuck.GetBehaviors<AddBehaviorToBloonModel>()[0].GetBehavior<DamageOverTimeModel>().immuneBloonPropertiesOriginal = (Il2Cpp.BloonProperties)17;
            stuck.GetBehaviors<AddBehaviorToBloonModel>()[1].GetBehavior<DamageOverTimeModel>().immuneBloonProperties = (Il2Cpp.BloonProperties)17;
            stuck.GetBehaviors<AddBehaviorToBloonModel>()[1].GetBehavior<DamageOverTimeModel>().immuneBloonPropertiesOriginal = (Il2Cpp.BloonProperties)17;
            stuck.GetBehaviors<AddBehaviorToBloonModel>()[1].GetBehavior<DamageOverTimeModel>().Interval = 24;
            stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<SlowModel>().overlayType = "GlueStronger";
            stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<SlowModel>().multiplier = 0.80f;
            stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<SlowModel>().Multiplier = 0.80f;
            stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<SlowModel>().Mutator.multiplier = 0.80f;
            stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<SlowModifierForTagModel>().resetToUnmodified = true;
            stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<SlowModifierForTagModel>().slowMultiplier = 2.5f;
            stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<SlowModel>().Mutator.overlayType = "GlueStronger";
            stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<AddBehaviorToBloonModel>().overlayType = "GlueStronger";
            stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<AddBehaviorToBloonModel>().GetBehavior<DamageOverTimeModel>().interval = 24;
            stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<AddBehaviorToBloonModel>().GetBehavior<DamageOverTimeModel>().Interval = 24;
            stuck.GetBehavior<TravelStraitModel>().Lifespan = 0.001f;
            stuck.GetBehavior<SlowModel>().multiplier = 0.80f;
            stuck.GetBehavior<SlowModel>().multiplier = 0.80f;
            stuck.GetBehavior<SlowModel>().overlayType = "GlueStronger";
            stuck.GetBehavior<SlowModel>().Mutator.overlayType = "GlueStronger";
            stuck.GetBehavior<SlowModel>().glueLevel = 5;
            stuck.GetBehavior<SlowModel>().Mutator.glueLevel = 5;
            stuck.GetBehavior<SlowModel>().Mutator.multiplier = 0.80f;
            stuck.GetBehaviors<SlowModifierForTagModel>()[0].resetToUnmodified = true;
            stuck.GetBehaviors<SlowModifierForTagModel>()[0].slowMultiplier = 2.5f;
            stuck.GetBehavior<AddBehaviorToBloonModel>().overlayType = "GlueStronger";
            stuck.GetBehavior<AddBehaviorToBloonModel>().GetBehavior<DamageOverTimeModel>().damage = 2f;
            stuck.pierce = 1;
            stuck.RemoveBehavior<CreateEffectOnContactModel>();
            var pinkStick = Game.instance.model.GetTowerFromId("GlueGunner-023").GetWeapon().projectile.GetBehavior<CreateEffectOnContactModel>();
            stuck.AddBehavior(pinkStick);

            var emi = new SingleEmissionModel("shootStuck_", null);
            var exhaust = new CreateProjectileOnExhaustFractionModel("stuck_", stuck, emi, 1f, -1f, false, false, false);
            project.AddBehavior(exhaust);
            var pro = Game.instance.model.GetTowerFromId("BombShooter").GetWeapon().projectile.Duplicate();
            pro.GetBehavior<CreateProjectileOnContactModel>().projectile.GetDamageModel().damage = 2;
            pro.RemoveBehavior<CreateEffectOnContactModel>();
            pro.RemoveBehavior<CreateSoundOnProjectileCollisionModel>();
            pro.pierce = 1;
            pro.GetBehavior<TravelStraitModel>().lifespan = 0.1f;
            pro.GetBehavior<TravelStraitModel>().Lifespan = 0.1f;
            pro.GetBehavior<TravelStraitModel>().speed = 500;
            pro.GetBehavior<TravelStraitModel>().Speed = 500;
            pro.GetBehavior<CreateProjectileOnContactModel>().projectile.GetDamageModel().immuneBloonProperties = (Il2Cpp.BloonProperties)17;
            pro.GetBehavior<CreateProjectileOnContactModel>().projectile.GetDamageModel().immuneBloonPropertiesOriginal = (Il2Cpp.BloonProperties)17;
            var target = Game.instance.model.GetTowerFromId("WizardMonkey-100").GetWeapon().projectile.GetBehavior<TrackTargetModel>().Duplicate();
            target.TurnRate = 500;
            target.turnRate = 500;
            pro.AddBehavior(target);
            pro.ApplyDisplay<invis>();
            stuck.ApplyDisplay<invis>();
            exhaust = new CreateProjectileOnExhaustFractionModel("hit_", pro, emi, 1f, -1f, false, false, false);
            project.AddBehavior(exhaust);
            project.RemoveBehavior<CreateEffectOnExhaustFractionModel>();
            stuck.GetBehavior<CreateProjectileOnContactModel>().projectile.radius = 15;

            stuck.GetBehavior<CreateProjectileOnContactModel>().projectile.pierce = 9999;
            pro.GetBehavior<CreateProjectileOnContactModel>().projectile.radius = 15;
            var temp = stuck.GetBehavior<SlowModifierForTagModel>().Duplicate();
            stuck.AddBehavior(temp);
            stuck.GetBehaviors<SlowModifierForTagModel>()[0].resetToUnmodified = false;
            stuck.GetBehaviors<SlowModifierForTagModel>()[0].tag = "Bad";
            stuck.GetBehaviors<SlowModifierForTagModel>()[0].slowMultiplier = 100;
            var temp2 = stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<SlowModifierForTagModel>().Duplicate();
            stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.AddBehavior(temp2);
            stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehaviors<SlowModifierForTagModel>()[0].resetToUnmodified = false;
            stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehaviors<SlowModifierForTagModel>()[0].tag = "Bad";
            stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehaviors<SlowModifierForTagModel>()[0].slowMultiplier = 100;
            stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<AddBehaviorToBloonModel>().GetBehavior<DamageOverTimeModel>().immuneBloonProperties = (Il2Cpp.BloonProperties)17;
            stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<AddBehaviorToBloonModel>().GetBehavior<DamageOverTimeModel>().immuneBloonPropertiesOriginal = (Il2Cpp.BloonProperties)17;
            //project.CanHitCamo();

            //project.GetDamageModel().damage = 999;

        }
        public class projectile : ModDisplay
        {
            public override string BaseDisplay => Generic2dDisplay;
            public override void ModifyDisplayNode(UnityDisplayNode node)
            {
                Set2DTexture(node, Name);
            }
        }
        public class invis : ModDisplay
        {
            public override string BaseDisplay => Generic2dDisplay;
            public override void ModifyDisplayNode(UnityDisplayNode node)
            {
                Set2DTexture(node, Name);
            }
        }
        public class GodBubbles : ModParagonUpgrade<TestingMonkey>
        {
            public override int Cost => 250000;
            public override string Description => "Nothing can stop these bubbles";
            public override string DisplayName => "Bubblegum Master";

            public override void ApplyUpgrade(TowerModel towerModel)
            {
                var weapon = towerModel.GetWeapon();
                var project = weapon.projectile;
                var stuck = project.GetBehaviors<CreateProjectileOnExhaustFractionModel>()[0].projectile;

                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehaviors<SlowModifierForTagModel>()[0].slowMultiplier = 1.5f;

                stuck.GetBehaviors<SlowModifierForTagModel>()[0].slowMultiplier = 1.5f;
                weapon.rate = 0f;
                Game.instance.model.GetTowerFromId("Adora").IsHero();
            }
        }

    }
}
