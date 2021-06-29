using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LockedDoor : MonoBehaviour
{
    [SerializeField] private GameObject fadeOut;
    [SerializeField] private Image macaneta;
    [SerializeField] private Sprite destrancada;
    [SerializeField] private Sprite alavancaAbaixada;
    [SerializeField] private AudioSource somPorta;
    [SerializeField] private AudioClip portaAbrindo;
    [SerializeField] private AudioClip portaTrancada;
    [SerializeField] private Button tranca;
    [SerializeField] private bool unlocked;
    
    public void Unlock()
    {
        macaneta.sprite = destrancada;
        tranca.interactable = false;
        unlocked = true;
    }
    
    public void OpenDoor()
    {
        if(unlocked == true)
        {
            macaneta.sprite = alavancaAbaixada;
            somPorta.PlayOneShot(portaAbrindo);
            macaneta.raycastTarget = false;
            fadeOut.SetActive(true);
        }
        else if(unlocked == false)
        {
            Handheld.Vibrate();
            somPorta.PlayOneShot(portaTrancada);
        }
    }
}