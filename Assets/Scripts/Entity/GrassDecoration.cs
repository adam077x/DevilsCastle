using UnityEngine;

public class GrassDecoration : MonoBehaviour
{
    public Sprite sprite1;
    public Sprite sprite2;
    public Sprite sprite3;
    public Sprite sprite4;

    void Start() 
    {
        int r = Random.Range(0, 4);

        if (r == 0) 
        {
            GetComponent<SpriteRenderer>().sprite = sprite1;
        }
        else if (r == 1) 
        {
            GetComponent<SpriteRenderer>().sprite = sprite2;
        }
        else if (r == 2) 
        {
            GetComponent<SpriteRenderer>().sprite = sprite3;
        }
        else if (r == 3) 
        {
            GetComponent<SpriteRenderer>().sprite = sprite4;
        }
    }
}
