using Assets.ZyphUI.Screens;
using Assets.Scripts.UIExample.Screens;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UIExample.Screens
{
    public class GamePlayScreen : BaseScreen
    {
        [SerializeField] Button menuButton;

        private const string _animationnName = "GamePlayScreenAnimation";
        private UIController _uiController; 

        public void Init(UIController uiController)
        {
            menuButton.onClick.AddListener(_uiController.OpenMainMenu);
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