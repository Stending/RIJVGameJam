using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class PhoneScript : MonoBehaviour {

    public delegate void ClassicEvent();
    public event ClassicEvent PhoneFinished;
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
        print("On se met à la position" + SourceTrans.localPosition);
        
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
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown("t"))
        {
            foreach(Contact c in Contacts)
            {
                c.Readable = true;
                c.Finished = true;
            }
            UpdateButtons();
        }
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
            PhoneFinished();
        }
    }

    public bool AllContactsFinished()
    {
        foreach (Contact c in Contacts)
        {
            if (!c.Finished)
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
        for (float t = 0; t < time; t += Time.deltaTime)
        {

            this.transform.localPosition = Vector3.Lerp(startPos, goalPos, t / time);
            this.transform.localEulerAngles = Vector3.Lerp(startRot, goalRot, t / time);
            this.transform.localScale = Vector3.Lerp(startScale, goalScale, t / time);
            yield return null;
        }

        this.transform.localPosition = goalPos;
        this.transform.localEulerAngles = goalRot;
        this.transform.localScale = goalScale;
    }


}
