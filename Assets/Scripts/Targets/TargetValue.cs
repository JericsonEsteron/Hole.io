using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteAlways]
public class TargetValue : MonoBehaviour
{
    
    [Header("Recommended 0.1 as the smallest")]
    public float targetValue = 0.1f;

    [HideInInspector] public bool gotSwallowed = false;

    private void Update()
    {
        if (gotSwallowed)
        {
            GameObject field = GameObject.FindGameObjectWithTag("Field");
            Physics.IgnoreCollision(GetComponent<Collider>(), field.GetComponent<Collider>(), true);
        }
    }
}
