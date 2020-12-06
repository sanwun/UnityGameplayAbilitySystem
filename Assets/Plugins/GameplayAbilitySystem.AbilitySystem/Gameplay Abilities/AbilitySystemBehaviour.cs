
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace GameplayAbilitySystem.AbilitySystem
{
    public class AbilitySystemBehaviour : MonoBehaviour
    {
        [SerializeReference]
        protected List<BaseAbility> GrantedAbilities;
        protected HashSet<BaseAbility> ActiveAbilities;

        public bool IsAbilityGranted(BaseAbility ability)
        {
            if (GrantedAbilities.FirstOrDefault(x => x == ability))
            {
                return true;
            }
            return false;
        }

        public void GrantAbility(BaseAbility ability)
        {
            // If ability already exists, don't add it again
            if (IsAbilityGranted(ability)) return;
            GrantedAbilities.Add(ability);
            ability.OnAvatarSet(this);
        }

        public void RemoveAbility(BaseAbility ability)
        {
            GrantedAbilities.Remove(ability);
            ability.OnAvatarRemove(this);
        }

        public bool TryActivateAbility(BaseAbility ability)
        {
            // If ability is already active, leave
            if (ActiveAbilities.Contains(ability)) return false;

            // Check ability logic to see if it is activatable
            if (!ability.CanActivateAbility()) return false;
            ability.ActivateAbility();
            return true;
        }

    }

}