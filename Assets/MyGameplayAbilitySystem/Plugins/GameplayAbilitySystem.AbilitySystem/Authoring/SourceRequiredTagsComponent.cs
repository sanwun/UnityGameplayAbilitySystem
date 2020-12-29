using GameplayAbilitySystem.AbilitySystem;
using Unity.Entities;
using UnityEngine;

[assembly: RegisterGenericComponentType(typeof(AbilityTagsDefinitionComponent<ISourceRequiredTags>.Component))]
namespace GameplayAbilitySystem.AbilitySystem
{
    public interface ISourceRequiredTags : IAbilityTagDefinition { }
    public class SourceRequiredTagsComponent : AbilityTagsDefinitionComponent<ISourceRequiredTags> { }
}
