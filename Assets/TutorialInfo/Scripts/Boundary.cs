using UnityEngine;
using System.Collections;

public class byBoundary: MonoBehaviour
{
	void OnTriggerExit(Collider other)
	{
		Destroy(other.gameObject);
	}
}