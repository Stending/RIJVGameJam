using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class PhoneScript : MonoBehaviour {

    public string mode = "Desktop";


    public Animator NavBarAnim;
    public Animator ContactMenuAnim;
    public Animator MessageMenuAnim;
    public ConversationPanelScript ConversationPanel;

    public Object ContactButtonPrefab;

    public List<Contact> Contacts;
    public Transform ContactListTransform;

    // Use this for initialization
	void Start () {
        LoadData();
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    public void LoadData()
    {
        int i = 0;
        foreach(Contact c in Contacts)
        {
            InstantiateContact(i, c);
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
    public void LoadConversation(int contactId)
    {
        if (mode == "ContactMenu")
        {
            NavBarAnim.SetBool("Active", false);
            ContactMenuAnim.SetBool("Active", false);
            MessageMenuAnim.SetBool("Active", true);
            ConversationPanel.LoadContact(Contacts[contactId]);

        }

    }
    public void HomeButton()
    {
        NavBarAnim.SetBool("Active", true);
        ContactMenuAnim.SetBool("Active", false);
        MessageMenuAnim.SetBool("Active", false);
        mode = "Desktop";
    }

}
