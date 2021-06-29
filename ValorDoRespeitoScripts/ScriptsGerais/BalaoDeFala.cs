using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalaoDeFala : MonoBehaviour
{
    [SerializeField] private GameObject pensamento;
    [SerializeField] private float tempoAparece;
    [SerializeField] private float tempoSome;
    public bool aparece;
    
    void Start()
    {
        pensamento.SetActive(false);
        aparece = true;
    }

    void Update()
    {
        BalaoTemp();
    }

    public void BalaoTemp()
    {
        if(Time.timeSinceLevelLoad >= tempoAparece && aparece == true)
            pensamento.SetActive(true);
        
        if(Time.timeSinceLevelLoad >= tempoSome)
            pensamento.SetActive(false);
    }
}