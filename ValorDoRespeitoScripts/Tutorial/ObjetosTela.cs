using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjetosTela : MonoBehaviour
{
    [SerializeField] private Image ajuda;
    [SerializeField] private Sprite aberta;
    [SerializeField] private Sprite fechada;
    [SerializeField] private Image zap;
    private bool aberto;

    public void Abrir()
    {
        if(aberto == false)
        {
            ajuda.sprite = aberta;
            ajuda.SetNativeSize();
            aberto = true;
            zap.gameObject.SetActive(false);
        }
        else if(aberto == true)
        {
            ajuda.sprite = fechada;
            ajuda.SetNativeSize();
            aberto = false;
        }
    }
}