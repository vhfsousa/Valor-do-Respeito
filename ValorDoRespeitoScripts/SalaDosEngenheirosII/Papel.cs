using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Papel : MonoBehaviour
{
[SerializeField] private Image papel;
[SerializeField] private Sprite amassado1;
[SerializeField] private Sprite amassado2;
[SerializeField] private Sprite amassado3;
[SerializeField] private Sprite amassado4;
[SerializeField] private Sprite amassado5;
[SerializeField] private bool canDrop;
[SerializeField] private bool canDrag;
[SerializeField] private int estado;
[SerializeField] private GameObject contadorPontuacao;
[SerializeField] private AudioSource papelAmassando;
[SerializeField] private AudioClip sendoAmassado;

void Start()
{
    estado = 6;
}

void Update()
{
}

public void OnClick()
{
    estado --;
    if(estado == 5)
    {
        papel.sprite = amassado1;
        papel.SetNativeSize();
        papelAmassando.PlayOneShot(sendoAmassado);
    }
    if(estado == 4)
    {
        papel.sprite = amassado2;
        papel.SetNativeSize();
        papelAmassando.PlayOneShot(sendoAmassado);
    }
    if(estado == 3)
    {
        papel.sprite = amassado3;
        papel.SetNativeSize();
        papelAmassando.PlayOneShot(sendoAmassado);
    }
    if(estado == 2)
    {
        papel.sprite = amassado4;
        papel.SetNativeSize();
        papelAmassando.PlayOneShot(sendoAmassado);
    }
    if(estado == 1)
    {
        papel.sprite = amassado5;
        papel.SetNativeSize();
        papelAmassando.PlayOneShot(sendoAmassado);
        canDrag = true;
    }
}

public void OnDrag()
{
    if(canDrag == true)
    {
        transform.position = Input.mousePosition;
    }
}

public void OnDrop()
{
    if(canDrop == true)
        {
            papel.gameObject.SetActive(false);
            papel.raycastTarget = false;
            contadorPontuacao.gameObject.GetComponent<PointsCounter>().score ++;
            papelAmassando.PlayOneShot(sendoAmassado);
        }
}

public void OnTriggerEnter2D(Collider2D col)
{
    if(col.tag == "Lixo")
    {
        canDrop = true;
    }
}
}