using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContadorTutorial : MonoBehaviour
{
public int score;
public bool puzzleAccept;
public int objetivo;
[SerializeField] private GameObject puzzle;
[SerializeField] private GameObject check;
[SerializeField] private Button botao;
[SerializeField] private Image comprado;
[SerializeField] private GameObject balao;

void Start()
{
    botao.interactable = false;
    comprado.gameObject.SetActive(false);
}

public void Update()
{
    if(score == objetivo)
    {
        botao.interactable = true;
        puzzleAccept = true;
    }
}

public void OnClick()
{
    if(score == objetivo)
    {
        comprado.gameObject.SetActive(true);
        Invoke("Finalizar" , 3);
        balao.GetComponent<BalaoDeFala>().aparece = false;
    }
}

public void Finalizar()
{
    puzzle.SetActive(false);
    check.SetActive(true);
}
}