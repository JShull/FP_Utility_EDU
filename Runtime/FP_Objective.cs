using System;
using System.Collections.Generic;
using UnityEngine;

namespace FuzzPhyte.Utility.EDU
{
    [Serializable]
    [CreateAssetMenu(fileName = "Objective", menuName = "FuzzPhyte/Utility/EDU/Objective", order = 4)]
    public class FP_Objective : FP_EDU_Data
    {
        [Tooltip("State Associated Index")]
        public string StandardIndex;
        public int StatePDFPageRef;
        [TextArea(6,10)]
        public string Objective;
        public List<FP_SubObjective> SubObjectives;
        [TextArea(10,20)]
        public string ContextOfStandard;
        public List<FP_EssentialSkill> EssentialSkills;
        public List<FP_EssentialQuestion> EssentialQuestions;
        public List<FP_Vocab> Vocabulary;
    }
}
