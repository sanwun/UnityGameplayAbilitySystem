

using Unity.Entities;
using GameplayAbilitySystem.AbilitySystem.GameplayEffects.ScriptableObjects;
using GameplayAbilitySystem.AbilitySystem.GameplayEffects.Components;
using GameplayAbilitySystem.AttributeSystem.Components;

public struct MySimpleGameplayEffectSpec : IGameplayEffectIdentifier
{
    public GameplayEffectGroupSharedComponent EffectGroupId;
    public GameplayEffectIdentifierComponent EffectId;
    public GameplayEffectContextComponent Context;
    public PlayerAttributeCollectionComponent Attributes;
    public GameplayEffectSpecMagnitude EffectMagnitude;
    public TimeDurationComponent Time;
    public DurationStateComponent Duration;
    public MySimpleGameplayEffectBlob GameplayEffectBlobAssetRef;
    public ComponentType[] GetComponents()
    {
        return new[]
        {
            ComponentType.ReadOnly<GameplayEffectGroupSharedComponent>(),
            ComponentType.ReadOnly<GameplayEffectIdentifierComponent>(),
            ComponentType.ReadOnly<GameplayEffectContextComponent>(),
            ComponentType.ReadOnly<PlayerAttributeCollectionComponent>(),
            ComponentType.ReadOnly<GameplayEffectSpecMagnitude>(),
            ComponentType.ReadOnly<TimeDurationComponent>(),
            ComponentType.ReadOnly<DurationStateComponent>(),
            ComponentType.ReadOnly<MySimpleGameplayEffectBlob>()
        };
    }
}

public struct MySimpleGameplayEffectBlob : IComponentData
{
    public BlobAssetReference<StandardGameplayEffectBlob> reference;
}

