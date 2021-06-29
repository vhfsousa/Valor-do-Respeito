using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuzzleProdutos : MonoBehaviour{
    [SerializeField] private Image produto;
    [SerializeField] private Image check;
    [SerializeField] private bool isChave;
    public bool eletrica;
    [SerializeField] private GameObject contadorPontuacao;
    [SerializeField] private AudioSource produtos;
    [SerializeField] private AudioClip arrastar;
    private bool pegou;

void Start()
{
    check.gameObject.SetActive(false);
    pegou = true;
}

public void OnDrag()
{
    transform.position = Input.mousePosition;
    if(pegou == true)
    {
        produtos.PlayOneShot(arrastar);
        pegou = false;
    }
}

public void OnClick()
{
    produto.gameObject.SetActive(false);
    produto.raycastTarget = false;
    check.gameObject.SetActive(true);
    contadorPontuacao.gameObject.GetComponent<PointsCounter>().score ++;
    produtos.PlayOneShot(arrastar);
    if(isChave == true)
    {
        eletrica = true;
    }
}
}