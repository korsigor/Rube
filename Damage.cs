using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    void OnTriggerStay2D(Collider2D other)
    {
        Move controller = other.GetComponent<Move>();

        if (controller != null)
        {
         controller.ChangeHealth(-10);
                
            
        }
    }
}
