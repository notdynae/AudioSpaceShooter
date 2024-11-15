﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXManager : MonoBehaviour
{
    public AudioClip playerShoot;
    public AudioClip asteroidExplosion;
    public AudioClip playerDamage;
    public AudioClip playerExplosion;
    public AudioClip BgMusicGameplay;
    public AudioClip BgMusicTitleScreen;
    public AudioClip ButtonHover;
    public AudioClip ButtonClick;

    private AudioSource SFXaudioSource;

    private AudioSource BgMusicAudioSource;

    public void Awake()
    {
        SFXaudioSource = GetComponent<AudioSource>();
        //GameObject child = this.transform.Find("BgMusic").gameObject;
        BgMusicAudioSource = gameObject.transform.Find("BgMusic").gameObject.GetComponent<AudioSource>();
        
        //BgMusicAudioSource.GetComponent<AudioSource>().Play();       
    }



    //called in the PlayerController Script
    public void PlayerShoot()
    {
        SFXaudioSource.pitch = Random.Range(0.9f, 1.1f);
        SFXaudioSource.PlayOneShot(playerShoot, 0.5f);
    }

    //called in the PlayerController Script
    public void PlayerDamage() {
        SFXaudioSource.pitch = Random.Range(0.85f, 1.15f);
        SFXaudioSource.PlayOneShot(playerDamage, 0.45f);
    }

    //called in the PlayerController Script
    public void PlayerExplosion()
    {
        SFXaudioSource.PlayOneShot(playerExplosion, 0.9f);
    }

    //called in the AsteroidDestroy script
    public void AsteroidExplosion()
    {
        SFXaudioSource.pitch = Random.Range(0.85f, 1.15f);
        SFXaudioSource.PlayOneShot(asteroidExplosion, 0.75f);
    }

    
    public void BGMusicMainMenu()
    {
        SFXaudioSource.pitch = 1.0f;
        BgMusicAudioSource.clip = BgMusicTitleScreen;
        BgMusicAudioSource.volume = 0.25f;
        BgMusicAudioSource.Play();
    }

    public void BGMusicGameplay()
    {
        BgMusicAudioSource.clip = BgMusicGameplay;
        BgMusicAudioSource.volume = 0.45f;
        BgMusicAudioSource.Play();
    }

    public void BGMusicPitch(float pitch) {
        BgMusicAudioSource.pitch = pitch;
    }
    
    public void BGMusicStop() {
        SFXaudioSource.pitch = 1.0f;
        BgMusicAudioSource.Stop();
    }
    public void BGMusicPause() {
        BgMusicAudioSource.Pause();
    }
    public void BGMusicResume() {
        BgMusicAudioSource.UnPause();
    }
}
