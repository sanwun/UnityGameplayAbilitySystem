using Unity.Entities;

namespace GameplayAbilitySystem.AbilitySystem.GameplayEffects.ScriptableObjects
{
    public interface IGameplayEffectSpec
    {
        ComponentType[] GetComponents();
    }

}
