using Unity.Entities;
using GameplayAbilitySystem.AbilitySystem.GameplayEffects.ScriptableObjects;
using GameplayAbilitySystem.AbilitySystem.GameplayEffects.Components;
using GameplayAbilitySystem.AttributeSystem.Components;

public struct GameplayEffectSpec : IGameplayEffectSpec
{
    public Entity Source;
    public Entity Target;
    public float Damage;
    public float Duration;
    public float TickPeriod;
    public DurationStateComponent DurationStateComponent;
    public TimeDurationComponent TimeDurationComponent;
    public GameplayEffectContextComponent GameplayEffectContextComponent;

}