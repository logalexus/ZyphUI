using UnityEngine;

namespace Assets.ZyphUI.Screens
{
    [RequireComponent(typeof(CanvasGroup), typeof(Animation))]
    public abstract class BaseScreen : MonoBehaviour
    {
        protected Animation _animation;

        public virtual void Init(BaseUIController uiController)
        {
            _animation = GetComponent<Animation>();
            Close();
        }

        public abstract void Open();

        public abstract void Close();
    }
}