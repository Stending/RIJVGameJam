using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class PhoneScript : MonoBehaviour {

    public delegate void ClassicEvent();
    public event ClassicEvent PhoneFinished;

    public string mode = "Desktop";

    public Color MainColor = new Color32(247, 186, 193, 255);

    public Animator PhoneAnim;

    public int NextContact = 0;

    public Animator NavBarAnim;
    public Animator ContactMenuAnim;
    public Animator MessageMenuAnim;
    public ConversationPanelScript ConversationPanel;

    public Object ContactButtonPrefab;

    public List<Contact> Contacts;
    public List<Button> ContactButtons;
    public Transform ContactListTransform;

    public List<Text> TextsToColor;
    public List<Image> ImagesToColor;


    public Transform CameraTransform;
    // Use this for initialization
	void Start () {
        ContactButtons = new List<Button>();
        LoadData();

        foreach(Text t in TextsToColor)
        {
            t.color = MainColor;
        }
        foreach(Image im in ImagesToColor)
        {
            im.color = MainColor;
        }
	}
	
	// Update is called once per frame
	void Update () {

        //this.transform.LookAt(CameraTransform);
		
	}

    public void LoadData()
    {
        int i = 0;
        foreach(Contact c in Contacts)
        {
            InstantiateContact(i, c);
            c.Init();
            i++;
        }
    }


    public void InstantiateContact(int id, Contact c)
    {
        GameObject go = Instantiate(ContactButtonPrefab, ContactListTransform) as GameObject;
        ContactButtonScript cbs = go.GetComponent<ContactButtonScript>();
        cbs.SetInfos(id, c.Name, c.PhoneNumber, this);
    }

    public Contact GetContact(string name)
    {

        foreach(Contact c in Contacts)
        {
            if (c.Name == name)
                return c;
        }
        return null;
    }

    public void LoadContactMenu()
    {
        if (mode == "Desktop")
        {
            NavBarAnim.SetBool("Active", false);
            ContactMenuAnim.SetBool("Active", true);
            MessageMenuAnim.SetBool("Active", false);
            mode = "ContactMenu";
        }
    }

    public void GoBackToContactMenu()
    {
        if (mode == "InConversation")
        {
            NavBarAnim.SetBool("Active", false);
            ContactMenuAnim.SetBool("Active", true);
            MessageMenuAnim.SetBool("Active", false);
            mode = "ContactMenu";
        }
    }

    
    public void LoadConversation(int contactId)
    {
        
        if (mode == "ContactMenu")
        {
            if (contactId == NextContact)
            {
                NavBarAnim.SetBool("Active", false);
                ContactMenuAnim.SetBool("Active", false);
                MessageMenuAnim.SetBool("Active", true);
                ConversationPanel.LoadContact(Contacts[contactId]);
                ConversationPanel.StoryFinished += SwitchNextContact;
                mode = "InConversation";
            }
        }
    }

    public void ChangeConversationWith(Character chara, Conversation conv)
    {
        Contact c = GetContact(chara);
        c.Conv = conv;

    }

    public Conversation GetConversationFrom(Character chara)
    {
        return GetContact(chara).Conv;
    }

    public Contact GetContact(Character chara)
    {

        foreach (Contact c in Contacts)
        {
            if (c.LinkedCharacter == chara)
            {
                return c;
            }
        }
        return null;
    }
    public void SwitchNextContact()
    {
        NextContact++;
        if(NextContact >= Contacts.Count)
        {
            PhoneFinished();
        }
    }

    public void HomeButton()
    {
        NavBarAnim.SetBool("Active", true);
        ContactMenuAnim.SetBool("Active", false);
        MessageMenuAnim.SetBool("Active", false);
        mode = "Desktop";
    }


    public void ComeFromLeft()
    {
        PhoneAnim.SetBool("Left", true);
        PhoneAnim.SetBool("Active", true);
    }

    public void ComeFromRight()
    {
        PhoneAnim.SetBool("Left", false);
        PhoneAnim.SetBool("Active", true);
    }

    public void LeaveToBottom()
    {
        PhoneAnim.SetBool("Active", false);
    }

    public void DisableIn(float sec)
    {
        Invoke("Disable", sec);
    }

    private void Disable()
    {
        this.gameObject.SetActive(false);
    }

}
