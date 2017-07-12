using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterScript : MonoBehaviour {

    public MeshRenderer MeshRend;
    public Material OnPhone;
    public Material NotOnPhone;

    private SpriteRenderer SpriteRend;

    private void Start()
    {
       // SpriteRend = this.GetComponent<SpriteRenderer>();
    }
    public void SetOnPhone()
    {
        //SpriteRend.sprite = OnPhone;
        MeshRend.material = OnPhone;
    }

    public void SetNotOnPhone()
    {
        MeshRend.material = NotOnPhone;
    }
}
