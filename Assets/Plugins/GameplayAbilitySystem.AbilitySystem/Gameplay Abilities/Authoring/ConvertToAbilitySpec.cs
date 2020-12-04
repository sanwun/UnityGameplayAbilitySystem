using Unity.Entities;
using UnityEngine;

namespace GameplayAbilitySystem.AbilitySystem.Abilities
{
    public class ConvertToAbilitySpec : MonoBehaviour, IConvertGameObjectToEntity
    {


        public virtual void Convert(EntityManager dstManager, Entity entity) { }

        public void Convert(Entity entity, EntityManager dstManager, GameObjectConversionSystem conversionSystem)
        {
            var components = this.GetComponents<ConvertToAbilitySpec>();
            for (var i = 0; i < components.Length; i++)
            {
                components[i].Convert(dstManager, entity);
            }
        }
    }
}