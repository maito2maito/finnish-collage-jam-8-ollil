using UnityEngine;
using TMPro;

public class DistanceTracker : MonoBehaviour
{
    public Transform car; // Vedä auton GameObject tähän Unityssä
    public TextMeshProUGUI distanceText; // Vedä TextMeshPro-teksti tähän Unityssä

    private Vector3 lastPosition;
    private float totalDistance = 0f;

    void Start()
    {
        if (car != null)
        {
            lastPosition = car.position;
        }
    }

    void Update()
    {
        if (car != null)
        {
            float distanceThisFrame = Vector3.Distance(car.position, lastPosition);

            Vector3 direction = car.position - lastPosition;
            if (Vector3.Dot(car.forward, direction) < 0)
            {
                totalDistance -= distanceThisFrame; // Vähennä matkaa, jos auto menee taaksepäin
            }
            else
            {
                totalDistance += distanceThisFrame; // Lisää matkaa, jos auto menee eteenpäin
            }

            lastPosition = car.position;

            if (distanceText != null)
            {
                distanceText.text = "Matka ajettu: " + Mathf.RoundToInt(totalDistance) + " m";
            }
        }
    }
}
