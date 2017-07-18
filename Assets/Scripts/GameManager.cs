using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public enum Character
{
    Blanche,
    Gael,
    Vanessa,
    Sacha,
    et
}

public class GameManager : MonoBehaviour {

    public static bool DEBUG = true;
    public static GameManager Instance = null;

    public CameraScript Camera;
    
    public RoomScript[] Rooms = new RoomScript[4];
    public PhoneScript[] Phones = new PhoneScript[4];
    public CharacterScript[] Characters = new CharacterScript[4];
    public DayTexts DayTextAnnounces;

    public GameObject EndBackground;

    public PhoneScript CurrentPhone;

    public Animator TutoScreenAnim;
    public Transform LargeViewSpot;
    public List<Transform> CharacterViewSpots;
    public Transform EndViewSpot;


    public Character CurrentCharacter;
    public Character LinkedCharacter;

    public GameObject etHouse;

    public Dictionary<string, int> triggers;
	// Use this for initialization
	void Awake () {
        if (Instance == null)
            Instance = this;
        else
            Destroy(this);
	}

    private void Start()
    {
        EndBackground.SetActive(false);
        //StartPhone(CurrentCharacter);
    }
    

    public void StartGame()
    {
        LargeView();
        CurrentCharacter = Character.Blanche;
        DayTextAnnounces.SwitchToText(0);
        Invoke("NextDay", 5.0f);
    }


    public void LargeView()
    {
        Camera.GoToSpot(LargeViewSpot, 4.0f);
    }

    public void EndView()
    {
        Camera.GoToSpot(EndViewSpot, 6.0f);
    }

    public void StartPhone(Character chara) 
    {
        CurrentPhone = Phones[(int)chara];
        CurrentPhone.gameObject.SetActive(true);
        SelectCharacter(chara);
        if(chara == Character.Blanche)
        {
            Invoke("TutoAppear", 2.0f);
            CurrentPhone.ContactOpened += EndTuto;
        }
        if(chara == Character.Blanche ||chara == Character.Gael)
        {
            CurrentPhone.Appear();
            
        }
        else
        {
            CurrentPhone.Appear();
            //CurrentPhone.ComeFromLeft();
        }
        CurrentPhone.PhoneFinished += FinishPhone;

        Characters[(int)CurrentCharacter].SetOnPhone();
    }

    public void SetCurrentCharacterOnPhone(bool on)
    {
        if (on)
            Characters[(int)CurrentCharacter].SetOnPhone();
        else
            Characters[(int)CurrentCharacter].SetNotOnPhone();
    }

    public void TutoAppear()
    {
        TutoScreenAnim.SetBool("Active", true);
    }

    public void EndTuto()
    {
        Invoke("TutoDisappear", 3.0f);
    }
    public void TutoDisappear()
    {
        TutoScreenAnim.SetBool("Active", false);
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape)){
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        if (Input.GetKeyDown("p") && DEBUG)
        {
            
            FinishPhone();
        }
	}

    public void FinishPhone()
    {
        Characters[(int)CurrentCharacter].SetNotOnPhone();
        CurrentPhone.Disappear();
        CurrentPhone.DisableIn(2.0f);
        UpdatePhonesWithConv(CurrentPhone, CurrentCharacter);
        int charId = (int)CurrentCharacter + 1;
        
        if (charId < 4)
        {
            CurrentCharacter = (Character)charId;
            DayTextAnnounces.SwitchToText(charId);
            /*if (charId == 2)
                CameraMoveToRight();*/
            Invoke("LargeView", 1.0f);
            AudioManager.Instance.LowerSound(0.7f, 1.0f);
            Invoke("NextDay", 6.0f);
        }
        else
        {
            //Camera.GoToSpot(EndViewSpot);
            Invoke("LargeView", 2.0f);
            Invoke("EndView", 8.0f);
            EndBackground.SetActive(true);
            print("FINI");
            DayTextAnnounces.SwitchToText(5);
        }
    }

    
    public void UpdatePhonesWithConv(PhoneScript originPhone, Character chara)
    {
       for(int i = 0; i < 4; i++)
        {
            Character currentChara = (Character)i;
            if (currentChara != chara) {
                Phones[i].ChangeConversationWith(chara, originPhone.GetConversationFrom(currentChara).InvertAuthors());
            }
        }
    }

    public void Unlocket()
    {
        foreach(PhoneScript p in Phones)
        {
            Contact c = p.GetContact(Character.et);
            if (c != null)
                c.Ignore = false;
        }
        etHouse.SetActive(true);
    }
    public void NextDay()
    {
        ZoomTo(CurrentCharacter);
        if(CurrentCharacter == Character.Blanche)
            AudioManager.Instance.SetPiste((int)CurrentCharacter + 1, 4.0f);
        else
            AudioManager.Instance.SetPiste((int)CurrentCharacter + 1, 2.0f);
        Invoke("StartCurrentPhone", 4.0f);
    }

    public void StartCurrentPhone()
    {
        StartPhone(CurrentCharacter);
    }

    public void ZoomTo(Character chara)
    {
        Camera.GoToSpot(CharacterViewSpots[(int)chara], 4.0f);
    }


    public void SelectCharacter(Character chara)
    {
        CurrentCharacter = chara;
        //Rooms[(int)chara].MoveToCenter(1.0f);
      //  MoveOtherCharaToExtremity(chara);
    }
    public void SelectLinkedCharacter(Character chara)
    {
        LinkedCharacter = chara;
        //Rooms[(int)CurrentCharacter].MoveTo2Center(0, 1.0f);
        //Rooms[(int)LinkedCharacter].MoveTo2Center(1, 1.0f);
    }

    public void UnselectCurrentCharacter()
    {

    }

/*    public void UnselectLinkedCharacter()
    {
        SelectCharacter(CurrentCharacter);
    }*/

    /*public void MoveOtherToCharasExtremity(Character chara, Character chara2)
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
    }*/
}
