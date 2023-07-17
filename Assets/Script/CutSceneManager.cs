using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CutSceneManager : MonoBehaviour
{
    public float timer;
    public string nameScene;
    void Start()
    {
              

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 65.08f)
        {
            SceneManager.LoadScene(nameScene);           
        }

        MusicThemeOff();
    }

    public void MusicThemeOff()
    {
        GameObject musicTheme = GameObject.FindGameObjectWithTag("MusicController");
        musicTheme.SetActive(false);
    }
}
