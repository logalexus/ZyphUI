using System;
using System.Collections.Generic;
using Assets.ZyphUI.Extensions;
using System.Linq;
using UnityEngine;

namespace Assets.ZyphUI.Screens
{
    public class BaseUIController : MonoBehaviour
    {
        private BaseScreen _activeScreen;
        private Stack<BaseScreen> _screensStack;
        private int _defaultZ = 0;

        public virtual void Init()
        {
            _screensStack = new Stack<BaseScreen>();
        }


        /// <summary>
        /// Открывает предыдущий экран
        /// </summary>
        /// <exception cref="Exception"></exception>
        public void OpenPreviousScreen()
        {
            if (_screensStack.Count == 0)
                throw new Exception("No previous screen");

            _activeScreen?.Close();
            BaseScreen previousScreen = _screensStack.Pop();
            OpenScreenOverAll(previousScreen);
        }



        /// <summary>
        /// Открывает экран поверх других
        /// </summary>
        /// <param name="screen"></param>
        public void OpenScreenOverAll(BaseScreen screen) 
        {
            _activeScreen = screen;
            _activeScreen.Open();
            _screensStack.Push(_activeScreen);
            _activeScreen.transform.SetZ(_screensStack.Count());
        }


        /// <summary>
        /// Открывает экран, но закрывает другие
        /// </summary>
        /// <param name="screen"></param>
        public void OpenScreenWithCloseAll(BaseScreen screen)
        {
            CloseAllScreens();

            _activeScreen = screen;
            _activeScreen.Open();
            _activeScreen.transform.SetZ(_defaultZ);

            _screensStack.Push(_activeScreen);
        }

        public void CloseAllScreens()
        {
            foreach (var openedScreen in _screensStack)
            {
                openedScreen.Close();
                openedScreen.transform.SetZ(_defaultZ);
            }
            _screensStack.Clear();
        }
    }
}
