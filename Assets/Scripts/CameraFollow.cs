using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public GameObject follow;
    public Vector2 minCameraPos, maxCameraPos;
    public float smoothTime;

    private Vector2 velocity;

    // Update is called once per frame
    void FixedUpdate()
    {
        float positionX = Mathf.SmoothDamp(
            transform.position.x,
            follow.transform.position.x,
            ref velocity.x,
            smoothTime);
        float positionY = Mathf.SmoothDamp(
            transform.position.y,
            follow.transform.position.y,
            ref velocity.y,
            smoothTime);

        transform.position = new Vector3(
            Mathf.Clamp(positionX,minCameraPos.x,maxCameraPos.x),
            Mathf.Clamp(positionY, minCameraPos.y, maxCameraPos.y), 
            transform.position.z);

    }
}
