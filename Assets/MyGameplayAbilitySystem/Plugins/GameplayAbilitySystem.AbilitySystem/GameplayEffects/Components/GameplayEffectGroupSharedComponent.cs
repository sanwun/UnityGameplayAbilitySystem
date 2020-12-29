using Unity.Entities;

namespace GameplayAbilitySystem.AbilitySystem
{
    public struct GameplayEffectGroupSharedComponent : ISharedComponentData
    {
        public uint SharedGroupId;
    }
}
