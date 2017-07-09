using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConversationPanelScript : MonoBehaviour {

    public Contact CurrentContact;

    public Text ContactName;

    public Object BulleAuthorPrefab;
    public Object BulleCorrespondantPrefab;
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
        while (CurrentContact.SmsStory.canContinue)
        {
            string text = CurrentContact.SmsStory.Continue().Trim();
            if (text.StartsWith("MSG|"))
            {
                
            }
            
        }

        yield return null;
    }
    
}
