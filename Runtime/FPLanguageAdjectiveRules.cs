namespace FuzzPhyte.Utility.EDU
{
    using System.Collections.Generic;

    public class FPLanguageAdjectiveRules
    {
        public List<FP_VocabSupport> SortOrder;
        public HashSet<FP_VocabSupport> PreNounCategories;

        public FPLanguageAdjectiveRules(List<FP_VocabSupport> sortOrder, HashSet<FP_VocabSupport> preNounCategories = null) 
        {
            SortOrder = sortOrder;
            PreNounCategories = preNounCategories ?? new HashSet<FP_VocabSupport>();
        }
       
    }
   
}
