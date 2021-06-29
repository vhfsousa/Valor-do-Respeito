using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CutsceneComida : MonoBehaviour
{
    [SerializeField] private GameObject fadeOut;
    [SerializeField] private Image tacoDog;
    [SerializeField] private Sprite tacoDogComido;
    [SerializeField] private AudioSource somComida;
    [SerializeField] private AudioClip somHmm;

    public void TrocarCena(){
        somComida.PlayOneShot(somHmm);
        tacoDog.sprite = tacoDogComido;
        fadeOut.SetActive(true);
    }
}