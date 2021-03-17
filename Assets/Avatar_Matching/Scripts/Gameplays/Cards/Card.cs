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
using UnityEngine.EventSystems;

namespace Avartar_Matching.Gameplays.Cards
{
    public class Card : MonoBehaviour, IPointerClickHandler
    {
        public new string name;
        public Sprite avatar;
        public Sprite placeholder;
        public bool isShow;

        public void OnPointerClick(PointerEventData eventData)
        {
            SwapImage();
            print("Clicking");
        }

        public void SetImage(Sprite image)
        {
            GetComponent<Image>().sprite = image;
        }

        public void SwapImage()
        {
            GetComponent<Animator>().Play("Flip Card");

            if (isShow is true)
            {
                ShowPlaceHolder();
                return;
            }

            ShowAvatar();
        }

        public void ShowAvatar()
        {
            GetComponent<Image>().sprite = avatar;
            GetComponent<Image>().raycastTarget = true;

            isShow = true;
        }

        public void ShowPlaceHolder()
        {
            GetComponent<Image>().sprite = placeholder;
            GetComponent<Image>().raycastTarget = true;

            isShow = false;
        }


    }
}