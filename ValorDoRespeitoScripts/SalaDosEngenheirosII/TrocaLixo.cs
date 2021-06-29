using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrocaLixo : MonoBehaviour
{
    [SerializeField] private GameObject contadorPontuacao;
    [SerializeField] private GameObject puzzle;
    
    void Update()
    {
        if(contadorPontuacao.gameObject.GetComponent<PointsCounter>().puzzleAccept == true)
        {
            puzzle.SetActive(false);
        }
    }
}