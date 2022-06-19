using Assets.Scripts.UIExample;
using System.Collections;
using UnityEngine;

namespace Assets.Scripts
{
    public class GameManager : MonoBehaviour
    {
        [SerializeField] UIController uiController;

        private void Start()
        {
            uiController.Init();
            uiController.OpenMainMenu();
        }
    }
}