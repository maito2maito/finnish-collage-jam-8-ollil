using UnityEngine;
using TMPro;

public class DistanceTracker : MonoBehaviour
{
    public Transform car; // Ved� auton GameObject t�h�n Unityss�
    public TextMeshProUGUI distanceText; // Ved� TextMeshPro-teksti t�h�n Unityss�

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
                totalDistance -= distanceThisFrame; // V�henn� matkaa, jos auto menee taaksep�in
            }
            else
            {
                totalDistance += distanceThisFrame; // Lis�� matkaa, jos auto menee eteenp�in
            }

            lastPosition = car.position;

            if (distanceText != null)
            {
                distanceText.text = "Matka ajettu: " + Mathf.RoundToInt(totalDistance) + " m";
            }
        }
    }
}
