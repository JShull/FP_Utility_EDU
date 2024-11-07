using System;
using System.Collections.Generic;
using UnityEngine;

namespace FuzzPhyte.Utility.EDU
{
    [Serializable]
    [CreateAssetMenu(fileName = "Vocabulary", menuName = "FuzzPhyte/Utility/EDU/Vocabulary", order = 1)]
    public class FP_Vocab : FP_EDU_Data
    {
        public string Word;
        public string IPAPronunciation;
        public FP_Language Language;
        [TextArea(2,4)]
        public string Definition;
        public FP_Audio WordAudio;
        public FP_Audio DefinitionAudio;
        public List<FP_Vocab> Translations;
    }
}
