using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutscenePassagemDeTempo : MonoBehaviour
{
    [SerializeField] private GameObject fadeOut;
    
    void Start()
    {
        Invoke("FadeOut", 2);
    }

    void FadeOut(){
        fadeOut.SetActive(true);
    }
}