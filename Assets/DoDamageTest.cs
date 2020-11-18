using Gamekit3D;
using GameplayAbilitySystem.AbilitySystem.GameplayEffects.Components;
using GameplayAbilitySystem.AttributeSystem.Components;
using MyGameplayAbilitySystem;
using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;

public class DoDamageTest : MonoBehaviour
{
    public MyPlayerAttributeAuthoringScript Character;
    public float AddValue;
    public bool Execute;

    void Update()
    {
        if (Execute)
        {
            var dstManager = Character.dstManager;
            var archetype = dstManager.CreateArchetype(new MySimpleGameplayEffectSpec().GetComponents());
            var sourceAttributes = dstManager.GetComponentData<AttributeValues>(Character.attributeEntity);
            var entity = dstManager.CreateEntity(archetype);
            dstManager.SetComponentData(entity, TimeDurationComponent.New(0, 10));
            dstManager.SetComponentData(entity, new PlayerAttributeCollectionComponent()
            {
                Source = sourceAttributes
            });
            dstManager.SetComponentData(entity, new GameplayEffectContextComponent()
            {
                Source = Character.attributeEntity,
                Target = Character.attributeEntity
            });

            // TODO: CREATE DYNAMIC BUFFER OF ATTRIBUTE MODIFIERS ATTACHED TO THE GAMEPLAYEFFECT SPEC.  THE DYNAMIC BUFFER CREATE THE ATTRIBUTE MODIFIERS

            // MyInstantAttributeUpdateSystem.CreateAttributeModifier(dstManager, new MyInstantGameplayAttributeModifier()
            // {
            //     Attribute = EMyPlayerAttribute.Health,
            //     Operator = EMyAttributeModifierOperator.Add,
            //     Value = AddValue
            // }, new GameplayAbilitySystem.AttributeSystem.Components.GameplayEffectContextComponent()
            // {
            //     Source = Entity.Null,
            //     Target = Character.attributeEntity
            // });

            Execute = false;
        }
    }

}