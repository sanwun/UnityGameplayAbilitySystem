using GameplayAbilitySystem.AbilitySystem;
using Unity.Entities;
using UnityEngine;

[assembly: RegisterGenericComponentType(typeof(AbilityTagsDefinitionComponent<IBlockAbilitiesWithTags>.Component))]
namespace GameplayAbilitySystem.AbilitySystem
{
    public interface IBlockAbilitiesWithTags : IAbilityTagDefinition { }
    public class BlockAbilitiesWithTagsComponent : AbilityTagsDefinitionComponent<IBlockAbilitiesWithTags> { }
}
