using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseAd : MonoBehaviour
{
    [SerializeField] private GameObject propaganda;
    [SerializeField] private AudioSource somClick;
    [SerializeField] private AudioClip click;

    public void CloseAdvertising(){
        propaganda.SetActive(false);
        somClick.PlayOneShot(click);
    }
}