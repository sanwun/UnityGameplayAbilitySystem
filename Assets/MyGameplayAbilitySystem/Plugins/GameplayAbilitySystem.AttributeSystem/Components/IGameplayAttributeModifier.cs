using Unity.Entities;

namespace GameplayAbilitySystem.AttributeSystem
{
    public interface IGameplayAttributeModifier<TAttributeModifier>
    where TAttributeModifier : struct, IAttributeModifier, IComponentData
    {
        void UpdateAttribute(ref TAttributeModifier attributeModifier);
    }
}
