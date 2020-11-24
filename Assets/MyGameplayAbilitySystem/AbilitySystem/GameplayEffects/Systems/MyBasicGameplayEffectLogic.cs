using GameplayAbilitySystem.AbilitySystem.GameplayEffects.Components;
using GameplayAbilitySystem.AttributeSystem.Components;
using MyGameplayAbilitySystem;
using Unity.Collections;
using Unity.Entities;

public class MyBasicGameplayEffectLogic : GameplayEffectApplicationSystem<MySimpleGameplayEffectSpec, MyBasicGameplayEffectLogic.MyBasicGameplayEffectJob>
{
    public override uint EffectGroupId => 1;

    protected override MyBasicGameplayEffectJob EffectJob()
    {
        return new MyBasicGameplayEffectJob()
        {
            GameplayEffectIdentifierComponentType = GetComponentTypeHandle<GameplayEffectIdentifierComponent>(true),
            GameplayEffectContextComponentType = GetComponentTypeHandle<GameplayEffectContextComponent>(true),
            PlayerAttributeCollectionComponentType = GetComponentTypeHandle<PlayerAttributeCollectionComponent>(true),
            GameplayEffectSpecMagnitudeType = GetComponentTypeHandle<GameplayEffectSpecMagnitude>(true),
            TimeDurationComponentType = GetComponentTypeHandle<TimeDurationComponent>(true),
        };
    }

    public struct MyBasicGameplayEffectJob : IJobChunk
    {
        [ReadOnly] public ComponentTypeHandle<GameplayEffectIdentifierComponent> GameplayEffectIdentifierComponentType;
        [ReadOnly] public ComponentTypeHandle<GameplayEffectContextComponent> GameplayEffectContextComponentType;
        [ReadOnly] public ComponentTypeHandle<PlayerAttributeCollectionComponent> PlayerAttributeCollectionComponentType;
        [ReadOnly] public ComponentTypeHandle<GameplayEffectSpecMagnitude> GameplayEffectSpecMagnitudeType;
        [ReadOnly] public ComponentTypeHandle<TimeDurationComponent> TimeDurationComponentType;
        public void Execute(ArchetypeChunk chunk, int chunkIndex, int firstEntityIndex)
        {
            var chunkGameplayEffectId = chunk.GetNativeArray(GameplayEffectIdentifierComponentType);
            var chunkGameplayEffectContext = chunk.GetNativeArray(GameplayEffectContextComponentType);
            var chunkPlayerAttributeCollection = chunk.GetNativeArray(PlayerAttributeCollectionComponentType);
            var chunkGameplayEffectSpecMagnitude = chunk.GetNativeArray(GameplayEffectSpecMagnitudeType);
            var chunkTimeDuration = chunk.GetNativeArray(TimeDurationComponentType);

            for (var i = 0; i < chunkGameplayEffectId.Length; i++)
            {

                // var damage = geSpec.Attributes.
            }
        }
    }
}


public struct GameplayEffectBlobComponent : IComponentData
{
    public BlobAssetReference<StandardGameplayEffectBlob> reference;
}
