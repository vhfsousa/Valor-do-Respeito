using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseJournal : MonoBehaviour
{
    [SerializeField] private GameObject jornal;
    public void OnClick(){
        jornal.gameObject.SetActive(false);
    }
}