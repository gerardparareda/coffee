using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BeansTrigger : MonoBehaviour
{

    public int beansLeft = 5;
    public Text beansLeftLabel;

    public Button NextLevel;
    public Button NextLevelBg;

    private void Awake()
    {
        NextLevel.gameObject.SetActive(false);
        NextLevelBg.gameObject.SetActive(false);
        beansLeftLabel.text = "" + beansLeft;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(beansLeft > 0)
        {
            beansLeft--;
            beansLeftLabel.text = "" + beansLeft;
        }
        
        if(beansLeft <= 0)
        {
            NextLevel.gameObject.SetActive(true);
            NextLevelBg.gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(!(beansLeft <= 0))
        {
            beansLeft++;
            beansLeftLabel.text = "" + beansLeft;
        }
    }
}
