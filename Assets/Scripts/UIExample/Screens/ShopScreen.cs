using Assets.ZyphUI.Screens;
using UnityEngine;
using UnityEngine.UI;

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

            backButton.onClick.AddListener(_uiController.OpenPreviousScreen);
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