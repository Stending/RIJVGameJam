using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaderScript : MonoBehaviour {

    public Sprite[] SpritesArr = new Sprite[4];
    public SpriteRenderer SR1;
    public SpriteRenderer SR2;
    public int baseLayer = 0;
    private int currentSR = 0;
   


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ChangeTo(int id)
    {
        OtherSR.sortingOrder = baseLayer;
        OtherSR.GetComponent<Animator>().Play("Appeared");
        OtherSR.sprite = SpritesArr[id];
        CurrentSR.sortingOrder = baseLayer+1;
        CurrentSR.GetComponent<Animator>().Play("Disappear");
        SwitchSR();
    }

    public void Disappear()
    {
        OtherSR.sortingOrder = baseLayer;
        OtherSR.gameObject.SetActive(false);
        CurrentSR.sortingOrder = baseLayer + 1;
        CurrentSR.GetComponent<Animator>().Play("Disappear");
    }

    public void SwitchSR()
    {
        currentSR = (currentSR == 0) ? 1 : 0;
    }
    public SpriteRenderer CurrentSR
    {
        get
        {
            return (currentSR == 0) ?SR1:SR2;
        }
    }

    public SpriteRenderer OtherSR
    {
        get
        {
            return (currentSR == 0) ? SR2 : SR1;
        }
    }
}
