using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interagir : MonoBehaviour
{
    public GameObject tela;
    public Sprite botaoSprite;

    void Start()
    {
        tela.SetActive(false);
    }
}