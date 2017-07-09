using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterScript : MonoBehaviour {

    public Sprite OnPhone;
    public Sprite NotOnPhone;

    private SpriteRenderer SpriteRend;

    private void Start()
    {
       // SpriteRend = this.GetComponent<SpriteRenderer>();
    }
    public void SetOnPhone()
    {
        //SpriteRend.sprite = OnPhone;
    }

    public void SetNotOnPhone()
    {
        //SpriteRend.sprite = NotOnPhone;
    }
}
