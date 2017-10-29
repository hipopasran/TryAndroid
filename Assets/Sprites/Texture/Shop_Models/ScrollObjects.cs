using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollObjects : MonoBehaviour {

    public GameObject models;

    
    private Vector3 screenPoint, offset;
    private float _lockedYPos;

    void Update()
    {
        if (models.transform.position.x > 0)
            models.transform.position = Vector3.MoveTowards(models.transform.position, new Vector3(0f, models.transform.position.y, models.transform.position.z),Time.deltaTime*30f);
        else if(models.transform.position.x<-17.5f)
            models.transform.position = Vector3.MoveTowards(models.transform.position, new Vector3(-17.5f, models.transform.position.y, models.transform.position.z), Time.deltaTime * 30f);
    }

    void OnMouseDown()
    {
        _lockedYPos = screenPoint.x;
        offset = models.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
        Cursor.visible = false;
    }
    void OnMouseDrag()
    {
        Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
        Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
        curPosition.y = _lockedYPos;
        models.transform.position = curPosition;
    }
    void OnMouseUp()
    {
        Cursor.visible = true;
    }
}
