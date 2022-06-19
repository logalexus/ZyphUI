using Assets.ZyphUI.Screens;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

namespace Assets.Scripts.UIExample.Screens
{
    public class ShopScreen : BaseScreen
    {
        [SerializeField] Button backButton;

        private const string _animationnName = "ShopScreenAnimation";
        private UIController _uiController;

        public override void Init(BaseUIController uiController)
        {
            base.Init(uiController);
            _uiController = uiController as UIController;

            backButton.onClick.AddListener(_uiController.BackToPreviousScreen);
        }

        public override void Open()
        {
            foreach (AnimationState state in _animation)
                state.speed = 1;

            _animation.Play(_animationnName);
        }

        public override void Close()
        {
            foreach (AnimationState state in _animation)
                state.speed = -1;

            _animation.Play(_animationnName);
        }
    }
}