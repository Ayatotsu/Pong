using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ResetButton : MonoBehaviour
{
    public string whatScene;
    public GameObject currentMenu;
    public GameObject nextMenu;

    public void BtnReset()
    {
        SceneManager.LoadScene(whatScene);
    }

    public void BtnStartGame()
    {
        SceneManager.LoadScene(whatScene);
        
    }
    public void SwitchActive()
    {
        currentMenu.gameObject.SetActive(false);
        nextMenu.gameObject.SetActive(true);
    }
}
