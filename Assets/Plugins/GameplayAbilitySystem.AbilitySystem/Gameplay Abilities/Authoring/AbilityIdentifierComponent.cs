using Unity.Entities;
using UnityEngine;
using GameplayAbilitySystem.GameplayTags;

namespace GameplayAbilitySystem.AbilitySystem
{

    public class AbilityIdentifierComponent : ConvertToSpec
    {
        public GameplayTagScriptableObject Id;
        public AbilityRegistryScriptableObject Registry;

        public override void CreateSpec(Entity entity, EntityManager dstManager)
        {
            dstManager.AddComponent<Component>(entity);
            dstManager.SetComponentData(entity, new Component()
            {
                Tag = Id.Tag
            });

            Registry.Add(Id.Tag, entity);
        }

        public struct Component : IComponentData
        {
            public GameplayTag Tag;
        }
    }
}
