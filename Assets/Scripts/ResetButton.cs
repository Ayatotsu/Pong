using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ResetButton : MonoBehaviour
{
    public string whatScene;

    public void BtnReset()
    {
        SceneManager.LoadScene(whatScene);
    }
}
