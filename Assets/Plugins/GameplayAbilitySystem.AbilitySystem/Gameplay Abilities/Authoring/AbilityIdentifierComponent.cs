using Unity.Entities;
using UnityEngine;
using GameplayAbilitySystem.GameplayTags;

namespace GameplayAbilitySystem.AbilitySystem.Abilities
{

    public class AbilityIdentifierComponent : ConvertToSpec
    {
        public GameplayTagScriptableObject Id;

        public override void CreateSpec(Entity entity, EntityManager dstManager)
        {
            dstManager.AddComponent<Component>(entity);
            dstManager.SetComponentData(entity, new Component()
            {
                Tag = Id.Tag
            });
        }

        public struct Component : IComponentData
        {
            public GameplayTag Tag;
        }
    }
}