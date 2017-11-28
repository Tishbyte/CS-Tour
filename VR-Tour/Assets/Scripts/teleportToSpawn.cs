using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleportToSpawn : MonoBehaviour {
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            other.gameObject.transform.localPosition = new Vector3(-3.15f, 0.679f, -2.485f);
        }
    }
}