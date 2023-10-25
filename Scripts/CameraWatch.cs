using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraWatch : MonoBehaviour
{
    [SerializeField] private Camera _camera;
    [SerializeField] private float sensivity;
    public static GameObject playerGameObject;
    public static float xRotCurrent;
    public static float yRotCurrent;
    private float currentVelosityX;
    private float currentVelosityY;
    private float smoothTime = 0.1f;
    public static float xRot;
    public static float yRot;
    private void Awake()
    {
       // Cursor.visible = false;
    }
    private void Update()
    {    
       xRot += Input.GetAxis("Mouse X") * sensivity;
       yRot += Input.GetAxis("Mouse Y") * sensivity;
       yRot = Mathf.Clamp(yRot, -90, 90);
       xRotCurrent = Mathf.SmoothDamp(xRotCurrent, xRot, ref currentVelosityX, smoothTime);
       yRotCurrent = Mathf.SmoothDamp(yRotCurrent, yRot, ref currentVelosityY, smoothTime);
        if (GunMenu._nowFence)
        {
            playerGameObject.transform.rotation = Quaternion.Euler(0, xRotCurrent, 0f);
            _camera.transform.position = new Vector3(playerGameObject.transform.position.x, playerGameObject.transform.position.y, playerGameObject.transform.position.z);
            _camera.transform.rotation = Quaternion.Euler(-yRotCurrent, xRotCurrent, 0f); ;
        }
        if (GunMenu._nowFence == false)
        {
            playerGameObject.transform.rotation = Quaternion.Euler(-yRotCurrent, xRotCurrent, 0f);
            _camera.transform.rotation = Quaternion.Euler(-yRotCurrent + 0.1f, xRotCurrent + 0.15f, 0f); ;
            _camera.transform.position = new Vector3(playerGameObject.transform.position.x, playerGameObject.transform.position.y + 0.3f, playerGameObject.transform.position.z);
        }
    }
}
