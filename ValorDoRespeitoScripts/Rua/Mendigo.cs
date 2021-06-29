using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mendigo : MonoBehaviour
{
    [SerializeField] private GameObject fadeOut;

    void Update()
    {
        fadeOut.SetActive(true);
    }
}