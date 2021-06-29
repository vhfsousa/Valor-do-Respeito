using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandyMinigameCollider : MonoBehaviour
{
    [SerializeField] private GameObject minigameBala;
    
    void OnTriggerEnter2D(Collider2D collider){
        if(collider.CompareTag("Player")){
            minigameBala.SetActive(true);
        }
    }
}