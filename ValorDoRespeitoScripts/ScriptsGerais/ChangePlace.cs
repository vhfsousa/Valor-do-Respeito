using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePlace : MonoBehaviour
{
    [SerializeField] private GameObject fadeOut;
    [SerializeField] private GameObject puzzle;
    private bool needPass;
    private bool canPass;
    
    void Update()
    {
        Pass();
    }

    public void OnTriggerEnter2D(Collider2D col){
        if(col.gameObject.CompareTag("Player")){
            canPass = true;
        }
    }
    public void OnTriggerExit2D(Collider2D col){
        if(col.gameObject.CompareTag("Player")){
            canPass = false;
        }
    }

    public void Pass()
    {
        if(needPass == true)
        {
            if(needPass == true && canPass == true)
            {
                if(puzzle.GetComponent<PointsCounter>().puzzleAccept == true)
                {
                    fadeOut.SetActive(true);
                }
            }
        }
        else if(needPass == false)
        {
            if(canPass == true)
            {
                fadeOut.SetActive(true);
            }
        }
    }
}