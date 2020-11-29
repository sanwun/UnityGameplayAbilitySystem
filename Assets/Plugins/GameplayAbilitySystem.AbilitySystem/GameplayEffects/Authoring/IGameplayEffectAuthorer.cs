using GameplayAbilitySystem.AbilitySystem.Common;
using Unity.Entities;

namespace GameplayAbilitySystem.AbilitySystem.GameplayEffects.ScriptableObjects
{
    public interface IGameplayEffectAuthorer<T>
    where T : ISpecComponentProvider
    {
        Entity ApplyGameplayEffect(EntityManager dstManager, T GameplayEffectSpec);
    }

}
