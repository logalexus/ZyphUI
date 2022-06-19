using UnityEngine;

namespace Assets.ZyphUI.Screens
{
    [RequireComponent(typeof(CanvasGroup), typeof(Animation))]
    public abstract class BaseScreen : MonoBehaviour
    {
        protected Animation _animation;

        private void Awake()
        {
            _animation = GetComponent<Animation>();
        }

        public abstract void Open();

        public abstract void Close();
    }
}