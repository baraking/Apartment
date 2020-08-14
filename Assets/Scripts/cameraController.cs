using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraController : MonoBehaviour
{
    [Range(0.1f,3)]
    [SerializeField]private float cameraSpeed=1f;

    [Range(0.01f, 45)]
    [SerializeField] private float angularSpeed = 0.1f;

    private float rotationAngle;
    void Start()
    {
        //cameraSpeed = 1f;
        rotationAngle = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");
        transform.Translate(Vector3.forward* cameraSpeed*Time.deltaTime);

        rotationAngle += mouseX * angularSpeed;

        transform.Rotate(new Vector3(0,rotationAngle));
    }
}
