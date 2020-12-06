using GameplayAbilitySystem.AbilitySystem;
using Unity.Entities;
using UnityEngine;

[assembly: RegisterGenericComponentType(typeof(AbilityTagsDefinitionComponent<ICancelAbilitiesWithTags>.Component))]
namespace GameplayAbilitySystem.AbilitySystem
{
    public interface ICancelAbilitiesWithTags : IAbilityTagDefinition { }
    public class CancelAbilitiesWithTagsComponent : AbilityTagsDefinitionComponent<ICancelAbilitiesWithTags> { }
}
