using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void GoToSpot(Transform trans)
    {
        StopAllCoroutines();
        StartCoroutine(GoToSpotIn(trans, .5f));

    }
    public void GoToSpot(Transform trans, float time)
    {
        StopAllCoroutines();
        StartCoroutine(GoToSpotIn(trans, time));

    }
    public IEnumerator GoToSpotIn(Transform trans, float time)
    {
        Vector3 startPos = this.transform.localPosition;
        Vector3 goalPos = trans.localPosition;
        Vector3 startRot = this.transform.localEulerAngles;
        Vector3 goalRot = trans.localEulerAngles;

        if (startRot.z > 180)
            startRot = new Vector3(startRot.x, startRot.y, -360 + startRot.z);
        if (goalRot.z > 180)
            goalRot = new Vector3(goalRot.x, goalRot.y, -360 + goalRot.z);
        if (startRot.x > 180)
            startRot = new Vector3(-360 + startRot.x, startRot.y, startRot.z);
        if (goalRot.x > 180)
            goalRot = new Vector3(-360 + goalRot.x, goalRot.y, goalRot.z);
       /* for (float t = 0; t < time; t += Time.deltaTime)
        {

            this.transform.localPosition = Vector3.Lerp(startPos, goalPos, t / time);
            this.transform.localEulerAngles = Vector3.Lerp(startRot, goalRot, t / time);
            yield return null;
        }
        
        this.transform.localPosition = goalPos;
        this.transform.localEulerAngles = goalRot;*/


        for (float f = 0; f < time; f += Time.deltaTime)
        {


            float posX = tweenFunction(f, startPos.x, goalPos.x - startPos.x, time);
            float posY = tweenFunction(f, startPos.y, goalPos.y - startPos.y, time);
            float posZ = tweenFunction(f, startPos.z, goalPos.z - startPos.z, time);

            float rotX = tweenFunction(f, startRot.x, goalRot.x - startRot.x, time);
            float rotY = tweenFunction(f, startRot.y, goalRot.y - startRot.y, time);
            float rotZ = tweenFunction(f, startRot.z, goalRot.z - startRot.z, time);

            Vector3 newPos = new Vector3(posX, posY, posZ);
            Vector3 newRot = new Vector3(rotX, rotY, rotZ);
            this.transform.localPosition = newPos;
            this.transform.localEulerAngles = newRot;
            yield return null;
        }
        this.transform.localPosition = goalPos;
        this.transform.localEulerAngles = goalRot;
    }

    private float tweenFunction(float t, float b, float c, float d)
    {
        return Tween.EaseInOutCubic(t, b, c, d);
        //return Tween.EaseOutElastic(t, b, c, d);
    }
}
