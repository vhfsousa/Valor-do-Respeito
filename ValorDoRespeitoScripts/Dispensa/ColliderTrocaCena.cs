using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderTrocaCena : MonoBehaviour
{
    [SerializeField] private GameObject fadeOut;
    [SerializeField] private GameObject puzzle;
    
    public void OnTriggerEnter2D(Collider2D col){
        if(col.gameObject.CompareTag("Player") && puzzle.GetComponent<PontuacaoEletrica>().puzzleAccept == true){
            fadeOut.SetActive(true);
        }
    }
}