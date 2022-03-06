using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Camera))]
public class CameraFollowPlayer : MonoBehaviour
{
    [Header("Set-up Player Transform")]
    [SerializeField] Transform player;

    [Header("Set-up Camera position from player in X, Y and Z axes")]
    [SerializeField] float positionInX = -3.59f;
    [SerializeField] float positionInY = 2.95f;
    [SerializeField] float positionInZ;

    [Header("Set-up Camera rotation from player in X, Y and Z axes")]
    [SerializeField] float rotationInX = 38.49f;
    [SerializeField] float rotationInY = 90f;
    [SerializeField] float rotationInZ;

    // Increases based on HoleSize, Check SwallowTargets.cs
    public static float XCounter = 0;
    public static float YCounter = 0;

    private void Start()
    {
        XCounter = positionInX;
        YCounter = positionInY;
    }

    private void LateUpdate()
    {
        Vector3 offset = new Vector3(XCounter, YCounter, positionInZ);
        Quaternion rotation = Quaternion.Euler(rotationInX, rotationInY, rotationInZ);

        Vector3 position = player.position + offset;
        transform.SetPositionAndRotation(position, rotation);
    }


}
