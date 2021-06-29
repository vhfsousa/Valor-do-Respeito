using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cutscene1 : MonoBehaviour
{
    [SerializeField] private GameObject fadeOut;
    [SerializeField] private AudioSource somCutscene;
    [SerializeField] private Image imagem1;
    [SerializeField] private Image imagem2;
    [SerializeField] private Image imagem3;
    [SerializeField] private Image imagem4;
    [SerializeField] private Image imagem5;
    [SerializeField] private Image imagem6;
    [SerializeField] private Image imagem7;
    [SerializeField] private Image imagem8;
    [SerializeField] private Image imagem9;
    [SerializeField] private Image imagem10;
    [SerializeField] private Image imagem11;
    [SerializeField] private Image imagem12;
    [SerializeField] private Image imagem13;
    [SerializeField] private Image imagem14;
    [SerializeField] private Image imagem15;
    [SerializeField] private Image imagem16;
    [SerializeField] private Image imagem17;
    [SerializeField] private Image imagem18;
    [SerializeField] private AudioClip cena1;
    [SerializeField] private AudioClip cena2;
    [SerializeField] private AudioClip cena3;
    [SerializeField] private AudioClip cena4;
    [SerializeField] private AudioClip cena5;
    [SerializeField] private AudioClip cena6;
    [SerializeField] private AudioClip cena7;
    [SerializeField] private AudioClip cena8;
    [SerializeField] private AudioClip cena9;
    [SerializeField] private AudioClip cena10;
    [SerializeField] private AudioClip cena11;
    [SerializeField] private AudioClip cena12;
    [SerializeField] private AudioClip cena13;
    [SerializeField] private AudioClip cena14;
    [SerializeField] private AudioClip cena15;
    [SerializeField] private AudioClip cena16;
    [SerializeField] private AudioClip cena17;
    [SerializeField] private AudioClip cena18;

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
        imagem1.gameObject.SetActive(false);
        imagem2.gameObject.SetActive(false);
        imagem3.gameObject.SetActive(false);
        imagem4.gameObject.SetActive(false);
        imagem5.gameObject.SetActive(true);
        Invoke("AtivarCena6",2.5f);
    }

    void AtivarCena6(){
        somCutscene.PlayOneShot(cena6);
        imagem6.gameObject.SetActive(true);
        Invoke("AtivarCena7", 2.5f);
    }

    void AtivarCena7(){
        somCutscene.PlayOneShot(cena7);
        imagem7.gameObject.SetActive(true);
        Invoke("AtivarCena8", 2.5f);
    }

    void AtivarCena8(){
        somCutscene.PlayOneShot(cena8);
        imagem8.gameObject.SetActive(true);
        Invoke("AtivarCena9", 2.5f);
    }

    void AtivarCena9(){
        somCutscene.PlayOneShot(cena9);
        imagem5.gameObject.SetActive(false);
        imagem6.gameObject.SetActive(false);
        imagem7.gameObject.SetActive(false);
        imagem8.gameObject.SetActive(false);
        imagem9.gameObject.SetActive(true);
        Invoke("AtivarCena10",2.5f);
    }

    void AtivarCena10(){
        somCutscene.PlayOneShot(cena10);
        imagem10.gameObject.SetActive(true);
        Invoke("AtivarCena11", 2.5f);
    }

    void AtivarCena11(){
        somCutscene.PlayOneShot(cena11);
        imagem11.gameObject.SetActive(true);
        Invoke("AtivarCena12", 2.5f);
    }

    void AtivarCena12(){
        somCutscene.PlayOneShot(cena12);
        imagem12.gameObject.SetActive(true);
        Invoke("AtivarCena13", 2.5f);
    }

    void AtivarCena13(){
        somCutscene.PlayOneShot(cena13);
        imagem9.gameObject.SetActive(false);
        imagem10.gameObject.SetActive(false);
        imagem11.gameObject.SetActive(false);
        imagem12.gameObject.SetActive(false);
        imagem13.gameObject.SetActive(true);
        Invoke("AtivarCena14", 2.5f);
    }

    void AtivarCena14(){
        somCutscene.PlayOneShot(cena14);
        imagem14.gameObject.SetActive(true);
        Invoke("AtivarCena15", 2.5f);
    }

    void AtivarCena15(){
        somCutscene.PlayOneShot(cena15);
        imagem15.gameObject.SetActive(true);
        Invoke("AtivarCena16", 2.5f);
    }

    void AtivarCena16(){
        somCutscene.PlayOneShot(cena16);
        imagem16.gameObject.SetActive(true);
        Invoke("AtivarCena17", 2.5f);
    }

    void AtivarCena17(){
        somCutscene.PlayOneShot(cena17);
        imagem13.gameObject.SetActive(false);
        imagem14.gameObject.SetActive(false);
        imagem15.gameObject.SetActive(false);
        imagem16.gameObject.SetActive(false);
        imagem17.gameObject.SetActive(true);
        Invoke("AtivarCena18", 2.5f);
    }

    void AtivarCena18(){
        somCutscene.PlayOneShot(cena18);
        imagem18.gameObject.SetActive(true);
        Invoke("TrocarCena", 2.5f);
    }

    void TrocarCena(){
        fadeOut.SetActive(true);
    }
}