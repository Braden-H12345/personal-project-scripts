using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mousescript : MonoBehaviour
{
    //Script to control mouse movement in first person

    // Start is called before the first frame update

    public float sens = 100f;
    public Transform playerModel;

    private float xRotate = 0;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * sens * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * sens * Time.deltaTime;

        xRotate -= mouseY;
        xRotate = Mathf.Clamp(xRotate, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotate, 0f, 0f);
        playerModel.Rotate(Vector3.up * mouseX);
    }
}
