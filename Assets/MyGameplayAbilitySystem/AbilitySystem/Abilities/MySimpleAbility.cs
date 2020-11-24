using GameplayAbilitySystem.AbilitySystem.Abilities.ScriptableObjects;
using MyGameplayAbilitySystem;
using UnityEngine;

[CreateAssetMenu(fileName = "My Simple Ability", menuName = "My Gameplay Ability System/Abilities/Simple")]
public class MySimpleAbility : DefaultAbilityScriptableObject<MySimpleGameplayEffectSpec, EMyPlayerAttribute, EMyAttributeModifierOperator>
{

}
