using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePickUp : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        // this will continuosly rotate our object because we are in the Update() method
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime * 1.5f);
    }
}
