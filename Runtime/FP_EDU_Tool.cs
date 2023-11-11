using System;
using System.Collections.Generic;
using UnityEngine;
using FuzzPhyte.Utility.Meta;

namespace FuzzPhyte.Utility.EDU
{
    [Serializable]
    [CreateAssetMenu(fileName = "Tool", menuName = "FuzzPhyte/Utility/EDU/Tool", order = 8)]
    public class FP_EDU_Tool : FP_EDU_Data
    {
        public FP_Theme ToolTheme;
        [TextArea(2,4)]
        public string ToolDescription;
        public List<FP_Tag> ToolTags;
    }
}
