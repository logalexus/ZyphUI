using DG.Tweening;
using System;
using UnityEngine;
using Assets.ZyphUI.Extension;

namespace Assets.ZyphUI.ScreensTransition
{
    [Serializable]
    public class BaseScreenTransition
    {
        [Header("Groups")]
        [SerializeField] protected RectTransform _topGroup;
        [SerializeField] protected RectTransform _bottomGroup;

        [Header("Animation")]
        [SerializeField] protected float _overshot = 0.5f;
        [SerializeField] protected float _durationOpen = 1f;
        [SerializeField] protected float _durationClose = 0.4f;
        [SerializeField] protected Ease _openEasy = Ease.OutBack;
        [SerializeField] protected Ease _closeEasy = Ease.InBack;


        protected CanvasGroup _canvasGroup;
        protected RectTransform _canvasTransform;


        public float DurationOpen => _durationOpen;
        public float DurationClose => _durationClose;


        public virtual void Init(CanvasGroup canvasGroup, RectTransform canvasTransform)
        {
            _canvasTransform = canvasTransform;
            _canvasGroup = canvasGroup;
            _canvasGroup.interactable = false;
        }

        public virtual void CloseAnim(TweenCallback callback)
        {
            _canvasGroup.interactable = false;

            float offsetY = _canvasTransform.rect.height;

            Sequence s = DOTween.Sequence().SetUpdate(true);

            s.Join(_bottomGroup.DOLocalMoveY(-offsetY, _durationClose));
            s.Join(_topGroup.DOLocalMoveY(offsetY, _durationClose));
            s.SetEase(_closeEasy, _overshot);
            s.SetRelative(true);
            s.OnComplete(callback);
        }

        
        public virtual void OpenAnim()
        {
            OffsetPositionGroups();

            float offsetY = _canvasTransform.rect.height;

            Sequence s = DOTween.Sequence().SetUpdate(true);

            s.Join(_bottomGroup.DOLocalMoveY(offsetY, _durationOpen));
            s.Join(_topGroup.DOLocalMoveY(-offsetY, _durationOpen));
            s.SetEase(_openEasy, _overshot);
            s.SetRelative(true);
            s.OnComplete(() => _canvasGroup.interactable = true);
        }


        protected virtual void OffsetPositionGroups()
        {
            float offsetY = _canvasTransform.rect.height;
            _topGroup.SetY(offsetY);
            _bottomGroup.SetY(-offsetY);
        }

    }
}