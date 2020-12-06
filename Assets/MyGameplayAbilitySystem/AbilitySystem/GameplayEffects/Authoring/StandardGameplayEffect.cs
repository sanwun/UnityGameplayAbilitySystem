using GameplayAbilitySystem.AbilitySystem;
using Unity.Entities;
using UnityEngine;
using MyGameplayAbilitySystem;
using GameplayAbilitySystem.AttributeSystem;

[CreateAssetMenu(fileName = "GameplayEffect", menuName = "My Gameplay Ability System/Gameplay Effects/Standard")]
public class StandardGameplayEffect : BaseGameplayEffectScriptableObject<MySimpleGameplayEffectSpec, EMyPlayerAttribute, EMyAttributeModifierOperator>
{

    public override Entity ApplyGameplayEffect(EntityManager dstManager, MySimpleGameplayEffectSpec GameplayEffectSpec)
    {
        // Create a poison effect, that does 1 damage every 1s tick
        var dotEntity = dstManager.CreateEntity(typeof(DurationStateComponent), typeof(TimeDurationComponent), typeof(GameplayEffectContextComponent));

        dstManager.SetComponentData(dotEntity, new GameplayEffectContextComponent()
        {
            Target = GameplayEffectSpec.Context.Target,
            Source = GameplayEffectSpec.Context.Source
        });

        dstManager.SetComponentData(dotEntity, GameplayEffectSpec.Time);
        return dotEntity;
    }

    public override MySimpleGameplayEffectSpec CreateGameplayEffect(MySimpleGameplayEffectSpec Spec)
    {

        throw new System.NotImplementedException();
    }
}
