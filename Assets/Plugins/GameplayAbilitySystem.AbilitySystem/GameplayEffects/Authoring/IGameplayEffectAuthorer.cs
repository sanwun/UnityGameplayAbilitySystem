using Unity.Entities;

namespace GameplayAbilitySystem.AbilitySystem
{
    public interface IGameplayEffectAuthorer<T>
    where T : ISpecComponentProvider
    {
        Entity ApplyGameplayEffect(EntityManager dstManager, T GameplayEffectSpec);
    }

}
