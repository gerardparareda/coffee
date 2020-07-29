using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Marble : MonoBehaviour
{

    public float generalVolume;
    AudioSource beanAudioData0;
    AudioSource beanAudioData1;
    AudioSource woodAudioData0;
    AudioSource woodAudioData1;
    AudioSource glassAudioData0;

    // Start is called before the first frame update
    void Start()
    {
        AudioSource[] audios = GetComponents<AudioSource>();
        beanAudioData0 = audios[0];
        beanAudioData1 = audios[1];
        woodAudioData0 = audios[2];
        woodAudioData1 = audios[3];
        glassAudioData0 = audios[4];
        generalVolume = GameManager._Instance.volumeLevel;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        PlayCollisionAudio(collision.gameObject.tag, collision.relativeVelocity.magnitude);
    }

    void PlayCollisionAudio(string tag, float magnitude)
    {

        switch (tag)
        {
            case "Bean":
                switch (Random.Range(0, 2))
                {
                    case 0:
                        beanAudioData0.volume = (magnitude / 30.0f) * generalVolume;
                        beanAudioData0.Play();
                        break;
                    case 1:
                        beanAudioData1.volume = (magnitude / 30.0f) * generalVolume;
                        beanAudioData1.Play();
                        break;
                }
                break;
            case "Wood":
                switch (Random.Range(0, 1))
                {
                    case 0:
                        woodAudioData0.volume = (magnitude / 30.0f) * generalVolume;
                        woodAudioData0.Play();
                        break;
                    case 1:
                        woodAudioData1.volume = (magnitude / 30.0f) * generalVolume;
                        woodAudioData1.Play();
                        break;
                }
                break;
            case "Glass":
                switch (Random.Range(0, 1))
                {
                    case 0:
                        glassAudioData0.volume = (magnitude / 30.0f) * generalVolume;
                        glassAudioData0.Play();
                        break;
                    case 1:
                        glassAudioData0.volume = (magnitude / 30.0f) * generalVolume;
                        glassAudioData0.Play();
                        break;
                }
                break;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
