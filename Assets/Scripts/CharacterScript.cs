using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterScript : MonoBehaviour {

    public MeshRenderer MeshRend;
    public Material OnPhone;
    public Material NotOnPhone;

    public CharacterScript RecursiveCharacter;

    private SpriteRenderer SpriteRend;

    private void Start()
    {

    }
    public void SetOnPhone()
    {
        MeshRend.sharedMaterial = OnPhone;
        if(RecursiveCharacter != null)
            RecursiveCharacter.SetOnPhone();
    }

    public void SetNotOnPhone()
    {
        MeshRend.material = NotOnPhone;
        if (RecursiveCharacter != null)
            RecursiveCharacter.SetNotOnPhone();
    }
}
