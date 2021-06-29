using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlotEletrica : MonoBehaviour
{
public bool canDrop;

public void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "Piece")
        {
            canDrop = true;
        }
    }

public void OnTriggerExit2D(Collider2D col)
    {
        if(col.tag == "Piece")
        {
            canDrop = false;
        }
    }
}