using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallPlat : MonoBehaviour
{
	public float fallTime = 0.5f;


	void OnCollisionEnter(Collision collision)
	{
		foreach (ContactPoint contact in collision.contacts)
		{
			//Debug.DrawRay(contact.point, contact.normal, Color.white);
			if (collision.gameObject.tag == "Player")
			{
				StartCoroutine(Fall(fallTime));
			}
		}
	}

IEnumerator Fall(float time)
{
    yield return new WaitForSeconds(time);
    // The object which this script is attached to
    // gets 100 added to its y position, make larger if needed
    transform.position = transform.position + new Vector3(0, 100, 0);
    // Wait for two seconds before moving the object back, change 2 into something else if needed
    yield return new WaitForSeconds(2);
    // Object is moved back into its originial position here by reducing the previously added amount
    transform.position = transform.position - new Vector3(0, 100, 0);
}

	/* IEnumerator Fall(float time)
	{
		yield return new WaitForSeconds(time);
		Destroy(gameObject);
	}

	IEnumerator Appear(float time)
	{
		yield return new WaitForSeconds(time);
		Destroy(gameObject);
	} */
}
