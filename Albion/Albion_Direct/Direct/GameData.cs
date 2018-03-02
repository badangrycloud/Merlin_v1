////////////////////////////////////////////////////////////////////////////////////
// Merlin API for Albion Online v1.10.351.112411-prod
////////////////////////////////////////////////////////////////////////////////////
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by a tool.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;

using UnityEngine;

using Albion.Common.Time;

namespace Albion_Direct
{
    /* Internal type: h0 */
    public partial class GameData
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        private static List<FieldInfo> _fieldReflectionPool = new List<FieldInfo>();
        
        private h0 _internal;
        
        #region Properties
        
        public h0 GameData_Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        public AgentsDataFile GetAgents() => _internal.a5();
        public BuildingDataFile GetBuildings() => _internal.@as();
        public GameDataFile GetGameData() => _internal.au();
        public ItemsDataFile GetItems() => _internal.aq();
        public MobCharactersDataFile GetMobCharacters() => _internal.av();
        public PlayerCharactersDataFile GetPlayerCharacters() => _internal.ax();
        public SpellsDataFile GetSpells() => _internal.ar();
        public WorldDataFile GetWorld() => _internal.a0();
        
        #endregion
        
        #region Constructor
        
        public GameData(h0 instance)
        {
            _internal = instance;
        }
        
        static GameData()
        {
            
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator h0(GameData instance)
        {
            return instance._internal;
        }
        
        public static implicit operator GameData(h0 instance)
        {
            return new GameData(instance);
        }
        
        public static implicit operator bool(GameData instance)
        {
            return instance._internal != null;
        }
        #endregion
    }
}
