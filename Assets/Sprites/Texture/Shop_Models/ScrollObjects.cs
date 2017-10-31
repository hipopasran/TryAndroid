using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollObjects : MonoBehaviour {

    public GameObject models;

    public GameObject whichModel;


    bool touch=false;
    private Vector3 screenPoint, offset;
    private float _lockedYPos;
    float posFloat;
   

    void Update()
    {

        posFloat = models.transform.position.x % 0.5f;
        

        if (models.transform.position.x > 0)
            models.transform.position = Vector3.MoveTowards(models.transform.position, new Vector3(0f, models.transform.position.y, models.transform.position.z),Time.deltaTime*30f);
        else if(models.transform.position.x<-17.5f)
            models.transform.position = Vector3.MoveTowards(models.transform.position, new Vector3(-17.5f, models.transform.position.y, models.transform.position.z), Time.deltaTime * 30f);
        else if (!touch)
        {
            models.transform.position = Vector3.MoveTowards(models.transform.position, new Vector3(-(whichModel.GetComponent<SelectModel>().ModelInTrigger.transform.localPosition.x), models.transform.position.y, models.transform.position.z),Time.deltaTime * 15) ;
        }
    }

    void OnMouseDown()
    {
        touch = true;
        //_lockedYPos = screenPoint.x;
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
        touch = false;
    }
}
