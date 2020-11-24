using System.Collections.Generic;
using GameplayAbilitySystem.AbilitySystem.GameplayEffects.ScriptableObjects;
using GameplayAbilitySystem.AttributeSystem.Components;
using GameplayAbilitySystem.GameplayTags;
using UnityEngine;

namespace GameplayAbilitySystem.AbilitySystem.Abilities.ScriptableObjects
{
    public abstract class BaseAbility : ScriptableObject
    {
        protected abstract bool TryActivateAbility();
        protected abstract void EndAbility();
        protected abstract bool ApplyGameplayEffects();
        protected abstract bool CanActivateAbility();
        protected abstract bool ApplicationTagRequirementsMet();
        protected abstract bool CostRequirementsMet();
        protected abstract bool CooldownRequirementsMet();
        protected abstract bool PreActivate();
        public abstract bool ActivateAbility();
        protected abstract bool CommitAbility();
        public abstract void OnAvatarSet(AbilitySystemBehaviour abilitySystem);
        public abstract void OnAvatarRemove(AbilitySystemBehaviour abilitySystem);
        public abstract void OnGameplayAbilityEnded(AbilitySystemBehaviour abilitySystem);
    }

}