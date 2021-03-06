﻿using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class PhoneScript : MonoBehaviour {

    public delegate void ClassicEvent();
    public event ClassicEvent PhoneFinished;
    public event ClassicEvent ContactOpened;
    public Transform SourceTrans;
    public Transform AppearedTrans;
    public string mode = "Desktop";

    public Color MainColor = new Color32(247, 186, 193, 255);
    public AudioClip SmsSound;

    public Animator PhoneAnim;

    public int NextContact = 0;

    public Animator NavBarAnim;
    public Animator ContactMenuAnim;
    public Animator MessageMenuAnim;
    public ConversationPanelScript ConversationPanel;

    public Object ContactButtonPrefab;

    public List<Contact> Contacts;
    public List<ContactButtonScript> ContactButtons;
    public Transform ContactListTransform;

    public List<Text> TextsToColor;
    public List<Image> ImagesToColor;


    public Transform CameraTransform;
    // Use this for initialization
	void Start () {
        Appear();
        
        ContactButtons = new List<ContactButtonScript>();
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
	

    public void LoadData()
    {
        int i = 0;
        foreach(Contact c in Contacts)
        {
            if (c.Ignore)
                continue;
            InstantiateContact(i, c);
            c.Init();
            i++;
        }
    }

    public void UpdateButtons()
    {
        for(int i = 0; i < ContactButtons.Count; i++)
        {
            ContactButtonScript cbs = ContactButtons[i];
            Contact c = Contacts[i];

            if (c.Finished)
            {
                cbs.Unhighlight();
            }else if (ConditionsValidated(c.Conditions))
            {
                cbs.Highlight();
                c.Readable = true;
                if (c.InvisibleAtFirst)
                    cbs.Unhide();
            }
            else
            {
                c.Readable = false;
                if (c.InvisibleAtFirst)
                    cbs.Hide();
                else
                    cbs.Unhighlight();
            }
            
        }
    }

    public bool ConditionsValidated(List<int> conds)
    {
        foreach(int i in conds)
        {
            if (!Contacts[i].Finished)
                return false;
        }
        return true;
    }

    public void InstantiateContact(int id, Contact c)
    {
        GameObject go = Instantiate(ContactButtonPrefab, ContactListTransform) as GameObject;
        ContactButtonScript cbs = go.GetComponent<ContactButtonScript>();
        cbs.SetInfos(id, c.Name, c.PhoneNumber, this);
        ContactButtons.Add(cbs);
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
            if (ContactOpened != null)
                ContactOpened();
            NavBarAnim.SetBool("Active", false);
            ContactMenuAnim.SetBool("Active", true);
            MessageMenuAnim.SetBool("Active", false);
            mode = "ContactMenu";
            UpdateButtons();
        }
    }

    public void GoBackToContactMenu()
    {
        if (mode == "InConversation")
        {
            GameManager.Instance.SetCurrentCharacterOnPhone(false);
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
            if (Contacts[contactId].Readable)
            {
                GameManager.Instance.SetCurrentCharacterOnPhone(true);
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
        UpdateButtons();
        if(AllContactsFinished())
        {
            Invoke("PhoneFinishedCall", 2.0f);
        }
    }

    private void PhoneFinishedCall()
    {
        PhoneFinished();
    }


    public bool AllContactsFinished()
    {
        foreach (Contact c in Contacts)
        {
            if (!c.Finished && !c.Ignore)
                return false;
        }
        return true;
    }

    public void PlaySmsSound()
    {
        AudioManager.Instance.PlaySfx(SmsSound);
    }
    public void HomeButton()
    {
        GameManager.Instance.SetCurrentCharacterOnPhone(false);
        NavBarAnim.SetBool("Active", true);
        ContactMenuAnim.SetBool("Active", false);
        MessageMenuAnim.SetBool("Active", false);
        mode = "Desktop";
    }


   /* public void ComeFromLeft()
    {
        PhoneAnim.SetBool("Left", true);
        PhoneAnim.SetBool("Active", true);
    }

    public void ComeFromRight()
    {
        PhoneAnim.SetBool("Left", false);
        PhoneAnim.SetBool("Active", true);
    }*/

    public void Appear()
    {
        StopAllCoroutines();
        StartCoroutine(GoToSpotIn(SourceTrans, AppearedTrans, 0.8f));
    }
    public void Disappear()
    {
        StopAllCoroutines();
        StartCoroutine(GoToSpotIn(AppearedTrans, SourceTrans, 0.8f));
    }

    public void DisableIn(float sec)
    {
        Invoke("Disable", sec);
    }

    private void Disable()
    {
        this.gameObject.SetActive(false);
    }


    public void GoToSpot(Transform from, Transform trans, float time)
    {
        StopAllCoroutines();
        StartCoroutine(GoToSpotIn(from, trans, time));

    }
    public IEnumerator GoToSpotIn(Transform from, Transform trans, float time)
    {
        transform.localPosition = from.localPosition; transform.localEulerAngles = from.localEulerAngles; transform.localScale = from.localScale;
        Vector3 startPos = this.transform.localPosition;
        Vector3 goalPos = trans.localPosition;
        Vector3 startRot = this.transform.localEulerAngles;
        Vector3 goalRot = trans.localEulerAngles;
        Vector3 startScale = this.transform.localScale;
        Vector3 goalScale = trans.localScale;
        

        if (startRot.z > 180)
            startRot = new Vector3(startRot.x, startRot.y, -360 + startRot.z);
        if (goalRot.z > 180)
            goalRot = new Vector3(goalRot.x, goalRot.y, -360 + goalRot.z);
        if (startRot.x > 180)
            startRot = new Vector3(-360 + startRot.x, startRot.y, startRot.z);
        if (goalRot.x > 180)
            goalRot = new Vector3(-360 + goalRot.x, goalRot.y, goalRot.z);

        for (float f = 0; f < time; f += Time.deltaTime)
        {


            /*float posX = tweenFunction(f, startPos.x, goalPos.x - startPos.x, time);
            float posY = tweenFunction(f, startPos.y, goalPos.y - startPos.y, time);
            float posZ = tweenFunction(f, startPos.z, goalPos.z - startPos.z, time);

            float rotX = rotTweenFunction(f, startRot.x, goalRot.x - startRot.x, time);
            float rotY = rotTweenFunction(f, startRot.y, goalRot.y - startRot.y, time);
            float rotZ = rotTweenFunction(f, startRot.z, goalRot.z - startRot.z, time);

            Vector3 newPos = new Vector3(posX, posY, posZ);
            Vector3 newRot = new Vector3(rotX, rotY, rotZ);
            this.transform.localPosition = newPos;
            this.transform.localEulerAngles = newRot;*/


            this.transform.localPosition = Vector3.Lerp(startPos, goalPos, f / time);
            this.transform.localEulerAngles = Vector3.Lerp(startRot, goalRot, f / time);
            this.transform.localScale = Vector3.Lerp(startScale, goalScale, f / time);

            yield return null;
        }

        this.transform.localPosition = goalPos;
        this.transform.localEulerAngles = goalRot;
        this.transform.localScale = goalScale;
    }

    private float tweenFunction(float t, float b, float c, float d)
    {
        return Tween.EaseOutCirc(t, b, c, d);
        //return Tween.EaseInBack(t, b, c, d);
    }

    private float rotTweenFunction(float t, float b, float c, float d)
    {
        return Tween.EaseOutCirc(t, b, c, d);
    }


}
