using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowTarget : MonoBehaviour
{
    [Header("Set-up Player Transform")]
    [SerializeField] Transform player;

    [Header("Set-up Camera position from player in X, Y and Z axes")]
    [SerializeField] float positionInX;
    [SerializeField] float positionInY;
    [SerializeField] float positionInZ;

    [Header("Set-up Camera rotation from player in X, Y and Z axes")]
    [SerializeField] float rotationInX;
    [SerializeField] float rotationInY;
    [SerializeField] float rotationInZ;

    private void LateUpdate()
    {
        Vector3 offset = new Vector3(positionInX, positionInY, positionInZ);
        Quaternion rotation = Quaternion.Euler(rotationInX, rotationInY, rotationInZ);

        Vector3 position = player.position + offset;
        transform.SetPositionAndRotation(position, rotation);
    }


}
