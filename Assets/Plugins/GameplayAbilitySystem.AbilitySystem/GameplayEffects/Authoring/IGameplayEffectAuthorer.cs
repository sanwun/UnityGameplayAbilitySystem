using Unity.Entities;

namespace GameplayAbilitySystem.AbilitySystem.GameplayEffects.ScriptableObjects
{
    public interface IGameplayEffectAuthorer<T>
    where T : IGameplayEffectSpec
    {
        Entity CreateEffectEntity(EntityManager dstManager, T GameplayEffectSpec);
    }

}
