using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ink.Runtime;

[System.Serializable]
public class Contact{

    public string Name;
    public string PhoneNumber;

    public TextAsset inkJSONAsset;

    public Story SmsStory;

    public Conversation Conv;
        

	// Use this for initialization
	void Start () {
        Conv = new Conversation();
        SmsStory = new Story(inkJSONAsset.text);
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}

}
