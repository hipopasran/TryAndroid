using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour {

    [SerializeField]
    private SettingPopup settingPopup;
	// Use this for initialization
	void Start () {
        settingPopup.Close();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnOpenSetting()
    {
        settingPopup.Open();
    }
}
