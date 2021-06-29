using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Borrifador : MonoBehaviour
{
    [SerializeField] private bool isDropped;
    [SerializeField] private Image borrifador;
    [SerializeField] private Sprite borrifadorSemApertar;
    [SerializeField] private Sprite borrifadorApertado;
    [SerializeField] private GameObject borrifada;
    [SerializeField] private AudioSource audioBorrifador;
    [SerializeField] private AudioClip somBorrifador;
    [SerializeField] private ParticleSystem spray;

    void Start()
    {
        isDropped = false;
        borrifada.SetActive(false);
        spray.gameObject.SetActive(false);
    }

    void Update()
    {
        if(isDropped == false){
            borrifador.sprite = borrifadorSemApertar;
        }
        else if (isDropped == true){
            borrifador.sprite = borrifadorApertado;
        }
    }

    public void OnDrag()
    {
        transform.position = Input.mousePosition;
        isDropped = false;
        borrifada.SetActive(false);
        spray.gameObject.SetActive(false);
    }

    public void OnDrop()
    {
        isDropped = true;
        borrifada.SetActive(true);
        audioBorrifador.PlayOneShot(somBorrifador);
        spray.gameObject.SetActive(true);
    }
}