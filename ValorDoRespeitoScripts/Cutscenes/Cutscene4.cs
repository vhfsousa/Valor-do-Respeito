using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cutscene4 : MonoBehaviour
{
[SerializeField] private GameObject fadeOut;
[SerializeField] private AudioSource somCutscene;
[SerializeField] private Image imagem1;
[SerializeField] private Image imagem2;
[SerializeField] private Image imagem3;
[SerializeField] private Image imagem4;
[SerializeField] private Image imagem5;
[SerializeField] private AudioClip cena1;
[SerializeField] private AudioClip cena2;
[SerializeField] private AudioClip cena3;
[SerializeField] private AudioClip cena4;
[SerializeField] private AudioClip cena5;

    void Start()
    {
        Invoke("AtivarCena1", 2.5f);
    }

    void AtivarCena1(){
        somCutscene.PlayOneShot(cena1);
        imagem1.gameObject.SetActive(true);
        Invoke("AtivarCena2", 2.5f);
    }
    void AtivarCena2(){
        somCutscene.PlayOneShot(cena2);
        imagem2.gameObject.SetActive(true);
        Invoke("AtivarCena3", 2.5f);
    }
    void AtivarCena3(){
        somCutscene.PlayOneShot(cena3);
        imagem3.gameObject.SetActive(true);
        Invoke("AtivarCena4", 2.5f);
    }
    void AtivarCena4(){
        somCutscene.PlayOneShot(cena4);
        imagem4.gameObject.SetActive(true);
        Invoke("AtivarCena5", 2.5f);
    }
    void AtivarCena5(){
        somCutscene.PlayOneShot(cena5);
        imagem5.gameObject.SetActive(true);
        Invoke("TrocarCena", 2.5f);
    }
    void TrocarCena(){
        fadeOut.SetActive(true);
    }
}