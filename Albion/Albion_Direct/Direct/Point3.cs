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
    /* Internal type: ag4 */
    public partial struct Point3
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        private static List<FieldInfo> _fieldReflectionPool = new List<FieldInfo>();
        
        private ag4 _internal;
        
        #region Properties
        
        public ag4 Point3_Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        
        #endregion
        
        #region Constructor
        
        public Point3(ag4 instance)
        {
            _internal = instance;
        }
        
        static Point3()
        {
            
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator ag4(Point3 instance)
        {
            return instance._internal;
        }
        
        public static implicit operator Point3(ag4 instance)
        {
            return new Point3(instance);
        }
        #endregion
    }
}
