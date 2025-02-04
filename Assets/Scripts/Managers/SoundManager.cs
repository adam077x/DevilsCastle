﻿using System;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance;

    public Sound[] sounds;

    void Awake()
    {
        foreach(Sound s in sounds) 
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
        }

        instance = FindObjectOfType<SoundManager>();
    }

    public void Play(string name) 
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        s.source.Play();
    }
}
