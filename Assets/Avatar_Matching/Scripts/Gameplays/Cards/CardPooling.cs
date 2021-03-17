#region metadata
/**
GI282-GameAnalystic_AvatarMatching 
by Chanon_Panpila
author: https://github.com/noney1412

NOTE: 
    - Unity Version (2020.3.0f1), .NET 4.6, C# 8.0
**/
#endregion

using System.Collections.Generic;
using UnityEngine;
using Avartar_Matching.Gameplays.Cards.Statics;

namespace Avartar_Matching.Gameplays.Cards
{
    public class CardPooling : MonoBehaviour
    {
        [Header("Image")]
        public Sprite placeholder;
        public List<Sprite> cardImages;

        [Header("Object Pool")]
        public Card cardPrefab;
        public Transform parent;

        private void Awake()
        {
            foreach (var card in cardImages)
            {
                var prefab = Instantiate<Card>(cardPrefab, parent);
                prefab.gameObject.name = card.name;
                prefab.name = card.name;
                prefab.avatar = card;
                prefab.placeholder = placeholder;
                prefab.SetImage(placeholder);
                prefab.gameObject.SetActive(false);
                CardStaticProfile.all.Add(prefab);
            }

            print(CardStaticProfile.all.Count);
        }
    }
}