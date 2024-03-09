using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PointsManager : MonoBehaviour
{
    private int points = 0;
    public TMP_Text pointsText;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Target"))
        {
            points += 10;
            UpdatePointsUI();
        }
    }

    void UpdatePointsUI()
    {
        if (pointsText != null)
        {
            pointsText.text = "Points: " + points.ToString();

            if (points > 50)
            {
                pointsText.text += "\nCongratulations!";
            }
        }
        else
        {
            Debug.LogWarning("Points Text UI element is not assigned in the PointsManager script.");
        }
    }
}
