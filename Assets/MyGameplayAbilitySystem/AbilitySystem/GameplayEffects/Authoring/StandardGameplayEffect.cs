using System.Collections;
using System.Collections.Generic;
using GameplayAbilitySystem.AbilitySystem.GameplayEffects.Components;
using GameplayAbilitySystem.GameplayTags;
using Unity.Collections;
using Unity.Entities;
using UnityEngine;
using GameplayAbilitySystem.AbilitySystem.GameplayEffects.ScriptableObjects;
using GameplayAbilitySystem.AttributeSystem.Components;
using Gamekit3D;
using MyGameplayAbilitySystem;

namespace Assets.MyGameplayAbilitySystem.AbilitySystem.GameplayEffects
{
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
}