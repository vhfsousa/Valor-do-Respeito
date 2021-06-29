using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TeethBrushCollider : MonoBehaviour
{
    [SerializeField] private GameObject pasta;
    [SerializeField] private Vector2 originalPosition;
    [SerializeField] private GameObject contadorPontuacao;
    
    void Start()
    {
        originalPosition = new Vector2 (960, 885);
    }

    public void OnTriggerEnter2D(Collider2D col){
        if(col.gameObject.CompareTag("PastaDeDente")){
            pasta.SetActive(false);
            pasta.transform.position = originalPosition;
            contadorPontuacao.gameObject.GetComponent<PointsCounter>().score ++;
        }
    }
}