using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public  class GameOver : MonoBehaviour
{

    public Text totalScore;

    private void Start()
    {
        totalScore.text = ""+PlayerPrefs.GetInt("final");
    }
    public void Restarted()
    {
        SceneManager.LoadScene(1);
    }

    public void Quite()
    {
        Application.Quit();
    }
}
