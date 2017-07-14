using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuSlideScript : MonoBehaviour {

    public int Count = 4;
    public int XDiff;
    public float timeTransition = 1.0f;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void GoToSlot(int slot)
    {
        StopAllCoroutines();
        StartCoroutine(MoveToSlide(slot, timeTransition));
    }


    public IEnumerator MoveToSlide(int slot, float time)
    {
        RectTransform rectTr = (RectTransform)this.transform;
        Vector3 startPos = rectTr.localPosition;
        Vector3 goalPos = new Vector3(XDiff * -slot, 0, 0);
        for (float t = 0; t < time; t += Time.deltaTime)
        {

            rectTr.localPosition = Vector3.Lerp(startPos, goalPos, t / time);
            yield return null;
        }
        rectTr.localPosition = goalPos;
        yield return null;
    }
}
