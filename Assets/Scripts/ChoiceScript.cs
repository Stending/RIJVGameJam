using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Ink.Runtime;

public class ChoiceScript : MonoBehaviour {


    public static int LINE_SIZE = 30;

    public Choice choice;
    public Text ChoiceText;

    public ChoicePanel CurrentChoicePanel;

    public void SetInfos(Choice choice, string text, ChoicePanel choicePanel)
    {
        this.choice = choice;
        CurrentChoicePanel = choicePanel;
        SetChoiceText(text);
    }

    public void SetChoiceText(string msg)
    {
        int lastBackspace = 0;
        string currentLine = msg.Substring(lastBackspace, Mathf.Min(msg.Length, lastBackspace + LINE_SIZE));
        while (currentLine.Length > LINE_SIZE - 1)
        {
            if (currentLine.Contains("\n"))
            {
                lastBackspace += currentLine.Substring(0, LINE_SIZE).LastIndexOf('\n') + 1;
            }
            else if (currentLine.Contains(" "))
            {

                lastBackspace += currentLine.Substring(0, LINE_SIZE).LastIndexOf(' ');
                msg.Remove(lastBackspace);
                msg = msg.Insert(lastBackspace, "\n");
                lastBackspace++;
            }
            else
            {
                lastBackspace += LINE_SIZE - 1;
                msg = msg.Insert(lastBackspace, "\n");
                lastBackspace++;
            }
            currentLine = msg.Substring(lastBackspace, Mathf.Min(msg.Length - lastBackspace, lastBackspace + LINE_SIZE));
        }
        ChoiceText.text = msg;
    }



    public void SelectChoice()
    {
        CurrentChoicePanel.SelectChoice(choice);
    }
}
