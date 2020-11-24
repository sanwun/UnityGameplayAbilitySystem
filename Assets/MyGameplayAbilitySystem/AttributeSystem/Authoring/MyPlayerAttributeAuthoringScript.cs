using Gamekit3D;
using GameplayAbilitySystem.AttributeSystem.Components;
using MyGameplayAbilitySystem;
using Unity.Entities;
using UnityEngine;

public class MyPlayerAttributeAuthoringScript : MonoBehaviour, IConvertGameObjectToEntity
{
    public EntityManager dstManager { get; private set; }
    public Entity attributeEntity { get; private set; }

    public void Convert(Entity entity, EntityManager dstManager, GameObjectConversionSystem conversionSystem)
    {
        attributeEntity = InitialiseAttributeEntity(dstManager);
        this.dstManager = dstManager;
    }

    public Entity InitialiseAttributeEntity(EntityManager dstManager)
    {
        var damagable = GetComponent<Damageable>();
        var defaultAttributes = new MyPlayerAttributes() { Health = damagable.maxHitPoints, MaxHealth = damagable.maxHitPoints };
        var _attributeEntity = MyAttributeUpdateSystem.CreatePlayerEntity(dstManager, new AttributeValues() { BaseValue = defaultAttributes });
        dstManager.SetName(_attributeEntity, $"{this.gameObject.name} - Attributes");
        return _attributeEntity;
    }
}
