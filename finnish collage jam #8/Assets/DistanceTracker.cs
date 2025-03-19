using UnityEngine;
using UnityEngine.UI;

public class DistanceTracker : MonoBehaviour
{
    public Transform player; // Pelaajan auto
    public Text distanceText; // UI-teksti kilometreille
    private Vector3 startPosition;

    void Start()
    {
        startPosition = player.position;
    }

    void Update()
    {
        UpdateDistance();
    }

    void UpdateDistance()
    {
        float distance = Vector3.Distance(startPosition, player.position) / 1000f; // Muutetaan metreistä kilometreiksi
        distanceText.text = "Distance: " + distance.ToString("F2") + " km";
    }
}
