using Unity.Entities;
using GameplayAbilitySystem.AbilitySystem.GameplayEffects.ScriptableObjects;
using GameplayAbilitySystem.AbilitySystem.GameplayEffects.Components;
using GameplayAbilitySystem.AttributeSystem.Components;
using MyGameplayAbilitySystem;
using System.ComponentModel;

public struct GameplayEffectSpec : IGameplayEffectSpec, IComponentData
{
    public GameplayEffectIdentifierComponent EffectId;
    public GameplayEffectContextComponent Context;
    public PlayerAttributeCollectionComponent Attributes;
    public float EffectMagnitude;
    public float Duration;
    public float TickPeriod;
}
