using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjetoCelular : MonoBehaviour
{
[SerializeField] private bool canDrop;
[SerializeField] private Image objeto;
[SerializeField] private Sprite celularDesligado;
[SerializeField] private Sprite celularLigado;
[SerializeField] private AudioSource celularSound;
[SerializeField] private AudioClip somVibrando;
private bool celularTremeu;

void Start(){
    celularTremeu = false;
}

public void OnDrag()
{
    transform.position = Input.mousePosition;
    objeto.sprite = celularLigado;
    if(celularTremeu == false){
        Handheld.Vibrate ();
        celularSound.PlayOneShot(somVibrando);
        celularTremeu = true;
    }

}
public void OnDrop()
    {
        Invoke("DesligarCelular", 2);
        celularTremeu = false;
    }

public void DesligarCelular(){
    objeto.sprite = celularDesligado;
}
}