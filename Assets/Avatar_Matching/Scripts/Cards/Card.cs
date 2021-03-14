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
using UnityEngine.UI;

namespace Avartar_Matching.Cards
{
    public class Card : MonoBehaviour
    {
        public new string name;
        public Sprite avatar;
        public Sprite placeholder;

        public void Flip()
        {
            // animate ( rotation )
        }

        public void SetImage(Sprite image)
        {
            GetComponent<Image>().sprite = image;
        }

        public void SwapImage()
        {
            if (GetComponent<Image>().sprite == avatar)
            {
                GetComponent<Image>().sprite = placeholder;
                return;
            }

            GetComponent<Image>().sprite = avatar;
        }
    }
}