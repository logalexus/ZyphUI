using Assets.ZyphUI.Screens;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UIExample.Screens
{
    public class MainMenuScreen : BaseScreen
    {
        [SerializeField] Button playButton;
        [SerializeField] Button shopButton;

        public event Action PlayClick;
        public event Action ShopClick;

        public void Init()
        {
            playButton.onClick.AddListener(() => PlayClick?.Invoke());
            shopButton.onClick.AddListener(() => ShopClick?.Invoke());
        }
    }
}