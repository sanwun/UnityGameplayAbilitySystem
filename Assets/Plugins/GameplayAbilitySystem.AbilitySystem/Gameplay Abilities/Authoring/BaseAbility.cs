using System.Collections.Generic;
using GameplayAbilitySystem.AbilitySystem.GameplayEffects.ScriptableObjects;
using GameplayAbilitySystem.AttributeSystem.Components;
using GameplayAbilitySystem.GameplayTags;
using Unity.Entities;
using UnityEngine;

namespace GameplayAbilitySystem.AbilitySystem.Abilities.ScriptableObjects
{
    public abstract class BaseAbility : ScriptableObject
    {
        public GameplayTagScriptableObject AbilityIdentifier;
        protected abstract void EndAbility();
        protected abstract bool ApplyGameplayEffects();
        public abstract bool CanActivateAbility();
        protected abstract bool ApplicationTagRequirementsMet();
        protected abstract bool CostRequirementsMet();
        protected abstract bool CooldownRequirementsMet();
        protected abstract void PreActivate();
        public abstract void ActivateAbility();
        protected abstract bool CommitAbility();
        public abstract void OnAvatarSet(AbilitySystemBehaviour abilitySystem);
        public abstract void OnAvatarRemove(AbilitySystemBehaviour abilitySystem);
        public abstract void OnGameplayAbilityEnded(AbilitySystemBehaviour abilitySystem);
        public abstract float GetCooldownForAbility(AbilitySystemBehaviour abilitySystem);

        public abstract Entity CreateAbilitySpec(EntityManager dstManager);

        public void CreateSpec()
        {

        }
    }



}