using Assets.ZyphUI.ScreensTransition;
using UnityEngine;

namespace Assets.ZyphUI.Screens
{
    public class ScreenWithTransition<Transition> : BaseScreen where Transition : BaseScreenTransition
    {
        [SerializeField] protected Transition transition;

        protected override void Awake()
        {
            base.Awake();
            transition.Init(_canvasGroup, _screenTransorm);
        }

        public override void Open()
        {
            base.Open();
            transition.OpenAnim();
        }

        public override void Close()
        {
            base.Close();
            transition.CloseAnim();
        }

    }
}