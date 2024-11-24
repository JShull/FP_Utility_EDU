namespace FuzzPhyte.Utility.EDU
{
    using System;
    using System.Collections.Generic;
    using UnityEngine;

    [Serializable]
    [CreateAssetMenu(fileName = "Vocabulary", menuName = "FuzzPhyte/Utility/EDU/Vocabulary", order = 1)]
    public class FP_Vocab : FP_EDU_Data
    {
        //I+1 = cap on going from one to the next but no more Input hypothesis
        // prime for incidental acquisition learning
        // glossing = term for pop up/ bringing attention to items via labels
        // post Q&A should have a random 'incidental' item thrown in based on actions and/or lack of actions
        public string Word;
        public string IPAPronunciation;
        public FP_Language Language;
        public FP_LanguageLevel LevelIntroduced;
        public CEFRLevel CEFRLevel;
        public FP_VocabCategory VocabCategory;
        [TextArea(2,4)]
        public string Definition;
        [Space]
        [Header("Audio related")]
        public FP_Audio WordAudio;
        public FP_Audio DefinitionAudio;
        [Space]
        [Header("Connections and Translations")]
        public List<FP_Vocab> Translations;
        public List<FPSemanticMap> SemanticMaps;
        [Space]
        [Header("Important Modifiers: Not Required")]
        // just a way to add more information that could be associated with the word
        // it's association is just singular based on English concepts and might not work for all cases
        // this is more/less for early modules to give us additional information when needed
        // e.g. user picks an article of clothing that has a 'color' and 'size' but not a 'shape'
        public FP_Vocab Opinion;
        public FP_Vocab Size;
        public FP_Vocab Color;
        public FP_Vocab Shape;
        public FP_Vocab Age;
        public FP_Vocab Texture;
        public FP_Vocab Material;
        public FP_Vocab Purpose;
    }
}
