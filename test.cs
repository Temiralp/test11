using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    CameraController cameracontroller;
    public GameObject mermi;
    void Start()
    {
        cameracontroller = FindObjectOfType<CameraController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(mermi, transform.position, Quaternion.identity);
        }

    }
}
