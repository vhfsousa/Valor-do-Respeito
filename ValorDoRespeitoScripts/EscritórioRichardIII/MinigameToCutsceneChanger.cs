using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinigameToCutsceneChanger : MonoBehaviour
{
    [SerializeField] private GameObject fadeOut;
    [SerializeField] private GameObject minigame;

    void Update()
    {
        if(minigame.gameObject.GetComponent<PointsCounter>().puzzleAccept == true){
            fadeOut.SetActive(true);
        }
    }
}