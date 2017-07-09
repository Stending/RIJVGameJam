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
        string currentLine = msg.Substring(lastBackspace, Mathf.Min(msg.Length, lastBackspace+ LINE_SIZE));
        while (currentLine.Length > LINE_SIZE - 1)
        {
            print("On traite la ligne : " + currentLine);
            if (currentLine.Contains("\n"))
            {
                lastBackspace += currentLine.Substring(0, LINE_SIZE).LastIndexOf('\n')+1;
                print("Il y a déjà un retour à la ligne, on passe à la suite");
            }
            else if (currentLine.Contains(" "))
            {

                lastBackspace += currentLine.Substring(0, LINE_SIZE).LastIndexOf(' ');
                print("Elle contient un espace au charactère " + currentLine.Substring(0, LINE_SIZE).LastIndexOf(' ') + "("+lastBackspace+")(juste après la lettre "+msg[lastBackspace-1]);
                msg.Remove(lastBackspace);
                msg = msg.Insert(lastBackspace, "\n");
                print(msg.LastIndexOf("\n"));
                lastBackspace ++;
                print("On le remplace et on obtient : " + msg);
            }
            else
            {
                print("Elle ne contient pas d'espace donc on va à la ligne à la fin");
                lastBackspace += LINE_SIZE-1;
                msg = msg.Insert(lastBackspace, "\n");
                lastBackspace ++;
                print("En faisant ça, on obtient : " + msg);
            }
            currentLine = msg.Substring(lastBackspace, Mathf.Min(msg.Length - lastBackspace, lastBackspace + LINE_SIZE));
        }
        MessageText.text = msg;
    }

    
}
