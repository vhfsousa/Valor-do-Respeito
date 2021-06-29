using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToothPaste : MonoBehaviour
{
    private float delay;
    [SerializeField] private float tempoDelay;
    [SerializeField] private GameObject pasta;
    [SerializeField] private Image tuboPasta;
    [SerializeField] private Sprite pastaAmassada;
    [SerializeField] private Sprite pastaNormal;
    [SerializeField] private AudioSource somPasta;
    [SerializeField] private AudioClip somSair;

    void Start()
    {
        pasta.gameObject.SetActive(false);
    }

    void Update()
    {
        delay -= Time.deltaTime;

        if(delay <= 0){
            tuboPasta.sprite = pastaNormal;
        }
    }

    public void CairPasta(){
            if(delay <= 0){
                pasta.gameObject.SetActive(true);
                tuboPasta.sprite = pastaAmassada;
                delay = tempoDelay;
                somPasta.PlayOneShot(somSair);
        }
    }
}