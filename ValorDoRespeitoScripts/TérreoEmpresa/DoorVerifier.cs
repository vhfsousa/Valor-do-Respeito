using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorVerifier : MonoBehaviour
{
    [SerializeField] private GameObject fadeOut;
    public int doorVerification;
    public bool isOpened;

    void Start()
    {
        doorVerification = 0;
        isOpened = false;
    }

    void Update()
    {
        if(doorVerification == 2 && isOpened == false){
            isOpened = true;
            fadeOut.SetActive(true);
        }
    }
}