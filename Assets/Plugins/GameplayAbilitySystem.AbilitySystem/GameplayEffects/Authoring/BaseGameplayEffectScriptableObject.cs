using System.Collections;
using GameplayAbilitySystem.AbilitySystem.GameplayEffects.Components;
using GameplayAbilitySystem.AttributeSystem.Components;
using GameplayAbilitySystem.GameplayTags;
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
        [SerializeField]
        public uint EffectId;

        [Header("Grouping ID")]
        [Tooltip("Group ID for this Effect.  Used for controlling the effect logic.")]
        [SerializeField]
        public uint GroupEffectId;

        [Header("Effect Specification")]
        public DurationPolicy Duration;
        public Modifiers<TAttributeModifierEnum, TAttributeModifierOperatorEnum>[] AttributeModifiers;
        public PeriodPolicy Period;

        [Header("Effect Tags")]
        public GameplayTagScriptableObject[] AssetTags;
        public GameplayTagScriptableObject[] GrantedTags;
        public GameplayTagScriptableObject[] OngoingTagRequirements;
        public GameplayTagScriptableObject[] ApplicationTagRequirements;
        public GameplayTagScriptableObject[] RemoveGameplayEffectsWithTags;
        public GameplayTagScriptableObject[] GrantedApplicationImmunityTags;
        public abstract TGameplayEffectSpec CreateGameplayEffect(TGameplayEffectSpec Spec);
        public abstract Entity ApplyGameplayEffect(EntityManager dstManager, TGameplayEffectSpec GameplayEffectSpec);
    }

    public abstract class ModifierExecutionCalculation<TGameplayEffectSpec, TInstantAttributesModifier, TDurationalAttributesModifier> : ScriptableObject
    where TGameplayEffectSpec : IGameplayEffectSpec
    where TInstantAttributesModifier : IAttributeModifier
    where TDurationalAttributesModifier : IAttributeModifier
    {
        public abstract void Modify(ref TInstantAttributesModifier InstantAttributeModifier, ref TDurationalAttributesModifier DurationalAttributeModifier, TGameplayEffectSpec GameplayEffectSpec);
    }

}
