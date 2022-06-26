using Assets.ZyphUI.Screens;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UIExample.Screens
{
    public class ShopScreen : BaseScreen
    {
        [SerializeField] Button backButton;

        public event Action BackClick;

        public void Init()
        {
            backButton.onClick.AddListener(()=> BackClick?.Invoke());
        }

    }
}