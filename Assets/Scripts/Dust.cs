using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dust : MonoBehaviour
{
    void Start()
    {
        //StartCoroutine(RemoveParticle());
    }

    void Update() 
    {
        transform.Translate(new Vector3(0, 1 * Time.deltaTime, 0));
    }

    IEnumerator RemoveParticle()
    {
        yield return new WaitForSeconds(1.0f);
        Destroy(gameObject);
    }
}
