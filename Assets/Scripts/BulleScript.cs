using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BulleScript : MonoBehaviour {

    public static int LINE_SIZE = 30;

    public Text MessageText;


	void Start () {
        //SetMessage("Salut c'est Matthieu j'ai besoin d'aide aidez moi j'en peux plus s'il vous plaaaait !!");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SetMessage(string msg)
    {
        int lastBackspace = 0;
        string currentLine = msg.Substring(lastBackspace, Mathf.Min(msg.Length, LINE_SIZE));
        while (currentLine.Length > LINE_SIZE - 1)
        {
            print("On traite la ligne " + currentLine);
            if (currentLine.Contains("\n"))
            {
                lastBackspace += currentLine.LastIndexOf('\n')+1;
            }
            else if (currentLine.Contains(" "))
            {
                print("Elle contient un espace, du coup on coupe la ligne ici");
                lastBackspace += currentLine.LastIndexOf(' ');
                msg.Remove(lastBackspace);
                msg = msg.Insert(lastBackspace, "\n");
                lastBackspace +=2;
            }
            else
            {
                lastBackspace += LINE_SIZE-1;
                msg = msg.Insert(lastBackspace, "\n");
                lastBackspace +=2;
            }
            print("On coupe de " + lastBackspace + " à " + Mathf.Min(msg.Length - lastBackspace, lastBackspace + LINE_SIZE));
            currentLine = msg.Substring(lastBackspace, Mathf.Min(msg.Length - lastBackspace, LINE_SIZE));
        }
        MessageText.text = msg;
    }



    
}
