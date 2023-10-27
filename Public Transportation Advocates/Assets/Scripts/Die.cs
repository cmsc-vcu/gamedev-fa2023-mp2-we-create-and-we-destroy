using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Die : MonoBehaviour
{
    

   private void OnTriggerEnter(Collider collision)
   {
     if (collision.gameObject.CompareTag("Car"))
     {
            Destroy(collision.gameObject);
     }
   }


}
