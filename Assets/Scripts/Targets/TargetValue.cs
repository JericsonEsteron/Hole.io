using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetValue : MonoBehaviour
{
    [Header("Starting for 0.1 as the smallest")]
    public float targetValue = 0.1f;

    [HideInInspector] public bool gotSwallowed = false;

    [Header("Set-up PullDirection child gameobject and the Pull Speed")]
    [SerializeField] Transform pullDirection;
    [SerializeField] float pullSpeed;

    private void Update()
    {
        if (gotSwallowed)
        {
            GameObject field = GameObject.FindGameObjectWithTag("Field");
            Physics.IgnoreCollision(GetComponent<Collider>(), field.GetComponent<Collider>());
        }
    }
}
