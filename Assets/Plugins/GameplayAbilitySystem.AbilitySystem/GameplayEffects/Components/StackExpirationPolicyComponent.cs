using Unity.Entities;

namespace GameplayAbilitySystem.AbilitySystem
{
    public struct StackExpirationPolicyComponent : IComponentData
    {
        public EStackExpirationPolicy StackExpirationPolicy;
    }
}