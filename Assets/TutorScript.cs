using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorScript : MonoBehaviour {

    public GameObject Tutor;

    void OnMouseUpAsButton()
    {
        Tutor.SetActive(false);
    }
    }
