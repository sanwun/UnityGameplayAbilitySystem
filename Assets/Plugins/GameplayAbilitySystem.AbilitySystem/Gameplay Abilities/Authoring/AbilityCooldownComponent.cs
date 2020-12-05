using GameplayAbilitySystem.AbilitySystem.GameplayEffects.ScriptableObjects;
using GameplayAbilitySystem.GameplayTags;
using Unity.Entities;
using UnityEngine;

namespace GameplayAbilitySystem.AbilitySystem.Abilities
{

    public class AbilityCooldownComponent<TGameplayEffectSpec, TAttributeModifierEnum, TAttributeModifierOperatorEnum> : ConvertToSpec
    where TGameplayEffectSpec : IGameplayEffectIdentifier
    where TAttributeModifierEnum : System.Enum
    where TAttributeModifierOperatorEnum : System.Enum
    {
        public BaseGameplayEffectScriptableObject<TGameplayEffectSpec, TAttributeModifierEnum, TAttributeModifierOperatorEnum> AbilityCost;

        public override void CreateSpec(Entity entity, EntityManager dstManager)
        {
            dstManager.AddComponent<AbilityCooldownRefComponent>(entity);
            if (Object.ReferenceEquals(AbilityCost, null)) return;
            dstManager.SetComponentData<AbilityCooldownRefComponent>(entity, new AbilityCooldownRefComponent()
            {
                Id = AbilityCost.Id.Tag
            });
        }
    }

    public struct AbilityCooldownRefComponent : IComponentData
    {
        public GameplayTag Id;
    }
}
