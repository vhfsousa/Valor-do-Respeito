using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CaixaEletrica : MonoBehaviour
{
    [SerializeField] private Image caixaEletrica;
    [SerializeField] private Sprite destrancada;
    [SerializeField] private Sprite aberta;
    [SerializeField] private Button tranca;
    private bool unlocked;
    [SerializeField] private Image vermelho;
    [SerializeField] private Image verde;
    [SerializeField] private Image azul;
    [SerializeField] private Image botao;
    [SerializeField] private Image slotVermelho;
    [SerializeField] private Image slotVerde;
    [SerializeField] private Image slotAzul;
    [SerializeField] private Image bolinha;
    [SerializeField] private GameObject chave;
    [SerializeField] private AudioSource eletrica;
    [SerializeField] private AudioClip abrir;
    [SerializeField] private AudioClip trancada;
    [SerializeField] private AudioClip portinhaAberta;
    [SerializeField] private Text textoFora;
    [SerializeField] private Text textoDentro;

    void Start()
    {
        vermelho.gameObject.SetActive(false);
        verde.gameObject.SetActive(false);
        azul.gameObject.SetActive(false);
        botao.gameObject.SetActive(false);
        slotAzul.gameObject.SetActive(false);
        slotVerde.gameObject.SetActive(false);
        slotVermelho.gameObject.SetActive(false);
        bolinha.gameObject.SetActive(false);
        textoDentro.gameObject.SetActive(false);
    }

    public void Unlock()
    {
        if(chave.GetComponent<PuzzleProdutos>().eletrica == true)
        {
            caixaEletrica.sprite = destrancada;
            tranca.interactable = false;
            unlocked = true;
            eletrica.PlayOneShot(portinhaAberta);
        }
        else if(chave.GetComponent<PuzzleProdutos>().eletrica == false)
        {
            Handheld.Vibrate ();
            eletrica.PlayOneShot(trancada);
        }
    }

    public void OpenDoor()
    {
        if(unlocked == true)
        {
            caixaEletrica.sprite = aberta;
            caixaEletrica.raycastTarget = false;
            vermelho.gameObject.SetActive(true);
            verde.gameObject.SetActive(true);
            azul.gameObject.SetActive(true);
            botao.gameObject.SetActive(true);
            slotAzul.gameObject.SetActive(true);
            slotVerde.gameObject.SetActive(true);
            slotVermelho.gameObject.SetActive(true);
            bolinha.gameObject.SetActive(true);
            textoDentro.gameObject.SetActive(true);
            textoFora.gameObject.SetActive(false);
            eletrica.PlayOneShot(abrir);
        }
        else if(unlocked == false)
        {
            Debug.Log("Trancada");
        }
    }
}
