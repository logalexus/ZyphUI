using Assets.ZyphUI.Screens;
using Assets.Scripts.UIExample.Screens;
using UnityEngine;
using System.Linq;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Assets.Scripts.UIExample.Screens
{
    public class GamePlayScreen : BaseScreen
    {
        [SerializeField] Button menuButton;

        public event Action BackToMenuClick;

        public void Init()
        {
            menuButton.onClick.AddListener(() => BackToMenuClick?.Invoke());
        }
    }
}