using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class GameText
{
    public string name;
    public Text gameText;

    public void ChangeText(string text) 
    {
        gameText.text = text;
    }

    public void Show()
    {
        gameText.gameObject.SetActive(true);
    }

    public void Hide()
    {
        gameText.gameObject.SetActive(false);
    }

    public string GetText() 
    {
        return gameText.text;
    }
}
