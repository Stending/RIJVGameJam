using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SecreetScript : MonoBehaviour {

    public Text FoundText;
    public bool Found = false;

    public void SetFound(int current, int on)
    {
        FoundText.text = current + " / " + on;
    }
}

