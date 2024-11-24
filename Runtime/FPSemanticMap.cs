namespace FuzzPhyte.Utility.EDU
{
    [System.Serializable]
    public struct FPSemanticMap
    {
        public FP_Vocab RelatedWord;
        public SemanticMapType MapType;
        public float StartingWeight; // Current weight of the relationship
    }
}
