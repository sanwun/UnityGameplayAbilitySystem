using Unity.Entities;
using GameplayAbilitySystem.AbilitySystem.GameplayEffects.ScriptableObjects;
using GameplayAbilitySystem.AbilitySystem.GameplayEffects.Components;
using GameplayAbilitySystem.AttributeSystem.Components;
using MyGameplayAbilitySystem;
using System.ComponentModel;

public struct GameplayEffectSpec : IGameplayEffectSpec, IComponentData
{
    public uint EffectId;
    public GameplayEffectContextComponent Context;
    public PlayerAttributeCollection Attributes;
    public float EffectMagnitude;
    public float Duration;
    public float TickPeriod;
}

public struct PlayerAttributeCollection
{
    public MyPlayerAttributes SourceBaseAttributes;
    public MyPlayerAttributes SourceCurrentAttributes;
    public MyPlayerAttributes TargetBaseAttributes;
    public MyPlayerAttributes TargetCurrentAttributes;

}