using GameplayAbilitySystem.AbilitySystem.GameplayEffects.Components;
using Unity.Entities;

public class GameplayEffectApplicationSystem : SystemBase
{
    EndSimulationEntityCommandBufferSystem m_EndSimulationEcbSystem;

    protected override void OnUpdate()
    {
        Entities
            .ForEach((int entityInQueryIndex, Entity entity, ref TimeDurationComponent durationComponent, ref DurationStateComponent state) =>
            {

            })
            .WithBurst()
            .ScheduleParallel();
    }
}