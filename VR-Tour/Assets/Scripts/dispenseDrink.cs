using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dispenseDrink : MonoBehaviour {

    public GameObject prefab;

    public void spawnDrink()
    {
        Instantiate(prefab);
    }
}