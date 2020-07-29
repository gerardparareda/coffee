using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public static GameManager _Instance;
    public int currentLevel = 1;

    [Range(0, 1)]
    public float volumeLevel;

    void Awake()
    {
        if(_Instance == null)
        {
            _Instance = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            

        }
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene("Level" + currentLevel);
    }

    public void NextLevel()
    {
        currentLevel++;
        print(currentLevel);
        SceneManager.LoadScene("Level" + currentLevel);
    }

}
