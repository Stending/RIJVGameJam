﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Ink.Runtime;

public class ConversationPanelScript : MonoBehaviour {

    public Contact CurrentContact;

    public Text ContactName;

    public UnityEngine.Object BulleAuthorPrefab;
    public UnityEngine.Object BulleCorrespondantPrefab;

    public UnityEngine.Object ChoicePanelPrefab;

    public ChoicePanel CurrentChoicePanel;

    public RectTransform MessagePanelTransform;

    public List<BulleScript> Bulles;
	// Use this for initialization
	void Start () {
        Bulles = new List<BulleScript>();
	}
	
	// Update is called once per frame
	void Update () {
        LayoutRebuilder.ForceRebuildLayoutImmediate(MessagePanelTransform);

        if (Input.GetKeyDown("space"))
        {
            NewBulle(Random.Range(0, 10) < 5, "Ohlalalalalala jpp jpp jpp trop de pression mais tout va bien merci");
        }
      
	}

    public RectTransform NewBulle(bool author, string msg)
    {
        BulleScript bs = InstantiateBulle(author);
        bs.SetMessage(msg);
        Bulles.Add(bs);
        return bs.GetComponent<RectTransform>();

    }

    public BulleScript InstantiateBulle(bool author)
    {
        GameObject go = Instantiate(((author) ? BulleAuthorPrefab : BulleCorrespondantPrefab), MessagePanelTransform) as GameObject;

        return go.GetComponent<BulleScript>();
    }

    public void LoadContact(Contact cont)
    {
        ContactName.text = cont.Name;
        ResetConv();
        CurrentContact = cont;
        LoadOldConv(cont.Conv);
        StartCoroutine(ContinueStory());
    }

    public void ResetConv()
    {
        foreach(BulleScript bs in Bulles)
        {
            Destroy(bs.gameObject);
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
                    NewBulle(currentAuthor, newSms);
                    retrievingSms = false;
                    yield return new WaitForSeconds(duration);
                }
                string[] strs = text.Split(';');
                currentAuthor = (strs[1] == "A");
                duration = float.Parse(strs[2]);
                retrievingSms = true;
                newSms = strs[3];
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
                    NewBulle(true, newSms);
                    yield return new WaitForSeconds(2.0f);
                }
            }
        }

        //GENERATION DU DERNIER SMS
        if (retrievingSms)
        {
            NewBulle(currentAuthor, newSms);
            retrievingSms = false;
            yield return new WaitForSeconds(duration);
        }


        print("On génère les choix");
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
}
