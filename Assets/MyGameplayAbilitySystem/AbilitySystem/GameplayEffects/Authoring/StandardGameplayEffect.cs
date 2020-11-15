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
    public class StandardGameplayEffect : BaseGameplayEffectScriptableObject<GameplayEffectSpec, EMyPlayerAttribute, EMyAttributeModifierOperator>
    {
        public override Entity CreateEffectEntity(EntityManager dstManager, GameplayEffectSpec GameplayEffectSpec)
        {
            // Create a poison effect, that does 1 damage every 1s tick
            var dotEntity = dstManager.CreateEntity(typeof(DotGameplayEffect), typeof(DurationStateComponent), typeof(TimeDurationComponent), typeof(GameplayEffectContextComponent));
            dstManager.SetComponentData(dotEntity, new DotGameplayEffect()
            {
                DamagePerTick = GameplayEffectSpec.EffectMagnitude
            });

            dstManager.SetComponentData(dotEntity, new GameplayEffectContextComponent()
            {
                Target = GameplayEffectSpec.GameplayEffectContextComponent.Target,
                Source = GameplayEffectSpec.GameplayEffectContextComponent.Source
            });

            dstManager.SetComponentData(dotEntity, TimeDurationComponent.New(GameplayEffectSpec.TickPeriod, GameplayEffectSpec.Duration));
            return dotEntity;
        }
    }
}