using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Choix
{
    public string text;
    public List<ConversationMessage> messages;
}


[System.Serializable]
public class ConversationMessage
{
    public string Message;
    public bool Author;
    public float Timer;

    public ConversationMessage(string message, bool author)
    {
        Message = message;
        Author = author;
    }

    public ConversationMessage InvertAuthor()
    {
        return new ConversationMessage(Message, !Author);
    }
}

[System.Serializable]
public class Conversation {

    public List<ConversationMessage> Messages = new List<ConversationMessage>();

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void AddMessage(ConversationMessage cm)
    {
        Messages.Add(cm);
    }
    public Conversation InvertAuthors()
    {
        Conversation con = new Conversation();
        foreach(ConversationMessage cm in Messages)
        {
            con.AddMessage(cm.InvertAuthor());
        }
        return con;
    }
}
