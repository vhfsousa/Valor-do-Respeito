using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuzzleEletrica : MonoBehaviour
{
    [SerializeField] private Image piece;
    [SerializeField] private GameObject volta;
    [SerializeField] private Image slot;
    [SerializeField] private GameObject col;
    [SerializeField] private GameObject pontuacao;
    [SerializeField] private float x, y;
    [SerializeField] private ParticleSystem particula;

public void OnDrag()
    {
        transform.position = Input.mousePosition;
    }

public void OnDrop()
    {
        if(slot.GetComponent<SlotEletrica>().canDrop == true && col.GetComponent<ColliderLuz>().entrou == true)
        {
            piece.raycastTarget = false;
            piece.transform.position = slot.transform.position;
            pontuacao.gameObject.GetComponent<PontuacaoEletrica>().score ++;
            particula.gameObject.SetActive(true);
        }
        if(slot.GetComponent<SlotEletrica>().canDrop == false || col.GetComponent<ColliderLuz>().entrou == false)
        {
            Handheld.Vibrate ();
            piece.rectTransform.position = volta.transform.position;
        }
    }
}