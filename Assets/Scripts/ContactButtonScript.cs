using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContactButtonScript : MonoBehaviour {

    int id;
    public Text NameText;
    public Text PhoneNumberText;

    private PhoneScript CurrentPhone;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SetInfos(int id, string name, string phoneNumber, PhoneScript ps)
    {
        this.id = id;
        NameText.text = name;
        PhoneNumberText.text = phoneNumber;
        CurrentPhone = ps;
    }

    public void OpenConversation()
    {
        CurrentPhone.LoadConversation(id);
    }
}
