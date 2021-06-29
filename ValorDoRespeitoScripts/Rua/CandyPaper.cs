using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CandyPaper : MonoBehaviour
{
    [SerializeField] private GameObject fadeOut;
    [SerializeField] private GameObject papelDaBala;
    [SerializeField] private Image papelBala;
    [SerializeField] private Sprite balaAmassada;
    [SerializeField] private GameObject minigameBala;
    [SerializeField] private AudioSource bala;
    [SerializeField] private AudioClip balaAmassando;
    [SerializeField] private bool playAmassado;

    void Start()
    {
        papelDaBala.gameObject.GetComponent<Rigidbody2D>().mass = 0;
        papelDaBala.gameObject.GetComponent<Rigidbody2D>().gravityScale = 0;
        playAmassado = true;
    }

    public void OnDrag(){
        if(Input.touchCount > 0)
        {
            papelBala.sprite = balaAmassada;
            papelDaBala.gameObject.GetComponent<Rigidbody2D>().mass = 10;
            papelDaBala.gameObject.GetComponent<Rigidbody2D>().gravityScale = 20;
            papelDaBala.gameObject.transform.position = Input.GetTouch(0).position;
            if(playAmassado == true){
                bala.PlayOneShot(balaAmassando);
                playAmassado = false;
            }
        }
    }

    void OnTriggerEnter2D(Collider2D col){
        if(col.gameObject.CompareTag("FloorCandyPaper")){
            minigameBala.SetActive(false);
            fadeOut.SetActive(true);
        }
    }
}