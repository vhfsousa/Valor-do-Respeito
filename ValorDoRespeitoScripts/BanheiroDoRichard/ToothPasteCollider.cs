using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToothPasteCollider : MonoBehaviour
{
    [SerializeField] private GameObject pasta;
    
    [SerializeField] private Transform tuboPasta;

    void Start()
    {
        
    }
    
    void OnTriggerEnter2D(Collider2D col){
        if(col.gameObject.CompareTag("PastaDeDente")){
            pasta.SetActive(false);
            pasta.transform.position = tuboPasta.transform.position;
        }
    }
}