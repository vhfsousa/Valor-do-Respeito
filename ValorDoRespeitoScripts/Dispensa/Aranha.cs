using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aranha : MonoBehaviour
{
    [SerializeField] private GameObject aranha;
    [SerializeField] private float speed, maxY, minY;
    private bool desceu = true;

    void Update()
    {
        if(desceu == true)
        {
            aranha.transform.Translate(0, Time.deltaTime * -speed , 0);
        }
        if(aranha.transform.position.y <= minY)
        {
            desceu = false;
        }
        if(desceu == false)
        {
            aranha.transform.Translate(0 ,Time.deltaTime * speed ,0);
        }
        if(aranha.transform.position.y >= maxY)
        {
            desceu = true;
        }
    }
}
