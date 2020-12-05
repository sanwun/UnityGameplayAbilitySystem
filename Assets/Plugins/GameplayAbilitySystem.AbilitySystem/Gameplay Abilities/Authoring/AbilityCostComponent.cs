using GameplayAbilitySystem.AbilitySystem.GameplayEffects.ScriptableObjects;
using GameplayAbilitySystem.GameplayTags;
using Unity.Entities;
using UnityEngine;
namespace GameplayAbilitySystem.AbilitySystem.Abilities
{

    public class AbilityCostComponent<TGameplayEffectSpec, TAttributeModifierEnum, TAttributeModifierOperatorEnum> : ConvertToSpec
    where TGameplayEffectSpec : IGameplayEffectIdentifier
    where TAttributeModifierEnum : System.Enum
    where TAttributeModifierOperatorEnum : System.Enum
    {
        public BaseGameplayEffectScriptableObject<TGameplayEffectSpec, TAttributeModifierEnum, TAttributeModifierOperatorEnum> AbilityCost;

        public override void CreateSpec(Entity entity, EntityManager dstManager)
        {
            dstManager.AddComponent<AbilityCostRefComponent>(entity);
            dstManager.SetComponentData<AbilityCostRefComponent>(entity, new AbilityCostRefComponent()
            {
                Id = AbilityCost.Id.Tag
            });
        }

    }
    public struct AbilityCostRefComponent : IComponentData
    {
        public GameplayTag Id;
    }
}
