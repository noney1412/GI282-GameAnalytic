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

namespace Avartar_Matching.Cards.Services
{
    public static class Picking
    {
        public static List<Card> RandomSlice(this List<Card> all, int max)
        {
            List<Card> clone = all;
            List<Card> result = new List<Card>();

            for (int i = 0; i < max; i++)
            {
                Card random = clone[Random.Range(0, clone.Count)];
                result.Add(random);
                clone.Remove(random);
            }

            return result; 
        }
    }
}