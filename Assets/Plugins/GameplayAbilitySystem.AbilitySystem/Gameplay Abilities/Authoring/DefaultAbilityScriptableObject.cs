using System;
using GameplayAbilitySystem.AbilitySystem.GameplayEffects.ScriptableObjects;
using GameplayAbilitySystem.GameplayTags;
using UnityEngine;

namespace GameplayAbilitySystem.AbilitySystem.Abilities.ScriptableObjects
{
    public abstract class DefaultAbilityScriptableObject<TGameplayEffectSpec, TAttributeModifierEnum, TAttributeModifierOperatorEnum> : BaseAbility
    where TGameplayEffectSpec : IGameplayEffectSpec
    where TAttributeModifierEnum : System.Enum
    where TAttributeModifierOperatorEnum : System.Enum
    {
        public string AbilityName;
        public Sprite AbilityIcon;
        public GameplayTagScriptableObject[] AbilityTags;
        public GameplayTagScriptableObject[] CancelAbilitiesWithTags;
        public GameplayTagScriptableObject[] BlockAbilitiesWithTags;
        public GameplayTagScriptableObject[] ActivationOwnedTags;
        public GameplayTagScriptableObject[] ActivationRequiredTags;
        public GameplayTagScriptableObject[] ActivationBlockedTags;
        public GameplayTagScriptableObject[] SourceRequiredTags;
        public GameplayTagScriptableObject[] SourceBlockedTags;
        public GameplayTagScriptableObject[] TargetRequiredTags;
        public GameplayTagScriptableObject[] TargetBlockedTags;
        public GameplayTagEffectsTuple[] GameplayEffects;
        public BaseGameplayEffectScriptableObject<TGameplayEffectSpec, TAttributeModifierEnum, TAttributeModifierOperatorEnum>[] AbilityCost;
        public BaseGameplayEffectScriptableObject<TGameplayEffectSpec, TAttributeModifierEnum, TAttributeModifierOperatorEnum>[] AbilityCooldown;
        public bool ActivateAbilityOnGrant;

        protected override bool TryActivateAbility()
        {
            if (!CanActivateAbility()) return false;

            ActivateAbility();
            CommitAbility();
            ApplyGameplayEffects();
            EndAbility();
            return true;
        }

        protected override void EndAbility()
        {

        }
        protected override bool ApplyGameplayEffects()
        {
            return false;
        }

        protected override bool CanActivateAbility()
        {
            return false;
        }

        protected override bool ApplicationTagRequirementsMet()
        {
            return false;
        }

        protected override bool CostRequirementsMet()
        {
            return false;
        }

        protected override bool CooldownRequirementsMet()
        {
            return false;
        }

        protected override bool PreActivate()
        {
            return false;
        }

        public override bool ActivateAbility()
        {
            return false;
        }

        protected override bool CommitAbility()
        {
            return false;
        }

        public override void OnAvatarSet(AbilitySystemBehaviour abilitySystem)
        {
            if (ActivateAbilityOnGrant)
            {
                abilitySystem.TryActivateAbility(this);
            }
        }

        public override void OnAvatarRemove(AbilitySystemBehaviour abilitySystem)
        {

        }

        public override void OnGameplayAbilityEnded(AbilitySystemBehaviour abilitySystem)
        {

        }


        [Serializable]
        public struct GameplayTagEffectsTuple
        {
            public GameplayTagScriptableObject Tag;
            public BaseGameplayEffectScriptableObject<TGameplayEffectSpec, TAttributeModifierEnum, TAttributeModifierOperatorEnum>[] GameplayEffects;

        }

    }

}