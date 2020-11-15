using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using GameplayAbilitySystem.AttributeSystem.Components;
using Unity.Entities;

namespace MyGameplayAbilitySystem
{

    [Serializable]
    public struct MyPlayerAttributes
    {
        public float Health;
        public float MaxHealth;
        public float Mana;
        public float MaxMana;
        public float Speed;
        public float PhysicalAttackDamage;
        public float MagicAttackDamage;
        public float PhysicalDefense;
        public float MagicDefense;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void GetAttribute(EMyPlayerAttribute attribute, ref float value)
        {
            switch (attribute)
            {
                case EMyPlayerAttribute.Health:
                    value = Health;
                    break;
                case EMyPlayerAttribute.MaxHealth:
                    value = MaxHealth;
                    break;
                case EMyPlayerAttribute.Mana:
                    value = Mana;
                    break;
                case EMyPlayerAttribute.MaxMana:
                    value = MaxMana;
                    break;
                case EMyPlayerAttribute.Speed:
                    value = Speed;
                    break;
                case EMyPlayerAttribute.PhysicalAttackDamage:
                    value = PhysicalAttackDamage;
                    break;
                case EMyPlayerAttribute.MagicAttackDamage:
                    value = MagicAttackDamage;
                    break;
                case EMyPlayerAttribute.PhysicalDefense:
                    value = PhysicalDefense;
                    break;
                case EMyPlayerAttribute.MagicDefense:
                    value = MagicDefense;
                    break;
            }
        }
        public float this[EMyPlayerAttribute attribute]
        {
            get
            {
                float value = 0;
                GetAttribute(attribute, ref value);
                return value;
            }
            set
            {
                float oldValue = 0;
                GetAttribute(attribute, ref oldValue);
                oldValue = value;
            }

        }
    }

}


