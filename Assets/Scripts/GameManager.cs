using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Character
{
    Gael,
    Sacha,
    Blanche,
    Vanessa
}

public class GameManager : MonoBehaviour {

    public static GameManager Instance = null;

    public RoomScript[] Rooms = new RoomScript[4];

    public Character CurrentCharacter;
    public Character LinkedCharacter;

    public Dictionary<string, int> triggers;
	// Use this for initialization
	void Awake () {
        if (Instance == null)
            Instance = this;
        else
            Destroy(this);
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("space"))
        {
            Character ch = (Character)Random.Range(0, 4);
            SelectCharacter(ch);
            print("ON SWITCH A " + ch.ToString());

        }
	}

    public void SelectCharacter(Character chara)
    {
        CurrentCharacter = chara;
        Rooms[(int)chara].MoveToCenter(1.0f);
        MoveOtherCharaToExtremity(chara);
    }
    public void SelectLinkedCharacter(Character chara)
    {
        LinkedCharacter = chara;
        Rooms[(int)CurrentCharacter].MoveTo2Center(0, 1.0f);
        Rooms[(int)LinkedCharacter].MoveTo2Center(1, 1.0f);
    }

    public void UnselectCurrentCharacter()
    {

    }

    public void UnselectLinkedCharacter()
    {
        SelectCharacter(CurrentCharacter);
    }

    public void MoveOtherToCharasExtremity(Character chara, Character chara2)
    {
        int charId1 = (int)chara;
        int charId2 = (int)chara2;
        int j = 0;
        for (int i = 0; i < 4; i++)
        {
            if (i != charId1 && i != charId2)
            {
                Rooms[i].MoveTo2Extremity(j, 1.0f);
                j++;
            }
        }
    }
    public void MoveOtherCharaToExtremity(Character chara)
    {
        int charId = (int)chara;
        int j = 0;
        for(int i = 0; i < 4; i++)
        {
            if (i != charId)
            {
                Rooms[i].MoveTo3Extremity(j, 1.0f);
                j++;
            }
        }
    }

    public void MoveEveryoneToExtremity()
    {
        for (int i = 0; i < 4; i++)
        {
                Rooms[i].MoveTo3Extremity(i, 1.0f);
        }
    }
}
