using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public float xDist;
    public float yDist;
    public float zDist;
    private Vector3 CamPos;
    private GameObject CameraMain;
    public float cameraYLookDisp, cameraXLookDisp;
    private Vector3 cameraLookAt;

    void Start()
    {
        CameraMain = GameObject.FindGameObjectWithTag("MainCamera");
    }

    // Update is called once per frame
    void Update()
    {
        CamPos = new Vector3(xDist + gameObject.transform.position.x, yDist + gameObject.transform.position.y, zDist + gameObject.transform.position.z);
        cameraLookAt = new Vector3(cameraXLookDisp, cameraYLookDisp, 0) + gameObject.transform.position;
        CameraMain.transform.position = CamPos;
        CameraMain.transform.LookAt(cameraLookAt);
    }
}
