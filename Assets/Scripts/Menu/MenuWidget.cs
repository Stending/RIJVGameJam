using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuWidget : MonoBehaviour {

    public Text HourText;
    public Text MinuteText;
    public Text DateText;
	// Use this for initialization
	void Start () {

        UpdateTime();
        DateTime dt = System.DateTime.Now;
        DateText.text = EnglishDayToFrench(dt.DayOfWeek.ToString()) + " " + dt.Day + " " + FrenchMonth((int)dt.Month);
    }
	
    public void UpdateTime() {
        DateTime dt = System.DateTime.Now;
        HourText.text = dt.Hour.ToString("00");
        MinuteText.text = dt.Minute.ToString();
        Invoke("UpdateTime", 40.0f);
    } 
    public string EnglishDayToFrench(string day)
    {
        switch (day)
        {
            case "Monday":
                return "lun.";
            case "Tuesday":
                return "mar.";
            case "Wednesday":
                return "merc.";
            case "Thursday":
                return "jeu.";
            case "Friday":
                return "ven.";
            case "Saturday":
                return "sam.";
            case "Sunday":
                return "dim.";
            default:
                return day;
        }
    }

    public string FrenchMonth(int id)
    {
        String[] mois = new String[] { "janv.", "fevr.", "mars", "avr.", "mai", "juin", "juil.", "aout", "sept.", "oct.", "nov.", "dec." };
        return mois[id];
    }
}
