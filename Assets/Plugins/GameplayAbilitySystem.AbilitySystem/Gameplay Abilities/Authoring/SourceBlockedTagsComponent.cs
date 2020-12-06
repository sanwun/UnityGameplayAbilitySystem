using GameplayAbilitySystem.AbilitySystem;
using Unity.Entities;
using UnityEngine;

[assembly: RegisterGenericComponentType(typeof(AbilityTagsDefinitionComponent<ISourceBlockedTags>.Component))]
namespace GameplayAbilitySystem.AbilitySystem
{
    public interface ISourceBlockedTags : IAbilityTagDefinition { }
    public class SourceBlockedTagsComponent : AbilityTagsDefinitionComponent<ISourceBlockedTags> { }
}
