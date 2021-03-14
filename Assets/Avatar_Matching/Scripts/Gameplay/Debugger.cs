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
using Avartar_Matching.Cards;
using UnityEngine;
using Avartar_Matching.Cards.Services;
using Avartar_Matching.Cards.Statics;

namespace Avartar_Matching.Gameplay.Debug
{
    public class Debugger : MonoBehaviour
    {
        public List<Card> randomCards;
        public Transform parent;

        private void Start()
        {
            randomCards = CardStaticProfile.all.RandomSlice(9);
            foreach (var card in randomCards)
            {
                card.transform.SetParent(parent);
                card.gameObject.SetActive(true);
            }
        }
    }
}