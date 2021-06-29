using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovePoint : MonoBehaviour
{
    [SerializeField] private float speedX;
    [SerializeField] private GameObject maxWidth;
    [SerializeField] private GameObject minWidth;
    [SerializeField] private AudioSource bolinha;
    [SerializeField] private AudioClip bater;
    [SerializeField] private bool isAtMax;

    void Start()
    {
        isAtMax = true;
    }

    void Update()
    {
        Move();
    }

public void Move()
{
    if(isAtMax == true){
        transform.Translate (speedX * Time.deltaTime, 0 , 0);
        if(transform.position.x >= maxWidth.transform.position.x){
            isAtMax = false;
            bolinha.PlayOneShot(bater);
        }
        
    }

        if (isAtMax == false){
            transform.Translate (speedX * Time.deltaTime * -1, 0 , 0);
            if (transform.position.x <= minWidth.transform.position.x){
                isAtMax = true;
                bolinha.PlayOneShot(bater);
            }
    }
}
}