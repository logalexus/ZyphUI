using UnityEngine;

namespace Assets.ZyphUI.Screens
{
    [RequireComponent(typeof(CanvasGroup))]
    public class BaseScreen : MonoBehaviour
    {
        protected RectTransform _screenTransorm;
        protected CanvasGroup _canvasGroup;


        protected virtual void Awake()
        {
            _screenTransorm = GetComponent<RectTransform>();
            _canvasGroup = GetComponent<CanvasGroup>();

            _canvasGroup.alpha = 0;
            _canvasGroup.blocksRaycasts = false;

        }

        public virtual void Open()
        {
            _canvasGroup.alpha = 1;
            _canvasGroup.blocksRaycasts = true;

        }

        public virtual void Close()
        {
            _canvasGroup.alpha = 0;
            _canvasGroup.blocksRaycasts = false;

        }

        public void SetInteractable(bool value)
        {
            _canvasGroup.interactable = value;
            _canvasGroup.blocksRaycasts = value;
        }
    }
}