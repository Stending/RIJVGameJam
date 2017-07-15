using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour {

    public int CurrentSlide = 0;
    public FaderScript Logo;
    public FaderScript Background;

    public Toggle FullscreenToggle;

    public Button LeftArrow;
    public Button RightArrow;

    public MenuSlideScript MenuSlides;
    public List<Transform> Spots = new List<Transform>();
    public int CenterSpotId = 3;
	// Use this for initialization
	void Start () {
        AudioManager.Instance.SetPiste(0, 1.0f);
        FullscreenToggle.isOn = Screen.fullScreen;
	}

    public void StartGame()
    {
        GameManager.Instance.StartGame();
        AudioManager.Instance.LowerSound(0.3f, 1.0f);
        Logo.Disappear();
        Background.Disappear();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("left"))
        {
            PrecSlide();
        }	else if (Input.GetKeyDown("right"))
        {
            NextSlide();
        }
	}

    public void NextSlide()
    {
        if(CurrentSlide < MenuSlides.Count-1)
        {
            CurrentSlide++;

            MenuSlides.GoToSlot(CurrentSlide);
            Logo.ChangeTo(CurrentSlide);
            Background.ChangeTo(CurrentSlide);
            RightArrow.interactable = (CurrentSlide < MenuSlides.Count-1);
            LeftArrow.interactable = (CurrentSlide > 0);

        }
    }

    public void MuteSound(bool sound)
    {
        AudioManager.Instance.gameObject.SetActive(sound);
    }
    public void EnableFullScreen(bool enabled)
    {
        Screen.fullScreen = enabled;
    }
    public void OpenItchIoLink()
    {
        Application.OpenURL("https://stending.itch.io/4cells");
    }

    public void OpenRIJVLink()
    {
        Application.OpenURL("http://rijv.org");
    }
    public void PrecSlide()
    {
        if (CurrentSlide > 0)
        {
            
            CurrentSlide--;
            MenuSlides.GoToSlot(CurrentSlide);

            Logo.ChangeTo(CurrentSlide);
            Background.ChangeTo(CurrentSlide);

            RightArrow.interactable = (CurrentSlide < MenuSlides.Count-1);
            LeftArrow.interactable = (CurrentSlide > 0);
        }
    }

  


}
