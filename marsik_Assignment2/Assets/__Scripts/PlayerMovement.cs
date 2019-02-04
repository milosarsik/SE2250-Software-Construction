using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerMovement : MonoBehaviour
{
    // variables
    public Text scoreText;
    public float sphereSpeed;
    private int _score;

    // Start is called before the first frame update
    void Start()
    {
        _score = 0;
        SetScoreText();
    }

    // Update is called once per frame
    void Update()
    {
        float xSpeed = Input.GetAxis("Horizontal");
        float ySpeed = Input.GetAxis("Vertical");

        Rigidbody body = GetComponent<Rigidbody>();
        body.AddTorque(new Vector3(xSpeed, 0, ySpeed) * sphereSpeed * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other)
    {
        // comparing the tags
        if (other.gameObject.CompareTag("Blue Pick Up"))
        {
            other.gameObject.SetActive(false);

            _score += 100;

            SetScoreText();
        }
        else
        {
            other.gameObject.SetActive(false);

            _score += 50;

            SetScoreText();
        }
    }

    void SetScoreText()
    {
        scoreText.text = "Score: " + _score.ToString();
    }
}
