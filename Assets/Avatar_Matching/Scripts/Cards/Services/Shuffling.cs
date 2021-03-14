#region metadata
/**
GI282-GameAnalystic_AvatarMatching 
by Chanon_Panpila
author: https://github.com/noney1412

NOTE: 
    - Unity Version (2020.3.0f1), .NET 4.6, C# 8.0
**/
#endregion

using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

namespace Avartar_Matching.Cards.Services
{
    public static class Shuffling
    {
        public static List<Card> Shuffle(this List<Card> cards)
        {
            var result = cards;
            var provider = new RNGCryptoServiceProvider();
            int n = result.Count;
            while (n > 1)
            {
                var box = new byte[1];
                do provider.GetBytes(box);
                while (!(box[0] < n * (Byte.MaxValue / n)));
                var k = (box[0] % n);
                n--;
                var value = result[k];
                result[k] = result[n];
                result[n] = value;
            }

            return result;
        }
    }
}