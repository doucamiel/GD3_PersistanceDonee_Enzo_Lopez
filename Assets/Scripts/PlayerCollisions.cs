using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisions : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        ICollectible iCollect = other.GetComponent<Collectible>();
        if (iCollect != null)
        {
            iCollect.Collect();
            
        }

        ITalk talking = other.GetComponent<ITalk>();
        if (talking != null) 
        {   
            talking.Talk();
         
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        ITalk talking = collision.gameObject.GetComponent<ITalk>();
        if (talking != null) 
        {
            talking .Talk();    
        }
    }
}
