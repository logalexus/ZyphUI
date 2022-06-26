using UnityEngine;

namespace Assets.ZyphUI.Screens
{
    [RequireComponent(typeof(Animation))]
    public abstract class BaseScreen : MonoBehaviour
    {
        [Header("Animation")]
        [SerializeField] protected AnimationClip openClip;
        [SerializeField] protected AnimationClip closeClip;

        protected Animation _animation;



        public virtual void Awake()
        {
            _animation = GetComponent<Animation>();
            _animation.AddClip(openClip, openClip.name);
            _animation.AddClip(closeClip, closeClip.name);
            openClip.legacy = true;
            closeClip.legacy = true;

            Close();
        }

        public virtual void Open()
        {
            _animation.Play(openClip.name);

        }

        public virtual void Close()
        {
            _animation.Play(closeClip.name);
        }
    }
}