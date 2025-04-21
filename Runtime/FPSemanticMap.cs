namespace FuzzPhyte.Utility.EDU
{
    using System.Collections.Generic;
    [System.Serializable]
    public struct FPSemanticMap
    {
        public FP_Vocab RelatedWord;
        public SemanticMapType MapType;
        public float StartingWeight; // Current weight of the relationship
    }
    public static class FPLanguageUtility
    {
        public static readonly FPLanguageAdjectiveRules USEnglishRules = new FPLanguageAdjectiveRules(
           new List<FP_VocabSupport>
           {
                FP_VocabSupport.Goodness,  // same as "Opinion"
                FP_VocabSupport.Beauty,
                FP_VocabSupport.Size,
                FP_VocabSupport.Age,
                FP_VocabSupport.Shape,
                FP_VocabSupport.Color,
                FP_VocabSupport.Origin,
                FP_VocabSupport.Material,
                FP_VocabSupport.Purpose,
                FP_VocabSupport.Number
           }
        );
        public static readonly FPLanguageAdjectiveRules FrenchRules = new FPLanguageAdjectiveRules(
            new List<FP_VocabSupport>
            {
                FP_VocabSupport.Beauty,
                FP_VocabSupport.Age,
                FP_VocabSupport.Goodness,
                FP_VocabSupport.Size,
                FP_VocabSupport.Shape,
                FP_VocabSupport.Color,
                FP_VocabSupport.Origin,
                FP_VocabSupport.Material,
                FP_VocabSupport.Purpose,
                FP_VocabSupport.Number
            },
            new HashSet<FP_VocabSupport>
            {
                FP_VocabSupport.Beauty,
                FP_VocabSupport.Age,
                FP_VocabSupport.Goodness,
                FP_VocabSupport.Size,
                FP_VocabSupport.Number
            }
        );
        public static readonly FPLanguageAdjectiveRules SpanishRules = new FPLanguageAdjectiveRules(
            new List<FP_VocabSupport>
            {
                FP_VocabSupport.Beauty,
                FP_VocabSupport.Age,
                FP_VocabSupport.Goodness,
                FP_VocabSupport.Size,
                FP_VocabSupport.Shape,
                FP_VocabSupport.Color,
                FP_VocabSupport.Origin,
                FP_VocabSupport.Material,
                FP_VocabSupport.Purpose,
                FP_VocabSupport.Number
            },
            new HashSet<FP_VocabSupport>
            {
                FP_VocabSupport.Goodness,
                FP_VocabSupport.Size,
                FP_VocabSupport.Age,
                FP_VocabSupport.Beauty,
                FP_VocabSupport.Number
            }
        );
    }
}
