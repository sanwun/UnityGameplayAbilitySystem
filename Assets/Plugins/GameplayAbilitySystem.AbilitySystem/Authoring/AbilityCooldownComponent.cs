using GameplayAbilitySystem.GameplayTags;
using Unity.Entities;
using UnityEngine;

namespace GameplayAbilitySystem.AbilitySystem
{

    [DisallowMultipleComponent]
    public class AbilityCooldownComponent : ConvertToSpec
    {
        public GameplayTagScriptableObject GameplayEffect;
        public override void CreateSpec(Entity entity, EntityManager dstManager)
        {
            dstManager.AddComponent<AbilityCooldownRefComponent>(entity);
            if (Object.ReferenceEquals(GameplayEffect, null)) return;
            dstManager.SetComponentData<AbilityCooldownRefComponent>(entity, new AbilityCooldownRefComponent()
            {
                Id = GameplayEffect.Tag
            });
        }
    }

    public struct AbilityCooldownRefComponent : IComponentData
    {
        public GameplayTag Id;
    }
}
