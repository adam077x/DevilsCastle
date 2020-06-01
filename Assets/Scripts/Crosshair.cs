using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Crosshair : MonoBehaviour
{
    public Image top, down, left, right, dot;
    public GameObject panel;
    public Color color;

    [Range(25f, 100f)]
    public float size;

    public bool drawDot;

    void Start()
    {
        dot.gameObject.SetActive(drawDot);
        panel.GetComponent<RectTransform>().sizeDelta = new Vector2(size, size);
        top.color = color;
        down.color = color;
        left.color = color;
        right.color = color;
        dot.color = color;
    }
    
    void Update()
    {
        
    }
}
