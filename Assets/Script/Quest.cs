using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Quest : MonoBehaviour
{
    public GameObject questSC, questBTN, nextQuest;   
    public GameObject planetIMG;
    private ScroreScript scroreScript;
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NextQuest()
    {
        questSC.SetActive(true);
    }

    public void AnswerQuest()
    {
        questBTN.SetActive(false);
        questSC.SetActive(false );        
        planetIMG.GetComponent<Image>().enabled = true;
        nextQuest.SetActive(true);
        //scroreScript.ScorePointAdd()
        
        
    }
}
