using Assets.Scripts.UIExample.Screens;
using Assets.ZyphUI;
using System.Collections;
using UnityEngine;

namespace Assets.Scripts
{
    public class EntryPoint : MonoBehaviour
    {
        IEnumerator Start()
        {
            yield return new WaitForSeconds(1f);

            UIController.Instance.OpenScreen<MainMenuScreen>();
        }
    }
}