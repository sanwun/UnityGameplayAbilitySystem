using System.Collections.Generic;
using GameplayAbilitySystem.GameplayTags;
using Unity.Collections;
using Unity.Entities;
using UnityEngine;

namespace GameplayAbilitySystem.AbilitySystem.Abilities
{
    [CreateAssetMenu(fileName = "Ability Registry", menuName = "My Gameplay Ability System/Abilities/Registry")]
    public class AbilityRegistryScriptableObject : ScriptableObject
    {
        [SerializeField]
        public Dictionary<GameplayTag, Entity> Registry = new Dictionary<GameplayTag, Entity>();

        public Entity Get(GameplayTag tag)
        {
            return Registry[tag];
        }

        public void Add(GameplayTag tag, Entity entity)
        {
            Registry.Add(tag, entity);
        }

        public void Remove(GameplayTag tag)
        {
            Registry.Remove(tag);
        }

    }

}
