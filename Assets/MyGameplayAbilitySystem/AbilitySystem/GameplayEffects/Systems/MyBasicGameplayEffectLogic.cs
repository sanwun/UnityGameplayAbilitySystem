using MyGameplayAbilitySystem;
using Unity.Collections;
using Unity.Entities;

public class MyBasicGameplayEffectLogic : GameplayEffectApplicationSystem<MyBasicGameplayEffectLogic.MyBasicGameplayEffectJob>
{
    public override uint EffectGroupId => 1;

    protected override MyBasicGameplayEffectJob EffectJob()
    {
        return new MyBasicGameplayEffectJob();
    }

    protected override EntityQueryDesc EffectQuery()
    {
        return new EntityQueryDesc()
        {
            All = new ComponentType[] { typeof(AttributeValues) }
        };
    }

    public struct MyBasicGameplayEffectJob : IJobChunk
    {
        [ReadOnly] public ComponentTypeHandle<GameplayEffectSpec> GameplayEffectSpecType;
        public void Execute(ArchetypeChunk chunk, int chunkIndex, int firstEntityIndex)
        {
            var chunkSpecs = chunk.GetNativeArray(GameplayEffectSpecType);

            for (var i = 0; i < chunkSpecs.Length; i++)
            {
                var geSpec = chunkSpecs[i];
                // var damage = geSpec.Attributes.
            }
        }
    }
}


