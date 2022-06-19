﻿using Assets.Scripts.UIExample.Screens;
using Assets.ZyphUI.Screens;
using System;
using UnityEngine;

namespace Assets.Scripts.UIExample
{
    public class UIController : BaseUIController
    {
        [SerializeField] MainMenuScreen mainMenuScreen;
        [SerializeField] GamePlayScreen gamePlayScreen;
        [SerializeField] ShopScreen shopScreen;


        public override void Init()
        {
            base.Init();
            mainMenuScreen.Init(this);
            gamePlayScreen.Init(this);
            shopScreen.Init(this);
        }

        public void OpenMainMenu()
        {
            OpenScreenWithCloseAll(mainMenuScreen);
        }

        public void OpenGamePlayScreen()
        {
            OpenScreenWithCloseAll(gamePlayScreen);
        }

        public void OpenShopScreen()
        {
            OpenScreenOverAll(shopScreen);
        }
    }
}