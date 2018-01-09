using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour
{
    private int speed;
    private Camera mainCamera;
    public GameObject shipRoof;
    // Use this for initialization
    void Start()
    {
        mainCamera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift))
            speed = 12;
        else
            speed = 8;
        if (Input.GetKey("up") || Input.GetKey("w"))
            this.transform.Translate(Vector3.forward * speed * Time.deltaTime);
        if (Input.GetKey("down") || Input.GetKey("s"))
            this.transform.Translate(Vector3.back * speed * Time.deltaTime);
        if (Input.GetKey("left") || Input.GetKey("a"))
            this.transform.Translate(Vector3.left * speed * Time.deltaTime);
        if (Input.GetKey("right") || Input.GetKey("d"))
            this.transform.Translate(Vector3.right * speed * Time.deltaTime);
        //Zoom in
        if (Input.GetAxis("Mouse ScrollWheel") > 0f)
        {
            if (mainCamera.orthographicSize > 5)
                mainCamera.orthographicSize -= Mathf.Round(mainCamera.orthographicSize / 3);
        }

        //Zoom out
        if (Input.GetAxis("Mouse ScrollWheel") < 0f)
        {
            if (mainCamera.orthographicSize < 100)
            {
                mainCamera.orthographicSize += Mathf.Round(mainCamera.orthographicSize / 3);
            }
        }
    }
}
