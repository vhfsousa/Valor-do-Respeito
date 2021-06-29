using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackButtonAfterConfirmation : MonoBehaviour
{
    [SerializeField] GameObject aviso;
    
    public void DisableWarning(){
        aviso.SetActive(false);
    }
}