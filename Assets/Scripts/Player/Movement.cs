using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Movement : MonoBehaviour
{
    [Header("Set-up Main Camera")]
    [SerializeField] Camera mainCamera;

    [SerializeField] LayerMask layerMask;

    private void FixedUpdate()
    {
        if (Input.GetMouseButton(0)) MoveToPosition();
    }

    void MoveToPosition()
    {
        bool hasHit = Physics.Raycast(RayOrigin(), out RaycastHit hit, layerMask);
        if (hasHit) MovePlayerTo(hit.point);
    }

    private Ray RayOrigin()
    {
        return mainCamera.ScreenPointToRay(Input.mousePosition);
    }

    private void MovePlayerTo(Vector3 destination)
    {
        GetComponent<NavMeshAgent>().destination = destination;
    }
}
