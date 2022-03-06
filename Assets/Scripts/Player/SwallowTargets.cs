using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwallowTargets : HoleSize
{
    private void OnTriggerStay(Collider other)
    {
        if(other.CompareTag("Targets") && other.isTrigger == false)
        {
            if (CanBeSwallowed(other) && other.GetComponent<TargetValue>().gotSwallowed == false)
            {
                holeSize += other.GetComponent<TargetValue>().targetValue;
                other.GetComponent<TargetValue>().gotSwallowed = true;

                SetScore.scoreValue += other.GetComponent<TargetValue>().targetValue * 100;

                // increasing Camera offset in relation to holesize
                CameraFollowPlayer.XCounter -= other.GetComponent<TargetValue>().targetValue;
                CameraFollowPlayer.YCounter += other.GetComponent<TargetValue>().targetValue;
            }
        }
    }

    bool CanBeSwallowed(Collider other)
    {
        if (other.GetType().ToString() == "BoxCollider")
        {
            // Implementing Offset for box objects
            // Since Box objects does not fit into the sphere objects even with equal scale
            return (other.transform.localScale.x < holeSize - 0.4f && other.transform.localScale.z < holeSize - 0.4f);
        }
        else
        {
            // Offset of other colliders
            return (other.transform.localScale.x < holeSize - 0.1f && other.transform.localScale.z < holeSize - 0.1f);

        }

    }

    private void Update()
    {
        transform.localScale = new Vector3(holeSize, transform.localScale.y, holeSize);
    }
}
