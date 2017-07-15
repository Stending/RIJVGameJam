using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DayTexts : MonoBehaviour {

    public List<Text> Texts;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SwitchToText(int id)
    {
        for(int i = 0; i < Texts.Count; i++)
        {
            if (i == id)
                Texts[i].enabled = true;
            else
                Texts[i].enabled = false;
        }
    }
}
