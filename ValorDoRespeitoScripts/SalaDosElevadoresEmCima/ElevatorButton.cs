using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ElevatorButton : MonoBehaviour
{
    [SerializeField] private GameObject fadeOut;
    [SerializeField] private Image botao;
    [SerializeField] private Sprite botaoApertado;
    [SerializeField] private AudioSource botaoSom;
    [SerializeField] private AudioClip somElevador;

    public void isPressed (){
        botaoSom.PlayOneShot(somElevador);
        botao.sprite = botaoApertado;
        fadeOut.SetActive(true);
    }
}