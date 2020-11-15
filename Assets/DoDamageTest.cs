using Gamekit3D;
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
            MyInstantAttributeUpdateSystem.CreateAttributeModifier(dstManager, new MyInstantGameplayAttributeModifier()
            {
                Attribute = EMyPlayerAttribute.Health,
                Operator = EMyAttributeModifierOperator.Add,
                Value = AddValue
            }, new GameplayAbilitySystem.AttributeSystem.Components.GameplayEffectContextComponent()
            {
                Source = Entity.Null,
                Target = Character.attributeEntity
            });

            Execute = false;
        }
    }

}