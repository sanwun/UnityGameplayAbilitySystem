using Unity.Entities;

namespace GameplayAbilitySystem.AbilitySystem.Common
{
    public interface ISpecComponentProvider
    {
        ComponentType[] GetComponents();
    }
}
