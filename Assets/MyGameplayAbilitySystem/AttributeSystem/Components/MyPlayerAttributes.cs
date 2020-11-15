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

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void SetAttribute(EMyPlayerAttribute attribute, float value)
        {
            switch (attribute)
            {
                case EMyPlayerAttribute.Health:
                    Health = value;
                    break;
                case EMyPlayerAttribute.MaxHealth:
                    MaxHealth = value;
                    break;
                case EMyPlayerAttribute.Mana:
                    Mana = value;
                    break;
                case EMyPlayerAttribute.MaxMana:
                    MaxMana = value;
                    break;
                case EMyPlayerAttribute.Speed:
                    Speed = value;
                    break;
                case EMyPlayerAttribute.PhysicalAttackDamage:
                    PhysicalAttackDamage = value;
                    break;
                case EMyPlayerAttribute.MagicAttackDamage:
                    MagicAttackDamage = value;
                    break;
                case EMyPlayerAttribute.PhysicalDefense:
                    PhysicalDefense = value;
                    break;
                case EMyPlayerAttribute.MagicDefense:
                    MagicDefense = value;
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
                SetAttribute(attribute, value);
            }

        }
    }

}


