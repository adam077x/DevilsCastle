using System;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;

    public GameText[] textList;
    public GameImage[] imageList;
    public GameSprite[] spriteList;

    void Awake()
    {
        instance = FindObjectOfType<UIManager>();
    }
    
    public GameText GetText(string name)
    {
        return Array.Find(textList, text => text.name == name);
    }

    public GameImage GetImage(string name)
    {
        return Array.Find(imageList, image => image.name == name);
    }

    public GameSprite GetSprite(string name) 
    {
        return Array.Find(spriteList, sprite => sprite.name == name);
    }
}
