using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GotSwallowedChecker : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        other.GetComponent<TargetValue>().gotSwallowed = true;
    }
}
