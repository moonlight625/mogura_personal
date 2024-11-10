using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Camera : MonoBehaviour
{
    
    private float camMinx = -90f, camMaxx = 90f;
    private Quaternion cameraRot, characterRot;
    public GameObject cam;
    private float x, z;
    
    [SerializeField] private float camSensitivityX = 1.5f;
    [SerializeField] private float camSensitivityY = 1.5f;
    
    // Start is called before the first frame update
    void Start()
    {
        cameraRot = cam.transform.localRotation;
        characterRot = transform.localRotation;
    }

    // Update is called once per frame
    void Update()
    {
        //Camera
        float xRot = Input.GetAxis("Mouse X") * camSensitivityX;
        float yRot = Input.GetAxis("Mouse Y") * camSensitivityY;

        cameraRot *= Quaternion.Euler(-yRot, 0, 0);
        characterRot *= Quaternion.Euler(0, xRot, 0);

        cameraRot = ClampRotation(cameraRot);

        cam.transform.localRotation = cameraRot;
        transform.localRotation = characterRot;
    }
    
    public Quaternion ClampRotation(Quaternion q)
    {
        q.x /= q.w;
        q.y /= q.w;
        q.z /= q.w;
        q.w = 1f;

        float angleX = Mathf.Atan(q.x) * Mathf.Rad2Deg * 2f;
        angleX = Mathf.Clamp(angleX, camMinx, camMaxx);
        q.x = Mathf.Tan(angleX * Mathf.Deg2Rad * 0.5f);

        return q;
    }
    
    
}
