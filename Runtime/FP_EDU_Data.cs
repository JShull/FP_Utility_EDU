using System;
using UnityEngine;

namespace FuzzPhyte.Utility.EDU
{
    /// <summary>
    /// this is used mainly for our characters so we can correctly match different services later as needed
    /// for things like TTS and other visual updates as the game ages
    /// this list is from "https://www.csusm.edu/ipa/surveys/inclusive-language-guidelines.html"
    /// </summary>
    [Serializable]
    [SerializeField]
    public enum CC_Gender
    {
        Woman,
        Man,
        Transgender,
        NonBinary_NonConforming,
        Robot,
        Cyborg
    }
    /// <summary>
    /// Base class for all things tied to Data for EDU and Scriptable Objects
    /// </summary>
    public class FP_EDU_Data : ScriptableObject
    {
        /// <summary>
        /// Must be UNIQUE
        /// </summary>
        public string UniqueID;
    }
}
