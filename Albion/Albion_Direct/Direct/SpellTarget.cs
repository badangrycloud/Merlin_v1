////////////////////////////////////////////////////////////////////////////////////
// Merlin API for Albion Online v1.11.357.114734-prod
////////////////////////////////////////////////////////////////////////////////////
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by a tool.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Albion_Direct
{
    /* Internal type: cv.SpellTarget */
    public enum SpellTarget
    {
        None = 0,
        Self = 1,
        Other = 2,
        All = 3,
        AllMobs = 4,
        AllPlayers = 5,
        Enemy = 6,
        EnemyMobs = 7,
        EnemyPlayers = 8,
        FriendOther = 9,
        FriendOtherMobs = 10,
        FriendOtherPlayers = 11,
        FriendAll = 12,
        FriendAllMobs = 13,
        FriendAllPlayers = 14,
        Ground = 15,
        KnockedDownPlayer = 16,
        DeadPlayer = 17
    }
    
    public static class SpellTargetExtensions
    {
        public static cv.SpellTarget ToInternal(this SpellTarget instance)
        {
            return (cv.SpellTarget)instance;
        }
        
        public static SpellTarget ToWrapped(this cv.SpellTarget instance)
        {
            return (SpellTarget)instance;
        }
    }
}
