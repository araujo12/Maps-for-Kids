using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip vClip, xClip;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MusicThemeOff();
    }



    public void MusicThemeOff()
    {
        GameObject musicTheme = GameObject.FindGameObjectWithTag("MusicController");
        musicTheme.SetActive(false);
    }

    public void CorrectAnswer()
    {
        audioSource.PlayOneShot(vClip);
    }

    public void WrongAnswer()
    {
        audioSource.PlayOneShot(xClip);
    }
}
