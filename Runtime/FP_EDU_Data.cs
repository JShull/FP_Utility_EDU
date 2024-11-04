using System;
using UnityEngine;

namespace FuzzPhyte.Utility.EDU
{
    
    /// <summary>
    /// Base class for all things tied to Data for EDU and Scriptable Objects
    /// </summary>
    public abstract class FP_EDU_Data : ScriptableObject
    {
        /// <summary>
        /// Must be UNIQUE
        /// </summary>
        public string UniqueID;
    }
}
