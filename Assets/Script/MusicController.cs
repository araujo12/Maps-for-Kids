using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicController : MonoBehaviour
{
    public static bool musicMenuoff;

    private void Awake()
    {
        musicMenuoff = false;
        GameObject[] musicControllers = GameObject.FindGameObjectsWithTag("MusicController");

        if(musicControllers.Length > 1 || musicMenuoff == true)
        {
            Destroy(this.gameObject);
        }
        else
        {
            DontDestroyOnLoad(this.gameObject);
        }
    }


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
