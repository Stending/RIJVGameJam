using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConversationPanelScript : MonoBehaviour {

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
            RectTransform rt = NewBulle(Random.Range(0, 10) < 5, "Ohlalalalalala jpp jpp jpp trop de pression mais tout va bien merci");
            LayoutRebuilder.ForceRebuildLayoutImmediate(MessagePanelTransform);
        }
      
	}

    public RectTransform NewBulle(bool author, string msg)
    {
        BulleScript bs = InstantiateBulle(author);
        bs.SetMessage(msg);
        return bs.GetComponent<RectTransform>();

    }

    public BulleScript InstantiateBulle(bool author)
    {
        GameObject go = Instantiate(((author) ? BulleAuthorPrefab : BulleCorrespondantPrefab), MessagePanelTransform) as GameObject;

        return go.GetComponent<BulleScript>();
    }

    
}
