using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMaster : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip buttonOn, buttonOff, startGameSound, closeWindow;
    public string nameScene;
    private float timerLoadScene;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    private IEnumerator TimeSceneOpen()
    {
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene(nameScene);
    }

    public void LoadScene(string name)
    {
        nameScene = name;
        StartCoroutine("TimeSceneOpen");
    }

    public void ButttonOn()
    {
        audioSource.PlayOneShot(buttonOn);
    }

    public void ButttonOff()
    {
        audioSource.PlayOneShot(buttonOff);
    }

    public void StatGameSound()
    {
        audioSource.PlayOneShot(startGameSound);
    }
    
    public void CloseWindow()
    {
        audioSource.PlayOneShot(closeWindow);
    }

    public void CloseApp()
    {
        Application.Quit();
    }
}
