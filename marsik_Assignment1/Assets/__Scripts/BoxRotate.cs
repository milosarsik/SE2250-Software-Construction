using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxRotate : MonoBehaviour
{
    int randomRotationX;              // getting a random value for the x axis
    int randomRotationZ;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        randomRotationX = Random.Range(-5, 5);              // getting a random value for the x axis
        randomRotationZ = Random.Range(-3, 3);              // getting a random value for the y axis
    }

    private void OnMouseOver()
    {
        // checking if the user has left clicked the mouse
        if (Input.GetMouseButtonDown(0))
        {
            gameObject.transform.eulerAngles = new Vector3(randomRotationX, 0, randomRotationZ);        // changing the angle of the box to the random values
        }
    }
}
