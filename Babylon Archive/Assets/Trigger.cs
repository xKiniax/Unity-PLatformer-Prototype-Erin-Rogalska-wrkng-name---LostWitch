using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
   public GameObject prefab;
   public GameObject spawn;

   private void OnTriggerEnter(Collider other)
   {
    if (other.gameObject.tag == "Player")
    {
        Debug.Log("hit");
        GameObject tmp = Instantiate(prefab) as GameObject; //can work
    }
   }
}
