using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance = null;
    public List<AudioSource> audioSources = new List<AudioSource>();
    public AudioSource SfxSource;
    public int CurrentPist = -1;
    public float time = 0;


    public AudioClip etSound;

    void Awake()
    {
        if (Instance == null)
            Instance = this;
        else if (Instance != this)
        {
            Destroy(Instance.gameObject);
            Instance = this;
        }
    }

    public void Start()
    {
        Mute();
    }

    void Update()
    {
        time = audioSources[0].time;
        if (audioSources[0].time >= 83.0f)
        {
            for (int j = 0; j < audioSources.Count; j++)
                audioSources[j].Play();
        }
    }
    public void SetPiste(int p, float time)
    {
        if (p != CurrentPist)
        {
            StartCoroutine(SetPisteIn(p, time));
            CurrentPist = p;
        }
    }

    public void FadeOut(float time)
    {
        StartCoroutine(SetPisteIn(-1, time));
    }


    public IEnumerator SetPisteIn(int p, float time)
    {
        float[] volumes = new float[audioSources.Count];

        for (int i = 0; i < audioSources.Count; i++)
        {
            volumes[i] = audioSources[i].volume;
        }

        for (float f = 0; f < time; f += Time.deltaTime)
        {
            for (int i = 0; i < audioSources.Count; i++)
            {
                if (i == p)
                {
                    audioSources[i].volume = f / time;
                }
                else if (volumes[i] != 0)
                {
                    audioSources[i].volume = 1 - f / time;
                }
            }

            yield return null;
        }

        for (int i = 0; i < audioSources.Count; i++)
        {
            if (i == p)
                audioSources[i].volume = 1.0f;
            else if (volumes[i] != 0)
                audioSources[i].volume = 0;
        }
    }

    public void LowerSound(float goalVolume, float time)
    {
        StopAllCoroutines();
        StartCoroutine(LowerSoundTo(goalVolume, time));
    }

    public IEnumerator LowerSoundTo(float goal, float time)
    {
        float startVolume = audioSources[CurrentPist].volume;
        float goalVolume = goal;
        for (float f = 0; f < time; f += Time.deltaTime)
        {
            audioSources[CurrentPist].volume =  startVolume- ((startVolume - goalVolume) * f / time);
            yield return null;
        }
        audioSources[CurrentPist].volume = goal;

    }

    public void Mute()
    {
        for (int i = 0; i < audioSources.Count; i++)
        {
            audioSources[i].volume = 0;
        }
    }

    public void PlaySfx(AudioClip ac)
    {
        SfxSource.PlayOneShot(ac);
    }

    public void PlayetSound()
    {
        SfxSource.PlayOneShot(etSound);
    }
}