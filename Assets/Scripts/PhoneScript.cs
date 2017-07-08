﻿using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class PhoneScript : MonoBehaviour {

    public string mode = "ContactMenu";

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
        cbs.SetInfos(id, c.Name, c.PhoneNumber);
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


    public void LoadConversation(int i)
    {

    }
}