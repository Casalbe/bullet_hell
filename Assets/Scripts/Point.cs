using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Point : MonoBehaviour
{

    public static double pointAmount;
    public TextMeshProUGUI pointText;

    void Start()
    {
        pointText.text = pointAmount.ToString() + " points to spend";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
