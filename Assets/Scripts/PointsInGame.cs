using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PointsInGame : MonoBehaviour
{
    public TextMeshProUGUI pointText;

    void Start()
    {
        pointText.text = Point.pointAmount.ToString() + " points";
    }

    // Update is called once per frame
    void Update()
    {
        pointText.text = Point.pointAmount.ToString() + " points";
    }
}
