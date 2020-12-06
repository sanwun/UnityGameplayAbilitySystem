using Unity.Entities;
using UnityEngine;

namespace GameplayAbilitySystem.AbilitySystem
{

    public class AbilityDefinitionComponent : ConvertToSpec
    {
        public string AbilityName;
        public string AbilityDescription;
        public Sprite Icon;

        public override void CreateSpec(Entity entity, EntityManager dstManager)
        {
            dstManager.AddComponent<Component>(entity);
            dstManager.SetComponentData<Component>(entity, new Component()
            {
                AbilityDescription = AbilityDescription,
                AbilityName = AbilityName,
                Icon = Icon
            });
        }

        public class Component : IComponentData
        {
            public string AbilityName;
            public string AbilityDescription;
            public Sprite Icon;
        }
    }


}
