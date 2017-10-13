using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonAnim : MonoBehaviour {

    public Sprite layer_up, layer_down;

    void OnMouseDown()
    {
        GetComponent<SpriteRenderer>().sprite = layer_down;
    }

    void OnMouseUp()
    {
        GetComponent<SpriteRenderer>().sprite = layer_up;
    }
	
}
