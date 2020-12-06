using System.Collections.Generic;
using GameplayAbilitySystem.GameplayTags;
using Unity.Entities;
using UnityEngine;

namespace GameplayAbilitySystem.AbilitySystem
{
    public abstract class AbilitySystemRegistryScriptableObject : ScriptableObject
    {
        private Dictionary<GameplayTag, Entity> Registry = new Dictionary<GameplayTag, Entity>();

        public Entity Get(GameplayTag tag)
        {
            return Registry[tag];
        }

        public void Add(GameplayTag tag, Entity entity)
        {
            if (Registry.ContainsKey(tag))
            {
                return;
            }

            Registry.Add(tag, entity);
        }

        public void Remove(GameplayTag tag)
        {
            Registry.Remove(tag);
        }

        public void Reset()
        {
            Registry = new Dictionary<GameplayTag, Entity>();
        }

    }

}
