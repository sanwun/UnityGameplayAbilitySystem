using Unity.Entities;
using UnityEngine;

namespace GameplayAbilitySystem.AbilitySystem.Abilities
{

    public class AbilityDefinitionComponent : ConvertToAbilitySpec
    {
        public string AbilityName;
        public string AbilityDescription;
        public Sprite Icon;

        public override void Convert(EntityManager dstManager, Entity entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
