using System;
using UnityEngine;

namespace FuzzPhyte.Utility.EDU
{
    [Serializable]
    [CreateAssetMenu(fileName = "Character", menuName = "FuzzPhyte/Utility/EDU/Character", order = 3)]
    public class FP_Character : FP_EDU_Data
    {
        public string CharacterName;
        public CC_Gender CharacterGender;
        public FP_Theme CharacterTheme;
    }
}
