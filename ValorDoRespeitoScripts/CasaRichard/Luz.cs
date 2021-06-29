using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Luz : MonoBehaviour
{
    [SerializeField] private float cooldown, limite1, tempoAcesa, tempoApagada, limite2;
    [SerializeField] private GameObject luz;
    private bool isCooldown;

    void Start()
    {
        
    }

    void Update()
    {
        if(isCooldown == false)
        {
            limite1 += Time.deltaTime * cooldown;
        }
        if(limite1 >= tempoAcesa)
        {
            luz.SetActive(false);
            isCooldown = true;
            limite1 = 0;
        }
        if(isCooldown == true)
        {
            limite2 += Time.deltaTime * cooldown;
        }
        if(limite2 >= tempoApagada)
        {
            luz.SetActive(true);
            isCooldown = false;
            limite2 = 0;
        }
    }
}