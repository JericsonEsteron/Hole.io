using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoleSize : MonoBehaviour
{
    [Header("Starting Hole Size, Recommended size is 1")]
    [SerializeField] float initialHoleSize = 1f;
    [HideInInspector] public float holeSize;

    private void Start()
    {
        holeSize = initialHoleSize;
        transform.localScale = new Vector3(initialHoleSize, transform.localScale.y, initialHoleSize);
    }
}
