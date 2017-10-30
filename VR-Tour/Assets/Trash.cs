using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Trash : MonoBehaviour {

    public Text txt;

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Trash")
        {
            Destroy(collision.gameObject);
            txt.gameObject.GetComponent<Text>().text = (int.Parse(txt.gameObject.GetComponent<Text>().text) + 1).ToString();
        }
    }
}
