using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalãoCollider : MonoBehaviour
{
    [SerializeField] private GameObject pensamento;
    [SerializeField] private GameObject player;
    
    void Start()
    {
        pensamento.SetActive(false);
    }

    void Update()
    {
        Balao();
    }

    public void Balao()
    {
        if(player.GetComponent<Player>().apareceBalao == true)
        {
            pensamento.SetActive(true);
        }
        else if(player.GetComponent<Player>().apareceBalao == false)
        {
            pensamento.SetActive(false);
        }
    }
}