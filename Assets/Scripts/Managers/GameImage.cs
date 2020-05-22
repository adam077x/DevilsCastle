using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class GameImage
{
    public string name;
    public Image image;

    public void Show()
    {
        image.gameObject.SetActive(true);
    }

    public void Hide()
    {
        image.gameObject.SetActive(false);
    }

    public Animator GetAnimator() 
    {
        Animator animator = image.GetComponent<Animator>();

        if(animator == null) {
            Debug.LogWarning("Object doesnt have component animator");
            return null;
        }

        return animator;
    }
}
