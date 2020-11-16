using Unity.Entities;

namespace GameplayAbilitySystem.AttributeSystem.Components
{
    public struct GameplayEffectGroupSharedComponent : ISharedComponentData
    {
        public uint SharedGroupId;
    }
}
