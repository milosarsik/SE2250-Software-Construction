using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeReset : MonoBehaviour
{
    Vector3 originalPos;

    // Start is called before the first frame update
    void Start()
    {
        originalPos = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
    }

    // OnMouseOver() is called every frame while the mouse is over the object
    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(1))
        {
            gameObject.transform.position = originalPos;
        }
    }
}
