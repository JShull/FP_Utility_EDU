using System;
using System.Collections.Generic;
using UnityEngine;

namespace FuzzPhyte.Utility.Edu
{
    [Serializable]
    public struct VocabularyUsageData
    {
        public int TimesUsed;
        public Dictionary<FP_VocabAction, int> ActionCounts; // keep track of how many times each action was performed on this word
        public VocabularyUsageData(int timesUsed =0)
        {
            TimesUsed = timesUsed;
            ActionCounts = new Dictionary<FP_VocabAction, int>();
        }
        public void IncrementAction(FP_VocabAction action)
        {
            if (ActionCounts.ContainsKey(action))
            {
                ActionCounts[action]++;
            }
            else
            {
                ActionCounts.Add(action, 1);
            }
        }
        public int GetActionCount(FP_VocabAction action)
        {
            return ActionCounts.ContainsKey(action) ? ActionCounts[action] : 0;
        }
    }
}
