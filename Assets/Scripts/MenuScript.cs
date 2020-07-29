using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public Slider playSLeft;
    public Slider playSRight;

    bool hovering = false;

    private void Awake()
    {
        playSLeft.value = 0;
        playSRight.value = 0;

    }

    public void PlayHover()
    {
        hovering = true;
    }

    public void ExitPlayHover()
    {
        hovering = false;
    }

    private void Update()
    {
        if (hovering)
        {
            playSLeft.value = Mathf.Lerp(playSLeft.value, 1, Time.deltaTime * 5);
            playSRight.value = Mathf.Lerp(playSRight.value, 1, Time.deltaTime * 5);
        }
        else
        {
            playSLeft.value = Mathf.Lerp(playSLeft.value, 0, Time.deltaTime * 5);
            playSRight.value = Mathf.Lerp(playSRight.value, 0, Time.deltaTime * 5);
        }
    }

    public void PressedPlay()
    {
        GameManager._Instance.currentLevel = 1;
        SceneManager.LoadScene("Level1");
    }
}
