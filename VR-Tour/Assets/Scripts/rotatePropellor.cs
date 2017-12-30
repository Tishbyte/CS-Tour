using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotatePropellor : MonoBehaviour {

	// Update is called once per frame
	void Update () {
        transform.Rotate(Vector3.back * Time.deltaTime * 10);
    }
}
