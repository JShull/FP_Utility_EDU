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
        public string URLReference;
        public string IPAPronunciation;
        public string URLWikiAudioOfWord;
        public AudioType URLAudioType;
        public Sprite Image;
        public List<FP_Vocab_Details> Details;
    }

}
