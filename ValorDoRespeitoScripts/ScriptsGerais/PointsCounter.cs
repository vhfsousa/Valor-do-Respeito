using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointsCounter : MonoBehaviour
{
    public int score;
    public bool puzzleAccept;
    [SerializeField] private int objetivo;
    [SerializeField] private GameObject puzzle;
    [SerializeField] private GameObject check;
    [SerializeField] private GameObject balao;

    void Update()
    {
        if(score == objetivo)
        {
            puzzleAccept = true;
            puzzle.SetActive(false);
            check.gameObject.SetActive(true);
            balao.GetComponent<BalaoDeFala>().aparece = false;
        }
    }
}