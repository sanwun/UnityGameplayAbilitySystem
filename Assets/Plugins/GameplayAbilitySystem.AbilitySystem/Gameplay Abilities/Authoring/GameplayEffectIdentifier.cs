using GameplayAbilitySystem.AbilitySystem;
using Unity.Entities;
using UnityEngine;

[assembly: RegisterGenericComponentType(typeof(AbilitySystemIdentifier<GameplayEffectRegistryScriptableObject>.Component))]
namespace GameplayAbilitySystem.AbilitySystem
{
    [DisallowMultipleComponent]
    public class GameplayEffectIdentifier : AbilitySystemIdentifier<GameplayEffectRegistryScriptableObject> { }
}
