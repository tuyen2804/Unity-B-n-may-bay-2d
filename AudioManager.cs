using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance { get; private set; }

    [SerializeField] private AudioClip introClip;
    [SerializeField] private AudioClip clickClip;
    [SerializeField] private AudioClip hitClip;
    private AudioSource fxMusic;
    private AudioSource introMusic;
    private AudioSource clickMusic;
    private AudioSource hitMusic;

    private void Awake()
    {
        if (Instance != null)
        {
            Debug.LogError("Only 1 AudioManager allowed to exist");
            Destroy(gameObject); // Destroy this duplicate AudioManager
            return;
        }
        Instance = this;

        // Create AudioSources and assign clips
        introMusic = gameObject.AddComponent<AudioSource>();
        introMusic.clip = introClip;

        clickMusic = gameObject.AddComponent<AudioSource>();
        clickMusic.clip = clickClip;

        hitMusic = gameObject.AddComponent<AudioSource>();
        hitMusic.clip = hitClip;

        fxMusic = gameObject.AddComponent<AudioSource>();
    }

    private void Start()
    {
        PlayIntroMusic();
    }

    public void PlayIntroMusic()
    {
        if (introMusic != null && !introMusic.isPlaying)
        {
            introMusic.Play();
        }
    }

    // Add methods for playing click and hit music if needed
    public void Click()
    {
        this.clickMusic.clip = this.clickClip;
        this.clickMusic.PlayOneShot(this.clickClip);
    }
    public void Hit()
    {
        this.hitMusic.clip = this.hitClip;
        this.hitMusic.PlayOneShot(this.hitClip);
    }
}
