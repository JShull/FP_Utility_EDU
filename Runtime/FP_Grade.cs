using System;
using UnityEngine;

namespace FuzzPhyte.Utility.EDU
{
    [Serializable]
    [CreateAssetMenu(fileName = "Grade", menuName = "FuzzPhyte/Utility/EDU/Grade", order = 9)]
    public class FP_Grade : ScriptableObject
    {
        public string GradeName;
        //0 = KG, 1=first, 2=second, etc.
        [Range(0,12)]
        public int GradeLevel;
    }
}
