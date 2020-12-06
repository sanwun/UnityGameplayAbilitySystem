using System;

namespace GameplayAbilitySystem.AbilitySystem
{
    [Flags]
    public enum EDurationState : byte
    {
        None = 0,
        TICKED_SINCE_RESET = 1,
        TICKED_THIS_FRAME = 2,
        EXPIRED = 4,
    }
}