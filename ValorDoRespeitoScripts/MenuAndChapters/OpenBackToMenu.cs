using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenBackToMenu : MonoBehaviour
{
    [SerializeField] private GameObject confirmationObject;

    public void OnClick(){
        confirmationObject.SetActive(true);
    }
}