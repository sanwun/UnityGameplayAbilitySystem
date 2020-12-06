using Unity.Entities;
using GameplayAbilitySystem.AbilitySystem;

[assembly: RegisterGenericComponentType(typeof(AbilityTagsDefinitionComponent<IAbilityTags>.Component))]
namespace GameplayAbilitySystem.AbilitySystem
{
    public interface IAbilityTags : IAbilityTagDefinition { }

    public class AbilityTagsComponent : AbilityTagsDefinitionComponent<IAbilityTags> { }
}
