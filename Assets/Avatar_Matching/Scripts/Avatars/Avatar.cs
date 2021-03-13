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
using UnityEngine;

namespace Avartar_Matching.Avatars
{
    public class Avatar : MonoBehaviour
    {
        public List<Sprite> all;

        public new string name;
    }

    public static class AvatarExtension
    {
        public static bool MatchBy(this Avatar self, Avatar other)
        {
            return self.name.Equals(other.name);
        }
    }

}