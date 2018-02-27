using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TooltipDisplay : MonoBehaviour {

    public GameObject face;
	// Update is called once per frame
	void Update () {
        if (Vector3.Distance(face.transform.position, transform.position) > .3)
        {
            this.gameObject.transform.GetChild(0).gameObject.active = false;
            this.gameObject.transform.GetChild(1).gameObject.active = false;
            this.gameObject.transform.GetChild(2).gameObject.active = false;
        }
        else
        {
            this.gameObject.transform.GetChild(0).gameObject.active = true;
            this.gameObject.transform.GetChild(1).gameObject.active = true;
            this.gameObject.transform.GetChild(2).gameObject.active = true;
        }
	}
}
