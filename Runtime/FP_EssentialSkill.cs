using System;
using UnityEngine;
namespace FuzzPhyte.Utility.EDU
{
    [Serializable]
    [CreateAssetMenu(fileName = "Skill", menuName = "FuzzPhyte/Utility/EDU/Skill", order = 6)]
    public class FP_EssentialSkill : FP_EDU_Data
    {
        [TextArea(3,6)]
        public string Skill;
    }
}
