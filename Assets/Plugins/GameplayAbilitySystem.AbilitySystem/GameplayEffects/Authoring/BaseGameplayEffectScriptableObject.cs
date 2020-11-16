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
    public abstract class BaseGameplayEffectScriptableObject<TGameplayEffectSpec, TAttributeModifierEnum, TAttributeModifierOperatorEnum> : ScriptableObject, IGameplayEffectAuthorer<TGameplayEffectSpec>
    where TGameplayEffectSpec : IGameplayEffectSpec
    where TAttributeModifierEnum : System.Enum
    where TAttributeModifierOperatorEnum : System.Enum
    {
        [Header("Effect Unique ID")]
        [Tooltip("Unique ID for this Effect")]
        public uint EffectId;

        [Header("Effect Specification")]
        public DurationPolicy Duration;
        public Modifiers[] AttributeModifiers;
        public PeriodPolicy Period;

        [Header("Effect Tags")]
        public GameplayTagScriptableObject[] AssetTags;
        public GameplayTagScriptableObject[] GrantedTags;
        public GameplayTagScriptableObject[] OngoingTagRequirements;
        public GameplayTagScriptableObject[] ApplicationTagRequirements;
        public GameplayTagScriptableObject[] RemoveGameplayEffectsWithTags;
        public GameplayTagScriptableObject[] GrantedApplicationImmunityTags;

        public abstract TGameplayEffectSpec CreateGameplayEffect(TGameplayEffectSpec Spec);
        public abstract Entity CreateEffectEntity(EntityManager dstManager, TGameplayEffectSpec GameplayEffectSpec);

        [Serializable]
        public struct Modifiers
        {
            public TAttributeModifierOperatorEnum Modifier;
            public TAttributeModifierEnum Attribute;
            public float ModificationValue;
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
        public enum EDurationPolicy
        {
            Instant, Duration, Infinite
        }

    }
    public abstract class ModifierExecutionCalculation<TGameplayEffectSpec, TInstantAttributesModifier, TDurationalAttributesModifier> : ScriptableObject
    where TGameplayEffectSpec : IGameplayEffectSpec
    where TInstantAttributesModifier : IAttributeModifier
    where TDurationalAttributesModifier : IAttributeModifier
    {
        public abstract void Modify(ref TInstantAttributesModifier InstantAttributeModifier, ref TDurationalAttributesModifier DurationalAttributeModifier, TGameplayEffectSpec GameplayEffectSpec);
    }



}
