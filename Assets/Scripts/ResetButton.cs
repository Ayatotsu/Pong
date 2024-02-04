using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ResetButton : MonoBehaviour
{
    public string whatScene;

    public GameObject currentLevel;
    public GameObject buttonNextLevel;

    public void BtnReset()
    {
        SceneManager.LoadScene(whatScene);
    }

    public void BtnStartGame()
    {
        SceneManager.LoadScene(whatScene);
        
    }

    public void NextLevel()
    {
        currentLevel.gameObject.SetActive(false);
        buttonNextLevel.gameObject.SetActive(true);
    }
}
