using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ink.Runtime;
using UnityEngine.UI;

public class ChoicePanel : MonoBehaviour {

    
    public delegate void ChoiceSelection(Choice choice);
    public event ChoiceSelection ChoiceSelected;

    public UnityEngine.Object ChoicePrefab;

    public List<ChoiceScript> Choices;

    private void Update()
    {
        LayoutRebuilder.ForceRebuildLayoutImmediate(this.GetComponent<RectTransform>());
    }

    public void CreateChoice(string str, Choice ch)
    {
        GameObject go = Instantiate(ChoicePrefab, this.transform) as GameObject;
        ChoiceScript cs = go.GetComponent<ChoiceScript>();
        cs.SetInfos(ch, str, this);
    }


    public void SelectChoice(Choice choice)
    {
        ChoiceSelected(choice);
    }
}
