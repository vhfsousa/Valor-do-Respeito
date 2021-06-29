using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChapterSystem : MonoBehaviour
{
    [SerializeField] private int chapterNumber;
    [SerializeField] private Button capituloUm;
    [SerializeField] private Button capituloDois;
    [SerializeField] private Button capituloTres;

    void Start()
    {
        chapterNumber = PlayerPrefs.GetInt("ChapterNumber");
    }

    void Update()
    {
        if(chapterNumber == 1){
            capituloUm.interactable = true;
        }

        if(chapterNumber == 2){
            capituloUm.interactable = true;
            capituloDois.interactable = true;
        }

        if(chapterNumber == 3){
            capituloUm.interactable = true;
            capituloDois.interactable = true;
            capituloTres.interactable = true;
        }
    }
}