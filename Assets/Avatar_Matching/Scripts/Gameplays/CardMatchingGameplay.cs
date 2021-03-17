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
using Avartar_Matching.Gameplays.Cards;
using Avartar_Matching.Gameplays.Cards.Statics;
using Avartar_Matching.Gameplays.Cards.Services;

namespace Avartar_Matching.Gameplays
{
    public class CardMatchingGameplay : MonoBehaviour
    {
        public void StartLevel(int level)
        {
            // panel.gameObject.SetActive(true);
            // panel.level.text = $"Level {level}";
            // var randoms = CardStaticProfile.all.RandomSlice(9);

            // List<Card> clones = new List<Card>();
            // foreach (var random in randoms)
            // {
            //     // pooling to parent
            //     random.transform.SetParent(panel.parent.transform);
            //     random.gameObject.name = random.name;
            //     random.gameObject.SetActive(true);

            //     // create clone
            //     Card clone = Instantiate<Card>(random, panel.parent.transform);
            //     clones.Add(clone);

            //     // shuffle 
            //     foreach (Transform each in panel.parent.transform)
            //     {
            //         each.gameObject.SetActive(true);

            //         int rand = Random.Range(0, panel.parent.transform.childCount);
            //         each.SetSiblingIndex(rand);
            //         each.GetComponent<Card>().ShowPlaceHolder();
            //     }
            // }

            // // start Playing
        }
    }
}