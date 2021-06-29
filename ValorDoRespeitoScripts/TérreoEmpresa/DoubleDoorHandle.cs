using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoubleDoorHandle : MonoBehaviour
{
    [SerializeField] private Image macaneta;
    [SerializeField] private Sprite alavancaLevantada;
    [SerializeField] private Sprite alavancaAbaixada;
    [SerializeField] private AudioSource somPorta;
    [SerializeField] private AudioClip portaAbrindo;
    [SerializeField] private GameObject verificadorPorta;

    public void OpenDoor()
    {
        verificadorPorta.gameObject.GetComponent<DoorVerifier>().doorVerification +=1;
        macaneta.sprite  = alavancaAbaixada;
        somPorta.PlayOneShot(portaAbrindo);
        macaneta.raycastTarget = false;
    }
}