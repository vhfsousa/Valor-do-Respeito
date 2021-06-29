using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuzzlePiece : MonoBehaviour{

    [SerializeField] private Image piece;
    [SerializeField] private Image slot;
    [SerializeField] private GameObject contadorPontuacao;
    [SerializeField] private AudioSource peca;
    [SerializeField] private AudioClip pecaEncaixando;
    [SerializeField] private ParticleSystem particula;
    [SerializeField] private Text texto;
    
    public void OnDrag()
    {
        transform.position = Input.mousePosition;
    }
    public void OnDrop()
    {
        if(slot.GetComponent<PuzzleSlot>().canDrop == true)
        {
            piece.raycastTarget = false;
            piece.transform.position = slot.transform.position;
            peca.PlayOneShot(pecaEncaixando);
            contadorPontuacao.gameObject.GetComponent<PointsCounter>().score ++;
            texto.text = contadorPontuacao.GetComponent<PointsCounter>().score.ToString();
            particula.gameObject.SetActive(true);
        }
    }
}