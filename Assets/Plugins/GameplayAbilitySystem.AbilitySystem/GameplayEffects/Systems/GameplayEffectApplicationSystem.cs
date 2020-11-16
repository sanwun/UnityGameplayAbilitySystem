using GameplayAbilitySystem.AbilitySystem.GameplayEffects.Components;
using GameplayAbilitySystem.AttributeSystem.Components;
using Unity.Entities;

public abstract class GameplayEffectApplicationSystem : SystemBase
{
    EndSimulationEntityCommandBufferSystem m_EndSimulationEcbSystem;
    public abstract uint EffectId { get; }
    protected override void OnUpdate()
    {
        Entities
            // WE NEED TO BE ABLE TO CODEGEN THIS, GIVEN THE INPUT EFFECT ID VARIABLE
            .WithSharedComponentFilter<GameplayEffectGroupSharedComponent>(new GameplayEffectGroupSharedComponent()
            {
                SharedGroupId = EffectId
            })

            // THIS LAMBDA SHOULD BE THE ONLY THING THAT NEEDS TO BE DEFINED IN CONCRETE CLASSES
            .ForEach((Entity entity) =>
            {
            }).ScheduleParallel();


    }
}