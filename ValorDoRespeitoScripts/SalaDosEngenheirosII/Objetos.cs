using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Objetos : MonoBehaviour
{
[SerializeField] private bool canDrop;
[SerializeField] private Image objeto;
[SerializeField] private GameObject contadorPontuacao;
[SerializeField] private AudioClip lixo;
[SerializeField] private AudioSource som;

public void OnDrag()
{
    transform.position = Input.mousePosition;
}
public void OnDrop()
    {
        if(canDrop == true)
        {
            objeto.gameObject.SetActive(false);
            objeto.raycastTarget = false;
            contadorPontuacao.gameObject.GetComponent<PointsCounter>().score ++;
            som.PlayOneShot(lixo);
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