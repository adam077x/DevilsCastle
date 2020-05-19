using System;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;

    public GameText[] textList;

    void Awake()
    {
        instance = FindObjectOfType<UIManager>();
    }
    
    public GameText GetText(string name)
    {
        return Array.Find(textList, text => text.name == name);
    }
}
