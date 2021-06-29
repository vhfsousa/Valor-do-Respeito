using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Advertising : MonoBehaviour
{
    [SerializeField] private Image email;
    [SerializeField] private Sprite emailVirusFree;
    [SerializeField] private Sprite emailWithVirus;
    [SerializeField] private float tempoPropagandaAparecendo;
    [SerializeField] private GameObject propagandasAbertas;
    [SerializeField] private GameObject botaoAceitar;
    [SerializeField] private AudioSource audioVirus;
    [SerializeField] private AudioClip virus;
    [SerializeField] private AudioClip receberMail;
    private bool somVirus;

    void Start()
    {
        somVirus = true;
        email.sprite = emailVirusFree;
        audioVirus.PlayOneShot(receberMail);
    }

    void Update()
    {
        Invoke("WithVirus", tempoPropagandaAparecendo);
        Invoke("VirusOpened", tempoPropagandaAparecendo + 3);
    }

    public void WithVirus(){
        email.sprite = emailWithVirus;
        if(somVirus == true)
        {
            Handheld.Vibrate ();
            audioVirus.PlayOneShot(virus);
            somVirus = false;
        }
    }

    public void VirusOpened(){
        propagandasAbertas.SetActive(true);
        botaoAceitar.SetActive(true);
    }
}