using System;
using System.Collections;
using System.Collections.Generic;
using GameplayAbilitySystem.AbilitySystem.GameplayEffects.Components;
using GameplayAbilitySystem.AttributeSystem.Components;
using GameplayAbilitySystem.GameplayTags;
using Unity.Collections;
using Unity.Entities;
using UnityEngine;

namespace GameplayAbilitySystem.AbilitySystem.GameplayEffects.ScriptableObjects
{
    public abstract class BaseGameplayEffectScriptableObject<TGameplayEffectSpec, TInstantAttributesModifier, TDurationalAttributesModifier> : ScriptableObject, IGameplayEffectAuthorer<TGameplayEffectSpec>
    where TGameplayEffectSpec : IGameplayEffectSpec
    where TInstantAttributesModifier : IAttributeModifier
    where TDurationalAttributesModifier : IAttributeModifier
    {
        [Header("Effect Unique ID")]
        [Tooltip("Unique ID for this Effect")]
        public uint EffectId;


        [Header("Effect Specification")]
        public DurationPolicy Duration;
        public List<Modifiers> AttributeModifiers;
        public PeriodPolicy Period;

        [Header("Effect Tags")]
        public GameplayTagScriptableObject[] AssetTags;
        public GameplayTagScriptableObject[] GrantedTags;
        public GameplayTagScriptableObject[] OngoingTagRequirements;
        public GameplayTagScriptableObject[] ApplicationTagRequirements;
        public GameplayTagScriptableObject[] RemoveGameplayEffectsWithTags;
        public GameplayTagScriptableObject[] GrantedApplicationImmunityTags;
        public abstract Entity CreateEffectEntity(EntityManager dstManager, TGameplayEffectSpec GameplayEffectSpec);

        [Serializable]
        public struct Modifiers
        {
            public TInstantAttributesModifier InstantAttributes;
            public TDurationalAttributesModifier DurationalAttributes;
            public GameplayTagScriptableObject[] SourceRequiredTags;
            public GameplayTagScriptableObject[] SourceBlockedTags;
            public GameplayTagScriptableObject[] TargetRequiredTags;
            public GameplayTagScriptableObject[] TargetBlockedTags;
        }

        [Serializable]
        public struct PeriodPolicy
        {
            public float Period;
            public bool ExecuteOnApplication;
        }

        [Serializable]
        public struct DurationPolicy
        {
            public EDurationPolicy DurationType;
            public float Duration;
        }
    }


    public enum EDurationPolicy
    {
        Instant, Duration, Infinite
    }

}
