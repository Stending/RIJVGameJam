using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ink.Runtime;

[System.Serializable]
public class Contact{

    public Character LinkedCharacter;
    public string Name;
    public string PhoneNumber;

    public TextAsset inkJSONAsset;

    public Story SmsStory;

    public Conversation Conv;
        

	public void Init () {
    //    Conv = new Conversation();
        SmsStory = new Story(inkJSONAsset.text);
	}
	

}
