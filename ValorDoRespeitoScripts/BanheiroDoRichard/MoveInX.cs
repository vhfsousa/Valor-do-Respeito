using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveInX : MonoBehaviour
{
    [SerializeField] private float speedX;
    [SerializeField] private GameObject maxWidth;
    [SerializeField] private GameObject minWidth;
    private bool isAtMax;

    void Start()
    {
        isAtMax = true;
    }

    void Update()
    {
        if(isAtMax == true){
            transform.Translate (speedX * Time.deltaTime, 0 , 0);
                if(transform.position.x >= maxWidth.transform.position.x){
                isAtMax = false;
                }
        }

        if (isAtMax == false){
            transform.Translate (speedX * Time.deltaTime * -1, 0 , 0);
                if (transform.position.x <= minWidth.transform.position.x){
                isAtMax = true;
                }
        }
    }
}