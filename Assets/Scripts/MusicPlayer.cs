using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class MusicPlayer : MonoBehaviour
{
    public static float MusicVolume = 0.5f;
    public AudioClip[] music;
    private AudioSource audioSource;

    int currentSong = 0;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.volume = MusicVolume;
    }

    private void Start()
    {
        PlayMusic();

    }
    void PlayMusic()
    {
        switch (currentSong)
        {
            case 0:
                audioSource.clip = music[0];
                break;
            case 1:
                audioSource.clip = music[1];
                break;
            case 2:
                audioSource.clip = music[2];
                break;
        }

        audioSource.Play();
    }

    private void Update()
    {
        if (!audioSource.isPlaying)
        {
            currentSong += 1;
            if (currentSong == 3) currentSong = 0;
            PlayMusic();
        }
    }
}