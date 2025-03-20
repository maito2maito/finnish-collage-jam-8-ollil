using UnityEngine;

public class RearCameraFollow : MonoBehaviour
{
    public Transform car; // Auton transform
    public float smoothSpeed = 5f; // Kuinka nopeasti kamera seuraa
    public Vector3 offset = new Vector3(0, 2, -6); // Kameran oletuspaikka kauempana auton takana
    public float rotationDamping = 10f; // Lis‰‰ pehmeytt‰ ja nopeampaa k‰‰ntymist‰
    public float turnAngle = 20f; // Kuinka paljon kamera k‰‰ntyy vastakkaiseen suuntaan auton k‰‰nnˆss‰

    void LateUpdate()
    {
        if (car == null)
            return;

        // Tavoitepaikka kameralle auton suhteessa
        Vector3 desiredPosition = car.position + car.rotation * offset;
        transform.position = Vector3.Lerp(transform.position, desiredPosition, Time.deltaTime * smoothSpeed);

        // Laske lis‰kulma auton k‰‰ntymisen perusteella
        float turnOffset = -car.GetComponent<Rigidbody>().angularVelocity.y * turnAngle;
        Quaternion additionalRotation = Quaternion.Euler(0, turnOffset, 0);

        // Tavoiterotaatio, kamera katsoo auton suuntaan mutta lis‰‰ k‰‰ntymist‰
        Quaternion desiredRotation = Quaternion.LookRotation(car.position - transform.position) * additionalRotation;
        transform.rotation = Quaternion.Slerp(transform.rotation, desiredRotation, Time.deltaTime * rotationDamping);
    }
}