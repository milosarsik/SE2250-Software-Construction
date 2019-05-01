using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeReset : MonoBehaviour
{
    Vector3 originalPos;        // this will store the original position of the shape

    // Start is called before the first frame update
    void Start()
    {
        originalPos = gameObject.transform.position;            // getting the original position of the shape
    }

    // Update is called once per frame
    void Update()
    {
    }

    // OnMouseOver() is called every frame while the mouse is over the object
    private void OnMouseOver()
    {
        // checking if the user has right clicked the mouse
        if (Input.GetMouseButtonDown(1))
        {
            gameObject.transform.position = originalPos;            // setting the position of the object to the original position
        }
    }
}
