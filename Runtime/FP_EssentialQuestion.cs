using System;
using UnityEngine;
namespace FuzzPhyte.Utility.EDU
{
    [Serializable]
    [CreateAssetMenu(fileName = "Question", menuName = "FuzzPhyte/Utility/EDU/Question", order = 7)]
    public class FP_EssentialQuestion : FP_EDU_Data
    {
        [TextArea(2,5)]
        public string Question;
    }
}
