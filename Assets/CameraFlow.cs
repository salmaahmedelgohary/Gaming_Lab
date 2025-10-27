using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CameraFlow : MonoBehaviour
{
    public Transform Target;
    public float CameraSpeed;
    public float minX, maxX;
    public float minY, maxY;

    void FixedUpdate()
    {
        if (Target != null)
        {
            Vector2 newCamPosition = Vector2.Lerp(transform.position, Target.position, Time.deltaTime * CameraSpeed);
            float ClampX = Mathf.Clamp(newCamPosition.x, minX, maxX);
            float ClampY = Mathf.Clamp(newCamPosition.y, minY, maxY);
            transform.position = new Vector3(ClampX, ClampY, -10f);
        }
    }
    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
