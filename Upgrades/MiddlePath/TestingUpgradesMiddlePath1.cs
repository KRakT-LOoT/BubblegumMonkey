using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Models.Towers;
using Il2CppAssets.Scripts.Models.Towers.Projectiles.Behaviors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Il2CppAssets.Scripts.Models.Bloons.Behaviors;
using static BubblegumMonkey.TestingMonkey;
using BubblegumMonkey;
using BubblegumMonkey.Upgrades.BottomPath;
using BubblegumMonkey.Upgrades.TopPath;


namespace BubblegumMonkey.Upgrades.MiddlePath
{
    internal class TestingUpgradesMiddlePath1 : ModUpgrade<TestingMonkey>
    {
        public override int Path => 1;

        public override int Tier => 1;

        public override int Cost => 90;
        public override string Description => "Wider Gum Packs let you blow bubbles even faster without needing another pack, also enhances other upgrades!";
        public override string DisplayName => "Wider Gum Pack";

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            var pro = towerModel.GetWeapon().projectile.GetBehaviors<CreateProjectileOnExhaustFractionModel>()[1].projectile;
            pro.GetBehavior<CreateProjectileOnContactModel>().projectile.GetDamageModel().damage += 1;

            var weapon = towerModel.GetWeapon();
            var proj = weapon.projectile;
            var stuck = proj.GetBehaviors<CreateProjectileOnExhaustFractionModel>()[0].projectile;
            towerModel.GetWeapon().rate -= 0.25f;

            if (towerModel.appliedUpgrades.Contains(UpgradeID<TestingUpgradesBottomPath1>()) || towerModel.appliedUpgrades.Contains(UpgradeID<GodBubbles>()))
            {
                stuck.GetBehaviors<AddBehaviorToBloonModel>()[0].GetBehavior<DamageOverTimeModel>().damage *= 1.5f;
                stuck.GetBehaviors<AddBehaviorToBloonModel>()[1].GetBehavior<DamageOverTimeModel>().damage *= 1.5f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<AddBehaviorToBloonModel>().GetBehavior<DamageOverTimeModel>().damage *= 1.5f;
                towerModel.range *= 1.05f;
                towerModel.GetAttackModel().range *= 1.05f;

            }

            if (towerModel.appliedUpgrades.Contains(UpgradeID<TestingUpgradesBottomPath2>()) || towerModel.appliedUpgrades.Contains(UpgradeID<GodBubbles>()))
            {
                stuck.GetBehaviors<AddBehaviorToBloonModel>()[0].GetBehavior<DamageOverTimeModel>().damage *= 1.5f;
                stuck.GetBehaviors<AddBehaviorToBloonModel>()[1].GetBehavior<DamageOverTimeModel>().damage *= 1.5f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<AddBehaviorToBloonModel>().GetBehavior<DamageOverTimeModel>().damage *= 1.5f;
                towerModel.range *= 1.05f;
                towerModel.GetAttackModel().range *= 1.05f;

            }

            if (towerModel.appliedUpgrades.Contains(UpgradeID<TestingUpgradesBottomPath3>()) || towerModel.appliedUpgrades.Contains(UpgradeID<GodBubbles>()))
            {
                stuck.GetBehaviors<AddBehaviorToBloonModel>()[0].GetBehavior<DamageOverTimeModel>().damage *= 1.5f;
                stuck.GetBehaviors<AddBehaviorToBloonModel>()[1].GetBehavior<DamageOverTimeModel>().damage *= 1.5f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<AddBehaviorToBloonModel>().GetBehavior<DamageOverTimeModel>().damage *= 1.5f;
                towerModel.range *= 1.05f;
                towerModel.GetAttackModel().range *= 1.05f;

            }

            if (towerModel.appliedUpgrades.Contains(UpgradeID<TestingUpgradesBottomPath4>()) || towerModel.appliedUpgrades.Contains(UpgradeID<GodBubbles>()))
            {
                stuck.GetBehaviors<AddBehaviorToBloonModel>()[0].GetBehavior<DamageOverTimeModel>().damage *= 1.5f;
                stuck.GetBehaviors<AddBehaviorToBloonModel>()[1].GetBehavior<DamageOverTimeModel>().damage *= 1.5f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<AddBehaviorToBloonModel>().GetBehavior<DamageOverTimeModel>().damage *= 1.5f;
                towerModel.range *= 1.05f;
                towerModel.GetAttackModel().range *= 1.05f;

            }

            if (towerModel.appliedUpgrades.Contains(UpgradeID<TestingUpgradesBottomPath5>()) || towerModel.appliedUpgrades.Contains(UpgradeID<GodBubbles>()))
            {
                stuck.GetBehaviors<AddBehaviorToBloonModel>()[0].GetBehavior<DamageOverTimeModel>().damage *= 1.5f;
                stuck.GetBehaviors<AddBehaviorToBloonModel>()[1].GetBehavior<DamageOverTimeModel>().damage *= 1.5f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<AddBehaviorToBloonModel>().GetBehavior<DamageOverTimeModel>().damage *= 1.5f;
                towerModel.range *= 1.05f;
                towerModel.GetAttackModel().range *= 1.05f;

            }

            if (towerModel.appliedUpgrades.Contains(UpgradeID<TestingUpgradesTopPath1>()) || towerModel.appliedUpgrades.Contains(UpgradeID<GodBubbles>()))
            {

                stuck.GetBehavior<SlowModel>().multiplier *= 0.95f;
                stuck.GetBehavior<SlowModel>().multiplier *= 0.95f;
                stuck.GetBehavior<SlowModel>().Mutator.multiplier *= 0.95f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<SlowModel>().multiplier *= 0.95f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<SlowModel>().Multiplier *= 0.95f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<SlowModel>().Mutator.multiplier *= 0.95f;
                stuck.GetBehaviors<SlowModifierForTagModel>()[1].slowMultiplier *= 0.96f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehaviors<SlowModifierForTagModel>()[1].slowMultiplier *= 0.96f;
                stuck.GetBehaviors<AddBehaviorToBloonModel>()[0].lifespan *= 1.05f;
                stuck.GetBehaviors<AddBehaviorToBloonModel>()[1].lifespan *= 1.05f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<SlowModel>().lifespan *= 1.05f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<AddBehaviorToBloonModel>().lifespan *= 1.05f;
                stuck.GetBehavior<SlowModel>().lifespan *= 1.05f;
            }

            if (towerModel.appliedUpgrades.Contains(UpgradeID<TestingUpgradesTopPath2>()) || towerModel.appliedUpgrades.Contains(UpgradeID<GodBubbles>()))
            {

                stuck.GetBehavior<SlowModel>().multiplier *= 0.95f;
                stuck.GetBehavior<SlowModel>().multiplier *= 0.95f;
                stuck.GetBehavior<SlowModel>().Mutator.multiplier *= 0.95f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<SlowModel>().multiplier *= 0.95f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<SlowModel>().Multiplier *= 0.95f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<SlowModel>().Mutator.multiplier *= 0.95f;
                stuck.GetBehaviors<SlowModifierForTagModel>()[1].slowMultiplier *= 0.96f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehaviors<SlowModifierForTagModel>()[1].slowMultiplier *= 0.96f;
                stuck.GetBehaviors<AddBehaviorToBloonModel>()[0].lifespan *= 1.05f;
                stuck.GetBehaviors<AddBehaviorToBloonModel>()[1].lifespan *= 1.05f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<SlowModel>().lifespan *= 1.05f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<AddBehaviorToBloonModel>().lifespan *= 1.05f;
                stuck.GetBehavior<SlowModel>().lifespan *= 1.05f;
            }

            if (towerModel.appliedUpgrades.Contains(UpgradeID<TestingUpgradesTopPath3>()) || towerModel.appliedUpgrades.Contains(UpgradeID<GodBubbles>()))
            {

                stuck.GetBehavior<SlowModel>().multiplier *= 0.95f;
                stuck.GetBehavior<SlowModel>().multiplier *= 0.95f;
                stuck.GetBehavior<SlowModel>().Mutator.multiplier *= 0.95f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<SlowModel>().multiplier *= 0.95f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<SlowModel>().Multiplier *= 0.95f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<SlowModel>().Mutator.multiplier *= 0.95f;
                stuck.GetBehaviors<SlowModifierForTagModel>()[1].slowMultiplier *= 0.96f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehaviors<SlowModifierForTagModel>()[1].slowMultiplier *= 0.96f;
                stuck.GetBehaviors<AddBehaviorToBloonModel>()[0].lifespan *= 1.05f;
                stuck.GetBehaviors<AddBehaviorToBloonModel>()[1].lifespan *= 1.05f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<SlowModel>().lifespan *= 1.05f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<AddBehaviorToBloonModel>().lifespan *= 1.05f;
                stuck.GetBehavior<SlowModel>().lifespan *= 1.05f;
            }

            if (towerModel.appliedUpgrades.Contains(UpgradeID<TestingUpgradesTopPath4>()) || towerModel.appliedUpgrades.Contains(UpgradeID<GodBubbles>()))
            {

                stuck.GetBehavior<SlowModel>().multiplier *= 0.95f;
                stuck.GetBehavior<SlowModel>().multiplier *= 0.95f;
                stuck.GetBehavior<SlowModel>().Mutator.multiplier *= 0.95f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<SlowModel>().multiplier *= 0.95f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<SlowModel>().Multiplier *= 0.95f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<SlowModel>().Mutator.multiplier *= 0.95f;
                stuck.GetBehaviors<SlowModifierForTagModel>()[1].slowMultiplier *= 0.96f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehaviors<SlowModifierForTagModel>()[1].slowMultiplier *= 0.96f;
                stuck.GetBehaviors<AddBehaviorToBloonModel>()[0].lifespan *= 1.05f;
                stuck.GetBehaviors<AddBehaviorToBloonModel>()[1].lifespan *= 1.05f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<SlowModel>().lifespan *= 1.05f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<AddBehaviorToBloonModel>().lifespan *= 1.05f;
                stuck.GetBehavior<SlowModel>().lifespan *= 1.05f;
            }

            if (towerModel.appliedUpgrades.Contains(UpgradeID<TestingUpgradesTopPath5>()) || towerModel.appliedUpgrades.Contains(UpgradeID<GodBubbles>()))
            {

                stuck.GetBehavior<SlowModel>().multiplier *= 0.95f;
                stuck.GetBehavior<SlowModel>().multiplier *= 0.95f;
                stuck.GetBehavior<SlowModel>().Mutator.multiplier *= 0.95f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<SlowModel>().multiplier *= 0.95f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<SlowModel>().Multiplier *= 0.95f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<SlowModel>().Mutator.multiplier *= 0.95f;
                stuck.GetBehaviors<SlowModifierForTagModel>()[1].slowMultiplier *= 0.96f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehaviors<SlowModifierForTagModel>()[1].slowMultiplier *= 0.96f;
                stuck.GetBehaviors<AddBehaviorToBloonModel>()[0].lifespan *= 1.05f;
                stuck.GetBehaviors<AddBehaviorToBloonModel>()[1].lifespan *= 1.05f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<SlowModel>().lifespan *= 1.05f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<AddBehaviorToBloonModel>().lifespan *= 1.05f;
                stuck.GetBehavior<SlowModel>().lifespan *= 1.05f;
            }
            stuck.radius *= 1.2f;
            stuck.GetBehavior<CreateProjectileOnContactModel>().projectile.radius *= 1.2f;
            pro.GetBehavior<CreateProjectileOnContactModel>().projectile.radius *= 1.2f;
        }
    }
    internal class TestingUpgradesMiddlePath2 : ModUpgrade<TestingMonkey>
    {
        public override int Path => 1;

        public override int Tier => 2;

        public override int Cost => 200;
        public override string Description => "Double Bubble lets you blow gum bubbles much quicker! Also enhances other upgrades!";
        public override string DisplayName => "Double Bubble";

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            var pro = towerModel.GetWeapon().projectile.GetBehaviors<CreateProjectileOnExhaustFractionModel>()[1].projectile;
            pro.GetBehavior<CreateProjectileOnContactModel>().projectile.GetDamageModel().damage += 1;

            var weapon = towerModel.GetWeapon();
            var proj = weapon.projectile;
            var stuck = proj.GetBehaviors<CreateProjectileOnExhaustFractionModel>()[0].projectile;
            towerModel.GetWeapon().rate -= 0.25f;

            if (towerModel.appliedUpgrades.Contains(UpgradeID<TestingUpgradesBottomPath1>()) || towerModel.appliedUpgrades.Contains(UpgradeID<GodBubbles>()))
            {
                stuck.GetBehaviors<AddBehaviorToBloonModel>()[0].GetBehavior<DamageOverTimeModel>().damage *= 1.5f;
                stuck.GetBehaviors<AddBehaviorToBloonModel>()[1].GetBehavior<DamageOverTimeModel>().damage *= 1.5f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<AddBehaviorToBloonModel>().GetBehavior<DamageOverTimeModel>().damage *= 1.5f;
                towerModel.range *= 1.05f;
                towerModel.GetAttackModel().range *= 1.05f;

            }

            if (towerModel.appliedUpgrades.Contains(UpgradeID<TestingUpgradesBottomPath2>()) || towerModel.appliedUpgrades.Contains(UpgradeID<GodBubbles>()))
            {
                stuck.GetBehaviors<AddBehaviorToBloonModel>()[0].GetBehavior<DamageOverTimeModel>().damage *= 1.5f;
                stuck.GetBehaviors<AddBehaviorToBloonModel>()[1].GetBehavior<DamageOverTimeModel>().damage *= 1.5f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<AddBehaviorToBloonModel>().GetBehavior<DamageOverTimeModel>().damage *= 1.5f;
                towerModel.range *= 1.05f;
                towerModel.GetAttackModel().range *= 1.05f;

            }

            if (towerModel.appliedUpgrades.Contains(UpgradeID<TestingUpgradesBottomPath3>()) || towerModel.appliedUpgrades.Contains(UpgradeID<GodBubbles>()))
            {
                stuck.GetBehaviors<AddBehaviorToBloonModel>()[0].GetBehavior<DamageOverTimeModel>().damage *= 1.5f;
                stuck.GetBehaviors<AddBehaviorToBloonModel>()[1].GetBehavior<DamageOverTimeModel>().damage *= 1.5f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<AddBehaviorToBloonModel>().GetBehavior<DamageOverTimeModel>().damage *= 1.5f;
                towerModel.range *= 1.05f;
                towerModel.GetAttackModel().range *= 1.05f;

            }

            if (towerModel.appliedUpgrades.Contains(UpgradeID<TestingUpgradesBottomPath4>()) || towerModel.appliedUpgrades.Contains(UpgradeID<GodBubbles>()))
            {
                stuck.GetBehaviors<AddBehaviorToBloonModel>()[0].GetBehavior<DamageOverTimeModel>().damage *= 1.5f;
                stuck.GetBehaviors<AddBehaviorToBloonModel>()[1].GetBehavior<DamageOverTimeModel>().damage *= 1.5f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<AddBehaviorToBloonModel>().GetBehavior<DamageOverTimeModel>().damage *= 1.5f;
                towerModel.range *= 1.05f;
                towerModel.GetAttackModel().range *= 1.050f;

            }

            if (towerModel.appliedUpgrades.Contains(UpgradeID<TestingUpgradesBottomPath5>()) || towerModel.appliedUpgrades.Contains(UpgradeID<GodBubbles>()))
            {
                stuck.GetBehaviors<AddBehaviorToBloonModel>()[0].GetBehavior<DamageOverTimeModel>().damage *= 1.5f;
                stuck.GetBehaviors<AddBehaviorToBloonModel>()[1].GetBehavior<DamageOverTimeModel>().damage *= 1.5f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<AddBehaviorToBloonModel>().GetBehavior<DamageOverTimeModel>().damage *= 1.5f;
                towerModel.range *= 1.05f;
                towerModel.GetAttackModel().range *= 1.05f;

            }

            if (towerModel.appliedUpgrades.Contains(UpgradeID<TestingUpgradesTopPath1>()) || towerModel.appliedUpgrades.Contains(UpgradeID<GodBubbles>()))
            {

                stuck.GetBehavior<SlowModel>().multiplier *= 0.95f;
                stuck.GetBehavior<SlowModel>().multiplier *= 0.95f;
                stuck.GetBehavior<SlowModel>().Mutator.multiplier *= 0.95f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<SlowModel>().multiplier *= 0.95f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<SlowModel>().Multiplier *= 0.95f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<SlowModel>().Mutator.multiplier *= 0.95f;
                stuck.GetBehaviors<SlowModifierForTagModel>()[1].slowMultiplier *= 0.96f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehaviors<SlowModifierForTagModel>()[1].slowMultiplier *= 0.96f;
                stuck.GetBehaviors<AddBehaviorToBloonModel>()[0].lifespan *= 1.05f;
                stuck.GetBehaviors<AddBehaviorToBloonModel>()[1].lifespan *= 1.05f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<SlowModel>().lifespan *= 1.05f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<AddBehaviorToBloonModel>().lifespan *= 1.05f;
                stuck.GetBehavior<SlowModel>().lifespan *= 1.05f;
            }

            if (towerModel.appliedUpgrades.Contains(UpgradeID<TestingUpgradesTopPath2>()) || towerModel.appliedUpgrades.Contains(UpgradeID<GodBubbles>()))
            {

                stuck.GetBehavior<SlowModel>().multiplier *= 0.95f;
                stuck.GetBehavior<SlowModel>().multiplier *= 0.95f;
                stuck.GetBehavior<SlowModel>().Mutator.multiplier *= 0.95f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<SlowModel>().multiplier *= 0.95f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<SlowModel>().Multiplier *= 0.95f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<SlowModel>().Mutator.multiplier *= 0.95f;
                stuck.GetBehaviors<SlowModifierForTagModel>()[1].slowMultiplier *= 0.96f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehaviors<SlowModifierForTagModel>()[1].slowMultiplier *= 0.96f;
                stuck.GetBehaviors<AddBehaviorToBloonModel>()[0].lifespan *= 1.05f;
                stuck.GetBehaviors<AddBehaviorToBloonModel>()[1].lifespan *= 1.05f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<SlowModel>().lifespan *= 1.05f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<AddBehaviorToBloonModel>().lifespan *= 1.05f;
                stuck.GetBehavior<SlowModel>().lifespan *= 1.05f;
            }

            if (towerModel.appliedUpgrades.Contains(UpgradeID<TestingUpgradesTopPath3>()) || towerModel.appliedUpgrades.Contains(UpgradeID<GodBubbles>()))
            {

                stuck.GetBehavior<SlowModel>().multiplier *= 0.95f;
                stuck.GetBehavior<SlowModel>().multiplier *= 0.95f;
                stuck.GetBehavior<SlowModel>().Mutator.multiplier *= 0.95f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<SlowModel>().multiplier *= 0.95f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<SlowModel>().Multiplier *= 0.95f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<SlowModel>().Mutator.multiplier *= 0.95f;
                stuck.GetBehaviors<SlowModifierForTagModel>()[1].slowMultiplier *= 0.96f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehaviors<SlowModifierForTagModel>()[1].slowMultiplier *= 0.96f;
                stuck.GetBehaviors<AddBehaviorToBloonModel>()[0].lifespan *= 1.05f;
                stuck.GetBehaviors<AddBehaviorToBloonModel>()[1].lifespan *= 1.05f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<SlowModel>().lifespan *= 1.05f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<AddBehaviorToBloonModel>().lifespan *= 1.05f;
                stuck.GetBehavior<SlowModel>().lifespan *= 1.05f;
            }

            if (towerModel.appliedUpgrades.Contains(UpgradeID<TestingUpgradesTopPath4>()) || towerModel.appliedUpgrades.Contains(UpgradeID<GodBubbles>()))
            {

                stuck.GetBehavior<SlowModel>().multiplier *= 0.95f;
                stuck.GetBehavior<SlowModel>().multiplier *= 0.95f;
                stuck.GetBehavior<SlowModel>().Mutator.multiplier *= 0.95f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<SlowModel>().multiplier *= 0.95f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<SlowModel>().Multiplier *= 0.95f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<SlowModel>().Mutator.multiplier *= 0.95f;
                stuck.GetBehaviors<SlowModifierForTagModel>()[1].slowMultiplier *= 0.96f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehaviors<SlowModifierForTagModel>()[1].slowMultiplier *= 0.96f;
                stuck.GetBehaviors<AddBehaviorToBloonModel>()[0].lifespan *= 1.05f;
                stuck.GetBehaviors<AddBehaviorToBloonModel>()[1].lifespan *= 1.05f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<SlowModel>().lifespan *= 1.05f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<AddBehaviorToBloonModel>().lifespan *= 1.05f;
                stuck.GetBehavior<SlowModel>().lifespan *= 1.05f;
            }

            if (towerModel.appliedUpgrades.Contains(UpgradeID<TestingUpgradesTopPath5>()) || towerModel.appliedUpgrades.Contains(UpgradeID<GodBubbles>()))
            {

                stuck.GetBehavior<SlowModel>().multiplier *= 0.95f;
                stuck.GetBehavior<SlowModel>().multiplier *= 0.95f;
                stuck.GetBehavior<SlowModel>().Mutator.multiplier *= 0.95f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<SlowModel>().multiplier *= 0.95f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<SlowModel>().Multiplier *= 0.95f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<SlowModel>().Mutator.multiplier *= 0.95f;
                stuck.GetBehaviors<SlowModifierForTagModel>()[1].slowMultiplier *= 0.96f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehaviors<SlowModifierForTagModel>()[1].slowMultiplier *= 0.96f;
                stuck.GetBehaviors<AddBehaviorToBloonModel>()[0].lifespan *= 1.05f;
                stuck.GetBehaviors<AddBehaviorToBloonModel>()[1].lifespan *= 1.05f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<SlowModel>().lifespan *= 1.05f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<AddBehaviorToBloonModel>().lifespan *= 1.05f;
                stuck.GetBehavior<SlowModel>().lifespan *= 1.05f;
            }
            stuck.radius *= 1.2f;
            stuck.GetBehavior<CreateProjectileOnContactModel>().projectile.radius *= 1.2f;
            pro.GetBehavior<CreateProjectileOnContactModel>().projectile.radius *= 1.2f;
        }
    }
    internal class TestingUpgradesMiddlePath3 : ModUpgrade<TestingMonkey>
    {
        public override int Path => 1;

        public override int Tier => 3;

        public override int Cost => 425;
        public override string DisplayName => "Triple Bubble";
        public override string Description => "You guessed it, you blow bubbles even faster. Also enhances other upgrades!";

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            var pro = towerModel.GetWeapon().projectile.GetBehaviors<CreateProjectileOnExhaustFractionModel>()[1].projectile;
            pro.GetBehavior<CreateProjectileOnContactModel>().projectile.GetDamageModel().damage += 1;

            var weapon = towerModel.GetWeapon();
            var proj = weapon.projectile;
            var stuck = proj.GetBehaviors<CreateProjectileOnExhaustFractionModel>()[0].projectile;
            towerModel.GetWeapon().rate -= 0.25f;

            if (towerModel.appliedUpgrades.Contains(UpgradeID<TestingUpgradesBottomPath1>()) || towerModel.appliedUpgrades.Contains(UpgradeID<GodBubbles>()))
            {
                stuck.GetBehaviors<AddBehaviorToBloonModel>()[0].GetBehavior<DamageOverTimeModel>().damage *= 1.5f;
                stuck.GetBehaviors<AddBehaviorToBloonModel>()[1].GetBehavior<DamageOverTimeModel>().damage *= 1.5f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<AddBehaviorToBloonModel>().GetBehavior<DamageOverTimeModel>().damage *= 1.5f;
                towerModel.range *= 1.05f;
                towerModel.GetAttackModel().range *= 1.05f;

            }

            if (towerModel.appliedUpgrades.Contains(UpgradeID<TestingUpgradesBottomPath2>()) || towerModel.appliedUpgrades.Contains(UpgradeID<GodBubbles>()))
            {
                stuck.GetBehaviors<AddBehaviorToBloonModel>()[0].GetBehavior<DamageOverTimeModel>().damage *= 1.5f;
                stuck.GetBehaviors<AddBehaviorToBloonModel>()[1].GetBehavior<DamageOverTimeModel>().damage *= 1.5f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<AddBehaviorToBloonModel>().GetBehavior<DamageOverTimeModel>().damage *= 1.5f;
                towerModel.range *= 1.05f;
                towerModel.GetAttackModel().range *= 1.05f;

            }

            if (towerModel.appliedUpgrades.Contains(UpgradeID<TestingUpgradesBottomPath3>()) || towerModel.appliedUpgrades.Contains(UpgradeID<GodBubbles>()))
            {
                stuck.GetBehaviors<AddBehaviorToBloonModel>()[0].GetBehavior<DamageOverTimeModel>().damage *= 1.5f;
                stuck.GetBehaviors<AddBehaviorToBloonModel>()[1].GetBehavior<DamageOverTimeModel>().damage *= 1.5f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<AddBehaviorToBloonModel>().GetBehavior<DamageOverTimeModel>().damage *= 1.5f;
                towerModel.range *= 1.05f;
                towerModel.GetAttackModel().range *= 1.05f;

            }

            if (towerModel.appliedUpgrades.Contains(UpgradeID<TestingUpgradesBottomPath4>()) || towerModel.appliedUpgrades.Contains(UpgradeID<GodBubbles>()))
            {
                stuck.GetBehaviors<AddBehaviorToBloonModel>()[0].GetBehavior<DamageOverTimeModel>().damage *= 1.5f;
                stuck.GetBehaviors<AddBehaviorToBloonModel>()[1].GetBehavior<DamageOverTimeModel>().damage *= 1.5f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<AddBehaviorToBloonModel>().GetBehavior<DamageOverTimeModel>().damage *= 1.5f;
                towerModel.range *= 1.05f;
                towerModel.GetAttackModel().range *= 1.05f;

            }

            if (towerModel.appliedUpgrades.Contains(UpgradeID<TestingUpgradesBottomPath5>()) || towerModel.appliedUpgrades.Contains(UpgradeID<GodBubbles>()))
            {
                stuck.GetBehaviors<AddBehaviorToBloonModel>()[0].GetBehavior<DamageOverTimeModel>().damage *= 1.5f;
                stuck.GetBehaviors<AddBehaviorToBloonModel>()[1].GetBehavior<DamageOverTimeModel>().damage *= 1.5f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<AddBehaviorToBloonModel>().GetBehavior<DamageOverTimeModel>().damage *= 1.5f;
                towerModel.range *= 1.05f;
                towerModel.GetAttackModel().range *= 1.05f;

            }

            if (towerModel.appliedUpgrades.Contains(UpgradeID<TestingUpgradesTopPath1>()) || towerModel.appliedUpgrades.Contains(UpgradeID<GodBubbles>()))
            {

                stuck.GetBehavior<SlowModel>().multiplier *= 0.95f;
                stuck.GetBehavior<SlowModel>().multiplier *= 0.95f;
                stuck.GetBehavior<SlowModel>().Mutator.multiplier *= 0.95f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<SlowModel>().multiplier *= 0.95f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<SlowModel>().Multiplier *= 0.95f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<SlowModel>().Mutator.multiplier *= 0.95f;
                stuck.GetBehaviors<SlowModifierForTagModel>()[1].slowMultiplier *= 0.96f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehaviors<SlowModifierForTagModel>()[1].slowMultiplier *= 0.96f;
                stuck.GetBehaviors<AddBehaviorToBloonModel>()[0].lifespan *= 1.05f;
                stuck.GetBehaviors<AddBehaviorToBloonModel>()[1].lifespan *= 1.05f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<SlowModel>().lifespan *= 1.05f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<AddBehaviorToBloonModel>().lifespan *= 1.05f;
                stuck.GetBehavior<SlowModel>().lifespan *= 1.05f;
            }

            if (towerModel.appliedUpgrades.Contains(UpgradeID<TestingUpgradesTopPath2>()) || towerModel.appliedUpgrades.Contains(UpgradeID<GodBubbles>()))
            {

                stuck.GetBehavior<SlowModel>().multiplier *= 0.95f;
                stuck.GetBehavior<SlowModel>().multiplier *= 0.95f;
                stuck.GetBehavior<SlowModel>().Mutator.multiplier *= 0.95f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<SlowModel>().multiplier *= 0.95f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<SlowModel>().Multiplier *= 0.95f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<SlowModel>().Mutator.multiplier *= 0.95f;
                stuck.GetBehaviors<SlowModifierForTagModel>()[1].slowMultiplier *= 0.96f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehaviors<SlowModifierForTagModel>()[1].slowMultiplier *= 0.96f;
                stuck.GetBehaviors<AddBehaviorToBloonModel>()[0].lifespan *= 1.05f;
                stuck.GetBehaviors<AddBehaviorToBloonModel>()[1].lifespan *= 1.05f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<SlowModel>().lifespan *= 1.05f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<AddBehaviorToBloonModel>().lifespan *= 1.05f;
                stuck.GetBehavior<SlowModel>().lifespan *= 1.05f;
            }

            if (towerModel.appliedUpgrades.Contains(UpgradeID<TestingUpgradesTopPath3>()) || towerModel.appliedUpgrades.Contains(UpgradeID<GodBubbles>()))
            {

                stuck.GetBehavior<SlowModel>().multiplier *= 0.95f;
                stuck.GetBehavior<SlowModel>().multiplier *= 0.95f;
                stuck.GetBehavior<SlowModel>().Mutator.multiplier *= 0.95f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<SlowModel>().multiplier *= 0.95f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<SlowModel>().Multiplier *= 0.95f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<SlowModel>().Mutator.multiplier *= 0.95f;
                stuck.GetBehaviors<SlowModifierForTagModel>()[1].slowMultiplier *= 0.96f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehaviors<SlowModifierForTagModel>()[1].slowMultiplier *= 0.96f;
                stuck.GetBehaviors<AddBehaviorToBloonModel>()[0].lifespan *= 1.05f;
                stuck.GetBehaviors<AddBehaviorToBloonModel>()[1].lifespan *= 1.05f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<SlowModel>().lifespan *= 1.05f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<AddBehaviorToBloonModel>().lifespan *= 1.05f;
                stuck.GetBehavior<SlowModel>().lifespan *= 1.05f;
            }

            if (towerModel.appliedUpgrades.Contains(UpgradeID<TestingUpgradesTopPath4>()) || towerModel.appliedUpgrades.Contains(UpgradeID<GodBubbles>()))
            {

                stuck.GetBehavior<SlowModel>().multiplier *= 0.95f;
                stuck.GetBehavior<SlowModel>().multiplier *= 0.95f;
                stuck.GetBehavior<SlowModel>().Mutator.multiplier *= 0.95f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<SlowModel>().multiplier *= 0.95f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<SlowModel>().Multiplier *= 0.95f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<SlowModel>().Mutator.multiplier *= 0.95f;
                stuck.GetBehaviors<SlowModifierForTagModel>()[1].slowMultiplier *= 0.96f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehaviors<SlowModifierForTagModel>()[1].slowMultiplier *= 0.96f;
                stuck.GetBehaviors<AddBehaviorToBloonModel>()[0].lifespan *= 1.05f;
                stuck.GetBehaviors<AddBehaviorToBloonModel>()[1].lifespan *= 1.05f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<SlowModel>().lifespan *= 1.05f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<AddBehaviorToBloonModel>().lifespan *= 1.05f;
                stuck.GetBehavior<SlowModel>().lifespan *= 1.05f;
            }

            if (towerModel.appliedUpgrades.Contains(UpgradeID<TestingUpgradesTopPath5>()) || towerModel.appliedUpgrades.Contains(UpgradeID<GodBubbles>()))
            {

                stuck.GetBehavior<SlowModel>().multiplier *= 0.95f;
                stuck.GetBehavior<SlowModel>().multiplier *= 0.95f;
                stuck.GetBehavior<SlowModel>().Mutator.multiplier *= 0.95f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<SlowModel>().multiplier *= 0.95f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<SlowModel>().Multiplier *= 0.95f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<SlowModel>().Mutator.multiplier *= 0.95f;
                stuck.GetBehaviors<SlowModifierForTagModel>()[1].slowMultiplier *= 0.96f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehaviors<SlowModifierForTagModel>()[1].slowMultiplier *= 0.96f;
                stuck.GetBehaviors<AddBehaviorToBloonModel>()[0].lifespan *= 1.05f;
                stuck.GetBehaviors<AddBehaviorToBloonModel>()[1].lifespan *= 1.05f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<SlowModel>().lifespan *= 1.05f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<AddBehaviorToBloonModel>().lifespan *= 1.05f;
                stuck.GetBehavior<SlowModel>().lifespan *= 1.05f;
            }
            stuck.radius *= 1.2f;
            stuck.GetBehavior<CreateProjectileOnContactModel>().projectile.radius *= 1.2f;
            pro.GetBehavior<CreateProjectileOnContactModel>().projectile.radius *= 1.2f;
        }
    }
    internal class TestingUpgradesMiddlePath4 : ModUpgrade<TestingMonkey>
    {
        public override int Path => 1;

        public override int Tier => 4;

        public override int Cost => 2000;
        public override string Description => "Blowing bubbles increadibly fast (Ability Coming Soon). I wonder what enhancing other upgrades even means? Also enhances other upgrades!";
        public override string DisplayName => "Gumballs";

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            var pro = towerModel.GetWeapon().projectile.GetBehaviors<CreateProjectileOnExhaustFractionModel>()[1].projectile;
            pro.GetBehavior<CreateProjectileOnContactModel>().projectile.GetDamageModel().damage += 1;

            var weapon = towerModel.GetWeapon();
            var proj = weapon.projectile;
            var stuck = proj.GetBehaviors<CreateProjectileOnExhaustFractionModel>()[0].projectile;
            towerModel.GetWeapon().rate -= 0.35f;

            if (towerModel.appliedUpgrades.Contains(UpgradeID<TestingUpgradesBottomPath1>()) || towerModel.appliedUpgrades.Contains(UpgradeID<GodBubbles>()))
            {
                stuck.GetBehaviors<AddBehaviorToBloonModel>()[0].GetBehavior<DamageOverTimeModel>().damage *= 1.5f;
                stuck.GetBehaviors<AddBehaviorToBloonModel>()[1].GetBehavior<DamageOverTimeModel>().damage *= 1.5f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<AddBehaviorToBloonModel>().GetBehavior<DamageOverTimeModel>().damage *= 1.5f;
                towerModel.range *= 1.05f;
                towerModel.GetAttackModel().range *= 1.05f;

            }

            if (towerModel.appliedUpgrades.Contains(UpgradeID<TestingUpgradesBottomPath2>()) || towerModel.appliedUpgrades.Contains(UpgradeID<GodBubbles>()))
            {
                stuck.GetBehaviors<AddBehaviorToBloonModel>()[0].GetBehavior<DamageOverTimeModel>().damage *= 1.5f;
                stuck.GetBehaviors<AddBehaviorToBloonModel>()[1].GetBehavior<DamageOverTimeModel>().damage *= 1.5f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<AddBehaviorToBloonModel>().GetBehavior<DamageOverTimeModel>().damage *= 1.5f;
                towerModel.range *= 1.05f;
                towerModel.GetAttackModel().range *= 1.05f;

            }

            if (towerModel.appliedUpgrades.Contains(UpgradeID<TestingUpgradesBottomPath3>()) || towerModel.appliedUpgrades.Contains(UpgradeID<GodBubbles>()))
            {
                stuck.GetBehaviors<AddBehaviorToBloonModel>()[0].GetBehavior<DamageOverTimeModel>().damage *= 1.5f;
                stuck.GetBehaviors<AddBehaviorToBloonModel>()[1].GetBehavior<DamageOverTimeModel>().damage *= 1.5f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<AddBehaviorToBloonModel>().GetBehavior<DamageOverTimeModel>().damage *= 1.5f;
                towerModel.range *= 1.05f;
                towerModel.GetAttackModel().range *= 1.05f;

            }

            if (towerModel.appliedUpgrades.Contains(UpgradeID<TestingUpgradesBottomPath4>()) || towerModel.appliedUpgrades.Contains(UpgradeID<GodBubbles>()))
            {
                stuck.GetBehaviors<AddBehaviorToBloonModel>()[0].GetBehavior<DamageOverTimeModel>().damage *= 1.5f;
                stuck.GetBehaviors<AddBehaviorToBloonModel>()[1].GetBehavior<DamageOverTimeModel>().damage *= 1.5f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<AddBehaviorToBloonModel>().GetBehavior<DamageOverTimeModel>().damage *= 1.5f;
                towerModel.range *= 1.05f;
                towerModel.GetAttackModel().range *= 1.05f;

            }

            if (towerModel.appliedUpgrades.Contains(UpgradeID<TestingUpgradesBottomPath5>()) || towerModel.appliedUpgrades.Contains(UpgradeID<GodBubbles>()))
            {
                stuck.GetBehaviors<AddBehaviorToBloonModel>()[0].GetBehavior<DamageOverTimeModel>().damage *= 1.5f;
                stuck.GetBehaviors<AddBehaviorToBloonModel>()[1].GetBehavior<DamageOverTimeModel>().damage *= 1.5f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<AddBehaviorToBloonModel>().GetBehavior<DamageOverTimeModel>().damage *= 1.5f;
                towerModel.range *= 1.05f;
                towerModel.GetAttackModel().range *= 1.05f;

            }

            if (towerModel.appliedUpgrades.Contains(UpgradeID<TestingUpgradesTopPath1>()) || towerModel.appliedUpgrades.Contains(UpgradeID<GodBubbles>()))
            {

                stuck.GetBehavior<SlowModel>().multiplier *= 0.95f;
                stuck.GetBehavior<SlowModel>().multiplier *= 0.95f;
                stuck.GetBehavior<SlowModel>().Mutator.multiplier *= 0.95f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<SlowModel>().multiplier *= 0.95f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<SlowModel>().Multiplier *= 0.95f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<SlowModel>().Mutator.multiplier *= 0.95f;
                stuck.GetBehaviors<SlowModifierForTagModel>()[1].slowMultiplier *= 0.96f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehaviors<SlowModifierForTagModel>()[1].slowMultiplier *= 0.96f;
                stuck.GetBehaviors<AddBehaviorToBloonModel>()[0].lifespan *= 1.05f;
                stuck.GetBehaviors<AddBehaviorToBloonModel>()[1].lifespan *= 1.05f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<SlowModel>().lifespan *= 1.05f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<AddBehaviorToBloonModel>().lifespan *= 1.05f;
                stuck.GetBehavior<SlowModel>().lifespan *= 1.05f;
            }

            if (towerModel.appliedUpgrades.Contains(UpgradeID<TestingUpgradesTopPath2>()) || towerModel.appliedUpgrades.Contains(UpgradeID<GodBubbles>()))
            {

                stuck.GetBehavior<SlowModel>().multiplier *= 0.95f;
                stuck.GetBehavior<SlowModel>().multiplier *= 0.95f;
                stuck.GetBehavior<SlowModel>().Mutator.multiplier *= 0.95f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<SlowModel>().multiplier *= 0.95f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<SlowModel>().Multiplier *= 0.95f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<SlowModel>().Mutator.multiplier *= 0.95f;
                stuck.GetBehaviors<SlowModifierForTagModel>()[1].slowMultiplier *= 0.96f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehaviors<SlowModifierForTagModel>()[1].slowMultiplier *= 0.96f;
                stuck.GetBehaviors<AddBehaviorToBloonModel>()[0].lifespan *= 1.05f;
                stuck.GetBehaviors<AddBehaviorToBloonModel>()[1].lifespan *= 1.05f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<SlowModel>().lifespan *= 1.05f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<AddBehaviorToBloonModel>().lifespan *= 1.05f;
                stuck.GetBehavior<SlowModel>().lifespan *= 1.05f;
            }

            if (towerModel.appliedUpgrades.Contains(UpgradeID<TestingUpgradesTopPath3>()) || towerModel.appliedUpgrades.Contains(UpgradeID<GodBubbles>()))
            {

                stuck.GetBehavior<SlowModel>().multiplier *= 0.95f;
                stuck.GetBehavior<SlowModel>().multiplier *= 0.95f;
                stuck.GetBehavior<SlowModel>().Mutator.multiplier *= 0.95f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<SlowModel>().multiplier *= 0.95f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<SlowModel>().Multiplier *= 0.95f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<SlowModel>().Mutator.multiplier *= 0.95f;
                stuck.GetBehaviors<SlowModifierForTagModel>()[1].slowMultiplier *= 0.96f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehaviors<SlowModifierForTagModel>()[1].slowMultiplier *= 0.96f;
                stuck.GetBehaviors<AddBehaviorToBloonModel>()[0].lifespan *= 1.05f;
                stuck.GetBehaviors<AddBehaviorToBloonModel>()[1].lifespan *= 1.05f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<SlowModel>().lifespan *= 1.05f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<AddBehaviorToBloonModel>().lifespan *= 1.05f;
                stuck.GetBehavior<SlowModel>().lifespan *= 1.05f;
            }

            if (towerModel.appliedUpgrades.Contains(UpgradeID<TestingUpgradesTopPath4>()) || towerModel.appliedUpgrades.Contains(UpgradeID<GodBubbles>()))
            {

                stuck.GetBehavior<SlowModel>().multiplier *= 0.95f;
                stuck.GetBehavior<SlowModel>().multiplier *= 0.95f;
                stuck.GetBehavior<SlowModel>().Mutator.multiplier *= 0.95f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<SlowModel>().multiplier *= 0.95f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<SlowModel>().Multiplier *= 0.95f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<SlowModel>().Mutator.multiplier *= 0.95f;
                stuck.GetBehaviors<SlowModifierForTagModel>()[1].slowMultiplier *= 0.96f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehaviors<SlowModifierForTagModel>()[1].slowMultiplier *= 0.96f;
                stuck.GetBehaviors<AddBehaviorToBloonModel>()[0].lifespan *= 1.05f;
                stuck.GetBehaviors<AddBehaviorToBloonModel>()[1].lifespan *= 1.05f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<SlowModel>().lifespan *= 1.05f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<AddBehaviorToBloonModel>().lifespan *= 1.05f;
                stuck.GetBehavior<SlowModel>().lifespan *= 1.05f;
            }

            if (towerModel.appliedUpgrades.Contains(UpgradeID<TestingUpgradesTopPath5>()) || towerModel.appliedUpgrades.Contains(UpgradeID<GodBubbles>()))
            {

                stuck.GetBehavior<SlowModel>().multiplier *= 0.95f;
                stuck.GetBehavior<SlowModel>().multiplier *= 0.95f;
                stuck.GetBehavior<SlowModel>().Mutator.multiplier *= 0.95f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<SlowModel>().multiplier *= 0.95f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<SlowModel>().Multiplier *= 0.95f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<SlowModel>().Mutator.multiplier *= 0.95f;
                stuck.GetBehaviors<SlowModifierForTagModel>()[1].slowMultiplier *= 0.96f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehaviors<SlowModifierForTagModel>()[1].slowMultiplier *= 0.96f;
                stuck.GetBehaviors<AddBehaviorToBloonModel>()[0].lifespan *= 1.05f;
                stuck.GetBehaviors<AddBehaviorToBloonModel>()[1].lifespan *= 1.05f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<SlowModel>().lifespan *= 1.05f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<AddBehaviorToBloonModel>().lifespan *= 1.05f;
                stuck.GetBehavior<SlowModel>().lifespan *= 1.05f;
            }
            stuck.radius *= 1.2f;
            stuck.GetBehavior<CreateProjectileOnContactModel>().projectile.radius *= 1.2f;
            pro.GetBehavior<CreateProjectileOnContactModel>().projectile.radius *= 1.2f;
        }
    }

    internal class TestingUpgradesMiddlePath5 : ModUpgrade<TestingMonkey>
    {
        public override int Path => 1;

        public override int Tier => 5;

        public override int Cost => 14750;
        public override string Description => "You fire at your max speed! (Ability Coming Soon) Also enhances other upgrades!";
        public override string DisplayName => "Golden Gum Pack";


        public override void ApplyUpgrade(TowerModel towerModel)
        {
            var pro = towerModel.GetWeapon().projectile.GetBehaviors<CreateProjectileOnExhaustFractionModel>()[1].projectile;
            pro.GetBehavior<CreateProjectileOnContactModel>().projectile.GetDamageModel().damage += 1;

            var weapon = towerModel.GetWeapon();
            var proj = weapon.projectile;
            var stuck = proj.GetBehaviors<CreateProjectileOnExhaustFractionModel>()[0].projectile;
            towerModel.GetWeapon().rate -= 0.5f;

            if (towerModel.appliedUpgrades.Contains(UpgradeID<TestingUpgradesBottomPath1>()) || towerModel.appliedUpgrades.Contains(UpgradeID<GodBubbles>()))
            {
                stuck.GetBehaviors<AddBehaviorToBloonModel>()[0].GetBehavior<DamageOverTimeModel>().damage *= 1.5f;
                stuck.GetBehaviors<AddBehaviorToBloonModel>()[1].GetBehavior<DamageOverTimeModel>().damage *= 1.5f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<AddBehaviorToBloonModel>().GetBehavior<DamageOverTimeModel>().damage *= 1.5f;
                towerModel.range *= 1.05f;
                towerModel.GetAttackModel().range *= 1.05f;

            }

            if (towerModel.appliedUpgrades.Contains(UpgradeID<TestingUpgradesBottomPath2>()) || towerModel.appliedUpgrades.Contains(UpgradeID<GodBubbles>()))
            {
                stuck.GetBehaviors<AddBehaviorToBloonModel>()[0].GetBehavior<DamageOverTimeModel>().damage *= 1.5f;
                stuck.GetBehaviors<AddBehaviorToBloonModel>()[1].GetBehavior<DamageOverTimeModel>().damage *= 1.5f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<AddBehaviorToBloonModel>().GetBehavior<DamageOverTimeModel>().damage *= 1.5f;
                towerModel.range *= 1.05f;
                towerModel.GetAttackModel().range *= 1.05f;

            }

            if (towerModel.appliedUpgrades.Contains(UpgradeID<TestingUpgradesBottomPath3>()) || towerModel.appliedUpgrades.Contains(UpgradeID<GodBubbles>()))
            {
                stuck.GetBehaviors<AddBehaviorToBloonModel>()[0].GetBehavior<DamageOverTimeModel>().damage *= 1.5f;
                stuck.GetBehaviors<AddBehaviorToBloonModel>()[1].GetBehavior<DamageOverTimeModel>().damage *= 1.5f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<AddBehaviorToBloonModel>().GetBehavior<DamageOverTimeModel>().damage *= 1.5f;
                towerModel.range *= 1.05f;
                towerModel.GetAttackModel().range *= 1.05f;

            }

            if (towerModel.appliedUpgrades.Contains(UpgradeID<TestingUpgradesBottomPath4>()) || towerModel.appliedUpgrades.Contains(UpgradeID<GodBubbles>()))
            {
                stuck.GetBehaviors<AddBehaviorToBloonModel>()[0].GetBehavior<DamageOverTimeModel>().damage *= 1.5f;
                stuck.GetBehaviors<AddBehaviorToBloonModel>()[1].GetBehavior<DamageOverTimeModel>().damage *= 1.5f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<AddBehaviorToBloonModel>().GetBehavior<DamageOverTimeModel>().damage *= 1.5f;
                towerModel.range *= 1.05f;
                towerModel.GetAttackModel().range *= 1.05f;

            }

            if (towerModel.appliedUpgrades.Contains(UpgradeID<TestingUpgradesBottomPath5>()) || towerModel.appliedUpgrades.Contains(UpgradeID<GodBubbles>()))
            {
                stuck.GetBehaviors<AddBehaviorToBloonModel>()[0].GetBehavior<DamageOverTimeModel>().damage *= 1.5f;
                stuck.GetBehaviors<AddBehaviorToBloonModel>()[1].GetBehavior<DamageOverTimeModel>().damage *= 1.5f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<AddBehaviorToBloonModel>().GetBehavior<DamageOverTimeModel>().damage *= 1.5f;
                towerModel.range *= 1.05f;
                towerModel.GetAttackModel().range *= 1.05f;

            }

            if (towerModel.appliedUpgrades.Contains(UpgradeID<TestingUpgradesTopPath1>()) || towerModel.appliedUpgrades.Contains(UpgradeID<GodBubbles>()))
            {

                stuck.GetBehavior<SlowModel>().multiplier *= 0.95f;
                stuck.GetBehavior<SlowModel>().multiplier *= 0.95f;
                stuck.GetBehavior<SlowModel>().Mutator.multiplier *= 0.95f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<SlowModel>().multiplier *= 0.95f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<SlowModel>().Multiplier *= 0.95f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<SlowModel>().Mutator.multiplier *= 0.95f;
                stuck.GetBehaviors<SlowModifierForTagModel>()[1].slowMultiplier *= 0.96f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehaviors<SlowModifierForTagModel>()[1].slowMultiplier *= 0.96f;
                stuck.GetBehaviors<AddBehaviorToBloonModel>()[0].lifespan *= 1.05f;
                stuck.GetBehaviors<AddBehaviorToBloonModel>()[1].lifespan *= 1.05f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<SlowModel>().lifespan *= 1.05f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<AddBehaviorToBloonModel>().lifespan *= 1.05f;
                stuck.GetBehavior<SlowModel>().lifespan *= 1.05f;
            }

            if (towerModel.appliedUpgrades.Contains(UpgradeID<TestingUpgradesTopPath2>()) || towerModel.appliedUpgrades.Contains(UpgradeID<GodBubbles>()))
            {

                stuck.GetBehavior<SlowModel>().multiplier *= 0.95f;
                stuck.GetBehavior<SlowModel>().multiplier *= 0.95f;
                stuck.GetBehavior<SlowModel>().Mutator.multiplier *= 0.95f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<SlowModel>().multiplier *= 0.95f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<SlowModel>().Multiplier *= 0.95f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<SlowModel>().Mutator.multiplier *= 0.95f;
                stuck.GetBehaviors<SlowModifierForTagModel>()[1].slowMultiplier *= 0.96f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehaviors<SlowModifierForTagModel>()[1].slowMultiplier *= 0.96f;
                stuck.GetBehaviors<AddBehaviorToBloonModel>()[0].lifespan *= 1.05f;
                stuck.GetBehaviors<AddBehaviorToBloonModel>()[1].lifespan *= 1.05f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<SlowModel>().lifespan *= 1.05f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<AddBehaviorToBloonModel>().lifespan *= 1.05f;
                stuck.GetBehavior<SlowModel>().lifespan *= 1.05f;
            }

            if (towerModel.appliedUpgrades.Contains(UpgradeID<TestingUpgradesTopPath3>()) || towerModel.appliedUpgrades.Contains(UpgradeID<GodBubbles>()))
            {

                stuck.GetBehavior<SlowModel>().multiplier *= 0.95f;
                stuck.GetBehavior<SlowModel>().multiplier *= 0.95f;
                stuck.GetBehavior<SlowModel>().Mutator.multiplier *= 0.95f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<SlowModel>().multiplier *= 0.95f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<SlowModel>().Multiplier *= 0.95f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<SlowModel>().Mutator.multiplier *= 0.95f;
                stuck.GetBehaviors<SlowModifierForTagModel>()[1].slowMultiplier *= 0.96f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehaviors<SlowModifierForTagModel>()[1].slowMultiplier *= 0.96f;
                stuck.GetBehaviors<AddBehaviorToBloonModel>()[0].lifespan *= 1.05f;
                stuck.GetBehaviors<AddBehaviorToBloonModel>()[1].lifespan *= 1.05f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<SlowModel>().lifespan *= 1.05f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<AddBehaviorToBloonModel>().lifespan *= 1.05f;
                stuck.GetBehavior<SlowModel>().lifespan *= 1.05f;
            }

            if (towerModel.appliedUpgrades.Contains(UpgradeID<TestingUpgradesTopPath4>()) || towerModel.appliedUpgrades.Contains(UpgradeID<GodBubbles>()))
            {

                stuck.GetBehavior<SlowModel>().multiplier *= 0.95f;
                stuck.GetBehavior<SlowModel>().multiplier *= 0.95f;
                stuck.GetBehavior<SlowModel>().Mutator.multiplier *= 0.95f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<SlowModel>().multiplier *= 0.95f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<SlowModel>().Multiplier *= 0.95f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<SlowModel>().Mutator.multiplier *= 0.95f;
                stuck.GetBehaviors<SlowModifierForTagModel>()[1].slowMultiplier *= 0.96f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehaviors<SlowModifierForTagModel>()[1].slowMultiplier *= 0.96f;
                stuck.GetBehaviors<AddBehaviorToBloonModel>()[0].lifespan *= 1.05f;
                stuck.GetBehaviors<AddBehaviorToBloonModel>()[1].lifespan *= 1.05f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<SlowModel>().lifespan *= 1.05f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<AddBehaviorToBloonModel>().lifespan *= 1.05f;
                stuck.GetBehavior<SlowModel>().lifespan *= 1.05f;
            }

            if (towerModel.appliedUpgrades.Contains(UpgradeID<TestingUpgradesTopPath5>()) || towerModel.appliedUpgrades.Contains(UpgradeID<GodBubbles>()))
            {

                stuck.GetBehavior<SlowModel>().multiplier *= 0.95f;
                stuck.GetBehavior<SlowModel>().multiplier *= 0.95f;
                stuck.GetBehavior<SlowModel>().Mutator.multiplier *= 0.95f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<SlowModel>().multiplier *= 0.95f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<SlowModel>().Multiplier *= 0.95f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<SlowModel>().Mutator.multiplier *= 0.95f;
                stuck.GetBehaviors<SlowModifierForTagModel>()[1].slowMultiplier *= 0.96f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehaviors<SlowModifierForTagModel>()[1].slowMultiplier *= 0.96f;
                stuck.GetBehaviors<AddBehaviorToBloonModel>()[0].lifespan *= 1.05f;
                stuck.GetBehaviors<AddBehaviorToBloonModel>()[1].lifespan *= 1.05f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<SlowModel>().lifespan *= 1.05f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<AddBehaviorToBloonModel>().lifespan *= 1.05f;
                stuck.GetBehavior<SlowModel>().lifespan *= 1.05f;
            }
            stuck.radius *= 1.2f;
            stuck.GetBehavior<CreateProjectileOnContactModel>().projectile.radius *= 1.2f;
            pro.GetBehavior<CreateProjectileOnContactModel>().projectile.radius *= 1.2f;
        }
    }
}
