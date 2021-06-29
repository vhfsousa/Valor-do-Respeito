using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Materiais : MonoBehaviour
{
    [SerializeField] private Image piece;
    [SerializeField] private GameObject volta;
    [SerializeField] private GameObject slot;
    [SerializeField] private GameObject contadorPontuacao;
    [SerializeField] private Text texto;
    [SerializeField] private float x, y;
    [SerializeField] private AudioSource som;
    [SerializeField] private AudioClip click;
    private bool toca;
    
    public void OnDrag()
    {
        transform.position = Input.mousePosition;
        if(toca == false)
        {
            som.PlayOneShot(click);
            toca = true;
        }
    }
    public void OnDrop()
    {
        if(slot.GetComponent<PuzzleSlot>().canDrop == true)
        {
            piece.gameObject.SetActive(false);
            contadorPontuacao.gameObject.GetComponent<ContadorTutorial>().score ++;
            texto.text = contadorPontuacao.GetComponent<ContadorTutorial>().score.ToString();
        }
        else if(slot.GetComponent<PuzzleSlot>().canDrop == false)
        {
            piece.rectTransform.position = volta.transform.position;
            toca = false;
        }
    }
}