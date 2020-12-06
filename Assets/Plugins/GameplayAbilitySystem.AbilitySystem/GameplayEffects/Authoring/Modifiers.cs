using System;
using GameplayAbilitySystem.GameplayTags;

namespace GameplayAbilitySystem.AbilitySystem
{
    [Serializable]
    public struct Modifiers<TAttributeModifierEnum, TAttributeModifierOperatorEnum>
    where TAttributeModifierEnum : System.Enum
    where TAttributeModifierOperatorEnum : System.Enum
    {
        public TAttributeModifierOperatorEnum Modifier;
        public TAttributeModifierEnum Attribute;
        public float ModificationValue;
        public GameplayTagScriptableObject[] SourceRequiredTags;
        public GameplayTagScriptableObject[] SourceBlockedTags;
        public GameplayTagScriptableObject[] TargetRequiredTags;
        public GameplayTagScriptableObject[] TargetBlockedTags;
    }

}
