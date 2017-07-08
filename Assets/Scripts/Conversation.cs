using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConversationMessage
{
    public string Message;
    public bool Author;

    public ConversationMessage(string message, bool author)
    {
        Message = message;
        Author = author;
    }

    public void InvertAuthor()
    {
        Author = !Author;
    }
}
public class Conversation {

    public List<ConversationMessage> Messages;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void InvertAuthors()
    {
        foreach(ConversationMessage cm in Messages)
        {
            cm.InvertAuthor();
        }
    }
}
