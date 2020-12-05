using Unity.Entities;
using GameplayAbilitySystem.AbilitySystem.Abilities;
[assembly: RegisterGenericComponentType(typeof(AbilityTagsDefinitionComponent<IAbilityTags>.Component))]
namespace GameplayAbilitySystem.AbilitySystem.Abilities
{
    public interface IAbilityTags : IAbilityTagDefinition { }

    public class AbilityTagsComponent : AbilityTagsDefinitionComponent<IAbilityTags> { }
}
