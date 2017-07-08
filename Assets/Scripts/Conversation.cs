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

    public ConversationMessage(string message, bool author, float timer)
    {
        Message = message;
        Author = author;
        Timer = timer;
        
    }

    public void InvertAuthor()
    {
        Author = !Author;
    }
}

[System.Serializable]
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
