using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyItems : MonoBehaviour {

    public GameObject particle;

	void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Interactable")
        {
            //GameObject particles = Instantiate(particle, other.transform.position, new Quaternion(0, 0, 90, 0));
            Destroy(other);
            //Destroy(particles, 2f);
        }
    }
}
