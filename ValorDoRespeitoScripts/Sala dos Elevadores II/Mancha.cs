using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mancha : MonoBehaviour
{
    [SerializeField] private Image manchaChao;
    [SerializeField] private Sprite manchaInteira;
    [SerializeField] private Sprite manchaSumindo;
    [SerializeField] private Sprite quaseSemMancha;
    [SerializeField] private GameObject borrifada;
    [SerializeField] private int estadoMancha;
    [SerializeField] private GameObject contadorPontuacao;
    [SerializeField] private GameObject mancha;
    

    void Start()
    {
        estadoMancha = 3;
    }

    void Update()
    {
        if(estadoMancha == 3){
            manchaChao.sprite = manchaInteira;
        }
        if(estadoMancha == 2){
            manchaChao.sprite = manchaSumindo;
        }
        if(estadoMancha == 1){
            manchaChao.sprite = quaseSemMancha;
        }
        else if (estadoMancha == 0){
            manchaChao.gameObject.SetActive(false);
            contadorPontuacao.gameObject.GetComponent<PointsCounter>().score ++;
        }
        
        TirarMancha();
    }

    public void OnTriggerEnter2D(Collider2D col){
        if(col.tag == "Borrifada"){
            borrifada.SetActive(false);
            estadoMancha --;
        }
    }

    public void TirarMancha()
    {
        if(contadorPontuacao.GetComponent<PointsCounter>().score == 5)
        {
            mancha.SetActive(false);
        }
    }
}