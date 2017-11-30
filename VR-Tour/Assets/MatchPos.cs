using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatchPos : MonoBehaviour {

    public GameObject htcVive;

	// Update is called once per frame
	void Update () {
        htcVive.transform.position = new Vector3(this.transform.localPosition.x + 11.5f, this.transform.localPosition.y + 26, this.transform.localPosition.z);
        htcVive.transform.localRotation = this.transform.localRotation;
    }
}
