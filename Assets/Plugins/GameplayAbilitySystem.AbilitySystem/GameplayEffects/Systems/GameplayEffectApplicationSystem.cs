using GameplayAbilitySystem.AbilitySystem.GameplayEffects.Components;
using GameplayAbilitySystem.AttributeSystem.Components;
using Unity.Entities;
using System.Collections.Generic;
using System.Linq;

public abstract class GameplayEffectApplicationSystem<TJob> : SystemBase
where TJob : struct, IJobChunk
{
    EndSimulationEntityCommandBufferSystem m_EndSimulationEcbSystem;
    public abstract uint EffectGroupId { get; }
    protected EntityQuery m_query;
    EntityQueryDesc sharedComponentDesc = new EntityQueryDesc()
    {
        All = new ComponentType[] { typeof(GameplayEffectGroupSharedComponent) },

    };

    protected sealed override void OnCreate()
    {
        var entityQueryDesc = EffectQuery();
        entityQueryDesc.All = entityQueryDesc.All.Append(typeof(GameplayEffectGroupSharedComponent)).ToArray();
        m_query = GetEntityQuery(entityQueryDesc);
        m_query.SetSharedComponentFilter(new GameplayEffectGroupSharedComponent() { SharedGroupId = EffectGroupId });
    }
    protected abstract EntityQueryDesc EffectQuery();
    protected abstract TJob EffectJob();
    protected sealed override void OnUpdate()
    {
        var a = EffectJob();
        Dependency = a.ScheduleParallel(m_query, Dependency);
    }

}