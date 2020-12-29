using Unity.Entities;

namespace GameplayAbilitySystem.AbilitySystem
{
    public interface ISpecComponentProvider
    {
        ComponentType[] GetComponents();
    }
}
