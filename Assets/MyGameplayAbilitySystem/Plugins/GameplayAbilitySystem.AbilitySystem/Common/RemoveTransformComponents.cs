using Unity.Entities;
using Unity.Transforms;
using UnityEngine;

namespace GameplayAbilitySystem.AbilitySystem
{
    public class RemoveTransformComponents : MonoBehaviour, IConvertGameObjectToEntity
    {
        public void Convert(Entity entity, EntityManager dstManager, GameObjectConversionSystem conversionSystem)
        {
            dstManager.RemoveComponent<LocalToWorld>(entity);
            dstManager.RemoveComponent<Rotation>(entity);
            dstManager.RemoveComponent<Translation>(entity);
        }
    }
}