using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class MarbleSpawn : MonoBehaviour
{
    public GameObject beanPrefab;
    public Text beansToUseText;

    public int beansToUse = 7;
    public float startHover = 0.0f;
    public float targetHover = 0.5f;
    public float velHoverTrans = 0.2f;
    float currTransparency = 0.0f;
    bool hovering = false;
    SpriteRenderer sprite;
    Color spColor;

    private void Awake()
    {
        sprite = GetComponent<SpriteRenderer>();
        spColor = sprite.color;
        sprite.color = new Color(spColor.r, spColor.g, spColor.b, 0.0f);
        beansToUseText.text = "x" + beansToUse;
    }

    private void OnMouseDown()
    {
        Vector3 instancePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if(beansToUse > 0)
        {
            Instantiate(beanPrefab, new Vector3(instancePos.x, instancePos.y, 0), transform.rotation);
            beansToUse--;
            beansToUseText.text = "x" + beansToUse;
        }

    }

    private void OnMouseOver()
    {
        hovering = true;
    }

    private void OnMouseExit()
    {
        hovering = false;
    }

    void Update()
    {
        if (hovering)
        {
            currTransparency = Mathf.Lerp(currTransparency, targetHover, velHoverTrans * Time.deltaTime);
            sprite.color = new Color(spColor.r, spColor.g, spColor.b, currTransparency);
        }
        else
        {
            currTransparency = Mathf.Lerp(currTransparency, startHover, velHoverTrans * Time.deltaTime);
            sprite.color = new Color(spColor.r, spColor.g, spColor.b, currTransparency);
        }   
    }


}
