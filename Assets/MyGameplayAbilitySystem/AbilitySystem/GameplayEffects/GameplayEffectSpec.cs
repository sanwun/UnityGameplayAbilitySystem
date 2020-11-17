using Unity.Entities;
using GameplayAbilitySystem.AbilitySystem.GameplayEffects.ScriptableObjects;
using GameplayAbilitySystem.AbilitySystem.GameplayEffects.Components;
using GameplayAbilitySystem.AttributeSystem.Components;
using MyGameplayAbilitySystem;
using System.ComponentModel;

public struct GameplayEffectSpec : IGameplayEffectSpec, IComponentData
{
    public GameplayEffectIdentifierComponent EffectId;
    public GameplayEffectGroupSharedComponent EffectGroupId;
    public GameplayEffectContextComponent Context;
    public PlayerAttributeCollectionComponent Attributes;
    public GameplayEffectSpecMagnitude EffectMagnitude;
    public GameplayEffectSpecDuration Duration;
    public GameplayEffectTickPeriod TickPeriod;
}
