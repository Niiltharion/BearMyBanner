﻿namespace BearMyBanner.Wrapper
{
    public interface IBMBAgent
    {
        bool IsAttacker { get; }
        bool IsDefender { get; }
        IBMBCharacter Character { get; }
        string PartyName { get; }
    }
}