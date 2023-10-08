using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public float speed;
    private Transform cam;
    // Start is called before the first frame update
    void Start()
    {
        cam = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.A) && cam.position.x > -30)
        {
            cam.position = new Vector3(cam.position.x - speed * Time.deltaTime, cam.position.y, cam.position.z);
        }
        if (Input.GetKey(KeyCode.S) && cam.position.y > 0)
        {
            cam.position = new Vector3(cam.position.x, cam.position.y - speed * Time.deltaTime, cam.position.z);
        }
        if (Input.GetKey(KeyCode.D) && cam.position.x < 26)
        {
            cam.position = new Vector3(cam.position.x + speed * Time.deltaTime, cam.position.y, cam.position.z);
        }
        if (Input.GetKey(KeyCode.W) && cam.position.y < 25)
        {
            cam.position = new Vector3(cam.position.x, cam.position.y + speed * Time.deltaTime, cam.position.z);
        }
    }
}
