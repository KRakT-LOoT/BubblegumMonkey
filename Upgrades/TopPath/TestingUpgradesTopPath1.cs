using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Data.Behaviors.Attacks;
using Il2CppAssets.Scripts.Data.Behaviors.Projectiles;
using Il2CppAssets.Scripts.Models;
using Il2CppAssets.Scripts.Models.Artifacts.Behaviors;
using Il2CppAssets.Scripts.Models.Towers;
using Il2CppAssets.Scripts.Models.Towers.Behaviors;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Abilities;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Abilities.Behaviors;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Emissions;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Emissions.Behaviors;
using Il2CppAssets.Scripts.Models.Towers.Filters;
using Il2CppAssets.Scripts.Models.Towers.Projectiles.Behaviors;
using Il2CppAssets.Scripts.Simulation.Towers.Behaviors;
using Il2CppAssets.Scripts.Unity;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppNinjaKiwi.Common.ResourceUtils;
using Il2CppAssets.Scripts.Models.Effects;
using BTD_Mod_Helper.Api.Display;
using Il2CppAssets.Scripts.Unity.Display;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Attack.Behaviors;


namespace BubblegumMonkey.Upgrades.TopPath
{
    internal class TestingUpgradesTopPath1 : ModUpgrade<TestingMonkey>
    {
        public override int Path => 0;

        public override int Tier => 1;

        public override int Cost => 125;
        public override string Description => "Slows Bloons down even more";
        public override string DisplayName => "Stickier Gum";

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            var attack = towerModel.GetAttackModel();
            var weapon = towerModel.GetWeapon();
            var project = weapon.projectile;
            var stuck = project.GetBehaviors<CreateProjectileOnExhaustFractionModel>()[0].projectile;
            var pro = towerModel.GetWeapon().projectile.GetBehaviors<CreateProjectileOnExhaustFractionModel>()[1].projectile;
            pro.GetBehavior<CreateProjectileOnContactModel>().projectile.GetDamageModel().damage += 1;
            stuck.GetBehavior<SlowModel>().multiplier *= 0.8f;
            stuck.GetBehavior<SlowModel>().Multiplier *= 0.8f;
            stuck.GetBehavior<SlowModel>().Mutator.multiplier *= 0.8f;
            stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<SlowModel>().multiplier *= 0.8f;
            stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<SlowModel>().Multiplier *= 0.8f;
            stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<SlowModel>().Mutator.multiplier *= 0.8f;
            stuck.GetBehaviors<SlowModifierForTagModel>()[1].slowMultiplier *= 1f;
            stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehaviors<SlowModifierForTagModel>()[1].slowMultiplier *= 1f;
            stuck.GetBehaviors<AddBehaviorToBloonModel>()[0].lifespan *= 1.2f;
            stuck.GetBehaviors<AddBehaviorToBloonModel>()[1].lifespan *= 1.2f;
            stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<SlowModel>().lifespan *= 1.2f;
            stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<AddBehaviorToBloonModel>().lifespan *= 1.2f;
            stuck.GetBehavior<SlowModel>().lifespan *= 1.2f;
            stuck.radius *= 1.2f;
            stuck.GetBehavior<CreateProjectileOnContactModel>().projectile.radius *= 1.2f;
            pro.GetBehavior<CreateProjectileOnContactModel>().projectile.radius *= 1.2f;
            /*var attack = towerModel.GetAttackModel();
            var weapon = towerModel.GetWeapon();
            var project = weapon.projectile;
            weapon.rate *= 0.5f;
            project.GetDamageModel().immuneBloonProperties = (Il2Cpp.BloonProperties)17;
            project.GetDamageModel().immuneBloonPropertiesOriginal = (Il2Cpp.BloonProperties)17;
            var emi = new RandomArcEmissionModel("Glave_", 4, 0, 360, 0, 0, null);
            var boom = Game.instance.model.GetTowerFromId("BombShooter-050").GetWeapon().projectile;
            boom.ApplyDisplay<Icon>();
            var exhaust = new CreateProjectileOnExhaustFractionModel("exhaust_", boom, emi, 0.1f, 0.1f, true, true, false);
            project.AddBehavior(exhaust);
            towerModel.ApplyDisplay<Icon>();
            var target = new TargetTypeBehavior();
            attack.fireWithoutTarget = true;
            weapon.fireWithoutTarget = true;
            var targetNormalModel = new TargetFirstModel("name", false, true);
            attack.targetProvider = targetNormalModel;
            towerModel.behaviors.RemoveItemOfType<Model, TargetFirstModel>();
            attack.behaviors.RemoveItemOfType<Model, TargetFirstModel>();*/
            /*var cashModel = new CashModel("CashModel_", 20, 20, 0, 0, false, false, false, false, false);
            project.AddBehavior(cashModel);
            var pickupModel = new PickupModel("PickupModel_", 50, 0);
            project.AddBehavior(pickupModel);*/
            /*weapon.rate = 1.2f;
            var temp = weapon.rate;
            attack.AddWeapon(Game.instance.model.GetTowerFromId("DartMonkey-005").GetWeapon().Duplicate());
            attack.RemoveWeapon(weapon);
            weapon = towerModel.GetWeapon();
            weapon.rate = temp;
            weapon.emission = new RandomArcEmissionModel("idk_", 15, 0,15, 5, 0, null);
            project = weapon.projectile;
            project.RemoveBehavior<CreateProjectileOnExhaustFractionModel>();
            var cashModel = Game.instance.model.GetTower(TowerType.Alchemist, 0, 0, 4).GetAttackModels()[1].GetDescendant<IncreaseBloonWorthModel>().Duplicate();
            var fil = Game.instance.model.GetTower(TowerType.Alchemist, 0, 0, 4).GetDescendant<FilterOutTagModel>().Duplicate();
            cashModel.filter = fil;
            project.AddBehavior(cashModel);*/
            //project.displayModel = SpriteReference(Icon);
            /*var splitThing = Game.instance.model.GetTowerFromId("DartMonkey-500").GetDescendant<CreateProjectileOnExhaustFractionModel>().Duplicate();
            splitThing.emission = new RandomArcEmissionModel("idk_", 15, 0, 15, 5, 0, null);
            var project2 = Game.instance.model.GetTowerFromId("DartMonkey-500").GetWeapon().projectile;
            project2.GetDamageModel().immuneBloonProperties = (Il2Cpp.BloonProperties)17;
            project2.GetDamageModel().immuneBloonPropertiesOriginal = (Il2Cpp.BloonProperties)17;
            splitThing.projectile = project2;
            project.AddBehavior(splitThing);
            towerModel.GetDescendants<FilterInvisibleModel>().ForEach(model => model.isActive = false);
            */
        }

    }
    internal class TestingUpgradesTopPath2 : ModUpgrade<TestingMonkey>
    {
        public override int Path => 0;
        public override int Tier => 2;
        public override int Cost => 250;
        public override string Description => "Slows Bloons down way more than before";
        public override string DisplayName => "Stronger Gum";
        public override void ApplyUpgrade(TowerModel towerModel)
        {

            var pro = towerModel.GetWeapon().projectile.GetBehaviors<CreateProjectileOnExhaustFractionModel>()[1].projectile;
            pro.GetBehavior<CreateProjectileOnContactModel>().projectile.GetDamageModel().damage += 1;
            var attack = towerModel.GetAttackModel();
            var weapon = towerModel.GetWeapon();
            var project = weapon.projectile;
            var stuck = project.GetBehaviors<CreateProjectileOnExhaustFractionModel>()[0].projectile;
            stuck.GetBehavior<SlowModel>().multiplier *= 0.8f;
            stuck.GetBehavior<SlowModel>().Multiplier *= 0.8f;
            stuck.GetBehavior<SlowModel>().Mutator.multiplier *= 0.8f;
            stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<SlowModel>().multiplier *= 0.8f;
            stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<SlowModel>().Multiplier *= 0.8f;
            stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<SlowModel>().Mutator.multiplier *= 0.8f;
            stuck.GetBehaviors<SlowModifierForTagModel>()[1].slowMultiplier *= 1f;
            stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehaviors<SlowModifierForTagModel>()[1].slowMultiplier *= 1f;
            stuck.GetBehaviors<AddBehaviorToBloonModel>()[0].lifespan *= 1.2f;
            stuck.GetBehaviors<AddBehaviorToBloonModel>()[1].lifespan *= 1.2f;
            stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<SlowModel>().lifespan *= 1.2f;
            stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<AddBehaviorToBloonModel>().lifespan *= 1.2f;
            stuck.GetBehavior<SlowModel>().lifespan *= 1.2f;
            stuck.radius *= 1.2f;
            stuck.GetBehavior<CreateProjectileOnContactModel>().projectile.radius *= 1.2f;
            pro.GetBehavior<CreateProjectileOnContactModel>().projectile.radius *= 1.2f;
        }
    }
    internal class TestingUpgradesTopPath3 : ModUpgrade<TestingMonkey>
    {
        public override int Path => 0;
        public override int Tier => 3;
        public override int Cost => 360;
        public override string Description => "Can even slow down a Moab";
        public override string DisplayName => "MOAB Gum";
        public override void ApplyUpgrade(TowerModel towerModel)
        {
            var pro = towerModel.GetWeapon().projectile.GetBehaviors<CreateProjectileOnExhaustFractionModel>()[1].projectile;
            pro.GetBehavior<CreateProjectileOnContactModel>().projectile.GetDamageModel().damage += 1;
            var attack = towerModel.GetAttackModel();
            var weapon = towerModel.GetWeapon();
            var project = weapon.projectile;
            var stuck = project.GetBehaviors<CreateProjectileOnExhaustFractionModel>()[0].projectile;
            stuck.GetBehavior<SlowModel>().multiplier *= 0.8f;
            stuck.GetBehavior<SlowModel>().Multiplier *= 0.8f;
            stuck.GetBehavior<SlowModel>().Mutator.multiplier *= 0.8f;
            stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<SlowModel>().multiplier *= 0.8f;
            stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<SlowModel>().Multiplier *= 0.8f;
            stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<SlowModel>().Mutator.multiplier *= 0.8f;
            stuck.GetBehaviors<SlowModifierForTagModel>()[1].slowMultiplier *= 0.85f;
            stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehaviors<SlowModifierForTagModel>()[1].slowMultiplier *= 0.85f;
            stuck.GetBehaviors<SlowModifierForTagModel>()[1].resetToUnmodified = false;
            stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehaviors<SlowModifierForTagModel>()[1].resetToUnmodified = false;
            stuck.GetBehaviors<AddBehaviorToBloonModel>()[0].lifespan *= 1.2f;
            stuck.GetBehaviors<AddBehaviorToBloonModel>()[1].lifespan *= 1.2f;
            stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<SlowModel>().lifespan *= 1.2f;
            stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<AddBehaviorToBloonModel>().lifespan *= 1.2f;
            stuck.GetBehavior<SlowModel>().lifespan *= 1.2f;
            stuck.radius *= 1.2f;
            stuck.GetBehavior<CreateProjectileOnContactModel>().projectile.radius *= 1.2f;
            pro.GetBehavior<CreateProjectileOnContactModel>().projectile.radius *= 1.2f;
        }
    }
    internal class TestingUpgradesTopPath4 : ModUpgrade<TestingMonkey>
    {
        public override int Path => 0;
        public override int Tier => 4;
        public override int Cost => 1700;
        public override string Description => "Slows Bloons and Moabs even more";
        public override string DisplayName => "Relentless Gum";
        public override void ApplyUpgrade(TowerModel towerModel)
        {
            var pro = towerModel.GetWeapon().projectile.GetBehaviors<CreateProjectileOnExhaustFractionModel>()[1].projectile;
            pro.GetBehavior<CreateProjectileOnContactModel>().projectile.GetDamageModel().damage += 1;
            var attack = towerModel.GetAttackModel();
            var weapon = towerModel.GetWeapon();
            var project = weapon.projectile;
            var stuck = project.GetBehaviors<CreateProjectileOnExhaustFractionModel>()[0].projectile;
            stuck.GetBehavior<SlowModel>().multiplier *= 0.8f;
            stuck.GetBehavior<SlowModel>().Multiplier *= 0.8f;
            stuck.GetBehavior<SlowModel>().Mutator.multiplier *= 0.8f;
            stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<SlowModel>().multiplier *= 0.8f;
            stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<SlowModel>().Multiplier *= 0.8f;
            stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<SlowModel>().Mutator.multiplier *= 0.8f;
            stuck.GetBehaviors<SlowModifierForTagModel>()[1].slowMultiplier *= 0.85f;
            stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehaviors<SlowModifierForTagModel>()[1].slowMultiplier *= 0.85f;
            stuck.GetBehaviors<AddBehaviorToBloonModel>()[0].lifespan *= 1.2f;
            stuck.GetBehaviors<AddBehaviorToBloonModel>()[1].lifespan *= 1.2f;
            stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<SlowModel>().lifespan *= 1.2f;
            stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<AddBehaviorToBloonModel>().lifespan *= 1.2f;
            stuck.GetBehavior<SlowModel>().lifespan *= 1.2f;
            stuck.radius *= 1.2f;
            stuck.GetBehavior<CreateProjectileOnContactModel>().projectile.radius *= 1.2f;
            pro.GetBehavior<CreateProjectileOnContactModel>().projectile.radius *= 1.2f;
        }

        }
        internal class TestingUpgradesTopPath5 : ModUpgrade<TestingMonkey>
        {
            public override int Path => 0;
            public override int Tier => 5;
            public override int Cost => 17000;
            public override string Description => "Slows Bloons and Moabs to the Max";
            public override string DisplayName => "Viscious Mucilaginous Gum";
            public override void ApplyUpgrade(TowerModel towerModel)
            {
                var pro = towerModel.GetWeapon().projectile.GetBehaviors<CreateProjectileOnExhaustFractionModel>()[1].projectile;
                pro.GetBehavior<CreateProjectileOnContactModel>().projectile.GetDamageModel().damage += 1;
                var attack = towerModel.GetAttackModel();
                var weapon = towerModel.GetWeapon();
                var project = weapon.projectile;
                var stuck = project.GetBehaviors<CreateProjectileOnExhaustFractionModel>()[0].projectile;
                stuck.GetBehavior<SlowModel>().multiplier *= 0.8f;
                stuck.GetBehavior<SlowModel>().Multiplier *= 0.8f;
                stuck.GetBehavior<SlowModel>().Mutator.multiplier *= 0.8f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<SlowModel>().multiplier *= 0.8f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<SlowModel>().Multiplier *= 0.8f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<SlowModel>().Mutator.multiplier *= 0.8f;
                stuck.GetBehaviors<SlowModifierForTagModel>()[1].slowMultiplier *= 0.85f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehaviors<SlowModifierForTagModel>()[1].slowMultiplier *= 0.85f;
                stuck.GetBehaviors<AddBehaviorToBloonModel>()[0].lifespan *= 1.2f;
                stuck.GetBehaviors<AddBehaviorToBloonModel>()[1].lifespan *= 1.2f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<SlowModel>().lifespan *= 1.2f;
                stuck.GetBehaviors<CreateProjectileOnContactModel>()[0].projectile.GetBehavior<AddBehaviorToBloonModel>().lifespan *= 1.2f;
                stuck.GetBehavior<SlowModel>().lifespan *= 1.2f;
                stuck.radius *= 1.2f;
                stuck.GetBehavior<CreateProjectileOnContactModel>().projectile.radius *= 1.2f;
                pro.GetBehavior<CreateProjectileOnContactModel>().projectile.radius *= 1.2f;
            }
    }
}
