using Unity.Entities;
using UnityEngine;
using GameplayAbilitySystem.GameplayTags;

namespace GameplayAbilitySystem.AbilitySystem.Abilities
{

    public class AbilityIdentifierComponent : ConvertToAbilitySpec
    {
        public GameplayTagScriptableObject Id;

        public override void Convert(EntityManager dstManager, Entity entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
