using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetScore : MonoBehaviour
{
    public static float scoreValue = 0f;

    private void Update()
    {
        GetComponent<Text>().text = scoreValue.ToString();
    }
}
