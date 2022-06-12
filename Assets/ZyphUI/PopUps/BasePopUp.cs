using System;
using UnityEngine;

namespace Assets.ZyphUI.PopUps
{
    public class BasePopUp : MonoBehaviour
    {
        protected RectTransform _screenTransorm;
        protected CanvasGroup _canvasGroup;

        public Action Closed;

        protected virtual void Awake()
        {
            _screenTransorm = GetComponent<RectTransform>();
            _canvasGroup = GetComponent<CanvasGroup>();

            _canvasGroup.alpha = 0;
            _canvasGroup.blocksRaycasts = false;

        }

        public virtual void Open(Action callback)
        {
            _canvasGroup.alpha = 1;
            _canvasGroup.blocksRaycasts = true;

        }

        public virtual void Open(Action<object> callback)
        {
            _canvasGroup.alpha = 1;
            _canvasGroup.blocksRaycasts = true;
        }

        public virtual void Close()
        {
            _canvasGroup.alpha = 0;
            _canvasGroup.blocksRaycasts = false;
            Closed.Invoke();
        }


    }
}