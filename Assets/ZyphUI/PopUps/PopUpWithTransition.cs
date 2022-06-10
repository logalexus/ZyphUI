using Assets.ZyphUI.ScreensTransition;
using System;
using UnityEngine;

namespace Assets.ZyphUI.PopUps
{
    public class PopUpWithTransition<Transition> : BasePopUp where Transition : BaseScreenTransition
    {
        [SerializeField] protected Transition transition;

        protected override void Awake()
        {
            base.Awake();
            transition.Init(_canvasGroup, _screenTransorm);
        }

        public override void Open(Action callback)
        {
            base.Open(callback);
            transition.OpenAnim();
        }

        public override void Close()
        {
            transition.CloseAnim(callback: () => base.Close());
        }
    }
}