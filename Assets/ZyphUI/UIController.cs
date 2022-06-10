using Assets.ZyphUI.PopUps;
using Assets.ZyphUI.Screens;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Assets.ZyphUI
{
    public class UIController : MonoBehaviour
    {
        [SerializeField] private List<BaseScreen> _screens;
        [SerializeField] private List<BasePopUp> _popUps;
        private BaseScreen _activeScreen;

        public static UIController Instance;

        private void Awake()
        {
            _screens = FindObjectsOfType<BaseScreen>().ToList();
            _popUps = FindObjectsOfType<BasePopUp>().ToList();

            if (Instance == null)
                Instance = this;
        }



        public void OpenScreen<T>() where T : BaseScreen
        {
            _activeScreen?.Close();
            _activeScreen = GetScreen<T>();
            _activeScreen.Open();
        }

        private T GetScreen<T>() where T : BaseScreen
        {
            return _screens.OfType<T>().FirstOrDefault();
        }

        public void OpenPopUp<T>(Action callback) where T : BasePopUp
        {
            _activeScreen.SetInteractable(false);

            var popup = GetPopUp<T>();
            popup.Open(callback);
            popup.OnClosed += () => _activeScreen.SetInteractable(true);
        }

        public void OpenPopUp(BasePopUp popup, Action callback)
        {
            _activeScreen?.SetInteractable(false);

            popup.Open(callback);
            popup.OnClosed += () => _activeScreen.SetInteractable(true);
        }

        public T GetPopUp<T>() where T : BasePopUp
        {
            return _popUps.OfType<T>().FirstOrDefault();
        }

    }
}