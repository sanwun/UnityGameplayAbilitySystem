using GameplayAbilitySystem.AbilitySystem;
using Unity.Entities;
using UnityEngine;

[assembly: RegisterGenericComponentType(typeof(AbilitySystemIdentifier<AbilityRegistryScriptableObject>.Component))]
namespace GameplayAbilitySystem.AbilitySystem
{
    [DisallowMultipleComponent]
    public class AbilityIdentifier : AbilitySystemIdentifier<AbilityRegistryScriptableObject> { }
}
