using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPadSpawner : MonoBehaviour
{
   public GameObject prefab;

   private void OnCollisionEnter(Collision col)
   {
    if (col.gameObject.tag == "Player")
    {
        gameObject.SetActive(false);
        GameObject tmp = Instantiate(prefab) as GameObject; //can work
    }
   }
}
