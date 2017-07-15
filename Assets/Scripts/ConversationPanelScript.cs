using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Ink.Runtime;

public class ConversationPanelScript : MonoBehaviour {


    public delegate void ClassicEvent();
    public event ClassicEvent StoryFinished;

    public Contact CurrentContact;

    public Text ContactName;

    public UnityEngine.Object BulleAuthorPrefab;
    public UnityEngine.Object BulleCorrespondantPrefab;

    public UnityEngine.Object ChoicePanelPrefab;

    public UnityEngine.Object ConversationEndPrefab;


    public ChoicePanel CurrentChoicePanel;

    public RectTransform MessagePanelTransform;

    public PhoneScript CurrentPhone;
    public List<BulleScript> Bulles;
	// Use this for initialization
	void Start () {
        Bulles = new List<BulleScript>();
	}
	
	// Update is called once per frame
	void Update () {
        LayoutRebuilder.ForceRebuildLayoutImmediate(MessagePanelTransform);
        if (Input.GetKeyDown("r"))
        {
            CurrentContact.Init();
            CurrentContact.Conv = new Conversation();
            ResetConv();
            StartCoroutine(ContinueStory());

        }
	}

    public RectTransform NewBulle(bool author, string msg)
    {
        BulleScript bs = InstantiateBulle(author);
        bs.SetMessage(msg);
        Bulles.Add(bs);
        return bs.GetComponent<RectTransform>();

    }

    public RectTransform NewMessage(bool author, string msg)
    {
        if (!author)
            CurrentPhone.PlaySmsSound();
        CurrentContact.Conv.Messages.Add(new ConversationMessage(msg, author));
        return NewBulle(author, msg);
    }

    public BulleScript InstantiateBulle(bool author)
    {
        GameObject go = Instantiate(((author) ? BulleAuthorPrefab : BulleCorrespondantPrefab), MessagePanelTransform) as GameObject;

        return go.GetComponent<BulleScript>();
    }

    public void LoadContact(Contact cont)
    {
        ContactName.text = cont.Name;
        StoryFinished = null;
        ResetConv();
        CurrentContact = cont;
        LoadOldConv(cont.Conv);
        StartCoroutine(ContinueStory());
    }

    public void ResetConv()
    {
        StopAllCoroutines();
        foreach(BulleScript bs in Bulles)
        {
            Destroy(bs.gameObject);
        }
        foreach(Transform child in MessagePanelTransform)
        {
            Destroy(child.gameObject);
        }
        Bulles.Clear();
    }

    public void LoadOldConv(Conversation conv)
    {
        foreach(ConversationMessage mes in conv.Messages)
        {
            NewBulle(mes.Author, mes.Message);
        }
    }

    public IEnumerator ContinueStory()
    {
        bool retrievingSms = false;
        string newSms = "";
        float duration = 0.0f;
        bool currentAuthor = false;

        while (CurrentContact.SmsStory.canContinue)
        {
            //GENERATION DES SMS
            string text = CurrentContact.SmsStory.Continue().Trim();
            if (text == " " || text == "" || text == "\n")
                continue;
            if (text.StartsWith("MSG;"))
            {
                if (retrievingSms)
                {
                    NewMessage(currentAuthor, newSms);
                    retrievingSms = false;
                    yield return new WaitForSeconds(duration);
                }
                string[] strs = text.Split(';');
                currentAuthor = (strs[1] == "A");
                duration = float.Parse(strs[2]);
                retrievingSms = true;
                newSms = text.Substring(7+strs[2].Length, text.Length- (7 + strs[2].Length)) ;
            }
            else
            {
                if (retrievingSms)
                {
                    newSms += "\n" + text;
                }
                else
                {
                    newSms = text;
                    NewMessage(true, newSms);
                    yield return new WaitForSeconds(2.0f);
                }
            }
        }

        //GENERATION DU DERNIER SMS
        if (retrievingSms)
        {
            NewMessage(currentAuthor, newSms);
            retrievingSms = false;
            yield return new WaitForSeconds(duration);
        }


        //GENERATION DES CHOIX
        if (CurrentContact.SmsStory.currentChoices.Count > 0)
        {
            CurrentChoicePanel = InstantiateChoicePanel();
            for (int i = 0; i < CurrentContact.SmsStory.currentChoices.Count; i++)
            {
                Choice choice = CurrentContact.SmsStory.currentChoices[i];
                CurrentChoicePanel.CreateChoice(choice.text.Trim(), choice);
            }
            CurrentChoicePanel.ChoiceSelected += SelectChoice;
        }
        else
        {
            //STORY TERMINÉE
            if (!CurrentContact.Finished)
            {
                CurrentContact.Finished = true;
                StoryFinished();
            }
            InstantiateConversationEndPanel();
        }
    }


    public void SelectChoice(Choice choice)
    {
        CurrentContact.SmsStory.ChooseChoiceIndex(choice.index);
        Destroy(CurrentChoicePanel.gameObject);
        //TODO animation
        CurrentChoicePanel = null;
        StartCoroutine(ContinueStory());
    }

    public ChoicePanel InstantiateChoicePanel()
    {
        GameObject go = Instantiate(ChoicePanelPrefab, MessagePanelTransform) as GameObject;
        return go.GetComponent<ChoicePanel>();
    }

    public void InstantiateConversationEndPanel()
    {
        Instantiate(ConversationEndPrefab, MessagePanelTransform);
    }
}
