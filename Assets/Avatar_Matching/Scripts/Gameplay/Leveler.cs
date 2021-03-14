#region metadata
/**
GI282-GameAnalystic_AvatarMatching 
by Chanon_Panpila
author: https://github.com/noney1412

NOTE: 
    - Unity Version (2020.3.0f1), .NET 4.6, C# 8.0
**/
#endregion

using System.Collections;
using System.Collections.Generic;
using Avartar_Matching.UIs;
using UnityEngine;

namespace Avartar_Matching
{
    public class Leveler : MonoBehaviour
    {
        [Header("Level Panel")]
        public LevelPanel panel;
        
        public void StartLevel(int level)
        {
            panel.level.text = $"Level {level}";

        }
    }
}