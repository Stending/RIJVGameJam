using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContactButtonScript : MonoBehaviour {

    int id;
    public Text NameText;
    public Text PhoneNumberText;

    public Image ActiveIconImage;

    private PhoneScript CurrentPhone;
    // Use this for initialization
    void Start () {
        SetActiveImageColor(CurrentPhone.MainColor);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SetInfos(int id, string name, string phoneNumber, PhoneScript ps)
    {
        if (id % 2 == 0)
        {
            this.GetComponent<Image>().color = new Color(0.9f, 0.9f, 0.9f, 1.0f);
        }
        this.id = id;
        NameText.text = name;
        PhoneNumberText.text = phoneNumber;
        CurrentPhone = ps;
    }

    public void Highlight()
    {
        ActiveIconImage.gameObject.SetActive(true);
    }
    public void Unhighlight()
    {
        ActiveIconImage.gameObject.SetActive(false);
    }

    public void SetActiveImageColor(Color col)
    {
        ActiveIconImage.color = col;
    }

    public void OpenConversation()
    {
        CurrentPhone.LoadConversation(id);
    }
}
