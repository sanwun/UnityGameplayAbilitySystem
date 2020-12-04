using GameplayAbilitySystem.AbilitySystem.GameplayEffects.ScriptableObjects;
using Unity.Entities;
using UnityEngine;

namespace GameplayAbilitySystem.AbilitySystem.Abilities
{

    public class AbilityCostComponent<TGameplayEffectSpec, TAttributeModifierEnum, TAttributeModifierOperatorEnum> : ConvertToAbilitySpec
    where TGameplayEffectSpec : IGameplayEffectIdentifier
    where TAttributeModifierEnum : System.Enum
    where TAttributeModifierOperatorEnum : System.Enum
    {
        public BaseGameplayEffectScriptableObject<TGameplayEffectSpec, TAttributeModifierEnum, TAttributeModifierOperatorEnum> AbilityCost;

        public override void Convert(EntityManager dstManager, Entity entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
