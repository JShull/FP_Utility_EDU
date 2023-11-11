using System;
using UnityEngine;

namespace FuzzPhyte.Utility.EDU
{
    [Serializable]
    [CreateAssetMenu(fileName = "SubObjective", menuName = "FuzzPhyte/Utility/EDU/SubObjective", order = 5)]
    public class FP_SubObjective : FP_EDU_Data
    {
        [Tooltip("Most states have some sort of index for association")]
        public string StandardIndex;
        [TextArea(2,4)]
        public string SubObjective;
    }
}
