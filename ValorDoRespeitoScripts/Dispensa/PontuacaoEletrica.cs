using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PontuacaoEletrica : MonoBehaviour
{
    public int score;
    public bool puzzleAccept;
    [SerializeField] private int objetivo;
    [SerializeField] private Sprite acesa;
    [SerializeField] private Image button;
    [SerializeField] private GameObject puzzleEletrica;
    [SerializeField] private GameObject luz;
    [SerializeField] private GameObject check;
    private bool clicou;

void Update()
{
    if(score == objetivo)
    {
        button.sprite = acesa;
        puzzleAccept = true;
    }
    if(clicou == true)
    {
        puzzleEletrica.SetActive(false);
        check.SetActive(true);
    }
}

public void OnClick()
{
    if(score == objetivo)
    {
        puzzleEletrica.SetActive(false);
        luz.SetActive(true);
        check.SetActive(true);
        clicou = true;
    }
}
}