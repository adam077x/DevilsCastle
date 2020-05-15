using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class PixelatedEffect : MonoBehaviour
{
    public Material effectMaterial;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    void OnRenderImage(RenderTexture src, RenderTexture dst) 
    {
        Graphics.Blit(src, dst, effectMaterial);
    }
}
