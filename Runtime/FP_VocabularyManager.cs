namespace FuzzPhyte.Utility.Edu
{
    using UnityEngine;
    using System.Collections.Generic;
    using FuzzPhyte.Utility.EDU;
    using FuzzPhyte.Utility;
    using System;

    public class FP_VocabularyManager : MonoBehaviour
    {
        public static FP_VocabularyManager Instance;

        // The dynamic list of vocabulary in a module/scene
        [SerializeField]protected List<FP_Vocab> vocabularyCollection = new List<FP_Vocab>();

        // usage of vocabularies
        protected Dictionary<FP_Vocab, VocabularyUsageData> vocabUsageData = new();
        protected Dictionary<FP_VocabCategory, VocabularyUsageData> categoryUsageData = new();

        public Action<FP_Vocab> OnVocabularyRuntimeAdded; // Optional delegate for notifying vocab additions
        public Action<FP_Vocab, FP_VocabAction> OnVocabularyRuntimeFirstUsage; // Optional delegate for notifying vocab usage
        public Action<FP_Vocab, FP_VocabAction> OnVocabularyRuntimeUsage; // Optional delegate for notifying vocab usage
        private void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
                DontDestroyOnLoad(gameObject);
            }
            else
            {
                Destroy(gameObject);
            }
        }
        /// <summary>
        /// Only call this from start/setup not during runtime as we won't invoke the events
        /// </summary>
        /// <param name="vocab"></param>
        public virtual void RegisterVocabulary(FP_Vocab vocab)
        {
            if (vocabularyCollection.Contains(vocab) == false)
            {
                vocabularyCollection.Add(vocab);
            }
        }
        // Add a new vocab to the manager
        // Record interaction with vocab
        public virtual void RecordVocabInteraction(FP_Vocab vocab, FP_VocabAction action)
        {
            if(vocabularyCollection.Contains(vocab) == false)
            {
                vocabularyCollection.Add(vocab);
                OnVocabularyRuntimeAdded?.Invoke(vocab); // Notify listeners if needed
                //we know it hasn't been used before
            }
            // Update vocab-level stats
            if (!vocabUsageData.ContainsKey(vocab))
            {
                vocabUsageData[vocab] = new VocabularyUsageData(0);
                OnVocabularyRuntimeFirstUsage?.Invoke(vocab, action); // Notify listeners if needed
            }

            var vocabData = vocabUsageData[vocab];
            vocabData.TimesUsed++;
            vocabData.IncrementAction(action);
            vocabUsageData[vocab] = vocabData;
           
            // Update category-level stats
            if (!categoryUsageData.ContainsKey(vocab.VocabCategory))
            {
                categoryUsageData[vocab.VocabCategory] = new VocabularyUsageData(0);
            }

            var categoryData = categoryUsageData[vocab.VocabCategory];
            categoryData.TimesUsed++;
            categoryData.IncrementAction(action);
            categoryUsageData[vocab.VocabCategory] = categoryData;

            OnVocabularyRuntimeUsage?.Invoke(vocab, action); // Notify listeners if needed
            Debug.Log($"Recorded {action} for vocab: {vocab.Word}, TotalInteractions: {vocabData.TimesUsed}");
        }

        #region Retrieve Stats
        
        public VocabularyUsageData GetVocabStats(FP_Vocab vocab)
        {
            return vocabUsageData.ContainsKey(vocab) ? vocabUsageData[vocab] : new VocabularyUsageData(0);
        }

        public VocabularyUsageData GetCategoryStats(FP_VocabCategory category)
        {
            return categoryUsageData.ContainsKey(category) ? categoryUsageData[category] : new VocabularyUsageData(0);
        }
        #endregion
    }
}
