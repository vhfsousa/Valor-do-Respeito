using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderLuz : MonoBehaviour
{
    public bool entrou;

public void OnTriggerEnter2D(Collider2D col)
{
    if(col.tag == "Energia")
    {
        entrou = true;
    }
}

public void OnTriggerExit2D(Collider2D col)
{
    if(col.tag == "Energia")
    {
        entrou = false;
    }
}
}