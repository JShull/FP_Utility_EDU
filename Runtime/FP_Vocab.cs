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
        // prime for incedental acquisition learning
        // glossing = term for pop up/ bringing attention to items via labels
        // post Q&A should have a random 'incidential' item thrown in based on actions and/or lack of actions
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
    }
}
