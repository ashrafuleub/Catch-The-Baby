using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameStar : MonoBehaviour
{
   

    public void OnStart()
    {
        Loding();
    }

    public void Gamequit()
    {
        Application.Quit();
    }

    public void Loding()
    {
        SceneManager.LoadScene(1);
    }
}
