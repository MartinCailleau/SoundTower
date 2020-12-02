using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitalCameraControl : MonoBehaviour {

    public Transform pivot;
    public float translationSpeed = 10;
    public float rotationSpeed = 30;

    private Vector3 previousMousePosition;
    private Vector3 mouseDirection;

    private void Start()
    {
        previousMousePosition = Input.mousePosition;
    }

    void Update () {

        if (Input.GetMouseButton(0))
        {
            mouseDirection = Vector3.Lerp(mouseDirection,(Input.mousePosition - previousMousePosition).normalized,1*Time.deltaTime);
            Debug.Log(mouseDirection);
            transform.RotateAround(pivot.position, Vector3.up, mouseDirection.x * Time.deltaTime * rotationSpeed);

            previousMousePosition = Input.mousePosition;
        }

        transform.RotateAround(pivot.position, Vector3.up, Input.GetAxis("Horizontal") * Time.deltaTime * rotationSpeed);
        transform.Translate(0, Input.GetAxis("Vertical") * Time.deltaTime * translationSpeed, 0 );
    }
}
