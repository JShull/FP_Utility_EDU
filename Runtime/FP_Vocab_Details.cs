using System;
using UnityEngine;

namespace FuzzPhyte.Utility.EDU
{
    [Serializable]
    [CreateAssetMenu(fileName = "VocabDetails", menuName = "FuzzPhyte/Utility/EDU/VocabDetails", order = 2)]
    public class FP_Vocab_Details : FP_EDU_Data
    {
        public FP_Grade GradeLevels;
        public int StatePDFPageRef;
        [TextArea(3, 6)]
        public string Definition;
    }
}
