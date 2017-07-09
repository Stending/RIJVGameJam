using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomScript : MonoBehaviour {

    public static Vector3 CenterAlone = new Vector3(0, -0.5f, -2);
    public static Vector3[] CenterTwo = new Vector3[] { new Vector3(2, 0, 2.5f), new Vector3(-2, 0, 2.5f) };
    public static Vector3[] ExtremityTwo = new Vector3[] { new Vector3(0, 4, -2), new Vector3(0, -4, -2) };
    public static Vector3[] ExtremityThree = new Vector3[] { new Vector3(0, 4, -2), new Vector3(-6, -2.5f, -2), new Vector3(6, -2.5f, -2) };
    public static Vector3[] ExtremityFour = new Vector3[] { new Vector3(2, 2, 0), new Vector3(-2, 2, 0), new Vector3(2, -2, 0), new Vector3(-2, -2, 0) };

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void MoveToCenter(float time)
    {
        StopAllCoroutines();
        Vector3 newPos = CenterAlone;
        StartCoroutine(MoveToPos(newPos, time));
    }

    public void MoveTo2Center(int nb, float time)
    {
        StopAllCoroutines();
        Vector3 newPos = CenterTwo[nb];
        StartCoroutine(MoveToPos(newPos, time));
    }

    public void MoveTo2Extremity(int nb, float time)
    {
        StopAllCoroutines();
        Vector3 newPos = ExtremityTwo[nb];
        StartCoroutine(MoveToPos(newPos, time));
    }
    public void MoveTo3Extremity(int nb, float time)
    {
        StopAllCoroutines();
        Vector3 newPos = ExtremityThree[nb];
        StartCoroutine(MoveToPos(newPos, time));
    }
    public void MoveTo4Extremity(int nb, float time)
    {
        StopAllCoroutines();
        Vector3 newPos = ExtremityFour[nb];
        StartCoroutine(MoveToPos(newPos, time));
    }

    public IEnumerator MoveToPos(Vector3 newPos, float time)
    {
        Vector3 startPos = this.transform.localPosition;
        print("ON SE DEPLACE DE " + startPos + " à " + newPos + " en " + time +" secondes");
        for (float t = 0; t < time;)
        {
            this.transform.localPosition = Vector3.Lerp(startPos, newPos, t / time);
            t += Time.deltaTime;
            print(t);
            yield return null;
        }
        this.transform.localPosition = newPos;

        yield return null;
    }
}
