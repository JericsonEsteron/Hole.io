using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwallowTargets : HoleSize
{
    private void OnTriggerStay(Collider other)
    {
        if(other.CompareTag("Targets") && other.isTrigger == false)
        {
            if (other.GetComponent<TargetValue>().targetValue <= holeSize && other.GetComponent<TargetValue>().gotSwallowed == false)
            {
                holeSize += other.GetComponent<TargetValue>().targetValue;
                other.GetComponent<TargetValue>().gotSwallowed = true;
            }
        }
    }

    private void Update()
    {
        transform.localScale = new Vector3(holeSize, transform.localScale.y, holeSize);
    }
}
