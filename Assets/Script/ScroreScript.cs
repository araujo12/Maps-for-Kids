using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScroreScript : MonoBehaviour
{
    public float scorePoint;
    public Text scoreTXT;

    private float scoreBarAt, scoreBar = 0; 
    
    void Start()
    {
        scoreBarAt = scoreBar;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ScorePointAdd()
    {     
        scorePoint++;

        scoreTXT.text = scorePoint.ToString();
    }


}
