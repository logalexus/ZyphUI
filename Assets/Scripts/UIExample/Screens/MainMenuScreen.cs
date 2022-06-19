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

        private const string _animationnName = "MainMenuScreenAnimation";
        private UIController _uiController;

        public void Init(UIController uiController)
        {

            playButton.onClick.AddListener(uiController.OpenGamePlayScreen);
            shopButton.onClick.AddListener(uiController.OpenShopScreen);
        }


        public override void Open()
        {
            _animation.Play(_animationnName);
        }

        public override void Close()
        {
            _animation.Rewind(_animationnName);
        }
    }
}