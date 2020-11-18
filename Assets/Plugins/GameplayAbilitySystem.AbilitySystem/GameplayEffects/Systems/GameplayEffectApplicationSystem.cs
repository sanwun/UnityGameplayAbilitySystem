using GameplayAbilitySystem.AbilitySystem.GameplayEffects.Components;
using GameplayAbilitySystem.AttributeSystem.Components;
using Unity.Entities;
using GameplayAbilitySystem.AbilitySystem.GameplayEffects.ScriptableObjects;

public abstract class GameplayEffectApplicationSystem<TGameplayEffectSpec, TJob> : SystemBase
where TGameplayEffectSpec : struct, IGameplayEffectSpec
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
        m_query = GetEntityQuery(new TGameplayEffectSpec().GetComponents());
        m_query.SetSharedComponentFilter(new GameplayEffectGroupSharedComponent() { SharedGroupId = EffectGroupId });
    }
    protected abstract TJob EffectJob();
    protected sealed override void OnUpdate()
    {
        var a = EffectJob();
        Dependency = a.ScheduleParallel(m_query, Dependency);
    }

}