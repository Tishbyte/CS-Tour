using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatchPos : MonoBehaviour {

    public GameObject htcVive;
    public float addX, addY, addZ;
    public float RaddX, RaddY, RaddZ;

    // Update is called once per frame
    void Update () {
        htcVive.transform.position = new Vector3(this.transform.localPosition.x + addX, this.transform.localPosition.y + addY, this.transform.localPosition.z + addZ);

        //super spinny htcVive.transform.Rotate(this.transform.localRotation.x + RaddX, this.transform.localRotation.y + RaddY, this.transform.localRotation.z + RaddZ);

        //htcVive.transform.localEulerAngles = new Vector3(this.transform.localEulerAngles.x + RaddX, this.transform.localEulerAngles.y + RaddY, this.transform.localEulerAngles.z + RaddZ);
    }
}
