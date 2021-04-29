using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 5f;
    private float rotationSpeed = 100f; 
    private float horizontalInput;
    private float verticalInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * speed * -verticalInput * Time.deltaTime);
        transform.Rotate(Vector3.up * rotationSpeed * horizontalInput * Time.deltaTime);
    }
}
