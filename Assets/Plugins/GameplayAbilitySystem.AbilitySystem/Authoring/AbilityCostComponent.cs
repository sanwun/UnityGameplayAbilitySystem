using GameplayAbilitySystem.GameplayTags;
using Unity.Entities;
using UnityEngine;
namespace GameplayAbilitySystem.AbilitySystem
{

    [DisallowMultipleComponent]
    public class AbilityCostComponent : ConvertToSpec
    {
        public GameplayTagScriptableObject GameplayEffect;

        public override void CreateSpec(Entity entity, EntityManager dstManager)
        {
            dstManager.AddComponent<AbilityCostRefComponent>(entity);
            dstManager.SetComponentData<AbilityCostRefComponent>(entity, new AbilityCostRefComponent()
            {
                Id = GameplayEffect.Tag
            });
        }

    }
    public struct AbilityCostRefComponent : IComponentData
    {
        public GameplayTag Id;
    }
}
