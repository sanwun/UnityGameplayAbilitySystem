
using System.Collections.Generic;
using System.Linq;
using GameplayAbilitySystem.AbilitySystem.Abilities.ScriptableObjects;
using UnityEngine;

namespace GameplayAbilitySystem.AbilitySystem.Abilities
{
    public class AbilitySystemBehaviour : MonoBehaviour
    {
        [SerializeReference]
        private List<BaseAbility> Abilities;

        [SerializeReference]
        private List<BaseAbility> ActiveAbilities;

        public bool IsAbilityGranted(BaseAbility ability)
        {
            if (Abilities.FirstOrDefault(x => x == ability))
            {
                return true;
            }
            return false;
        }

        public void GrantAbility(BaseAbility ability)
        {
            // If ability already exists, don't add it again
            if (IsAbilityGranted(ability)) return;
            Abilities.Add(ability);
            ability.OnAvatarSet(this);
        }

        public void RemoveAbility(BaseAbility ability)
        {
            Abilities.Remove(ability);
            ActiveAbilities.Remove(ability);
            ability.OnAvatarRemove(this);
        }

        public void TryActivateAbility(BaseAbility ability)
        {

        }
    }
}