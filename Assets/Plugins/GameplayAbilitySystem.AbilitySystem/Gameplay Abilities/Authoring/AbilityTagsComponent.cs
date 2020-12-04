using Unity.Entities;
using UnityEngine;
using GameplayAbilitySystem.GameplayTags;

namespace GameplayAbilitySystem.AbilitySystem.Abilities
{

    public class AbilityTagsComponent : ConvertToAbilitySpec
    {
        public GameplayTagScriptableObject[] AbilityTags;
        public GameplayTagScriptableObject[] CancelAbilitiesWithTags;
        public GameplayTagScriptableObject[] BlockAbilitiesWithTags;
        public GameplayTagScriptableObject[] ActivationOwnedTags;
        public GameplayTagScriptableObject[] ActivationRequiredTags;
        public GameplayTagScriptableObject[] ActivationBlockedTags;
        public GameplayTagScriptableObject[] SourceRequiredTags;
        public GameplayTagScriptableObject[] SourceBlockedTags;
        public GameplayTagScriptableObject[] TargetRequiredTags;
        public GameplayTagScriptableObject[] TargetBlockedTags;

        public override void Convert(EntityManager dstManager, Entity entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
